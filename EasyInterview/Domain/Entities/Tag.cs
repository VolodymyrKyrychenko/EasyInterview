using System.Collections.Generic;

namespace Domain.Entities
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Exercise> Tasks { get; set; }
    }
}
