using CaRRent.BLL.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.BLL.DTO
{
    public class CarDTO : BaseDTO
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
        public decimal RentPrice { get; set; }
        public bool IsAvailable { get; set; }
        public CarBrandDTO Brand { get; set; }
    }
}
