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
    public partial class student_search : Form
    {
        public student_search()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=PATRIC;Initial Catalog=CMS;Persist Security Info=True;User ID=sa;Password=pat1234567");
            SqlDataAdapter adapter;
            DataTable table = new DataTable();
            try
            {
                //String q = "select * from CMS.dbo.student_personal where CMS.dbo.student_personal.Enrollment_No = '" + tb_enrollment_no.Text + "'";
                String name = (tb_firstname.Text + " " + tb_middlename.Text + " " + tb_lastname.Text);
                String s = "select tbl1.*,  tbl2.Register_No, tbl2.University_ID, tbl2.Date_of_Admission, tbl2.Education_Year, tbl2.Nationality, tbl2.Religion, tbl2.Caste, tbl2.Category, tbl2.Handicap, tbl2.Admission_Class, tbl2.Division, tbl2.Specialization, tbl2.Form_No, tbl2.New_Admission, tbl2.Hosteler, tbl2.Minority_Student from CMS.dbo.student_personal tbl1 inner join CMS.dbo.student_college_info tbl2 on tbl1.Enrollment_No = tbl2.Enrollment_No where (tbl1.Enrollment_No = '"+ tb_enrollment_no.Text + "' or tbl1.Student_Name = '"+ name + "')";
                adapter = new SqlDataAdapter(s, connection);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Refresh();
                connection.Open();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }
    }
}
