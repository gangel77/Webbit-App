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
    public partial class msgbox : Form
    {
        public msgbox(string message, string title)
        {
            InitializeComponent();
            lblquestion.Text = message;
            Text = title;
            
        }
        
    }
}

