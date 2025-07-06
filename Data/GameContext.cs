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
    public DbSet<YearEntry> YearEntries { get; set; }
    public DbSet<UpdatePost> UpdatePosts { get; set; } = null!;
    public DbSet<Tag> Tags { get; set; } = null!;
    public DbSet<Book> Books { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Engine>().ToTable("Engines");
      modelBuilder.Entity<Game>().ToTable("Games");
      modelBuilder.Entity<Link>().ToTable("Links");
      modelBuilder.Entity<Server>().ToTable("Servers");
      modelBuilder.Entity<Map>().ToTable("Maps");
      modelBuilder.Entity<Book>().ToTable("Books");

      // Configure the many-to-many relationship between Book and Tag
      modelBuilder.Entity<Book>()
          .HasMany(p => p.Tags)
          .WithMany(t => t.Books)
          .UsingEntity<Dictionary<string, object>>(
              "BookTag",
              j => j.HasOne<Tag>().WithMany().HasForeignKey("TagId").OnDelete(DeleteBehavior.Cascade),
              j => j.HasOne<Book>().WithMany().HasForeignKey("BookTitle").OnDelete(DeleteBehavior.Cascade));

      // Configure composite key for Link
      modelBuilder.Entity<Link>()
        .HasKey(l => new { l.Url, l.GameID, l.BookTitle, l.MapID });

      // Configure composite key for Map
      modelBuilder.Entity<Map>()
        .HasKey(m => new { m.MapID, m.GameInfo });

      modelBuilder.Entity<Game>()
        .HasMany(g => g.Servers)
        .WithOne()
        .HasForeignKey(s => s.GameID);

      modelBuilder.Entity<Game>()
        .Property(g => g.ReleaseDates)
        .HasConversion(
          v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
          v => JsonSerializer.Deserialize<ReleaseDate[]>(v, new JsonSerializerOptions()) ?? Array.Empty<ReleaseDate>());

      modelBuilder.Entity<Game>()
        .Property(g => g.ServerConfig)
        .HasConversion(
            v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
            v => JsonSerializer.Deserialize<ServerBrowserConfig>(v, new JsonSerializerOptions()));

      modelBuilder.Entity<Map>()
        .Property(m => m.GameInfo)
        .HasConversion(
          v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
          v => JsonSerializer.Deserialize<List<MapGameInfo>>(v, new JsonSerializerOptions()) ?? new List<MapGameInfo>());

      // Configure UpdatePost table
      modelBuilder.Entity<UpdatePost>().ToTable("UpdatePosts");

      // Configure Tag table
      modelBuilder.Entity<Tag>().ToTable("Tags");

      // Configure the many-to-many relationship between UpdatePost and Tag
      // EF Core 5+ can configure this by convention, but explicit configuration is clearer.
      modelBuilder.Entity<UpdatePost>()
          .HasMany(p => p.Tags)
          .WithMany(t => t.UpdatePosts)
          .UsingEntity<Dictionary<string, object>>(
              "UpdatePostTag", // Name of the join table
              j => j
                  .HasOne<Tag>()
                  .WithMany()
                  .HasForeignKey("TagId")
                  .OnDelete(DeleteBehavior.Cascade),
              j => j
                  .HasOne<UpdatePost>()
                  .WithMany()
                  .HasForeignKey("UpdatePostId")
                  .OnDelete(DeleteBehavior.Cascade));
    }
  }
}