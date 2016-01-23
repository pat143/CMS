using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class Result : Form
    {
        string connection = "Data Source=DESKTOP-3CVCKVK;Initial Catalog=Demo;User ID=dilkap;Password=driems";
        
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
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\FeedBackTable.mdf;Integrated Security=True");
            SqlCommand cm = new SqlCommand("SELECT * from FeedBackInit", con);
            con.Open();
            int i=0;
            SqlDataReader sd = cm.ExecuteReader();
            while(sd.Read() && i<10)
            {
                a[i] = sd[0].ToString();
                i++;
            }
            con.Close();
            
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



    }
}
