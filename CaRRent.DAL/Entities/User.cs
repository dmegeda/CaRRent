using CaRRent.DAL.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.DAL.Entities
{
    public class User : BaseEntity
    {
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }
    }
}
