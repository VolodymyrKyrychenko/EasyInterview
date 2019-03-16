using EasyInterview.Core.Entities;
using EasyInterview.DAL.Context;
using EasyInterview.DAL.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EasyInterview.DAL.Repositories
{
    public class TaskRepository : IRepository<TaskEntity>
    {
        private readonly SqlContext _context;

        public TaskRepository(SqlContext context)
        {
            _context = context;
        }

        public void Create(TaskEntity item)
        {
            _context.Tasks.Add(item);

            _context.SaveChanges();
        }

        public TaskEntity Get(int id)
        {
            var task = _context.Tasks.SingleOrDefault(t => t.Id == id);

            return task;
        }

        public IEnumerable<TaskEntity> GetAll()
        {
            var tasks = _context.Tasks.ToList();

            return tasks;
        }

        public void Update(TaskEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;

            _context.SaveChanges();
        }

        public void Delete(TaskEntity item)
        {
            _context.Tasks.Remove(item);

            _context.SaveChanges();
        }
    }
}
