using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using Domain.Entities;
using Services.Interfaces;

namespace Services.Services
{
    public class LibraryService : IService<Library>
    {
        private readonly IUnitOfWork _unitOfWork;

        public LibraryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<Library>> Get()
        {
            return _unitOfWork.LibraryRepository.GetAsync();
        }
    }
}
