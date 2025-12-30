namespace ASP_site.Models;

public class SiteNode
{
    public string Id { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public string? Url { get; set; }
    public List<SiteNode> Children { get; set; } = new();
}

