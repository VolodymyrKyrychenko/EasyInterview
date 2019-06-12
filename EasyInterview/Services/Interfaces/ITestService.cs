using Domain.Entities;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ITestService
    {
        Task Create(Test test);
    }
}
