using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities.LectureAggregate;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class LectureConfiguration : BaseEntityConfiguration<Lecture>
    {
        public override void Configure(EntityTypeBuilder<Lecture> builder)
        {
            builder.ToTable("Lectures", InfrastructureContext.DEFAULT_SCHEMA);
        }
    }
}
