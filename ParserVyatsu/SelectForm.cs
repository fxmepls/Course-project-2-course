using MaterialSkin.Controls;

using ParserVyatsu.Models;
using ParserVyatsu.Parsers;

using System.Collections.Generic;
using System.Linq;

namespace ParserVyatsu
{
    public partial class SelectForm : MaterialForm
    {
        private readonly List<Institute> _institutes;
        private readonly SelectedTeacher _selectedTeacher = new SelectedTeacher();

        /// <summary>
        /// Выбранный преподаватель
        /// </summary>
        public SelectedTeacher SelectedTeacher { get; private set; }

        public SelectForm(MaterialSkin.MaterialSkinManager materialSkinManager, List<Institute> institutes)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            _institutes = institutes;

            InstituteComboBox.Items.AddRange(_institutes.Select(i => i.Name).ToArray());
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            SelectedTeacher = _selectedTeacher;
            Close();
        }

        private void InstituteComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            FacultyComboBox.Items.Clear();
            DepartmentComboBox.Items.Clear();
            TeachercomboBox.Items.Clear();

            _selectedTeacher.Institute = InstituteComboBox.SelectedItem as string;

            FacultyComboBox.Items.AddRange(_institutes.FirstOrDefault(i => i.Name == _selectedTeacher.Institute).Faculties.Select(i => i.Name).ToArray());

            FacultyComboBox.Enabled = true;
            DepartmentComboBox.Enabled = false;
            TeachercomboBox.Enabled = false;
            AddButton.Enabled = false;
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _selectedTeacher.Faculty = FacultyComboBox.SelectedItem as string;

            DepartmentComboBox.Items.Clear();
            TeachercomboBox.Items.Clear();

            var institute = _institutes.FirstOrDefault(i => i.Name == _selectedTeacher.Institute);
            var faculty = institute.Faculties.FirstOrDefault(i => i.Name == _selectedTeacher.Faculty);

            DepartmentComboBox.Items.AddRange(faculty.Departments.Select(i => i.Name).ToArray());

            DepartmentComboBox.Enabled = true;
            TeachercomboBox.Enabled = false;
            AddButton.Enabled = false;
        }

        private void DepartmentComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _selectedTeacher.Department = DepartmentComboBox.SelectedItem as string;

            TeachercomboBox.Items.Clear();

            var institute = _institutes.FirstOrDefault(i => i.Name == _selectedTeacher.Institute);
            var faculty = institute.Faculties.FirstOrDefault(i => i.Name == _selectedTeacher.Faculty);
            var department = faculty.Departments.FirstOrDefault(i => i.Name == _selectedTeacher.Department);

            ParserTeacher parserTeacher = new ParserTeacher(department.Links.FirstOrDefault().HtmlUrl);
            parserTeacher.Parse();

            TeachercomboBox.Items.AddRange(parserTeacher.Teachers.Select(i => i.Name).ToArray());

            TeachercomboBox.Enabled = true;
            AddButton.Enabled = false;
        }

        private void TeachercomboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _selectedTeacher.Teacher = TeachercomboBox.SelectedItem as string;

            AddButton.Enabled = true;
        }
    }
}
