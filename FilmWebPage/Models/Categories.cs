using System.ComponentModel.DataAnnotations;

namespace FilmWebPage.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
