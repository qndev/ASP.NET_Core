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

            ConfigureServices(services);
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages().AddRazorRuntimeCompilation();
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
                    name: "reset_password",
                    pattern: "{controller=Account}/{action=RegisterAccount}");
            });
        }
    }
}
