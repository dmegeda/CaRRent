using CaRRent.BLL.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.BLL.DTO
{
    public class UserDTO : BaseDTO
    {
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
