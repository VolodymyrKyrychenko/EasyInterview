using System.Data.Entity;
using EasyInterview.Core.Entities;

namespace EasyInterview.DAL.Context
{
    public class DbInitializer : CreateDatabaseIfNotExists<SqlContext>
    {
        protected override void Seed(SqlContext db)
        {
            db.Tests.Add(new Test {Name = "Test"});

            db.SaveChanges();
        }
    }
}
