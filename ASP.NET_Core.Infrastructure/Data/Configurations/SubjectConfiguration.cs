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
            builder.HasOne(s => s.User)
                .WithMany(u => u.Subjects)
                .HasForeignKey(s => s.CreatedBy);
            builder.HasMany(s => s.Courses)
                .WithOne(c => c.Subject);
            builder.Property(s => s.Name)
                .HasColumnType("varchar(255)")
                .IsRequired();
            builder.Property(l => l.CreatedBy)
                .IsRequired();
        }
    }
}
