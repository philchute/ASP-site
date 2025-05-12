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

        // Helper dictionaries for checkboxes
        public Dictionary<string, string> AllContentTypes { get; private set; }


        public IndexModel()
        {
            _allEntries = YearEntryInitializer.GetYearEntries();
            TimelineEntries = new List<ASP_site.Models.YearEntry>();

            // Populate checkbox options for ContentTypes
            AllContentTypes = Enum.GetValues(typeof(ContentType))
                                .Cast<ContentType>()
                                .ToDictionary(e => e.ToString(), e => e.ToString());

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
        }

        public IList<ASP_site.Models.YearEntry> TimelineEntries { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedContentTypes { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedAgeAppropriateness { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SortField { get; set; } = "Year";
        public SelectList? SortOptions { get; set; }

        public void OnGet()
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


            IEnumerable<ASP_site.Models.YearEntry> entries = _allEntries;

            // Filter by selected Content Types
            // Check count against AllContentTypes dictionary size
            if (SelectedContentTypes != null && SelectedContentTypes.Any() && SelectedContentTypes.Count < AllContentTypes.Count) 
            {
                entries = entries.Where(e => e.Type.HasValue && SelectedContentTypes.Contains(e.Type.Value.ToString()));
            }

            // Filter by selected Age Appropriateness levels
            // Check count against total number of AgeAppropriateness enum values
            if (SelectedAgeAppropriateness != null && SelectedAgeAppropriateness.Any() && SelectedAgeAppropriateness.Count < Enum.GetNames(typeof(AgeAppropriateness)).Length)
            {
                entries = entries.Where(e => SelectedAgeAppropriateness.Contains(e.Age.ToString()));
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
                    entries = entries.OrderBy(e => string.IsNullOrEmpty(e.Published)).ThenBy(e => e.Published).ThenBy(e => e.Year);
                    break;
                default: // Year
                    entries = entries.OrderBy(e => e.Year).ThenBy(e => e.StartDate).ThenBy(e => e.Title);
                    break;
            }

            TimelineEntries = entries.ToList();
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

        public static string GetEra(int year)
        {
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
            if (year <= 2030) return "Contemporary"; // Roughly up to a generation from now
            if (year > 2030) return "Future";
            return "Unknown"; // Default fallback
        }
    }
} 