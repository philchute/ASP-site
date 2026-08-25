using ASP_site.Data;

namespace ASP_site.Pages.Books.Rand
{
    public class IndexModel : AuthorIndexModelBase
    {
        public IndexModel(GameContext context) : base(context) { }

        protected override string AuthorName => "Ayn Rand";
    }
}
