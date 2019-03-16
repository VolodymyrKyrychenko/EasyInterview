using EasyInterview.Core.Entities;
using EasyInterview.DAL.Interfaces.Repositories;

namespace EasyInterview.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<TaskEntity> Tasks { get; }
    }
}