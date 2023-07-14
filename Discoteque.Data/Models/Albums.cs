using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discoteque.Data.Models
{
    public class Album : BaseEntity<int>
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public Genres Genre { get; set; } = Genres.Unknown;
    }

    public enum Genres
    {
        Rock,
        Metal,
        Salsa,
        Merengue,
        Urban,
        Folk,
        Indie,
        Techno,
        Unknown
    }
}
