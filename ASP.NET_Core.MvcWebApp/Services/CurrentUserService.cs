using System;
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

        public int UserId => Convert.ToInt32(_httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier));
        public string UserEmail => _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Email);
        public bool UserLoggedIn => _httpContextAccessor.HttpContext.User.Identity.IsAuthenticated;
    }
}
