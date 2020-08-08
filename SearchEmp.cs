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
    public partial class SearchEmp : Form
    {
        public static int EmpId = 0;
        public static int UpdateFlow = 0;
        String gender = "";
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public SearchEmp()
        {
            InitializeComponent();
        }

        private void SearchEmp_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from tblEmployee;", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                EmpId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception Ex)
            {
               
            }
        }

        private void TxtPerameterSearch_TextChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from tblEmployee where EmployeeId like '" + TxtPerameterSearch.Text + "' or fname like'" + TxtPerameterSearch.Text + "' or  lname  like '" + TxtPerameterSearch.Text + "' or addr  like '" + TxtPerameterSearch.Text + "' or  cityId  like '" + TxtPerameterSearch.Text + "' or gender like '" + TxtPerameterSearch.Text + "' or DOB like '" + TxtPerameterSearch.Text + "' or contactNo like '" + TxtPerameterSearch.Text + "' or emailId like '" + TxtPerameterSearch.Text + "' or DateOfJoining like '" + TxtPerameterSearch.Text + "' or designation like '" + TxtPerameterSearch.Text + "' or salary like '" + TxtPerameterSearch.Text + "' or userName like '" + TxtPerameterSearch.Text + "' or pwd like '" + TxtPerameterSearch.Text + "';", con);
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
        }
        private void DataDisplay()
        {
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from tblEmployee;", con);
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            // throw new NotImplementedException();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Delete ?", "Delete", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from tblEmployee where EmployeeId =" + EmpId + ";", con);
                //  cmd = new SqlCommand("update tblEmployee set fname ='"TxtFirstName.Text"',lname='"+TxtLastName.Text+"',addr='"+TxtAddress.Text+"',cityId="+TxtCityId.Text+",gender='"+gender+"',DOB='"+DateDOB.Value+"',contactNo='"+TxtContact.Text+"' ,emailId='"+TxtEmail.Text+"' ,DateOfJoining ='"+DateOfJoining.Value+"',designation ='"+TxtDesignation.Text+"',salary="+TxtSalary.Text+",userName='"+TxtUserName.Text+"',pwd='"+TxtPassword.Text+"' where EmployeeId ="+TxtEmpId.Text+";", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                DataDisplay();
                MessageBox.Show("Employee Deleted");
            }
            else
            {
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmp UEmp = new UpdateEmp();
            UEmp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
