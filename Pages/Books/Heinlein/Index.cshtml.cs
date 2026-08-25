using ASP_site.Data;

namespace ASP_site.Pages.Books.Heinlein
{
    public class IndexModel : AuthorIndexModelBase
    {
        public IndexModel(GameContext context) : base(context) { }

        protected override string AuthorName => "Robert A. Heinlein";

        protected override IEnumerable<string> DefaultSelectedTypeKeys(IEnumerable<string> existingTypeKeys) =>
            existingTypeKeys;
    }
}
