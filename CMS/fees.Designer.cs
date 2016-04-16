namespace CMS
{
    partial class fees
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_receipt_no = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_amount_paid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_cheque_dd_no = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton_transfer = new System.Windows.Forms.RadioButton();
            this.radioButton_DD = new System.Windows.Forms.RadioButton();
            this.radioButton_cheque = new System.Windows.Forms.RadioButton();
            this.radioButton_cash = new System.Windows.Forms.RadioButton();
            this.tb_enrollment_no = new System.Windows.Forms.TextBox();
            this.tb_last_name = new System.Windows.Forms.TextBox();
            this.tb_middle_name = new System.Windows.Forms.TextBox();
            this.tb_first_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt No.";
            // 
            // tb_receipt_no
            // 
            this.tb_receipt_no.Location = new System.Drawing.Point(105, 12);
            this.tb_receipt_no.Name = "tb_receipt_no";
            this.tb_receipt_no.Size = new System.Drawing.Size(108, 20);
            this.tb_receipt_no.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2016, 3, 15, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Regular Fees Collection :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Class";
            // 
            // comboBox_class
            // 
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Items.AddRange(new object[] {
            "FE",
            "SE",
            "TE",
            "BE"});
            this.comboBox_class.Location = new System.Drawing.Point(350, 139);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(100, 21);
            this.comboBox_class.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Roll No.";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(505, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 20);
            this.textBox3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(588, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 477);
            this.panel1.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 258);
            this.dataGridView1.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(105, 563);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 34);
            this.button3.TabIndex = 20;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(301, 563);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 34);
            this.button4.TabIndex = 21;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.tb_amount_paid);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tb_cheque_dd_no);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.radioButton_transfer);
            this.panel2.Controls.Add(this.radioButton_DD);
            this.panel2.Controls.Add(this.radioButton_cheque);
            this.panel2.Controls.Add(this.radioButton_cash);
            this.panel2.Location = new System.Drawing.Point(64, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 308);
            this.panel2.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(156, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Fees Payment";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(170, 220);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tb_amount_paid
            // 
            this.tb_amount_paid.Location = new System.Drawing.Point(103, 154);
            this.tb_amount_paid.Name = "tb_amount_paid";
            this.tb_amount_paid.Size = new System.Drawing.Size(111, 20);
            this.tb_amount_paid.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Amount Paid";
            // 
            // tb_cheque_dd_no
            // 
            this.tb_cheque_dd_no.Location = new System.Drawing.Point(100, 111);
            this.tb_cheque_dd_no.Name = "tb_cheque_dd_no";
            this.tb_cheque_dd_no.Size = new System.Drawing.Size(114, 20);
            this.tb_cheque_dd_no.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cheque/DD No.";
            // 
            // radioButton_transfer
            // 
            this.radioButton_transfer.AutoSize = true;
            this.radioButton_transfer.Location = new System.Drawing.Point(292, 65);
            this.radioButton_transfer.Name = "radioButton_transfer";
            this.radioButton_transfer.Size = new System.Drawing.Size(64, 17);
            this.radioButton_transfer.TabIndex = 3;
            this.radioButton_transfer.TabStop = true;
            this.radioButton_transfer.Text = "Transfer";
            this.radioButton_transfer.UseVisualStyleBackColor = true;
            // 
            // radioButton_DD
            // 
            this.radioButton_DD.AutoSize = true;
            this.radioButton_DD.Location = new System.Drawing.Point(204, 65);
            this.radioButton_DD.Name = "radioButton_DD";
            this.radioButton_DD.Size = new System.Drawing.Size(41, 17);
            this.radioButton_DD.TabIndex = 2;
            this.radioButton_DD.TabStop = true;
            this.radioButton_DD.Text = "DD";
            this.radioButton_DD.UseVisualStyleBackColor = true;
            // 
            // radioButton_cheque
            // 
            this.radioButton_cheque.AutoSize = true;
            this.radioButton_cheque.Location = new System.Drawing.Point(100, 64);
            this.radioButton_cheque.Name = "radioButton_cheque";
            this.radioButton_cheque.Size = new System.Drawing.Size(61, 17);
            this.radioButton_cheque.TabIndex = 1;
            this.radioButton_cheque.TabStop = true;
            this.radioButton_cheque.Text = "cheque";
            this.radioButton_cheque.UseVisualStyleBackColor = true;
            // 
            // radioButton_cash
            // 
            this.radioButton_cash.AutoSize = true;
            this.radioButton_cash.Location = new System.Drawing.Point(15, 62);
            this.radioButton_cash.Name = "radioButton_cash";
            this.radioButton_cash.Size = new System.Drawing.Size(48, 17);
            this.radioButton_cash.TabIndex = 0;
            this.radioButton_cash.TabStop = true;
            this.radioButton_cash.Text = "cash";
            this.radioButton_cash.UseVisualStyleBackColor = true;
            // 
            // tb_enrollment_no
            // 
            this.tb_enrollment_no.Location = new System.Drawing.Point(113, 139);
            this.tb_enrollment_no.Name = "tb_enrollment_no";
            this.tb_enrollment_no.Size = new System.Drawing.Size(143, 20);
            this.tb_enrollment_no.TabIndex = 7;
            // 
            // tb_last_name
            // 
            this.tb_last_name.Location = new System.Drawing.Point(322, 96);
            this.tb_last_name.Name = "tb_last_name";
            this.tb_last_name.Size = new System.Drawing.Size(100, 20);
            this.tb_last_name.TabIndex = 5;
            // 
            // tb_middle_name
            // 
            this.tb_middle_name.Location = new System.Drawing.Point(191, 96);
            this.tb_middle_name.Name = "tb_middle_name";
            this.tb_middle_name.Size = new System.Drawing.Size(100, 20);
            this.tb_middle_name.TabIndex = 4;
            // 
            // tb_first_name
            // 
            this.tb_first_name.Location = new System.Drawing.Point(64, 96);
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(100, 20);
            this.tb_first_name.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Enrollment No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Middle Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Last Name";
            // 
            // fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_enrollment_no);
            this.Controls.Add(this.tb_last_name);
            this.Controls.Add(this.tb_middle_name);
            this.Controls.Add(this.tb_first_name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_class);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_receipt_no);
            this.Controls.Add(this.label1);
            this.Name = "fees";
            this.Text = "fees";
            this.Load += new System.EventHandler(this.fees_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_receipt_no;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_amount_paid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_cheque_dd_no;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton_transfer;
        private System.Windows.Forms.RadioButton radioButton_DD;
        private System.Windows.Forms.RadioButton radioButton_cheque;
        private System.Windows.Forms.RadioButton radioButton_cash;
        private System.Windows.Forms.TextBox tb_enrollment_no;
        private System.Windows.Forms.TextBox tb_last_name;
        private System.Windows.Forms.TextBox tb_middle_name;
        private System.Windows.Forms.TextBox tb_first_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}