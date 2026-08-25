using System.Text.RegularExpressions;
using ASP_site.Data;
using ASP_site.Models;

namespace ASP_site.Helpers
{
    public static class CatalogLinker
    {
        private static readonly Dictionary<string, string> GameIdAliases = new(StringComparer.OrdinalIgnoreCase)
        {
            ["aoe1"] = "aoe",
            ["momentum"] = "momentummod"
        };

        private static readonly Regex TrailingParen = new(@"\s*\([^)]*\)\s*$", RegexOptions.Compiled);

        public static void LinkYearEntries(GameContext context)
        {
            var games = context.Games.Local.ToList();
            if (games.Count == 0)
            {
                games = context.Games.ToList();
            }

            var books = context.Books.Local.ToList();
            if (books.Count == 0)
            {
                books = context.Books.ToList();
            }

            var media = context.Media.Local.ToList();
            if (media.Count == 0)
            {
                media = context.Media.ToList();
            }

            var arcs = context.StoryArcs.Local.ToList();
            if (arcs.Count == 0)
            {
                arcs = context.StoryArcs.ToList();
            }

            var gameIds = new HashSet<string>(games.Select(g => g.GameID), StringComparer.OrdinalIgnoreCase);
            var gamesByName = UniqueBy(games, g => Normalize(g.Name), g => g.GameID);
            var gamesByLongestName = games
                .OrderByDescending(g => g.Name.Length)
                .ToList();

            var booksByTitle = UniqueBy(books, b => Normalize(b.Title), b => b.Title);
            var mediaByTitle = UniqueBy(media, m => Normalize(m.Title), m => m.MediaID);
            var arcsByTitle = UniqueBy(arcs, a => Normalize(a.Title), a => a.ArcID);

            var entries = context.YearEntries.Local.ToList();
            if (entries.Count == 0)
            {
                entries = context.YearEntries.ToList();
            }

            var links = context.Links.Local.ToList();
            if (links.Count == 0)
            {
                links = context.Links.ToList();
            }
            foreach (var link in links)
            {
                if (!string.IsNullOrEmpty(link.GameID)
                    && GameIdAliases.TryGetValue(link.GameID, out var aliasedLink)
                    && gameIds.Contains(aliasedLink))
                {
                    link.GameID = aliasedLink;
                }
            }

            foreach (var entry in entries)
            {
                if (!string.IsNullOrEmpty(entry.GameID))
                {
                    if (GameIdAliases.TryGetValue(entry.GameID, out var aliased) && gameIds.Contains(aliased))
                    {
                        entry.GameID = aliased;
                    }
                    else if (!gameIds.Contains(entry.GameID))
                    {
                        entry.GameID = null;
                    }
                }

                if (string.IsNullOrEmpty(entry.GameID))
                {
                    entry.GameID = MatchGame(entry.Title, gamesByName, gamesByLongestName);
                }

                if (string.IsNullOrEmpty(entry.Title)) continue;

                if (string.IsNullOrEmpty(entry.BookTitle))
                {
                    var key = Normalize(StripTrailingParen(entry.Title));
                    if (booksByTitle.TryGetValue(key, out var bookTitle))
                    {
                        entry.BookTitle = bookTitle;
                    }
                }

                if (string.IsNullOrEmpty(entry.MediaID))
                {
                    var key = Normalize(StripTrailingParen(entry.Title));
                    if (mediaByTitle.TryGetValue(key, out var mediaId))
                    {
                        entry.MediaID = mediaId;
                    }
                }

                if (string.IsNullOrEmpty(entry.StoryArcID))
                {
                    var key = Normalize(StripTrailingParen(entry.Title));
                    if (arcsByTitle.TryGetValue(key, out var arcId))
                    {
                        entry.StoryArcID = arcId;
                    }
                }
            }
        }

        private static string? MatchGame(
            string? title,
            Dictionary<string, string> gamesByName,
            List<Game> gamesByLongestName)
        {
            if (string.IsNullOrWhiteSpace(title)) return null;

            var stripped = StripTrailingParen(title);
            var key = Normalize(stripped);
            if (gamesByName.TryGetValue(key, out var id))
            {
                return id;
            }

            foreach (var game in gamesByLongestName)
            {
                if (stripped.StartsWith(game.Name + ":", StringComparison.OrdinalIgnoreCase)
                    || stripped.Equals(game.Name, StringComparison.OrdinalIgnoreCase))
                {
                    return game.GameID;
                }
            }

            return null;
        }

        private static Dictionary<string, TValue> UniqueBy<T, TValue>(
            IEnumerable<T> items,
            Func<T, string> keySelector,
            Func<T, TValue> valueSelector)
        {
            return items
                .GroupBy(keySelector)
                .Where(g => !string.IsNullOrEmpty(g.Key) && g.Count() == 1)
                .ToDictionary(g => g.Key, g => valueSelector(g.First()));
        }

        private static string StripTrailingParen(string title) => TrailingParen.Replace(title, "").Trim();

        private static string Normalize(string value) =>
            value.Trim().ToLowerInvariant();
    }
}
