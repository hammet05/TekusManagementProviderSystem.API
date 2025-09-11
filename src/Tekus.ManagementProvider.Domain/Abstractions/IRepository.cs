using System.Linq.Expressions;

namespace Tekus.ManagementProvider.Domain.Abstractions
{
    public interface IRepository<T> where T : class
    {
        Task<T?> Find(Guid id);
        Task Add(T entity);

        Task<T> GetFirstOrDefault(
                              Expression<Func<T, bool>>? filter = null,
                              string? includeProperties = null,
                              bool isTracking = true
                            );
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool isTracking = true, params Expression<Func<T, object>>[] includes);
    }
}
