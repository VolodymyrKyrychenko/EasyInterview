using System;

namespace Domain.Entities
{
    public class Change : BaseEntity
    {
        public DateTime Time { get; set; }

        public string Body { get; set; }

        public int InterviewId { get; set; }

        public Interview Interview { get; set; }
    }
}
