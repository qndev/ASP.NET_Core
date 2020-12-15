using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using ASP.NET_Core.ApplicationCore.Interfaces;
using ASP.NET_Core.Infrastructure.Services;
using ASP.NET_Core.Infrastructure.Identity;
using ASP.NET_Core.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core.MvcWebApp.Configurations
{
    public static class ConfigureInfrastructureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<InfrastructureContext>(c =>
                c.UseMySql(configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseMySql(configuration.GetConnectionString("IdentityConnection")));
            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                // Default SignIn settings.
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;

                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 6;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = true;
            });
            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<MailKitServiceOptions>(configuration.GetSection(MailKitServiceOptions.MailKitService));
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddTransient<IDateTime, DateTimeService>();

            return services;
        }
    }
}
