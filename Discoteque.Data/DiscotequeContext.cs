using Discoteque.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
