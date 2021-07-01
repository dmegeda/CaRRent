using CaRRent.DAL.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.DAL.Entities
{
    public class Car : BaseEntity
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
        public decimal RentPrice { get; set; }
        public bool IsAvailable { get; set; }
        public int HorsePower { get; set; }

        public int BrandId { get; set; }
        public virtual CarBrand Brand { get; set; }
    }
}
