using Microsoft.EntityFrameworkCore;

namespace Mission06_Briggs.Models
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options) : base(options) { }

        public DbSet<FilmCollection> FilmCollections { get; set; }
    }
}
