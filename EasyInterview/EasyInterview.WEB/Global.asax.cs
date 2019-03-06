using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using EasyInterview.Contracts.BLL;
using EasyInterview.Contracts.DAL;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;

namespace EasyInterview.WEB
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            NinjectModule gameModule = new DataModule();
            NinjectModule serviceModule = new ServiceModule();
            var kernel = new StandardKernel(gameModule, serviceModule);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}