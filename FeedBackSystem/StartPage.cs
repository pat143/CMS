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

namespace FeedBackSystem
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
            


        }

        private void lbl_instruction1_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_server_Click(object sender, EventArgs e)
        {
           
            LoginPage form2 = new LoginPage();
            form2.ShowDialog();
            this.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            Form6 fs = new Form6();
            fs.Show();
            this.Visible = false;
        }

       
    }
}
