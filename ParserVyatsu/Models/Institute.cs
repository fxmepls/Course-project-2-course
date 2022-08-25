using System.Collections.Generic;

namespace ParserVyatsu.Models
{
    /// <summary>
    /// Институт
    /// </summary>
    public class Institute
    {
        public string Name { get; set; }

        public List<Faculty> Faculties { get; set; } = new List<Faculty>();
    }
}
