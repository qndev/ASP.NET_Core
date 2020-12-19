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
            builder.HasKey(f => new { f.Id, f.FaqId });
            builder.Property(f => f.FaqId)
                .HasColumnType("varchar(256)");
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();
            builder.HasOne(f => f.User)
                .WithMany(u => u.Faqs)
                .HasForeignKey(f => new { f.Id, f.UserId });
            builder.Property(f => f.Answer)
                .HasColumnType("text")
                .IsRequired();
            builder.Property(f => f.Question)
                .HasColumnType("text")
                .IsRequired();
            builder.Property(f => f.ModifiedBy)
                .HasColumnType("varchar(256)")
                .IsRequired(false);
        }
    }
}
