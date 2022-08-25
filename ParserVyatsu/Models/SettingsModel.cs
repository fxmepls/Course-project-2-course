using System.Collections.Generic;

namespace ParserVyatsu.Models
{
    /// <summary>
    /// Настройки
    /// </summary>
    internal sealed class SettingsModel
    {
        /// <summary>
        /// Открывать при сохранении расписания
        /// </summary>
        public bool Open { get; set; }

        /// <summary>
        /// Тема
        /// </summary>
        public bool Theme { get; set; }

        /// <summary>
        /// Папка для сохранения
        /// </summary>
        public string Folder { get; set; }

        /// <summary>
        /// Выбранные преподаватели
        /// </summary>
        public List<SelectedTeacher> SelectedTeachers { get; set; } = new List<SelectedTeacher>();
    }
}
