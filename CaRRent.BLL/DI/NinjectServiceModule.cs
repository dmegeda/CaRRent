using CaRRent.DAL.Abstracts;
using CaRRent.DAL.Data;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.BLL.DI
{
    public class NinjectServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().InSingletonScope();
            Bind<IDataContext>().To<CarRentContext>().InSingletonScope();
        }
    }
}
