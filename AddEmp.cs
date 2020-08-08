using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMS
{
    public partial class AddEmp : Form
    {
        String gender = "", a, b, c;
        // String a = TxtEmpId.Text, b = TxtFirstName.Text, c = TxtLastName.Text;
        //String[] userName = { };
        String[] userName = new String[13];
        int id = 0, maxId = 0;
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public AddEmp()
        {
            InitializeComponent();
        }

        private void AddEmp_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            TxtEmpId.Enabled = false;
            SqlDataReader dr;
            con.Close();
            cmd = new SqlCommand("Select max(EmployeeId) from tblEmployee;", con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                TxtEmpId.Text = dr.GetValue(0).ToString();
            }
            con.Close();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                if (radioMale.Checked == true)
                {
                    gender = "Male";
                }
                else if (radioFemale.Checked == true)
                {
                    gender = "Female";
                }
                cmd = new SqlCommand("insert into tblEmployee (fname,lname,addr,cityId,gender,DOB,contactNo,emailId,DateOfJoining,designation,salary,userName,pwd) values('" + TxtFirstName.Text + "','" + TxtLastName.Text + "','" + TxtAddress.Text + "'," + TxtCityId.Text + ",'" + gender + "','" + DateDOB.Value + "','" + TxtContact.Text + "','" + TxtEmpId.Text + "','" + DateOfJoining.Value + "','" + TxtDesignation.Text + "','" + TxtSalary.Text + "','" + TxtUserName.Text + "','" + TxtPassword.Text + "');", con);
                SqlCommand cmd2 = new SqlCommand("insert into tblLoginDetails values('" + TxtUserName.Text + "','" + TxtPassword.Text + "');", con);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee Registered Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Filds are empty");
            }
        }

        private void TxtFirstName_Leave(object sender, EventArgs e)
        {
            TxtUserName.Text = TxtFirstName.Text + TxtEmpId.Text;
        }
    }
}
