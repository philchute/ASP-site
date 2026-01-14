using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_site.Models.Gunpla
{
    public class UserKitEntry
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; } = "";
        public string KitId { get; set; } = "";
        
        [ForeignKey("KitId")]
        public GunplaKit? Kit { get; set; }

        public KitStatus Status { get; set; }
        public decimal? PricePaid { get; set; }
        public string Notes { get; set; } = "";
    }
}
