using ASP_site.Models;

namespace ASP_site.Services;

public class SiteMapService
{
    public SiteNode GetSiteMap()
    {
        return new SiteNode
        {
            Id = "home",
            Label = "Home",
            Children = new List<SiteNode>
            {
                new SiteNode
                {
                    Id = "books",
                    Label = "Books",
                    Children = new List<SiteNode>
                    {
                        new SiteNode { Id = "asimov", Label = "Isaac Asimov", Url = "/Books/Asimov/Index" },
                        new SiteNode { Id = "chiang", Label = "Ted Chiang", Url = "/Books/Chiang/Index" },
                        new SiteNode { Id = "clarke", Label = "Arthur C. Clarke", Url = "/Books/Clarke/Index" },
                        new SiteNode { Id = "heinlein", Label = "Robert A. Heinlein", Url = "/Books/Heinlein/Index" },
                        new SiteNode { Id = "rand", Label = "Ayn Rand", Url = "/Books/Rand/Index" },
                        new SiteNode { Id = "philosophy", Label = "Philosophy", Url = "/Philosophy/Index" },
                        new SiteNode { Id = "tractatus", Label = "Tractatus", Url = "/Tractatus/Index" },
                    }
                },
                new SiteNode
                {
                    Id = "chess",
                    Label = "Chess",
                    Children = new List<SiteNode>
                    {
                        new SiteNode { Id = "pieces", Label = "Pieces", Url = "/Chess/Pieces" },
                        new SiteNode { Id = "armies", Label = "Armies", Url = "/Chess/Armies/Index" },
                        new SiteNode { Id = "variants", Label = "Variants", Url = "/Chess/Variants/Index" },
                        new SiteNode { Id = "parser", Label = "Betza Parser", Url = "/Chess/Parser" },
                    }
                },
                new SiteNode
                {
                    Id = "games",
                    Label = "Games",
                    Children = new List<SiteNode>
                    {
                        new SiteNode { Id = "ccgs", Label = "Card Games", Url = "/CCGs/Index" },
                        new SiteNode { Id = "engines", Label = "Game Engines", Url = "/Engines/Index" },
                        new SiteNode { Id = "games", Label = "Games List", Url = "/Games/Index" },
                        new SiteNode { Id = "maps", Label = "Map List", Url = "/Maps/Index" },
                        new SiteNode { Id = "servers", Label = "Server Browser", Url = "/Servers/Index" },
                        new SiteNode { Id = "scales", Label = "Model Scales", Url = "/Math/Scales/Index" },
                        new SiteNode { Id = "gunpla", Label = "Gunpla Dashboard", Url = "/Gundam/Dashboard" },
                    }
                },
                new SiteNode
                {
                    Id = "website",
                    Label = "Website",
                    Children = new List<SiteNode>
                    {
                        new SiteNode { Id = "about", Label = "About", Url = "/About/Index" },
                        new SiteNode { Id = "updates", Label = "Updates", Url = "/Updates/Index" },
                        new SiteNode { Id = "blog", Label = "Blog", Url = "/Blog/Index" },
                        new SiteNode { Id = "events", Label = "Events", Url = "/Events/Index" },
                        new SiteNode { Id = "links", Label = "Links", Url = "/Links/Index" },
                        new SiteNode { Id = "years", Label = "Years", Url = "/Years/Index" },
                    }
                },
            }
        };
    }
}

