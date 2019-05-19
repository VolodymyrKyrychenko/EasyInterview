using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public static class DataInitializer
    {
        public static void AddInitData(this ModelBuilder modelBuilder)
        {
            var tags = new Tag[]
            {
               new Tag
               {
                   Id = 1,
                   Name = "Algorithms"
               }
            };

            modelBuilder.Entity<Tag>().HasData(tags);
        }
    }
}
