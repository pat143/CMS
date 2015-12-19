namespace FeedBackSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_options = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_start_server = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_view_reports = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_user_accounts = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_instruction2 = new System.Windows.Forms.Label();
            this.lbl_instruction1 = new System.Windows.Forms.Label();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_options});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(911, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_options
            // 
            this.btn_options.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_start_server,
            this.btn_view_reports,
            this.btn_user_accounts,
            this.btn_exit});
            this.btn_options.Image = ((System.Drawing.Image)(resources.GetObject("btn_options.Image")));
            this.btn_options.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(62, 22);
            this.btn_options.Text = "Options";
            // 
            // btn_start_server
            // 
            this.btn_start_server.Name = "btn_start_server";
            this.btn_start_server.Size = new System.Drawing.Size(152, 22);
            this.btn_start_server.Text = "Start Server";
            this.btn_start_server.Click += new System.EventHandler(this.btn_start_server_Click);
            // 
            // btn_view_reports
            // 
            this.btn_view_reports.Name = "btn_view_reports";
            this.btn_view_reports.Size = new System.Drawing.Size(152, 22);
            this.btn_view_reports.Text = "View Reports";
            // 
            // btn_user_accounts
            // 
            this.btn_user_accounts.Name = "btn_user_accounts";
            this.btn_user_accounts.Size = new System.Drawing.Size(152, 22);
            this.btn_user_accounts.Text = "User Accounts";
            // 
            // btn_exit
            // 
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(152, 22);
            this.btn_exit.Text = "Exit";
            // 
            // lbl_instruction2
            // 
            this.lbl_instruction2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_instruction2.AutoSize = true;
            this.lbl_instruction2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instruction2.Location = new System.Drawing.Point(259, 130);
            this.lbl_instruction2.Name = "lbl_instruction2";
            this.lbl_instruction2.Size = new System.Drawing.Size(351, 126);
            this.lbl_instruction2.TabIndex = 1;
            this.lbl_instruction2.Text = resources.GetString("lbl_instruction2.Text");
            // 
            // lbl_instruction1
            // 
            this.lbl_instruction1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_instruction1.AutoSize = true;
            this.lbl_instruction1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instruction1.Location = new System.Drawing.Point(370, 77);
            this.lbl_instruction1.Name = "lbl_instruction1";
            this.lbl_instruction1.Size = new System.Drawing.Size(114, 24);
            this.lbl_instruction1.TabIndex = 2;
            this.lbl_instruction1.Text = "Instructions";
            this.lbl_instruction1.Click += new System.EventHandler(this.lbl_instruction1_Click);
            // 
            // btn_proceed
            // 
            this.btn_proceed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_proceed.Location = new System.Drawing.Point(392, 259);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_proceed.TabIndex = 3;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_proceed;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 377);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.lbl_instruction1);
            this.Controls.Add(this.lbl_instruction2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btn_options;
        private System.Windows.Forms.ToolStripMenuItem btn_start_server;
        private System.Windows.Forms.ToolStripMenuItem btn_view_reports;
        private System.Windows.Forms.ToolStripMenuItem btn_user_accounts;
        private System.Windows.Forms.ToolStripMenuItem btn_exit;
        private System.Windows.Forms.Label lbl_instruction2;
        private System.Windows.Forms.Label lbl_instruction1;
        private System.Windows.Forms.Button btn_proceed;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;



    }
}

