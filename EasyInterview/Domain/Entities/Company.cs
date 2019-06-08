using System.Collections.Generic;

namespace Domain.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public Company()
        {
            Employees = new List<Employee>();
        }
    }
}
