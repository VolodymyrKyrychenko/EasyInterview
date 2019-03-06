using System.Collections.Generic;

namespace EasyInterview.DAL.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
    }
}