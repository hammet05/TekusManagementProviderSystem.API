using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tekus.ManagementProvider.Domain.Entities.Services;

namespace Tekus.ManagementProvider.Infrastructure.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Services");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ServiceName).HasMaxLength(200).IsRequired()
                                                .HasConversion(
                                                      name => name!.value,
                                                      value => new ServiceName(value)
                                                ); ;

            builder.Property(x => x.HourlyRateUsd).HasColumnType("decimal(18,2)");

            //builder.HasMany(x => x.Countries)
            //       .WithOne(x => x.Service)
            //       .HasForeignKey(x => x.ServiceId);
        }
    }
}
