using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMS
{
    public partial class fee_structure : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable table;
        DataSet ds;
        SqlCommandBuilder cb;
        public fee_structure()
        {
            InitializeComponent();
        }

        private void btn_show_fee_chart_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=PATRIC;Initial Catalog=CMS;Persist Security Info=True;User ID=sa;Password=pat1234567");
            table = new DataTable();
            try
            {
                String s = "select * from CMS.dbo." + comboBox_class.SelectedItem.ToString() + " union all	select NULL, NULL, sum(Amount) from CMS.dbo." + comboBox_class.SelectedItem.ToString() + ";";
                adapter = new SqlDataAdapter(s, connection);
                //ds = new System.Data.DataSet();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Refresh();
                connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void fee_structure_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_c__demoDataSet.tbl_login' table. You can move, or remove it, as needed.
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                cb = new SqlCommandBuilder(adapter);
                adapter.Update(table);
                MessageBox.Show("Info Updated", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
