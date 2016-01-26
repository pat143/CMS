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
using CrystalDecisions.CrystalReports;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.ReportAppServer;
using CrystalDecisions.CrystalReports.Engine;
namespace FeedBackSystem
{
    public partial class ServerWait : Form
    {
            
        public ServerWait()
        {
            InitializeComponent();
           
        }
        int FillsData(SqlConnection connect,string ProfName,string Question,string Tablename,string Option)
        {
            int val=0;
            SqlCommand sml=new SqlCommand("Select Questions,"+ProfName+" from [dbo].[FeedBackMain] WHERE Questions='"+Question+"' AND "+ProfName+"='"+Option+"'",connect);
            SqlDataReader sdr = sml.ExecuteReader();
            while(sdr.Read())
            {
                val++;
            }
            sdr.Close();
            return val;

        }
        
        int CreateTable(SqlConnection connect,string name)
        {


            {
                SqlCommand cmd = new SqlCommand("IF OBJECT_ID('dbo."+name+"', 'U') IS NULL BEGIN CREATE TABLE [dbo].[" + name + "]([Questions] NVARCHAR(MAX) NOT NULL,[A] NVARCHAR(MAX) NOT NULL,[B] NVARCHAR(MAX) NOT NULL,[C] NVARCHAR(MAX) NOT NULL,[D] NVARCHAR(MAX) NOT NULL) END", connect);


                return cmd.ExecuteNonQuery();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name= "tablename";
            string[] tablearray = { "", "", "", "", "", "", "" };
            string[] profarray={ "", "", "", "", "", "", "" };
            SqlConnection myConnection = new SqlConnection("Data Source=DESKTOP-3CVCKVK;Initial Catalog=Demo;User ID=dilkap;Password=driems");
            myConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ProfData",myConnection);
           
            SqlDataReader sdr =cmd.ExecuteReader();
            int id = 0;
            while(sdr.Read())
            {
                id = (int)sdr[0];
                tablearray[id-1] = name+id.ToString();
                profarray[id-1]=sdr[1].ToString();
            }
            sdr.Close();
            int i=0;
            for(i=0;i<id;i++)
            {
                if(tablearray[i]!="")
                {
                    int r=CreateTable(myConnection,tablearray[i]);
                }
                else 
                { 
                    break;
                }
            }
             
            myConnection.Close();
            
            SqlConnection con=new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\FeedBackTable.mdf;Integrated Security=True");
            string[] quesarray = new string[10];
            SqlCommand cm = new SqlCommand("SELECT * from FeedBackInit", con);
            con.Open();
            i = 0;
            SqlDataReader sd = cm.ExecuteReader();
            while (sd.Read() && i < 10)
            {
                quesarray[i] = sd[0].ToString();
                i++;
            }
            con.Close();
            i=0;
            int j;
            myConnection.Open();
            int k=0;
            string[] options = { "A", "B", "C", "D" };
            int[] valueresult =new int[4];
            for(i=0;i<id;i++)
            {
                string currentProf = profarray[i];
                string currenttable = tablearray[i];
                for(j=0;j<10;j++)
                {
                    
                    string currentques = quesarray[j];
                    for(k=0;k<4;k++)
                    {
                        string option=options[k];
                        valueresult[k] = FillsData(myConnection, currentProf, currentques, currenttable,option); 
                    }
                    SqlCommand ls = new SqlCommand("Insert Into [dbo].[" + currenttable + "] values('" + currentques + "','" + valueresult[0] + "','" + valueresult[1] + "','" + valueresult[2] + "','" + valueresult[3] + "')", myConnection);
                    ls.ExecuteNonQuery();
                }

            }
           




                myConnection.Close();
            





        }



        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           

        }

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {
          
        }

        private void ServerWait_Load(object sender, EventArgs e)
        {

        }
    }
}
