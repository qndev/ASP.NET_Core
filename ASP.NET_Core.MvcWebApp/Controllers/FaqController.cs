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
    public class FaqController : BaseApiController
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
        [HttpGet]
        [AllowAnonymous]
        [Route("[controller]/[action]/{id}")]
        public async Task<ActionResult<FaqDto>> GetFaqDetail(int faqId)
        {
            var faqDetail = await _faqService.GetAsync(faqId);
            if (faqDetail == null)
            {
                _logger.LogInformation("test");
                return NotFound();
            }
            return Ok(faqDetail);
        }
    }
}
