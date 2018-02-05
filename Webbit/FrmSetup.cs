using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.OleDb;

namespace PackChecker
{
    public partial class FrmSetup : Form
    {
        public FrmSetup()
        {
            InitializeComponent();
        }

        private void FrmSetup_Paint(object sender, PaintEventArgs e)
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
        msgbox mbsetup = new msgbox("This has already been set up", "done");
        private void btnconnect_Click(object sender, EventArgs e)
        {
            if (picconnection == null || picconnection.Image == null)
            {
                frmconnectionsetup frmInitialsetup = new frmconnectionsetup("");
                frmInitialsetup.ShowDialog();
                if (frmInitialsetup.successconnect == true)
                {
                    picconnection.Image = Properties.Resources.green_tick;
                    picarrowcon.Image = null;
                    picarrowuser.Image = Properties.Resources.green_arrowRight;
                }
            }
            else
            {
                mbsetup.ShowDialog();
            }
        }

        private void FrmSetup_Load(object sender, EventArgs e)
        {
            Utility.addnewusers();
            using (msgboxlarge mb = new msgboxlarge("This is the Setup Screen. It will take you through the Webbit Configuration" + Environment.NewLine + "Just follow the arrows!", "Steps"))
            {
                mb.ShowDialog();
            }

            using (msgbox mb2 = new msgbox("If you don't want to make any changes yet just press 'Save and Close' on each of the screens.", "Steps"))
            {
                mb2.ShowDialog();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (picuser == null || picuser.Image == null)
            {
                using (msgbox mb = new msgbox("First of all, we need to elevate one Dispense User to Pharmacist Level", "Steps"))
                {
                    mb.ShowDialog();
                }

                string userfirst = "user";
                string userlogin;
                string userpass;
                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

                using (inputbox ipfirst = new PackChecker.inputbox("Please enter a Login Code from" + Environment.NewLine + "Dispense for an Admin User:", "New User", ""))
                {
                    if (ipfirst.ShowDialog() == DialogResult.OK)
                    {
                        userlogin = ti.ToUpper(ipfirst.answer);
                    }
                    else
                    {
                        return;
                    }
                }

                try
                {
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        string countusers = "SELECT Count(*) FROM tbluser WHERE userlogin = ?";
                        string strusername = "SELECT userfirstname FROM tbluser WHERE userlogin = ?";
                        OleDbCommand cmd = new OleDbCommand(countusers, con);

                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = userlogin;

                        int count;
                        con.Open();
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();

                        if(count == 0)
                        {
                            using (msgbox mb = new PackChecker.msgbox("That user doesn't exist in dispense, please try again", "no user"))
                            {
                                mb.ShowDialog();
                                return;
                            }
                        }else
                        {
                            cmd.CommandText = strusername;
                            con.Open();
                            userfirst = cmd.ExecuteScalar().ToString();
                            con.Close();
                        }
                        
                    }
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, "Failed to check patient count", "Main Page Open", exe.LineNumber(), this.FindForm().Name);
                }



                using (inputbox ippass = new PackChecker.inputbox("Thanks " + userfirst + ", please enter a password for your Webbit account:", "New User", ""))
                {
                    if (ippass.ShowDialog() == DialogResult.OK)
                    {
                        userpass = ippass.answer;
                    }
                    else
                    {
                        return;
                    }
                }
                

                try
                {
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        string strupdateuser = "UPDATE tbluser SET userjobid = 1, userpass = ? WHERE userlogin = ?";

                        OleDbCommand cmd = new OleDbCommand(strupdateuser, con);
                        
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = userpass;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = userlogin;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        using (msgbox mb = new PackChecker.msgbox(userfirst + ", you have been elevated to an Admin position." + Environment.NewLine + "Other users can be edited later on.", "User Created"))
                        {
                            mb.ShowDialog();
                        }

                        picuser.Image = Properties.Resources.green_tick;
                        picarrowuser.Image = null;
                        picarrowloc.Image = Properties.Resources.green_arrowRight;

                    }
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, "Failed to check patient count", "Main Page Open", exe.LineNumber(), this.FindForm().Name);
                }
            }
            else
            {
                mbsetup.ShowDialog();
            }

        }

        private void btnlocations_Click(object sender, EventArgs e)
        {
            using (msgbox mb = new msgbox("Listed next are any DAA locations once they are packed." + Environment.NewLine + "You can Add or Hide locations", "Steps"))
            {
                mb.ShowDialog();
            }

            if (picloc == null || picloc.Image == null)
            {
                frmlocationlist frmlocationlist = new frmlocationlist();
                frmlocationlist.ShowDialog();
                if (frmlocationlist.succeed == true)
                {
                    picloc.Image = Properties.Resources.green_tick;
                    picarrowloc.Image = null;
                    picarrowsize.Image = Properties.Resources.green_arrowRight;
                }
            }
            else
            {
                mbsetup.ShowDialog();
            }
        }



        private void btnsizes_Click(object sender, EventArgs e)
        {
            using (msgbox mb = new msgbox("This next section lets you edit your Pack Sizes." + Environment.NewLine + "You can rename them too if you like.", "Steps"))
            {
                mb.ShowDialog();
            }

            if (picsize == null || picsize.Image == null)
            {
                frmtraysizelist frmtraysizelist = new frmtraysizelist();
                frmtraysizelist.ShowDialog();
                if (frmtraysizelist.succeed == true)
                {
                    picsize.Image = Properties.Resources.green_tick;
                    picarrowsize.Image = null;
                    picarrowcycle.Image = Properties.Resources.green_arrowRight;
                }

            }
            else
            {
                mbsetup.ShowDialog();
            }
        }

        private void btncycles_Click(object sender, EventArgs e)
        {
            using (msgbox mb = new msgbox("This is the final preferences page.", "Steps"))
            {
                mb.ShowDialog();
            }

            using (msgboxlarge mb2 = new msgboxlarge(@"There are a number of cycle types.  You may hide any that you never use." + Environment.NewLine + 
                "You may enable them again later if you want to." + Environment.NewLine +
                "Although you cannot create cycle new types, you may change their name to your own terminology.", "Steps"))
            {
                mb2.ShowDialog();
            }

            

            if (piccycles == null || piccycles.Image == null)
            {
                frmcyclelist frmcyclelist = new frmcyclelist();
                frmcyclelist.ShowDialog();
                if (frmcyclelist.succeed == true)
                {
                    piccycles.Image = Properties.Resources.green_tick;
                    picarrowcycle.Image = null;
                    picarrowimport.Image = Properties.Resources.green_arrowRight;
                }

            }
            else
            {
                mbsetup.ShowDialog();
            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            if (piccycles == null || piccycles.Image == null || picsize == null || picsize.Image == null || picloc == null || picloc.Image == null || picuser == null || picuser.Image == null)
            {
                msgbox notallowed = new msgbox("You cannot start the import until all actions above have been completed (Ticked)", "No access");
                notallowed.ShowDialog();
                return;
            }
            else
            {

                using (msgbox mb = new msgbox("Great. I'm now going to import your Dispense groups so you can let me know which ones are DAA groups.", "Steps"))
            {
                mb.ShowDialog();
            }

            frmimportinstitutions frmimportinstitutions = new frmimportinstitutions("new");
                this.Close();
                    this.Dispose();
                frmimportinstitutions.ShowDialog();
            }
        }

        private void btnclosetop_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
