using EasyInterview.Core.Entities;
using EasyInterview.DAL.Interfaces;
using EasyInterview.DAL.Interfaces.Repositories;

namespace EasyInterview.DAL.Unit
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<Exercise> Tasks { get; }

        public UnitOfWork(IRepository<Exercise> tasks)
        {
            Tasks = tasks;
        }
    }
}

