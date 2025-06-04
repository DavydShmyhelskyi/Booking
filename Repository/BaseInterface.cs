using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface BaseInterface<T> where T : class
    {
        Task CreateAsync(T entity);
        Task<IEnumerable<T>> GetAsync();
        Task<T?> GetAsync(int id);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
        Task AddRangeAsync(IEnumerable<T> entities);
    }
}