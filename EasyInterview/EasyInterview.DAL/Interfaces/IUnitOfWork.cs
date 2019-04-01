using EasyInterview.Core.Entities;
using EasyInterview.DAL.Interfaces.Repositories;

namespace EasyInterview.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Exercise> Tasks { get; }
    }
}