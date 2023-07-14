using Discoteque.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Discoteque.Data
{

    public class DiscotequeContext : DbContext
    {
        public DiscotequeContext(DbContextOptions<DiscotequeContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; } = null!;
        public DbSet<Album> Albums { get; set; } = null!;
    }
}
