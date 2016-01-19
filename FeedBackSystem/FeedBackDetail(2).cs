using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace FeedBackSystem
{
               
    public partial class FeedBackDetail_2 : Form
    {
               
        public FeedBackDetail_2()
        {
            InitializeComponent();
        }

        private void FeedBackDetail_2_Load(object sender, EventArgs e)
        {
               
        }

        private void tb_college_and_place_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int InsertData(SqlConnection connect,string[] datarrray,int index)
        {
           
            {
                SqlCommand MyCommand = new SqlCommand("INSERT INTO [dbo].[ProfData] (Idno,Name) Values (@Column1, @Column2)", connect);
                MyCommand.Parameters.AddWithValue("@Column1", index+1);
                MyCommand.Parameters.AddWithValue("@Column2", datarrray[index]);
                
               
                return MyCommand.ExecuteNonQuery();

            }
        }

        int CreateTable(SqlConnection connect)
        {

            
            {
                SqlCommand cmd = new SqlCommand("IF OBJECT_ID('dbo.FeedBackMain', 'U') IS NULL BEGIN CREATE TABLE [dbo].[FeedBackMain]([Questions] NVARCHAR(MAX) NOT NULL) END",connect);

                
                return cmd.ExecuteNonQuery();

            }
        }
        int AlterTable(SqlConnection connect,string Name)
        {

             {
                SqlCommand cmd = new SqlCommand("DECLARE @sup nvarchar(MAX); " +"SET @sup = QUOTENAME('" + Name + "'); "+"EXEC ('ALTER TABLE dbo.FeedBackMain  ADD ' + @sup + ' nvarchar(MAX) NOT NULL')",connect);
                    return cmd.ExecuteNonQuery();

            }
        }

        public void bt_fbd2_ok_Click(object sender, EventArgs e)
        {  string[] feedbackdetails={null,null,null,null,null,null,null};
           
            if (tb_t1.Text.ToString() != "" && tb_s1.Text.ToString() != "")
           {
               feedbackdetails[0] = tb_t1.Text.ToString() + "\n" + tb_s1.Text.ToString();
           } 
           
           if (tb_t2.Text.ToString() != "" && tb_s2.Text.ToString() != "")
           {
               feedbackdetails[1] = tb_t2.Text.ToString() + "\n" + tb_s2.Text.ToString();
           }

           if (tb_t3.Text.ToString() != "" && tb_s3.Text.ToString() != "")
           {
               feedbackdetails[2] = tb_t3.Text.ToString() + "\n" + tb_s3.Text.ToString();
           }
           if (tb_t4.Text.ToString() != "" && tb_s4.Text.ToString() != "")
           {
               feedbackdetails[3] = tb_t4.Text.ToString() + "\n" + tb_s4.Text.ToString();
           }
           if (tb_t5.Text.ToString() != "" && tb_s5.Text.ToString() != "")
           {
               feedbackdetails[4] = tb_t5.Text.ToString() + "\n" + tb_s5.Text.ToString();
           }
           if (tb_t6.Text.ToString() != "" && tb_s6.Text.ToString() != "")
           {
               feedbackdetails[5] = tb_t6.Text.ToString() + "\n" + tb_s6.Text.ToString();
           }
           if (tb_t7.Text.ToString() != "" && tb_s7.Text.ToString() != "")
           {
               feedbackdetails[6] = tb_t7.Text.ToString() + "\n" + tb_s7.Text.ToString();
           }

            int i=0;
            string connection = "Data Source=DESKTOP-3CVCKVK;Initial Catalog=Demo;User ID=dilkap;Password=driems";
            SqlConnection myConnection = new SqlConnection(connection);
            myConnection.Open();

            while (i < 7)
            {
                if (feedbackdetails[i] != null)
                {
                    int r = InsertData(myConnection, feedbackdetails, i);
                    i++;
                }
                else
                {
                    i = 0;
                    break;
                }

            }
     
            int j = CreateTable(myConnection);
            while (i < 7)
            {
                if (feedbackdetails[i] != null)
                {
                    int r = AlterTable(myConnection, feedbackdetails[i]);
                    i++;
                }
                else
                {
                    break;
                }


            }

            myConnection.Close();


           

        }






    }
}
