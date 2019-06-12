using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ITagService
    {
        Task<IEnumerable<Tag>> GetAll();
    }
}
