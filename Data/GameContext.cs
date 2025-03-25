using Microsoft.EntityFrameworkCore;
using ASP_site.Models;

namespace ASP_site.Data
{
  public class GameContext : DbContext
  {
    public GameContext(DbContextOptions<GameContext> options)
      : base(options)
    {
    }

    public DbSet<Engine> Engines { get; set; }
    public DbSet<Game> Games { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Engine>().ToTable("Engines");
      modelBuilder.Entity<Game>().ToTable("Games");
    }
  }
}
