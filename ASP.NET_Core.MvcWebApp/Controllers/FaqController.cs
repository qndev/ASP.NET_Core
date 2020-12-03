using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ASP.NET_Core.MvcWebApp.Controllers.Api;
using ASP.NET_Core.ApplicationCore.Interfaces;
using ASP.NET_Core.ApplicationCore.Dtos.Faq;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.MvcWebApp.Controllers
{
    [Route("[controller]/[action]")]
    public class FaqController : BaseController
    {
        private readonly IFaqService _faqService;
        private readonly ILogger _logger;
        public FaqController(
            IFaqService faqService,
            ILogger<FaqController> logger
        )
        {
            _faqService = faqService;
            _logger = logger;
        }
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<Faq>> GetFaqDetails(int id)
        {
            var faqDetail = await _faqService.GetAsync(id);
            if (faqDetail == null)
            {
                _logger.LogInformation("Not found");
                return NotFound();
            }
            return Ok(faqDetail);
        }

        [HttpPost]
        public async Task<ActionResult<Faq>> CreateFaq([FromBody] Faq faq)
        {
            if (faq == null)
            {
                return NoContent();
            }
            var createdResult = await _faqService.CreateAsync(faq);
            if (createdResult.Item2)
            {
                return Ok(faq);
            }
            return BadRequest();
        }
    }
}
