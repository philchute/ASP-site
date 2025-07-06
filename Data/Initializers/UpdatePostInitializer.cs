using ASP_site.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP_site.Data.Initializers
{
    public static class UpdatePostInitializer
    {
        public static (List<UpdatePost> Posts, List<Tag> Tags) GetInitialData()
        {
            var tags = new List<Tag>
            {
                new Tag { Id = 1, Name = "Website Update" },
                new Tag { Id = 2, Name = "Personal Update" },
                new Tag { Id = 3, Name = "Gaming Update" }
            };

            var posts = new List<UpdatePost>
            {
                new UpdatePost
                {
                    Id = 1, Title = "New Updates Page Launched!",
                    Content = "<p>This has been an exciting period of growth for me as a developer. AI has turned the corner where it becomes a real multiplier for what I am able to do and things will only accelerate from here. Building features onto a website can finally occur at nearly the speed of thought and it's only limited by my imagination. Let's see what comes next!</p>",
                    PostedDate = new DateTime(2025, 5, 28, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Website Update"), tags.Single(t => t.Name == "Personal Update") }
                },
                new UpdatePost
                {
                    Id = 2,
                    Title = "Server Browser Enhancements",
                    Content = "<p>The game server browser has received significant updates to filter out fake servers, especially for CS 1.6 and CS2. We're also now pulling more servers per pull, and caching the results for 5 minutes to ensure a good list is available.</p><p>I've also unified the data populating the server browser with the primary games model on the website for further integration and linking. This created some data stubs in the games listing, but we can fill that out with time, and I'm proud to now have more than 100 games on the server browser.</p>",
                    PostedDate = new DateTime(2025, 5, 28, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Website Update"), tags.Single(t => t.Name == "Gaming Update") }
                },
                new UpdatePost
                {
                    Id = 3,
                    Title = "New philosophy page, and other updates",
                    Content = "<p>I added a new base philosophy page for the Tractatus explorer to link from, in addition to some other information I'll continue to fill in. I'm not entirely sure what the final form will be. I've also added all the good lightgun games I know of from Steam to the games page, let me know if you know of any other games that work with the Sinden lightguns or other lightguns. I also slightly changed the url routing of the individual game, map, and engine pages, sorry if that breaks any bookmarks or anything, but I wanted to get that change in to clean up the urls.</p>",
                    PostedDate = new DateTime(2025, 6, 21, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Website Update") }
                }, 
                new UpdatePost
                {
                    Id = 4,
                    Title = "New books page",
                    Content = "<p>I added a new books page with all of Robert A. Heinlein's books. I think I'll do a few other authors and sets of books where I feel the information could be organized better. I also did some more work to unify the server browser into the site rather than being tacked on. The site evolves but that's intentional, who can say what it will be in a few years?</p>",
                    PostedDate = new DateTime(2025, 7, 5, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Website Update") }
                }
            };
            return (posts, tags);
        }
    }
} 