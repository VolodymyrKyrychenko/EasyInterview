using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using System.Threading.Tasks;

namespace Services.Interfaces
{
	public interface ICandidateService
	{

		Task<Candidate> Get(int id);

		Task Create(Candidate candidate);

		Task Update(Candidate candidate);
	}
}
