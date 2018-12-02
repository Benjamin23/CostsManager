using AutoMapper;
using CostsManager.Common;
using CostsManager.DAL;
using CostsManager.Model;
using CostsManager.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostsManager.Service
{
    public class IncomeService : IIncomeService
    {
        protected COSTSMANAGEREntities Context { get; private set; }

        public IncomeService(COSTSMANAGEREntities context)
        {
            Context = context;
        }


        public bool delete(Guid itemId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IncomeModel> Find(BaseFilter filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IncomeModel> GetAll()
        {
            var incomes = Context.Incomes.ToList();
            return Mapper.Map<List<IncomeModel>>(incomes);
        }

        public IncomeModel Insert(IncomeModel item)
        {
            throw new NotImplementedException();
        }

        public IncomeModel Update(IncomeModel item)
        {
            throw new NotImplementedException();
        }
    }
}
