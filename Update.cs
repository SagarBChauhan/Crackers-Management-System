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
    public partial class Update : UserControl
    {
        public static int OperationFlow=0;
        int OpF = OperationFlow;
        public Update()
        {
            InitializeComponent();
        }

        private void GroupSupplier_Enter(object sender, EventArgs e)
        {
            
        }

        private void Update_Load(object sender, EventArgs e)
        {
            GroupSupplier.Hide();
            GroupItem.Hide();
            GroupEmployee.Hide();

            if (OpF == 1)
            {
                GroupEmployee.Show();    
            }
            else if (OpF == 2)
            { GroupItem.Show(); }
            else if (OpF == 3)
            { GroupSupplier.Show(); }
            else
            {
                
               // MessageBox.Show("No");
            }
        }
    }
}
