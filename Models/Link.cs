using System.ComponentModel.DataAnnotations;

namespace ASP_site.Models
{
    public enum LinkType { Official, Community, OfficialDiscord, CommunityDiscord, PickupDiscord, 
        Documentary, Guide, Gameplay, Highlights, Store, Stats, Download, SteamDB, Trailer, Wiki }

    public class Link
    {
        [Key]
        public required string Url { get; set; }
        public string Label { get; set; } = "Link";
        public LinkType LinkType { get; set; } = LinkType.Community;
        public string Description { get; set; } = "";
        public string GameID { get; set; } = "";
        public string? MapID { get; set; }
    }
} 