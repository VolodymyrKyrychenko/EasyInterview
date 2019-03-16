using EasyInterview.Core.Entities;
using System.Data.Entity;

namespace EasyInterview.DAL.Context
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<SqlContext>
    {
        protected override void Seed(SqlContext db)
        {
            db.Tasks.Add(new TaskEntity {Name = "Test"});

            db.SaveChanges();
        }
    }
}
