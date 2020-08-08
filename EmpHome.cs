using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS
{
    public partial class EmpHome : Form
    {
        public EmpHome()
        {
            InitializeComponent();
        }

        private void BtnPwdChange_Click(object sender, EventArgs e)
        {

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
                changePassword1.Show();
                changePassword1.BringToFront();
            }
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            SidePanel.Height = BtnHome.Height;
            SidePanel.Top = BtnHome.Top;
           // hideAll();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            SidePanel.Height = BtnOrder.Height;
            SidePanel.Top = BtnOrder.Top;
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
