using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Report());
           //Application.Run(new Home());
           //  Application.Run(new UpdateEmp());
          //  Application.Run(new CMS.SearchItemForm());
           // Application.Run(new SearchSupplierForm());
            // Application.Run(new Bill());
        }
    }
}
