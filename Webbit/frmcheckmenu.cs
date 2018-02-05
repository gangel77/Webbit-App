using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackChecker
{
    public partial class frmcheckmenu : UserControl
    {
        double counttocheck;
        public frmcheckmenu(double tocheck)
        {
            InitializeComponent();
            
            counttocheck = tocheck;
            
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            int pass = Utility.userreq("check");
            if (pass == 0)
            {
                return;
            }

            frmchecking frmchecking = new frmchecking();
            frmchecking.ShowDialog();
            Utility.checktocheck(out counttocheck);
            lblcheckcount.Text = counttocheck.ToString();
        }

        private void frmcheckmenu_Load(object sender, EventArgs e)
        {

            Utility.checktocheck(out counttocheck);
            lblcheckcount.Text = counttocheck.ToString();
        }
        
        public void rewritepacktocheck(double countocheck)
        {
            Utility.checktocheck(out counttocheck);
            lblcheckcount.Text = counttocheck.ToString();
        }
    }
}
