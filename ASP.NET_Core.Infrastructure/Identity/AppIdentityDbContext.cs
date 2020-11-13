using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ASP.NET_Core.Infrastructure.Identity.IdentityConfigurations;

namespace ASP.NET_Core.Infrastructure.Identity
{
    public class AppIdentityDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int, ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin,
        ApplicationRoleClaim, ApplicationUserToken>
    {
        private const string UserTable = "ElcUsers";
        private const string RoleTable = "ElcRoles";
        private const string UserRoleTable = "ElcUserRoles";
        private const string UserClaimTable = "ElcUserClaims";
        private const string UserLoginTable = "ElcUserLogins";
        private const string RoleClaimTable = "ElcRoleClaims";
        private const string UserTokenTable = "ElcUserTokens";

        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            // builder.ApplyConfiguration(new AppIdentityConfiguration<ApplicationUser>("AppUsers"));
            builder.ApplyConfiguration(new ApplicationUserConfiguration(UserTable));
            builder.ApplyConfiguration(new ApplicationRoleConfiguration(RoleTable));
            builder.ApplyConfiguration(new ApplicationUserRoleConfiguration(UserRoleTable));
            builder.ApplyConfiguration(new ApplicationUserClaimConfiguration(UserClaimTable));
            builder.ApplyConfiguration(new ApplicationUserLoginConfiguration(UserLoginTable));
            builder.ApplyConfiguration(new ApplicationRoleClaimConfiguration(RoleClaimTable));
            builder.ApplyConfiguration(new ApplicationUserTokenConfiguration(UserTokenTable));
        }
    }

}
