using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace PackChecker
{
    public partial class frmpackmanagementmenu : UserControl
    {
        string splashtext;
        FrmSplash splashy;
        public frmpackmanagementmenu()
        {
            InitializeComponent();
        }

        private void frmpackmanagementmenu_Load(object sender, EventArgs e)
        {

        }
        private void btnforcecycle_Click(object sender, EventArgs e)
        {
            int pass = Utility.userreq("webadmin");
            if (pass == 0)
            {
                return;
            }

            using (yesnobox yn = new yesnobox("Are you sure you want to force a new cycle?", "Check Force"))
            {
                if (yn.ShowDialog() == DialogResult.No)
                {
                    return;
                }

            }
            startplash("Creating Cycle...");
            Utility.addcycle();
            stopsplash();
            using (msgbox mb = new PackChecker.msgbox("New Cycle Added", "Update Complete"))
            {
                mb.ShowDialog();

            }
        }



        private void btnpxlist_Click(object sender, EventArgs e)
        {
            
            frmpatientlist pxlist = new frmpatientlist();
            pxlist.ShowDialog();
            
        }



        private void btnchanges_Click(object sender, EventArgs e)
        {
            int pass = Utility.userreq("collect");
            if (pass == 0)
            {
                return;
            }
            frmchanges fc = new frmchanges();
            fc.ShowDialog();
        }

        private void btndeactpacks_Click(object sender, EventArgs e)
        {
            int pass = Utility.userreq("webadmin");
            if (pass == 0)
            {
                return;
            }
            frmdeactpacks dp = new frmdeactpacks();
            dp.ShowDialog();
        }

        private void btnfuture_Click(object sender, EventArgs e)
        {
            int pass = Utility.userreq("webadmin");
            if (pass == 0)
            {
                return;
            }
            frmholidaypacks hp = new frmholidaypacks();
            hp.ShowDialog();
        }

        private void btnimportnewpx_Click(object sender, EventArgs e)
        {
            int pass = Utility.userreq("webadmin");
            if (pass == 0)
            {
                return;
            }
            startplash("Updating Patients... please wait");
            
            Utility.updateallpx(sender, e,"force");
            stopsplash();
            using (msgbox mb = new PackChecker.msgbox("Update Complete", "Update Complete"))
            {
                mb.ShowDialog();

            }

        }

        private void btncasualpx_Click(object sender, EventArgs e)
        {
            frmcasualpatient fc = new frmcasualpatient("add",0);
            fc.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Utility.recopy_dispenseusers();
        }

        public void startplash(string starttext)
        {
            if (!backgroundWorker1.IsBusy)
            {
                splashtext = starttext;
                backgroundWorker1.RunWorkerAsync();
                
            }

        }
        private void updatesplash(string updatetext)
        {
            splashy.InvokeBy(() =>
            {
                splashy.SetStatus(updatetext);
            }
                        );
        }
        private void stopsplash()
        {
            splashy.InvokeBy(() =>
            {
                splashy.Close();
            }
                        );

            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            splashy = new FrmSplash();
            splashy.SetStatus(splashtext);
            splashy.ShowDialog();
        }
    }
}
