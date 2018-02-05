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
    public partial class frmdelivreportviewer : Form
    {
        public frmdelivreportviewer()
        {
            InitializeComponent();
        }

        private void frmdelivreportviewer_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'webbitdbdataset.rptdelivery' table. You can move, or remove it, as needed.
            try
            { this.rptdeliveryTableAdapter.Fill(this.webbitdbdataset.rptdelivery);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmdelivreportviewer_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = Color.FromArgb(0, 59, 76);
            var borderStyle = ButtonBorderStyle.Solid;
            var borderWidth = 3;
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, borderColor,
                    borderWidth,
                    borderStyle,
                    borderColor,
                    borderWidth,
                    borderStyle,
                    borderColor,
                    borderWidth,
                    borderStyle,
                    borderColor,
                    borderWidth,
                    borderStyle);
        }
    }
}
