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
    public DbSet<Server> Servers { get; set; }
    public DbSet<Map> Maps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Engine>().ToTable("Engines");
      modelBuilder.Entity<Game>().ToTable("Games");
      modelBuilder.Entity<Link>().ToTable("Links");
      modelBuilder.Entity<Server>().ToTable("Servers");
      modelBuilder.Entity<Map>().ToTable("Maps");

      // Configure composite key for Link
      modelBuilder.Entity<Link>()
        .HasKey(l => new { l.Url, l.GameID });

      // Configure composite key for Map
      modelBuilder.Entity<Map>()
        .HasKey(m => new { m.MapID, m.GameInfo });

      modelBuilder.Entity<Game>()
        .Property(g => g.ReleaseDates)
        .HasConversion(
          v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
          v => JsonSerializer.Deserialize<ReleaseDate[]>(v, new JsonSerializerOptions()) ?? Array.Empty<ReleaseDate>());

      modelBuilder.Entity<Map>()
        .Property(m => m.GameInfo)
        .HasConversion(
          v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
          v => JsonSerializer.Deserialize<List<MapGameInfo>>(v, new JsonSerializerOptions()) ?? new List<MapGameInfo>());
    }
  }
}