using DataAccess.Context;
using DataAccess.Interfaces;
using DataAccess.Repository;
using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly Lazy<IRepository<Candidate>> _candidateRepository;
        private readonly Lazy<IRepository<Company>> _companyRepository;
        private readonly Lazy<IRepository<Employee>> _employeeRepository;
        private readonly Lazy<IRepository<Problem>> _problemRepository;
        private readonly Lazy<IRepository<Interview>> _interviewRepository;
        private readonly Lazy<IRepository<Library>> _libratyRepository;
        private readonly Lazy<IRepository<LibraryProblem>> _libratyProblemRepository;
        private readonly Lazy<IRepository<Tag>> _tagRepository;
        private readonly Lazy<IRepository<Test>> _testRepository;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;

            _candidateRepository = new Lazy<IRepository<Candidate>>(() => new Repository<Candidate>(_context));
            _companyRepository = new Lazy<IRepository<Company>>(() => new Repository<Company>(_context));
            _employeeRepository = new Lazy<IRepository<Employee>>(() => new Repository<Employee>(_context));
            _problemRepository = new Lazy<IRepository<Problem>>(() => new Repository<Problem>(_context));
            _interviewRepository = new Lazy<IRepository<Interview>>(() => new Repository<Interview>(_context));
            _libratyRepository = new Lazy<IRepository<Library>>(() => new Repository<Library>(_context));
            _libratyProblemRepository = new Lazy<IRepository<LibraryProblem>>(() => new Repository<LibraryProblem>(_context));
            _tagRepository = new Lazy<IRepository<Tag>>(() => new Repository<Tag>(_context));
            _testRepository = new Lazy<IRepository<Test>>(() => new Repository<Test>(_context));
        }

        public IRepository<Candidate> CandidateRepository => _candidateRepository.Value;

        public IRepository<Company> CompanyRepository => _companyRepository.Value;

        public IRepository<Employee> EmployeeRepository => _employeeRepository.Value;

        public IRepository<Problem> ProblemRepository => _problemRepository.Value;

        public IRepository<Interview> InterviewRepository => _interviewRepository.Value;

        public IRepository<Library> LibraryRepository => _libratyRepository.Value;

        public IRepository<LibraryProblem> LibraryProblemRepository => _libratyProblemRepository.Value;

        public IRepository<Tag> TagRepository => _tagRepository.Value;

        public IRepository<Test> TestRepository => _testRepository.Value;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
