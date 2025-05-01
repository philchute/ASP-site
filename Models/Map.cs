using System.ComponentModel.DataAnnotations;

namespace ASP_site.Models
{
    public class MapGameInfo
    {
        public string? GameID { get; set; }
        public string? FileName { get; set; }
        public string? Author { get; set; } = "";
        public string? Description { get; set; } = "";
    }

    public class Map
    {
        [Key]
        public required string MapID { get; set; }
        public bool IsCompetitive { get; set; } = false;
        public string? Description { get; set; } = "";
        public List<MapGameInfo> GameInfo { get; set; } = new List<MapGameInfo>();

        public static List<Link> GetLinks(Map map, List<Link> allLinks)
        {
            return allLinks.Where(l => 
                l.MapID == map.MapID && // Must match the map ID
                (string.IsNullOrEmpty(l.GameID) || map.GameInfo.Any(g => g.GameID == l.GameID)) // Either no GameID or matches a game version
            ).ToList();
        }
    }
}