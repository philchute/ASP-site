using Microsoft.EntityFrameworkCore;
using ASP_site.Data;
using ASP_site.Models;

namespace ASP_site.Helpers
{
    public static class FranchiseLookup
    {
        public static Task<List<Franchise>> ForMediaAsync(GameContext context, string mediaId) =>
            ForKeysAsync(context, works => works.Where(w => w.MediaID == mediaId));

        public static Task<List<Franchise>> ForGameAsync(GameContext context, string gameId) =>
            ForKeysAsync(context, works => works.Where(w => w.GameID == gameId));

        private static async Task<List<Franchise>> ForKeysAsync(
            GameContext context,
            Func<IQueryable<FranchiseWork>, IQueryable<FranchiseWork>> filter)
        {
            var franchiseIds = await filter(context.FranchiseWorks.AsNoTracking())
                .Select(w => w.FranchiseID)
                .Distinct()
                .ToListAsync();

            if (franchiseIds.Count == 0)
            {
                return [];
            }

            return await context.Franchises
                .AsNoTracking()
                .Where(f => franchiseIds.Contains(f.FranchiseID))
                .OrderBy(f => f.Name)
                .ToListAsync();
        }
    }
}
