using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ASP_site.Models
{
    public class ComicIssue
    {
        [Key]
        public string IssueID { get; set; } = "";
        public string SeriesTitle { get; set; } = "";
        public string IssueNumber { get; set; } = "";
        public string Description { get; set; } = "";
        public int? PublishYear { get; set; }
        public int? PublishMonth { get; set; }
        
        // Credits
        public string? Author { get; set; }
        public string? Artist { get; set; }
        public string? Inker { get; set; }
        public string? Pencils { get; set; }
        public string? Letters { get; set; }
    }
}