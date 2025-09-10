using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tekus.ManagementProvider.Domain.Entities.ProvidersServices;

namespace Tekus.ManagementProvider.Infrastructure.Configurations
{
    public class ProviderServiceConfiguration : IEntityTypeConfiguration<ProviderService>
    {
        public void Configure(EntityTypeBuilder<ProviderService> builder)
        {
            builder.ToTable("ProviderServices");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Provider)
                   .WithMany(x => x.ProviderServices)
                   .HasForeignKey(x => x.ProviderId);

            builder.HasOne(x => x.Service)
                   .WithMany(x => x.ProviderServices)
                   .HasForeignKey(x => x.ServiceId);
        }
    }
}
