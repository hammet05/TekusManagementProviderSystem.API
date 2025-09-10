using Tekus.ManagementProvider.Domain.Abstractions;
using Tekus.ManagementProvider.Domain.Entities.CustomsFields;
using Tekus.ManagementProvider.Domain.Entities.ProvidersServices;

namespace Tekus.ManagementProvider.Domain.Entities.Providers
{
    public class Provider : BaseEntity
    {
        protected Provider(Guid id) : base(id)
        {
        }
        public Nit? Nit { get; private set; }
        public Name? Name { get; private set; }
        public Email? Email { get; private set; }

        public ICollection<ProviderService> ProviderServices { get; set; } = new List<ProviderService>();
        public ICollection<ProviderCustomField> CustomFields { get; set; } = new List<ProviderCustomField>();
    }
}
