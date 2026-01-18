using System.ComponentModel.DataAnnotations;

namespace ASP_site.Models.Gunpla
{
    public class Gundam
    {
        [Key]
        public string ModelNumber { get; set; } = ""; // e.g., 'GAT-X105'
        public string CommonName { get; set; } = ""; // e.g., 'Strike Gundam'
        public string Timeline { get; set; } = "";
        public string Description { get; set; } = "";
        public string? Faction { get; set; }
        public List<string> Series { get; set; } = new();
    }
}
