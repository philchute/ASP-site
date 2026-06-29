using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ASP_site.Models
{
    public class StoryArc
    {
        [Key]
        public string ArcID { get; set; } = "";
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public List<string> IssueIDs { get; set; } = new List<string>();
    }
}