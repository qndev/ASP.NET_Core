using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core.MvcWebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
