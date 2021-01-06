using System.Transactions;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using ASP.NET_Core.ApplicationCore.Entities;
using ASP.NET_Core.ApplicationCore.Constants;
using ASP.NET_Core.ApplicationCore.Interfaces;

namespace ASP.NET_Core.Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService<User, string> _userService;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;
        private readonly IDateTime _dateTime;

        public IdentityService(
            UserManager<ApplicationUser> userManager,
            IUserService<User, string> userService,
            SignInManager<ApplicationUser> signInManager,
            ILogger<IdentityService> logger,
            IDateTime dateTime
        )
        {
            _userManager = userManager;
            _userService = userService;
            _signInManager = signInManager;
            _logger = logger;
            _dateTime = dateTime;
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
            if (user == null)
            {
                responseMessage = ResponseMessage.USER_NOT_FOUND;
                return (responseMessage, ResponseMessage.ERROR_STATUS);
            }
            if (!(await _userManager.IsEmailConfirmedAsync(user)))
            {
                responseMessage = ResponseMessage.EMAIL_NOT_CONFIRMED;
                _logger.LogInformation("User has not been verified!");
                return (responseMessage, ResponseMessage.ERROR_STATUS);
            }
            responseMessage = await _userManager.GeneratePasswordResetTokenAsync(user);
            return (responseMessage + "" + user.Id, ResponseMessage.SUCCESS_STATUS);
        }

        public async Task<string> ResetPasswordAsync(string email, string token, string newPassword)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return ResponseMessage.USER_NOT_FOUND;
            }
            var result = await _userManager.ResetPasswordAsync(user, token, newPassword);
            if (result.Succeeded)
            {
                return ResponseMessage.SUCCESS_MESSAGE;
            }
            return ResponseMessage.ERROR_MESSAGE;
        }

        public async Task<(string, int)> RegisterAccountAsync(string userName, string email, string password)
        {
            using (var transactionScope = new TransactionScope(
                TransactionScopeOption.Required,
                new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted },
                TransactionScopeAsyncFlowOption.Enabled))
            {
                var code = "";
                var createdUser = false;
                try
                {
                    var user = new ApplicationUser { UserName = userName, Email = email };
                    var result = await _userManager.CreateAsync(user, password);
                    if (result.Succeeded)
                    {
                        code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        _logger.LogInformation("User created a new account with password.");
                        User userEntity = new User
                        {
                            UserId = user.Id,
                            Email = user.Email,
                            FirstName = "N/A",
                            LastName = "N/A",
                            CreationTime = _dateTime.Now
                        };
                        _logger.LogInformation("Created Identity User with Id: " + userEntity.UserId);
                        var createdUserEntity = _userService.CreateUserAsync(userEntity);
                        if (createdUserEntity.Result.Item2)
                        {
                            createdUser = true;
                        }
                    }
                    if (createdUser)
                    {
                        transactionScope.Complete();
                        return (code + "SEPARATOR" + user.Id, ResponseMessage.SUCCESS_STATUS);
                    }
                }
                catch (System.Exception ex)
                {
                    _logger.LogWarning(ex.Message);
                }

                return (ResponseMessage.ERROR_MESSAGE, ResponseMessage.ERROR_STATUS);
            }
        }

        public async Task<string> ConfirmEmailAsync(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return ResponseMessage.USER_NOT_FOUND;
            }
            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                return ResponseMessage.SUCCESS_MESSAGE;
            }
            return ResponseMessage.ERROR_MESSAGE; 
        }
    }
}
