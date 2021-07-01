using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.BLL.Abstracts
{
    public interface IService<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> FindAsync(Func<T, bool> predicate);
        Task AddAsync(T item);
        Task Update(T item);
        Task DeleteAsync(int id);
    }
}
