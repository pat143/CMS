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
    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
        }

        private void fees_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=PATRIC;Initial Catalog=CMS;Persist Security Info=True;User ID=sa;Password=pat1234567");
            SqlDataAdapter adapter;
            DataTable table = new DataTable();
            String name = (tb_first_name.Text + " " + tb_middle_name.Text + " " + tb_last_name.Text);
            //String a = "select balance from CMS.dbo.fees where Enrollment_No = '"+ tb_enrollment_no +"'";
            int z = Int32.Parse(tb_amount_paid.Text);
            String pay_mode;
            if (radioButton_cash.Checked)
            {
                pay_mode = "cash";
            }
            else if(radioButton_cheque.Checked)
            {
                pay_mode = "cheque";
            }
            else if(radioButton_DD.Checked)
            {
                pay_mode = "DD";
            }
            else
            {
                pay_mode = "Transfer";
            }
            
            try
            {
                connection.Open();
                String grid = "select * from CMS.dbo."+ comboBox_class.SelectedItem.ToString() +";";
                adapter = new SqlDataAdapter(grid, connection);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Refresh();
                //SqlCommand cmd = new SqlCommand(a, connection);
                //String x = cmd.ToString();
                //int b =  Int32.Parse(x);
                //int balance = 400;
                SqlCommand valsum = new SqlCommand();
                valsum.Connection = connection;
                valsum.CommandText = "select Balance from CMS.dbo.fees where Enrollment_No = '" + tb_enrollment_no.Text + "'";
                int stud_bal = 0;
                SqlDataReader presentstu = valsum.ExecuteReader();
                while (presentstu.Read())
                {
                    stud_bal = (int)presentstu[0];
                }
                int final_bal = z - stud_bal;
                presentstu.Close();
                String bal = "update CMS.dbo.fees set Balance = '"+ final_bal +"' where Enrollment_No = '"+ tb_enrollment_no.Text +"';";
                String s = "update CMS.dbo.fees set paid = '" + tb_amount_paid.Text + "' where Enrollment_No = '" + tb_enrollment_no.Text + "' and Student_Name = '" + name + "';";
                String s1 = "update CMS.dbo.fees set Pay_Mode = '" + pay_mode + "' where Enrollment_No = '" + tb_enrollment_no.Text + "' and Student_Name = '" + name + "';";
                String s2 = "update CMS.dbo.fees set Chq_DD_No = '" + tb_cheque_dd_no.Text + "' where Enrollment_No = '" + tb_enrollment_no.Text + "' and Student_Name = '" + name + "';";
                String s3 = "update CMS.dbo.fees set Receipt_No = '" + tb_receipt_no.Text + "' where Enrollment_No = '" + tb_enrollment_no.Text + "' and Student_Name = '" + name + "';";
                String s4 = "update CMS.dbo.fees set Date = '" + dateTimePicker1.Value.ToString() + "' where Enrollment_No = '" + tb_enrollment_no.Text + "' and Student_Name = '" + name + "';";
                SqlCommand cmd1 = new SqlCommand(s, connection);
                SqlCommand cmd2 = new SqlCommand(s1, connection);
                SqlCommand cmd3 = new SqlCommand(s2, connection);
                SqlCommand cmd4 = new SqlCommand(s3, connection);
                SqlCommand cmd5 = new SqlCommand(s4, connection);
                SqlCommand cmd6 = new SqlCommand(bal, connection);
                
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
