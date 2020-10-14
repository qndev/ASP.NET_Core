using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class AnswerUserConfiguration : IEntityTypeConfiguration<AnswerUser>
    {
        public void Configure(EntityTypeBuilder<AnswerUser> builder)
        {
            builder.ToTable("answer_user", InfrastructureContext.DEFAULT_SCHEMA);
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
