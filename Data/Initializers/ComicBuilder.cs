using ASP_site.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP_site.Data.Initializers
{
    public static class ComicBuilder
    {
        /// <summary>
        /// Generates a sequential run of comic issues, automatically incrementing months and years.
        /// </summary>
        public static IEnumerable<ComicIssue> GenerateRun(
            string seriesIdPrefix,
            string seriesTitle,
            int startIssue,
            int endIssue,
            int? startYear = null,
            int? startMonth = null,
            string? author = null,
            string? artist = null,
            string? inker = null,
            string? pencils = null,
            string? letters = null,
            string? descriptionTemplate = null)
        {
            var issues = new List<ComicIssue>();

            for (int i = 0; i <= (endIssue - startIssue); i++)
            {
                int issueNum = startIssue + i;
                
                int? publishYear = startYear;
                int? publishMonth = startMonth;

                // Handle the month/year incrementing
                if (startYear.HasValue && startMonth.HasValue)
                {
                    // Subtract 1 from startMonth to make it 0-indexed for modulo math
                    int totalMonths = (startMonth.Value - 1) + i;
                    publishMonth = (totalMonths % 12) + 1; // Convert back to 1-12
                    publishYear = startYear.Value + (totalMonths / 12);
                }

                // If description format was provided (e.g. "Chapter {0}"), fill it
                string description = "";
                if (!string.IsNullOrEmpty(descriptionTemplate))
                {
                    description = string.Format(descriptionTemplate, issueNum);
                }

                issues.Add(new ComicIssue
                {
                    IssueID = $"{seriesIdPrefix}-{issueNum}",
                    SeriesTitle = seriesTitle,
                    IssueNumber = issueNum.ToString(),
                    PublishYear = publishYear,
                    PublishMonth = publishMonth,
                    Author = author,
                    Artist = artist,
                    Inker = inker,
                    Pencils = pencils,
                    Letters = letters,
                    Description = description
                });
            }
            
            return issues;
        }

        /// <summary>
        /// Helper to generate a list of issue IDs for use in StoryArcs and CollectedEditions.
        /// Example: GetIssueIds("amazing-spider-man", 1, 38)
        /// </summary>
        public static List<string> GetIssueIds(string seriesIdPrefix, int startIssue, int endIssue)
        {
            var ids = new List<string>();
            for (int i = startIssue; i <= endIssue; i++)
            {
                ids.Add($"{seriesIdPrefix}-{i}");
            }
            return ids;
        }

        /// <summary>
        /// Extension method to bulk edit a range of issues in your list.
        /// Example: issues.UpdateRange("amazing-spider-man", 12, 14, i => i.Artist = "John Romita Sr.");
        /// </summary>
        public static void UpdateRange(this List<ComicIssue> issues, string seriesIdPrefix, int startIssue, int endIssue, Action<ComicIssue> updateAction)
        {
            for (int i = startIssue; i <= endIssue; i++)
            {
                string targetId = $"{seriesIdPrefix}-{i}";
                var issue = issues.FirstOrDefault(x => x.IssueID == targetId);
                if (issue != null)
                {
                    updateAction(issue);
                }
            }
        }

        /// <summary>
        /// Extension method to edit a single issue in your list.
        /// Example: issues.UpdateIssue("amazing-spider-man", 15, i => i.Description = "First appearance of Kraven");
        /// </summary>
        public static void UpdateIssue(this List<ComicIssue> issues, string seriesIdPrefix, int issueNum, Action<ComicIssue> updateAction)
        {
            string targetId = $"{seriesIdPrefix}-{issueNum}";
            var issue = issues.FirstOrDefault(x => x.IssueID == targetId);
            if (issue != null)
            {
                updateAction(issue);
            }
        }
    }
}