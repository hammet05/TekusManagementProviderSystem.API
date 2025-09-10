using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tekus.ManagementProvider.Domain.Entities.Providers;

namespace Tekus.ManagementProvider.Infrastructure.Configurations
{
    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.ToTable("Providers");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nit).IsRequired().HasMaxLength(12)
                                        .HasConversion(
                                                nit => nit!.value,
                                                value => new Nit(value)
                                        );


            builder.Property(p => p.Name).IsRequired().HasMaxLength(50)
                                         .HasConversion(
                                                name => name!.value,
                                                value => new Name(value)
                                         );

            builder.Property(p => p.Email).IsRequired().HasMaxLength(30)
                                          .HasConversion(
                                                    email => email!.value,
                                                    value => new Email(value)
                                          );


            builder.HasMany(x => x.ProviderServices)
                   .WithOne(x => x.Provider)
                   .HasForeignKey(x => x.ProviderId);

            builder.HasMany(x => x.CustomFields)
                   .WithOne(x => x.Provider)
                   .HasForeignKey(x => x.Id);
        }
    }
}


