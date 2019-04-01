using System.Collections.Generic;

namespace EasyInterview.Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection<Interview> Interviews { get; set; }

        public Employee()
        {
            Interviews = new List<Interview>();
        }
    }
}
