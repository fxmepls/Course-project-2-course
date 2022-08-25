using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyatsuParser.Models
{
    /// <summary>
    /// Факультет
    /// </summary>
    class Faculty
    {
        public string Name { get; set; }

        /// <summary>
        /// Кафедры
        /// </summary>
        public List<Department> Departments { get; set; } = new List<Department>();
    }
}
