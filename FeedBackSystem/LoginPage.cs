using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(tb_user_name.Text.Equals("abc") && tb_password.Text.Equals("123"))
            {
                
                Form3 form3 = new Form3();
                form3.Show();
                
                
            }
            else if(tb_user_name.Text.Equals("") && tb_password.Text.Equals(""))
            {
                MessageBox.Show("Please Enter user name and password");
            }
            else if(tb_user_name.Text.Equals(""))
            {
                MessageBox.Show("Please Enter user name");

            }
            else if(tb_password.Text.Equals(""))
            {
                MessageBox.Show("Plz Enter password");

            }
            else
            {
                MessageBox.Show("Entered invalid user name or password");
            }
        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void lbl_user_name_Click(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_user_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
