using ASP_site.Data;

namespace ASP_site.Pages.Books.Chiang
{
    public class IndexModel : AuthorIndexModelBase
    {
        public IndexModel(GameContext context) : base(context) { }

        protected override string AuthorName => "Ted Chiang";
    }
}
