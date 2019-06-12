using System.Collections.Generic;

namespace Domain.Entities
{
    public class Library : BaseEntity
    {
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }

        public ICollection<LibraryProblem> Problems { get; set; }

        public Library()
        {
            Problems = new List<LibraryProblem>();
        }
    }
}
