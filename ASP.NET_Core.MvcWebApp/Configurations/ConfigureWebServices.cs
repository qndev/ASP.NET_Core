using Microsoft.Extensions.DependencyInjection;
using ASP.NET_Core.ApplicationCore.Interfaces;
using ASP.NET_Core.MvcWebApp.Services;
using ASP.NET_Core.MvcWebApp.Interfaces;
using ASP.NET_Core.MvcWebApp.Models.FaqViewModels;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.MvcWebApp.Configurations
{
    public static class ConfigureWebServices
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services)
        {
            services.AddSingleton<ICurrentUserService, CurrentUserService>();
            services.AddScoped(typeof(IMappingEntitiesAndViewModels<FaqViewModel,Faq>), typeof(FaqViewModelService));
            services.AddScoped(typeof(IMappingEntitiesAndViewModels<Faq,FaqViewModel>), typeof(FaqViewModelService));

            return services;
        }
    }
}