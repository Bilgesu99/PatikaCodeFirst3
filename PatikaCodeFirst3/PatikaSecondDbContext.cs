using Microsoft.EntityFrameworkCore;
using PatikaCodeFirst3.Models;

namespace PatikaCodeFirst3
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PatikaCodeFirstDb3;Trusted_Connection=True;");
        }
    }
}
