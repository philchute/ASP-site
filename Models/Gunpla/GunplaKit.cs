using ASP_site.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_site.Models.Gunpla
{
    public class GunplaKit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; } = ""; // Grade Series Number (e.g. RG-001)

       [NotMapped]
        public List<string> GundamModels { get; set; } = new();
        public List<Gundam> Gundams { get; set; } = new();
        public string? Faction { get; set; }
        public string? KitName { get; set; } // For overriding the Gundam Common Name (e.g. "Gundam Kimaris Trooper")
        public string? Description { get; set; }
        public GunplaGrade Grade { get; set; } // Doubles as ItemType
        public string Scale { get; set; } = ScaleConverterService.Scale1_144.Name;
        public int ReleaseYear { get; set; }     
        public string Manufacturer { get; set; } = "Bandai";
    }
}
