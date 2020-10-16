using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class NewsConfiguration : BaseEntityConfiguration<News>
    {
        public override void Configure(EntityTypeBuilder<News> builder)
        {
            base.Configure(builder);
            builder.ToTable("News");
            builder.HasOne(n => n.User)
                .WithMany(u => u.News)
                .HasForeignKey(f => f.CreatedBy);
            builder.Property(n => n.Title)
                .HasColumnType("text")
                .IsRequired();
            builder.Property(n => n.Content)
                .HasColumnType("text")
                .IsRequired();
            builder.Property(l => l.CreatedBy)
                .IsRequired();
            builder.Property(l => l.ModifiedBy)
                .IsRequired();
        }
    }
}
