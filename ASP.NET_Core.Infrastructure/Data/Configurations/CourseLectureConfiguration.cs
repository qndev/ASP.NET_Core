using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class CourseLectureConfiguration : IEntityTypeConfiguration<CourseLecture>
    {
        public void Configure(EntityTypeBuilder<CourseLecture> builder)
        {
            builder.ToTable("course_lecture", InfrastructureContext.DEFAULT_SCHEMA);
        }
    }
}
