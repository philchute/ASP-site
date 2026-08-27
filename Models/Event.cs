using System.ComponentModel.DataAnnotations;

namespace ASP_site.Models
{
    public enum EventCategoryGroup { Esports, Racing, Sports, Local }
    public enum EventCategory
    {
        [Display(Name = "Apex Legends")] ApexLegends,
        [Display(Name = "Call of Duty")] CallOfDuty,
        [Display(Name = "Counter-Strike")] CounterStrike,
        [Display(Name = "Dota 2")] Dota2,
        [Display(Name = "Fighting Games")] FightingGames,
        Fortnite,
        [Display(Name = "League of Legends")] LeagueOfLegends,
        [Display(Name = "Overwatch 2")] Overwatch2,
        PUBG,
        [Display(Name = "Rainbow Six Siege")] RainbowSixSiege,
        [Display(Name = "Rocket League")] RocketLeague,
        Trackmania,
        Valorant,
        Chess,
        NASCAR,
        F1,
        IndyCar,
        Soccer,
        Olympics,
        Other
    }
    public enum WatchPlatform { BroadcastTV, CableTV, Free, Paid }

    public class Event
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        [Required]
        public DateOnly Day { get; set; }
        /// <summary>Time in Eastern, used for sorting. Null for TBD/unknown.</summary>
        public TimeOnly? SortTime { get; set; }
        /// <summary>Custom display (e.g. "TBD", "sunset"). When set, overrides helper formatting.</summary>
        public string? TimeDisplay { get; set; }
        public string? Link { get; set; }
        public WatchPlatform? Platform { get; set; }
        public string? Channel { get; set; }
        public EventCategoryGroup? CategoryGroup { get; set; }
        public EventCategory? Category { get; set; }

        /// <summary>Formats SortTime as "7:00 PM ET" (or custom suffix). Use TimeDisplay when set for values like "TBD" or "sunset".</summary>
        public static string FormatTime(TimeOnly? sortTime, string? timeDisplay, string? suffix = "ET")
        {
            if (!string.IsNullOrEmpty(timeDisplay)) return timeDisplay;
            if (!sortTime.HasValue) return string.Empty;
            var formatted = sortTime.Value.ToString("h:mm tt");
            return string.IsNullOrEmpty(suffix) ? formatted : $"{formatted} {suffix}";
        }
    }
}
