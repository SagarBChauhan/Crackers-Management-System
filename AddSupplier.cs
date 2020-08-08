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
    public partial class AddSupplier : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            TxtSupplierId.Enabled = false;
            SqlDataReader dr;
            con.Close();
            cmd = new SqlCommand("Select max(supplierId) from tblSupplier;", con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                TxtSupplierId.Text = dr.GetValue(0).ToString();
            }
            con.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("insert into tblSupplier (Fname,Lname ,address ,cityId ,contactNo ,emailId) values ('" + TxtFirstName.Text + "','" + TxtLastName.Text + "','" + TxtAddress.Text + "'," + TxtCityId.Text + ",'" + TxtContact.Text + "','" + TxtEmail.Text + "');", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Supplier Added");
        }
    }
}
