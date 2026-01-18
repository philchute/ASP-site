using MarkedNet;

namespace ASP_site.Services
{
    public class MarkdownService
    {
        private readonly Marked _marked;

        public MarkdownService()
        {
            _marked = new Marked();
        }

        public string Parse(string markdown)
        {
            if (string.IsNullOrEmpty(markdown)) return "";
            var html = _marked.Parse(markdown);
            // Apply custom table styling
            return html.Replace("<table>", "<table class=\"table\">");
        }
    }
}