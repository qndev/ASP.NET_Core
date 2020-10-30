using System.Threading.Tasks;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IIdentityService
    {
        Task<bool> LoginAsync(string email, string password, bool rememberMe);
    }
}
