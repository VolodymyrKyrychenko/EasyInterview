using EasyInterview.Core.Entities;
using System.Data.Entity;

namespace EasyInterview.DAL.Context
{
    public class SqlContext : DbContext
    {
        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<Change> Changes { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Exercise> Tasks { get; set; }

        public DbSet<Interview> Interviews { get; set; }

        public DbSet<Library> Libraries { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Test> Tests { get; set; }

        static SqlContext()
        {
            Database.SetInitializer(new DbInitializer());
        }

        public SqlContext(): base("EasyInterview")
        {
        }
    }
}
