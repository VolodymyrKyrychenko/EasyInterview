using EasyInterview.Core.Entities;
using EasyInterview.DAL.Interfaces;
using EasyInterview.DAL.Interfaces.Repositories;

namespace EasyInterview.DAL.Unit
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<TaskEntity> Tasks { get; }

        public UnitOfWork(IRepository<TaskEntity> tasks)
        {
            Tasks = tasks;
        }
    }
}

