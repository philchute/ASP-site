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

        /// <summary>
        /// Removes Quake 3 / id Tech 3 color codes (^1, ^xRRGGBB, etc). ^^ becomes a literal ^.
        /// </summary>
        public static string StripQuake3Colors(string? input)
        {
            if (string.IsNullOrEmpty(input))
                return input ?? "";

            var sb = new StringBuilder(input.Length);
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] != '^' || i + 1 >= input.Length)
                {
                    sb.Append(input[i]);
                    continue;
                }

                var next = input[i + 1];
                if (next == '^')
                {
                    sb.Append('^');
                    i++;
                    continue;
                }

                if ((next is 'x' or 'X') && i + 7 < input.Length && IsHex6(input, i + 2))
                {
                    i += 7;
                    continue;
                }

                i++;
            }

            return sb.ToString();
        }

        private static bool IsHex6(string s, int start)
        {
            for (var i = 0; i < 6; i++)
            {
                var c = s[start + i];
                if (c is not (>= '0' and <= '9') and not (>= 'a' and <= 'f') and not (>= 'A' and <= 'F'))
                    return false;
            }
            return true;
        }

        public static string ToSlug(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return "";
            var slug = value.Trim().ToLowerInvariant();
            slug = Regex.Replace(slug, @"[^a-z0-9]+", "-");
            return slug.Trim('-');
        }
    }
} 