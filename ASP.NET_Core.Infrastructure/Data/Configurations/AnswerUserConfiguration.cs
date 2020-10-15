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
        }
    }
}
