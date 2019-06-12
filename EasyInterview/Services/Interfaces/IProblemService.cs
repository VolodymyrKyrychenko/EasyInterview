using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IProblemService
    {
        Task<Problem> Find(int id);

        Task<IEnumerable<Problem>> Get(int libraryId);

        Task Create(Problem problem);

        Task<IEnumerable<Problem>> GetProblemName(string name);

        Task Update(Problem problem);
    }
}
