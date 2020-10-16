using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class FaqConfiguration : BaseEntityConfiguration<Faq>
    {
        public override void Configure(EntityTypeBuilder<Faq> builder)
        {
            base.Configure(builder);
            builder.ToTable("Faqs");
            builder.HasOne(f => f.User)
                .WithMany(u => u.Faqs)
                .HasForeignKey(f => f.CreatedBy);
            builder.Property(f => f.Answer)
                .HasColumnType("text")
                .IsRequired();
            builder.Property(f => f.Question)
                .HasColumnType("text")
                .IsRequired();
        }
    }
}
