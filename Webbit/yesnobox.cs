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
    public partial class yesnobox : Form
    {
        public yesnobox(string question, string title)
        {
            InitializeComponent();
            lblquestion.Text = question;
            Text = title;
            
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            return;
        }

        private void yesnobox_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = Color.FromArgb(31, 134, 73);
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

