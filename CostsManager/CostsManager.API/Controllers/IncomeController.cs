using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using CostsManager.API.Models;
using CostsManager.API.Providers;
using CostsManager.API.Results;
using CostsManager.Service.Common;
using AutoMapper;
using CostsManager.Common;
using CostsManager.Model;

namespace CostsManager.API.Controllers
{
    [Authorize]
    [RoutePrefix("Income")]
    public class IncomeController : ApiController
    {
       public IIncomeService IncomeService { get; set; }
        

        public IncomeController(IIncomeService incomeService)
        {
            IncomeService = incomeService;
        }

       
        // GET api/Account/UserInfo
        [HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)]
        [Route("All")]
        public List<IncomeViewModel> GetAll()
        {
            var incomes = IncomeService.GetAll();
            return Mapper.Map<List<IncomeViewModel>>(incomes);
        }

        public class IncomesMappingSection : IMappingSection
        {
            public void Run(IMapperConfigurationExpression cfg)
            {
                cfg.CreateMap<IncomeViewModel, IncomeModel>().ReverseMap();
            }
        }
    }

    
}
