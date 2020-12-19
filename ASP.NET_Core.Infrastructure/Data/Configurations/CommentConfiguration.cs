using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class CommentConfiguration : BaseEntityConfiguration<Comment>
    {
        public override void Configure(EntityTypeBuilder<Comment> builder)
        {
            base.Configure(builder);
            builder.ToTable("Comments");
            builder.HasKey(c => c.CommentId);
            builder.Property(c => c.CommentId)
                .HasColumnType("varchar(256)");
            builder.HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId);
            builder.Property(c => c.CommentContent)
                .HasColumnType("text")
                .IsRequired();
            builder.Property(c => c.CourseId)
                .IsRequired();
            builder.Property(c => c.LectureId)
                .IsRequired();
        }
    }
}
