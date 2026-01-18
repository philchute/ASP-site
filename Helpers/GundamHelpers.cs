using ASP_site.Models.Gunpla;
using System.Reflection;

namespace ASP_site.Helpers
{
    public static class GundamHelpers
    {
        public static string GetSeriesFullName(string? series)
        {
            if (string.IsNullOrEmpty(series)) return "";

            var field = typeof(GunplaConstants.Series).GetField(series);
            if (field != null)
            {
                return field.GetValue(null)?.ToString() ?? series;
            }
            return series;
        }

        public static string GetSeriesColor(string? series)
        {
            if (string.IsNullOrEmpty(series)) return "#808080"; // Gray default

            return series switch
            {
                GunplaConstants.Series.MSG or 
                "MSV" or 
                GunplaConstants.Series.MSG08 or 
                "MS IGLOO" or 
                "Harmony of Gundam" or 
                "Blue Destiny" or 
                "Battlefield Record U.C. 0081" or 
                "Requiem for Vengeance" => "#FDB813", // Yellow-Orange

                GunplaConstants.Series.WarInThePocket => "#8DB600", // Light Green
                
                GunplaConstants.Series.StardustMemory => "#0047AB", // Blue
                
                GunplaConstants.Series.Zeta or 
                "Zeta MSV" or 
                "Advance of Zeta" => "#008000", // Green

                GunplaConstants.Series.ZZ or 
                "Moon Gundam" => "#FF8C00", // Orange

                GunplaConstants.Series.Sentinel => "#00FFFF", // Cyan

                GunplaConstants.Series.CCA or 
                GunplaConstants.Series.Unicorn or 
                GunplaConstants.Series.GQ or 
                "Gundam UC" or 
                "Gundam UC MSV" or 
                "Twilight Axis" or 
                "Gundam NT" or 
                "Hathaway" => "#FF0000", // Red

                GunplaConstants.Series.F91 or 
                GunplaConstants.Series.Crossbone => "#B0E0E6", // Pale-Blue

                GunplaConstants.Series.Victory => "#FFFF00", // Yellow

                GunplaConstants.Series.GGundam => "#FF4500", // Red-Orange

                GunplaConstants.Series.Wing or 
                GunplaConstants.Series.EW or 
                "Gundam Wing G-Unit" => "#800080", // Purple

                GunplaConstants.Series.X => "#66e4f5", // Sky-Blue

                GunplaConstants.Series.TurnA => "#FFFFFF", // White

                GunplaConstants.Series.Seed or 
                GunplaConstants.Series.SeedDestiny or
                GunplaConstants.Series.SeedFreedom or
                GunplaConstants.Series.SeedStargazer => "#000080", // Dark-Blue

                "Extreme Vs" => "#0000FF", // Gloss-Blue
                
                _ => "#808080" // Default Gray
            };
        }
    }
}
