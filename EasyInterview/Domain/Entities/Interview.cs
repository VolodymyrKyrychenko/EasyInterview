using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Interview : BaseEntity
    {
        public string Report { get; set; }

        public DateTime Start { get; set; }

        public DateTime Finish { get; set; }

        public int CandidateId { get; set; }

        public Candidate Candidate { get; set; }

        public int LibraryId { get; set; }

        public ICollection<Interviewer> Interviewer { get; set; }

        public Interview()
        {
            Interviewer = new List<Interviewer>();
        }
    }
}
