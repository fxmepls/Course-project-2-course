using HtmlAgilityPack;

using ParserVyatsu.Extensions;
using ParserVyatsu.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ParserVyatsu.Parsers
{
    internal class PeriodParser
    {
        private const string Url = "https://www.vyatsu.ru";
        private static readonly Regex dateRegex = new Regex(@"\d{2}.\d{2}.\d{2}");
        private static readonly Regex timeRegex = new Regex(@"\d{2}:\d{2}");


        public StudyPeriod Parse(string teacher, IEnumerable<Link> links, DateTime startDate, DateTime endDate)
        {
            var period = new StudyPeriod
            {
                StartDate = startDate,
                EndDate = endDate,
                TeacherName = teacher
            };

            var web = new HtmlWeb();

            foreach (var link in links.SkipWhile(i => i.StartDate < startDate && i.EndDate < startDate).TakeWhile(i => i.StartDate <= endDate))
            {
                var doc = web.Load(Url + link.HtmlUrl);
                var body = doc.DocumentNode.Descendants("table").FirstOrDefault();
                var rows = body.ChildNodes.Where(i => i.Name.ToLower() == "tr").ToList();

                var teachersRow = rows.Skip(1).FirstOrDefault();
                var teacherColumn = teachersRow.ChildNodes.FirstOrDefault(i => i.FirstChild?.InnerText.Decode().Contains(teacher) ?? false);
                if (teacherColumn == null)
                {
                    continue;
                }
                var teacherIndex = teachersRow.ChildNodes.Where(i => i.Name.ToLower() == "td").ToList().IndexOf(teacherColumn);

                for (var row = 2; row < rows.Count; row += 7)
                {
                    var currentDay = rows[row].ChildNodes.FirstOrDefault(i => i.Attributes["ROWSPAN"] != null);
                    if (currentDay == null)
                    {
                        continue;
                    }

                    var date = dateRegex.Match(currentDay.InnerText);

                    var day = new StudyDay
                    {
                        Date = DateTime.Parse(date.Value)
                    };

                    if (day.Date < startDate || day.Date > endDate)
                    {
                        continue;
                    }

                    for (var innerRow = row; innerRow < row + 7; innerRow++)
                    {
                        var columns = rows[innerRow].ChildNodes.Where(i => i.Name.ToLower() == "td").ToList();
                        MatchCollection times;
                        HtmlNode lessonNode;
                        if (innerRow == row)
                        {
                            times = timeRegex.Matches(columns[1].InnerText);
                            lessonNode = columns[teacherIndex];
                        }
                        else
                        {
                            times = timeRegex.Matches(columns[0].InnerText);
                            lessonNode = columns[teacherIndex - 1];
                        }

                        var lesson = new Lesson
                        {
                            StartTime = TimeSpan.Parse(times[0].Value),
                            EndTime = TimeSpan.Parse(times[1].Value),
                            Title = lessonNode.ChildNodes.FirstOrDefault()?.InnerText.Decode() ?? string.Empty,
                        };

                        day.Lessons.Add(lesson.StartTime, lesson);
                    }

                    period.StudyDays.Add(day.Date, day);
                }
            }

            return period;
        }
    }
}
