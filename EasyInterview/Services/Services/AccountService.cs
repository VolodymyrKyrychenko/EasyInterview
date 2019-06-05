using System.Threading.Tasks;
using DataAccess.Interfaces;
using Domain.Entities;
using Services.Interfaces;

namespace Services.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(Employee employee)
        {
            await _unitOfWork.EmployeeRepository.CreateAsync(employee);

            await _unitOfWork.SaveAsync();
        }

        public Task<Employee> Get(int id)
        {
            return _unitOfWork.EmployeeRepository.FindAsync(id);
        }

        public Task Update(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Update(employee);

            return _unitOfWork.SaveAsync();
        }
    }
}
