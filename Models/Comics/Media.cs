using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ASP_site.Models
{
    public class Media
    {
        [Key]
        public string MediaID { get; set; } = "";
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public MediaType MediaType { get; set; }
        public int ReleaseYear { get; set; }
        public int? ReleaseMonth { get; set; }
        public int? ReleaseDay { get; set; }
        public int? SettingYear { get; set; }
        public SettingCalendar SettingCalendar { get; set; } = SettingCalendar.Gregorian;
        
        // Used only for initialization, not saved to DB
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public List<string> AdaptedFromArcIDs { get; set; } = new List<string>();

        // Navigation property for many-to-many relationship
        public ICollection<StoryArc> AdaptedFromArcs { get; set; } = new List<StoryArc>();
    }

    public enum MediaType { Movie, TVShow, Other }
}