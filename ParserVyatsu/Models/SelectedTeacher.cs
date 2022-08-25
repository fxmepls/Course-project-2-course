using System;
using System.Collections.Generic;

namespace ParserVyatsu.Models
{
    /// <summary>
    /// Выбранный преподаватель
    /// </summary>
    public sealed class SelectedTeacher : IEquatable<SelectedTeacher>
    {
        /// <summary>
        /// Институт
        /// </summary>
        public string Institute { get; set; }

        /// <summary>
        /// Факультет
        /// </summary>
        public string Faculty { get; set; }

        /// <summary>
        /// Кафедра
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Преподаватель
        /// </summary>
        public string Teacher { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as SelectedTeacher);
        }

        public bool Equals(SelectedTeacher other)
        {
            return other != null &&
                   Institute == other.Institute &&
                   Faculty == other.Faculty &&
                   Department == other.Department &&
                   Teacher == other.Teacher;
        }

        public override int GetHashCode()
        {
            int hashCode = -263614933;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Institute);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Faculty);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Department);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Teacher);
            return hashCode;
        }

        public static bool operator ==(SelectedTeacher left, SelectedTeacher right)
        {
            return EqualityComparer<SelectedTeacher>.Default.Equals(left, right);
        }

        public static bool operator !=(SelectedTeacher left, SelectedTeacher right)
        {
            return !(left == right);
        }
    }
}
