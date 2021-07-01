using CaRRent.DAL.Abstracts;
using CaRRent.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.DAL.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGenericRepository<Car> Cars => throw new NotImplementedException();

        public IGenericRepository<CarBrand> Brands => throw new NotImplementedException();

        public IGenericRepository<Rental> Rentals => throw new NotImplementedException();

        public IGenericRepository<Role> Roles => throw new NotImplementedException();

        public IGenericRepository<User> Users => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
