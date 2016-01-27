﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.ReportAppServer;

namespace FeedBackSystem
{
    public partial class Result : Form
    {
        string connection = "Data Source=DESKTOP-3CVCKVK;Initial Catalog=Demo;User ID=dilkap;Password=driems";
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=F:\\Programs\\Feedbacks\\FeedBackSystem\\FeedBackSystem\\FeedBackTable.mdf;Integrated Security=True");
           
        public Result()
        {
            InitializeComponent();
            SqlConnection myConnection = new SqlConnection(connection);
            
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM ProfData", myConnection);
            myConnection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                comboBox1.Items.Add(sdr["Name"]);

            }
            myConnection.Close();   


            //sorting code
            string[] a=new string[10];
            SqlCommand cm = new SqlCommand("SELECT * from FeedBackInit", con);
            con.Open();
            int i=0;
            SqlDataReader sd = cm.ExecuteReader();
            while(sd.Read() && i<10)
            {
                a[i] = sd[0].ToString();
                i++;
            }

            //




            CrystalReport11.SetDatabaseLogon("dilkap","driems","DESKTOP-3CVCKVK","Demo");
           


                if (CrystalReport11.Subreports["sr_Table2"].HasRecords == false)
                {
                    
                    CrystalReport11.DetailSection7.SectionFormat.EnableSuppress = true;
                    
                }
                if (CrystalReport11.Subreports["sr_Table3"].HasRecords == false)
                {

                    CrystalReport11.DetailSection8.SectionFormat.EnableSuppress = true;

                }
                if (CrystalReport11.Subreports["sr_Table4"].HasRecords == false)
                {

                    CrystalReport11.DetailSection9.SectionFormat.EnableSuppress = true;

                }
                if (CrystalReport11.Subreports["sr_Table5"].HasRecords == false)
                {

                    CrystalReport11.DetailSection10.SectionFormat.EnableSuppress = true;

                }
                if (CrystalReport11.Subreports["sr_Table6"].HasRecords == false)
                {

                    CrystalReport11.DetailSection11.SectionFormat.EnableSuppress = true;

                }
                if (CrystalReport11.Subreports["sr_Table7"].HasRecords == false)
                {

                    CrystalReport11.DetailSection12.SectionFormat.EnableSuppress = true;

                }
               
    
            

                

            
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sel = comboBox1.SelectedItem.ToString();
            
            SqlConnection myConnection = new SqlConnection(connection);
            
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT Questions,"+sel+" FROM FeedBackMain where Questions!='Remarks'", myConnection);
            myConnection.Open();
            SqlDataReader sdr=cmd.ExecuteReader();
            dataGridView1.Columns[1].HeaderText = sel;
            while(sdr.Read())
            {
                dataGridView1.Rows.Add(sdr[0], sdr[1]);
            }
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
            
        }

        private void Result_Load(object sender, EventArgs e)
        {
            con.Close();
           
        }

        private void CrystalReport11_InitReport(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void CrystalReport11_InitReport_1(object sender, EventArgs e)
        {

        }

        



    }
}
