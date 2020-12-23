using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core.MvcWebApp.Controllers
{
    public class SubjectController : BaseController
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
