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
    public partial class SearchSupplierForm : Form
    {
        public static int sid = 0;
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public SearchSupplierForm()
        {
            InitializeComponent();
        }

        private void SearchSupplierForm_Load(object sender, EventArgs e)
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
            da = new SqlDataAdapter("select * from tblSupplier;", con);
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
            da = new SqlDataAdapter("select * from tblSupplier where supplierId like '" + TxtPerameterSearch.Text + "' or Fname like'" + TxtPerameterSearch.Text + "'or Lname like '" + TxtPerameterSearch.Text + "'or address like'" + TxtPerameterSearch.Text + "'or cityId like'" + TxtPerameterSearch.Text + "'or contactNo like'" + TxtPerameterSearch.Text + "'or emailId like'" + TxtPerameterSearch.Text + "';", con);
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Delete ?", "Delete", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                con.Close();
                cmd = new SqlCommand("delete from tblSupplier where supplierId=" + sid + ";", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                DataDisplay();
                MessageBox.Show("Supplier removed");
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                sid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                /*      TxtFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                      TxtLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                      TxtAddress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                      TxtCityId.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                      TxtContact.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                      TxtEmail.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("select rows only");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSupplierForm us = new UpdateSupplierForm();
            us.Show();
        }
    }
}
