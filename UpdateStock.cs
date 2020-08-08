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
    public partial class UpdateStock : Form
    {
        int itemId = 0;
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public UpdateStock()
        {
            InitializeComponent();
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            itemId = StockCheck.itemId;

            FetchData();
        }
        private void FetchData()
        {
            con.Close();
            SqlDataReader dr;
            cmd = new SqlCommand("select * from tblSubcategory where subcategoryId=" + itemId + ";", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                TxtSubCategoryId.Text = dr.GetValue(0).ToString();
                TxtSubCategoryName.Text = dr.GetValue(1).ToString();
                //    dateTimePickerMFG.Value = Convert.ToDateTime(dr.GetValue(2).ToString());
                //    dateTimePickerExp.Value = Convert.ToDateTime(dr.GetValue(3).ToString());
                TxtPrice.Text = dr.GetValue(4).ToString();
                TxtQty.Text = dr.GetValue(5).ToString();
                TxtReOrder.Text = dr.GetValue(6).ToString();
                TxtSupplierBrandId.Text = dr.GetValue(7).ToString();
                TxtCateGoryId.Text = dr.GetValue(8).ToString();

            }
            // throw new NotImplementedException();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Update?", "Update", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                con.Close();
                int total = Convert.ToInt32(TxtQty.Text) + Convert.ToInt32(TxtAddQty.Text);
                cmd = new SqlCommand("update tblSubcategory set  quantity=" + total + " where subcategoryId=" + TxtSubCategoryId.Text + ";", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Stock Added updated");
            
            }
            else
            {
            }
        }
    }
}
