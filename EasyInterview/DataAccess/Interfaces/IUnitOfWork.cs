using System.Threading.Tasks;
using Domain.Entities;

namespace DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Candidate> CandidateRepository { get; }

        IRepository<Company> CompanyRepository { get; }

        IRepository<Employee> EmployeeRepository { get; }

        IRepository<Problem> ProblemRepository { get; }

        IRepository<Interview> InterviewRepository { get; }

        IRepository<Library> LibraryRepository { get; }

        IRepository<LibraryProblem> LibraryProblemRepository { get; }

        IRepository<Tag> TagRepository { get; }

        IRepository<Test> TestRepository { get; }

        Task SaveAsync();
    }
}
