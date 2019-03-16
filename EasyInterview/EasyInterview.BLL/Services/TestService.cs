using System.Collections.Generic;
using EasyInterview.BLL.Interfaces;
using EasyInterview.Core.Entities;
using EasyInterview.DAL.Interfaces;

namespace EasyInterview.BLL.Services
{
    public class TestService : IService
    {
        private readonly IUnitOfWork _unit;

        public TestService(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public IEnumerable<Test> GetAll()
        {
            var test = _unit.Tests.GetAll();

            return test;
        }
    }
}
