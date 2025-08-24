using BL_Crud_Server_Net8.Entities;
using Microsoft.EntityFrameworkCore;

namespace BL_Crud_Server_Net8.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                    new Game
                    {
                        Id = 1,
                        Name = "N1",
                        Developer = "D1",
                        Release = new DateTime(2004, 11, 16)
                    },
                    new Game
                    {
                        Id = 2,
                        Name = "N2",
                        Developer = "D2",
                        Release = new DateTime(1993, 5, 25)
                    }
                );
        }
        public DbSet<Game> Games => Set<Game>();
    }
}
