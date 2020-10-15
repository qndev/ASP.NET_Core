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
            builder.HasOne(c => c.Subject)
                .WithMany(s => s.Courses)
                .HasForeignKey(c => c.SubjectId);
            builder.HasMany(c => c.CourseLectures)
                .WithOne(cl => cl.Course);
            builder.HasMany(c => c.CourseUsers)
                .WithOne(cu => cu.Course);
        }
    }
}
