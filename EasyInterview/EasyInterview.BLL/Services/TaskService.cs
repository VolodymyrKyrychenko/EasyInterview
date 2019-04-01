using System.Collections.Generic;
using EasyInterview.BLL.Interfaces;
using EasyInterview.Core.Entities;
using EasyInterview.DAL.Interfaces;

namespace EasyInterview.BLL.Services
{
    public class TaskService : IService<Exercise>
    {
        private readonly IUnitOfWork _unit;

        public TaskService(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public void Create(Exercise item)
        {
            _unit.Tasks.Create(item);
        }

        public Exercise Get(int id)
        {
            var task = _unit.Tasks.Get(id);

            return task;
        }

        public IEnumerable<Exercise> GetAll()
        {
            var tasks = _unit.Tasks.GetAll();

            return tasks;
        }

        public void Update(Exercise item)
        {
            _unit.Tasks.Update(item);
        }

        public void Delete(int id)
        {
            var task = Get(id);

            _unit.Tasks.Delete(task);
        }
    }
}