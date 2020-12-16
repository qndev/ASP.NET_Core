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

namespace ASP.NET_Core.MvcWebApp.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
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
            return View(await PaginatedList<Faq>.GetPaginatedListAsync(_dbContext.Faqs.AsNoTracking(), pageNumber ?? Constants.Pagging.DEFAULT_PAGE_INDEX, Constants.Pagging.PAGE_SIZE));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Faq>> Details(int id)
        {
            var faqDetail = await _faqService.GetAsync(id);
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
        public async Task<IActionResult> Edit(int id)
        {
            var faqDetail = await _faqService.GetAsync(id);
            if (faqDetail == null)
            {
                return NotFound();
            }
            var faqViewModel = _createFaqViewModelFromFaq.CreateMapping(faqDetail);
            return View(faqViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<Faq>> Update(int id, [FromForm] FaqViewModel faqViewModel)
        {
            Faq faq = new Faq
            {
                Question = faqViewModel.Question,
                Answer = faqViewModel.Answer
            };
            var updatedResult = await _faqService.UpdateAsync(faq, id);
            if (updatedResult.Item2)
            {
                return Ok(faq);
            }
            return BadRequest();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogInformation(id.ToString());
            if (await _faqService.DeleteAsync(id))
            {
                return RedirectToAction("Index");
            }
            return View("Error");
        }
    }
}
