using EasyInterview.Core.Entities;
using EasyInterview.DAL.Context;
using EasyInterview.DAL.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EasyInterview.DAL.Repositories
{
    public class TestRepository : IRepository<Test>
    {
        private readonly SqlContext _context;

        public TestRepository(SqlContext context)
        {
            _context = context;
        }

        public IEnumerable<Test> GetAll()
        {
            var tests = _context.Tests.ToList();

            return tests;
        }
    }
}
