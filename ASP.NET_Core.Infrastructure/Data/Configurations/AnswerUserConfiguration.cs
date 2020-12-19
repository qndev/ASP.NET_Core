using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class AnswerUserConfiguration : BaseEntityConfiguration<AnswerUser>
    {
        public override void Configure(EntityTypeBuilder<AnswerUser> builder)
        {
            base.Configure(builder);
            builder.ToTable("AnswerUser");
            builder.HasKey(au => au.AnswerUserId);
            builder.Property(au => au.AnswerUserId)
                .HasColumnType("varchar(256)");
            builder.HasOne(au => au.Answer)
                .WithMany(a => a.AnswerUsers)
                .HasForeignKey(au => au.AnswerId);
            builder.HasOne(au => au.User)
                .WithMany(u => u.AnswerUsers)
                .HasForeignKey(au => au.UserId);;
            builder.Property(au => au.CourseId)
                .IsRequired();
            builder.Property(au => au.LectureId)
                .IsRequired();
            builder.Property(au => au.QuestionId)
                .IsRequired();
        }
    }
}
