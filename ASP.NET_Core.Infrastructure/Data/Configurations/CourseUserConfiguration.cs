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
            builder.HasOne(cu => cu.Course)
                .WithMany(c => c.CourseUsers)
                .HasForeignKey(cu => cu.CourseId);
            builder.HasOne(cu => cu.User)
                .WithMany(u => u.CourseUsers)
                .HasForeignKey(cu => cu.UserId);
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
