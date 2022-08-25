using System;

namespace ParserVyatsu.Models
{
    internal class Lesson
    {
        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return $"{StartTime}-{EndTime}: {Title}";
        }
    }
}
