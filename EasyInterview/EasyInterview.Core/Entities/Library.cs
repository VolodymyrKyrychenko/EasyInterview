using System.Collections.Generic;

namespace EasyInterview.Core.Entities
{
    public class Library
    {
        public int Id { get; set; }
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
