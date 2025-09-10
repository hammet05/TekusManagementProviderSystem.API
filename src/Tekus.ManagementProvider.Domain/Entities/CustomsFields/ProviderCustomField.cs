using Tekus.ManagementProvider.Domain.Abstractions;
using Tekus.ManagementProvider.Domain.Entities.Providers;

namespace Tekus.ManagementProvider.Domain.Entities.CustomsFields
{
    public class ProviderCustomField : BaseEntity
    {

        public ProviderCustomField(Guid id) : base(id)
        {
        }
        public FieldName? FieldName { get; private set; }

        public FieldValue? FieldValue { get; private set; }

        public FieldType? FieldType { get; private set; }

        public Provider? Provider { get; set; }

    }
}
