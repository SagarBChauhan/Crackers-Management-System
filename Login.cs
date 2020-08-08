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
    public partial class Login : Form
    {
        public static String UserName = "";
        String pwd;
        String type="";
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            SqlDataReader da;
            con.Close();
            cmd = new SqlCommand("select  password,type from tblLoginDetails where username='" + txtusername.Text + "' ;", con);
            con.Open();
            da = cmd.ExecuteReader();
            if (da.HasRows)
            {
                da.Read();
                pwd = da.GetValue(0).ToString();
                type = da.GetValue(1).ToString();
                if (pwd == txtpassword.Text || type == "Owner")
                {
                    UserName = txtusername.Text;
                    Home hm = new Home();
                    hm.Show();
                    this.Hide();
                    Home.UserName = UserName;
                }
                else if (pwd == txtpassword.Text || type == "Employee")
                {
                    UserName = txtusername.Text;
                    Home hm = new Home();
                    hm.Show();
                    this.Hide();
                    Home.UserName = UserName;
                }
                else
                {
                    MessageBox.Show("Password not matched");
                }

            }
            else
            {
                MessageBox.Show("No username found");
            }
            con.Close();
        }
        private void checkUser()
        {
            SqlDataReader da;
            con.Close();
            cmd = new SqlCommand("select  password from tblLoginDetails where username='" + txtusername.Text + "' ;", con);
            con.Open();
            da = cmd.ExecuteReader();
            if (da.HasRows)
            {
                da.Read();
                txtusername.BackColor = Color.Green;
                txtusername.ForeColor = Color.White;
            }
            else
            {
                txtusername.BackColor = Color.Red;
                txtusername.ForeColor = Color.White;
            }
            //   throw new NotImplementedException();
        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            checkUser();
        }

    }
}
