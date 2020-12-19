using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class , IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(a => a.CreationTime)
                .HasColumnType("timestamp");
            builder.Property(a => a.DeletionTime)
                .HasColumnType("timestamp");
            builder.Property(a => a.LastModificationTime)
                .HasColumnType("timestamp");
        }
    }
}
