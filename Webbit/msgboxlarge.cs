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
    public partial class msgboxlarge : Form
    {
        public msgboxlarge(string message, string title)
        {
            InitializeComponent();
            lblquestion.Text = message;
            Text = title;
            
        }

        private void msgbox_Load(object sender, EventArgs e)
        {

        }

        private void msgbox_Paint(object sender, PaintEventArgs e)
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

