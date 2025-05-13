using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_site.Models
{
    public enum ContentType  { Book, Play, Movie, Series, Episode, Game, GameMission }
    public enum AgeAppropriateness { Early, Middle, Teen, Adult }

    public class YearEntry
    {
        [Key]
        [Required] public int ID { get; set; }
        [Required] public int Year { get; set; } 
        [Required] public string? Title { get; set; }
        public ContentType? Type { get; set; }
        public AgeAppropriateness? Age { get; set; }
        public string? Description { get; set; }
        public string? GameID { get; set; }
        public string? Published { get; set; }
        public string? Availability { get; set; }
    }
}