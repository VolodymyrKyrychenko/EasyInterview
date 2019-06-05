using Domain.Entities;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAccountService
    {
        Task<Employee> Get(int id);

        Task Create(Employee employee);

        Task Update(Employee employee);
    }
}
