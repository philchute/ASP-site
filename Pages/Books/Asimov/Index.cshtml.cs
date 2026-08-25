using ASP_site.Data;

namespace ASP_site.Pages.Books.Asimov
{
    public class IndexModel : AuthorIndexModelBase
    {
        public IndexModel(GameContext context) : base(context) { }

        protected override string AuthorName => "Isaac Asimov";
        protected override bool ListAllBookTypes => true;

        protected override IEnumerable<string> DefaultSelectedTypeKeys(IEnumerable<string> existingTypeKeys) =>
            new[] { "Novel", "ShortStory", "NonFiction", "Poem" };
    }
}
