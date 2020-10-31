using System.Threading.Tasks;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IIdentityService
    {
        Task<bool> LoginAsync(string email, string password, bool rememberMe);
        Task LogoutAsync();
        Task<bool> ChangePasswordAsync(string email, string currentPassword, string newPassword);
        Task<(string, int)> ForgotPasswordAsync(string email);
    }
}
