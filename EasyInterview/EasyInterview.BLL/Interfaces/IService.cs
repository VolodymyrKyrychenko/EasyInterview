using EasyInterview.Core.Entities;
using System.Collections.Generic;

namespace EasyInterview.BLL.Interfaces
{
    public interface IService
    {
        IEnumerable<Test> GetAll();
    }
}