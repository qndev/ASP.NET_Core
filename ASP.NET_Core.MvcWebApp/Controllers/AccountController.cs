using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core.MvcWebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult ManagementProfile()
        {
            return View("ManagementProfile");
        }

        public IActionResult Login()
        {
            return View("Login");
        }

        public IActionResult ChangePassword()
        {
            return View("ChangePassword");
        }

        public IActionResult ForgotPassword()
        {
            return View("ForgotPassword");
        }

        public IActionResult ResetPassword()
        {
            return View("ResetPassword");
        }

        public IActionResult RegisterAccount()
        {
            return View("RegisterAccount");
        }
    }
}
