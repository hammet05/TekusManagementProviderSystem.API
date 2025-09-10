using Tekus.ManagementProvider.Domain.Abstractions;
using Tekus.ManagementProvider.Domain.Entities.Providers;
using Tekus.ManagementProvider.Domain.Entities.Services;

namespace Tekus.ManagementProvider.Domain.Entities.ProvidersServices
{
    public class ProviderService : BaseEntity
    {
        public ProviderService(Guid id) : base(id)
        {
        }

        public Guid ProviderId { get; private set; }
        public Guid ServiceId { get; private set; }
        public string? CountryId { get; private set; }

        public Provider? Provider { get; set; }
        public Service? Service { get; set; }





    }

}
