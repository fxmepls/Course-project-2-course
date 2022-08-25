using System.Collections.Generic;

namespace ParserVyatsu.Models
{
    /// <summary>
    /// Факультет
    /// </summary>
    public class Faculty
    {
        public string Name { get; set; }

        /// <summary>
        /// Кафедры
        /// </summary>
        public List<Department> Departments { get; set; } = new List<Department>();
    }
}
