using FilmWebPage.Models;
using Microsoft.EntityFrameworkCore;

namespace Mission06_Briggs.Models
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options) : base(options) { }

        public DbSet<Movies> Movies { get; set; }

        public DbSet<Categories> Categories { get; set; }

    }
}
