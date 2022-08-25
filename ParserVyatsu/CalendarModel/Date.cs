using ParserVyatsu.Models;

using System;
using System.Collections.Generic;
using System.Linq;

namespace ParserVyatsu.CalendarModel
{
    internal class Date
    {
        private readonly List<Institute> institutes;
        public DateTime dateTime = DateTime.Now.Date;
        private DateTime PeriodDate;
        public Date(List<Institute> institutes)
        {
            this.institutes = institutes;
        }

        public int GetDate(Department department)
        {
            for (int i = 0; i < department.Links.Count; i++)
            {
                if (department.Links[i].StartDate.Date <= dateTime
                    && department.Links[i].EndDate.Date >= dateTime)
                {
                    PeriodDate = department.Links[i].StartDate;
                    return i;
                }
            }
            return 0;
        }

        public Department GetDepartment(SelectedTeacher teacher)
        {
            var institute = institutes.FirstOrDefault(i => i.Name == teacher.Institute);
            var faculty = institute.Faculties.FirstOrDefault(i => i.Name == teacher.Faculty);
            var department = faculty.Departments.FirstOrDefault(i => i.Name == teacher.Department);

            return department;
        }
    }
}
