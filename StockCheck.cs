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
    public partial class StockCheck : Form
    {
        public static int alertFlag = 0;
        public static int itemId = 0;
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public StockCheck()
        {
            InitializeComponent();
        }

        private void StockCheck_Load(object sender, EventArgs e)
        {
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from tblSubcategory where  quantity<reorder_level;", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
            SqlDataReader dr;
            cmd = new SqlCommand("select * from tblSubcategory where  quantity<reorder_level;", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();

                alertFlag = 1;
            }
            else
            {
                alertFlag = 0;
            }
        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            UpdateStock us = new UpdateStock();
            us.Show();

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            itemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}
