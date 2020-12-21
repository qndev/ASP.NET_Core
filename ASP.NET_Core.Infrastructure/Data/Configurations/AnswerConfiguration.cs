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
            builder.ToTable("Answers");
            builder.HasKey(a => a.AnswerId);
            builder.Property(a => a.AnswerId)
                .HasColumnType("varchar(256)");
            builder.HasOne(a => a.Question)
                .WithMany(q => q.Answers)
                .HasForeignKey(a => a.QuestionId);
            builder.HasMany(a => a.AnswerUsers)
                .WithOne(au => au.Answer);
            builder.Property(a => a.Content)
                .IsRequired();
            builder.Property(a => a.CorrectFlag)
                .IsRequired();
            builder.Property(a => a.OrderNumber)
                .HasColumnType("tinyint(4)")
                .IsRequired();
        }
    }
}
