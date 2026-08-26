using ASP_site.Models;
using ASP_site.Data.Initializers;
using ASP_site.Helpers;

namespace ASP_site.Data {
  public static class DbInitializer {
    public static void Initialize(GameContext context) {
      // Clear all tables
      context.Maps.RemoveRange(context.Maps);
      context.Links.RemoveRange(context.Links);
      context.Servers.RemoveRange(context.Servers);
      context.Games.RemoveRange(context.Games);
      context.Engines.RemoveRange(context.Engines);
      context.YearEntries.RemoveRange(context.YearEntries);
      context.Events.RemoveRange(context.Events);
      // Clear UpdatePosts and Tags
      // context.Database.ExecuteSqlRaw("DELETE FROM UpdatePostTag"); // Removed for in-memory compatibility/simplicity
      context.UpdatePosts.RemoveRange(context.UpdatePosts);
      context.Tags.RemoveRange(context.Tags);
      context.Books.RemoveRange(context.Books);
      context.FranchiseWorks.RemoveRange(context.FranchiseWorks);
      context.Franchises.RemoveRange(context.Franchises);

      // Clear Chess tables
      context.Variants.RemoveRange(context.Variants);
      context.ChessPieces.RemoveRange(context.ChessPieces);

      context.SaveChanges();

      // Initialize Chess Data
      try {
        ChessInitializer.Initialize(context);
      }
      catch (Exception ex) {
        Console.WriteLine($"Failed to initialize chess data: {ex.Message}");
      }

      // Initialize Comics Base Data (Issues, Arcs, Editions) so they can be referenced by other media
      var comicIssues = ComicInitializer.GetComicIssues();
      ThrowIfDuplicateIds(comicIssues, i => i.IssueID, "ComicIssue.IssueID");
      context.ComicIssues.AddRange(comicIssues);
      context.SaveChanges();

      var storyArcs = ComicInitializer.GetStoryArcs();
      ThrowIfDuplicateIds(storyArcs, a => a.ArcID, "StoryArc.ArcID");
      context.StoryArcs.AddRange(storyArcs);
      context.SaveChanges();

      var collectedEditions = ComicInitializer.GetCollectedEditions();
      ThrowIfDuplicateIds(collectedEditions, e => e.EditionID, "CollectedEdition.EditionID");
      context.CollectedEditions.AddRange(collectedEditions);
      context.SaveChanges();
      
      // Initialize engines
      var engines = EngineInitializer.GetEngines();
      foreach (var engine in engines) {
        try {
          context.Engines.Add(engine);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add engine {engine.EngineID}: {ex.Message}");
        }
      }
      
      // Initialize games
      var games = GameInitializer.GetGames();
      ThrowIfDuplicateIds(games, g => g.GameID, "Game.GameID");
      foreach (var game in games) {
        Game h = Game.InitializeYear(game, games.ToList());
        h = Game.InitializeEngine(h, games.ToList());
        if (h.AdaptedFromArcIDs != null && h.AdaptedFromArcIDs.Any()) {
            h.AdaptedFromArcs = context.StoryArcs.Local.Where(arc => h.AdaptedFromArcIDs.Contains(arc.ArcID)).ToList();
        }
        context.Games.Add(h);
      }
      context.SaveChanges(); // Persist game entities immediately
      
      // Initialize CS maps
      var csmaps = CSMapInitializer.GetMaps();
      foreach (var map in csmaps) {
        try {
          context.Maps.Add(map);
          context.Links.Add(CSLinkInitializer.GetWikiLink(map.MapID));
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add map {map.MapID}: {ex.Message}");
        }
      }

      // Initialize TF maps
      var tfmaps = TFMapInitializer.GetMaps();
      foreach (var map in tfmaps) {
        try {
          context.Maps.Add(map);
          // Add wiki link for TF2 maps
          if (map.GameInfo.Any(g => g.GameID == "TF2")) {
            context.Links.Add(TFLinkInitializer.GetWikiLink(map.MapID));
          }
          // Only add wiki link if the TFC version has Valve Corporation as author
          var tfcVersion = map.GameInfo.FirstOrDefault(g => g.GameID == "TFC");
          if (tfcVersion?.Author == "Valve Corporation") {
            context.Links.Add(TFLinkInitializer.GetWikiLinkClassic(map.MapID));
          }
          // Add map repo link for QWTF maps
          if (map.GameInfo.Any(g => g.GameID == "QWTF")) {
            context.Links.Add(TFLinkInitializer.GetRepoLink(map.MapID));
          }
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add map {map.MapID}: {ex.Message}");
        }
      }
      
      // Initialize links
      var links = LinkInitializer.GetLinks();
      foreach (var link in links) {
        try {
          context.Links.Add(link);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add link {link.Url}: {ex.Message}");
        }
      }
      
      // Add Steam links
      foreach (var game in games.Where(g => g.SteamID.HasValue)) {
        var steamLinks = LinkInitializer.GetSteamLinks(game);
        try {
          context.Links.AddRange(steamLinks);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add Steam links for game {game.GameID}: {ex.Message}");
        }
      }
      
      // Add TF links
      var tfLinks = TFLinkInitializer.GetLinks();
      foreach (var link in tfLinks) {
        try {
          context.Links.Add(link);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add TF link {link.Url}: {ex.Message}");
        }
      }
      
      // Add CS links
      var csLinks = CSLinkInitializer.GetLinks();
      foreach (var link in csLinks) {
        try {
          context.Links.Add(link);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add CS link {link.Url}: {ex.Message}");
        }
      }
      
      // Initialize servers
      var servers = ServerInitializer.GetServers();
      foreach (var server in servers) {
        try {
          context.Servers.Add(server);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add server {server.Name}: {ex.Message}");
        }
      }

      // Initialize Year Entries
      var yearEntries = YearEntryInitializer.GetYearEntries();
      foreach (var entry in yearEntries) {
        try {
          context.YearEntries.Add(entry);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add year entry (ID: {entry.ID}, Title: {entry.Title}): {ex.Message}");
        }
      }

      // Initialize Events
      var events = EventInitializer.GetEvents();
      foreach (var evt in events) {
        try {
          context.Events.Add(evt);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add event (ID: {evt.ID}, Name: {evt.Name}): {ex.Message}");
        }
      }

      // Initialize Gunpla Data
      try {
        GunplaInitializer.Initialize(context);
      }
      catch (Exception ex) {
        Console.WriteLine($"Failed to initialize Gunpla data: {ex.Message}");
      }

      // Initialize Update Posts and Tags
      var (initialPosts, initialTags) = UpdatePostInitializer.GetInitialData();
      foreach (var tag in initialTags)
      {
          if (!context.Tags.Any(t => t.Id == tag.Id))
          {
              context.Tags.Add(tag);
          }
      }
      context.SaveChanges(); // Save tags first to ensure they exist for posts

      foreach (var post in initialPosts)
      {
          // Ensure tags are tracked or loaded from context if already existing
          var tagsForPost = new List<Tag>();
          foreach (var postTag in post.Tags)
          {
              var existingTag = context.Tags.Local.FirstOrDefault(t => t.Id == postTag.Id) ?? context.Tags.Find(postTag.Id);
              if (existingTag != null) {
                  tagsForPost.Add(existingTag);
              } else {
                 // This case should ideally not happen if GetInitialData provides valid tag references
                 // Or if all tags were added and saved above correctly.
                 Console.WriteLine($"Warning: Tag with Id {postTag.Id} not found for post '{post.Title}'.");
              }
          }
          post.Tags = tagsForPost;
          context.UpdatePosts.Add(post);
      }
      
      // Initialize Books and their Tags
      var (books, bookLinks) = BookInitializer.GetData();
      context.Links.AddRange(bookLinks);
      var allBookTags = books.SelectMany(b => b.Tags).Select(t => t.Name).Distinct();

      foreach (var tagName in allBookTags)
      {
          if (!context.Tags.Any(t => t.Name == tagName))
          {
              context.Tags.Add(new Tag { Name = tagName });
          }
      }
      context.SaveChanges();

      var tagsFromDb = context.Tags.ToList();

      foreach (var book in books)
      {
          var tagsForBook = new List<Tag>();
          if (book.Tags != null && book.Tags.Any())
          {
              var tagNamesForBook = book.Tags.Select(t => t.Name);
              tagsForBook.AddRange(tagsFromDb.Where(t => tagNamesForBook.Contains(t.Name)));
          }
          book.Tags = tagsForBook;
          
          if (book.AdaptedFromArcIDs != null && book.AdaptedFromArcIDs.Any()) {
              book.AdaptedFromArcs = context.StoryArcs.Local.Where(arc => book.AdaptedFromArcIDs.Contains(arc.ArcID)).ToList();
          }

          if (string.IsNullOrEmpty(book.Slug))
          {
              book.Slug = StringUtils.ToSlug(book.Title);
          }
          
          context.Books.Add(book);
      }

      var duplicateSlugs = context.Books.Local
          .Where(b => !string.IsNullOrEmpty(b.Slug))
          .GroupBy(b => b.Slug)
          .Where(g => g.Count() > 1);
      foreach (var group in duplicateSlugs)
      {
          int n = 2;
          foreach (var book in group.Skip(1))
          {
              book.Slug = $"{book.Slug}-{n++}";
          }
      }
      
      context.SaveChanges();

      foreach (var book in books.Where(b => b.ParentCollectionTitle != null))
      {
          book.ParentCollection = context.Books.SingleOrDefault(b => b.Title == book.ParentCollectionTitle);
      }
      
      context.SaveChanges();

      var adaptedMedia = ComicInitializer.GetMedia();
      ThrowIfDuplicateIds(adaptedMedia, m => m.MediaID, "Media.MediaID");
      foreach (var media in adaptedMedia) {
        if (media.AdaptedFromArcIDs != null && media.AdaptedFromArcIDs.Any()) {
          media.AdaptedFromArcs = context.StoryArcs.Local.Where(arc => media.AdaptedFromArcIDs.Contains(arc.ArcID)).ToList();
        }
        context.Media.Add(media);
      }
      context.SaveChanges();

      var (franchises, franchiseWorks) = FranchiseInitializer.GetData();
      ThrowIfDuplicateIds(franchises, f => f.FranchiseID, "Franchise.FranchiseID");
      context.Franchises.AddRange(franchises);
      context.SaveChanges();
      context.FranchiseWorks.AddRange(franchiseWorks);
      context.SaveChanges();

      CatalogLinker.LinkYearEntries(context);
      context.SaveChanges();
    }

    private static void ThrowIfDuplicateIds<T>(IEnumerable<T> items, Func<T, string> idSelector, string label)
    {
      var dupes = items
        .Select(idSelector)
        .Where(id => !string.IsNullOrWhiteSpace(id))
        .GroupBy(id => id, StringComparer.OrdinalIgnoreCase)
        .Where(g => g.Count() > 1)
        .Select(g => $"{g.Key} x{g.Count()}")
        .ToList();

      if (dupes.Count > 0)
      {
        throw new InvalidOperationException(
          $"Duplicate {label} values (refusing to skip):\n  " + string.Join("\n  ", dupes));
      }
    }
  }
}