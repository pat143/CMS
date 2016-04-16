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
    public partial class student_add : Form
    {
        SqlConnection connection;
        //SqlConnectionStringBuilder sb;
        public student_add()
        {
            InitializeComponent();
            //ConnectTo();
        }

       /*void ConnectTo()
        {
            //Data Source=PATRIC;Initial Catalog=CMS;Persist Security Info=True;User ID=sa;Password=pat1234567
            sb = new SqlConnectionStringBuilder();
            sb.DataSource = "PATRIC";
            sb.InitialCatalog = "CMS";
            sb.PersistSecurityInfo = true;
            sb.IntegratedSecurity = true;
            connection = new SqlConnection(sb.ToString());
        }*/
        void btn_save_data(String name, String gender)
        {
            
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            String name = (tb_firstname.Text + " " + tb_middlename.Text + " " + tb_lastname.Text);
            String gender, cb_new_admission, cb_hosteler, cb_minority;

            if (checkBox_new_admission.CheckState == CheckState.Checked)
                cb_new_admission = "Yes";
            else
                cb_new_admission = "N/A";

            if (checkBox_hosteler.CheckState == CheckState.Checked)
                cb_hosteler = "Yes";
            else
                cb_hosteler = "N/A";

            if (checkBox_minority_student.CheckState == CheckState.Checked)
                cb_minority = "Yes";
            else
                cb_minority = "N/A";

            if (rb_male.Checked)
            {
                gender = "Male";
            }
            else if (rb_female.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Others";
            }
            /*try
            {
                String datasource = "Data Source=PATRIC;Initial Catalog=CMS;Persist Security Info=True;User ID=sa;Password=pat1234567";
                connection = new SqlConnection(datasource);

                String save = "insert into CMS.dbo.student_record(Register_No,Enrollment_No,University_ID,Student_Name,Mother_Name,Gender,Date_of_Birth,Place_of_Birth,Permanent_Address,Local_Address,Date_of_Admission,Education_Year,Mobile_No,Phone_No,Email_ID,Blood_Group,Mother_Tongue,Nationality,Religion,Caste,Category,Handicap,ADHAR_No,Admission_Class,Division,Specialization,Form_No,New_Admission,Hosteler,Minority_Student) values('" + tb_register_no.Text + "','" + tb_enrollment_no.Text + "','" + tb_university_id.Text + "','" + name + "','" + tb_mothername.Text + "','" + gender + "','" + date_dob.Value.ToString() + "','" + tb_placeofbirth.Text + "','" + tb_permanent_address.Text + "','" + tb_local_address.Text + "','" + date_doa.Value.ToString() + "','" + tbm_education_yr.Text + "','" + tb_mobile.Text + "','" + tb_phone.Text + "','" + tb_email.Text + "','" + comboBox_blood.SelectedItem.ToString() + "','" + tb_mother_tongue.Text + "','" + tb_nationality.Text + "','" + tb_religion.Text + "','" + tb_caste.Text + "','" + tb_category.Text + "','" + tb_handicap_description.Text + "','" + tb_adhar.Text + "','" + comboBox_admit_class.SelectedItem.ToString() + "','" + comboBox_division.SelectedItem.ToString() + "','" + comboBox_specialization.SelectedItem.ToString() + "','" + tb_form_no.Text + "','" + cb_new_admission + "','" + cb_hosteler + "','" + cb_minority + "')";
                SqlCommand cmd = new SqlCommand(save, connection);
                //
                //
                /*cmd.Parameters.AddWithValue("@Student_Name", name);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@New_Admission", cb_new_admission);
                cmd.Parameters.AddWithValue("@Hosteler", cb_hosteler);
                cmd.Parameters.AddWithValue("@Minority_Student", cb_minority);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                MessageBox.Show("in");
            }
            finally
            {
                connection.Close();
            }*/
            if (comboBox_division.SelectedItem == null || comboBox_admit_class.SelectedItem == null || comboBox_specialization.SelectedItem == null || comboBox_handicap.SelectedItem == null || comboBox_blood.SelectedItem == null || tb_form_no.Text == "" || tb_adhar.Text == "" || tb_category.Text == "" || tb_caste.Text == "" || tb_religion.Text == "" || tb_nationality.Text == "" || tb_mother_tongue.Text == "" || tb_email.Text == "" || tb_phone.Text == "" || tb_mobile.Text == "" || tb_local_address.Text == "" || tb_permanent_address.Text == "" || tb_placeofbirth.Text == "" || tb_register_no.Text == "" || tb_enrollment_no.Text == "" || tb_university_id.Text == "" || tb_firstname.Text == "" || tb_middlename.Text == "" || tb_lastname.Text == "" || tb_mothername.Text == "")
            {
                if (tb_register_no.Text == "")
                {
                    errorProvider1.SetError(tb_register_no, "Enter correct values");
                }
                else
                {
                    errorProvider1.Clear();
                }

                if (tb_enrollment_no.Text == "")
                {
                    errorProvider2.SetError(tb_enrollment_no, "Enter correct values");
                }
                else
                {
                    errorProvider2.Clear();
                }

                if (tb_university_id.Text == "")
                {
                    errorProvider3.SetError(tb_university_id, "Enter correct values");
                }
                else
                {
                    errorProvider3.Clear();
                }

                if (tb_firstname.Text == "")
                {
                    errorProvider4.SetError(tb_firstname, "Enter correct values");
                }
                else
                {
                    errorProvider4.Clear();
                }

                if (tb_middlename.Text == "")
                {
                    errorProvider5.SetError(tb_middlename, "Enter correct values");
                }
                else
                {
                    errorProvider5.Clear();
                }

                if (tb_lastname.Text == "")
                {
                    errorProvider6.SetError(tb_lastname, "Enter correct values");
                }
                else
                {
                    errorProvider6.Clear();
                }

                if (tb_mothername.Text == "")
                {
                    errorProvider7.SetError(tb_mothername, "Enter correct values");
                }
                else
                {
                    errorProvider7.Clear();
                }

                if (tb_placeofbirth.Text == "")
                {
                    errorProvider8.SetError(tb_placeofbirth, "Enter correct values");
                }
                else
                {
                    errorProvider8.Clear();
                }

                if (tb_permanent_address.Text == "")
                {
                    errorProvider9.SetError(tb_permanent_address, "Enter correct values");
                }
                else
                {
                    errorProvider9.Clear();
                }

                if (tb_local_address.Text == "")
                {
                    errorProvider10.SetError(tb_local_address, "Enter correct values");
                }
                else
                {
                    errorProvider10.Clear();
                }

                if (tb_mobile.Text == "")
                {
                    errorProvider11.SetError(tb_mobile, "Enter correct values");
                }
                else
                {
                    errorProvider11.Clear();
                }

                if (tb_phone.Text == "")
                {
                    errorProvider12.SetError(tb_phone, "Enter correct values");
                }
                else
                {
                    errorProvider12.Clear();
                }

                if (tb_email.Text == "")
                {
                    errorProvider13.SetError(tb_email, "Enter correct values");
                }
                else
                {
                    errorProvider13.Clear();
                }

                if (tb_mother_tongue.Text == "")
                {
                    errorProvider14.SetError(tb_mother_tongue, "Enter correct values");
                }
                else
                {
                    errorProvider14.Clear();
                }

                if (tb_nationality.Text == "")
                {
                    errorProvider15.SetError(tb_nationality, "Enter correct values");
                }
                else
                {
                    errorProvider15.Clear();
                }

                if (tb_religion.Text == "")
                {
                    errorProvider16.SetError(tb_religion, "Enter correct values");
                }
                else
                {
                    errorProvider16.Clear();
                }

                if (tb_caste.Text == "")
                {
                    errorProvider17.SetError(tb_caste, "Enter correct values");
                }
                else
                {
                    errorProvider17.Clear();
                }

                if (tb_category.Text == "")
                {
                    errorProvider18.SetError(tb_category, "Enter correct values");
                }
                else
                {
                    errorProvider18.Clear();
                }

                if (tb_adhar.Text == "")
                {
                    errorProvider19.SetError(tb_adhar, "Enter correct values");
                }
                else
                {
                    errorProvider19.Clear();
                }

                if (tb_form_no.Text == "")
                {
                    errorProvider20.SetError(tb_form_no, "Enter correct values");
                }
                else
                {
                    errorProvider20.Clear();
                }

                if (comboBox_blood.SelectedItem == null)
                {
                    errorProvider21.SetError(comboBox_blood, "Enter correct values");
                }
                else
                {
                    errorProvider21.Clear();
                }

                if (comboBox_handicap.SelectedItem == null)
                {
                    errorProvider22.SetError(comboBox_handicap, "Enter correct values");
                }
                else
                {
                    errorProvider22.Clear();
                }

                if (comboBox_specialization.SelectedItem == null)
                {
                    errorProvider23.SetError(comboBox_specialization, "Enter correct values");
                }
                else
                {
                    errorProvider23.Clear();
                }

                if (comboBox_admit_class.SelectedItem == null)
                {
                    errorProvider24.SetError(comboBox_admit_class, "Enter correct values");
                }
                else
                {
                    errorProvider24.Clear();
                }

                if (comboBox_division.SelectedItem == null)
                {
                    errorProvider25.SetError(comboBox_division, "Enter correct values");
                }
                else
                {
                    errorProvider25.Clear();
                }
            }
            else
            {
                try
                {
                    String datasource = "Data Source=PATRIC;Initial Catalog=CMS;Persist Security Info=True;User ID=sa;Password=pat1234567";
                    connection = new SqlConnection(datasource);
                    connection.Open();
                    SqlCommand valsum = new SqlCommand();
                    valsum.Connection = connection;
                    valsum.CommandText = "select sum(Amount) from CMS.dbo."+ comboBox_admit_class.SelectedItem.ToString() +";";
                    int stud_bal = 0;
                    SqlDataReader presentstu = valsum.ExecuteReader();
                    while (presentstu.Read())
                    {
                        stud_bal = (int)presentstu[0];
                    }
                    presentstu.Close();
                    String stud_college_info = "insert into CMS.dbo.student_college_info(Enrollment_No,Student_Name,Register_No,University_ID,Date_of_Admission,Education_Year,Nationality,Religion,Caste,Category,Handicap,Admission_Class,Division,Specialization,Form_No,New_Admission,Hosteler,Minority_Student) values('" + tb_enrollment_no.Text + "','" + name + "','" + tb_register_no.Text + "','" + tb_university_id.Text + "','" + date_doa.Value.ToString() + "','" + tbm_education_yr.Text + "','" + tb_nationality.Text + "','" + tb_religion.Text + "','" + tb_caste.Text + "','" + tb_category.Text + "','" + tb_handicap_description.Text + "','" + comboBox_admit_class.SelectedItem.ToString() + "','" + comboBox_division.SelectedItem.ToString() + "','" + comboBox_specialization.SelectedItem.ToString() + "','" + tb_form_no.Text + "','" + cb_new_admission + "','" + cb_hosteler + "','" + cb_minority + "')";
                    String stud_personal = "insert into CMS.dbo.student_personal(Enrollment_No,Student_Name,Mother_Name,Mother_Tongue,Gender,Blood_Group,Date_of_Birth,Place_of_Birth,Permanent_Address,Local_Address,ADHAR_No,Mobile_No,Phone_No,Email_ID) values('" + tb_enrollment_no.Text + "','" + name + "','" + tb_mothername.Text + "','" + tb_mother_tongue.Text + "','" + gender + "','" + comboBox_blood.SelectedItem.ToString() + "','" + date_dob.Value.ToString() + "','" + tb_placeofbirth.Text + "','" + tb_permanent_address.Text + "','" + tb_local_address.Text + "','" + tb_adhar.Text + "','" + tb_mobile.Text + "','" + tb_phone.Text + "','" + tb_email.Text + "')";
                    String stud_fees = "insert into CMS.dbo.fees(Enrollment_No,Student_Name,Class,Balance) values('"+ tb_enrollment_no.Text +"','"+ name +"','"+ comboBox_admit_class.SelectedItem.ToString() +"',"+ stud_bal +")";
                    SqlCommand cmd = new SqlCommand(stud_personal, connection);
                    SqlCommand cmd1 = new SqlCommand(stud_college_info, connection);
                    SqlCommand cmd2 = new SqlCommand(stud_fees, connection);              
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
               }
                catch(Exception)
                {
                
                    //throw;
                    MessageBox.Show("duplicate entry");
                }
            
            finally
                {
                    connection.Close();
                }
            }
        }

        private void checkBox_same_address_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_same_address.CheckState == CheckState.Checked)
            {
                tb_local_address.Text = tb_permanent_address.Text;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
       
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void student_create_Load(object sender, EventArgs e)
        {

        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox_handicap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_handicap.SelectedItem.ToString() == "Y")
            {
                tb_handicap_description.Visible = true;
            }
            else
            {
                tb_handicap_description.Visible = false;
            }
        }

        private void tb_middlename_TextChanged(object sender, EventArgs e)
        {

        }

        

       
    }
}
