using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            string connection = "Data Source=DESKTOP-3CVCKVK;Initial Catalog=Demo;User ID=dilkap;Password=driems";
            SqlConnection myConnection = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SELECT * FROM ProfData",myConnection);
            myConnection.Open();
            SqlDataReader sdr=cmd.ExecuteReader();

            while (sdr.Read())
            {




                DataGridViewColumn col = new DataGridViewComboBoxColumn();

                col.HeaderText = sdr["Name"].ToString();
                DataGridViewComboBoxCell CBCell = new DataGridViewComboBoxCell();
                string[] x = { "A", "B", "C", "D" };
                CBCell.DataSource = x;
                col.CellTemplate = CBCell;

                int colIndex = dataGridView1.Columns.Add(col);

            }        
                
              
            
            myConnection.Close();
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
            string connection = "Data Source=DESKTOP-3CVCKVK;Initial Catalog=Demo;User ID=dilkap;Password=driems";
            SqlConnection myConnection = new SqlConnection(connection);
          
            
            myConnection.Open();
           int jmax = dataGridView1.ColumnCount;
            int i = 0;
            int j = 0;
            for(i=0;i<10;i++)
            {
                string[] a = { "", "", "", "", "", "", "", "" };
                for(j=0;j<jmax;j++)
                {
                    if (j != jmax-1)
                    {
                        a[j] = "'" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "'" + ",";
                    }
                    else
                    {
                        a[j]="'" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "'";
                    }
                   
                }
                SqlCommand cmd = new SqlCommand("Insert into dbo.FeedBackMain values(" + a[0] + a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7] + ");", myConnection);
                cmd.ExecuteNonQuery();



            }
            myConnection.Close();
 



        }
    }
}
