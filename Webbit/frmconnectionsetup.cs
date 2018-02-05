using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.OleDb;

namespace PackChecker
{
    public partial class frmconnectionsetup : Form
    {
        
        int pass;
        string _Inputconpath;
        
        //string fixedconpath;

        public frmconnectionsetup(string conpath)
        {
            InitializeComponent();
            _Inputconpath = conpath;
        }
        public bool successconnect;
    
        private void btnconnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["WebbitConnectionString"] = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtdbpath.Text + ";";
            Properties.Settings.Default.Save();

            Utility.checkwebbitconnection(out pass);
            if (pass == 0)
            {
                using (msgbox mb = new PackChecker.msgbox("Connection failed, please find WebbitDB.accdb and try again", "Failed"))
                {
                    mb.ShowDialog();
                    
                }
                
                return ;
            }

            successconnect = true;
            using (msgbox mb = new PackChecker.msgbox("Success, Webbit is Connected", "Connected"))
            {
                mb.ShowDialog();
                

            }
           
            this.Close();
            this.Dispose();
            
            }

        private void frmconnectionsetup_Load(object sender, EventArgs e)
        {
            txtdbpath.Text = _Inputconpath;
            if (!string.IsNullOrEmpty(txtdbpath.Text))
            {
                txtdbpath.Enabled = false;
            }
            ActiveControl = txtdbpath;
        }
    
        private void frmconnectionsetup_Paint(object sender, PaintEventArgs e)
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

        

        private void btnclose_Click(object sender, EventArgs e)
        {
            using (yesnobox yn = new yesnobox("This will cancel the connection setup, are you sure?", "Cancel connection"))
            {
                if (yn.ShowDialog() == DialogResult.Yes)
                {
                   
                    Environment.Exit(1);
                }
                else
                {
                    
                    return;
                }
            }
        }

        private void btnfinddb_Click(object sender, EventArgs e)
        {
            OpenFileDialog findfile = new OpenFileDialog();

            if (findfile.ShowDialog() == DialogResult.OK)
            {
                txtdbpath.Text = findfile.FileName;
            }
        }
    }
}
