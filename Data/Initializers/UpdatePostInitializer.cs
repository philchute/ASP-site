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
                },
                new UpdatePost
                {
                    Id = 5,
                    Title = "New games added to the server browser",
                    Content = "<p>I've begun adding GameSpy based games to the server browser. 333Networks runs a replacement master server so I was able to get from them the info for unreal engine based games including UT99 and MoH:AA and several others. Hope to add even more classic games to the browser.</p>",
                    PostedDate = new DateTime(2025, 7, 6, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Website Update"), tags.Single(t => t.Name == "Gaming Update") }
                },
                new UpdatePost
                {
                    Id = 6,
                    Title = "New CCG page, more authors added to the books section",
                    Content = "<p>I've added a new CCG page with the current status of all of the CCGs in NA that I know of. I've also added Arthur C. Clarke and Isaac Asimov to the books page, completing the 'big three' of golden age science fiction. I'm going to add a few more authors and fill in some more information. Like a lot of pages here, I'm hoping that is more of a beginning scaffolding than a completed project.</p>",
                    PostedDate = new DateTime(2025, 7, 19, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Website Update"), tags.Single(t => t.Name == "Gaming Update") }
                },
                new UpdatePost
                {
                    Id = 7,
                    Title = "More updates",
                    Content = "<p>Changed the server page url to be based on ID rather than position in the list. Added more icons to the Games page, and an icon to signify and link to the Server Browser for that game, and added a link on the Game Info page to the Server Browser for that game. Fixed an issue with the maps not displaying on the Maps page, updated the competitive maps for season 3 of CS2, minor changes to the Engine info page.</p>",
                    PostedDate = new DateTime(2025, 7, 19, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Website Update"), tags.Single(t => t.Name == "Gaming Update") }
                },
                new UpdatePost
                {
                    Id = 8,
                    Title = "And we're back",
                    Content = "<p>PC issues put me offline for more time than I expected. Ultimately bought a new PC but we're back now. Small update here to get back into the swing of things. CCG page has new information and some slight reorganization.</p>",
                    PostedDate = new DateTime(2025, 12, 5, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Personal Update"), tags.Single(t => t.Name == "Website Update") }
                },
                new UpdatePost
                {
                    Id = 9,
                    Title = "Game Server Browser Update",
                    Content = "<p>Added proper domain name support for the server browser, fixing an issue with some old IPs which now won't need to be replaced. Fixed issue where Day of Defeat was showing DoD:Source servers.</p>",
                    PostedDate = new DateTime(2025, 12, 7, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Website Update"), tags.Single(t => t.Name == "Gaming Update") }
                }
            };
            return (posts, tags);
        }
    }
} 