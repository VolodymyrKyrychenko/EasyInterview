namespace Domain.Entities
{
    public class Test : BaseEntity
    {
        public int Number { get; set; }

        public bool Hidden { get; set; }

        public string Input { get; set; }

        public string Output { get; set; }

        public int ExerciseId { get; set; }

        public Exercise Exercise { get; set; }
    }
}
