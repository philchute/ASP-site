using ASP_site.Data;
using ASP_site.Models.Gunpla;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace ASP_site.Services
{
    public class GunplaCollectionService
    {
        private readonly GameContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string CookieKey = "GunplaGuestId";

        public GunplaCollectionService(GameContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        private string GetUserId()
        {
            var context = _httpContextAccessor.HttpContext;
            if (context == null) return "unknown";

            if (context.Request.Cookies.TryGetValue(CookieKey, out var userId) && !string.IsNullOrEmpty(userId))
            {
                return userId;
            }

            // Create new ID
            var newId = Guid.NewGuid().ToString();
            context.Response.Cookies.Append(CookieKey, newId, new CookieOptions 
            { 
                Expires = DateTime.Now.AddYears(1),
                HttpOnly = true,
                IsEssential = true
            });
            return newId;
        }

        public async Task<List<UserKitEntry>> GetUserCollectionAsync()
        {
            var userId = GetUserId();
            return await _context.UserKitEntries
                .Where(u => u.UserId == userId)
                .Include(u => u.Kit)
                .ThenInclude(k => k!.Gundam)
                .ToListAsync();
        }

        public async Task<List<GunplaKit>> GetAllKitsAsync()
        {
             return await _context.GunplaKits
                .Include(k => k.Gundam)
                .ToListAsync();
        }

        public async Task<Dictionary<string, int>> GetCompletedCountByGradeAsync()
        {
            var userId = GetUserId();
            var grades = Enum.GetValues(typeof(GunplaGrade)).Cast<GunplaGrade>();
            var result = new Dictionary<string, int>();

            foreach (var grade in grades)
            {
                // Completion defined as Built or Completed
                var count = await _context.UserKitEntries
                    .Include(u => u.Kit)
                    .Where(u => u.UserId == userId)
                    .CountAsync(u => u.Kit != null && u.Kit.Grade == grade && (u.Status == KitStatus.Built || u.Status == KitStatus.Completed));
                
                if (count > 0)
                {
                    result[grade.ToString()] = count;
                }
            }
            return result;
        }

        public async Task<decimal> GetTotalSpentAsync()
        {
            var userId = GetUserId();
            return await _context.UserKitEntries
                .Where(u => u.UserId == userId)
                .SumAsync(u => u.PricePaid ?? 0);
        }

        public async Task<List<GunplaKit>> GetKitsByGradeAsync(GunplaGrade grade)
        {
            return await _context.GunplaKits
                .Include(k => k.Gundam)
                .Where(k => k.Grade == grade)
                .OrderBy(k => k.Id)
                .ToListAsync();
        }

        public async Task<List<string>> GetAllTimelinesAsync()
        {
            return await _context.Gundams
                .Select(g => g.Timeline)
                .Distinct()
                .OrderBy(t => t)
                .ToListAsync();
        }

        public async Task<List<GunplaKit>> GetKitsByTimelineAsync(string timelineName)
        {
            return await _context.GunplaKits
                .Include(k => k.Gundam)
                .Where(k => k.Gundam != null && k.Gundam.Timeline == timelineName)
                .ToListAsync();
        }


        public async Task<Dictionary<string, int>> GetStatusCountsAsync()
        {
             var userId = GetUserId();
             var stats = await _context.UserKitEntries
                .Where(u => u.UserId == userId)
                .GroupBy(u => u.Status)
                .Select(g => new { Status = g.Key, Count = g.Count() })
                .ToDictionaryAsync(k => k.Status.ToString(), v => v.Count);
            
            foreach(var status in Enum.GetNames(typeof(KitStatus)))
            {
                if(!stats.ContainsKey(status)) stats[status] = 0;
            }
            return stats;
        }

        public async Task<int> GetBacklogCountAsync()
        {
            var userId = GetUserId();
            // Backlog usually means Own but not built/started. The prompt says "Status == Own".
            return await _context.UserKitEntries
                .Where(u => u.UserId == userId)
                .CountAsync(u => u.Status == KitStatus.Own);
        }

        public string ExportToCsv(List<UserKitEntry> entries)
        {
            var sb = new StringBuilder();
            sb.AppendLine("KitId,GundamModelNumber,CommonName,Status,PricePaid,Notes");

            foreach (var entry in entries)
            {
                var gundamModel = entry.Kit?.GundamModelNumber ?? entry.Kit?.Gundam?.ModelNumber ?? "";
                var commonName = entry.Kit?.Gundam?.CommonName ?? "";
                
                // Simple CSV escaping
                var notes = entry.Notes?.Replace("\"", "\"\"") ?? "";
                if (notes.Contains(",") || notes.Contains("\n")) notes = $"\"{notes}\"";

                sb.AppendLine($"{entry.KitId},{gundamModel},{commonName},{entry.Status},{entry.PricePaid},{notes}");
            }
            return sb.ToString();
        }

        public List<UserKitEntry> ImportFromCsv(string csvContent)
        {
            var userId = GetUserId();
            var entries = new List<UserKitEntry>();
            var lines = csvContent.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Skip header
            foreach (var line in lines.Skip(1))
            {
                // Basic CSV parsing (not robust for all edge cases but sufficient for this demo)
                var parts = line.Split(',');
                
                if (parts.Length >= 4)
                {
                    string kitId = parts[0];
                    if (Enum.TryParse(parts[3], out KitStatus status))
                    {
                        decimal? price = null;
                        if (parts.Length > 4 && decimal.TryParse(parts[4], out decimal p)) price = p;
                        
                        // Handle potential notes at the end
                        string notes = "";
                        if (parts.Length > 5) notes = string.Join(",", parts.Skip(5)); 
                        if (notes.StartsWith("\"") && notes.EndsWith("\"")) notes = notes.Substring(1, notes.Length - 2).Replace("\"\"", "\"");

                        entries.Add(new UserKitEntry
                        {
                            UserId = userId,
                            KitId = kitId,
                            Status = status,
                            PricePaid = price,
                            Notes = notes
                        });
                    }
                }
            }
            return entries;
        }
        
        public async Task AddOrUpdateEntryAsync(UserKitEntry newEntry)
        {
            var userId = GetUserId();
            newEntry.UserId = userId; // Ensure it's set

            var existing = await _context.UserKitEntries
                .FirstOrDefaultAsync(e => e.KitId == newEntry.KitId && e.UserId == userId);
            
            if (existing != null)
            {
                existing.Status = newEntry.Status;
                existing.PricePaid = newEntry.PricePaid;
                existing.Notes = newEntry.Notes;
                _context.UserKitEntries.Update(existing);
            }
            else
            {
                await _context.UserKitEntries.AddAsync(newEntry);
            }
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEntryStatusAsync(string kitId, KitStatus newStatus)
        {
            var userId = GetUserId();
            var existing = await _context.UserKitEntries
                .FirstOrDefaultAsync(e => e.KitId == kitId && e.UserId == userId);
            
            if (existing != null)
            {
                existing.Status = newStatus;
                _context.UserKitEntries.Update(existing);
            }
            else
            {
                 // Create new entry
                await _context.UserKitEntries.AddAsync(new UserKitEntry 
                { 
                    UserId = userId,
                    KitId = kitId, 
                    Status = newStatus,
                    Notes = "" 
                });
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Gundam?> GetGundamAsync(string modelNumber)
        {
             return await _context.Gundams.FirstOrDefaultAsync(g => g.ModelNumber == modelNumber);
        }

        public async Task<List<GunplaKit>> GetKitsForGundamAsync(string modelNumber)
        {
            return await _context.GunplaKits
                .Where(k => k.GundamModelNumber == modelNumber)
                .Include(k => k.Gundam)
                .ToListAsync();
        }

        public async Task<GunplaKit?> GetKitAsync(string kitId)
        {
            return await _context.GunplaKits
                .Include(k => k.Gundam)
                .FirstOrDefaultAsync(k => k.Id == kitId);
        }

        public async Task<UserKitEntry?> GetUserEntryAsync(string kitId)
        {
             var userId = GetUserId();
             return await _context.UserKitEntries
                .FirstOrDefaultAsync(u => u.KitId == kitId && u.UserId == userId);
        }

    }
}
