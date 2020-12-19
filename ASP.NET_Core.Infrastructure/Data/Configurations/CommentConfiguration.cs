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
            builder.HasKey(c => new { c.Id, c.CommentId });
            builder.Property(c => c.CommentId)
                .HasColumnType("varchar(256)");
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();
            builder.HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => new { c.Id, c.UserId });
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
