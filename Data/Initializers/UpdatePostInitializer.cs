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
                }
            };
            return (posts, tags);
        }
    }
} 