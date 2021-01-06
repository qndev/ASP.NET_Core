using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core.MvcWebApp.Controllers
{
    public class UserController : BaseController
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
