using System.Collections.Generic;

namespace EasyInterview.Core.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Library> Libraries { get; set; }

        public Company()
        {
            Employees = new List<Employee>();
            Libraries = new List<Library>();
        }
    }
}
