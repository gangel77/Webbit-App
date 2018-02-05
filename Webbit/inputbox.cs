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
    public partial class inputbox : Form
    {
        public inputbox(string question, string title, string fillbox)
        {
            InitializeComponent();
            lblquestion.Text = question;
            Text = title;
            txtanswer.Text = fillbox;
        }
        public String answer;

        private void btnok_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtanswer.Text))
            {
                using (msgbox mb = new PackChecker.msgbox("You cannot leave this empty", "No Input"))
                {
                    mb.ShowDialog();
                    
                }
                ActiveControl = txtanswer;
            }else { 

                answer = txtanswer.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
                this.Dispose();
            }


        }

        private void inputbox_Paint(object sender, PaintEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void inputbox_Load(object sender, EventArgs e)
        {

        }
    }
}

