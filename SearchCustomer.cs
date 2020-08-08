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
    public partial class SearchCustomer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public SearchCustomer()
        {
            InitializeComponent();
        }

        private void SearchCustomer_Load(object sender, EventArgs e)
        {
            dataDisplay();
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void dataDisplay()
        {
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from tblCustomer;", con);
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           // throw new NotImplementedException();
        }

        private void TxtPerameterSearch_TextChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from tblCustomer where Fname like '" + TxtPerameterSearch.Text + "' or Lname like'" + TxtPerameterSearch.Text + "'or  Addr like  '" + TxtPerameterSearch.Text + "'or  cityId like  '" + TxtPerameterSearch.Text + "'or  contactNo like  '" + TxtPerameterSearch.Text + "'or emaliId like  '" + TxtPerameterSearch.Text + "';", con);
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
             dataDisplay();
             TxtPerameterSearch.ResetText();
        }
    }
}
