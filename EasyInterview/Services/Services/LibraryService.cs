using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using Domain.Entities;
using Services.Interfaces;

namespace Services.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LibraryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Library> Get(string company)
        {
            var library = await _unitOfWork.LibraryRepository.GetAsync(lib => lib.Company.Name == company);

            return library.FirstOrDefault();
        }
    }
}
