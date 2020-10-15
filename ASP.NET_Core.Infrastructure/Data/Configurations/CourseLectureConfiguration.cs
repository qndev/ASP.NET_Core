using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class CourseLectureConfiguration : BaseEntityConfiguration<CourseLecture>
    {
        public override void Configure(EntityTypeBuilder<CourseLecture> builder)
        {
            builder.ToTable("CourseLecture", InfrastructureContext.DEFAULT_SCHEMA);
        }
    }
}
