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
    public partial class Stock : UserControl
    {
        public static int alertFlag=0;
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
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
    }
}
