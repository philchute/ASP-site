using ASP_site.Models;

namespace ASP_site.Helpers
{
    public static class GenreHub
    {
        public static readonly HashSet<Genre> EssayGenres = [Genre.Fighting];

        public static bool HasEssay(Genre? genre) =>
            genre is Genre g && EssayGenres.Contains(g);

        public static string DisplayName(Genre genre) => genre switch
        {
            Genre.FPS => "FPS",
            Genre.TPS => "TPS",
            Genre.RTS => "RTS",
            Genre.TBS => "TBS",
            Genre.MOBA => "MOBA",
            _ => $"{genre} Games"
        };

        public static string MarkdownFileName(Genre genre) =>
            $"{genre.ToString().ToLowerInvariant()}.md";

        public static string MarkdownRelativePath(Genre genre) =>
            Path.Combine("markdown", "genres", MarkdownFileName(genre));
    }
}
