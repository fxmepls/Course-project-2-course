using System.Collections.Generic;

namespace ParserVyatsu.Models
{
    /// <summary>
    /// Кафедра
    /// </summary>
    public class Department
    {
        public string Name { get; set; }

        public List<Link> Links { get; set; } = new List<Link>();
    }
}
