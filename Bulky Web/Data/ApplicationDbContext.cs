using Bulky_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky_Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Category>().HasData(
                    new Category { Categoryid = 1, Name = "Action", DisplayOrder = 1 },
                    new Category { Categoryid = 2, Name = "SciFi", DisplayOrder = 2 },
                    new Category { Categoryid = 3, Name = "History", DisplayOrder = 3 },
                    new Category { Categoryid = 4, Name = "Drama", DisplayOrder = 4 }
                );
        }
    }
}
