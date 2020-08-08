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
    public partial class ManageEmployeeForm : Form
    {
        public ManageEmployeeForm()
        {
            InitializeComponent();
        }

        private void BtnAddEmp_Click(object sender, EventArgs e)
        {
            AddEmp Ae = new AddEmp();
            Ae.Show();
            //this.Hide();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchEmp Se = new SearchEmp();
            Se.Show();
            //this.Hide();
        }

        private void BtnUpdateEmp_Click(object sender, EventArgs e)
        {
            UpdateEmp Ue = new UpdateEmp();
            Ue.Show();
           // this.Hide();
        }

        private void ManageEmployeeForm_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
