using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ASP.NET_Core.ApplicationCore.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using ASP.NET_Core.ApplicationCore.Entities;
using ASP.NET_Core.MvcWebApp.Models.FaqViewModels;
using ASP.NET_Core.MvcWebApp.Interfaces;
using ASP.NET_Core.MvcWebApp.Models;
using ASP.NET_Core.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Core.ApplicationCore.Constants;
using System.Linq;

namespace ASP.NET_Core.MvcWebApp.Controllers
{
    [Authorize]
    public class FaqController : BaseController
    {
        private readonly InfrastructureContext _dbContext;
        private readonly IFaqService _faqService;
        private readonly IRepository<Faq, int> _repository;
        private readonly ICurrentUserService _currentUserService;
        private readonly IMappingEntitiesAndViewModels<FaqViewModel, Faq> _createFaqFromViewwModel;
        private readonly IMappingEntitiesAndViewModels<Faq, FaqViewModel> _createFaqViewModelFromFaq;
        private readonly ILogger _logger;
        public FaqController(
            InfrastructureContext dbContext,
            IFaqService faqService,
            IRepository<Faq, int> repository,
            ICurrentUserService currentUserService,
            IMappingEntitiesAndViewModels<FaqViewModel, Faq> createFaqFromViewwModel,
            IMappingEntitiesAndViewModels<Faq, FaqViewModel> createFaqViewModelFromFaq,
            ILogger<FaqController> logger
        )
        {
            _dbContext = dbContext;
            _faqService = faqService;
            _repository = repository;
            _currentUserService = currentUserService;
            _createFaqFromViewwModel = createFaqFromViewwModel;
            _createFaqViewModelFromFaq = createFaqViewModelFromFaq;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? pageNumber)
        {
            return View(await PaginatedList<Faq>.GetPaginatedListAsync(
                                                    _dbContext.Faqs
                                                        .Include(u => u.User)
                                                        .Select(f => new Faq
                                                        {
                                                            FaqId = f.FaqId,
                                                            Question = f.Question,
                                                            Answer = f.Answer,
                                                            User = new User
                                                            {
                                                                LastName = f.User.LastName,
                                                                Email = f.User.Email
                                                            }
                                                        }).AsNoTracking(),
                                                    pageNumber ?? Constants.Pagging.DEFAULT_PAGE_INDEX,
                                                    Constants.Pagging.PAGE_SIZE));
        }

        [HttpGet]
        public async Task<ActionResult<Faq>> Details(string id)
        {
            var faqDetail = await _faqService.GetAsync(id, Constants.EntityKey.FAQ_ID);
            if (faqDetail == null)
            {
                _logger.LogInformation("Not found");
                return NotFound();
            }
            return View(faqDetail);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var UserId = _currentUserService.UserId;
            _logger.LogInformation(UserId.ToString());
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<Faq>> Create([FromForm] FaqViewModel faqViewModel)
        {
            if (faqViewModel == null)
            {
                return NoContent();
            }
            if (ModelState.IsValid)
            {
                // var faq = FaqViewModel.MapFaqViewModelToEntity(faqViewModel);
                var faq = _createFaqFromViewwModel.CreateMapping(faqViewModel);
                var createdResult = await _faqService.CreateAsync(faq);
                if (createdResult.Item2)
                {
                    return Ok("Successfully created Faq!");
                }
                return BadRequest("Something went wrong when create Faq.");
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var faqDetail = await _faqService.GetAsync(id, Constants.EntityKey.FAQ_ID);
            if (faqDetail == null)
            {
                return NotFound();
            }
            var faqViewModel = _createFaqViewModelFromFaq.CreateMapping(faqDetail);
            return View(faqViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromForm] FaqViewModel faqViewModel)
        {
            if (faqViewModel.FaqId == null)
            {
                return NotFound("Notfound");
            }
            Faq faq = FaqViewModel.MapFaqViewModelToEntity(faqViewModel);
            // var updatedResult = await _faqService.UpdateAsync(faq, faqViewModel, Constants.EntityKey.FAQ_ID);
            // var updatedResult = await _faqService.UpdateAsync(faq, Constants.EntityKey.FAQ_ID, faq => faq.Question, faq => faq.Answer);
            // var updatedResult = await _faqService.UpdateAsync(faq, Constants.EntityKey.FAQ_ID);
            var updatedResult = await _faqService.UpdateAsync(faq);
            if (updatedResult.Item2)
            {
                return Ok(updatedResult.Item1);
            }
            return BadRequest();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string faqId)
        {
            _logger.LogInformation(faqId);
            if (await _faqService.DeleteAsync(faqId, Constants.EntityKey.FAQ_ID))
            {
                return RedirectToAction("Index");
            }
            return View("Error");
        }
    }
}
