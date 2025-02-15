using Microsoft.EntityFrameworkCore;

namespace FilmWebPage.Models
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options) : base(options) { }

        public DbSet<FilmCollection> FilmCollections { get; set; }
    }
}
