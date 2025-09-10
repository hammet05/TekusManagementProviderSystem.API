using Tekus.ManagementProvider.Domain.Abstractions;
using Tekus.ManagementProvider.Domain.Entities.ProvidersServices;

namespace Tekus.ManagementProvider.Domain.Entities.Services
{
    public class Service : BaseEntity
    {
        public Service(Guid id) : base(id)
        {
        }

        public ServiceName? ServiceName { get; private set; }

        public decimal HourlyRateUsd { get; private set; }

        public ICollection<ProviderService> ProviderServices { get; set; } = new List<ProviderService>();

    }
}
