using Tekus.ManagementProvider.Domain.Abstractions;

namespace Tekus.ManagementProvider.Domain.Entities.Providers.Events
{
    public record ProviderCreateDomainEvent(Guid ProviderId) : IDomainEvent;

}
