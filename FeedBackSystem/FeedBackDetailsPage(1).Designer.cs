namespace FeedBackSystem
{
    partial class Form3
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
            this.tb_college_and_place = new System.Windows.Forms.TextBox();
            this.tb_branch = new System.Windows.Forms.TextBox();
            this.tb_stud_present = new System.Windows.Forms.TextBox();
            this.tb_total_studs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.cb_batch = new System.Windows.Forms.ComboBox();
            this.cb_div = new System.Windows.Forms.ComboBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_college_and_place
            // 
            this.tb_college_and_place.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_college_and_place.Location = new System.Drawing.Point(332, 57);
            this.tb_college_and_place.Multiline = true;
            this.tb_college_and_place.Name = "tb_college_and_place";
            this.tb_college_and_place.Size = new System.Drawing.Size(171, 21);
            this.tb_college_and_place.TabIndex = 0;
            // 
            // tb_branch
            // 
            this.tb_branch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_branch.Location = new System.Drawing.Point(332, 149);
            this.tb_branch.Name = "tb_branch";
            this.tb_branch.Size = new System.Drawing.Size(171, 20);
            this.tb_branch.TabIndex = 2;
            // 
            // tb_stud_present
            // 
            this.tb_stud_present.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_stud_present.Location = new System.Drawing.Point(332, 300);
            this.tb_stud_present.Name = "tb_stud_present";
            this.tb_stud_present.Size = new System.Drawing.Size(171, 20);
            this.tb_stud_present.TabIndex = 5;
            // 
            // tb_total_studs
            // 
            this.tb_total_studs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_total_studs.Location = new System.Drawing.Point(332, 350);
            this.tb_total_studs.Name = "tb_total_studs";
            this.tb_total_studs.Size = new System.Drawing.Size(171, 20);
            this.tb_total_studs.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "College and \r\nPlace";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Branch";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Div";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Batch";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "No. of Students \r\npresent";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "No. of Students\r\non Roll no.";
            // 
            // cb_class
            // 
            this.cb_class.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Items.AddRange(new object[] {
            "FE",
            "SE",
            "TE",
            "BE"});
            this.cb_class.Location = new System.Drawing.Point(332, 101);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(171, 21);
            this.cb_class.TabIndex = 14;
            // 
            // cb_batch
            // 
            this.cb_batch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_batch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_batch.FormattingEnabled = true;
            this.cb_batch.Items.AddRange(new object[] {
            "B1",
            "B2",
            "B3"});
            this.cb_batch.Location = new System.Drawing.Point(332, 253);
            this.cb_batch.Name = "cb_batch";
            this.cb_batch.Size = new System.Drawing.Size(171, 21);
            this.cb_batch.TabIndex = 15;
            // 
            // cb_div
            // 
            this.cb_div.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_div.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_div.FormattingEnabled = true;
            this.cb_div.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cb_div.Location = new System.Drawing.Point(332, 201);
            this.cb_div.Name = "cb_div";
            this.cb_div.Size = new System.Drawing.Size(171, 21);
            this.cb_div.TabIndex = 16;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(332, 407);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 17;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(428, 407);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 471);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.cb_div);
            this.Controls.Add(this.cb_batch);
            this.Controls.Add(this.cb_class);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_college_and_place);
            this.Controls.Add(this.tb_total_studs);
            this.Controls.Add(this.tb_stud_present);
            this.Controls.Add(this.tb_branch);
            this.Name = "Form3";
            this.Text = "Admin Page";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_college_and_place;
        private System.Windows.Forms.TextBox tb_branch;
        private System.Windows.Forms.TextBox tb_stud_present;
        private System.Windows.Forms.TextBox tb_total_studs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.ComboBox cb_batch;
        private System.Windows.Forms.ComboBox cb_div;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_exit;
    }
}