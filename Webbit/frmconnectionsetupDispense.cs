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
using Moletrator.SQLDocumentor;
using System.Threading;

namespace PackChecker
{
    public partial class frmconnectionsetupDispense : Form
    {
        
        int pass;
        
        
        public frmconnectionsetupDispense()
        {
            InitializeComponent();
           
        }
        public bool successconnect;
    
        private void btnconnect_Click(object sender, EventArgs e)
        {
            if (cmbdispense.SelectedIndex == -1)
            {
                using (msgbox mb = new msgbox("Please select a dispense system to import from before connecting", "Need dispense name"))
                {
                    mb.ShowDialog();
                }

                return;
            }

            //if(string.IsNullOrEmpty(txtpcname.Text))
            //{
            //    using (msgbox mb = new msgbox("Please Enter the Server PC Name prior to trying to connect", "Need dispense name"))
            //    {
            //        mb.ShowDialog();
            //    }

            //    return;
            //}
            if(listboxSQLServerInstances.SelectedIndex == -1)
            {
                using (msgbox mb = new msgbox("Please select one of the listed servers before proceeding.", "Need dispense name"))
                {
                    mb.ShowDialog();
                    return;
                }
            }
            string SQLServer = listboxSQLServerInstances.SelectedItem.ToString();

            string lotsconstring = @"Server=" + SQLServer + "; Database=" + "LOTS" + ";Integrated Security=False;User ID=sa;Password=Corum123";
            //MessageBox.Show(lotsconstring, "failed connection");
            Properties.Settings.Default.LOTSConnectionString = lotsconstring;
            
            Properties.Settings.Default.Save();




            Utility.checkdispenseconnection(out pass,cmbdispense.SelectedItem.ToString());
            if (pass == 1)
            {

                using (msgbox mb = new msgbox("All Connections Setup, Database Connected", "Connected"))
                {
                    mb.ShowDialog();
                }

                //Properties.Settings.Default.WebbitPath = txtdbpath.Text;
                successconnect = true;
                this.Close();
                this.Dispose();
            }


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

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            using (yesnobox yn = new yesnobox("This will cancel the connection setup, are you sure?", "Cancel connection"))
            {
                if(yn.ShowDialog() == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }else
                {
                    return;
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Utility.checkwebbitconnection(out pass);
            if(pass == 0)
            {
                using (msgbox mb = new PackChecker.msgbox("Connection failed, please find WebbitDB.accdb and try again", "Failed"))
                {
                    mb.ShowDialog();
                    
                }
                return;
            }
        }

        private void frmconnectionsetupDispense_Load(object sender, EventArgs e)
        {

        }

        
        private void cmbdispense_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
                SQLInfoEnumerator sie = new SQLInfoEnumerator();
                try
                {
                    listboxSQLServerInstances.Items.Clear();

                    listboxSQLServerInstances.Items.AddRange(sie.EnumerateSQLServersDatabases());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                spl.DialogResult = DialogResult.OK;
                
            }
        }
        FrmSplash spl = new FrmSplash();

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            spl.SetStatus("Searching for Databases");
            spl.ShowDialog();
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }
    }
}
