namespace ParserVyatsu
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TeachercomboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.DepartmentComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.FacultyComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.InstituteComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.AddButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(31, 342);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(193, 19);
            this.materialLabel4.TabIndex = 55;
            this.materialLabel4.Text = "Выберите преподавателя";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(31, 253);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(143, 19);
            this.materialLabel3.TabIndex = 54;
            this.materialLabel3.Text = "Выберите кафедру";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Location = new System.Drawing.Point(31, 169);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(158, 19);
            this.materialLabel2.TabIndex = 53;
            this.materialLabel2.Text = "Выберите факультет";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.White;
            this.materialLabel1.Location = new System.Drawing.Point(31, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(145, 19);
            this.materialLabel1.TabIndex = 52;
            this.materialLabel1.Text = "Выберите институт";
            // 
            // TeachercomboBox
            // 
            this.TeachercomboBox.AutoResize = false;
            this.TeachercomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TeachercomboBox.Depth = 0;
            this.TeachercomboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TeachercomboBox.DropDownHeight = 174;
            this.TeachercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeachercomboBox.DropDownWidth = 121;
            this.TeachercomboBox.Enabled = false;
            this.TeachercomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TeachercomboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TeachercomboBox.FormattingEnabled = true;
            this.TeachercomboBox.IntegralHeight = false;
            this.TeachercomboBox.ItemHeight = 43;
            this.TeachercomboBox.Location = new System.Drawing.Point(34, 366);
            this.TeachercomboBox.MaxDropDownItems = 4;
            this.TeachercomboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.TeachercomboBox.Name = "TeachercomboBox";
            this.TeachercomboBox.Size = new System.Drawing.Size(446, 49);
            this.TeachercomboBox.StartIndex = 0;
            this.TeachercomboBox.TabIndex = 51;
            this.TeachercomboBox.SelectedIndexChanged += new System.EventHandler(this.TeachercomboBox_SelectedIndexChanged);
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.AutoResize = false;
            this.DepartmentComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DepartmentComboBox.Depth = 0;
            this.DepartmentComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.DepartmentComboBox.DropDownHeight = 174;
            this.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentComboBox.DropDownWidth = 121;
            this.DepartmentComboBox.Enabled = false;
            this.DepartmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DepartmentComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.IntegralHeight = false;
            this.DepartmentComboBox.ItemHeight = 43;
            this.DepartmentComboBox.Location = new System.Drawing.Point(34, 279);
            this.DepartmentComboBox.MaxDropDownItems = 4;
            this.DepartmentComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(446, 49);
            this.DepartmentComboBox.StartIndex = 0;
            this.DepartmentComboBox.TabIndex = 50;
            this.DepartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentComboBox_SelectedIndexChanged);
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.AutoResize = false;
            this.FacultyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FacultyComboBox.Depth = 0;
            this.FacultyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.FacultyComboBox.DropDownHeight = 174;
            this.FacultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyComboBox.DropDownWidth = 121;
            this.FacultyComboBox.Enabled = false;
            this.FacultyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.FacultyComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.IntegralHeight = false;
            this.FacultyComboBox.ItemHeight = 43;
            this.FacultyComboBox.Location = new System.Drawing.Point(34, 191);
            this.FacultyComboBox.MaxDropDownItems = 4;
            this.FacultyComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(446, 49);
            this.FacultyComboBox.StartIndex = 0;
            this.FacultyComboBox.TabIndex = 49;
            this.FacultyComboBox.SelectedIndexChanged += new System.EventHandler(this.FacultyComboBox_SelectedIndexChanged);
            // 
            // InstituteComboBox
            // 
            this.InstituteComboBox.AutoResize = false;
            this.InstituteComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InstituteComboBox.Depth = 0;
            this.InstituteComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.InstituteComboBox.DropDownHeight = 174;
            this.InstituteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InstituteComboBox.DropDownWidth = 121;
            this.InstituteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.InstituteComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InstituteComboBox.FormattingEnabled = true;
            this.InstituteComboBox.IntegralHeight = false;
            this.InstituteComboBox.ItemHeight = 43;
            this.InstituteComboBox.Location = new System.Drawing.Point(34, 102);
            this.InstituteComboBox.MaxDropDownItems = 4;
            this.InstituteComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.InstituteComboBox.Name = "InstituteComboBox";
            this.InstituteComboBox.Size = new System.Drawing.Size(446, 49);
            this.InstituteComboBox.StartIndex = 0;
            this.InstituteComboBox.TabIndex = 48;
            this.InstituteComboBox.SelectedIndexChanged += new System.EventHandler(this.InstituteComboBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddButton.Depth = 0;
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Enabled = false;
            this.AddButton.HighEmphasis = true;
            this.AddButton.Icon = null;
            this.AddButton.Location = new System.Drawing.Point(193, 441);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddButton.Size = new System.Drawing.Size(100, 36);
            this.AddButton.TabIndex = 56;
            this.AddButton.Text = "Добавить";
            this.AddButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddButton.UseAccentColor = false;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 524);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TeachercomboBox);
            this.Controls.Add(this.DepartmentComboBox);
            this.Controls.Add(this.FacultyComboBox);
            this.Controls.Add(this.InstituteComboBox);
            this.Name = "SelectForm";
            this.Text = "Выберите преподавателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox TeachercomboBox;
        private MaterialSkin.Controls.MaterialComboBox DepartmentComboBox;
        private MaterialSkin.Controls.MaterialComboBox FacultyComboBox;
        private MaterialSkin.Controls.MaterialComboBox InstituteComboBox;
        private MaterialSkin.Controls.MaterialButton AddButton;
    }
}