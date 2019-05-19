using System.Collections.Generic;

namespace Domain.Entities
{
    public class Exercise : BaseEntity
    {
        public string Name { get; set; }

        public string Condition { get; set; }

        public string Notation { get; set; }

        public string Example { get; set; }

        public string Template { get; set; }

        public int Level { get; set; }

        public ICollection<Library> Libraries { get; set; }
        public ICollection<Test> Tests { get; set; }
        public ICollection<Tag> Tags { get; set; }

        public Exercise()
        {
            Libraries = new List<Library>();
            Tests = new List<Test>();
            Tags = new List<Tag>();
        }
    }
}
