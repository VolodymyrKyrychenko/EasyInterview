using System.Collections.Generic;

namespace Domain.Entities
{
    public class Problem : BaseEntity
    {
        public string Name { get; set; }

        public string Condition { get; set; }

        public string Notation { get; set; }

        public string Example { get; set; }

        public string Template { get; set; }

        public int Level { get; set; }

        public ICollection<LibraryProblem> Libraries { get; set; }

        public ICollection<Test> Tests { get; set; }

        public ICollection<ProblemTag> Tags { get; set; }

        public Problem()
        {
            Libraries = new List<LibraryProblem>();
            Tests = new List<Test>();
            Tags = new List<ProblemTag>();
        }
    }
}
