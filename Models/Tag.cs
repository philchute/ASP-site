using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_site.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public required string Name { get; set; }

        // Navigation property for many-to-many relationship
        public ICollection<UpdatePost> UpdatePosts { get; set; } = new List<UpdatePost>();
    }
} 