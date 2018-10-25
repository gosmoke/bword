using BWord.Core;
using BWord.Data.Repositories;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace BWord.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IMapperService, MapperService>();
            container.RegisterType<ILoggerService, LoggerService>();
            container.RegisterType<IBWordDataRepository, BWordDataRepository>();
            container.RegisterType<IBWordService, BWordService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}