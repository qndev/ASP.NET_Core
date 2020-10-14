using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities.LectureAggregate;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class LectureConfiguration : IEntityTypeConfiguration<Lecture>
    {
        public void Configure(EntityTypeBuilder<Lecture> builder)
        {
            builder.ToTable("lectures", InfrastructureContext.DEFAULT_SCHEMA);
        }
    }
}
