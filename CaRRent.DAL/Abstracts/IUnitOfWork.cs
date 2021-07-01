using CaRRent.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.DAL.Abstracts
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Car> Cars { get; }
        IGenericRepository<CarBrand> Brands { get; }
        IGenericRepository<Rental> Rentals { get; }
        IGenericRepository<Role> Roles { get; }
        IGenericRepository<User> Users { get; }

        void Save();
        Task SaveAsync();
    }
}
