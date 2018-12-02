using CostsManager.DAL;
using CostsManager.Service.Common;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostsManager.Service
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {

            Bind<IIncomeService>().To<IncomeService>();

            Bind<COSTSMANAGEREntities>().ToSelf().InSingletonScope();

        }
    }
}
