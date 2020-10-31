using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using ASP.NET_Core.ApplicationCore.Interfaces;
using ASP.NET_Core.ApplicationCore.Constants;

namespace ASP.NET_Core.Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;
        public IdentityService(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<IdentityService> logger
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }
        public async Task<bool> LoginAsync(string email, string password, bool rememberMe = false)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                _logger.LogInformation("Exist user email");
                if (!await _userManager.IsEmailConfirmedAsync(user))
                {
                    _logger.LogInformation("User has not been verified!");
                    return false;
                }
            }
            _logger.LogInformation("User has been verified!");
            var result = await _signInManager.PasswordSignInAsync(email, password, rememberMe, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                _logger.LogInformation(1, "User logged in.");
                return true;
            }
            if (result.IsLockedOut)
            {
                _logger.LogWarning(2, "User account locked out.");
                return false;
            }
            _logger.LogWarning(2, "Invalid login attempt.");
            return false;
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
        }

        public async Task<bool> ChangePasswordAsync(string email, string currentPassword, string newPassword)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                var result = await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
                if (result.Succeeded)
                {
                    _logger.LogInformation("Changed Password!");
                    return true;
                }
                _logger.LogInformation("Something went wrong!");
                return false;
            }
            _logger.LogInformation("User not found!");
            return false;
        }

        public async Task<(string, int)> ForgotPasswordAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            string responseMessage = "";
            int userId = user.Id;
            if (user == null)
            {
                responseMessage = ResponseMessage.USER_NOT_FOUND;
                return (responseMessage, userId);
            }
            if (!(await _userManager.IsEmailConfirmedAsync(user)))
            {
                responseMessage = ResponseMessage.EMAIL_NOT_CONFIRMED;
                _logger.LogInformation("User has not been verified!");
                return (responseMessage, userId);
            }
            responseMessage = await _userManager.GeneratePasswordResetTokenAsync(user);
            return (responseMessage, userId);
        }
    }
}
