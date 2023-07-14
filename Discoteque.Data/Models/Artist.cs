using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discoteque.Data.Models
{
    public class Artist : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Label { get; set; }
        public bool IsOnTour { get; set; }
    }
}
