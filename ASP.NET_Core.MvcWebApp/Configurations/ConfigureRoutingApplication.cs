using Microsoft.AspNetCore.Builder;

namespace ASP.NET_Core.MvcWebApp.Configurations
{
    public  static class ConfigureRoutingApplication
    {
        public static IApplicationBuilder UseEndpointRoutingApplication(this IApplicationBuilder app)
        {
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
                endpoints.MapControllerRoute(
                    name: "faq_detail",
                    pattern: "{controller=Faq}/{action=GetFaqDetails}/{id}");
            });

            return app;
        }
    }
}
