using Microsoft.Extensions.DependencyInjection;
using ASP.NET_Core.ApplicationCore.Interfaces;
using ASP.NET_Core.Infrastructure.Data.Repositories;
using ASP.NET_Core.ApplicationCore.Services;
using ASP.NET_Core.ApplicationCore.Entities;
using ASP.NET_Core.ApplicationCore.Validators;
using FluentValidation;

namespace ASP.NET_Core.MvcWebApp.Configurations
{
    public static class ConfigureApplicationCoreServices
    {
        public static IServiceCollection AddApplicationCoreServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
            services.AddScoped<IFaqService, FaqService>();
            services.AddScoped<ISubjectService, SubjectService>();

            // Fluent Validation
            services.AddTransient<IValidator<Faq>, FaqValidator>();

            return services;
        }
    }
}
