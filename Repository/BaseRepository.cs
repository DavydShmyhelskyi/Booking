using Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository
{
    public class BaseRepository<T> : BaseInterface<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public ApplicationDbContext Context => _context;

        public async Task CreateAsync(T entity)
        {
            var keyProperty = _context.Model.FindEntityType(typeof(T))?.FindPrimaryKey()?.Properties[0];
            var keyValue = keyProperty?.PropertyInfo?.GetValue(entity);

            var existingEntity = keyValue != null ? await _dbSet.FindAsync(keyValue) : null;
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }
            _context.Entry(entity).State = EntityState.Added;
            await SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetAsync(int id)
        {
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == id);
        }

        public async Task UpdateAsync(T entity)
        {
            var idValue = _context.Entry(entity).Property("Id").CurrentValue;
            var existingEntity = _dbSet.Local.FirstOrDefault(e =>
                _context.Entry(e).Property("Id").CurrentValue.Equals(idValue));
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

            await SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await SaveChangesAsync();
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await SaveChangesAsync();
        }

        // Додаткові методи (не в інтерфейсі, але можна додати за потреби)
        public async Task<bool> AnyAsync()
        {
            return await _dbSet.AnyAsync();
        }

        public async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(predicate);
        }
    }
}