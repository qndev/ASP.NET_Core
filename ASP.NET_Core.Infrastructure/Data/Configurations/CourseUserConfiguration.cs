using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class CourseUserConfiguration : BaseEntityConfiguration<CourseUser>
    {
        public override void Configure(EntityTypeBuilder<CourseUser> builder)
        {
            base.Configure(builder);
            builder.ToTable("CourseUser");
            builder.HasKey(cu => new { cu.Id, cu.CourseUserId });
            builder.Property(cu => cu.CourseUserId)
                .HasColumnType("varchar(256)");
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();
            builder.HasOne(cu => cu.Course)
                .WithMany(c => c.CourseUsers)
                .HasForeignKey(cu => new { cu.Id, cu.CourseId });
            builder.HasOne(cu => cu.User)
                .WithMany(u => u.CourseUsers)
                .HasForeignKey(cu => new { cu.Id, cu.UserId });
            builder.Property(cu => cu.OrderStatus)
                .HasColumnType("tinyint(4)")
                .IsRequired();
            builder.Property(cu => cu.OrderDateTime)
                .HasColumnType("timestamp")
                .IsRequired();
            builder.Property(cu => cu.PaymentDateTime)
                .HasColumnType("timestamp");
        }
    }
}
