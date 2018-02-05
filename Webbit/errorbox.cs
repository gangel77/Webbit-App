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
    public partial class errorbox : Form
    {
        public errorbox(string question1, string question2, string fillbox1, string fillbox2, string title)
        {
            InitializeComponent();
            lblquestion1.Text = question1;
            lblquestion2.Text = question2;
            Text = title;
            txtanswer.Text = fillbox1;
            txtanswer2.Text = fillbox2;
            txtanswer.Focus();
        }
        public String answer1;
        public String answer2;

        private void btnok_Click(object sender, EventArgs e)
        {
            bool pass;
            bool y = validateall(out pass);

            if(y==false)
            {
                return;
            }

            answer1 = txtanswer.Text;
            answer2 = txtanswer2.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private bool validateall(out bool pass)
        {
            pass = true;
            int validint;
            bool valid = int.TryParse(txtanswer.Text, out validint);

            if (!valid)
            {
                msgbox mb = new msgbox("Please Enter a NUMBER into the count box", "Entry not a number");
                mb.ShowDialog();
                txtanswer.Text = "";
                pass = false;
                return pass;
                
            }

            if (txtanswer2.Text == string.Empty)
            {
                msgbox mb2 = new msgbox("You must leave a comment for the error", "Missing Comment");
                mb2.ShowDialog();
                pass = false;
                return pass;
            }

            return pass;
            
        }

        private void txtanswer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    SendKeys.Send("{TAB}");
                    // SelectNext(this);
                    break;
                default:
                    base.OnKeyDown(e);
                    break;
            }
        }

        private void txtanswer2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    SendKeys.Send("{TAB}");
                    // SelectNext(this);
                    break;
                default:
                    base.OnKeyDown(e);
                    break;
            }
        }

        private void errorbox_Load(object sender, EventArgs e)
        {

        }

        private void errorbox_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = Color.FromArgb(75, 47, 70);
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

