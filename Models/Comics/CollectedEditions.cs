using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ASP_site.Models
{
    public class CollectedEdition
    {
        [Key]
        public string EditionID { get; set; } = "";
        public string Line { get; set; } = "";
        public string Title { get; set; } = "";
        public string Format { get; set; } = "";
        public int? ReleaseYear { get; set; }
        public int? ReleaseMonth { get; set; }
        public int? ReleaseDay { get; set; }
        public List<string> CollectedIssueIDs { get; set; } = new List<string>();
    }
}