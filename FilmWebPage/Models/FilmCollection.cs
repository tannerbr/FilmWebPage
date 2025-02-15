using System.ComponentModel.DataAnnotations;

namespace FilmWebPage.Models
{
    public class FilmCollection
    {
        [Key]
        [Required]
        public int FilmID { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1900, 2100)]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool? Edited { get; set; } // Optional, uses nullable type

        [StringLength(100)]
        public string? LentTo { get; set; } // Optional, explicitly nullable

        [MaxLength(25)]
        public string? Notes { get; set; } // Optional, explicitly nullable, limited to 25 characters
    }
}
