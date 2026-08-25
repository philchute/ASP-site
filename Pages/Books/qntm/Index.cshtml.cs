using ASP_site.Data;

namespace ASP_site.Pages.Books.qntm
{
    public class IndexModel : AuthorIndexModelBase
    {
        public IndexModel(GameContext context) : base(context) { }

        protected override string AuthorName => "qntm";
    }
}
