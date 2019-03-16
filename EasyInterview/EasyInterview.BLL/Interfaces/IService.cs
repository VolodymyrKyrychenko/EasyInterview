using System.Collections.Generic;

namespace EasyInterview.BLL.Interfaces
{
    public interface IService<TEntity> where TEntity : class
    {
        void Create(TEntity item);
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Update(TEntity item);
        void Delete(int id);
    }
}