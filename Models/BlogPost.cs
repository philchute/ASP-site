using System;

namespace ASP_site.Models
{
    public class BlogPost
    {
        public string Slug { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Content { get; set; } = string.Empty; // Raw Markdown or rendered HTML
    }
}

