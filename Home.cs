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

    public partial class Home : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public static String UserName="";
        public static String UpdateFlow = "";
        public Home()
        {
            InitializeComponent();
            SidePanel.Height = BtnHome.Height;
            SidePanel.Top = BtnHome.Top;
            BlurBackGround();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BtnExit.Height;
            SidePanel.Top = BtnExit.Top;
                DialogResult dialog = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                { 
                }
        }
        
        private void BtnManage_Click(object sender, EventArgs e)
        {
            BlurBackGround();
            SidePanel.Height = BtnManage.Height;
            SidePanel.Top = BtnManage.Top;
            manage1.Show();
            manage1.BringToFront();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            CheckStock();
            BlurBackGround();
            //MessageBox.Show("Welcome "+Login.UserName);
            LblUserName.Text = "   "+Login.UserName;
            hideAll();
            SizeAd();
            AddEmp Ae = new AddEmp();
            AddSupplier As = new AddSupplier();
            AddItem Ai = new AddItem();
            SearchEmp Se = new SearchEmp();
            SearchSupplierForm Ss = new SearchSupplierForm();
            SearchItemForm Si = new SearchItemForm();
            UpdateEmp Ue = new UpdateEmp();
            UpdateItemForm Ui = new UpdateItemForm();
            UpdateSupplierForm Us= new UpdateSupplierForm();
        }

        private void CheckStock()
        {
            con.Close();
            SqlDataReader dr;
            cmd = new SqlCommand("select * from tblSubcategory where  quantity<reorder_level;", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                BtnStockAlert.Show();
                //alertFlag = 1;
            }
            else
            {
               // alertFlag = 0;
                BtnStockAlert.Hide();
            }

            //throw new NotImplementedException();
        }

        private void hideAll()
        {
            manage1.Hide();
            order1.Hide();
            changePassword1.Hide();
            about1.Hide();
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion.jpg");
            this.BackgroundImage = myimage;

            //throw new NotImplementedException();
        }

        private void SizeAd()
        {
            manage1.Height = PanalSide.Height;
            manage1.Width = PanalLow.Width;
            
            order1.Height = PanalSide.Height;
            order1.Width = PanalLow.Width;

            changePassword1.Height = PanalSide.Height;
            changePassword1.Width = PanalLow.Width;

            about1.Height = PanalSide.Height;
            about1.Width = PanalLow.Width;


            //throw new NotImplementedException();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Log out ?", "Logout", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            else
            {
            }

        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BtnOrder.Height;
            SidePanel.Top = BtnOrder.Top;
            order1.Show();
            order1.BringToFront();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            CheckStock();
            SidePanel.Height = BtnHome.Height;
            SidePanel.Top = BtnHome.Top;
            hideAll();
        }

        private void BlurBackGround()
        {

            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //throw new NotImplementedException();
        }

        private void BtnPwdChange_Click(object sender, EventArgs e)
        {
            BlurBackGround();
            changePassword1.Show();
            changePassword1.BringToFront();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            BlurBackGround();
            SidePanel.Height = BtnAbout.Height;
            SidePanel.Top = BtnAbout.Top;
            about1.Show();
            about1.BringToFront();

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            con.Close();
            SqlDataReader dr;
            cmd = new SqlCommand("select * from tblSubcategory where  quantity<reorder_level;", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                BtnStockAlert.Show();
                //alertFlag = 1;
            }
            else
            {
                // alertFlag = 0;
                BtnStockAlert.Hide();
            }
        }

        private void BtnStockAlert_Click(object sender, EventArgs e)
        {
            StockCheck st = new StockCheck();
            st.Show();
        }
    }
}
