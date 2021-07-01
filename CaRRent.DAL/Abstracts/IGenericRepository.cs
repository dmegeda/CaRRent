using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.DAL.Abstracts
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task AddAsync(TEntity item);
        Task DeleteAsync(TEntity item);
        Task UpdateAsync(TEntity item);
        Task FindAsync(Func<TEntity, bool> predicate);
    }
}
