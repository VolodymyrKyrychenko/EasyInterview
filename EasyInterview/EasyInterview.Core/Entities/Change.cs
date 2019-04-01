using System;

namespace EasyInterview.Core.Entities
{
    public class Change
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Body { get; set; }

        public int InterviewId { get; set; }
        public Interview Interview { get; set; }
    }
}
