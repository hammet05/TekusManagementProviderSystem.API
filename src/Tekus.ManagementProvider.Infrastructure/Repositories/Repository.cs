using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Tekus.ManagementProvider.Domain.Abstractions;
using Tekus.ManagementProvider.Infrastructure.Contexts;

namespace Tekus.ManagementProvider.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _applicationDbContext;
        internal DbSet<T> _dbSet;
        public Repository(ApplicationDbContext context)
        {
            _applicationDbContext = context;
            _dbSet = _applicationDbContext.Set<T>();
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task<T?> Find(Guid id)
        {
            return await _dbSet!.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool isTracking = true, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (!isTracking)
            {
                query = query.AsNoTracking();
            }

            return await query.ToListAsync();
        }

        public Task<T> GetFirstOrDefault(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, bool isTracking = true)
        {
            IQueryable<T> query = _dbSet!;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (!isTracking)
            {
                query = query.AsNoTracking();
            }
            return query.FirstOrDefaultAsync()!;
        }
    }
}
