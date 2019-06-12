using System.Threading.Tasks;
using DataAccess.Interfaces;
using Domain.Entities;
using Services.Interfaces;

namespace Services.Services
{
    public class TestService : ITestService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TestService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(Test test)
        {
            await _unitOfWork.TestRepository.CreateAsync(test);

            await _unitOfWork.SaveAsync();
        }
    }
}
