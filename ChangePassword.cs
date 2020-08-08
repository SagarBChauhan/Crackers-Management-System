using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMS
{
    public partial class ChangePassword : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void TxtOld_Leave(object sender, EventArgs e)
        {
            con.Close();
            SqlDataReader dr;
            cmd = new SqlCommand("select password from tblLoginDetails where userName='"+Login.UserName+"';",con);
            con.Open();
            dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                String pwd = dr.GetValue(0).ToString();
                if (pwd == TxtOld.Text)
                {
                    TxtOld.BackColor = Color.Green;
                }
                else
                {
                    TxtOld.BackColor = Color.Red;
                }
            }
            else
            {
            
            }
        }

        private void TxtReNew_Leave(object sender, EventArgs e)
        {
            if (TxtNew.Text != TxtReNew.Text)
            {
                TxtReNew.BackColor = Color.Red;
                TxtNew.BackColor = Color.Red;
            }
            else
            {
                TxtReNew.BackColor = Color.White;
                TxtNew.BackColor = Color.White;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (TxtNew.Text == TxtReNew.Text)
            {
                con.Close();
                cmd = new SqlCommand("update tblLoginDetails set password='" + TxtReNew.Text + "'  where userName='" + Login.UserName + "';", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password updated");
                Home ho = new Home();
                ho.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Password not Matched");
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
