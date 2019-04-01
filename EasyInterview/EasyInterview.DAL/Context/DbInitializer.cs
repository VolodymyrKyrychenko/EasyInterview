using EasyInterview.Core.Entities;
using System.Data.Entity;

namespace EasyInterview.DAL.Context
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<SqlContext>
    {
        protected override void Seed(SqlContext db)
        {
            db.Tasks.Add(new Exercise {Name = "Test"});

            db.SaveChanges();
        }
    }
}
