using Microsoft.EntityFrameworkCore;
using ASP_site.Models;
using System.Text.Json;

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
    public DbSet<Link> Links { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Engine>().ToTable("Engines");
      modelBuilder.Entity<Game>().ToTable("Games");
      modelBuilder.Entity<Link>().ToTable("Links");

      modelBuilder.Entity<Game>()
        .Property(g => g.ReleaseDates)
        .HasConversion(
          v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
          v => JsonSerializer.Deserialize<ReleaseDate[]>(v, (JsonSerializerOptions)null));
    }
  }
}
