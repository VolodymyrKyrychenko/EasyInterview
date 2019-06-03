namespace Domain.Entities
{
    public class LibraryProblem : BaseEntity
    {
        public int LibraryId { get; set; }

        public Library Library { get; set; }

        public int ProblemId { get; set; }

        public Problem Problem { get; set; }
    }
}
