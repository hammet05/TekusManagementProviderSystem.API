using Microsoft.EntityFrameworkCore;
using Tekus.ManagementProvider.Domain.Entities.Providers;
using Tekus.ManagementProvider.Infrastructure.Contexts;

namespace Tekus.ManagementProvider.Infrastructure.Repositories
{
    public class ProviderRepository : Repository<Provider>, IProviderRepository
    {


        public ProviderRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }


        public async Task<IEnumerable<Provider>> GetActiveProviders()
        {
            return await _dbSet.Where(p => p.IsActive).ToListAsync();
        }


    }
}
