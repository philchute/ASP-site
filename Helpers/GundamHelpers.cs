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

        public static string GetTimeline(string? series)
        {
            if (string.IsNullOrEmpty(series)) return GunplaConstants.Timelines.Other;

            return series switch
            {
                // Universal Century
                GunplaConstants.Series.MSG or
                "MSV" or
                GunplaConstants.Series.MSG08 or
                "MS IGLOO" or
                GunplaConstants.Series.HarmonyOfGundam or
                GunplaConstants.Series.BlueDestiny or
                GunplaConstants.Series.BattlefieldRecord or
                GunplaConstants.Series.RequiemForVengeance or
                GunplaConstants.Series.WarInThePocket or
                GunplaConstants.Series.StardustMemory or
                GunplaConstants.Series.Zeta or
                "Zeta MSV" or
                GunplaConstants.Series.AdvanceOfZeta or
                GunplaConstants.Series.ZZ or
                GunplaConstants.Series.Moon or
                GunplaConstants.Series.Sentinel or
                GunplaConstants.Series.CCA or
                GunplaConstants.Series.CCABC or
                GunplaConstants.Series.Unicorn or
                GunplaConstants.Series.GQ or
                "Gundam UC" or
                "Gundam UC MSV" or
                "Twilight Axis" or
                "Gundam NT" or
                GunplaConstants.Series.Hathaway or
                GunplaConstants.Series.F90 or
                GunplaConstants.Series.F91 or
                GunplaConstants.Series.SilhouetteFormula91 or
                GunplaConstants.Series.Crossbone or
                GunplaConstants.Series.Victory => GunplaConstants.Timelines.UC,

                // Future Century
                GunplaConstants.Series.GGundam => GunplaConstants.Timelines.FC,

                // After Colony
                GunplaConstants.Series.Wing or
                GunplaConstants.Series.EW or
                GunplaConstants.Series.GUnit => GunplaConstants.Timelines.AC,

                // After War
                GunplaConstants.Series.X => GunplaConstants.Timelines.AW,

                // Correct Century
                GunplaConstants.Series.TurnA => GunplaConstants.Timelines.CC,

                // Cosmic Era
                GunplaConstants.Series.Seed or
                GunplaConstants.Series.SeedAstray or
                GunplaConstants.Series.SeedDestiny or
                GunplaConstants.Series.SeedFreedom or
                GunplaConstants.Series.SeedStargazer => GunplaConstants.Timelines.CE,

                // Anno Domini
                GunplaConstants.Series.MSG00 or
                "Extreme Vs" => GunplaConstants.Timelines.AD,

                // Advanced Generation
                GunplaConstants.Series.AGE => GunplaConstants.Timelines.AG,

                // Regild Century
                GunplaConstants.Series.GReco => GunplaConstants.Timelines.RC,

                // Post Disaster
                GunplaConstants.Series.IBO => GunplaConstants.Timelines.PD,

                // Ad Stella
                GunplaConstants.Series.WFM => GunplaConstants.Timelines.AS,

                // Build
                GunplaConstants.Series.BuildFighters or
                GunplaConstants.Series.BuildDivers or
                GunplaConstants.Series.PlamoKyoshiro => GunplaConstants.Timelines.Build,

                _ => GunplaConstants.Timelines.Other
            };
        }

        public static string GetSeriesColor(string? series)
        {
            if (string.IsNullOrEmpty(series)) return "#808080"; // Gray default

            // We can now use GetTimeline logic if we wanted to group colors by timeline,
            // but for now we keep the specific series mapping for colors as they are more granular.
            
            return series switch
            {
                GunplaConstants.Series.MSG or 
                "MSV" or 
                GunplaConstants.Series.MSG08 or 
                "MS IGLOO" or 
                GunplaConstants.Series.HarmonyOfGundam or 
                GunplaConstants.Series.BlueDestiny or 
                GunplaConstants.Series.BattlefieldRecord or 
                GunplaConstants.Series.RequiemForVengeance => "#FDB813", // Yellow-Orange

                GunplaConstants.Series.WarInThePocket => "#8DB600", // Light Green
                
                GunplaConstants.Series.StardustMemory => "#0047AB", // Blue
                
                GunplaConstants.Series.Zeta or 
                "Zeta MSV" or 
                GunplaConstants.Series.AdvanceOfZeta => "#008000", // Green

                GunplaConstants.Series.ZZ or 
                GunplaConstants.Series.Moon => "#FF8C00", // Orange

                GunplaConstants.Series.Sentinel => "#00FFFF", // Cyan

                GunplaConstants.Series.CCA or 
                GunplaConstants.Series.CCABC or
                GunplaConstants.Series.Unicorn or 
                GunplaConstants.Series.GQ or 
                "Gundam UC" or 
                "Gundam UC MSV" or 
                "Twilight Axis" or 
                "Gundam NT" or 
                GunplaConstants.Series.Hathaway => "#FF0000", // Red

                GunplaConstants.Series.F90 or
                GunplaConstants.Series.F91 or 
                GunplaConstants.Series.SilhouetteFormula91 or
                GunplaConstants.Series.Crossbone => "#B0E0E6", // Pale-Blue

                GunplaConstants.Series.Victory => "#FFFF00", // Yellow

                GunplaConstants.Series.GGundam => "#FF4500", // Red-Orange

                GunplaConstants.Series.Wing or 
                GunplaConstants.Series.EW or 
                GunplaConstants.Series.GUnit => "#800080", // Purple

                GunplaConstants.Series.X => "#66e4f5", // Sky-Blue

                GunplaConstants.Series.TurnA => "#FFFFFF", // White

                GunplaConstants.Series.Seed or 
                GunplaConstants.Series.SeedAstray or
                GunplaConstants.Series.SeedDestiny or
                GunplaConstants.Series.SeedFreedom or
                GunplaConstants.Series.SeedStargazer => "#000080", // Dark-Blue

                "Extreme Vs" => "#0000FF", // Gloss-Blue
                
                _ => "#808080" // Default Gray
            };
        }
    }
}
