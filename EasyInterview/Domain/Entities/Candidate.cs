using System.Collections.Generic;

namespace Domain.Entities
{
    public class Candidate : BaseEntity
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public ICollection<Interview> Interviews { get; set; }

        public Candidate()
        {
            Interviews = new List<Interview>();
        }
    }
}
