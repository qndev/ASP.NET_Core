using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ASP.NET_Core.MvcWebApp.Models.AccountViewModels;
using Microsoft.Extensions.Logging;
using ASP.NET_Core.ApplicationCore.Interfaces;
using ASP.NET_Core.Infrastructure.Identity;
using Microsoft.AspNetCore.Http;
using ASP.NET_Core.ApplicationCore.Constants;

namespace ASP.NET_Core.MvcWebApp.Controllers
{
    [Authorize]
    public class AccountController : BaseController
    {
        //private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IIdentityService _identityService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private  readonly  ICurrentUserService _currentUserService;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;

        public AccountController(
            //IHttpContextAccessor httpContextAccessor,
            IIdentityService identityService,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            SignInManager<ApplicationUser> signInManager,
            ICurrentUserService currentUserService,
            IEmailSender emailSender,
            ILogger<AccountController> logger)
        {
            //_httpContextAccessor = httpContextAccessor;
            _identityService = identityService;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _currentUserService = currentUserService;
            _emailSender = emailSender;
            _logger = logger;
        }
        public IActionResult ManagementProfile()
        {
            return View("ManagementProfile");
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View("Login");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                if (await _identityService.LoginAsync(model.Email, model.Password, model.RememberMe))
                {
                    return RedirectToLocal(returnUrl);
                }
                ModelState.AddModelError(string.Empty, "Something went wrong! Please verify your email address and login again.");
                return View(model);
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _identityService.LogoutAsync();
            return RedirectToAction(nameof(AccountController.Login), "Account");
        }

        [HttpGet]
        public IActionResult ChangePassword(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View("ChangePassword");
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model, string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                //var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
                //_logger.LogInformation(userName);
                var currentUserEmail = _currentUserService.UserEmail;
                if (model.Email == currentUserEmail)
                {
                    if (await _identityService.ChangePasswordAsync(model.Email, model.CurrentPassword, model.NewPassword))
                    {
                        return RedirectToLocal("/Account/ChangePassword");
                    }
                    return View("404");
                }
                return View("403");
            }

            return View("Error");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View("ForgotPassword");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _identityService.ForgotPasswordAsync(model.Email);
                // var respone = result.Result;

                if (result.Item1.Equals(ResponseMessage.USER_NOT_FOUND))
                {
                    return View("404");
                }
                if (result.Item1.Equals(ResponseMessage.EMAIL_NOT_CONFIRMED))
                {
                    return View("VerifyEmail");
                }
                var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = result.Item2, code = result.Item1 }, protocol: HttpContext.Request.Scheme);
                await _emailSender.SendEmailAsync(model.Email, "Reset Password",
                   "Please reset your password by clicking here: <a href=\"" + callbackUrl + "\">link</a>");
                return View("ForgotPasswordConfirmation");
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string code = null)
        {
            return code == null ? View("Error") : View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var resetPasswordResult = await _identityService.ResetPasswordAsync(model.Email, model.Code, model.Password);
            if (resetPasswordResult.Equals(ResponseMessage.USER_NOT_FOUND))
            {
                return View("Error");
            }
            if (resetPasswordResult.Equals(ResponseMessage.SUCCESS_MESSAGE))
            {
                return RedirectToAction(nameof(AccountController.ResetPasswordConfirmation), "Account");
            }
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult RegisterAccount(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View("RegisterAccount");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterAccount(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var registerAccountResult = await _identityService.RegisterAccountAsync(model.Email, model.Email, model.Password);
                if (registerAccountResult.Item1.Equals(ResponseMessage.SUCCESS_MESSAGE))
                {
                    var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = registerAccountResult.Item2, code = registerAccountResult.Item1 }, protocol: HttpContext.Request.Scheme);
                    await _emailSender.SendEmailAsync(model.Email, "Confirm your account",
                        "Please confirm your account by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");
                    // await _signInManager.SignInAsync(user, isPersistent: false);
                    _logger.LogInformation("User created a new account with password.");
                    return RedirectToLocal("/Account/Login");
                }
                _logger.LogInformation(registerAccountResult.Item1);
                return View("Error");
                // AddErrors(result);
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var confirmEmailResult = await _identityService.ConfirmEmailAsync(userId, code);
            if (confirmEmailResult.Equals(ResponseMessage.USER_NOT_FOUND))
            {
                return View("Error");
            }
            if (confirmEmailResult.Equals(ResponseMessage.SUCCESS_MESSAGE))
            {
                return View("ConfirmEmail");
            }
            return View("Error");
        }

        #region Helpers

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        #endregion
    }
}
