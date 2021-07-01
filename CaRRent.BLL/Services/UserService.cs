using CaRRent.BLL.Abstracts;
using CaRRent.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.BLL.Services
{
    public class UserService : IService<UserDTO>
    {
        public Task AddAsync(UserDTO item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDTO>> FindAsync(Func<UserDTO, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(UserDTO item)
        {
            throw new NotImplementedException();
        }

        private string ConvertPasswordToHash(string password)
        {
            throw new NotImplementedException();
        }
    }
}
