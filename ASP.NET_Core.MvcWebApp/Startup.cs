using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using ASP.NET_Core.Infrastructure.Data;
using ASP.NET_Core.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using ASP.NET_Core.ApplicationCore.Interfaces;
using ASP.NET_Core.Infrastructure.Services;

namespace ASP.NET_Core.MvcWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureDevelopmentServices(IServiceCollection services)
        {
            // use real database
            ConfigureProductionServices(services);
        }

        public void ConfigureProductionServices(IServiceCollection services)
        {
            services.AddDbContext<InfrastructureContext>(c =>
                c.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
            // Identity DbContext
            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("IdentityConnection")));
            ConfigureServices(services);
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();
            // Identity settings
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
            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                // If the LoginPath isn't set, ASP.NET Core defaults 
                // the path to /Account/Login.
                options.LoginPath = "/Account/Login";
                // If the AccessDeniedPath isn't set, ASP.NET Core defaults 
                // the path to /Account/AccessDenied.
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddScoped<IIdentityService, IdentityService>();
            services.Configure<MailKitServiceOptions>(Configuration.GetSection(MailKitServiceOptions.MailKitService));
            services.AddControllersWithViews();
            services.AddRazorPages().AddRazorRuntimeCompilation();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                System.Console.WriteLine("Helllo");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "list_users",
                    pattern: "{controller=User}/{action=Index}");
                endpoints.MapControllerRoute(
                    name: "user_profile",
                    pattern: "{controller=Account}/{action=ManagementProfile}/{id?}");
                endpoints.MapControllerRoute(
                    name: "change_password",
                    pattern: "{controller=Account}/{action=ChangePassword}/{id?}");
                endpoints.MapControllerRoute(
                    name: "account_login",
                    pattern: "{controller=Account}/{action=Login}");
                endpoints.MapControllerRoute(
                    name: "forgot_password",
                    pattern: "{controller=Account}/{action=ForgotPassword}");
                endpoints.MapControllerRoute(
                    name: "reset_password",
                    pattern: "{controller=Account}/{action=ResetPassword}");
                endpoints.MapControllerRoute(
                    name: "register_account",
                    pattern: "{controller=Account}/{action=RegisterAccount}");
            });
        }
    }
}
