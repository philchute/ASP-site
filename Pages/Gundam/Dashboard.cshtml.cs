using ASP_site.Models.Gunpla;
using ASP_site.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;

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
                    (k.Gundams != null && k.Gundams.Any(u => u.Timeline.Contains(SearchString, StringComparison.OrdinalIgnoreCase))) ||
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
            switch (SortField)
            {
                case "Grade":
                    query = query.OrderBy(k => k.Grade).ThenBy(k => k.Id);
                    break;
                case "Timeline":
                    query = query.OrderBy(k => k.Gundams.FirstOrDefault() != null ? k.Gundams.First().Timeline : "").ThenBy(k => k.Id);
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
    }
}
