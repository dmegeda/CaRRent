using CaRRent.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.DAL.Abstracts
{
    public interface IDataContext
    {
        DbSet<TEntity> DbSet<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
    }
}
