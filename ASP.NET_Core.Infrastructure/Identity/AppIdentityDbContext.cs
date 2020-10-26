using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ASP.NET_Core.Infrastructure.Identity.IdentityConfigurations;

namespace ASP.NET_Core.Infrastructure.Identity
{
    public class AppIdentityDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int, IdentityUserClaim<int>, ApplicationUserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
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
            builder.ApplyConfiguration(new ApplicationUserConfiguration());

            builder.ApplyConfiguration(new ApplicationRoleConfiguration());

            builder.Entity<IdentityUserClaim<int>>(b =>
            {
                b.ToTable("ElcUserClaims");
            });

            builder.Entity<IdentityUserLogin<int>>(b =>
            {
                b.ToTable("ElcUserLogins");
            });

            builder.Entity<IdentityUserToken<int>>(b =>
            {
                b.ToTable("ElcUserTokens");
            });

            builder.Entity<IdentityRoleClaim<int>>(b =>
            {
                b.ToTable("ElcRoleClaims");
            });

            builder.Entity<ApplicationUserRole>(b =>
            {
                b.ToTable("ElcUserRoles");
            });
        }
    }

}
