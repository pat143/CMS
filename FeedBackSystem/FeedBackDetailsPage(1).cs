using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SqlConnection s = new SqlConnection("Data Source=DESKTOP-3CVCKVK;Initial Catalog=Demo;User ID=dilkap;Password=driems");
            s.Open();
            SqlCommand cd = new SqlCommand();
            cd.Connection = s;
            cd.CommandText = "delete from [dbo].Table1";
            cd.ExecuteNonQuery();
            cd.CommandText = "delete from [dbo].Table2";
            cd.ExecuteNonQuery();
            cd.CommandText = "delete from [dbo].Table3";
            cd.ExecuteNonQuery();
            cd.CommandText = "delete from [dbo].Table4";
            cd.ExecuteNonQuery();
            cd.CommandText = "delete from [dbo].Table5";
            cd.ExecuteNonQuery();
            cd.CommandText = "delete from [dbo].Table6";
            cd.ExecuteNonQuery();
            cd.CommandText = "delete from [dbo].Table7";
            cd.ExecuteNonQuery();
            cd.CommandText = "delete from [dbo].ProfData";
            cd.ExecuteNonQuery();
            cd.CommandText = "delete from [dbo].FeedBackMain";
            cd.ExecuteNonQuery();
            cd.CommandText = "delete from [dbo].Data1";
            cd.ExecuteNonQuery();

            s.Close();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            SqlConnection s = new SqlConnection("Data Source=DESKTOP-3CVCKVK;Initial Catalog=Demo;User ID=dilkap;Password=driems");
            s.Open();
            SqlCommand c = new SqlCommand();
            string colname = tb_college_and_place.Text;
            string classname = cb_class.SelectedItem.ToString();
            string branchname = tb_branch.Text;
            string divname = cb_div.SelectedItem.ToString();
            string batchname = cb_batch.SelectedItem.ToString();
            string stupre = tb_stud_present.Text;
            string stuno = tb_total_studs.Text;
            c.Connection = s;
            c.CommandText = "Insert into [dbo].[Data1] values('"+colname+"','"+classname+"','"+branchname+"','"+divname+"','"+batchname+"','"+stupre+"','"+stuno+"')";
            c.ExecuteNonQuery();
            s.Close();






            FeedBackDetail_2 fbd2 = new FeedBackDetail_2();
            fbd2.Show();
            this.Close();


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
