using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class Form6 : Form
    {
        public Form6(string[] details)
        {
            InitializeComponent();

           for(int i=0;i<7;i++)
            {
                if (details[i] !=null)
                {
                    
                    DataGridViewColumn col = new DataGridViewComboBoxColumn();

                    col.HeaderText = details[i];
                    DataGridViewComboBoxCell CBCell = new DataGridViewComboBoxCell();
                    string[] x = { "A", "B", "C", "D" };
                    CBCell.DataSource = x;
                    col.CellTemplate = CBCell;

                    int colIndex = dataGridView1.Columns.Add(col);
                   
                    
                }
              
            }
           dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
            feedBackInitBindingSource.AllowNew = false;
              
        } 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'feedBackTableDataSet1.FeedBackInit' table. You can move, or remove it, as needed.
            this.feedBackInitTableAdapter.Fill(this.feedBackTableDataSet1.FeedBackInit);

        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
