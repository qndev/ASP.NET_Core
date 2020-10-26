using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASP.NET_Core.Infrastructure.Identity.IdentityConfigurations
{
    public class AppIdentityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class
    {
        private string identityTablename;
        public AppIdentityConfiguration(string tableName)
        {
            identityTablename = tableName;
        }
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(identityTablename);
        }
    }
}
