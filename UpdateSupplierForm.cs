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
    public partial class UpdateSupplierForm : Form
    {
        int supId = 0;
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public UpdateSupplierForm()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("update tblSupplier set Fname ='" + TxtFirstName.Text + "',Lname='" + TxtLastName.Text + "',address='" + TxtAddress.Text + "',cityId=" + TxtCityId.Text + ",contactNo='" + TxtConatctNo.Text+ "' ,emailId='" + TxtEmail.Text + "'  where supplierId =" + supId+ ";", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Supplier updated");
        }

        private void FetchData()
        {
            con.Close();
            SqlDataReader dr;
            cmd = new SqlCommand("select * from tblSupplier where supplierId=" +supId +";", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                TxtSupplierId.Text = dr.GetValue(0).ToString();
                TxtFirstName.Text = dr.GetValue(1).ToString();
                TxtLastName.Text = dr.GetValue(2).ToString();
                TxtAddress.Text = dr.GetValue(3).ToString();
                TxtCityId.Text = dr.GetValue(4).ToString();
                TxtConatctNo.Text = dr.GetValue(5).ToString();
                TxtEmail.Text = dr.GetValue(6).ToString();
              //  TxtBrandId.Text = dr.GetValue(7).ToString();
                //TxtBrandName.Text = dr.GetValue(8).ToString();

            }
            con.Close();
            SqlDataReader dr2;
            cmd = new SqlCommand("select * from supplierBrand where supplierId=" + supId + ";", con);
            con.Open();
            dr2 = cmd.ExecuteReader();
            if (dr2.HasRows)
            {
                dr2.Read();
                TxtBrandId.Text = dr2.GetValue(0).ToString();
                TxtBrandName.Text = dr2.GetValue(2).ToString();

            }
            con.Close();
        }

        private void UpdateSupplierForm_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            supId = SearchSupplierForm.sid;
            FetchData();
        }
    }
}
