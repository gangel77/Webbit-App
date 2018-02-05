using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace PackChecker
{
    public partial class frmlocation : Form
    {
        int newlocationid;
        frmlocationlist _owner;
        string formaction;
        public frmlocation(int locationid, frmlocationlist owner,string action)
        {
            InitializeComponent();
            _owner = owner;
            newlocationid = locationid;
            formaction = action;
        }

        private void frmlocation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'webbitdbdataset.tblpacklocation' table. You can move, or remove it, as needed.
            if(formaction == "add")
            { return;
            }else
            {
                try
                { 
                this.tblpacklocationTableAdapter.Fill(this.webbitdbdataset.tblpacklocation);
                tblpacklocationBindingSource.Position = this.tblpacklocationBindingSource.Find("locationid", newlocationid);
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                }
            }
            
        }



        private void btnsave_Click(object sender, EventArgs e)
        {
            if (locationnameTextBox.Text.Trim() == string.Empty)
            {
                msgbox mb = new msgbox("Location Name must be filled prior to saving.", "Fields Required");
                mb.ShowDialog();
                return;
            }

            if (formaction == "add")
            {
                //runsql
                try
                { 
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {

                    string strins = "INSERT INTO tblpacklocation (locationname,warning,hidelocation) VALUES (?,?,?)";
                    using (OleDbCommand cmd = new OleDbCommand(strins, con))
                    {

                        using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                        {
                            cmd.Parameters.Add("?", OleDbType.VarChar).Value = locationnameTextBox.Text;
                            cmd.Parameters.Add("?", OleDbType.Boolean).Value = warningCheckBox.CheckState;
                            cmd.Parameters.Add("?", OleDbType.Boolean).Value = hidelocationCheckBox.CheckState;

                            adapt.SelectCommand = cmd;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                }
            }
            else
            {
                try
                { 
                this.Validate();
                this.tblpacklocationBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.webbitdbdataset);
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                }
            }
            _owner.PerformRefresh();
            this.Close();
            this.Dispose();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }



        private void hidelocationCheckBox_Click(object sender, EventArgs e)
        {
            string state = hidelocationCheckBox.Checked.ToString();

            if (state == "True")
            {
                hidelocationCheckBox.Checked = false;

            }
            else
            {
                int count = 0;
                try
                { 
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    string strpxcycles = "SELECT COUNT(*) FROM tblpatient WHERE (packlocation = ? AND active = 1) OR (secondarypacklocation = ? AND active = 1)";

                    using (OleDbCommand cmd = new OleDbCommand(strpxcycles, con))
                    {

                        cmd.Parameters.Add("?", OleDbType.Integer).Value = newlocationid;
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = newlocationid;
                        
                        con.Open();
                        count = (int)cmd.ExecuteScalar();
                        con.Close();
                    }
                }
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                }

                if (count != 0)
                {
                    msgbox mb = new msgbox("You cannot hide this location, it is in use by " + count + " patients.", "Failed to Hide");
                    mb.ShowDialog();


                    //something


                }
                else
                {
                    hidelocationCheckBox.Checked = true;
                }
            }
        }

        private void locationnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (locationnameTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(locationnameTextBox, "This cannot be blank");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void frmlocation_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = Color.FromArgb(31, 134, 73);
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

