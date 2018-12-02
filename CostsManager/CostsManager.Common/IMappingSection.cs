using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostsManager.Common
{
    public interface IMappingSection
    {
        void Run(IMapperConfigurationExpression cfg);
    }
}
