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
    public partial class promote_student : Form
    {
        SqlConnection connection;
        public promote_student()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter;
        DataTable table;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cMSDataSet1.student_college_info' table. You can move, or remove it, as needed.
            this.student_college_infoTableAdapter.Fill(this.cMSDataSet1.student_college_info);
            

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
                try
                {
                    String Datasource = "Data Source=PATRIC;Initial Catalog=CMS;Persist Security Info=True;User ID=sa;Password=pat1234567";
                    connection = new SqlConnection(Datasource);
                    String s = "select Enrollment_No, Student_Name, Register_No from CMS.dbo.student_college_info where Specialization = '" + comboBox_specialization.SelectedItem.ToString() + "' and Admission_Class = '" + comboBox_class.SelectedItem.ToString() + "' and Division = '" + comboBox_division.SelectedItem.ToString() + "' and Education_Year = '" + tbm_education_yr.Text + "'";
                    adapter = new SqlDataAdapter(s, connection);
                    table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.Rows.Clear();
                    foreach (DataRow row in table.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = false;
                        dataGridView1.Rows[n].Cells[1].Value = row["Enrollment_No"].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = row["Student_Name"].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = row["Register_No"].ToString();

                    }
                    //SqlCommand cmd = new SqlCommand(s, connection);
                    //dataGridView1.DataSource = table;
                    connection.Open();
                    //cmd.ExecuteNonQuery();
                    //dataGridView1.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter correct values");
                }
                finally
                {
                    connection.Close();
                }
            
        }
        
        private void btn_promote_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((bool)row.Cells[0].Value == true)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = row.Cells[1].Value.ToString();
                    dataGridView2.Rows[n].Cells[1].Value = row.Cells[2].Value.ToString();
                    dataGridView2.Rows[n].Cells[2].Value = row.Cells[3].Value.ToString();
                }
            }

           /* for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (dataGridView1.Rows[i].Cells[0].Value != null &&
                     (bool)dataGridView1.Rows[i].Cells[0].Value == true)
                {
                  
                    for (int j = 1; j < dataGridView1.Columns.Count; j++)
                        dataGridView2.Rows[i].Cells[j].Value = dataGridView1.Rows[i].Cells[j].Value;
                    dataGridView2.Rows.Add();
                }

            }  
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
             
                int c = column.Index;
                for (; column.Index<dataGridView1.Columns.Count;column.Index++)
                string name = column.HeaderText;
                string amount = column.Cells[enrollmentNoDataGridViewTextBoxColumn.HeaderText].Value.ToString();
                dataGridView2.Rows.Add(name, amount);
                dataGridView2.Refresh();
                for (int i=0;i<dataGridView1.Columns.Count;i++)
                {
                    dataGridView2.Columns.Add(column);
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[checker.Name].Value) == true)
                {
                    dataGridView2.Rows.Add(row);
                }
            }
            if (!datagridview1)
            {
                datagridview1 = true;
                dataGridView1.EndEdit();
                dataGridView2.DataSource = dataGridView1;

            }
            else
            {
                datagridview1 = false;
            }*/
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)dataGridView1.SelectedRows[0].Cells[0].Value == false)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                String Datasource = "Data Source=PATRIC;Initial Catalog=CMS;Persist Security Info=True;User ID=sa;Password=pat1234567";
                connection = new SqlConnection(Datasource);
                connection.Open();
                int n = dataGridView2.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    String save = " update CMS.dbo.student_college_info set Admission_Class='"+comboBox_class_new.SelectedItem.ToString()+"', specialization = '"+comboBox_specialization_new.SelectedItem.ToString()+"', division = '"+comboBox_division_new.SelectedItem.ToString()+"', education_year = '"+tbm_education_year_new.Text+"' where Enrollment_No = '" + dataGridView2.Rows[i].Cells[0].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(save, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter correct values");
            }
            finally
            {
                connection.Close();
            }
                
         }
    }
}