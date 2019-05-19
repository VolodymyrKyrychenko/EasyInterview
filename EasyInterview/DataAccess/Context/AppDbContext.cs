using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<Change> Changes { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Exercise> Tasks { get; set; }

        public DbSet<Interview> Interviews { get; set; }

        public DbSet<Library> Libraries { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddInitData();
        }
    }
}
