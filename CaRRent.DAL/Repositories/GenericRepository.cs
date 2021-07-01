using CaRRent.DAL.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.DAL.Repositories
{
    public class GenericRepository<TEntity> :
        IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        public Task AddAsync(TEntity item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TEntity item)
        {
            throw new NotImplementedException();
        }

        public Task FindAsync(Func<TEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
