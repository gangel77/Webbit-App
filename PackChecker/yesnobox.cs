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
    }
}

