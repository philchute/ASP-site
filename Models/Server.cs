using System.ComponentModel.DataAnnotations;

namespace ASP_site.Models
{
    public enum ServerType { Official, Pickup, Public, Skills }

    public class Server
    {
        [Key]
        public required string IPAddress { get; set; }
        public string Name { get; set; } = "Server";
        public ServerType ServerType { get; set; } = ServerType.Public;
        public string Description { get; set; } = "";
        public string? GameID { get; set; }
    }
}