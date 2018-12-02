using AutoMapper;
using CostsManager.Common;
using CostsManager.DAL;
using CostsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostsManager.Service
{
    public class MappingSection : IMappingSection
    {
        public void Run(IMapperConfigurationExpression cfg)
        {
            
                cfg.CreateMap<IncomeModel, Income>().ReverseMap();
                cfg.CreateMap<OutcomeModel, Outcome>().ReverseMap();
          
        }
    }
}
