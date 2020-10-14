using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities.LectureAggregate;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.ToTable("exercises", InfrastructureContext.DEFAULT_SCHEMA);
        }
    }
}
