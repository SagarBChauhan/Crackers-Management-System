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
    public partial class AddItem : Form
    {
        public static int SubCatId = 0;
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch; 
            
            TxtSubCategoryId.Enabled = false;
            SqlDataReader dr;
            con.Close();
            cmd = new SqlCommand("Select max(subcategoryId) from tblSubcategory;", con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                SubCatId = Convert.ToInt32(dr.GetValue(0).ToString());
                TxtSubCategoryId.Text = SubCatId.ToString();
            }
            con.Close();
        }

        private void BtnAddSubCategory_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                cmd = new SqlCommand("insert into tblSubcategory (name, mfg_date, exp_date, price, quantity, reorder_level, supplierbrandId, categoryId) values ('" + TxtSubCategoryName.Text + "','" + dateTimePickerMFG.Value + "','" + dateTimePickerExp.Value + "'," + TxtPrice.Text + "," + TxtQty.Text + "," + TxtReOrder.Text + "," + TxtSupplierBrandId.Text + "," + TxtCateGoryId.Text + ");", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("SubCategory Added");
            }
            catch (Exception ex)
            { MessageBox.Show("category or brand unavailable"); }
        }
    }
}
