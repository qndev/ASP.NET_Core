using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class CourseUserConfiguration : IEntityTypeConfiguration<CourseUser>
    {
        public void Configure(EntityTypeBuilder<CourseUser> builder)
        {
            builder.ToTable("course_user", InfrastructureContext.DEFAULT_SCHEMA);
        }
    }
}
