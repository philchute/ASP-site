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
        public const int CalendarChipLimit = 3;

        private static readonly string[] DefaultCategoryGroups = { "Esports", "Racing", "Sports" };

        private readonly GameContext _context;
        private TimeZoneInfo _eastern = TimeZoneInfo.Utc;
        private TimeZoneInfo _displayZone = TimeZoneInfo.Utc;

        public Dictionary<string, string> AllCategoryGroups { get; private set; }
        public Dictionary<string, string> AllCategories { get; private set; }
        public Dictionary<string, string> AllPlatforms { get; private set; }

        public IndexModel(GameContext context)
        {
            _context = context;
            EventList = new List<Event>();
            EventViews = new List<EventView>();
            CalendarDays = new List<CalendarCell>();

            AllCategoryGroups = Enum.GetValues(typeof(EventCategoryGroup))
                .Cast<EventCategoryGroup>()
                .ToDictionary(e => e.ToString(), e => e.ToString());
            AllCategories = Enum.GetValues(typeof(EventCategory))
                .Cast<EventCategory>()
                .ToDictionary(e => e.ToString(), e => GetEnumDisplayName(e));
            AllPlatforms = Enum.GetValues(typeof(WatchPlatform))
                .Cast<WatchPlatform>()
                .ToDictionary(e => e.ToString(), e => e.ToString());

            SortOptions = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Value = "Day", Text = "Date" },
                new SelectListItem { Value = "Name", Text = "Name" }
            }, "Value", "Text");

            TimeZoneOptions = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Value = "ET", Text = "Eastern (ET)" },
                new SelectListItem { Value = "CT", Text = "Central (CT)" },
                new SelectListItem { Value = "MT", Text = "Mountain (MT)" },
                new SelectListItem { Value = "PT", Text = "Pacific (PT)" },
                new SelectListItem { Value = "UTC", Text = "UTC" },
                new SelectListItem { Value = "local", Text = "Browser local" }
            }, "Value", "Text");

            SelectedCategoryGroups = new List<string>();
            SelectedCategories = new List<string>();
            SelectedPlatforms = new List<string>();
        }

        public IList<Event> EventList { get; set; }
        public IList<EventView> EventViews { get; set; }
        public IList<CalendarCell> CalendarDays { get; set; }
        public IReadOnlyDictionary<DateOnly, List<EventView>> EventsByDay { get; private set; } =
            new Dictionary<DateOnly, List<EventView>>();

        public DateOnly TodayInZone { get; private set; }
        public DateOnly CalendarMonthStart { get; private set; }
        public string TzSuffix { get; private set; } = "ET";
        public string TimeZoneLabel { get; private set; } = "Eastern";

        public bool IsCalendarView => string.Equals(View, "calendar", StringComparison.OrdinalIgnoreCase);

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
        public SelectList? TimeZoneOptions { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? View { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Tz { get; set; } = "ET";

        [BindProperty(SupportsGet = true)]
        public string? TzIana { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Range { get; set; } = "all";

        [BindProperty(SupportsGet = true)]
        public int Year { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Month { get; set; }

        public async Task OnGetAsync()
        {
            await LoadPageAsync();
        }

        public async Task<IActionResult> OnGetExportAsync()
        {
            await LoadEventViewsAsync(IsCalendarView);
            var csv = BuildCsv();
            return File(Encoding.UTF8.GetBytes(csv), "text/csv", "events.csv");
        }

        public async Task<IActionResult> OnGetEventsPdfAsync()
        {
            await LoadEventViewsAsync(IsCalendarView);
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
                            c.Item().Text($"Generated {generated} · {EventViews.Count} events (times in {TzSuffix})")
                                .FontSize(10).FontColor(Colors.Grey.Darken1);
                        });
                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            if (!EventViews.Any())
                            {
                                x.Item().Text("No events match your filters.").Italic().FontColor(Colors.Grey.Darken1);
                                return;
                            }
                            foreach (var row in EventViews)
                            {
                                var evt = row.Event;
                                var watchStr = FormatWatch(evt);
                                x.Item().PaddingVertical(4)
                                    .Column(c =>
                                    {
                                        c.Item().Text(evt.Name ?? "-").Bold().FontSize(10).FontColor(Colors.Black);
                                        c.Item().Text($"{row.DisplayDay:MMM d, yyyy} · {row.TimeText} · {watchStr} · {row.CategoryText}")
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

        private async Task LoadPageAsync()
        {
            await LoadEventViewsAsync(IsCalendarView);
            if (IsCalendarView)
            {
                BuildCalendarDays();
            }
        }

        private async Task LoadEventViewsAsync(bool forCalendar)
        {
            EnsureFilterDefaults();
            ResolveZones();
            EnsureCalendarMonth();

            var bounds = forCalendar ? GetCalendarFetchBounds() : GetListFetchBounds();
            var events = await QueryEventsAsync(bounds.Min, bounds.Max);
            var views = events.Select(ToView).ToList();
            views = ApplyDisplayDateFilter(views, forCalendar);
            EventViews = SortViews(views);
            EventList = EventViews.Select(v => v.Event).ToList();
        }

        private void EnsureFilterDefaults()
        {
            var allCategoryNames = AllCategories.Keys.ToList();
            var allPlatformNames = AllPlatforms.Keys.ToList();

            if (SelectedCategoryGroups == null || !SelectedCategoryGroups.Any())
            {
                SelectedCategoryGroups = DefaultCategoryGroups.ToList();
            }
            if (SelectedCategories == null || !SelectedCategories.Any())
            {
                SelectedCategories = allCategoryNames;
            }
            if (SelectedPlatforms == null || !SelectedPlatforms.Any())
            {
                SelectedPlatforms = allPlatformNames;
            }
            if (string.IsNullOrWhiteSpace(View))
            {
                View = "list";
            }
            if (string.IsNullOrWhiteSpace(Tz))
            {
                Tz = "ET";
            }
            if (string.IsNullOrWhiteSpace(Range))
            {
                Range = "all";
            }
            if (string.IsNullOrWhiteSpace(SortField))
            {
                SortField = "Day";
            }
        }

        private void ResolveZones()
        {
            _eastern = FindTimeZone("America/New_York", "Eastern Standard Time");
            _displayZone = ResolveDisplayZone(Tz, TzIana);
            var now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, _displayZone);
            TodayInZone = DateOnly.FromDateTime(now);
            TzSuffix = GetTzSuffix(Tz, _displayZone, now);
            TimeZoneLabel = GetTimeZoneLabel(Tz, _displayZone);
        }

        private void EnsureCalendarMonth()
        {
            var anchor = GetRangeWindow()?.Start ?? TodayInZone;
            if (Year < 1 || Month < 1 || Month > 12)
            {
                Year = anchor.Year;
                Month = anchor.Month;
            }
            CalendarMonthStart = new DateOnly(Year, Month, 1);
        }

        private (DateOnly? Min, DateOnly? Max) GetCalendarFetchBounds()
        {
            var monthEnd = CalendarMonthStart.AddMonths(1).AddDays(-1);
            var min = CalendarMonthStart.AddDays(-1);
            var max = monthEnd.AddDays(1);
            var window = GetRangeWindow();
            if (window != null)
            {
                var rangeMin = window.Value.Start.AddDays(-1);
                var rangeMax = window.Value.End.AddDays(1);
                if (rangeMin < min) min = rangeMin;
                if (rangeMax > max) max = rangeMax;
            }
            return (min, max);
        }

        private (DateOnly? Min, DateOnly? Max) GetListFetchBounds()
        {
            var window = GetRangeWindow();
            if (window != null)
            {
                return (window.Value.Start.AddDays(-1), window.Value.End.AddDays(1));
            }
            if (!ShowPastEvents)
            {
                return (TodayInZone.AddDays(-1), null);
            }
            return (null, null);
        }

        private (DateOnly Start, DateOnly End)? GetRangeWindow()
        {
            var key = (Range ?? "all").Trim().ToLowerInvariant();
            return key switch
            {
                "today" => (TodayInZone, TodayInZone),
                "weekend" => GetWeekendWindow(TodayInZone),
                "week" => (TodayInZone, TodayInZone.AddDays(6)),
                _ => null
            };
        }

        private static (DateOnly Start, DateOnly End) GetWeekendWindow(DateOnly today)
        {
            DateOnly saturday;
            if (today.DayOfWeek == DayOfWeek.Saturday)
            {
                saturday = today;
            }
            else if (today.DayOfWeek == DayOfWeek.Sunday)
            {
                saturday = today.AddDays(-1);
            }
            else
            {
                saturday = today.AddDays(6 - (int)today.DayOfWeek);
            }
            return (saturday, saturday.AddDays(1));
        }

        private async Task<List<Event>> QueryEventsAsync(DateOnly? minDay, DateOnly? maxDay)
        {
            var allCategoryGroupNames = AllCategoryGroups.Keys.ToList();
            var allCategoryNames = AllCategories.Keys.ToList();
            var allPlatformNames = AllPlatforms.Keys.ToList();

            IQueryable<Event> query = _context.Events.AsQueryable();

            if (minDay.HasValue)
            {
                var min = minDay.Value;
                query = query.Where(e => e.Day >= min);
            }
            if (maxDay.HasValue)
            {
                var max = maxDay.Value;
                query = query.Where(e => e.Day <= max);
            }

            if (SelectedCategoryGroups.Count < allCategoryGroupNames.Count)
            {
                query = query.Where(e => e.CategoryGroup.HasValue && SelectedCategoryGroups.Contains(e.CategoryGroup.Value.ToString()));
            }
            if (SelectedCategories.Count < allCategoryNames.Count)
            {
                query = query.Where(e => e.Category.HasValue && SelectedCategories.Contains(e.Category.Value.ToString()));
            }
            if (SelectedPlatforms.Count < allPlatformNames.Count)
            {
                query = query.Where(e => e.Platform.HasValue && SelectedPlatforms.Contains(e.Platform.Value.ToString()));
            }
            if (!string.IsNullOrEmpty(SearchString))
            {
                query = query.Where(e =>
                    (e.Name != null && e.Name.Contains(SearchString, StringComparison.OrdinalIgnoreCase)) ||
                    (e.Description != null && e.Description.Contains(SearchString, StringComparison.OrdinalIgnoreCase)));
            }

            return await query.ToListAsync();
        }

        private List<EventView> ApplyDisplayDateFilter(List<EventView> views, bool forCalendar)
        {
            var window = GetRangeWindow();
            IEnumerable<EventView> filtered = views;

            if (window != null)
            {
                filtered = filtered.Where(v => v.DisplayDay >= window.Value.Start && v.DisplayDay <= window.Value.End);
            }
            else if (forCalendar)
            {
                var monthEnd = CalendarMonthStart.AddMonths(1).AddDays(-1);
                filtered = filtered.Where(v => v.DisplayDay >= CalendarMonthStart && v.DisplayDay <= monthEnd);
            }
            else if (!ShowPastEvents)
            {
                filtered = filtered.Where(v => v.DisplayDay >= TodayInZone);
            }

            return filtered.ToList();
        }

        private List<EventView> SortViews(List<EventView> views)
        {
            if (string.Equals(SortField, "Name", StringComparison.OrdinalIgnoreCase))
            {
                return views
                    .OrderBy(v => v.Event.Name)
                    .ThenBy(v => v.DisplayDay)
                    .ThenBy(v => v.DisplayTime == null ? 1 : 0)
                    .ThenBy(v => v.DisplayTime)
                    .ToList();
            }

            return views
                .OrderBy(v => v.DisplayDay)
                .ThenBy(v => v.DisplayTime == null ? 1 : 0)
                .ThenBy(v => v.DisplayTime)
                .ThenBy(v => v.Event.Name)
                .ToList();
        }

        private void BuildCalendarDays()
        {
            EventsByDay = EventViews
                .GroupBy(v => v.DisplayDay)
                .ToDictionary(g => g.Key, g => g.OrderBy(v => v.DisplayTime == null ? 1 : 0).ThenBy(v => v.DisplayTime).ThenBy(v => v.Event.Name).ToList());

            var window = GetRangeWindow();
            var first = CalendarMonthStart;
            var gridStart = first.AddDays(-(int)first.DayOfWeek);
            var cells = new List<CalendarCell>(42);
            for (var i = 0; i < 42; i++)
            {
                var date = gridStart.AddDays(i);
                EventsByDay.TryGetValue(date, out var dayEvents);
                cells.Add(new CalendarCell
                {
                    Date = date,
                    IsCurrentMonth = date.Month == first.Month && date.Year == first.Year,
                    IsToday = date == TodayInZone,
                    IsWeekend = date.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday,
                    IsInRange = window == null || (date >= window.Value.Start && date <= window.Value.End),
                    Events = dayEvents ?? new List<EventView>()
                });
            }
            CalendarDays = cells;
            if (cells.Count == 42 && cells.Skip(35).All(c => !c.IsCurrentMonth && c.Events.Count == 0))
            {
                CalendarDays = cells.Take(35).ToList();
            }
        }

        public EventView ToView(Event evt)
        {
            var categoryText = evt.CategoryGroup?.ToString() ?? "-";
            if (evt.Category.HasValue && evt.Category != EventCategory.Other)
            {
                categoryText += $" / {GetEnumDisplayName(evt.Category)}";
            }

            if (!string.IsNullOrEmpty(evt.TimeDisplay) || !evt.SortTime.HasValue)
            {
                return new EventView
                {
                    Event = evt,
                    DisplayDay = evt.Day,
                    DisplayTime = evt.SortTime,
                    TimeText = Event.FormatTime(evt.SortTime, evt.TimeDisplay, TzSuffix),
                    ChipTimeText = Event.FormatTime(evt.SortTime, evt.TimeDisplay, suffix: null),
                    DateText = evt.Day.ToString("dddd, MMMM d, yyyy"),
                    CategoryText = categoryText,
                    WatchText = FormatWatch(evt),
                    UtcIso = GetUtcIsoForEvent(evt)
                };
            }

            var converted = ConvertFromEastern(evt.Day, evt.SortTime.Value, _eastern, _displayZone);
            return new EventView
            {
                Event = evt,
                DisplayDay = converted.Day,
                DisplayTime = converted.Time,
                TimeText = Event.FormatTime(converted.Time, null, TzSuffix),
                ChipTimeText = Event.FormatTime(converted.Time, null, suffix: null),
                DateText = converted.Day.ToString("dddd, MMMM d, yyyy"),
                CategoryText = categoryText,
                WatchText = FormatWatch(evt),
                UtcIso = converted.Utc.ToString("yyyy-MM-ddTHH:mm:ssZ")
            };
        }

        public static (DateOnly Day, TimeOnly Time, DateTime Utc) ConvertFromEastern(DateOnly day, TimeOnly time, TimeZoneInfo destZone)
        {
            return ConvertFromEastern(day, time, FindTimeZone("America/New_York", "Eastern Standard Time"), destZone);
        }

        public static (DateOnly Day, TimeOnly Time, DateTime Utc) ConvertFromEastern(DateOnly day, TimeOnly time, TimeZoneInfo eastern, TimeZoneInfo destZone)
        {
            var etDt = new DateTime(day.Year, day.Month, day.Day, time.Hour, time.Minute, 0, DateTimeKind.Unspecified);
            var utc = TimeZoneInfo.ConvertTimeToUtc(etDt, eastern);
            var destDt = TimeZoneInfo.ConvertTimeFromUtc(utc, destZone);
            return (DateOnly.FromDateTime(destDt), TimeOnly.FromDateTime(destDt), utc);
        }

        public static TimeZoneInfo ResolveDisplayZone(string? tz, string? tzIana)
        {
            var key = (tz ?? "ET").Trim();
            if (key.Equals("local", StringComparison.OrdinalIgnoreCase))
            {
                if (!string.IsNullOrWhiteSpace(tzIana))
                {
                    return FindTimeZone(tzIana, tzIana);
                }
                return FindTimeZone("America/New_York", "Eastern Standard Time");
            }

            return key.ToUpperInvariant() switch
            {
                "CT" => FindTimeZone("America/Chicago", "Central Standard Time"),
                "MT" => FindTimeZone("America/Denver", "Mountain Standard Time"),
                "PT" => FindTimeZone("America/Los_Angeles", "Pacific Standard Time"),
                "UTC" => TimeZoneInfo.Utc,
                _ => FindTimeZone("America/New_York", "Eastern Standard Time")
            };
        }

        public static TimeZoneInfo FindTimeZone(string ianaId, string windowsId)
        {
            try
            {
                return TimeZoneInfo.FindSystemTimeZoneById(ianaId);
            }
            catch (TimeZoneNotFoundException)
            {
                try
                {
                    return TimeZoneInfo.FindSystemTimeZoneById(windowsId);
                }
                catch (TimeZoneNotFoundException)
                {
                    return TimeZoneInfo.Utc;
                }
            }
            catch (InvalidTimeZoneException)
            {
                return TimeZoneInfo.Utc;
            }
        }

        public static string GetTzSuffix(string? tz, TimeZoneInfo zone, DateTime at)
        {
            var key = (tz ?? "ET").Trim().ToUpperInvariant();
            return key switch
            {
                "ET" => "ET",
                "CT" => "CT",
                "MT" => "MT",
                "PT" => "PT",
                "UTC" => "UTC",
                _ => AbbreviationFor(zone, at)
            };
        }

        public static string GetTimeZoneLabel(string? tz, TimeZoneInfo zone)
        {
            var key = (tz ?? "ET").Trim().ToUpperInvariant();
            return key switch
            {
                "ET" => "Eastern",
                "CT" => "Central",
                "MT" => "Mountain",
                "PT" => "Pacific",
                "UTC" => "UTC",
                "LOCAL" => string.IsNullOrEmpty(zone.Id) ? "local" : zone.Id.Replace('_', ' '),
                _ => zone.Id
            };
        }

        private static string AbbreviationFor(TimeZoneInfo zone, DateTime at)
        {
            if (zone.Id == "UTC" || zone.Equals(TimeZoneInfo.Utc)) return "UTC";
            var name = zone.IsDaylightSavingTime(at) ? zone.DaylightName : zone.StandardName;
            var parts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length >= 2 && parts.All(p => p.Length > 0 && char.IsLetter(p[0])))
            {
                return string.Concat(parts.Select(p => char.ToUpperInvariant(p[0])));
            }
            return name.Length <= 5 ? name : "local";
        }

        public static string FormatWatch(Event evt)
        {
            if (!string.IsNullOrEmpty(evt.Channel) && evt.Platform.HasValue) return $"{evt.Channel} ({evt.Platform})";
            if (!string.IsNullOrEmpty(evt.Channel)) return evt.Channel;
            if (evt.Platform.HasValue) return evt.Platform.Value.ToString();
            return "-";
        }

        public static string ChipClass(EventCategoryGroup? group)
        {
            return group switch
            {
                EventCategoryGroup.Esports => "event-chip-esports",
                EventCategoryGroup.Racing => "event-chip-racing",
                EventCategoryGroup.Sports => "event-chip-sports",
                EventCategoryGroup.Local => "event-chip-local",
                _ => "event-chip-other"
            };
        }

        private string BuildCsv()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name,Date,Time ({TzSuffix}),Platform,Channel,Category,Description,Link");
            foreach (var row in EventViews)
            {
                var evt = row.Event;
                var platformStr = evt.Platform?.ToString() ?? "";
                var channelStr = evt.Channel ?? "";
                sb.AppendLine($"{EscapeCsv(evt.Name ?? "")},{row.DisplayDay:yyyy-MM-dd},{EscapeCsv(row.TimeText)},{platformStr},{EscapeCsv(channelStr)},{EscapeCsv(row.CategoryText)},{EscapeCsv(evt.Description ?? "")},{EscapeCsv(evt.Link ?? "")}");
            }
            return sb.ToString();
        }

        private static string EscapeCsv(string value)
        {
            if (value.Contains(',') || value.Contains('"') || value.Contains('\n'))
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }

        public string GetExportQueryString(string? handler = null) => GetFilterQueryString(handler: handler);

        public string GetFilterQueryString(
            string? handler = null,
            string? view = null,
            string? range = null,
            int? year = null,
            int? month = null,
            string? tz = null)
        {
            var q = new List<string>();
            if (!string.IsNullOrEmpty(handler)) q.Add($"handler={handler}");

            var viewVal = view ?? View ?? "list";
            q.Add($"View={Uri.EscapeDataString(viewVal)}");

            var tzVal = tz ?? Tz ?? "ET";
            q.Add($"Tz={Uri.EscapeDataString(tzVal)}");
            if (tzVal.Equals("local", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(TzIana))
            {
                q.Add($"TzIana={Uri.EscapeDataString(TzIana)}");
            }

            var rangeVal = range ?? Range ?? "all";
            if (!string.IsNullOrEmpty(rangeVal) && !rangeVal.Equals("all", StringComparison.OrdinalIgnoreCase))
            {
                q.Add($"Range={Uri.EscapeDataString(rangeVal)}");
            }

            var yearVal = year ?? Year;
            var monthVal = month ?? Month;
            if (yearVal > 0 && monthVal > 0)
            {
                q.Add($"Year={yearVal}");
                q.Add($"Month={monthVal}");
            }

            if (!string.IsNullOrEmpty(SearchString)) q.Add($"SearchString={Uri.EscapeDataString(SearchString)}");
            if (ShowPastEvents) q.Add("ShowPastEvents=true");
            if (!string.IsNullOrEmpty(SortField)) q.Add($"SortField={Uri.EscapeDataString(SortField)}");
            foreach (var g in SelectedCategoryGroups ?? Enumerable.Empty<string>()) q.Add($"SelectedCategoryGroups={Uri.EscapeDataString(g)}");
            foreach (var c in SelectedCategories ?? Enumerable.Empty<string>()) q.Add($"SelectedCategories={Uri.EscapeDataString(c)}");
            foreach (var p in SelectedPlatforms ?? Enumerable.Empty<string>()) q.Add($"SelectedPlatforms={Uri.EscapeDataString(p)}");
            return q.Any() ? "?" + string.Join("&", q) : "";
        }

        public DateOnly PreviousMonth => CalendarMonthStart.AddMonths(-1);
        public DateOnly NextMonth => CalendarMonthStart.AddMonths(1);

        public DateOnly GetRangeAnchor(string rangeKey)
        {
            return (rangeKey ?? "all").Trim().ToLowerInvariant() switch
            {
                "weekend" => GetWeekendWindow(TodayInZone).Start,
                "today" or "week" => TodayInZone,
                _ => TodayInZone
            };
        }

        public bool IsRange(string rangeKey) =>
            string.Equals(Range ?? "all", rangeKey, StringComparison.OrdinalIgnoreCase);

        public static string GetEnumDisplayName(Enum? enumValue)
        {
            if (enumValue == null) return "-";
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault()
                ?.GetCustomAttribute<DisplayAttribute>()?.GetName() ?? enumValue.ToString();
        }

        /// <summary>Returns UTC ISO string for ET Day+SortTime. Null when not applicable.</summary>
        public static string? GetUtcIsoForEvent(Event evt)
        {
            if (!evt.SortTime.HasValue) return null;
            try
            {
                var eastern = FindTimeZone("America/New_York", "Eastern Standard Time");
                var dt = new DateTime(evt.Day.Year, evt.Day.Month, evt.Day.Day, evt.SortTime.Value.Hour, evt.SortTime.Value.Minute, 0, DateTimeKind.Unspecified);
                var utc = TimeZoneInfo.ConvertTimeToUtc(dt, eastern);
                return utc.ToString("yyyy-MM-ddTHH:mm:ssZ");
            }
            catch { return null; }
        }

        public class EventView
        {
            public required Event Event { get; set; }
            public DateOnly DisplayDay { get; set; }
            public TimeOnly? DisplayTime { get; set; }
            public string TimeText { get; set; } = string.Empty;
            public string ChipTimeText { get; set; } = string.Empty;
            public string DateText { get; set; } = string.Empty;
            public string CategoryText { get; set; } = string.Empty;
            public string WatchText { get; set; } = string.Empty;
            public string? UtcIso { get; set; }
        }

        public class CalendarCell
        {
            public DateOnly Date { get; set; }
            public bool IsCurrentMonth { get; set; }
            public bool IsToday { get; set; }
            public bool IsWeekend { get; set; }
            public bool IsInRange { get; set; } = true;
            public List<EventView> Events { get; set; } = new();
        }
    }
}
