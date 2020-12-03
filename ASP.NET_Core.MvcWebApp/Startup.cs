using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FluentValidation.AspNetCore;
using ASP.NET_Core.MvcWebApp.Configurations;

namespace ASP.NET_Core.MvcWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Infrastructure services.
            services.AddInfrastructureServices(Configuration);

            // Cookie settings
            services.AddCookieSettings();

            // Application services.
            services.AddApplicationCoreServices();

            // Web services.
            services.AddWebServices();

            //
            services.AddControllersWithViews();
            services.AddControllers();
            services.AddHttpContextAccessor();
            services.AddRazorPages().AddRazorRuntimeCompilation();
            // AutoMapper
            // var mapperConfiguration = new AutoMapperConfiguration();
            // services.AddSingleton(mapperConfiguration.CreateMapper());
            services.AddMvc().AddFluentValidation();
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

            //app.UseEndpointRoutingApplication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
