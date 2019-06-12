using System.Linq;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using Domain.Entities;
using Services.Interfaces;

namespace Services.Services
{
	class CandidateService : ICandidateService
	{
		private readonly IUnitOfWork _unitOfWork;
		public CandidateService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public async Task Create(Candidate candidate)
		{
			await _unitOfWork.CandidateRepository.CreateAsync(candidate);

			await _unitOfWork.SaveAsync();
		}

		public Task<Candidate> Get(int id)
		{
			return _unitOfWork.CandidateRepository.FindAsync(id);
		}

		public Task Update(Candidate candidate)
		{
			_unitOfWork.CandidateRepository.Update(candidate);

			return _unitOfWork.SaveAsync();
		}
	}
}
