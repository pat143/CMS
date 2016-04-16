namespace CMS
{
    partial class promote_student
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbm_education_year_new = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_class_new = new System.Windows.Forms.ComboBox();
            this.comboBox_division_new = new System.Windows.Forms.ComboBox();
            this.comboBox_specialization_new = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_promote = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checker = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Enrollment_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Register_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tbm_education_yr = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.comboBox_division = new System.Windows.Forms.ComboBox();
            this.comboBox_specialization = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentcollegeinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMSDataSet1 = new CMS.CMSDataSet1();
            this.cMSDataSet = new CMS.CMSDataSet();
            this.cMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_college_infoTableAdapter = new CMS.CMSDataSet1TableAdapters.student_college_infoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentcollegeinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbm_education_year_new);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox_class_new);
            this.panel1.Controls.Add(this.comboBox_division_new);
            this.panel1.Controls.Add(this.comboBox_specialization_new);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.btn_promote);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.tbm_education_yr);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.comboBox_class);
            this.panel1.Controls.Add(this.comboBox_division);
            this.panel1.Controls.Add(this.comboBox_specialization);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 471);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbm_education_year_new
            // 
            this.tbm_education_year_new.Location = new System.Drawing.Point(779, 110);
            this.tbm_education_year_new.Mask = "0000-0000";
            this.tbm_education_year_new.Name = "tbm_education_year_new";
            this.tbm_education_year_new.Size = new System.Drawing.Size(120, 20);
            this.tbm_education_year_new.TabIndex = 85;
            this.tbm_education_year_new.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Educational Year";
            // 
            // comboBox_class_new
            // 
            this.comboBox_class_new.FormattingEnabled = true;
            this.comboBox_class_new.Items.AddRange(new object[] {
            "FE",
            "SE",
            "TE",
            "BE"});
            this.comboBox_class_new.Location = new System.Drawing.Point(652, 69);
            this.comboBox_class_new.Name = "comboBox_class_new";
            this.comboBox_class_new.Size = new System.Drawing.Size(121, 21);
            this.comboBox_class_new.TabIndex = 83;
            // 
            // comboBox_division_new
            // 
            this.comboBox_division_new.FormattingEnabled = true;
            this.comboBox_division_new.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.comboBox_division_new.Location = new System.Drawing.Point(842, 69);
            this.comboBox_division_new.Name = "comboBox_division_new";
            this.comboBox_division_new.Size = new System.Drawing.Size(100, 21);
            this.comboBox_division_new.TabIndex = 82;
            // 
            // comboBox_specialization_new
            // 
            this.comboBox_specialization_new.FormattingEnabled = true;
            this.comboBox_specialization_new.Items.AddRange(new object[] {
            "COMPUTER ENGINEERING",
            "CIVIL ENGINEERING",
            "MECHANICAL ENGINEERING",
            "ELECTRICAL ENGINEERING",
            "ELECTRONICS & TELECOMMUNICATION ENGINEERING"});
            this.comboBox_specialization_new.Location = new System.Drawing.Point(726, 30);
            this.comboBox_specialization_new.Name = "comboBox_specialization_new";
            this.comboBox_specialization_new.Size = new System.Drawing.Size(177, 21);
            this.comboBox_specialization_new.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Specialization";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(792, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Division";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1025, 264);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 77;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(576, 158);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(427, 297);
            this.dataGridView2.TabIndex = 76;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Enrollment_No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Student_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Register_No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // btn_promote
            // 
            this.btn_promote.Location = new System.Drawing.Point(495, 283);
            this.btn_promote.Name = "btn_promote";
            this.btn_promote.Size = new System.Drawing.Size(75, 23);
            this.btn_promote.TabIndex = 75;
            this.btn_promote.Text = "Promote";
            this.btn_promote.UseVisualStyleBackColor = true;
            this.btn_promote.Click += new System.EventHandler(this.btn_promote_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checker,
            this.Enrollment_No,
            this.Student_Name,
            this.Register_No});
            this.dataGridView1.Location = new System.Drawing.Point(15, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(474, 297);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.btn_promote_Click);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // checker
            // 
            this.checker.HeaderText = "";
            this.checker.Name = "checker";
            this.checker.Width = 50;
            // 
            // Enrollment_No
            // 
            this.Enrollment_No.HeaderText = "Enrollment_No";
            this.Enrollment_No.Name = "Enrollment_No";
            this.Enrollment_No.Width = 120;
            // 
            // Student_Name
            // 
            this.Student_Name.HeaderText = "Student_Name";
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Width = 150;
            // 
            // Register_No
            // 
            this.Register_No.HeaderText = "Register_No";
            this.Register_No.Name = "Register_No";
            this.Register_No.Width = 110;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(263, 108);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 72;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // tbm_education_yr
            // 
            this.tbm_education_yr.Location = new System.Drawing.Point(117, 110);
            this.tbm_education_yr.Mask = "0000-0000";
            this.tbm_education_yr.Name = "tbm_education_yr";
            this.tbm_education_yr.Size = new System.Drawing.Size(120, 20);
            this.tbm_education_yr.TabIndex = 71;
            this.tbm_education_yr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 70;
            this.label15.Text = "Educational Year";
            // 
            // comboBox_class
            // 
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Items.AddRange(new object[] {
            "FE",
            "SE",
            "TE",
            "BE"});
            this.comboBox_class.Location = new System.Drawing.Point(61, 69);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(121, 21);
            this.comboBox_class.TabIndex = 69;
            // 
            // comboBox_division
            // 
            this.comboBox_division.FormattingEnabled = true;
            this.comboBox_division.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.comboBox_division.Location = new System.Drawing.Point(251, 69);
            this.comboBox_division.Name = "comboBox_division";
            this.comboBox_division.Size = new System.Drawing.Size(100, 21);
            this.comboBox_division.TabIndex = 68;
            // 
            // comboBox_specialization
            // 
            this.comboBox_specialization.FormattingEnabled = true;
            this.comboBox_specialization.Items.AddRange(new object[] {
            "COMPUTER ENGINEERING",
            "CIVIL ENGINEERING",
            "MECHANICAL ENGINEERING",
            "ELECTRICAL ENGINEERING",
            "ELECTRONICS & TELECOMMUNICATION ENGINEERING"});
            this.comboBox_specialization.Location = new System.Drawing.Point(135, 30);
            this.comboBox_specialization.Name = "comboBox_specialization";
            this.comboBox_specialization.Size = new System.Drawing.Size(177, 21);
            this.comboBox_specialization.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Specialization";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Division";
            // 
            // studentcollegeinfoBindingSource
            // 
            this.studentcollegeinfoBindingSource.DataMember = "student_college_info";
            this.studentcollegeinfoBindingSource.DataSource = this.cMSDataSet1;
            // 
            // cMSDataSet1
            // 
            this.cMSDataSet1.DataSetName = "CMSDataSet1";
            this.cMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cMSDataSet
            // 
            this.cMSDataSet.DataSetName = "CMSDataSet";
            this.cMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cMSDataSetBindingSource
            // 
            this.cMSDataSetBindingSource.DataSource = this.cMSDataSet;
            this.cMSDataSetBindingSource.Position = 0;
            // 
            // student_college_infoTableAdapter
            // 
            this.student_college_infoTableAdapter.ClearBeforeFill = true;
            // 
            // promote_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.Controls.Add(this.panel1);
            this.Name = "promote_student";
            this.Text = "Promote";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentcollegeinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_specialization;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.ComboBox comboBox_division;
        private System.Windows.Forms.MaskedTextBox tbm_education_yr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cMSDataSetBindingSource;
        private CMSDataSet cMSDataSet;
        private System.Windows.Forms.Button btn_refresh;
        private CMSDataSet1 cMSDataSet1;
        private System.Windows.Forms.BindingSource studentcollegeinfoBindingSource;
        private CMSDataSet1TableAdapters.student_college_infoTableAdapter student_college_infoTableAdapter;
        private System.Windows.Forms.Button btn_promote;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.MaskedTextBox tbm_education_year_new;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_class_new;
        private System.Windows.Forms.ComboBox comboBox_division_new;
        private System.Windows.Forms.ComboBox comboBox_specialization_new;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enrollment_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Register_No;
    }
}