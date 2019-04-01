using EasyInterview.Core.Entities;
using EasyInterview.DAL.Context;
using EasyInterview.DAL.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EasyInterview.DAL.Repositories
{
    public class TaskRepository : IRepository<Exercise>
    {
        private readonly SqlContext _context;

        public TaskRepository(SqlContext context)
        {
            _context = context;
        }

        public void Create(Exercise item)
        {
            _context.Tasks.Add(item);

            _context.SaveChanges();
        }

        public Exercise Get(int id)
        {
            var task = _context.Tasks.SingleOrDefault(t => t.Id == id);

            return task;
        }

        public IEnumerable<Exercise> GetAll()
        {
            var tasks = _context.Tasks.ToList();

            return tasks;
        }

        public void Update(Exercise item)
        {
            _context.Entry(item).State = EntityState.Modified;

            _context.SaveChanges();
        }

        public void Delete(Exercise item)
        {
            _context.Tasks.Remove(item);

            _context.SaveChanges();
        }
    }
}
