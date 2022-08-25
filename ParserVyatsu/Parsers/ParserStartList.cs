using HtmlAgilityPack;

using ParserVyatsu.Models;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ParserVyatsu.Parsers
{
    internal class ParserStartList
    {
        private const string Url = "https://www.vyatsu.ru/studentu-1/spravochnaya-informatsiya/teacher.html";

        public List<Institute> Institutes { get; } = new List<Institute>();

        public ParserStartList()
        {
        }

        public void Parser()
        {
            var web = new HtmlWeb();
            var doc = web.Load(Url);
            // находим расписание
            var scheduleNode = doc.DocumentNode.Descendants("div").FirstOrDefault(i => i.HasClass("column-center_rasp"));

            // проходим всех детей ноды

            Institute currentInstitute = null;

            foreach (var child in scheduleNode.ChildNodes)
            {
                //  если нашли название института, то создаем его
                if (child.Name.ToLower() == "div" && child.HasClass("headerEduPrograms"))
                {
                    currentInstitute = new Institute
                    {
                        Name = CleanName(child.InnerText)
                    };

                    Institutes.Add(currentInstitute);

                }
                //  если нашли таблицу с факультетами
                else if (child.Name.ToLower() == "table")
                {
                    //  находим ноды с факультетами
                    var facultyNodes = child.Descendants("div").Where(i => i.HasClass("fak_name"));
                    foreach (var facultyNode in facultyNodes)
                    {
                        //  создаем факультет
                        var faculty = new Faculty
                        {
                            Name = CleanName(facultyNode.InnerText)
                        };
                        currentInstitute.Faculties.Add(faculty);

                        //  находим кафедры
                        var departments = facultyNode.ParentNode.Descendants("div").Where(i => i.HasClass("kafPeriod"));

                        var regex = new Regex(@"\d{1,2}.\d{1,2}.\d{4}");

                        foreach (var departmentNode in departments)
                        {
                            //  создаем кафедру
                            var department = new Department
                            {
                                Name = CleanName(departmentNode.InnerText)
                            };
                            faculty.Departments.Add(department);

                            //  находим расписания
                            var periodsNode = departmentNode.ParentNode.ChildNodes.FirstOrDefault(i => i.HasClass("listPeriod"));
                            foreach (var periodNode in periodsNode.ChildNodes)
                            {
                                if (periodNode.Name.ToLower() == "a")
                                {
                                    var linkUrl = periodNode.Attributes.FirstOrDefault(i => i.Name == "href")?.Value;
                                    var link = department.Links.FirstOrDefault(i => i.FileName == Path.GetFileNameWithoutExtension(linkUrl));
                                    if (link == null)
                                    {

                                        link = new Link
                                        {
                                            FileName = Path.GetFileNameWithoutExtension(linkUrl),
                                            Period = CleanName(periodNode.InnerText),
                                            HtmlUrl = linkUrl
                                        };

                                        var dates = regex.Matches(link.Period);

                                        link.StartDate = DateTime.Parse(dates[0].Value);
                                        link.EndDate = DateTime.Parse(dates[1].Value);

                                        department.Links.Add(link);
                                    }
                                    else
                                    {
                                        link.ExcelUrl = linkUrl;
                                    }

                                }
                            }

                        }

                        faculty.Departments = faculty.Departments.GroupBy(i => i.Name).Select(g => new Department
                        {
                            Name = g.Key,
                            Links = g.SelectMany(l => l.Links).OrderBy(o => o.StartDate).ToList()
                        }).ToList();

                    }
                }
                else
                {
                    //  ничего не делаем
                }
            }

        }
        private static string CleanName(string input)
        {
            return input.Trim();
        }
    }
}
