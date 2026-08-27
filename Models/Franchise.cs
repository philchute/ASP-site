using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_site.Models
{
    public enum FranchiseWorkKind
    {
        Movie,
        TVShow,
        Book,
        Game,
        ComicArc
    }

    public class Franchise
    {
        [Key]
        public string FranchiseID { get; set; } = "";

        [Required]
        public string Name { get; set; } = "";

        public string? Description { get; set; }

        public ICollection<FranchiseWork> Works { get; set; } = new List<FranchiseWork>();
    }

    public class FranchiseWork
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FranchiseID { get; set; } = "";

        public Franchise? Franchise { get; set; }

        public string Branch { get; set; } = "";

        public FranchiseWorkKind Kind { get; set; }

        public string? GameID { get; set; }
        public string? BookTitle { get; set; }
        public string? MediaID { get; set; }
        public string? StoryArcID { get; set; }

        [NotMapped]
        public string Title { get; set; } = "";

        [NotMapped]
        public int? SettingYear { get; set; }

        [NotMapped]
        public int? ReleasedYear { get; set; }

        [NotMapped]
        public int? ReleasedMonth { get; set; }

        [NotMapped]
        public List<string> CollectionNames { get; set; } = new();

        public CatalogLink? GetCatalogLink()
        {
            if (!string.IsNullOrEmpty(GameID)) return CatalogLink.Game(GameID);
            if (!string.IsNullOrEmpty(BookTitle)) return CatalogLink.Book(BookTitle);
            if (!string.IsNullOrEmpty(MediaID)) return CatalogLink.Media(MediaID);
            if (!string.IsNullOrEmpty(StoryArcID)) return CatalogLink.Arc(StoryArcID);
            return null;
        }

        public static string FormatKind(FranchiseWorkKind kind) => kind switch
        {
            FranchiseWorkKind.Movie => "Movies",
            FranchiseWorkKind.TVShow => "TV",
            FranchiseWorkKind.Book => "Books",
            FranchiseWorkKind.Game => "Games",
            FranchiseWorkKind.ComicArc => "Comics",
            _ => kind.ToString()
        };

        public static string FormatKindShort(FranchiseWorkKind kind) => kind switch
        {
            FranchiseWorkKind.Movie => "Movie",
            FranchiseWorkKind.TVShow => "TV",
            FranchiseWorkKind.Book => "Book",
            FranchiseWorkKind.Game => "Game",
            FranchiseWorkKind.ComicArc => "Comic",
            _ => kind.ToString()
        };

        public static string FormatBranch(string branch) =>
            string.IsNullOrEmpty(branch) ? "—" : branch;
    }
}
