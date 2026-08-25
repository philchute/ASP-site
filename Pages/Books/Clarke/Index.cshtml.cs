using ASP_site.Data;

namespace ASP_site.Pages.Books.Clarke
{
    public class IndexModel : AuthorIndexModelBase
    {
        public IndexModel(GameContext context) : base(context) { }

        protected override string AuthorName => "Arthur C. Clarke";
        protected override bool ListAllBookTypes => true;
        protected override bool ExcludePoemFromTypeList => true;

        protected override IEnumerable<string> DefaultSelectedTypeKeys(IEnumerable<string> existingTypeKeys) =>
            new[] { "Novel", "ShortStory", "NonFiction" };
    }
}
