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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.ReportAppServer;
namespace FeedBackSystem
{
    public partial class Remarks : Form
    {
        int id=0;
        TextBox[] tx = new TextBox[7]; 
        public Remarks()
        {
            InitializeComponent();
            string connection = "Data Source=DESKTOP-3CVCKVK;Initial Catalog=Demo;User ID=dilkap;Password=driems";
            SqlConnection myConnection = new SqlConnection(connection);
          
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM ProfData", myConnection);
            myConnection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            int i = 0;
            
            string[] a = { null, null, null, null, null, null, null };
            Label[] lb = { label2, label3, label4, label5, label6, label7, label8 };
            tx[0] = textBox1;
            tx[1] = textBox2;
            tx[2] = textBox3;
            tx[3] = textBox4;
            tx[4] = textBox5;
            tx[5] = textBox6;
            tx[6] = textBox7;

            
            while (sdr.Read())
            {
                id = (int)sdr[0];
                a[id-1] = sdr["Name"].ToString();

            }

            for (i = 0; i < 7; i++)
            {
                if (a[i] != null)
                {
                    lb[i].Text = a[i];
                    lb[i].Visible = true;


                }
                else
                {
                    lb[i].Visible = false;
                    tx[i].Visible = false;
                }
            }

            myConnection.Close();

   
        }

        private void Remarks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] tbdata = {"", "", "", "", "", "", "" };
  
 
            string connection = "Data Source=DESKTOP-3CVCKVK;Initial Catalog=Demo;User ID=dilkap;Password=driems";
            SqlConnection myConnection = new SqlConnection(connection);

            
            myConnection.Open();
            int j = 0;
            for (j = 0; j < id; j++)
            {
                if (j != id - 1)
                {
                    tbdata[j] = "'" + tx[j].Text.ToString() + "'" + ",";
                }
                else
                {
                    tbdata[j] = "'" + tx[j].Text.ToString() + "'";
                }

            }

          


            SqlCommand cmd = new SqlCommand("Insert into dbo.FeedBackMain values('Remarks'," + tbdata[0] + tbdata[1] + tbdata[2] + tbdata[3] + tbdata[4] + tbdata[5] + tbdata[6] + ");", myConnection);
            cmd.ExecuteNonQuery();



            
            myConnection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            
        }
            
        }
    }

