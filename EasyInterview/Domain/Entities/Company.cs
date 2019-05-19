namespace Domain.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Library> Libraries { get; set; }

        public Company()
        {
            Employees = new List<Employee>();
            Libraries = new List<Library>();
        }
    }
}
