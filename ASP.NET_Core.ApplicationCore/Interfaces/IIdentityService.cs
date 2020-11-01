using System.Threading.Tasks;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IIdentityService
    {
        Task<bool> LoginAsync(string email, string password, bool rememberMe);
        Task LogoutAsync();
        Task<bool> ChangePasswordAsync(string email, string currentPassword, string newPassword);
        Task<(string, int)> ForgotPasswordAsync(string email);
        Task<string> ResetPasswordAsync(string email, string token, string newPassword);
        Task<(string, int)> RegisterAccountAsync(string userName, string email, string pasword);
        Task<string> ConfirmEmailAsync(string userId, string token);
    }
}
