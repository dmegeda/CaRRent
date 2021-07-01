using CaRRent.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.BLL.Abstracts
{
    public interface IStatisticService
    {
        public int GetTotalRentalCount();
        public decimal GetTotalRentalPayments();
        public CarDTO GetMostPopularCar();
        public int GetRentCountForCarById(int id);
    }
}
