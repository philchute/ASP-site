using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ASP_site.Models
{
    public enum BookType
    {
        Novel,
        //Novella,
        ShortStory,
        NonFiction,
        Poem,
        //Screenplay,
        Forward
    }

    public class Book
    {
        [Key]
        public string Title { get; set; } = "";

        [Required]
        public string Author { get; set; } = "Robert A. Heinlein";

        public string? WrittenAs { get; set; } // Pseudonym

        public int? PublicationYear { get; set; }

        public int? PublicationMonth { get; set; }

        public BookType Type { get; set; }
        
        public string? Description { get; set; }

        public string? Notes { get; set; }

        public string? ParentCollectionTitle { get; set; }
        public Book? ParentCollection { get; set; }

        // Navigation property for many-to-many relationship
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }
} 