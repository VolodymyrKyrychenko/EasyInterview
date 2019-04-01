using System.Collections.Generic;

namespace EasyInterview.Core.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Exercise> Tasks { get; set; }
    }
}
