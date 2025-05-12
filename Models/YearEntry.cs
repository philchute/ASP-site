using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_site.Models
{
    public enum ContentType  { Book, Play, Movie, Series, Episode, Game, GameMission }
    public enum AgeAppropriateness { Early, Middle, Teen, Adult }

    public class YearEntry
    {
        [Required] public int ID { get; set; }
        [Required] public int Year { get; set; } 
        public string? Title { get; set; }
        public ContentType? Type { get; set; }
        public AgeAppropriateness? Age { get; set; }
        public string? Description { get; set; }
        public string? GameID { get; set; }
        public string? Published { get; set; }
        public string? Availability { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}