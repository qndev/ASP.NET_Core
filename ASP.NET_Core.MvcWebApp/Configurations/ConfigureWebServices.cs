using Microsoft.Extensions.DependencyInjection;
using ASP.NET_Core.ApplicationCore.Interfaces;
using ASP.NET_Core.MvcWebApp.Services;

namespace ASP.NET_Core.MvcWebApp.Configurations
{
    public static class ConfigureWebServices
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services)
        {
            services.AddSingleton<ICurrentUserService, CurrentUserService>();

            return services;
        }
    }
}