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
    public partial class SearchItemForm : Form
    {
        public static int itemId = 0;
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public static int ItemId = 0;
        public SearchItemForm()
        {
            InitializeComponent();
        }
       
        private void SearchItemForm_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            DataDisplay();

        }


        private void DataDisplay()
        {
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from tblSubcategory;", con);
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //throw new NotImplementedException();
        }
        private void TxtPerameterSearch_TextChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from tblSubcategory where subcategoryId like '" + TxtPerameterSearch.Text + "' or name like'" + TxtPerameterSearch.Text + "'or  mfg_date like  '" + TxtPerameterSearch.Text + "'or  exp_date like  '" + TxtPerameterSearch.Text + "'or  price like  '" + TxtPerameterSearch.Text + "'or quantity like  '" + TxtPerameterSearch.Text + "'or reorder_level like '" + TxtPerameterSearch.Text + "'or supplierbrandId like  '" + TxtPerameterSearch.Text + "'or categoryId like  '" + TxtPerameterSearch.Text + "';", con);
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                itemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            { }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("delete from tblSubcategory where subcategoryId=" + ItemId + ";", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DataDisplay();
            MessageBox.Show("SubCategory removed");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateItemForm uif = new UpdateItemForm();
            uif.Show();
            this.Hide();
        }
    }
}
