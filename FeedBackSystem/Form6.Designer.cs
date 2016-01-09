namespace FeedBackSystem
{
    partial class Form6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.questionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedBackInitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedBackTableDataSet1 = new FeedBackSystem.FeedBackTableDataSet1();
            this.feedBackTableDataSet = new FeedBackSystem.FeedBackTableDataSet();
            this.feedBackTableDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedBackInitTableAdapter = new FeedBackSystem.FeedBackTableDataSet1TableAdapters.FeedBackInitTableAdapter();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackInitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackTableDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackTableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackTableDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.feedBackInitBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1302, 515);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // questionsDataGridViewTextBoxColumn
            // 
            this.questionsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.questionsDataGridViewTextBoxColumn.DataPropertyName = "Questions";
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.questionsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.questionsDataGridViewTextBoxColumn.HeaderText = "Questions";
            this.questionsDataGridViewTextBoxColumn.Name = "questionsDataGridViewTextBoxColumn";
            this.questionsDataGridViewTextBoxColumn.Width = 79;
            // 
            // feedBackInitBindingSource
            // 
            this.feedBackInitBindingSource.DataMember = "FeedBackInit";
            this.feedBackInitBindingSource.DataSource = this.feedBackTableDataSet1;
            // 
            // feedBackTableDataSet1
            // 
            this.feedBackTableDataSet1.DataSetName = "FeedBackTableDataSet1";
            this.feedBackTableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedBackTableDataSet
            // 
            this.feedBackTableDataSet.DataSetName = "FeedBackTableDataSet";
            this.feedBackTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedBackTableDataSetBindingSource
            // 
            this.feedBackTableDataSetBindingSource.DataSource = this.feedBackTableDataSet;
            this.feedBackTableDataSetBindingSource.Position = 0;
            // 
            // feedBackInitTableAdapter
            // 
            this.feedBackInitTableAdapter.ClearBeforeFill = true;
            // 
            // bt_confirm
            // 
            this.bt_confirm.Location = new System.Drawing.Point(296, 3);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(75, 44);
            this.bt_confirm.TabIndex = 1;
            this.bt_confirm.Text = "OK";
            this.bt_confirm.UseVisualStyleBackColor = true;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(233, -138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 50);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bt_confirm);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1302, 579);
            this.splitContainer1.SplitterDistance = 515;
            this.splitContainer1.TabIndex = 3;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1302, 579);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackInitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackTableDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackTableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackTableDataSetBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource feedBackTableDataSetBindingSource;
        private FeedBackTableDataSet feedBackTableDataSet;
        private FeedBackTableDataSet1 feedBackTableDataSet1;
        private System.Windows.Forms.BindingSource feedBackInitBindingSource;
        private FeedBackTableDataSet1TableAdapters.FeedBackInitTableAdapter feedBackInitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;

    }
}