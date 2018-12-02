using AutoMapper;
using CostsManager.Common;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dependencies;

namespace CostsManager.API
{

    // List and Describe Necessary HttpModules
    // This class is optional if you already Have NinjectMvc
    public static class AutoMapperSections
    {
        //Return Lists of Modules in the Application
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                var assemblies = AppDomain.CurrentDomain.GetAssemblies();
                foreach (var assembly in assemblies)
                {
                    var validAssemblies = assembly
                    .GetTypes()
                    .Where(t => !t.IsInterface && typeof(IMappingSection).IsAssignableFrom(t) && t.FullName.StartsWith("CostsManager"))
                    .ToList();

                    if (validAssemblies.Any())
                    {
                        validAssemblies.ForEach(t =>
                        {
                            var instance = Activator.CreateInstance(t) as IMappingSection;
                            if (instance != null)
                            {
                                instance.Run(cfg);
                            }
                        });
                    }
                }
            });

        }
    }
}
   
