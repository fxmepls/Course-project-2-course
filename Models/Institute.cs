using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyatsuParser.Models
{
    /// <summary>
    /// Институт
    /// </summary>
    class Institute
    {
        public string Name { get; set; }

        public List<Faculty> Faculties { get; set; } = new List<Faculty>();
    }
}
