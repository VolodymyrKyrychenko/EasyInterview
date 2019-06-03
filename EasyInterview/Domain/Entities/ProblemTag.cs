namespace Domain.Entities
{
    public class ProblemTag : BaseEntity
    {
        public int ProblemId { get; set; }

        public Problem Problem { get; set; }

        public int TagId { get; set; }

        public Tag Tag { get; set; }
    }
}
