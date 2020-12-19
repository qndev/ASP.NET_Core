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
            builder.HasKey(q => new { q.Id, q.QuestionId });
            builder.Property(q => q.QuestionId)
                .HasColumnType("varchar(256)");
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();
            builder.HasOne(q => q.Exercise)
                .WithMany(e => e.Questions)
                .HasForeignKey(q => new { q.Id, q.ExerciseId });
            builder.HasMany(q => q.Answers)
                .WithOne(a => a.Question);
            builder.Property(q => q.Content)
                .HasColumnType("text")
                .IsRequired();
            builder.Property(q => q.Description)
                .HasColumnType("text")
                .IsRequired();
            builder.Property(q => q.OrderNumber)
                .IsRequired();
        }
    }
}
