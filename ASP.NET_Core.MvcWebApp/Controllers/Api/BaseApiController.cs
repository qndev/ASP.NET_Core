using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core.MvcWebApp.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class BaseApiController : ControllerBase
    { }
}
