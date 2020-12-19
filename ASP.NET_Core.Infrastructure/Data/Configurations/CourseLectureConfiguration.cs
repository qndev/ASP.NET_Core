using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class CourseLectureConfiguration : BaseEntityConfiguration<CourseLecture>
    {
        public override void Configure(EntityTypeBuilder<CourseLecture> builder)
        {
            base.Configure(builder);
            builder.ToTable("CourseLecture");
            builder.HasKey(cl => new { cl.Id, cl.CourseLectureId });
            builder.Property(cl => cl.CourseLectureId)
                .HasColumnType("varchar(256)");
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();
            builder.HasOne(cl => cl.Course)
                .WithMany(c => c.CourseLectures)
                .HasForeignKey(cl => new { cl.Id, cl.CourseId });
            builder.HasOne(cl => cl.Lecture)
                .WithMany(l => l.CourseLectures)
                .HasForeignKey(cl => new { cl.Id, cl.LectureId });
        }
    }
}
