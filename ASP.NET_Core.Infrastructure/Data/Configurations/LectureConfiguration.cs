using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities.LectureAggregate;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class LectureConfiguration : BaseEntityConfiguration<Lecture>
    {
        public override void Configure(EntityTypeBuilder<Lecture> builder)
        {
            base.Configure(builder);
            builder.ToTable("Lectures");
            builder.HasMany(l => l.Exercises)
                .WithOne(e => e.Lecture);
            builder.HasMany(l => l.CourseLectures)
                .WithOne(cl => cl.Lecture);
        }
    }
}
