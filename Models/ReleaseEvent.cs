namespace ASP_site.Models
{
    public enum ReleaseKind
    {
        Game,
        Book,
        Media,
        ComicIssue,
        CollectedEdition
    }

    public class ReleaseEvent
    {
        public int Year { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }
        public required string Title { get; set; }
        public ReleaseKind Kind { get; set; }
        public string? Detail { get; set; }
        public string? Href { get; set; }
    }
}
