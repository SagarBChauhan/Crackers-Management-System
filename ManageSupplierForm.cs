﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS
{
    public partial class ManageSupplierForm : Form
    {
        public ManageSupplierForm()
        {
            InitializeComponent();
        }

        private void BtnAddEmp_Click(object sender, EventArgs e)
        {
            AddSupplier As = new AddSupplier();
            As.Show();
            //this.Hide();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchSupplierForm Ss = new SearchSupplierForm();
            Ss.Show();
           // this.Hide();
        }

        private void BtnUpdateEmp_Click(object sender, EventArgs e)
        {
            UpdateSupplierForm Us = new UpdateSupplierForm();
            Us.Show();
           //this.Hide();
        }

        private void ManageSupplierForm_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
