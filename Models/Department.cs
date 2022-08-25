using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyatsuParser.Models
{
    /// <summary>
    /// Кафедра
    /// </summary>
    class Department
    {
        public string Name { get; set; }

        public List<Link> Links { get; set; } = new List<Link>();
    }
}
