using CaRRent.DAL.Abstracts;
using CaRRent.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.DAL.Data
{
    public class CarRentContext : DbContext, IDataContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrand> Brands { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        //public CarRentContext(DbContextOptions<CarRentContext> options) : base(options)
        //{
        //    Database.EnsureCreated();
        //}

        public CarRentContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../CaRRent.DAL/Database/car_rent.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<TEntity> DbSet<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }
    }
}
