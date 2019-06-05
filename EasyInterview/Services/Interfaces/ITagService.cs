using Domain.Entities;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ITagService
    {
        Task<Tag> GetAll();
    }
}
