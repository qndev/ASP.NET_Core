using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using ASP.NET_Core.ApplicationCore.Interfaces;

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
    }
}
