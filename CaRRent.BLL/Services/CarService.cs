using CaRRent.BLL.Abstracts;
using CaRRent.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.BLL.Services
{
    public class CarService : IService<CarDTO>
    {
        public Task AddAsync(CarDTO item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CarDTO>> FindAsync(Func<CarDTO, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CarDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CarDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(CarDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
