using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities.LectureAggregate;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class QuestionConfiguration : BaseEntityConfiguration<Question>
    {
        public override void Configure(EntityTypeBuilder<Question> builder)
        {
            base.Configure(builder);
            builder.ToTable("Questions");
            builder.HasOne(q => q.Exercise)
                .WithMany(e => e.Questions)
                .HasForeignKey(q => q.ExerciseId);
            builder.HasMany(q => q.Answers)
                .WithOne(a => a.Question);
        }
    }
}
