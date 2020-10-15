using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();
            builder.Property(a => a.CreationTime)
                .HasColumnType("timestamp")
                .HasDefaultValueSql("getdate()");
            builder.Property(a => a.DeletionTime)
                .HasColumnType("timestamp");
            builder.Property(a => a.LastModificationTime)
                .HasColumnType("timestamp");
        }
    }
}
