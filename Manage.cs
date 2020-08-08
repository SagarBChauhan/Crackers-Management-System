using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMS
{
    public partial class Manage : UserControl
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void BtnEmp_Click(object sender, EventArgs e)
        {
            ManageEmployeeForm Me = new ManageEmployeeForm();
            Me.Show();
        }

        private void BtnSup_Click(object sender, EventArgs e)
        {
            ManageSupplierForm Ms = new ManageSupplierForm();
            Ms.Show();
        }

        private void BtnItm_Click(object sender, EventArgs e)
        {
            ManageItemForm Mi = new ManageItemForm();
            Mi.Show();
        }

    }
}