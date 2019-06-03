using System.Collections.Generic;

namespace Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Status { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }

        public ICollection<Interviewer> Interviews { get; set; }

        public Employee()
        {
            Interviews = new List<Interviewer>();
        }
    }
}
