using EasyInterview.BLL.Interfaces;
using EasyInterview.BLL.Services;
using EasyInterview.Core.Entities;
using Ninject.Modules;

namespace EasyInterview.Contracts.BLL
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IService<Exercise>>().To<TaskService>();
        }
    }
}
