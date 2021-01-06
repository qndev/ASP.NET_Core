using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities.CourseAggregate;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class SubjectConfiguration : BaseEntityConfiguration<Subject>
    {
        public override void Configure(EntityTypeBuilder<Subject> builder)
        {
            base.Configure(builder);
            builder.ToTable("Subjects");
            builder.HasKey(s => s.SubjectId);
            builder.Property(s => s.SubjectId)
                .HasColumnType("varchar(256)");
            builder.HasOne(s => s.User)
                .WithMany(u => u.Subjects)
                .HasForeignKey(s => s.UserId);
            builder.HasMany(s => s.Courses)
                .WithOne(c => c.Subject);
            builder.Property(s => s.Name)
                .HasColumnType("varchar(256)")
                .IsRequired();
            builder.Property(s => s.ModifiedBy)
                .HasColumnType("varchar(256)")
                .IsRequired(false);
        }
    }
}
