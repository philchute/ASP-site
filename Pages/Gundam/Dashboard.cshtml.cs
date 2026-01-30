using System;
using ASP_site.Models.Gunpla;
using ASP_site.Services;
using ASP_site.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ASP_site.Pages.Gundam
{
    public class DashboardModel : PageModel
    {
        private readonly GunplaCollectionService _service;

        public DashboardModel(GunplaCollectionService service)
        {
            _service = service;
            SortOptions = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Value = "ID", Text = "ID" },
                new SelectListItem { Value = "Grade", Text = "Grade" },
                new SelectListItem { Value = "Status", Text = "Status" },
                new SelectListItem { Value = "Timeline", Text = "Timeline" },
                new SelectListItem { Value = "Model", Text = "Model" },
                new SelectListItem { Value = "Name", Text = "Name" },
                new SelectListItem { Value = "Release", Text = "Release Year" }
            }, "Value", "Text");
        }

        public List<UserKitEntry> UserCollection { get; set; } = new();
        public List<GunplaKit> AllKits { get; set; } = new();
        public Dictionary<string, int> CompletedStats { get; set; } = new();
        public Dictionary<string, int> StatusCounts { get; set; } = new();
        public int BacklogCount { get; set; }
        public decimal TotalSpent { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; } = "";

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedGrades { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedScales { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedStatuses { get; set; } = new();

        public List<string> AllScales { get; set; } = new();

        // Sorting Properties
        [BindProperty(SupportsGet = true)]
        public string SortField { get; set; } = "ID";
        public SelectList SortOptions { get; set; }

        public async Task OnGetAsync()
        {
            var scales = new ScaleConverterService().GetCommonScales();
            AllScales = scales
                .Where(s => s.Category.Contains("Gundam"))
                .Select(s => s.Name)
                .ToList();

            UserCollection = await _service.GetUserCollectionAsync();
            var allKits = await _service.GetAllKitsAsync();
            
            // Filter logic
            var query = allKits.AsQueryable();

            if (!string.IsNullOrEmpty(SearchString))
            {
                query = query.Where(k => 
                    k.Id.Contains(SearchString, StringComparison.OrdinalIgnoreCase) ||
                    (k.KitName != null && k.KitName.Contains(SearchString, StringComparison.OrdinalIgnoreCase)) ||
                    (k.Gundams != null && k.Gundams.Any(u => u.ModelNumber.Contains(SearchString, StringComparison.OrdinalIgnoreCase))) ||
                    (k.Gundams != null && k.Gundams.Any(u => u.CommonName.Contains(SearchString, StringComparison.OrdinalIgnoreCase))) ||
                    (k.Gundams != null && k.Gundams.Any(u => u.Series != null && u.Series.Any(s => s.Contains(SearchString, StringComparison.OrdinalIgnoreCase))))
                );
            }

            if (SelectedGrades.Any())
            {
                query = query.Where(k => SelectedGrades.Contains(k.Grade.ToString()));
            }

            if (SelectedScales.Any())
            {
                query = query.Where(k => SelectedScales.Contains(k.Scale));
            }

            // Status filter
            if (SelectedStatuses.Any())
            {
                var matchingKitIds = UserCollection
                    .Where(u => SelectedStatuses.Contains(u.Status.ToString()))
                    .Select(u => u.KitId)
                    .ToHashSet();
                
                query = query.Where(k => matchingKitIds.Contains(k.Id));
            }

            // Apply Sorting
            if (SortField == "Status")
            {
                var statusOrder = new[] { KitStatus.Want, KitStatus.Own, KitStatus.Started, KitStatus.Built, KitStatus.Completed };
                var entryByKit = UserCollection.ToDictionary(u => u.KitId, u => u.Status);
                AllKits = query.AsEnumerable()
                    .OrderBy(k => entryByKit.TryGetValue(k.Id, out var s) ? Array.IndexOf(statusOrder, s) : 999)
                    .ThenBy(k => k.Grade)
                    .ThenBy(k => k.Id)
                    .ToList();
            }
            else
            {
                switch (SortField)
                {
                    case "Grade":
                        query = query.OrderBy(k => k.Grade).ThenBy(k => k.Id);
                        break;
                    case "Timeline":
                        query = query.AsEnumerable()
                            .OrderBy(k => GundamHelpers.GetTimeline(k.Gundams.FirstOrDefault()?.Series.FirstOrDefault()))
                            .ThenBy(k => k.Id)
                            .AsQueryable();
                        break;
                    case "Model":
                        query = query.OrderBy(k => k.Gundams.FirstOrDefault() != null ? k.Gundams.First().ModelNumber : "").ThenBy(k => k.Id);
                        break;
                    case "Name":
                        query = query.OrderBy(k => k.KitName ?? (k.Gundams.FirstOrDefault() != null ? k.Gundams.First().CommonName : "")).ThenBy(k => k.Id);
                        break;
                    case "Release":
                        query = query.OrderBy(k => k.ReleaseYear).ThenBy(k => k.Id);
                        break;
                    case "ID":
                    default:
                        query = query.OrderBy(k => k.Id);
                        break;
                }
                AllKits = query.ToList();
            }

            CompletedStats = await _service.GetCompletedCountByGradeAsync();
            StatusCounts = await _service.GetStatusCountsAsync();
            BacklogCount = await _service.GetBacklogCountAsync();
            TotalSpent = await _service.GetTotalSpentAsync();
        }

        public async Task<IActionResult> OnPostUpdateStatusAsync(string kitId, KitStatus status)
        {
            await _service.UpdateEntryStatusAsync(kitId, status);
            return new JsonResult(new { success = true });
        }

        public async Task<IActionResult> OnGetExportAsync()
        {
            var collection = await _service.GetUserCollectionAsync();
            var csv = _service.ExportToCsv(collection);
            return File(Encoding.UTF8.GetBytes(csv), "text/csv", "gunpla_collection.csv");
        }

        [BindProperty]
        public IFormFile? CsvFile { get; set; }

        public async Task<IActionResult> OnPostImportAsync()
        {
            if (CsvFile != null && CsvFile.Length > 0)
            {
                using (var reader = new StreamReader(CsvFile.OpenReadStream()))
                {
                    var csvContent = await reader.ReadToEndAsync();
                    var entries = _service.ImportFromCsv(csvContent);
                    foreach (var entry in entries)
                    {
                        await _service.AddOrUpdateEntryAsync(entry);
                    }
                }
            }
            return RedirectToPage();
        }

        public async Task<IActionResult> OnGetShoppingListPdfAsync(bool includeAccessories = false)
        {
            var userCollection = await _service.GetUserCollectionAsync();
            var allKits = await _service.GetAllKitsAsync();
            var kitLookup = allKits.ToDictionary(k => k.Id);

            var wantedKitIds = userCollection
                .Where(u => u.Status == KitStatus.Want)
                .Select(u => u.KitId)
                .ToHashSet();

            var wantedKits = allKits
                .Where(k => wantedKitIds.Contains(k.Id))
                .OrderBy(k => k.Grade)
                .ThenBy(k => k.Manufacturer)
                .ThenBy(k => k.Id)
                .ToList();

            var relevantStatuses = new[] { KitStatus.Want, KitStatus.Own, KitStatus.Started, KitStatus.Built };
            var userKitIds = userCollection
                .Where(u => relevantStatuses.Contains(u.Status))
                .Select(u => u.KitId)
                .ToHashSet();

            var accessoryGrades = new[]
            {
                GunplaGrade.WaterSlide, GunplaGrade.Sticker, GunplaGrade.MetalSticker,
                GunplaGrade.Part, GunplaGrade.ActionBase
            };

            List<(GunplaKit Accessory, List<(string KitId, string KitName, KitStatus Status)> MatchingKits)> accessoryEntries = new();
            if (includeAccessories)
            {
                var accessories = allKits
                    .Where(k => accessoryGrades.Contains(k.Grade))
                    .ToList();
                var accessoryIds = accessories.Select(a => a.Id).ToHashSet();
                var allRelIds = accessoryIds.Union(userKitIds).ToList();
                var relationships = await _service.GetRelationshipsForKitsAsync(allRelIds);
                var nonAccessoryKits = allKits
                    .Where(k => !accessoryGrades.Contains(k.Grade))
                    .ToDictionary(k => k.Id);

                foreach (var acc in accessories)
                {
                    var fitsKitIds = new HashSet<string>();

                    foreach (var r in relationships.Where(r =>
                        (r.KitId == acc.Id || r.RelatedKitId == acc.Id) && r.Type == KitRelationshipType.CombinesWith))
                    {
                        var otherId = r.KitId == acc.Id ? r.RelatedKitId : r.KitId;
                        if (nonAccessoryKits.ContainsKey(otherId)) fitsKitIds.Add(otherId);
                    }

                    var accGundamModels = acc.Gundams?.Select(g => g.ModelNumber).ToHashSet() ?? new HashSet<string>();
                    var nonScale = ScaleConverterService.NonScale.Name;
                    if (accGundamModels.Any())
                    {
                        foreach (var kv in nonAccessoryKits)
                        {
                            var k = kv.Value;
                            if (k.Gundams == null || !k.Gundams.Any(g => accGundamModels.Contains(g.ModelNumber))) continue;
                            if (acc.Scale != nonScale && k.Scale != acc.Scale) continue;
                            fitsKitIds.Add(k.Id);
                        }
                    }

                    // Faction matching only when the accessory has factions explicitly listed on it (acc.Factions).
                    var accFactions = acc.Factions?.ToHashSet() ?? new HashSet<string>();
                    if (accFactions.Any())
                    {
                        foreach (var kv in nonAccessoryKits)
                        {
                            var k = kv.Value;
                            var kitFactions = k.Gundams?
                                .SelectMany(g => g.Factions ?? new List<string>())
                                .ToHashSet() ?? new HashSet<string>();
                            if (!kitFactions.Any() || !accFactions.Overlaps(kitFactions)) continue;
                            if (acc.Scale != nonScale && k.Scale != acc.Scale) continue;
                            fitsKitIds.Add(k.Id);
                        }
                    }

                    var matching = userKitIds
                        .Where(id => fitsKitIds.Contains(id))
                        .Select(id =>
                        {
                            var e = userCollection.FirstOrDefault(u => u.KitId == id);
                            var kit = kitLookup.GetValueOrDefault(id);
                            var name = kit?.KitName ?? kit?.Gundams?.FirstOrDefault()?.CommonName ?? id;
                            return (id, name ?? id, e!.Status);
                        })
                        .ToList();
                    if (matching.Count == 0) continue;

                    accessoryEntries.Add((acc, matching));
                }

                accessoryEntries = accessoryEntries
                    .OrderBy(x => x.Accessory.Grade)
                    .ThenBy(x => x.Accessory.Manufacturer)
                    .ThenBy(x => x.Accessory.Id)
                    .ToList();
            }

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
                            c.Item().Text("Gunpla Shopping List")
                                .SemiBold().FontSize(18).FontColor(Colors.Black);
                            c.Item().Text($"Total Kits: {wantedKits.Count}")
                                .FontSize(10).FontColor(Colors.Grey.Darken1);
                        });

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            if (!wantedKits.Any())
                            {
                                x.Item().Text("No kits in your shopping list.").Italic().FontColor(Colors.Grey.Darken1);
                                return;
                            }

                            foreach (var gradeGroup in wantedKits.GroupBy(k => k.Grade))
                            {
                                x.Item().PaddingTop(5).PaddingBottom(2)
                                    .Text(gradeGroup.Key.ToString())
                                    .Bold().FontSize(12).FontColor(Colors.Black);

                                var byManufacturer = gradeGroup.GroupBy(k => k.Manufacturer).ToList();
                                foreach (var manufacturerGroup in byManufacturer)
                                {
                                    if (byManufacturer.Count > 1)
                                    {
                                        x.Item().PaddingTop(2).PaddingBottom(1)
                                            .Text(manufacturerGroup.Key)
                                            .SemiBold().FontSize(10).FontColor(Colors.Grey.Darken1);
                                    }

                                    foreach (var kit in manufacturerGroup)
                                    {
                                        var gundam = kit.Gundams.FirstOrDefault();
                                        var kitName = kit.KitName ?? gundam?.CommonName ?? "Unknown";
                                        var modelNumber = gundam?.ModelNumber ?? "-";

                                        x.Item().PaddingVertical(2)
                                            .Row(row =>
                                            {
                                                row.ConstantItem(14).Text("\u2610").FontSize(10).FontColor(Colors.Black);
                                                row.RelativeItem(1).Text(kit.Id)
                                                    .FontFamily("Courier").FontSize(8)
                                                    .FontColor(Colors.Grey.Darken2);
                                                row.RelativeItem(3).Text(kitName).FontSize(9).FontColor(Colors.Black);
                                                row.RelativeItem(1).Text(kit.Manufacturer)
                                                    .FontSize(8).FontColor(Colors.Grey.Darken1).AlignRight();
                                                row.RelativeItem(1).Text(kit.Scale)
                                                    .FontSize(8).FontColor(Colors.Grey.Darken1).AlignRight();
                                                row.RelativeItem(1).Text(modelNumber)
                                                    .FontSize(8).FontColor(Colors.Grey.Darken2).AlignRight();
                                            });
                                        x.Item().LineHorizontal(0.5f).LineColor(Colors.Grey.Lighten2);
                                    }
                                }
                                x.Item().PaddingBottom(5);
                            }
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Gunpla Shopping List");
                            x.Span(" \u00B7 Generated ");
                            x.Span(generated);
                            x.Span(" \u00B7 ");
                            x.CurrentPageNumber();
                        });
                });

                if (includeAccessories)
                {
                    if (accessoryEntries.Any())
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
                                    c.Item().Text("Accessories (decals, parts, etc.)")
                                        .SemiBold().FontSize(18).FontColor(Colors.Black);
                                    c.Item().Text("For kits on your wanted / owned / in-progress list. Buy when you see them.")
                                        .FontSize(10).FontColor(Colors.Grey.Darken1);
                                });

                            page.Content()
                                .PaddingVertical(1, Unit.Centimetre)
                                .Column(x =>
                                {
                                    foreach (var typeGroup in accessoryEntries.GroupBy(e => e.Accessory.Grade))
                                    {
                                        x.Item().PaddingTop(5).PaddingBottom(2)
                                            .Text(typeGroup.Key.ToString())
                                            .Bold().FontSize(12).FontColor(Colors.Black);

                                        foreach (var brandGroup in typeGroup.GroupBy(e => e.Accessory.Manufacturer))
                                        {
                                            x.Item().PaddingTop(2).PaddingBottom(1)
                                                .Text(brandGroup.Key + ":")
                                                .SemiBold().FontSize(10).FontColor(Colors.Grey.Darken1);

                                            foreach (var (acc, matching) in brandGroup)
                                            {
                                                var accName = acc.KitName ?? acc.Gundams?.FirstOrDefault()?.CommonName ?? acc.Id;
                                                var kitIds = string.Join(", ", matching.Select(m => m.KitId));
                                                x.Item().PaddingVertical(2)
                                                    .Row(row =>
                                                    {
                                                        row.ConstantItem(14).Text("\u2610").FontSize(10).FontColor(Colors.Black);
                                                        row.RelativeItem(1)
                                                            .Text($"{acc.Id} ({accName}) - for your {kitIds}")
                                                            .FontSize(8).FontColor(Colors.Black);
                                                    });
                                                x.Item().LineHorizontal(0.5f).LineColor(Colors.Grey.Lighten2);
                                            }
                                        }
                                        x.Item().PaddingBottom(5);
                                    }
                                });

                            page.Footer()
                                .AlignCenter()
                                .Text(x =>
                                {
                                    x.Span("Accessories");
                                    x.Span(" \u00B7 Generated ");
                                    x.Span(generated);
                                    x.Span(" \u00B7 ");
                                    x.CurrentPageNumber();
                                });
                        });
                    }
                    else
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
                                    c.Item().Text("Accessories (decals, parts, etc.)")
                                        .SemiBold().FontSize(18).FontColor(Colors.Black);
                                });

                            page.Content()
                                .PaddingVertical(2, Unit.Centimetre)
                                .Column(x =>
                                {
                                    x.Item().Text("No accessories fit your current Want / Own / Started / Built kits.")
                                        .FontSize(11).FontColor(Colors.Black);
                                    x.Item().PaddingTop(8)
                                        .Text("Add kits to your wanted, owned, or in-progress list to see suggestions.")
                                        .FontSize(9).FontColor(Colors.Grey.Darken1);
                                });

                            page.Footer()
                                .AlignCenter()
                                .Text(x =>
                                {
                                    x.Span("Accessories");
                                    x.Span(" \u00B7 Generated ");
                                    x.Span(generated);
                                    x.Span(" \u00B7 ");
                                    x.CurrentPageNumber();
                                });
                        });
                    }
                }
            });

            var stream = new MemoryStream();
            document.GeneratePdf(stream);
            stream.Position = 0;

            var fileName = includeAccessories ? "Gunpla_Shopping_List_With_Accessories.pdf" : "Gunpla_Shopping_List.pdf";
            return File(stream, "application/pdf", fileName);
        }
    }
}
