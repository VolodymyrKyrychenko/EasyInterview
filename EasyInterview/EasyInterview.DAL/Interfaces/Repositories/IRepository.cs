using System.Collections.Generic;

namespace EasyInterview.DAL.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity item);
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Update(TEntity item);
        void Delete(TEntity item);
    }
}