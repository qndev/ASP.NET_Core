using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ASP.NET_Core.ApplicationCore.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using ASP.NET_Core.ApplicationCore.Entities;
using ASP.NET_Core.MvcWebApp.Models.FaqViewModels;

namespace ASP.NET_Core.MvcWebApp.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class FaqController : BaseController
    {
        private readonly IFaqService _faqService;
        private readonly ICurrentUserService _currentUserService;
        private readonly ILogger _logger;
        public FaqController(
            IFaqService faqService,
            ICurrentUserService currentUserService,
            ILogger<FaqController> logger
        )
        {
            _faqService = faqService;
            _currentUserService = currentUserService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _faqService.GetAllAsyn());
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
                Faq faq = new Faq
                {
                    Question = faqViewModel.Question,
                    Answer = faqViewModel.Answer,
                    CreatedBy = _currentUserService.UserId,
                    ModifiedBy = _currentUserService.UserId,
                    CreationTime = DateTime.Now
                };
                var createdResult = await _faqService.CreateAsync(faq);
                if (createdResult.Item2)
                {
                    return Ok(faq);
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
            FaqViewModel faqViewModel = new FaqViewModel
            {
                Answer = faqDetail.Answer,
                Question = faqDetail.Question
            };
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
