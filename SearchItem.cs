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
    public partial class SearchItem : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public static int ItemId = 0;
        public SearchItem()
        {
            InitializeComponent();
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
        private void SearchItem_Load(object sender, EventArgs e)
        {
            DataDisplay();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ItemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
               /* TxtSubCategoryName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dateTimePickerMFG.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                dateTimePickerExp.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                TxtPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                TxtQty.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                TxtReOrder.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                TxtSupplierBrandId.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                TxtCateGoryId.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select rows only");
            }
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
            CMS.Update.OperationFlow = 2;
            Home hm = new Home();
            hm.Show();
        }
    }
}
