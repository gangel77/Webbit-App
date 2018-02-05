using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;


namespace PackChecker
{
    public partial class frmcycle : Form
    {
        int newcycleid;
        string oldtextpacks;
        string oldtextweeks;
        frmcyclelist _owner;
        public frmcycle(int cycleid, frmcyclelist owner)
        {
            InitializeComponent();
            newcycleid = cycleid;
            _owner = owner;

        }
        
        private void frmcycle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'webbitdbdataset.tblcycle' table. You can move, or remove it, as needed.
            this.tblcycleTableAdapter.Fill(this.webbitdbdataset.tblcycle);
            
            tblcycleBindingSource.Position = this.tblcycleBindingSource.Find("cycleid",newcycleid);
            oldtextpacks = cyclepacksTextBox.Text;
            oldtextweeks = cycleweeksTextBox.Text;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cyclecodeTextBox.Text.Trim() == string.Empty || cycleweeksTextBox.Text.Trim() == string.Empty || cyclepacksTextBox.Text.Trim() == string.Empty)
            {
                msgbox mb = new msgbox("All boxes must be filled prior to saving.", "Fields Required");
                mb.ShowDialog();
                return;
            }

            int n;
            string newtext = cyclepacksTextBox.Text;
            //Check integer added
            if (int.TryParse(newtext, out n))
            {
                //If it is a number
                //Check if it is larger than weeks
                if (n > Convert.ToInt32(cycleweeksTextBox.Text))
                {
                    msgbox mb = new msgbox("You can't have more packs than there are weeks!" + Environment.NewLine + "If this is the case, create a new Tray Size with 2 packs in it", "Input Error");
                    mb.ShowDialog();
                    cyclepacksTextBox.Text = oldtextpacks;
                    cycleweeksTextBox.Text = oldtextweeks;
                    return;
                }
            }
            else
            {
                //if not a number
                msgbox mb = new msgbox("Both weeks and packs must be numbers!", "Input Error");
                mb.ShowDialog();
                cyclepacksTextBox.Text = oldtextpacks;
                cycleweeksTextBox.Text = oldtextweeks;
                return;
            }
            try
            { 
            this.Validate();
            this.tblcycleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.webbitdbdataset);
            _owner.PerformRefresh();
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
            DialogResult = DialogResult.OK;

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        

        private void cyclehideCheckBox_Click(object sender, EventArgs e)
        {
            string state = cyclehideCheckBox.Checked.ToString();

            if (state == "True")
            {
                cyclehideCheckBox.Checked = false;

            }
            else
            {
                try
                { 
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    string strpxcycles = "SELECT COUNT(*) FROM tblpatient WHERE cycleid = ? AND active = -1";

                    OleDbCommand cmd = new OleDbCommand(strpxcycles, con);

                    cmd.Parameters.Add("?", OleDbType.Integer).Value = newcycleid;

                    int count = 0;
                    con.Open();
                    count = (int)cmd.ExecuteScalar();
                    con.Close();
                
                if (count != 0)
                {
                    msgbox mb = new msgbox("You cannot hide this cycle, it is in use by " + count + " patients.", "Failed to Hide");
                    mb.ShowDialog();
                    
                    
                        //something
                        

                }
                else
                {
                    cyclehideCheckBox.Checked = true;
                }
                }
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                }


            }
        }

        private void cyclecodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cyclecodeTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(cyclecodeTextBox, "This cannot be blank");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cycleweeksTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cycleweeksTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(cycleweeksTextBox, "This cannot be blank");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cyclepacksTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cyclepacksTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(cyclepacksTextBox, "This cannot be blank");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void frmcycle_Paint(object sender, PaintEventArgs e)
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
