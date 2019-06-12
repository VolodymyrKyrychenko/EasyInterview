using Domain.Entities;
using Services.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IInterviewService
    {
        Task<IEnumerable<Interview>> Get(InterviewStatus status);

		Task<Interview> GetbyId(int id);

		Task Create(Interview interview);

        Task Update(Interview interview);

        Task<string> GerReport(int interviewId);

		Task<IEnumerable<Interview>> GetAll();
	}
}
