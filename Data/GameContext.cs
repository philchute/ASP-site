using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ASP_site.Models;
using ASP_site.Models.Chess;
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
    // ChessArmy merged into ChessVariant
    // public DbSet<ChessArmy> Armies { get; set; } = null!;
    public DbSet<ChessVariant> Variants { get; set; } = null!;
    public DbSet<ChessArmyPlacement> ArmyPlacements { get; set; } = null!;
    public DbSet<ChessPiece> ChessPieces { get; set; } = null!;

    public DbSet<ASP_site.Models.Gunpla.Gundam> Gundams { get; set; } = null!;
    public DbSet<ASP_site.Models.Gunpla.GunplaKit> GunplaKits { get; set; } = null!;
    public DbSet<ASP_site.Models.Gunpla.UserKitEntry> UserKitEntries { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<ASP_site.Models.Gunpla.Gundam>().ToTable("Gundams");
      modelBuilder.Entity<ASP_site.Models.Gunpla.GunplaKit>().ToTable("GunplaKits");
      modelBuilder.Entity<ASP_site.Models.Gunpla.UserKitEntry>().ToTable("UserKitEntries");

      modelBuilder.Entity<Engine>().ToTable("Engines");
      modelBuilder.Entity<Game>().ToTable("Games");
      modelBuilder.Entity<Link>().ToTable("Links");
      modelBuilder.Entity<Server>().ToTable("Servers");
      modelBuilder.Entity<Map>().ToTable("Maps");
      modelBuilder.Entity<Book>().ToTable("Books");
      // modelBuilder.Entity<ChessArmy>().ToTable("Armies");
      modelBuilder.Entity<ChessVariant>().ToTable("Variants");
      modelBuilder.Entity<ChessPiece>().ToTable("ChessPieces");
      modelBuilder.Entity<ChessArmyPlacement>().ToTable("ArmyPlacements");

      modelBuilder.Entity<ChessPiece>()
        .Property(p => p.Names)
        .HasConversion(
            v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
            v => JsonSerializer.Deserialize<List<ChessPieceName>>(v, new JsonSerializerOptions()) ?? new List<ChessPieceName>())
        .Metadata.SetValueComparer(new ValueComparer<List<ChessPieceName>>(
            (c1, c2) => JsonSerializer.Serialize(c1, new JsonSerializerOptions()) == JsonSerializer.Serialize(c2, new JsonSerializerOptions()),
            c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => JsonSerializer.Deserialize<List<ChessPieceName>>(JsonSerializer.Serialize(c, new JsonSerializerOptions()), new JsonSerializerOptions())!));

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
        .HasKey(l => new { l.Url, l.GameID, l.BookTitle, l.MapID, l.ArmyID });

      // Configure composite key for Map
      modelBuilder.Entity<Map>()
        .HasKey(m => new { m.MapID, m.GameInfo });

      modelBuilder.Entity<Game>()
        .HasMany(g => g.Servers)
        .WithOne()
        .HasForeignKey(s => s.GameID);

      modelBuilder.Entity<Game>()
        .HasMany(g => g.Mods)
        .WithOne()
        .HasForeignKey(g => g.ModForGameID);

      modelBuilder.Entity<Engine>()
        .HasMany(e => e.Children)
        .WithOne()
        .HasForeignKey(e => e.ParentID);

      modelBuilder.Entity<Engine>()
        .HasMany(e => e.Games)
        .WithOne()
        .HasForeignKey(g => g.EngineID);

      modelBuilder.Entity<Game>()
        .Property(g => g.ReleaseDates)
        .HasConversion(
          v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
          v => JsonSerializer.Deserialize<ReleaseDate[]>(v, new JsonSerializerOptions()) ?? Array.Empty<ReleaseDate>())
        .Metadata.SetValueComparer(new ValueComparer<ReleaseDate[]>(
          (c1, c2) => JsonSerializer.Serialize(c1, new JsonSerializerOptions()) == JsonSerializer.Serialize(c2, new JsonSerializerOptions()),
          c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
          c => JsonSerializer.Deserialize<ReleaseDate[]>(JsonSerializer.Serialize(c, new JsonSerializerOptions()), new JsonSerializerOptions())!));

      modelBuilder.Entity<Game>()
        .Property(g => g.ServerConfig)
        .HasConversion(
            v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
            v => JsonSerializer.Deserialize<ServerBrowserConfig>(v, new JsonSerializerOptions()))
        .Metadata.SetValueComparer(new ValueComparer<ServerBrowserConfig>(
            (c1, c2) => JsonSerializer.Serialize(c1, new JsonSerializerOptions()) == JsonSerializer.Serialize(c2, new JsonSerializerOptions()),
            c => JsonSerializer.Serialize(c, new JsonSerializerOptions()).GetHashCode(),
            c => JsonSerializer.Deserialize<ServerBrowserConfig>(JsonSerializer.Serialize(c, new JsonSerializerOptions()), new JsonSerializerOptions())!));

      modelBuilder.Entity<Map>()
        .Property(m => m.GameInfo)
        .HasConversion(
          v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
          v => JsonSerializer.Deserialize<List<MapGameInfo>>(v, new JsonSerializerOptions()) ?? new List<MapGameInfo>())
        .Metadata.SetValueComparer(new ValueComparer<List<MapGameInfo>>(
          (c1, c2) => JsonSerializer.Serialize(c1, new JsonSerializerOptions()) == JsonSerializer.Serialize(c2, new JsonSerializerOptions()),
          c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
          c => JsonSerializer.Deserialize<List<MapGameInfo>>(JsonSerializer.Serialize(c, new JsonSerializerOptions()), new JsonSerializerOptions())!));

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

      // Configure many-to-many relationship between Army and ChessPiece
      // REMOVED old many-to-many config as we are moving to explicit Placement entity
      // Keeping generic config if needed, but 'ArmyChessPiece' table is likely deprecated by 'ArmyPlacements'

      modelBuilder.Entity<ChessVariant>()
        .Property(v => v.ParentIDs)
        .HasConversion(
            v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
            v => JsonSerializer.Deserialize<List<string>>(v, new JsonSerializerOptions()) ?? new List<string>())
        .Metadata.SetValueComparer(new ValueComparer<List<string>>(
            (c1, c2) => JsonSerializer.Serialize(c1, new JsonSerializerOptions()) == JsonSerializer.Serialize(c2, new JsonSerializerOptions()),
            c => JsonSerializer.Serialize(c, new JsonSerializerOptions()).GetHashCode(),
            c => JsonSerializer.Deserialize<List<string>>(JsonSerializer.Serialize(c, new JsonSerializerOptions()), new JsonSerializerOptions())!));

      modelBuilder.Entity<ChessVariant>()
        .Property(v => v.DeadZones)
        .HasConversion(
            v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
            v => JsonSerializer.Deserialize<List<BoardSquare>>(v, new JsonSerializerOptions()) ?? new List<BoardSquare>())
        .Metadata.SetValueComparer(new ValueComparer<List<BoardSquare>>(
            (c1, c2) => JsonSerializer.Serialize(c1, new JsonSerializerOptions()) == JsonSerializer.Serialize(c2, new JsonSerializerOptions()),
            c => JsonSerializer.Serialize(c, new JsonSerializerOptions()).GetHashCode(),
            c => JsonSerializer.Deserialize<List<BoardSquare>>(JsonSerializer.Serialize(c, new JsonSerializerOptions()), new JsonSerializerOptions())!));

      modelBuilder.Entity<ChessVariant>()
        .Property(v => v.RiverZones)
        .HasConversion(
            v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
            v => JsonSerializer.Deserialize<List<BoardSquare>>(v, new JsonSerializerOptions()) ?? new List<BoardSquare>())
        .Metadata.SetValueComparer(new ValueComparer<List<BoardSquare>>(
            (c1, c2) => JsonSerializer.Serialize(c1, new JsonSerializerOptions()) == JsonSerializer.Serialize(c2, new JsonSerializerOptions()),
            c => JsonSerializer.Serialize(c, new JsonSerializerOptions()).GetHashCode(),
            c => JsonSerializer.Deserialize<List<BoardSquare>>(JsonSerializer.Serialize(c, new JsonSerializerOptions()), new JsonSerializerOptions())!));

      modelBuilder.Entity<ChessVariant>()
        .Property(v => v.PromotionRules)
        .HasConversion(
            v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
            v => JsonSerializer.Deserialize<List<PromotionRule>>(v, new JsonSerializerOptions()) ?? new List<PromotionRule>())
        .Metadata.SetValueComparer(new ValueComparer<List<PromotionRule>>(
            (c1, c2) => JsonSerializer.Serialize(c1, new JsonSerializerOptions()) == JsonSerializer.Serialize(c2, new JsonSerializerOptions()),
            c => JsonSerializer.Serialize(c, new JsonSerializerOptions()).GetHashCode(),
            c => JsonSerializer.Deserialize<List<PromotionRule>>(JsonSerializer.Serialize(c, new JsonSerializerOptions()), new JsonSerializerOptions())!));

      // modelBuilder.Entity<ChessArmy>()
      //   .Property(a => a.PromotionRules)
      //   .HasConversion(
      //       v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
      //       v => JsonSerializer.Deserialize<List<PromotionRule>>(v, new JsonSerializerOptions()) ?? new List<PromotionRule>())
      //   .Metadata.SetValueComparer(new ValueComparer<List<PromotionRule>>(
      //       (c1, c2) => JsonSerializer.Serialize(c1, new JsonSerializerOptions()) == JsonSerializer.Serialize(c2, new JsonSerializerOptions()),
      //       c => JsonSerializer.Serialize(c, new JsonSerializerOptions()).GetHashCode(),
      //       c => JsonSerializer.Deserialize<List<PromotionRule>>(JsonSerializer.Serialize(c, new JsonSerializerOptions()), new JsonSerializerOptions())!));
    }
  }
}