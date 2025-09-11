using Tekus.ManagementProvider.Domain.Abstractions;
using Tekus.ManagementProvider.Domain.Entities.Providers;
using Tekus.ManagementProvider.Infrastructure.Contexts;

namespace Tekus.ManagementProvider.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public IProviderRepository Providers { get; }
        //public IRepository<Provider> Providers { get; }
        public UnitOfWork(ApplicationDbContext applicationDbContext, IProviderRepository providerRepository)
        {
            _applicationDbContext = applicationDbContext;
            Providers = providerRepository;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _applicationDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            System.GC.SuppressFinalize(this);
        }
    }
}
