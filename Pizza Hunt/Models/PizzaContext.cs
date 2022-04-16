using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizza_Hunt.Models
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
                { }
        public DbSet<users>? users { get; set; }
        public DbSet<pizza>? pizza { get; set; }
        public DbSet<pasta>? pasta { get; set; }
        public DbSet<desert>? desert { get; set; }
        public DbSet<refreshments>? refreshments { get; set; }
        public DbSet<FavoritePizza>? FavoritePizza { get; set; }
        public DbSet<FavoritePasta>? FavoritePasta { get; set; }
        public DbSet<FavoriteDesert>? FavoriteDesert { get; set; }
        public DbSet<FavoriteRefreshment>? FavoriteRefreshment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FavoritePizza>()
                .HasKey(t => new { t.pizzaID, t.usersID });
            modelBuilder.Entity<FavoritePasta>()
                .HasKey(t => new { t.pastaID, t.usersID });
            modelBuilder.Entity<FavoriteDesert>()
                .HasKey(t => new { t.desertID, t.usersID });
            modelBuilder.Entity<FavoriteRefreshment>()
                .HasKey(t => new { t.refreshmentsID, t.usersID });
        }

    }
}
