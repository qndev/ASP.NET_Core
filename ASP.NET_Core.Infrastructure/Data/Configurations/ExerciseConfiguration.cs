using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities.LectureAggregate;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class ExerciseConfiguration : BaseEntityConfiguration<Exercise>
    {
        public override void Configure(EntityTypeBuilder<Exercise> builder)
        {
            base.Configure(builder);
            builder.ToTable("Exercises");
            builder.HasOne(e => e.Lecture)
                .WithMany(l => l.Exercises)
                .HasForeignKey(e => e.LectureId);
            builder.HasMany(e => e.Questions)
                .WithOne(q => q.Exercise);
            builder.Property(e => e.Title)
                .HasColumnType("text")
                .IsRequired();
            builder.Property(e => e.Description)
                .HasColumnType("text")
                .IsRequired(false);
            builder.Property(e => e.OrderNumber)
                .IsRequired();
        }
    }
}
