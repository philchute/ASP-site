using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_site.Models
{
    public class UpdatePost
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public required string Title { get; set; }

        [Required]
        public required string Content { get; set; } // Could be HTML or Markdown

        public DateTime PostedDate { get; set; } = DateTime.UtcNow;

        [StringLength(100)]
        public string? Author { get; set; }

        // Navigation property for many-to-many relationship
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }
} 