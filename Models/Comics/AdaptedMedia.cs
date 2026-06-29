using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ASP_site.Models
{
    public class AdaptedMedia
    {
        [Key]
        public string AdaptedMediaID { get; set; } = "";
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public MediaType MediaType { get; set; }
        public int ReleaseYear { get; set; }
        public List<string> AdaptedFromArcIDs { get; set; } = new List<string>();
    }
}

public enum MediaType { Movie, TVShow, Game, Other }