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

            var libraries = new Library[]
            {
                new Library
                {
                    Id = 1,
                    Name = "HackerRank"
                },
                 new Library
                {
                    Id = 2,
                    Name = "HackerRank2"
                },
                new Library
                {
                    Id = 3,
                    Name = "HackerRank3"
                }
            };

            modelBuilder.Entity<Tag>().HasData(tags);
            modelBuilder.Entity<Library>().HasData(libraries);
        }
    }
}
