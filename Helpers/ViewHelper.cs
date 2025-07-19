using System;

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
    }
} 