namespace ASP_site.Models.Gunpla
{
    public class KitRelationship
    {
        public int Id { get; set; }
        
        public string KitId { get; set; } = "";
        public GunplaKit Kit { get; set; } = null!;

        public string RelatedKitId { get; set; } = "";
        public GunplaKit RelatedKit { get; set; } = null!;

        public KitRelationshipType Type { get; set; }
        public string? Description { get; set; }
    }

    public enum KitRelationshipType
    {
        CombinesWith,   // This kit combines with the related kit (e.g. G-Defenser + Mk II)
        PartSwap,       // Can swap parts with (e.g. Core Gundam planets)
        Recolor,        // This kit is a strict recolor of the related kit (shares all parts)
        Remix,          // This kit shares parts/mold with the related kit
        Requires,       // This kit requires the related kit (e.g. Expansion sets)
        Includes,       // This kit includes the related kit (e.g. Optional parts or Re-releases)
    }
}
