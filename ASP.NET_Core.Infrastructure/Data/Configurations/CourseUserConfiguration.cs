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
        }
    }
}
