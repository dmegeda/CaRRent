using CaRRent.DAL.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.DAL.Entities
{
    public class Rental : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
