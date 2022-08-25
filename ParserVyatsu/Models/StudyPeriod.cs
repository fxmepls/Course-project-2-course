using System;
using System.Collections.Generic;

namespace ParserVyatsu.Models
{
    internal class StudyPeriod
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string TeacherName { get; set; }

        public SortedList<DateTime, StudyDay> StudyDays { get; } = new SortedList<DateTime, StudyDay>();
    }
}
