using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_site.Models.Gunpla
{
    public class GunplaKit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; } = ""; // Grade Series Number (e.g. RG-001)

        public string GundamModelNumber { get; set; } = "";
        
        [ForeignKey("GundamModelNumber")]
        public Gundam? Gundam { get; set; }

        public string? KitName { get; set; } // For overriding the Gundam Common Name (e.g. "Gundam Kimaris Trooper")

        public GunplaGrade Grade { get; set; }
        public int ReleaseYear { get; set; }
    }
}
