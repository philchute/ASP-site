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
                },
                new UpdatePost
                {
                    Id = 10,
                    Title = "New title page",
                    Content = "<p>The website has a new star constellation themed home page to accommodate the growing number of pages. I also added an author page for Ted Chiang, as I intend to read all of his stories and books. Fixed a bug on the links page where the dropdown showed options with no links.</p>",
                    PostedDate = new DateTime(2025, 12, 19, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Website Update") }
                },
                new UpdatePost
                {
                    Id = 11,
                    Title = "New chess section!",
                    Content = "<p>I've added a new section of Chess related pages, including a listing of pieces and variants, a listing of armies that can be played against each other, and a notation parser for the Betza notation system. This was a fun and intense coding project that really got me back to full-speed here. Like most of the pages here, these pages will never really be 'complete' but I hope to add a lot more information there, refine the data over time, and better integrate things together and with other sites. Shogi removed as a game and listed as a variant.</p>",
                    PostedDate = new DateTime(2025, 12, 27, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Website Update") }
                },
                new UpdatePost
                {
                    Id = 12,
                    Title = "New visuals, new Blog section",
                    Content = "<p>I liked the new visuals from the spash page so I spread them to the rest of the site. Added a new Blog section for longer writing than this page which can just be for site updates. Redid the Engines page display and added some more engine and game data.</p>",
                    PostedDate = new DateTime(2025, 12, 29, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Website Update") }
                },
                new UpdatePost
                {
                    Id = 13,
                    Title = "New scale reference page",
                    Content = "<p>I've added a new scale reference page with scales for various model trains and wargames. You can see relative size of some things and generate a PDF file with correct scaling. As always there's more work that can be done here but it's a nice start to something useful.</p>",
                    PostedDate = new DateTime(2026, 1, 11, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Website Update") }
                },
                new UpdatePost  
                {
                    Id = 14,
                    Title = "New Gunpla section",
                    Content = "<p>I've added a new Gunpla section with a dashboard to track your collection. This will list the gundam kits from different grades and timelines. As always this is a work in progress. I'm better at starting projects than finishing them, but we'll see how it goes. Added Ayn Rand author page.</p>",
                    PostedDate = new DateTime(2026, 1, 14, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Website Update") }
                },
                new UpdatePost
                {
                    Id = 15,
                    Title = "New events page",
                    Content = "<p>I've added a new events page with a listing of upcoming events. Again trying to make public things I track in my head or on spreadsheets.</p>",
                    PostedDate = new DateTime(2026, 2, 3, 12, 0, 0, DateTimeKind.Utc), Author = "Phil",
                    Tags = new List<Tag> { tags.Single(t => t.Name == "Website Update") }
                }

            };
            return (posts, tags);
        }
    }
} 