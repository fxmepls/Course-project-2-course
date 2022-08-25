using HtmlAgilityPack;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using VyatsuParser.Models;

namespace VyatsuParser
{
    class Program
    {
        const string Url = "https://www.vyatsu.ru/studentu-1/spravochnaya-informatsiya/teacher.html";

        static void Main(string[] args)
        {
            var web = new HtmlWeb();
            var doc = web.Load(Url);

            var institutes = new List<Institute>();

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

                    institutes.Add(currentInstitute);
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
                                        department.Links.Add(link);
                                    }
                                    else
                                    {
                                        link.ExcelUrl = linkUrl;
                                    }

                                }
                            }

                        }

                    }
                }
                else
                {
                    //  ничего не делаем
                }
            }
            
            foreach (var institute in institutes)
            {
                Console.WriteLine(institute.Name);

                foreach (var fac in institute.Faculties)
                {
                    Console.WriteLine($"\t{fac.Name}");

                    foreach (var dep in fac.Departments)
                    {
                        Console.WriteLine($"\t\t{dep.Name}");
                    }
                }
            }

        }

        private static string CleanName(string input)
        {
            return input.Trim();
        }
    }
}
