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
            answer1 = txtanswer.Text;
            answer2 = txtanswer2.Text;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

        }

        private void inputbox_Load(object sender, EventArgs e)
        {

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
    }
}

