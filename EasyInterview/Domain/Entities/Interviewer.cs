namespace Domain.Entities
{
    public class Interviewer : BaseEntity
    {
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public int InterviewId { get; set; }

        public Interview Interview { get; set; }
    }
}
