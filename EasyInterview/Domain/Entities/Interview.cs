using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Interview : BaseEntity
    {
        public string Report { get; set; }

        public DateTime Date { get; set; }

        public DateTime Start { get; set; }

        public DateTime Finish { get; set; }

        public int CandidateId { get; set; }

        public Candidate Candidate { get; set; }

        public int LibraryId { get; set; }

        public Library Library { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Change> Changes { get; set; }

        public Interview()
        {
            Employees = new List<Employee>();
            Changes = new List<Change>();
        }
    }
}
