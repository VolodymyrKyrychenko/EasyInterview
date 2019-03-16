using EasyInterview.BLL.Interfaces;
using EasyInterview.BLL.Services;
using Ninject.Modules;

namespace EasyInterview.Contracts.BLL
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IService>().To<TestService>();
        }
    }
}
