using System.Text;
using System.Text.RegularExpressions;

namespace ASP_site.Helpers
{
    public static partial class StringUtils
    {
        // Pre-compile the regex for performance
        [GeneratedRegex("\\^.|<[^>]*>")]
        private static partial Regex ColorAndHtmlTagsRegex();

        public static string CleanString(string input, bool removeColors = true, bool removeHtml = true, Encoding? encoding = null)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            var currentEncoding = encoding ?? Encoding.UTF8;
            byte[] bytes = currentEncoding.GetBytes(input);
            string decodedString = currentEncoding.GetString(bytes);

            // Simplify the removal logic
            if (removeColors)
            {
                // Basic color code removal (e.g., ^1, ^2, etc.) - adjust regex if needed for specific formats
                decodedString = ColorAndHtmlTagsRegex().Replace(decodedString, string.Empty); // Combined removal
            }
            else if (removeHtml)
            {
                // If only removing HTML, use a simpler regex or method
                // For basic HTML tags: decodedString = Regex.Replace(decodedString, "<[^>]*>", string.Empty);
                // More robust HTML stripping might require a dedicated library if complex HTML is expected.
                decodedString = ColorAndHtmlTagsRegex().Replace(decodedString, match => match.Value.StartsWith("^") ? match.Value : string.Empty); // Keep colors, remove HTML

            }

            return decodedString.Trim();
        }
    }
} 