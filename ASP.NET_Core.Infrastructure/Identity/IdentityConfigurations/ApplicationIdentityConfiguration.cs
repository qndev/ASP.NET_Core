using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASP.NET_Core.Infrastructure.Identity.IdentityConfigurations
{
    public class ApplicationIdentityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : class
    {
        private string IdentityTable { get; set; }
        public ApplicationIdentityConfiguration(string tableName)
        {
            this.IdentityTable = tableName;
        }
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(IdentityTable);
        }
    }

    public class ApplicationUserConfiguration : ApplicationIdentityConfiguration<ApplicationUser>
    {
        public ApplicationUserConfiguration(string userTableName) 
            : base(userTableName)
        {
        }
        public override void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            base.Configure(builder);
            // Each User can have many UserClaims
            builder.HasMany(e => e.Claims)
                .WithOne(e => e.User)
                .HasForeignKey(uc => uc.UserId)
                .IsRequired();

            // Each User can have many UserLogins
            builder.HasMany(e => e.Logins)
                .WithOne(e => e.User)
                .HasForeignKey(ul => ul.UserId)
                .IsRequired();

            // Each User can have many UserTokens
            builder.HasMany(e => e.Tokens)
                .WithOne(e => e.User)
                .HasForeignKey(ut => ut.UserId)
                .IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany(e => e.UserRoles)
                .WithOne(e => e.User)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
        }
    }

    public class ApplicationRoleConfiguration : ApplicationIdentityConfiguration<ApplicationRole>
    {
        public ApplicationRoleConfiguration(string roleTableName) 
            : base(roleTableName)
        {
        }
        public override void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            base.Configure(builder);
            builder.Property(r => r.Description)
                .HasColumnType("varchar(256)");
            // Each Role can have many entries in the UserRole join table
            builder.HasMany(e => e.UserRoles)
                .WithOne(e => e.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany(e => e.RoleClaims)
                .WithOne(e => e.Role)
                .HasForeignKey(rc => rc.RoleId)
                .IsRequired();
        }
    }

    public class ApplicationUserRoleConfiguration : ApplicationIdentityConfiguration<ApplicationUserRole>
    {
        public ApplicationUserRoleConfiguration(string userRoleTableName)
            : base(userRoleTableName)
        {
        }
        public override void Configure(EntityTypeBuilder<ApplicationUserRole> builder)
        {
            base.Configure(builder);
        }
    }

    public class ApplicationUserClaimConfiguration : ApplicationIdentityConfiguration<ApplicationUserClaim>
    {
        public ApplicationUserClaimConfiguration(string userClaimTableName)
            : base(userClaimTableName)
        {
        }
        public override void Configure(EntityTypeBuilder<ApplicationUserClaim> builder)
        {
            base.Configure(builder);
        }
    }

    public class ApplicationUserLoginConfiguration : ApplicationIdentityConfiguration<ApplicationUserLogin>
    {
        public ApplicationUserLoginConfiguration(string userLoginTableName)
            : base(userLoginTableName)
        {
        }
        public override void Configure(EntityTypeBuilder<ApplicationUserLogin> builder)
        {
            base.Configure(builder);
        }
    }

    public class ApplicationRoleClaimConfiguration : ApplicationIdentityConfiguration<ApplicationRoleClaim>
    {
        public ApplicationRoleClaimConfiguration(string roleClaimTableName)
            : base(roleClaimTableName)
        {
        }
        public override void Configure(EntityTypeBuilder<ApplicationRoleClaim> builder)
        {
            base.Configure(builder);
        }
    }

    public class ApplicationUserTokenConfiguration : ApplicationIdentityConfiguration<ApplicationUserToken>
    {
        public ApplicationUserTokenConfiguration(string userTokenTableName)
            : base(userTokenTableName)
        {
        }
        public override void Configure(EntityTypeBuilder<ApplicationUserToken> builder)
        {
            base.Configure(builder);
        }
    }
}
