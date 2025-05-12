using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using ASP_site.Models;
using ASP_site.Data.Initializers;
using System.ComponentModel.DataAnnotations;
using System;
using System.Reflection;

namespace ASP_site.Pages.Years
{
    public class IndexModel : PageModel
    {
        private List<ASP_site.Models.YearEntry> _allEntries;

        public IndexModel()
        {
            _allEntries = YearEntryInitializer.GetYearEntries();
            TimelineEntries = new List<ASP_site.Models.YearEntry>(); // Initialize to empty, will be populated in OnGet

            // Populate ContentTypes from Enum
            ContentTypes = new SelectList(Enum.GetValues(typeof(ContentType))
                .Cast<ContentType>()
                .Select(e => new SelectListItem { Value = e.ToString(), Text = e.ToString() })
                .ToList(), "Value", "Text");

            // Populate AgeAppropriatenessLevels from Enum, respecting Display attribute
            AgeAppropriatenessLevels = new SelectList(Enum.GetValues(typeof(AgeAppropriateness))
                .Cast<AgeAppropriateness>()
                .Select(e => new SelectListItem
                {
                    Value = e.ToString(),
                    Text = GetEnumDisplayName(e)
                })
                .ToList(), "Value", "Text");

            SortOptions = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Value = "Year", Text = "Year (Event)" },
                new SelectListItem { Value = "Title", Text = "Title" },
                new SelectListItem { Value = "Published", Text = "Published Date" }
            }, "Value", "Text");
        }

        public IList<ASP_site.Models.YearEntry> TimelineEntries { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SelectedContentType { get; set; }
        public SelectList? ContentTypes { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SelectedAgeAppropriateness { get; set; }
        public SelectList? AgeAppropriatenessLevels { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SortField { get; set; } = "Year"; // Default sort
        public SelectList? SortOptions { get; set; }

        public void OnGet()
        {
            IEnumerable<ASP_site.Models.YearEntry> entries = _allEntries;

            if (!string.IsNullOrEmpty(SelectedContentType) && Enum.TryParse<ContentType>(SelectedContentType, out var contentTypeEnum))
            {
                entries = entries.Where(e => e.Type == contentTypeEnum);
            }

            if (!string.IsNullOrEmpty(SelectedAgeAppropriateness) && Enum.TryParse<AgeAppropriateness>(SelectedAgeAppropriateness, out var ageEnum))
            {
                entries = entries.Where(e => e.Age == ageEnum);
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(s => (s.Title != null && s.Title.Contains(SearchString, StringComparison.OrdinalIgnoreCase)) ||
                                             (s.Description != null && s.Description.Contains(SearchString, StringComparison.OrdinalIgnoreCase)));
            }

            // Apply Sorting
            switch (SortField)
            {
                case "Title":
                    entries = entries.OrderBy(e => e.Title).ThenBy(e => e.Year);
                    break;
                case "Published":
                    // Assuming Published is a string that can be parsed to int or compared lexicographically
                    // For more robust sorting, convert to DateTime or int if possible.
                    entries = entries.OrderBy(e => e.Published).ThenBy(e => e.Year);
                    break;
                default: // Year and any other case
                    entries = entries.OrderBy(e => e.Year).ThenBy(e => e.StartDate).ThenBy(e => e.Title);
                    break;
            }

            TimelineEntries = entries.ToList();
        }

        // Helper to get DisplayName for enums, made public static to be accessible from Razor page
        public static string GetEnumDisplayName(Enum? enumValue) // Changed to public static and nullable Enum
        {
            if (enumValue == null) return "-"; // Handle null enum values gracefully
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()?.GetName() ?? enumValue.ToString();
        }

        public static string GetEra(int year)
        {
            if (year <= -3000) return "Prehistory";
            if (year <= -1200) return "Bronze Age";  //Bronze Age (3000 BCE to 1200 BC)
            if (year <= -550) return "Iron Age"; // Iron Age (1200 BC to 550 BC) 
            if (year <= 1) return "Early Classical Era"; // Early Classical Era (550 BC to 1 AD)
            if (year <= 476) return "Latter Classical Era"; // Latter Classical Era (1 AD to 476 AD, Fall of Western Roman Empire)
            if (year <= 1000) return "Early Medieval"; // Early Middle Ages (476 to 1000)
            if (year <= 1250) return "High Medieval"; // High Middle Ages (1000 to 1250)
            if (year <= 1491) return "Late Medieval"; // Late Middle Ages (1250 to 1453, eve of Columbus' voyage)
            if (year <= 1788) return "Renaissance"; // Up to eve of French Revolution
            if (year <= 1945) return "Early Modern"; // Up to end of WWII
            if (year <= 2045) return "Contemporary"; // Roughly up to a generation from now
            if (year > 2045) return "Future";
            return "Unknown"; // Default fallback
        }
    }
} 