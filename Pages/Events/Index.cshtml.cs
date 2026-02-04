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
using System.Text;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ASP_site.Pages.Events
{
    public class IndexModel : PageModel
    {
        private readonly GameContext _context;

        public Dictionary<string, string> AllCategoryGroups { get; private set; }
        public Dictionary<string, string> AllCategories { get; private set; }
        public Dictionary<string, string> AllPlatforms { get; private set; }

        public IndexModel(GameContext context)
        {
            _context = context;
            EventList = new List<Event>();

            AllCategoryGroups = Enum.GetValues(typeof(EventCategoryGroup))
                .Cast<EventCategoryGroup>()
                .ToDictionary(e => e.ToString(), e => e.ToString());
            AllCategories = Enum.GetValues(typeof(EventCategory))
                .Cast<EventCategory>()
                .ToDictionary(e => e.ToString(), e => e.ToString());
            AllPlatforms = Enum.GetValues(typeof(WatchPlatform))
                .Cast<WatchPlatform>()
                .ToDictionary(e => e.ToString(), e => e.ToString());

            SortOptions = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Value = "Day", Text = "Date" },
                new SelectListItem { Value = "Name", Text = "Name" }
            }, "Value", "Text");

            SelectedCategoryGroups = new List<string>();
            SelectedCategories = new List<string>();
            SelectedPlatforms = new List<string>();
        }

        public IList<Event> EventList { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedCategoryGroups { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedCategories { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedPlatforms { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool ShowPastEvents { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SortField { get; set; } = "Day";
        public SelectList? SortOptions { get; set; }

        public async Task OnGetAsync()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var allCategoryGroupNames = AllCategoryGroups.Keys.ToList();
            var allCategoryNames = AllCategories.Keys.ToList();
            var allPlatformNames = AllPlatforms.Keys.ToList();

            if (SelectedCategoryGroups == null || !SelectedCategoryGroups.Any())
            {
                SelectedCategoryGroups = new List<string> { "Esports", "Racing", "Sports" };
            }
            if (SelectedCategories == null || !SelectedCategories.Any())
            {
                SelectedCategories = allCategoryNames;
            }
            if (SelectedPlatforms == null || !SelectedPlatforms.Any())
            {
                SelectedPlatforms = allPlatformNames;
            }

            IQueryable<Event> query = _context.Events.AsQueryable();

            // Hide past events by default
            if (!ShowPastEvents)
            {
                query = query.Where(e => e.Day >= today);
            }

            // Filter by category group
            if (SelectedCategoryGroups != null && SelectedCategoryGroups.Any() && SelectedCategoryGroups.Count < allCategoryGroupNames.Count)
            {
                query = query.Where(e => e.CategoryGroup.HasValue && SelectedCategoryGroups.Contains(e.CategoryGroup.Value.ToString()));
            }

            // Filter by category
            if (SelectedCategories != null && SelectedCategories.Any() && SelectedCategories.Count < allCategoryNames.Count)
            {
                query = query.Where(e => e.Category.HasValue && SelectedCategories.Contains(e.Category.Value.ToString()));
            }

            // Filter by platform
            if (SelectedPlatforms != null && SelectedPlatforms.Any() && SelectedPlatforms.Count < allPlatformNames.Count)
            {
                query = query.Where(e => e.Platform.HasValue && SelectedPlatforms.Contains(e.Platform.Value.ToString()));
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                query = query.Where(e =>
                    (e.Name != null && e.Name.Contains(SearchString, StringComparison.OrdinalIgnoreCase)) ||
                    (e.Description != null && e.Description.Contains(SearchString, StringComparison.OrdinalIgnoreCase)));
            }

            switch (SortField)
            {
                case "Name":
                    query = query.OrderBy(e => e.Name).ThenBy(e => e.Day).ThenBy(e => e.SortTime == null ? 1 : 0).ThenBy(e => e.SortTime).ThenBy(e => e.Name);
                    break;
                default:
                    // SortTime null = TBD, sort after known times on same day
                    query = query.OrderBy(e => e.Day).ThenBy(e => e.SortTime == null ? 1 : 0).ThenBy(e => e.SortTime).ThenBy(e => e.Name);
                    break;
            }

            EventList = await query.ToListAsync();
        }

        private async Task<IList<Event>> GetFilteredEventsAsync()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var allCategoryGroupNames = AllCategoryGroups.Keys.ToList();
            var allCategoryNames = AllCategories.Keys.ToList();
            var allPlatformNames = AllPlatforms.Keys.ToList();

            var selGroups = SelectedCategoryGroups ?? new List<string>();
            var selCats = SelectedCategories ?? new List<string>();
            var selPlatforms = SelectedPlatforms ?? new List<string>();

            if (!selGroups.Any()) selGroups = new List<string> { "Esports", "Racing", "Sports" };
            if (!selCats.Any()) selCats = allCategoryNames;
            if (!selPlatforms.Any()) selPlatforms = allPlatformNames;

            var query = _context.Events.AsQueryable();
            if (!ShowPastEvents) query = query.Where(e => e.Day >= today);
            if (selGroups.Any() && selGroups.Count < allCategoryGroupNames.Count)
                query = query.Where(e => e.CategoryGroup.HasValue && selGroups.Contains(e.CategoryGroup.Value.ToString()));
            if (selCats.Any() && selCats.Count < allCategoryNames.Count)
                query = query.Where(e => e.Category.HasValue && selCats.Contains(e.Category.Value.ToString()));
            if (selPlatforms.Any() && selPlatforms.Count < allPlatformNames.Count)
                query = query.Where(e => e.Platform.HasValue && selPlatforms.Contains(e.Platform.Value.ToString()));
            if (!string.IsNullOrEmpty(SearchString))
                query = query.Where(e => (e.Name != null && e.Name.Contains(SearchString, StringComparison.OrdinalIgnoreCase)) ||
                    (e.Description != null && e.Description.Contains(SearchString, StringComparison.OrdinalIgnoreCase)));

            query = SortField == "Name"
                ? query.OrderBy(e => e.Name).ThenBy(e => e.Day).ThenBy(e => e.SortTime == null ? 1 : 0).ThenBy(e => e.SortTime)
                : query.OrderBy(e => e.Day).ThenBy(e => e.SortTime == null ? 1 : 0).ThenBy(e => e.SortTime).ThenBy(e => e.Name);

            return await query.ToListAsync();
        }

        public async Task<IActionResult> OnGetExportAsync()
        {
            EventList = await GetFilteredEventsAsync();
            var csv = BuildCsv();
            return File(Encoding.UTF8.GetBytes(csv), "text/csv", "events.csv");
        }

        public async Task<IActionResult> OnGetEventsPdfAsync()
        {
            EventList = await GetFilteredEventsAsync();
            QuestPDF.Settings.EnableDebugging = false;
            var generated = DateTime.Now.ToString("yyyy-MM-dd");
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(9));
                    page.Header()
                        .Column(c =>
                        {
                            c.Item().Text("Events")
                                .SemiBold().FontSize(18).FontColor(Colors.Black);
                            c.Item().Text($"Generated {generated} · {EventList.Count} events (times in ET)")
                                .FontSize(10).FontColor(Colors.Grey.Darken1);
                        });
                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            if (!EventList.Any())
                            {
                                x.Item().Text("No events match your filters.").Italic().FontColor(Colors.Grey.Darken1);
                                return;
                            }
                            foreach (var evt in EventList)
                            {
                                var timeStr = Event.FormatTime(evt.SortTime, evt.TimeDisplay);
                                var watchStr = !string.IsNullOrEmpty(evt.Channel) && evt.Platform.HasValue
                                    ? $"{evt.Channel} ({evt.Platform})" : evt.Platform?.ToString() ?? evt.Channel ?? "-";
                                var catStr = evt.CategoryGroup?.ToString() ?? "-";
                                if (evt.Category.HasValue && evt.Category != EventCategory.Other) catStr += $" / {evt.Category}";
                                x.Item().PaddingVertical(4)
                                    .Column(c =>
                                    {
                                        c.Item().Text(evt.Name ?? "-").Bold().FontSize(10).FontColor(Colors.Black);
                                        c.Item().Text($"{evt.Day:MMM d, yyyy} · {timeStr} · {watchStr} · {catStr}")
                                            .FontSize(8).FontColor(Colors.Grey.Darken1);
                                        if (!string.IsNullOrEmpty(evt.Description))
                                            c.Item().PaddingTop(2).Text(evt.Description).FontSize(8).FontColor(Colors.Grey.Darken2);
                                    });
                                x.Item().LineHorizontal(0.5f).LineColor(Colors.Grey.Lighten2);
                            }
                        });
                    page.Footer()
                        .AlignCenter()
                        .Text(x => { x.Span("Events"); x.Span(" · "); x.CurrentPageNumber(); });
                });
            });
            var stream = new MemoryStream();
            document.GeneratePdf(stream);
            stream.Position = 0;
            return File(stream, "application/pdf", "events.pdf");
        }

        private string BuildCsv()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Name,Date,Time,Platform,Channel,Category,Description,Link");
            foreach (var evt in EventList)
            {
                var timeStr = Event.FormatTime(evt.SortTime, evt.TimeDisplay);
                var platformStr = evt.Platform?.ToString() ?? "";
                var channelStr = evt.Channel ?? "";
                var catStr = evt.CategoryGroup?.ToString() ?? "";
                if (evt.Category.HasValue && evt.Category != EventCategory.Other) catStr += $" / {evt.Category}";
                sb.AppendLine($"{EscapeCsv(evt.Name ?? "")},{evt.Day:yyyy-MM-dd},{timeStr},{platformStr},{EscapeCsv(channelStr)},{EscapeCsv(catStr)},{EscapeCsv(evt.Description ?? "")},{EscapeCsv(evt.Link ?? "")}");
            }
            return sb.ToString();
        }

        private static string EscapeCsv(string value)
        {
            if (value.Contains(',') || value.Contains('"') || value.Contains('\n'))
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }

        /// <summary>Builds query string for export links to preserve current filters.</summary>
        public string GetExportQueryString(string? handler = null)
        {
            var q = new List<string>();
            if (!string.IsNullOrEmpty(handler)) q.Add($"handler={handler}");
            if (!string.IsNullOrEmpty(SearchString)) q.Add($"SearchString={Uri.EscapeDataString(SearchString)}");
            if (ShowPastEvents) q.Add("ShowPastEvents=true");
            if (!string.IsNullOrEmpty(SortField)) q.Add($"SortField={Uri.EscapeDataString(SortField)}");
            foreach (var g in SelectedCategoryGroups ?? Enumerable.Empty<string>()) q.Add($"SelectedCategoryGroups={Uri.EscapeDataString(g)}");
            foreach (var c in SelectedCategories ?? Enumerable.Empty<string>()) q.Add($"SelectedCategories={Uri.EscapeDataString(c)}");
            foreach (var p in SelectedPlatforms ?? Enumerable.Empty<string>()) q.Add($"SelectedPlatforms={Uri.EscapeDataString(p)}");
            return q.Any() ? "?" + string.Join("&", q) : "";
        }

        public static string GetEnumDisplayName(Enum? enumValue)
        {
            if (enumValue == null) return "-";
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault()
                ?.GetCustomAttribute<DisplayAttribute>()?.GetName() ?? enumValue.ToString();
        }

        /// <summary>Returns UTC ISO string for ET Day+SortTime, for client-side local time conversion. Null when not applicable.</summary>
        public static string? GetUtcIsoForEvent(Event evt)
        {
            if (!evt.SortTime.HasValue) return null;
            try
            {
                var eastern = TimeZoneInfo.FindSystemTimeZoneById("America/New_York");
                var dt = new DateTime(evt.Day.Year, evt.Day.Month, evt.Day.Day, evt.SortTime.Value.Hour, evt.SortTime.Value.Minute, 0, DateTimeKind.Unspecified);
                var utc = TimeZoneInfo.ConvertTimeToUtc(dt, eastern);
                return utc.ToString("yyyy-MM-ddTHH:mm:ssZ");
            }
            catch { return null; }
        }
    }
}
