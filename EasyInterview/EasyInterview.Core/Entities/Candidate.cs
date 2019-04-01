using System.Collections.Generic;

namespace EasyInterview.Core.Entities
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
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
