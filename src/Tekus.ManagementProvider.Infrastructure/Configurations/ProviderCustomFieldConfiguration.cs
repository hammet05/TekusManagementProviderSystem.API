using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tekus.ManagementProvider.Domain.Entities.CustomsFields;

namespace Tekus.ManagementProvider.Infrastructure.Configurations
{
    internal class ProviderCustomFieldConfiguration : IEntityTypeConfiguration<ProviderCustomField>
    {
        public void Configure(EntityTypeBuilder<ProviderCustomField> builder)
        {
            builder.ToTable("ProviderCustomFields");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FieldName).HasMaxLength(200).IsRequired()
                                               .HasConversion(
                                                     name => name!.value,
                                                     value => new FieldName(value)
                                               );

            builder.Property(x => x.FieldType).HasMaxLength(100).IsRequired()
                                                 .HasConversion(
                                                     name => name!.value,
                                                     value => new FieldType(value)
                                                 );

            builder.Property(x => x.FieldValue).HasMaxLength(100).IsRequired()
                                                .HasConversion(
                                                    name => name!.value,
                                                    value => new FieldValue(value)
                                                );
        }
    }
}
