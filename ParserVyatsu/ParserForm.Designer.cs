
namespace ParserVyatsu {
    partial class ParserForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParserForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.start = new System.Windows.Forms.TabPage();
            this.TeacherListBox = new MaterialSkin.Controls.MaterialListBox();
            this.DeleteButton = new MaterialSkin.Controls.MaterialButton();
            this.AddButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.CalendarCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveChangesButton1 = new MaterialSkin.Controls.MaterialButton();
            this.CurrentPeriodButton = new MaterialSkin.Controls.MaterialButton();
            this.SelectButton = new MaterialSkin.Controls.MaterialButton();
            this.EndDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.StartDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.PeriodcomboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OpenFilecheckBox = new System.Windows.Forms.CheckBox();
            this.ThemeButtom = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dateTimePicker2 = new ParserVyatsu.Components.DatePickerExt(this.components);
            this.dateTimePicker1 = new ParserVyatsu.Components.DatePickerExt(this.components);
            this.materialTabControl1.SuspendLayout();
            this.start.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.start);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 66);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(579, 600);
            this.materialTabControl1.TabIndex = 0;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.White;
            this.start.Controls.Add(this.TeacherListBox);
            this.start.Controls.Add(this.DeleteButton);
            this.start.Controls.Add(this.AddButton);
            this.start.Controls.Add(this.materialLabel1);
            this.start.Controls.Add(this.CalendarCheckBox);
            this.start.Controls.Add(this.SaveChangesButton1);
            this.start.Controls.Add(this.dateTimePicker2);
            this.start.Controls.Add(this.dateTimePicker1);
            this.start.Controls.Add(this.CurrentPeriodButton);
            this.start.Controls.Add(this.SelectButton);
            this.start.Controls.Add(this.EndDateLabel);
            this.start.Controls.Add(this.StartDateLabel);
            this.start.Controls.Add(this.materialLabel5);
            this.start.Controls.Add(this.PeriodcomboBox);
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.ImageKey = "home-variant.png";
            this.start.Location = new System.Drawing.Point(4, 39);
            this.start.Name = "start";
            this.start.Padding = new System.Windows.Forms.Padding(3);
            this.start.Size = new System.Drawing.Size(571, 557);
            this.start.TabIndex = 0;
            this.start.Text = "Главная";
            this.start.UseVisualStyleBackColor = true;
            // 
            // TeacherListBox
            // 
            this.TeacherListBox.BackColor = System.Drawing.Color.White;
            this.TeacherListBox.BorderColor = System.Drawing.Color.LightGray;
            this.TeacherListBox.Depth = 0;
            this.TeacherListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TeacherListBox.Location = new System.Drawing.Point(67, 36);
            this.TeacherListBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.TeacherListBox.Name = "TeacherListBox";
            this.TeacherListBox.SelectedIndex = -1;
            this.TeacherListBox.SelectedItem = null;
            this.TeacherListBox.Size = new System.Drawing.Size(446, 171);
            this.TeacherListBox.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            this.TeacherListBox.TabIndex = 66;
            this.TeacherListBox.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.TeacherListBox_SelectedIndexChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.Enabled = false;
            this.DeleteButton.HighEmphasis = true;
            this.DeleteButton.Icon = null;
            this.DeleteButton.Location = new System.Drawing.Point(422, 216);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteButton.Size = new System.Drawing.Size(91, 36);
            this.DeleteButton.TabIndex = 65;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteButton.UseAccentColor = true;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddButton.Depth = 0;
            this.AddButton.HighEmphasis = true;
            this.AddButton.Icon = null;
            this.AddButton.Location = new System.Drawing.Point(314, 216);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddButton.Size = new System.Drawing.Size(100, 36);
            this.AddButton.TabIndex = 64;
            this.AddButton.Text = "Добавить";
            this.AddButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddButton.UseAccentColor = false;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(64, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(118, 19);
            this.materialLabel1.TabIndex = 63;
            this.materialLabel1.Text = "Преподаватели";
            // 
            // CalendarCheckBox
            // 
            this.CalendarCheckBox.AutoSize = true;
            this.CalendarCheckBox.Location = new System.Drawing.Point(66, 417);
            this.CalendarCheckBox.Name = "CalendarCheckBox";
            this.CalendarCheckBox.Size = new System.Drawing.Size(156, 17);
            this.CalendarCheckBox.TabIndex = 61;
            this.CalendarCheckBox.Text = "Использовать календарь";
            this.CalendarCheckBox.UseVisualStyleBackColor = true;
            this.CalendarCheckBox.CheckedChanged += new System.EventHandler(this.CalendarCheckBox_CheckedChanged);
            // 
            // SaveChangesButton1
            // 
            this.SaveChangesButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveChangesButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveChangesButton1.Depth = 0;
            this.SaveChangesButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveChangesButton1.HighEmphasis = false;
            this.SaveChangesButton1.Icon = null;
            this.SaveChangesButton1.Location = new System.Drawing.Point(67, 216);
            this.SaveChangesButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveChangesButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveChangesButton1.Name = "SaveChangesButton1";
            this.SaveChangesButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveChangesButton1.Size = new System.Drawing.Size(203, 36);
            this.SaveChangesButton1.TabIndex = 59;
            this.SaveChangesButton1.Text = "Сохранить изменения";
            this.SaveChangesButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.SaveChangesButton1.UseAccentColor = false;
            this.SaveChangesButton1.UseVisualStyleBackColor = true;
            this.SaveChangesButton1.Click += new System.EventHandler(this.SaveChangesButton1_Click);
            // 
            // CurrentPeriodButton
            // 
            this.CurrentPeriodButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CurrentPeriodButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CurrentPeriodButton.Depth = 0;
            this.CurrentPeriodButton.Enabled = false;
            this.CurrentPeriodButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CurrentPeriodButton.HighEmphasis = false;
            this.CurrentPeriodButton.Icon = null;
            this.CurrentPeriodButton.Location = new System.Drawing.Point(239, 309);
            this.CurrentPeriodButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CurrentPeriodButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CurrentPeriodButton.Name = "CurrentPeriodButton";
            this.CurrentPeriodButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CurrentPeriodButton.Size = new System.Drawing.Size(259, 36);
            this.CurrentPeriodButton.TabIndex = 56;
            this.CurrentPeriodButton.Text = "Перейти к текущему периоду";
            this.CurrentPeriodButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.CurrentPeriodButton.UseAccentColor = false;
            this.CurrentPeriodButton.UseVisualStyleBackColor = true;
            this.CurrentPeriodButton.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SelectButton.Depth = 0;
            this.SelectButton.HighEmphasis = true;
            this.SelectButton.Icon = null;
            this.SelectButton.Location = new System.Drawing.Point(226, 487);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SelectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SelectButton.Size = new System.Drawing.Size(89, 36);
            this.SelectButton.TabIndex = 55;
            this.SelectButton.Text = "Создать";
            this.SelectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SelectButton.UseAccentColor = false;
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.Selectbutton_Click);
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Depth = 0;
            this.EndDateLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EndDateLabel.Location = new System.Drawing.Point(274, 442);
            this.EndDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(19, 19);
            this.EndDateLabel.TabIndex = 52;
            this.EndDateLabel.Text = "по";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Depth = 0;
            this.StartDateLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StartDateLabel.Location = new System.Drawing.Point(66, 442);
            this.StartDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(11, 19);
            this.StartDateLabel.TabIndex = 51;
            this.StartDateLabel.Text = "С";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(64, 318);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(132, 19);
            this.materialLabel5.TabIndex = 48;
            this.materialLabel5.Text = "Выберите период";
            // 
            // PeriodcomboBox
            // 
            this.PeriodcomboBox.AutoResize = false;
            this.PeriodcomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PeriodcomboBox.Depth = 0;
            this.PeriodcomboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.PeriodcomboBox.DropDownHeight = 174;
            this.PeriodcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PeriodcomboBox.DropDownWidth = 121;
            this.PeriodcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.PeriodcomboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PeriodcomboBox.FormattingEnabled = true;
            this.PeriodcomboBox.IntegralHeight = false;
            this.PeriodcomboBox.ItemHeight = 43;
            this.PeriodcomboBox.Location = new System.Drawing.Point(67, 349);
            this.PeriodcomboBox.MaxDropDownItems = 4;
            this.PeriodcomboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PeriodcomboBox.Name = "PeriodcomboBox";
            this.PeriodcomboBox.Size = new System.Drawing.Size(446, 49);
            this.PeriodcomboBox.StartIndex = 0;
            this.PeriodcomboBox.TabIndex = 42;
            this.PeriodcomboBox.SelectedIndexChanged += new System.EventHandler(this.PeriodcomboBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.OpenFilecheckBox);
            this.tabPage2.Controls.Add(this.ThemeButtom);
            this.tabPage2.ImageKey = "cog (1).png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            // 
            // OpenFilecheckBox
            // 
            this.OpenFilecheckBox.AutoSize = true;
            this.OpenFilecheckBox.Checked = true;
            this.OpenFilecheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpenFilecheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OpenFilecheckBox.Location = new System.Drawing.Point(89, 75);
            this.OpenFilecheckBox.Name = "OpenFilecheckBox";
            this.OpenFilecheckBox.Size = new System.Drawing.Size(273, 21);
            this.OpenFilecheckBox.TabIndex = 63;
            this.OpenFilecheckBox.Text = "Открыть расписание по завершению";
            this.OpenFilecheckBox.UseVisualStyleBackColor = true;
            this.OpenFilecheckBox.CheckedChanged += new System.EventHandler(this.OpenFilecheckBox_CheckedChanged);
            // 
            // ThemeButtom
            // 
            this.ThemeButtom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ThemeButtom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ThemeButtom.Depth = 0;
            this.ThemeButtom.HighEmphasis = true;
            this.ThemeButtom.Icon = null;
            this.ThemeButtom.Location = new System.Drawing.Point(89, 19);
            this.ThemeButtom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ThemeButtom.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeButtom.Name = "ThemeButtom";
            this.ThemeButtom.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ThemeButtom.Size = new System.Drawing.Size(144, 36);
            this.ThemeButtom.TabIndex = 56;
            this.ThemeButtom.Text = "Изменить тему";
            this.ThemeButtom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ThemeButtom.UseAccentColor = false;
            this.ThemeButtom.UseVisualStyleBackColor = true;
            this.ThemeButtom.Click += new System.EventHandler(this.ThemeButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "setting.png");
            this.imageList1.Images.SetKeyName(2, "cog (1).png");
            this.imageList1.Images.SetKeyName(3, "cog.png");
            this.imageList1.Images.SetKeyName(4, "delete-circle.png");
            this.imageList1.Images.SetKeyName(5, "home-circle-outline (1).png");
            this.imageList1.Images.SetKeyName(6, "home-circle-outline.png");
            this.imageList1.Images.SetKeyName(7, "store.png");
            this.imageList1.Images.SetKeyName(8, "home-variant-outline.png");
            this.imageList1.Images.SetKeyName(9, "home-variant.png");
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.BackDisabledColor = System.Drawing.Color.Gray;
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.Purple;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(314, 441);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker2.TabIndex = 58;
            this.dateTimePicker2.TextColor = System.Drawing.Color.White;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BackDisabledColor = System.Drawing.Color.Gray;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Purple;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 441);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 57;
            this.dateTimePicker1.TextColor = System.Drawing.Color.White;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 655);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.ParserForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.start.ResumeLayout(false);
            this.start.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage start;
        private MaterialSkin.Controls.MaterialButton SelectButton;
        private MaterialSkin.Controls.MaterialLabel EndDateLabel;
        private MaterialSkin.Controls.MaterialLabel StartDateLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox PeriodcomboBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton CurrentPeriodButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private Components.DatePickerExt dateTimePicker2;
        private Components.DatePickerExt dateTimePicker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialButton SaveChangesButton1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox CalendarCheckBox;
        private MaterialSkin.Controls.MaterialButton ThemeButtom;
        private System.Windows.Forms.CheckBox OpenFilecheckBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton DeleteButton;
        private MaterialSkin.Controls.MaterialButton AddButton;
        private MaterialSkin.Controls.MaterialListBox TeacherListBox;
    }
}

