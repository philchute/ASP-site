using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using ASP_site.Models;
using ASP_site.Data;
using System.ComponentModel.DataAnnotations;
using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace ASP_site.Pages.Years
{
    public class IndexModel : PageModel
    {
        private readonly GameContext _context;

        // Helper dictionaries for checkboxes
        public Dictionary<string, string> AllContentTypes { get; private set; }
        public Dictionary<string, string> GregorianCalendars { get; private set; }
        public Dictionary<string, string> FictionalCalendars { get; private set; }


        public IndexModel(GameContext context)
        {
            _context = context;
            TimelineEntries = new List<ASP_site.Models.YearEntry>();

            // Populate checkbox options for ContentTypes
            AllContentTypes = Enum.GetValues(typeof(ContentType))
                                .Cast<ContentType>()
                                .ToDictionary(e => e.ToString(), e => e.ToString());

            GregorianCalendars = new Dictionary<string, string>
            {
                [nameof(SettingCalendar.Gregorian)] = GetEnumDisplayName(SettingCalendar.Gregorian)
            };
            FictionalCalendars = Enum.GetValues<SettingCalendar>()
                .Where(c => c != SettingCalendar.Gregorian)
                .ToDictionary(c => c.ToString(), c => GetEnumDisplayName(c));

            // Simplified Sort Options
            SortOptions = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Value = "Year", Text = "Year" },
                new SelectListItem { Value = "Title", Text = "Title" },
                new SelectListItem { Value = "Published", Text = "Published" }
            }, "Value", "Text");

            // Initialize lists
            SelectedContentTypes = new List<string>();
            SelectedAgeAppropriateness = new List<string>();
            SelectedCalendars = new List<string>();
        }

        public IList<ASP_site.Models.YearEntry> TimelineEntries { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedContentTypes { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedAgeAppropriateness { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedCalendars { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SortField { get; set; } = "Year";
        public SelectList? SortOptions { get; set; }

        public async Task OnGetAsync()
        {
            // Initialize selections if empty (treat as 'All' selected)
            if (SelectedContentTypes == null || !SelectedContentTypes.Any())
            {
                 SelectedContentTypes = AllContentTypes.Keys.ToList();
            }
             if (SelectedAgeAppropriateness == null || !SelectedAgeAppropriateness.Any())
            {
                 // When empty, consider all possible enum values selected
                 SelectedAgeAppropriateness = Enum.GetNames(typeof(AgeAppropriateness)).ToList(); 
            }
            if (SelectedCalendars == null || !SelectedCalendars.Any())
            {
                SelectedCalendars = new List<string> { nameof(SettingCalendar.Gregorian) };
            }

            var catalogGames = await _context.Games.AsNoTracking()
                .Where(g => g.SettingYear.HasValue)
                .ToListAsync();
            var catalogBooks = await _context.Books.AsNoTracking()
                .Where(b => b.SettingYear.HasValue)
                .ToListAsync();
            var catalogMedia = await _context.Media.AsNoTracking()
                .Where(m => m.SettingYear.HasValue)
                .ToListAsync();
            var yearEntries = await _context.YearEntries.AsNoTracking().ToListAsync();

            var gamesWithSettingYear = catalogGames
                .Select(g => g.GameID)
                .ToHashSet(StringComparer.OrdinalIgnoreCase);
            var booksWithSettingYear = catalogBooks
                .Select(b => b.Title)
                .ToHashSet(StringComparer.OrdinalIgnoreCase);
            var mediaWithSettingYear = catalogMedia
                .Select(m => m.MediaID)
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            IEnumerable<ASP_site.Models.YearEntry> entries = catalogGames.Select(ASP_site.Models.YearEntry.FromGame)
                .Concat(catalogBooks.Select(ASP_site.Models.YearEntry.FromBook))
                .Concat(catalogMedia.Select(ASP_site.Models.YearEntry.FromMedia))
                .Concat(yearEntries.Where(e => !IsSupersededByCatalog(e, gamesWithSettingYear, booksWithSettingYear, mediaWithSettingYear)));

            if (SelectedContentTypes != null && SelectedContentTypes.Any() && SelectedContentTypes.Count < AllContentTypes.Count)
            {
                entries = entries.Where(e => e.Type.HasValue && SelectedContentTypes.Contains(e.Type.Value.ToString()));
            }

            if (SelectedAgeAppropriateness != null && SelectedAgeAppropriateness.Any() && SelectedAgeAppropriateness.Count < Enum.GetNames(typeof(AgeAppropriateness)).Length)
            {
                entries = entries.Where(e => e.Age.HasValue && SelectedAgeAppropriateness.Contains(e.Age.Value.ToString()));
            }

            if (SelectedCalendars.Any())
            {
                entries = entries.Where(e => SelectedCalendars.Contains(e.SettingCalendar.ToString()));
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(s => (s.Title != null && s.Title.Contains(SearchString, StringComparison.OrdinalIgnoreCase)) ||
                                             (s.Description != null && s.Description.Contains(SearchString, StringComparison.OrdinalIgnoreCase)));
            }

            TimelineEntries = SortField switch
            {
                "Title" => entries.OrderBy(e => e.Title).ThenBy(e => e.Year).ToList(),
                "Published" => entries
                    .OrderBy(e => e.GetPublishedYear() ?? int.MaxValue)
                    .ThenBy(e => e.Year)
                    .ThenBy(e => e.Title)
                    .ToList(),
                _ => entries.OrderBy(e => e.Year).ThenBy(e => e.Title).ToList()
            };
        }

        private static bool IsSupersededByCatalog(
            ASP_site.Models.YearEntry entry,
            HashSet<string> gamesWithSettingYear,
            HashSet<string> booksWithSettingYear,
            HashSet<string> mediaWithSettingYear)
        {
            if (entry.Type == ContentType.GameMission)
            {
                return false;
            }

            if (entry.Type == ContentType.Game
                && !string.IsNullOrEmpty(entry.GameID)
                && gamesWithSettingYear.Contains(entry.GameID))
            {
                return true;
            }

            if (entry.Type == ContentType.Book
                && !string.IsNullOrEmpty(entry.BookTitle)
                && booksWithSettingYear.Contains(entry.BookTitle))
            {
                return true;
            }

            if ((entry.Type == ContentType.Movie || entry.Type == ContentType.Series || entry.Type == ContentType.Episode)
                && !string.IsNullOrEmpty(entry.MediaID)
                && mediaWithSettingYear.Contains(entry.MediaID))
            {
                return true;
            }

            return false;
        }

        // Helper to get DisplayName for enums
        public static string GetEnumDisplayName(Enum? enumValue) 
        {
            if (enumValue == null) return "-"; 
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()?.GetName() ?? enumValue.ToString();
        }

        public static string GetEra(int year) => GetEra(year, SettingCalendar.Gregorian);

        public static string GetEra(int year, SettingCalendar calendar)
        {
            if (calendar == SettingCalendar.AfterGuild) return "Dune";
            if (calendar == SettingCalendar.MiddleEarth) return year < 0 ? "Second Age" : "Third Age";
            if (year <= -3000) return "Prehistory";
            if (year <= -1200) return "Bronze Age";  //Bronze Age (3000 BCE to 1200 BC)
            if (year <= -550) return "Iron Age"; // Iron Age (1200 BC to 550 BC) 
            if (year <= 1) return "Early Classical"; // Early Classical Era (550 BC to 1 AD)
            if (year <= 476) return "Latter Classical"; // Latter Classical Era (1 AD to 476 AD, Fall of Western Roman Empire)
            if (year <= 1000) return "Early Medieval"; // Early Middle Ages (476 to 1000)
            if (year <= 1250) return "High Medieval"; // High Middle Ages (1000 to 1250)
            if (year <= 1491) return "Late Medieval"; // Late Middle Ages (1250 to 1453, eve of Columbus' voyage)
            if (year <= 1788) return "Renaissance"; // Up to eve of French Revolution
            if (year <= 1945) return "Modern"; // Up to end of WWII
            if (year <= 2030) return "Contemporary"; // Current time
            if (year > 2030) return "Future";
            return "Unknown"; // Default fallback
        }
    }
} 