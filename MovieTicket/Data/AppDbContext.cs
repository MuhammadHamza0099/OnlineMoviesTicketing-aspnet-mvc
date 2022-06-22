using Microsoft.EntityFrameworkCore;
using MovieTicket.Models;

namespace MovieTicket.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
