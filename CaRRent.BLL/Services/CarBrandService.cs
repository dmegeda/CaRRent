using CaRRent.BLL.Abstracts;
using CaRRent.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.BLL.Services
{
    public class CarBrandService : IService<CarBrandDTO>
    {
        public Task AddAsync(CarBrandDTO item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CarBrandDTO>> FindAsync(Func<CarBrandDTO, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CarBrandDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CarBrandDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(CarBrandDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
