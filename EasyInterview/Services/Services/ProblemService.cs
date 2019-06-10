using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using Domain.Entities;
using Services.Interfaces;

namespace Services.Services
{
    public class ProblemService : IProblemService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProblemService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(Problem problem)
        {
            await _unitOfWork.ProblemRepository.CreateAsync(problem);

            await _unitOfWork.SaveAsync();
        }

        public Task<Problem> Find(int id)
        {
            return _unitOfWork.ProblemRepository.FindAsync(id);
        }

        public Task<IEnumerable<Problem>> Get(int libraryId)
        {
            return _unitOfWork.ProblemRepository.GetAsync(problem => problem.Libraries.Select(x => x.LibraryId).Contains(libraryId));
        }

        public Task<IEnumerable<Problem>> GetProblemName(string name)
        {
            return  _unitOfWork.ProblemRepository.GetAsync(problem => problem.Name == name);
        }
    }
}
