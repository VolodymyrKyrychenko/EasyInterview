using System.Collections.Generic;
using EasyInterview.BLL.Interfaces;
using EasyInterview.Core.Entities;
using EasyInterview.DAL.Interfaces;

namespace EasyInterview.BLL.Services
{
    public class TaskService : IService<TaskEntity>
    {
        private readonly IUnitOfWork _unit;

        public TaskService(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public void Create(TaskEntity item)
        {
            _unit.Tasks.Create(item);
        }

        public TaskEntity Get(int id)
        {
            var task = _unit.Tasks.Get(id);

            return task;
        }

        public IEnumerable<TaskEntity> GetAll()
        {
            var tasks = _unit.Tasks.GetAll();

            return tasks;
        }

        public void Update(TaskEntity item)
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