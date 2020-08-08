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
    public partial class AddCustomer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            TxtCustomerId.Enabled = false;
            SqlDataReader dr;
            con.Close();
            cmd = new SqlCommand("Select max(CustId) from tblCustomer;", con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                TxtCustomerId.Text = 1+dr.GetValue(0).ToString();
            }
            con.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                cmd = new SqlCommand("insert into tblCustomer (Fname,Lname,Addr,cityId,contactNo,emaliId) values('" + TxtFirstName.Text + "','" + TxtLastName.Text + "','" + TxtAddress.Text + "'," + TxtCityId.Text + ",'" + TxtContact.Text + "','" + TxtEmail.Text + "');", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customer Registered Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Filds are empty");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                cmd = new SqlCommand("delete from tblCustomer where CustId=" + TxtCustomerId.Text + ";", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
