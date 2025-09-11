using Tekus.ManagementProvider.Domain.Entities.Providers;

namespace Tekus.ManagementProvider.Domain.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        //IRepository<Provider> Providers { get; }
        IProviderRepository Providers { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
