using System.ComponentModel.DataAnnotations;

namespace ASP_site.Models
{
    public enum LinkType { OfficialSite, CommunitySite, OfficialDiscord, CommunityDiscord, PickupDiscord, GameplayGuide, GameplayVideo, StoreLink, StatsLink, CommunityPort, SteamDB, Trailer }

    public class Link
    {
        [Key]
        public required string Url { get; set; }
        public string Label { get; set; } = "Link";
        public LinkType LinkType { get; set; } = LinkType.CommunitySite;
        public string Description { get; set; } = "";
        public string? GameID { get; set; }
    }
} 