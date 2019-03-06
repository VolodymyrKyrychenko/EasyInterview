using EasyInterview.Core.Entities;
using EasyInterview.DAL.Interfaces;
using EasyInterview.DAL.Interfaces.Repositories;

namespace EasyInterview.DAL.Unit
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<Test> Tests { get; }

        public UnitOfWork(IRepository<Test> tests)
        {
            Tests = tests;
        }
    }
}

