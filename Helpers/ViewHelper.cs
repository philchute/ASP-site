using System;
using ASP_site.Models;

namespace ASP_site.Helpers
{
    public static class ViewHelper
    {
        public static string GetMonthName(int? month)
        {
            if (month.HasValue && month >= 1 && month <= 12)
            {
                return new DateTime(1, month.Value, 1).ToString("MMMM");
            }
            return string.Empty;
        }

        public static string FormatSettingYear(int? year, SettingCalendar calendar = SettingCalendar.Gregorian)
        {
            if (!year.HasValue)
            {
                return "—";
            }

            var y = year.Value;
            return calendar switch
            {
                SettingCalendar.AfterGuild when y < 0 => $"{Math.Abs(y)} BG",
                SettingCalendar.AfterGuild => $"{y} AG",
                SettingCalendar.MiddleEarth when y < 0 => $"{Math.Abs(y)} SA",
                SettingCalendar.MiddleEarth => $"{y} TA",
                SettingCalendar.Gregorian when y < 0 => $"{Math.Abs(y)} BC",
                _ => y.ToString()
            };
        }
    }
} 