using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.Infrastructure.Data.Configurations
{
    public class FaqConfiguration : IEntityTypeConfiguration<Faq>
    {
        public void Configure(EntityTypeBuilder<Faq> builder)
        {
            builder.ToTable("faqs", InfrastructureContext.DEFAULT_SCHEMA);
        }
    }
}
