using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackChecker
{
    public partial class ucdeliverymenu : UserControl
    {
        double countdeliv;

        private void btnDelivReport_Click(object sender, EventArgs e)
        {
            if (lbldevlierycount.Text == "0")
            {
                using (msgbox mb = new msgbox("No packs ready to deliver", "no delivery"))
                {
                    mb.ShowDialog();
                }
                return;
            }
            frmdelivreportviewer frmdelivreportviewer = new frmdelivreportviewer();
            frmdelivreportviewer.ShowDialog();
        }

        public ucdeliverymenu(double todeliv)
        {
            InitializeComponent();
            countdeliv = todeliv;
        }

        private void btndeliver_Click(object sender, EventArgs e)
        {
            if(lbldevlierycount.Text == "0")
            {
                using (msgbox mb = new msgbox("No packs ready to deliver", "no delivery"))
                {
                    mb.ShowDialog();
                }
                return;
            }
            int pass = Utility.userreq("collect");
            if (pass == 0)
            {
                return;
            }

            frmdelivery frmdelivery = new frmdelivery();
            frmdelivery.ShowDialog();
            Utility.checkdeliver(out countdeliv);
            lbldevlierycount.Text = countdeliv.ToString();
        }

        public void ucdeliverymenu_Load(object sender, EventArgs e)
        {
            Utility.checkdeliver(out countdeliv);
            lbldevlierycount.Text = countdeliv.ToString();
        }
    }
}
