using System.ComponentModel.DataAnnotations;

namespace ASP_site.Models.Gunpla
{
    public class Gundam
    {
        [Key]
        public string ModelNumber { get; set; } = ""; // e.g., 'GAT-X105'
        public string CommonName { get; set; } = ""; // e.g., 'Strike Gundam'
        public string Description { get; set; } = "";
        public List<string> Factions { get; set; } = new();
        public List<string> Designers { get; set; } = new();
        public List<string> Series { get; set; } = new();
    }
}
