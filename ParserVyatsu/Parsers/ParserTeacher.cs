using HtmlAgilityPack;

using ParserVyatsu.Extensions;
using ParserVyatsu.Models;

using System.Collections.Generic;
using System.Linq;

namespace ParserVyatsu.Parsers
{
    internal class ParserTeacher
    {
        private readonly string Url = "https://www.vyatsu.ru";
        public List<Teacher> Teachers { get; } = new List<Teacher>();

        public ParserTeacher(string Url)
        {
            this.Url += Url;
        }

        public void Parse()
        {
            var web = new HtmlWeb();
            var doc = web.Load(Url);
            var scheduleNode = doc.DocumentNode.Descendants("tr").FirstOrDefault(i => i.HasClass("R1"));
            foreach (var child in scheduleNode.ChildNodes)
            {
                if (child.Name.ToLower() == "td" && child.HasClass("R1C2"))
                {
                    var name = child.ChildNodes.FirstOrDefault(i => i.Name == "span")?.InnerText;
                    var Teacher = new Teacher()
                    {
                        Name = CleanName(name)
                    };
                    Teachers.Add(Teacher);
                }
            }
        }
        private static string CleanName(string input)
        {
            return input.Decode();
        }
    }
}
