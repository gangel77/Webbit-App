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
    public partial class frmshowcons : Form
    {
        public frmshowcons(string dispname,bool webpass, bool disppass)
        {
            InitializeComponent();
            lbldispense.Text = dispname + " Connection:";
            if (webpass == true)
            {
                imgweb.Image = Properties.Resources.tick;
            }
            if (disppass == true)
            {
                imgdisp.Image = Properties.Resources.tick;
            }
        }

        private void frmshowcons_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = Color.FromArgb(148, 213, 0);
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
        
        private void frmshowcons_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
