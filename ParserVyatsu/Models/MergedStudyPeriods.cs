using System;
using System.Collections.Generic;
using System.Linq;

namespace ParserVyatsu.Models
{
    internal sealed class MergedStudyPeriods
    {
        public DateTime StartDate { get; }

        public DateTime EndDate { get; }

        public List<string> TeacherNames { get; }

        public SortedList<DateTime, MergedStudyDays> StudyDays { get; } = new SortedList<DateTime, MergedStudyDays>();

        public MergedStudyPeriods(List<StudyPeriod> studyPeriods)
        {
            StartDate = studyPeriods.Min(i => i.StartDate);
            EndDate = studyPeriods.Max(i => i.EndDate);
            TeacherNames = studyPeriods.Select(i => i.TeacherName).Distinct().ToList();

            foreach (var studyPeriod in studyPeriods)
            {
                foreach (var day in studyPeriod.StudyDays)
                {
                    MergedStudyDays mergedStudyDays = null;
                    if (StudyDays.ContainsKey(day.Key))
                        mergedStudyDays = StudyDays[day.Key];
                    else
                    {
                        mergedStudyDays = new MergedStudyDays();
                        StudyDays.Add(day.Key, mergedStudyDays);
                    }
                    
                    foreach (var lesson in day.Value.Lessons)
                    {
                        if (!mergedStudyDays.Times.ContainsKey(lesson.Key))
                            mergedStudyDays.Times.Add(lesson.Key, lesson.Value.EndTime);

                        Dictionary<string, string> values;
                        if (mergedStudyDays.Lessons.ContainsKey(lesson.Key))
                            values = mergedStudyDays.Lessons[lesson.Key];
                        else
                        {
                            values = new Dictionary<string, string>(TeacherNames.Count);
                            foreach (var teacherName in TeacherNames)
                            {
                                values.Add(teacherName, string.Empty);
                            }
                            mergedStudyDays.Lessons.Add(lesson.Key, values);
                        }

                        if (values.ContainsKey(studyPeriod.TeacherName))
                        {
                            values[studyPeriod.TeacherName] += (!string.IsNullOrEmpty(values[studyPeriod.TeacherName]) ?"\n" : "") + lesson.Value.Title;
                        }
                        else
                        {
                            values.Add(studyPeriod.TeacherName, lesson.Value.Title);
                        }
                    }
                }
            }
        }
    }
}
