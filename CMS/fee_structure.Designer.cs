namespace CMS
{
    partial class fee_structure
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_show_fee_chart = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(379, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(500, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox_class
            // 
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Items.AddRange(new object[] {
            "FE",
            "SE",
            "TE",
            "BE"});
            this.comboBox_class.Location = new System.Drawing.Point(126, 134);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(121, 21);
            this.comboBox_class.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class/Year";
            // 
            // btn_show_fee_chart
            // 
            this.btn_show_fee_chart.Location = new System.Drawing.Point(84, 221);
            this.btn_show_fee_chart.Name = "btn_show_fee_chart";
            this.btn_show_fee_chart.Size = new System.Drawing.Size(138, 44);
            this.btn_show_fee_chart.TabIndex = 3;
            this.btn_show_fee_chart.Text = "Show Fee Chart";
            this.btn_show_fee_chart.UseVisualStyleBackColor = true;
            this.btn_show_fee_chart.Click += new System.EventHandler(this.btn_show_fee_chart_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(941, 113);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(104, 37);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(941, 231);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(104, 34);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // fee_structure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_show_fee_chart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_class);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fee_structure";
            this.Text = "Fee Structure";
            this.Load += new System.EventHandler(this.fee_structure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_show_fee_chart;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_update;
    }
}