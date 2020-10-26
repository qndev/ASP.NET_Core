using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.ToTable("Users");
            builder.HasMany(u => u.Faqs)
                .WithOne(f => f.User);
            builder.HasMany(u => u.News)
                .WithOne(n => n.User);
            builder.HasMany(u => u.Subjects)
                .WithOne(s => s.User);
            builder.HasMany(u => u.Comments)
                .WithOne(c => c.User);
            builder.HasMany(u => u.CourseUsers)
                .WithOne(cu => cu.User);
            builder.HasMany(u => u.AnswerUsers)
                .WithOne(au => au.User);
            builder.Property(u => u.IdentityUserId)
                .IsRequired();
            builder.Property(u => u.FirstName)
                .HasColumnType("varchar(50)")
                .IsRequired();
            builder.Property(u => u.LastName)
                .HasColumnType("varchar(50)")
                .IsRequired();
            builder.Property(u => u.Phone)
                .HasColumnType("varchar(25)")
                .IsRequired(false);
            builder.Property(u => u.Gender)
                .HasDefaultValue(0);
            builder.Property(u => u.ImageUrl)
                .HasColumnType("varchar(25)")
                .IsRequired(false);
        }
    }
}
