using MaterialSkin;
using MaterialSkin.Controls;

using ParserVyatsu.CalendarModel;
using ParserVyatsu.ExelFiles;
using ParserVyatsu.Models;
using ParserVyatsu.Parsers;
using ParserVyatsu.PdfFiles;
using ParserVyatsu.Settings;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ParserVyatsu
{
    public partial class ParserForm : MaterialForm
    {
        private SettingsModel _settings;

        private readonly ParserStartList parser;
        public string FolderLink = @"C:\Users\" + Environment.UserName + @"\Downloads";
        private readonly MaterialSkinManager materialSkinManager;
        private int _currentPeriodIndex;

        public ParserForm()
        {
            InitializeComponent();
            parser = new ParserStartList();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
        }

        /// <summary>
        /// Если выбранный период сменился не на текущий,
        /// становится доступной кнопка возврата к текущему периоду,
        /// период выбранного расписания доступен только на 2 недели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PeriodcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentPeriodButton.Enabled = _currentPeriodIndex != PeriodcomboBox.SelectedIndex;
            this.Refresh();

        }

        /// <summary>
        /// Скачивает эксель-таблицу с сайта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Selectbutton_Click(object sender, EventArgs e)
        {
            if (_settings.SelectedTeachers == null || _settings.SelectedTeachers.Count == 0)
            {
                MessageBox.Show("Не выбраны преподаватели для формирования расписания");
                return;
            }

            var periodParser = new PeriodParser();
            List<StudyPeriod> data = new List<StudyPeriod>();

            foreach (var selectedTeacher in _settings.SelectedTeachers)
            {
                StudyPeriod parsedData;
                var department = new Date(parser.Institutes).GetDepartment(selectedTeacher);
                if (CalendarCheckBox.Checked)
                {
                    parsedData = periodParser.Parse(selectedTeacher.Teacher, department.Links, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
                }
                else
                {
                    var link = department.Links.FirstOrDefault(i => i.PeriodEqual(PeriodcomboBox.SelectedItem as string));
                    parsedData = periodParser.Parse(selectedTeacher.Teacher, department.Links, link.StartDate, link.EndDate);
                }
                data.Add(parsedData);
            }
            DownloadFolder downloadFolder = new DownloadFolder();
            FolderLink = downloadFolder.GetLink(data.FirstOrDefault());
            if (FolderLink == null) return;
            var mergedData = new MergedStudyPeriods(data);
            if (downloadFolder.filter == 1)
            {
                PdfCreate pdfCreate = new PdfCreate();
                pdfCreate.CreatePDF(FolderLink, mergedData, OpenFilecheckBox.Checked);
            }
            else
            {
                var creator = new ExcelCreate();
                creator.CreateExcel(FolderLink, mergedData, OpenFilecheckBox.Checked);
            }
        }

        private void OpenFilecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _settings.Open = OpenFilecheckBox.Checked;
        }

        /// <summary>
        /// Проверка на использование календаря
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalendarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PeriodcomboBox.SelectedItem != null)
            {
                if (CalendarCheckBox.Checked)
                {
                    dateTimePicker1.Enabled = true;
                    dateTimePicker2.Enabled = true;
                    PeriodcomboBox.Enabled = false;

                }
                else
                {
                    dateTimePicker1.Enabled = false;
                    dateTimePicker2.Enabled = false;
                    PeriodcomboBox.Enabled = true;
                }
            }

        }
        /// <summary>
        /// Смена темы приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemeButton_Click(object sender, EventArgs e)
        {
            if (_settings.Theme)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue700, Accent.Blue700, TextShade.WHITE);
                dateTimePicker1.TextColor = Color.Black;
                dateTimePicker2.TextColor = Color.Black;
                _settings.Theme = false;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey100, Accent.LightBlue200, TextShade.WHITE);
                dateTimePicker1.TextColor = Color.White;
                dateTimePicker2.TextColor = Color.White;
                _settings.Theme = true;
            }
        }

        /// <summary>
        /// Сохранение выбранных полей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveChangesButton1_Click(object sender, EventArgs e)
        {
            SaveSettings saveSettings = new SaveSettings();
            saveSettings.SaveSetting(_settings);
        }

        /// <summary>
        /// Переходит к текущему периоду
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialButton2_Click(object sender, EventArgs e)
        {
            PeriodcomboBox.SelectedIndex = _currentPeriodIndex;
            CurrentPeriodButton.Enabled = false;
        }

        #region Загрузка формы

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParserForm_Load(object sender, EventArgs e)
        {
            parser.Parser();
            dateTimePicker1.Invalidate();
            var openSave = new OpenSaveSettings();
            _settings = openSave.OpenSetting();
            _settings.Theme = !_settings.Theme;

            _settings.Open = _settings.Open;
            if (_settings.Open)
            {
                OpenFilecheckBox.Checked = true;
            }
            else
            {
                OpenFilecheckBox.Checked = false;
            }

            ThemeButton_Click(sender, e);

            if (_settings.Folder != null)
            {
                FolderLink = _settings.Folder;
            }

            foreach (var teacher in _settings.SelectedTeachers)
            {
                TeacherListBox.Items.Add(CreateFromSelectedTeacher(teacher));
                UpdatePeriodComboBox();
            }
        }

        #endregion

        private void AddButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm(materialSkinManager, parser.Institutes);
            if (selectForm.ShowDialog() == DialogResult.OK)
            {
                if (_settings.SelectedTeachers.Contains(selectForm.SelectedTeacher)) return;
                _settings.SelectedTeachers.Add(selectForm.SelectedTeacher);
                TeacherListBox.Items.Add(CreateFromSelectedTeacher(selectForm.SelectedTeacher));
                UpdatePeriodComboBox();
            }
        }

        private MaterialListBoxItem CreateFromSelectedTeacher(SelectedTeacher teacher)
        {
            return new MaterialListBoxItem(teacher.Teacher, teacher.Department);
        }

        private void TeacherListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            DeleteButton.Enabled = TeacherListBox.SelectedIndex != -1;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedItem = TeacherListBox.SelectedItem;

            var teacher = _settings.SelectedTeachers.FirstOrDefault(i => i.Teacher == selectedItem.Text && i.Department == selectedItem.SecondaryText);
            _settings.SelectedTeachers.Remove(teacher);

            TeacherListBox.RemoveItem(TeacherListBox.SelectedItem);
            DeleteButton.Enabled = false;
            UpdatePeriodComboBox();
        }

        private void UpdatePeriodComboBox()
        {
            if (_settings.SelectedTeachers.Count == 0)
            {
                PeriodcomboBox.Items.Clear();
                Refresh();
                return;
            }

            if (PeriodcomboBox.Items.Count > 0) return;

            var teacher = _settings.SelectedTeachers.FirstOrDefault();
            var date = new Date(parser.Institutes);
            var department = date.GetDepartment(teacher);
            PeriodcomboBox.Items.AddRange(department.Links.Select(i => i.Period).ToArray());

            _currentPeriodIndex = date.GetDate(department);
            PeriodcomboBox.SelectedIndex = _currentPeriodIndex;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                dateTimePicker1.Value = dateTimePicker2.Value;
            }
        }
    }
}


