namespace FeedBackSystem
{
    partial class Form2
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
            this.tb_user_name = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // tb_user_name
            // 
            this.tb_user_name.Location = new System.Drawing.Point(132, 58);
            this.tb_user_name.Name = "tb_user_name";
            this.tb_user_name.Size = new System.Drawing.Size(135, 20);
            this.tb_user_name.TabIndex = 0;
            this.tb_user_name.TextChanged += new System.EventHandler(this.tb_user_name_TextChanged);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(132, 84);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(135, 20);
            this.tb_password.TabIndex = 1;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Location = new System.Drawing.Point(67, 61);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(60, 13);
            this.lbl_user_name.TabIndex = 2;
            this.lbl_user_name.Text = "User Name";
            this.lbl_user_name.Click += new System.EventHandler(this.lbl_user_name_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(160, 122);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Sumbit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(67, 91);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Password";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 248);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_user_name);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_user_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user_name;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_user_name;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_password;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}