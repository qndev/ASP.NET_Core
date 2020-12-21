using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities.CourseAggregate;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class CourseConfiguration : BaseEntityConfiguration<Course>
    {
        public override void Configure(EntityTypeBuilder<Course> builder)
        {
            base.Configure(builder);
            builder.ToTable("Courses");
            builder.HasKey(c => c.CourseId);
            builder.Property(c => c.CourseId)
                .HasColumnType("varchar(256)");
            builder.HasOne(c => c.Subject)
                .WithMany(s => s.Courses)
                .HasForeignKey(c => c.SubjectId);
            builder.HasMany(c => c.CourseLectures)
                .WithOne(cl => cl.Course);
            builder.HasMany(c => c.CourseUsers)
                .WithOne(cu => cu.Course);
            builder.Property(c => c.Code)
                .HasColumnType("varchar(50)")
                .IsRequired();
            builder.Property(c => c.Name)
                .HasColumnType("varchar(256)")
                .IsRequired();
            builder.Property(c => c.Description)
                .HasColumnType("text")
                .HasDefaultValue(null);
            builder.Property(c => c.StartDate)
                .HasColumnType("date")
                .IsRequired();
            builder.Property(c => c.EndDate)
                .HasColumnType("date")
                .IsRequired();
            builder.Property(c => c.Resources)
                .HasColumnType("text")
                .HasDefaultValue(null);
            builder.Property(c => c.Price)
                .HasColumnType("decimal(10, 2)")
                .HasDefaultValue(0);
            builder.Property(c => c.ImageFile)
                .HasColumnType("varchar(256)")
                .IsRequired(false);
            builder.Property(c => c.Status)
                .HasDefaultValue(0);
            builder.Property(c => c.UserId)
                .IsRequired();
        }
    }
}
