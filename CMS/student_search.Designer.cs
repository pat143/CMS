namespace CMS
{
    partial class student_search
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
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.tb_middlename = new System.Windows.Forms.TextBox();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.tb_enrollment_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cMSDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMSDataSet1 = new CMS.CMSDataSet1();
            this.btn_edit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_lastname);
            this.panel1.Controls.Add(this.tb_middlename);
            this.panel1.Controls.Add(this.tb_firstname);
            this.panel1.Controls.Add(this.tb_enrollment_no);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(21, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 471);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(532, 134);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(965, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(951, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Last";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(780, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Middle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "First";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Student Name";
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(901, 46);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(120, 20);
            this.tb_lastname.TabIndex = 5;
            // 
            // tb_middlename
            // 
            this.tb_middlename.Location = new System.Drawing.Point(744, 46);
            this.tb_middlename.Name = "tb_middlename";
            this.tb_middlename.Size = new System.Drawing.Size(120, 20);
            this.tb_middlename.TabIndex = 4;
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(580, 46);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(120, 20);
            this.tb_firstname.TabIndex = 3;
            // 
            // tb_enrollment_no
            // 
            this.tb_enrollment_no.Location = new System.Drawing.Point(153, 46);
            this.tb_enrollment_no.Name = "tb_enrollment_no";
            this.tb_enrollment_no.Size = new System.Drawing.Size(165, 20);
            this.tb_enrollment_no.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enrollment No.";
            // 
            // cMSDataSet1BindingSource
            // 
            this.cMSDataSet1BindingSource.DataSource = this.cMSDataSet1;
            this.cMSDataSet1BindingSource.Position = 0;
            // 
            // cMSDataSet1
            // 
            this.cMSDataSet1.DataSetName = "CMSDataSet1";
            this.cMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(532, 379);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 24;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // student_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.Controls.Add(this.panel1);
            this.Name = "student_search";
            this.Text = "Search";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_middlename;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.TextBox tb_enrollment_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.BindingSource cMSDataSet1BindingSource;
        private CMSDataSet1 cMSDataSet1;
        private System.Windows.Forms.Button btn_edit;
    }
}