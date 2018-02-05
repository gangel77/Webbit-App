using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Deployment.Application;
using System.Configuration;
using Microsoft.Win32;
using System.Threading;
using System.Data.OleDb;

namespace PackChecker
{
    public partial class MainPage : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        double topack;
        double tocheck;
        double total;
        double todeliv;
        int Pass;
        double counttopack;
        double counttocheck;
        double counttotal;
        double countdeliv;
        private FrmSplash _splashy;

        public MainPage(FrmSplash splashy)
        {

            //Properties.Settings.Default.Save();

            this.Icon = Properties.Resources.icon;

            bool webbit_connected = false;
            bool dispense_connected = false;
            _splashy = splashy;
            _splashy.SetStatus("Checking Connection");

            int pass;


            //Check if setup has been performed on this pc before, and check connection.
            if (Properties.Settings.Default.initialsetup == "False")
            {
                Utility.checkwebbitconnection(out pass);
                //check if already connected to Webbit
                if (pass == 0)
                {

                    using (msgbox mb = new msgbox("Welcome to Webbit, I'll take you through how to set up this computer!", "Welcome"))
                    {
                        mb.ShowDialog();
                    }

                    using (yesnobox yn = new yesnobox("Is this your Master Terminal" + Environment.NewLine + "(First one you have setup)?", "Check server"))
                    {
                        if (yn.ShowDialog() == DialogResult.Yes)
                        {
                            Properties.Settings.Default.TerminalType = "Master";
                        }
                        else
                        {
                            Properties.Settings.Default.TerminalType = "Client";
                        }
                    }


                    using (yesnobox yn = new yesnobox("Did you put the database on this computer during installation?" + Environment.NewLine + "Select NO if you put in on a different Server", "Check server"))
                    {
                        string webbitpath = "";
                        if (yn.DialogResult == DialogResult.Yes)
                        {
                            webbitpath = "C:\\WebbitDB\\WebbitDB.accdb";
                        }
                        else
                        {
                            webbitpath = "";

                        }

                        while (webbit_connected == false)
                        {
                            //if pc is the server, open connect and add default server file destination as the string.
                            using (frmconnectionsetup connect = new frmconnectionsetup(webbitpath))
                            {
                                connect.ShowDialog();
                                webbit_connected = connect.successconnect;
                            }
                        }
                    }
                }

                string lotsconstring;
                string webbitconstring;
                if (Properties.Settings.Default.TerminalType == "Master")
                {
                    try
                    {

                        webbitconstring = Properties.Settings.Default.WebbitConnectionString;
                        using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                        {
                            string strupdateuser = "UPDATE tblsettings SET settingactive = ? WHERE settingid = 12";

                            OleDbCommand cmd = new OleDbCommand(strupdateuser, con);

                            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = webbitconstring;


                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                    }
                    catch (Exception exe)
                    {
                        Utility.LogFile(exe.Message, "Failed to save Webbit Connection String", "Main Page Open", exe.LineNumber(), this.FindForm().Name);
                    }


                    while (dispense_connected == false)
                    {
                        //if pc is the server, open connect and add default server file destination as the string.
                        using (frmconnectionsetupDispense connectdispense = new frmconnectionsetupDispense())
                        {
                            connectdispense.ShowDialog();
                            dispense_connected = connectdispense.successconnect;

                        }
                    }

                    try
                    {

                        lotsconstring = Properties.Settings.Default.LOTSConnectionString;
                        using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                        {
                            string strupdateuser = "UPDATE tblsettings SET settingactive = ? WHERE settingid = 1";

                            OleDbCommand cmd = new OleDbCommand(strupdateuser, con);

                            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = lotsconstring;


                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                    }
                    catch (Exception exe)
                    {
                        Utility.LogFile(exe.Message, "Failed to save Dispense Connection String", "Main Page Open", exe.LineNumber(), this.FindForm().Name);
                    }

                } else
                {
                    try
                    {


                        using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                        {
                            string strupdateuser = "SELECT settingactive FROM tblsettings WHERE settingid = 1";

                            OleDbCommand cmd = new OleDbCommand(strupdateuser, con);

                            con.Open();
                            lotsconstring = cmd.ExecuteScalar().ToString();
                            con.Close();

                        }
                        string dispensetype;
                        using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                        {
                            string strupdateuser = "SELECT settingactive FROM tblsettings WHERE settingid = 2";

                            OleDbCommand cmd = new OleDbCommand(strupdateuser, con);

                            con.Open();
                            dispensetype = cmd.ExecuteScalar().ToString();
                            con.Close();

                        }
                        Properties.Settings.Default.LOTSConnectionString = lotsconstring;

                        
                        Utility.checkdispenseconnection(out pass, dispensetype);

                        if (pass == 0)
                        {
                            using (msgbox mb = new msgbox("Couldn't connect to " + dispensetype + ".  Please run setup again on Master Installation", "Dispense didnt connect"))
                            {
                                mb.ShowDialog();
                            }
                            Environment.Exit(1);
                        }

                    }
                    catch (Exception exe)
                    {
                        Utility.LogFile(exe.Message, "Failed to save Dispense Connection String", "Main Page Open", exe.LineNumber(), this.FindForm().Name);
                    }
                }



            
        
                Properties.Settings.Default.initialsetup = "True";
                Properties.Settings.Default.Save();
            }
            //First run HAS been completed on this compo.
            else
            {
                Utility.checkwebbitconnection(out Pass);

                //Once setup is complete
                //if failed connect
                if (Pass == 0)
                {

                    using (yesnobox mb = new PackChecker.yesnobox("Error Connecting to Webbit, reconfigure it? This will not delete your data", "Connection Error"))
                    {
                        if (mb.ShowDialog() == DialogResult.Yes)
                        {
                            using (yesnobox yn = new yesnobox("Did you put the database on this computer during installation?" + Environment.NewLine + "Select NO if you put in on a different Server", "Check server"))
                            {
                                string webbitpath = "";
                                if (yn.DialogResult == DialogResult.Yes)
                                {
                                    webbitpath = "C:\\WebbitDB\\WebbitDB.accdb";
                                }
                                else
                                {
                                    webbitpath = "";
                                    
                                }
                                while (Pass == 0)
                                {
                                    //if pc is the server, open connect and add default server file destination as the string.
                                    using (frmconnectionsetup connect = new frmconnectionsetup(webbitpath))
                                    {
                                        connect.ShowDialog();

                                        if (connect.successconnect)
                                        {
                                            using (frmconnectionsetupDispense connectdispense = new frmconnectionsetupDispense())
                                            {
                                                connectdispense.ShowDialog();

                                                if (connectdispense.successconnect)
                                                {
                                                    Pass = 1;
                                                }

                                            }

                                        }
                                    }
                                }
                            }
                        }else
                        {
                            Environment.Exit(1);
                        }
                        

                    }
                }else
                {
                    Utility.checkdispenseconnection(out Pass, "Dispense");
                }

            }


            //Connections Successful - start program
            PackChecker.Properties.Settings.Default["WebbitConnectionString2"] = PackChecker.Properties.Settings.Default["WebbitConnectionString"];
            PackChecker.Properties.Settings.Default["LOTSConnectionString2"] = PackChecker.Properties.Settings.Default["LOTSConnectionString"];

            //Check for ComWarn in tblpatient and add if not there
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                con.Open();
                var schema = con.GetSchema("COLUMNS");
                var col = schema.Select("TABLE_NAME='tblpatient' AND COLUMN_NAME='comwarn'");

        if (col.Length > 0)
                {

                }
           // Column exist
        else
                {

                    string Addcolconwarn = "alter table tblpatient add comwarn BIT";

                    OleDbCommand cmd = new OleDbCommand(Addcolconwarn, con);
                    
                    cmd.ExecuteNonQuery();
                   
                }

                con.Close();

            }



            //check patient count
            int count = 0;
            //try
            //{
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    string strpxcycles = "SELECT COUNT(*) FROM tblpatient";

                    OleDbCommand cmd = new OleDbCommand(strpxcycles, con);


                    con.Open();
                    count = (int)cmd.ExecuteScalar();
                    con.Close();

                    //No Patients Found
                    while (count == 0)
                    {
                        using (msgbox mb = new msgbox("It looks like you are connected! Now it is time to import your dispense patients!", "Welcome"))
                        {
                            mb.ShowDialog();
                        }

                        using (msgbox mb = new msgbox("Make sure you have information on patients pack preferences with you", "Welcome"))
                        {
                            mb.ShowDialog();
                        }


                        FrmSetup FrmSetup = new FrmSetup();
                        FrmSetup.ShowDialog();
                        con.Open();
                        count = (int)cmd.ExecuteScalar();
                        con.Close();
                    }

                }
            //}
            //catch (Exception exe)
            //{
            //    Utility.LogFile(exe.Message, "Failed to check patient count", "Main Page Open", exe.LineNumber(), this.FindForm().Name);
            //}





            InitializeComponent();
            

            
            
            _splashy.SetStatus("Counting Packs");

            int weekid;
            Utility.checktopack(out counttopack, out weekid);
            Utility.checktocheck(out counttocheck);
            Utility.checktotalpacks(out counttotal);
            Utility.checkdeliver(out countdeliv);

            //MessageBox.Show("8");

            topack = counttopack;
            tocheck = counttocheck;
            total = counttotal;
            todeliv = countdeliv;
            preloadcontrols();
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                object getversion = hklm.OpenSubKey(@"SOFTWARE\Webbit").GetValue("Version");
                lblversion.Text = "Version " + getversion.ToString();
            }            
                        

            


        }

        public void SplashStart()
        {
            Application.Run(new FrmSplash());
        }
        public static frmcheckmenu frmcheckmenu;
        public static frmcollectmenu frmcollectmenu;
        public static frmpackmenu frmpackmenu;
        ucdeliverymenu ucdeliverymenu;
        public void preloadcontrols()
        {
            _splashy.SetStatus("Organising lily pads");
            frmcollectmenu = new frmcollectmenu();
            panelactive.Controls.Add(frmcollectmenu);
            frmcollectmenu.Dock = DockStyle.Fill;
            

            frmpackmenu = new frmpackmenu(topack, tocheck, total);
            panelactive.Controls.Add(frmpackmenu);
            frmpackmenu.Dock = DockStyle.Fill;


            frmcheckmenu = new frmcheckmenu(tocheck);
            panelactive.Controls.Add(frmcheckmenu);
            frmcheckmenu.Dock = DockStyle.Fill;

            
            _splashy.SetStatus("Catching flies");
            frmreports frmreports = new frmreports();
            panelactive.Controls.Add(frmreports);
            frmreports.Dock = DockStyle.Fill;

            ucdeliverymenu = new ucdeliverymenu(todeliv);
            panelactive.Controls.Add(ucdeliverymenu);
            ucdeliverymenu.Dock = DockStyle.Fill;

            _splashy.SetStatus("Having a swim");
            frmsettingsmenu frmsettingsmenu = new frmsettingsmenu();
            panelactive.Controls.Add(frmsettingsmenu);
            frmsettingsmenu.Dock = DockStyle.Fill;


            frmpackmanagementmenu frmpackmanagementmenu = new frmpackmanagementmenu();
            panelactive.Controls.Add(frmpackmanagementmenu);
            frmpackmanagementmenu.Dock = DockStyle.Fill;

            frmcollectmenu.BringToFront();
            foreach (Control p in pnlbuttons.Controls)
                if (p.GetType() == typeof(Bunifu.Framework.UI.BunifuFlatButton) && p.Name != "btncollectmenu")
                {
                    p.Left = -30;
                }else
                {
                    p.Left = -10;
                }
            _splashy.Close();
            _splashy.Dispose();

        }

        
        private void MainPage_Load(object sender, EventArgs e)
        {
       
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
           
        }

        
        void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btncollectmenu_Click(object sender, EventArgs e)
        {
            frmcollectmenu.rebiuldcombo(sender, e);
            MakeActiveButton(sender);

            foreach (Control ctrl in panelactive.Controls)
            {
                if (ctrl.Name == "frmcollectmenu")
                {
                       
                    ctrl.BringToFront();
                    
                    return;

                }
            }
            


        }

        private void MakeActiveButton(object sender)
        {
            var button = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            string btnname = button.Name;

            foreach (Control p in pnlbuttons.Controls)
                if (p.GetType() == typeof(Bunifu.Framework.UI.BunifuFlatButton) && p.Name != btnname)
                {
                    p.Left = -30;
                }
                
            button.Left = -10;
        }

        
        private void btnpackmenu_Click(object sender, EventArgs e)
        {
            int weekid;
            Utility.checktopack(out counttopack, out weekid);
            Utility.checktotalpacks(out counttotal);
            frmpackmenu.reloadtable(sender, e);
            frmpackmenu.recreatecircle(counttopack, counttotal);
            MakeActiveButton(sender);
            foreach (Control ctrl in panelactive.Controls)
            {
                if (ctrl.Name == "frmpackmenu")
                {
                    
                    ctrl.BringToFront();
                    
                    return;
                    
                }
            }

            
            
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void btncheckmenu_Click(object sender, EventArgs e)
        {
            Utility.checktocheck(out counttocheck);
            frmcheckmenu.lblcheckcount.Text = counttocheck.ToString();
            MakeActiveButton(sender);
            foreach (Control ctrl in panelactive.Controls)
            {
                if (ctrl.Name == "frmcheckmenu")
                {
                    
                    ctrl.BringToFront();
                    return;

                }
            }
            
        }
        

        private void btnclosetop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
        private void btnmanagepacks_Click(object sender, EventArgs e)
        {
            MakeActiveButton(sender);
            foreach (Control ctrl in panelactive.Controls)
            {
                if (ctrl.Name == "frmpackmanagementmenu")
                {
                    ctrl.BringToFront();
                    return;

                }
            }
        }

        private void btndeliveries_Click(object sender, EventArgs e)
        {
            ucdeliverymenu.ucdeliverymenu_Load(sender, e);
            MakeActiveButton(sender);
            foreach (Control ctrl in panelactive.Controls)
            {
                if (ctrl.Name == "ucdeliverymenu")
                {
                    
                    ctrl.BringToFront();
                    return;

                }
            }
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            MakeActiveButton(sender);
            foreach (Control ctrl in panelactive.Controls)
            {
                if (ctrl.Name == "frmreports")
                {
                    ctrl.BringToFront();
                    return;

                }
            }
            
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            MakeActiveButton(sender);
            foreach (Control ctrl in panelactive.Controls)
            {
                if (ctrl.Name == "frmsettingsmenu")
                {
                    ctrl.BringToFront();
                    return;

                }
            }
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void MainPage_Paint(object sender, PaintEventArgs e)
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

       

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
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

        private void pnlclose_Paint(object sender, PaintEventArgs e)
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


