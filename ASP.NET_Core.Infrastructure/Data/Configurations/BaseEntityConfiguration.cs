using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity<int> , IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(b => b.CreationTime)
                .HasColumnType("timestamp");
            builder.Property(b => b.DeletionTime)
                .HasColumnType("timestamp");
            builder.Property(b => b.LastModificationTime)
                .HasColumnType("timestamp");
        }
    }
}
