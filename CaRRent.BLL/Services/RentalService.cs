using CaRRent.BLL.Abstracts;
using CaRRent.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.BLL.Services
{
    public class RentalService : IService<RentalDTO>
    {
        public Task AddAsync(RentalDTO item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RentalDTO>> FindAsync(Func<RentalDTO, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RentalDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RentalDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(RentalDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
