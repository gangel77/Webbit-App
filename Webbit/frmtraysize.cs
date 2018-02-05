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
    public partial class frmtraysize : Form
    {
        frmtraysizelist _owner;
        string formaction;
        int _nextorder;
        int traysizeid;
        public frmtraysize(string action, frmtraysizelist owner, int nextorder, int inptraysizeid)
        {
            InitializeComponent();
            _owner = owner;
            formaction = action;
            _nextorder = nextorder;
            traysizeid = inptraysizeid;
        }

        private void tblpacksizeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblpacksizeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.webbitdbdataset);

        }

        private void frmtraysize_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'webbitdbdataset.tblpacksize' table. You can move, or remove it, as needed.
            if (formaction == "add")
            {
                sizeorderTextBox.Text = _nextorder.ToString();
                lblTitle.Text = "Add new Tray Size";
            }
            else
            { 
                try
                {
                    this.tblpacksizeTableAdapter.Fill(this.webbitdbdataset.tblpacksize);
                tblpacksizeBindingSource.Position = this.tblpacksizeBindingSource.Find("packsizeid", traysizeid);
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                }
        }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (sizenameTextBox.Text.Trim() == string.Empty || sizelongnameTextBox.Text.Trim() == string.Empty || sizeorderTextBox.Text.Trim() == string.Empty)
            {
                msgbox mb = new msgbox("All boxes must be filled prior to saving.", "Fields Required");
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
                        string strins = "INSERT INTO tblpacksize (sizename,sizelongname,sizecomment,sizeorder, hide) VALUES (?,?,?,?,?)";
                        using (OleDbCommand cmd = new OleDbCommand(strins, con))
                        {
                            using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                            {
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = sizenameTextBox.Text;
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = sizelongnameTextBox.Text;
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = sizecommentTextBox.Text;
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = sizeorderTextBox.Text;
                                cmd.Parameters.Add("?", OleDbType.Boolean).Value = hideCheckBox.Checked;

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
                this.Validate();
                this.tblpacksizeBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(this.webbitdbdataset);
            }
            _owner.PerformRefresh();
            this.Close();
            this.Dispose();
        }

        private void sizeorderTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sizeorderTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(sizeorderTextBox, "This cannot be blank");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void sizeorderTextBox_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 2500;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("Order to show this size in dropdown boxes", TB, 25, 0, VisibleTime);
        }

        private void sizenameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sizenameTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(sizenameTextBox, "This cannot be blank");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void sizelongnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sizelongnameTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(sizelongnameTextBox, "This cannot be blank");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void frmtraysize_Paint(object sender, PaintEventArgs e)
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

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }  
    
}
