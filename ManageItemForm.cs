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
    public partial class ManageItemForm : Form
    {
        public ManageItemForm()
        {
            InitializeComponent();
        }

        private void BtnAddEmp_Click(object sender, EventArgs e)
        {
            AddItem Ai = new AddItem();
            Ai.Show();
            //this.Hide();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchItemForm Si = new SearchItemForm();
            Si.Show();
            //this.Hide();
        }

        private void BtnUpdateEmp_Click(object sender, EventArgs e)
        {
            UpdateItemForm Ui = new UpdateItemForm();
            Ui.Show();
           // this.Hide();
        }

        private void ManageItemForm_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
