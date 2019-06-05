using Domain.Entities;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ILibraryService
    {
        Task<Library> Get(string company);
    }
}
