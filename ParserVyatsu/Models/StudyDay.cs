using System;
using System.Collections.Generic;
using System.Linq;

namespace ParserVyatsu.Models
{
    internal class StudyDay
    {
        public DateTime Date { get; set; }

        public SortedList<TimeSpan, Lesson> Lessons { get; } = new SortedList<TimeSpan, Lesson>();

        public override string ToString()
        {
            return $"{Date}: {Lessons.Where(i => !string.IsNullOrEmpty(i.Value.Title)).Count()}";
        }
    }
}
