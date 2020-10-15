using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities.LectureAggregate;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class AnswerConfiguration : BaseEntityConfiguration<Answer>
    {
        public override void Configure(EntityTypeBuilder<Answer> builder)
        {
            base.Configure(builder);
            builder.ToTable("Answers", InfrastructureContext.DEFAULT_SCHEMA);
            // builder.Property(b => b.QuestionId)
            //     .HasColumnName("question_id");
            // builder.Property(b => b.Content)
            //     .HasColumnName("content");
            // builder.Property(b => b.CorrectFlag)
            //     .HasColumnName("correct_flag");
            // builder.Property(b => b.OrderNumber)
            //     .HasColumnName("order_number");
        }
    }
}
