using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FilmWebPage.Models;

namespace Mission06_Briggs.Models
{
    public class Movies
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Categories? Categories { get; set; }

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

        public bool CopiedToPlex { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; } // Optional, explicitly nullable, limited to 25 characters
    }
}
