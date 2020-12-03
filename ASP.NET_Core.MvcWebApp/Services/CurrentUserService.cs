using  ASP.NET_Core.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace ASP.NET_Core.MvcWebApp.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string UserEmail => _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Email);
    }
}
