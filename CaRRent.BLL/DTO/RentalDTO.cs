using CaRRent.BLL.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.BLL.DTO
{
    public class RentalDTO : BaseDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public CarDTO Car { get; set; }
        public UserDTO User { get; set; }
    }
}
