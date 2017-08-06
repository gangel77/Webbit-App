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
            answer = txtanswer.Text;
        }


    }
}

