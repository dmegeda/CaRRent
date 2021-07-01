using CaRRent.BLL.Abstracts;
using CaRRent.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.BLL.Services
{
    public class RoleService : IService<RoleDTO>
    {
        public Task AddAsync(RoleDTO item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RoleDTO>> FindAsync(Func<RoleDTO, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RoleDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RoleDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(RoleDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
