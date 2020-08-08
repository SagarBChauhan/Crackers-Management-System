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
    public partial class UpdateEmp : Form
    {
        int empId = 0;
        String gender = "";
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public UpdateEmp()
        {
            InitializeComponent();

        }

        private void UpdateEmp_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            empId = SearchEmp.EmpId;
            FetchData();
        }

        private void FetchData()
        {
            con.Close();
            SqlDataReader dr;
            cmd = new SqlCommand("select * from tblEmployee where EmployeeId="+empId+";", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                TxtEmpId.Text = dr.GetValue(0).ToString();
                 TxtFirstName.Text= dr.GetValue(1).ToString();
                 TxtLastName.Text = dr.GetValue(2).ToString();
                 TxtAddress.Text = dr.GetValue(3).ToString();
                 TxtCityId.Text = dr.GetValue(4).ToString();
                 gender = dr.GetValue(5).ToString();
                 if (gender == "Male")
                 { radioMale.Checked=true; }
                 else
                 { radioFemale.Checked = true; }
                 DateDOB.Value = Convert.ToDateTime(dr.GetValue(6).ToString());
                 TxtContact.Text = dr.GetValue(7).ToString();
                 TxtEmail.Text = dr.GetValue(8).ToString();
                 DateOfJoining.Value = Convert.ToDateTime(dr.GetValue(9));
                 TxtDesignation.Text = dr.GetValue(10).ToString();
                 TxtSalary.Text = dr.GetValue(11).ToString();
                 TxtUserName.Text = dr.GetValue(12).ToString();
                 TxtPassword.Text = dr.GetValue(13).ToString();

            }
           // throw new NotImplementedException();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            con.Close();
            if (radioFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }
            cmd = new SqlCommand("update tblEmployee set Fname ='" + TxtFirstName.Text + "',Lname='" + TxtLastName.Text + "',address='" + TxtAddress.Text + "',cityId=" + TxtCityId.Text + ",contactNo='" + TxtContact.Text + "' ,emailId='" + TxtEmail.Text + "' where EmployeeId =" + TxtEmpId.Text + ";", con);
            //  cmd = new SqlCommand("update tblEmployee set fname ='"TxtFirstName.Text"',lname='"+TxtLastName.Text+"',addr='"+TxtAddress.Text+"',cityId="+TxtCityId.Text+",gender='"+gender+"',DOB='"+DateDOB.Value+"',contactNo='"+TxtContact.Text+"' ,emailId='"+TxtEmail.Text+"' ,DateOfJoining ='"+DateOfJoining.Value+"',designation ='"+TxtDesignation.Text+"',salary="+TxtSalary.Text+",userName='"+TxtUserName.Text+"',pwd='"+TxtPassword.Text+"' where EmployeeId ="+TxtEmpId.Text+";", con);
            SqlCommand cmd2 = new SqlCommand("update tblLoginDetails set password='" + TxtPassword.Text + "',userName='" + TxtUserName.Text + "' where userName='" + TxtUserName.Text + "';", con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show("Employee updated");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchEmp SEmp = new SearchEmp();
            SEmp.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
