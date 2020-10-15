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
            // builder.HasMany(u => u.Faqs);
            // builder.HasMany(u => u.News);
            // builder.HasMany(u => u.Subjects);
            // builder.HasMany(u => u.Comments);
            // builder.HasMany(u => u.CourseUsers);
            // builder.HasMany(u => u.AnswerUsers);
        }
    }
}
