using Microsoft.EntityFrameworkCore;
using SamSho5SpcWebApi.Data.Models;

namespace SamSho5SpcWebApi.Data
{
    public class SamShoDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }

        public DbSet<Move> Moves { get; set; }

        public SamShoDbContext() : base()
        {

        }

        public SamShoDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Character>().ToTable("Characters");
            builder.Entity<Move>().ToTable("Moves");
        }
    }
}
