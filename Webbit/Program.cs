using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackChecker
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
            FrmSplash splashy = new FrmSplash();
            splashy.Show();
            Application.Run(new MainPage(splashy));
            //Application.Run(new frmimportinstitutions("new"));
            
        }
    }
    
    static class User
    {
        
        public static int curuserid;
        public static string curuserlogin;
        public static string curusername;

    }
}
