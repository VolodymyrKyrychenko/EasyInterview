using System.Collections.Generic;

namespace Domain.Entities
{
    public class Library : BaseEntity
    {
        public string Name { get; set; }

        public int? CompanyId { get; set; }

        public Company Company { get; set; }

        public ICollection<Interview> Interviews { get; set; }

        public ICollection<Exercise> Tasks { get; set; }

        public Library()
        {
            Tasks = new List<Exercise>();
        }
    }
}
