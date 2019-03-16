using EasyInterview.Core.Entities;
using EasyInterview.DAL.Context;
using EasyInterview.DAL.Interfaces;
using EasyInterview.DAL.Interfaces.Repositories;
using EasyInterview.DAL.Repositories;
using EasyInterview.DAL.Unit;
using Ninject.Modules;
using Ninject.Web.Common;

namespace EasyInterview.Contracts.DAL
{
    public class DataModule : NinjectModule
    {
        public override void Load()
        {
            Bind<SqlContext>().To<SqlContext>().InRequestScope();

            Bind<IRepository<TaskEntity>>().To<TaskRepository>();

            Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
