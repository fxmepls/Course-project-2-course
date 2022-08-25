using System;
using System.Collections.Generic;

namespace ParserVyatsu.Models
{
    internal class MergedStudyDays
    {
        public SortedList<TimeSpan, TimeSpan> Times { get; } = new SortedList<TimeSpan, TimeSpan>();

        public SortedList<TimeSpan, Dictionary<string, string>> Lessons { get; } = new SortedList<TimeSpan, Dictionary<string, string>>();
    }
}
