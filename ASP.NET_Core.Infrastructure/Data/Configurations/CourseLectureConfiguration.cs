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
        }
    }
}
