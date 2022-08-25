using System;
using System.Text.RegularExpressions;

namespace ParserVyatsu.Models
{
    public class Link
    {
        private readonly Regex dateTimeRegex = new Regex(@"\d{1,2}.\d{1,2}.\d{4}");

        public string Period { get; set; }

        public string ExcelUrl { get; set; }

        public string HtmlUrl { get; set; }

        public string FileName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool PeriodEqual(string period)
        {
            var matches = dateTimeRegex.Matches(period);
            var start = DateTime.Parse(matches[0].Value);
            var end = DateTime.Parse(matches[1].Value);

            return StartDate == start && EndDate == end;
        }
    }
}
