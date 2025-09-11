using Tekus.ManagementProvider.Domain.Abstractions;

namespace Tekus.ManagementProvider.Domain.Entities.Providers
{
    public interface IProviderRepository : IRepository<Provider>
    {
        Task<IEnumerable<Provider>> GetActiveProviders();

    }
}
