using EasyInterview.Core.Entities;
using System.Data.Entity;

namespace EasyInterview.DAL.Context
{
    public class SqlContext : DbContext
    {
        public DbSet<TaskEntity> Tasks { get; set; }

        static SqlContext()
        {
            Database.SetInitializer<SqlContext>(new DbInitializer());
        }

        public SqlContext(): base("EasyInterview")
        {
        }
    }
}
