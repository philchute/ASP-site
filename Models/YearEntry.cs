using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_site.Models
{
    public enum ContentType  { Book, Play, Movie, Series, Episode, Game, GameMission }
    public enum AgeAppropriateness { Early, Middle, Teen, Adult }

    public class YearEntry
    {
        [Key]
        [Required] public int ID { get; set; }
        [Required] public int Year { get; set; } 
        [Required] public string? Title { get; set; }
        public ContentType? Type { get; set; }
        public AgeAppropriateness? Age { get; set; }
        public string? Description { get; set; }
        public string? GameID { get; set; }
        public string? BookTitle { get; set; }
        public string? MediaID { get; set; }
        public string? StoryArcID { get; set; }
        public string? Published { get; set; }
        public string? Availability { get; set; }

        public bool HasCatalogLink =>
            !string.IsNullOrEmpty(GameID)
            || !string.IsNullOrEmpty(BookTitle)
            || !string.IsNullOrEmpty(MediaID)
            || !string.IsNullOrEmpty(StoryArcID);

        public int? GetPublishedYear()
        {
            if (string.IsNullOrWhiteSpace(Published)) return null;
            return int.TryParse(Published.Trim(), out var year) ? year : null;
        }

        public CatalogLink? GetPrimaryLink()
        {
            switch (Type)
            {
                case ContentType.Game:
                case ContentType.GameMission:
                    if (!string.IsNullOrEmpty(GameID)) return CatalogLink.Game(GameID);
                    break;
                case ContentType.Book:
                    if (!string.IsNullOrEmpty(BookTitle)) return CatalogLink.Book(BookTitle);
                    break;
                case ContentType.Movie:
                case ContentType.Series:
                case ContentType.Episode:
                    if (!string.IsNullOrEmpty(MediaID)) return CatalogLink.Media(MediaID);
                    if (!string.IsNullOrEmpty(BookTitle)) return CatalogLink.Book(BookTitle);
                    break;
            }

            return GetCatalogLinks().FirstOrDefault();
        }

        public List<CatalogLink> GetCatalogLinks()
        {
            var links = new List<CatalogLink>();
            if (!string.IsNullOrEmpty(GameID)) links.Add(CatalogLink.Game(GameID));
            if (!string.IsNullOrEmpty(BookTitle)) links.Add(CatalogLink.Book(BookTitle));
            if (!string.IsNullOrEmpty(MediaID)) links.Add(CatalogLink.Media(MediaID));
            if (!string.IsNullOrEmpty(StoryArcID)) links.Add(CatalogLink.Arc(StoryArcID));
            return links;
        }
    }

    public class CatalogLink
    {
        public required string Page { get; set; }
        public required string RouteName { get; set; }
        public required string RouteValue { get; set; }
        public required string Label { get; set; }

        public static CatalogLink Game(string id) => new() { Page = "/Games/Game", RouteName = "GameID", RouteValue = id, Label = "Game" };
        public static CatalogLink Book(string title) => new() { Page = "/Books/Book", RouteName = "BookTitle", RouteValue = title, Label = "Book" };
        public static CatalogLink Media(string id) => new() { Page = "/Media/Details", RouteName = "id", RouteValue = id, Label = "Movie / TV" };
        public static CatalogLink Arc(string id) => new() { Page = "/Comics/Arc", RouteName = "id", RouteValue = id, Label = "Comic arc" };
    }
}