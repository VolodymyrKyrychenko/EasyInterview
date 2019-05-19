using System.Threading.Tasks;
using Domain.Entities;

namespace DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Candidate> CandidateRepository { get; }

        IRepository<Change> ChangeRepository { get; }

        IRepository<Company> CompanyRepository { get; }

        IRepository<Employee> EmployeeRepository { get; }

        IRepository<Exercise> ExerciseRepository { get; }

        IRepository<Interview> InterviewRepository { get; }

        IRepository<Library> LibraryRepository { get; }

        IRepository<Tag> TagRepository { get; }

        IRepository<Test> TestRepository { get; }

        Task SaveAsync();
    }
}
