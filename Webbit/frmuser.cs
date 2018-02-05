using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace PackChecker
{
    public partial class frmuser : Form
    {
        int newuserid;
        frmuserlist _owner;
        string formaction;
        public frmuser(int userid, frmuserlist owner,string action)
        {
            InitializeComponent();
            _owner = owner;
            newuserid = userid;
            formaction = action;
            dataGridjob.ClearSelection();
            dataGridjob.EnableHeadersVisualStyles = false;
        }

        private void frmlocation_Load(object sender, EventArgs e)
        {

            this.tbljobTableAdapter.Fill(this.webbitdbdataset.tbljob);
            

            if (formaction == "add")
            {

            }
            else
            {
                try
                {                  
                    
                this.tbluserTableAdapter.Fill(this.webbitdbdataset.tbluser);
                tbluserBindingSource.Position = this.tbluserBindingSource.Find("userid", newuserid);
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                }
                //using (msgbox mb = new msgbox("Edit ", "Check User"))
                //{
                //    mb.ShowDialog();
                //}
            }

            greenticks();
        }

        private void greenticks()
        {
            foreach (DataGridViewRow row2 in dataGridjob.Rows)
            {
                for (int i = 0; i < dataGridjob.Columns.Count; i++)
                {
                    if (row2.Cells[i].Value.ToString() == "True")
                    {
                        row2.Cells[i].Style.BackColor = Color.FromArgb(129, 183, 143);
                        row2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(129, 183, 143);
                    }else
                    {
                        row2.DefaultCellStyle.SelectionBackColor = Color.White;
                    }


                }


            }
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            if (formaction == "add")
            {
                if(userfirstnameTextBox.Text.Trim() == string.Empty ||userlastnameTextBox.Text.Trim() == string.Empty || userloginTextBox.Text.Trim() == string.Empty || cmbjob.SelectedIndex == -1)
                {
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        string strins = "SELECT count(*) FROM tbluser WHERE login = ?";
                        using (OleDbCommand cmd = new OleDbCommand(strins, con))
                        {
                            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = userloginTextBox.Text;
                            int countid = new int();
                            using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                            {
                                con.Open();
                                countid = (Int32)cmd.ExecuteScalar();
                                con.Close();
                            }
                            if(countid != 0)
                            {
                                msgbox mb2 = new msgbox("That Login already exists. Please select another.", "Duplicate Login");
                                mb2.ShowDialog();
                                return;
                            }
                        }
                        
                    }

                                msgbox mb = new msgbox("All boxes must be filled prior to saving.", "Fields Required");
                    mb.ShowDialog();
                    return;
                }

                //runsql


                try
                {
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        string strins = "INSERT INTO tbluser (userfirstname,userlastname,userlogin,userpass,userjobid) VALUES (?,?,?,?,?)";
                        using (OleDbCommand cmd = new OleDbCommand(strins, con))
                        {
                            using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                            {
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = userfirstnameTextBox.Text;
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = userlastnameTextBox.Text;
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = userloginTextBox.Text;
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = userpassTextBox.Text;
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = Convert.ToInt32(cmbjob.SelectedIndex) + 1;

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
                if (userfirstnameTextBox.Text.Trim() == string.Empty || userlastnameTextBox.Text.Trim() == string.Empty || userloginTextBox.Text.Trim() == string.Empty || cmbjob.SelectedIndex == -1)
                {
                    msgbox mb = new msgbox("All boxes must be filled prior to saving.", "Fields Required");
                    mb.ShowDialog();
                    return;
                }
                this.Validate();
                this.tbluserBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(this.webbitdbdataset);
            }

            
                    

                    _owner.PerformRefresh();
            DialogResult = DialogResult.Cancel;
                    //this.Close();
                    //this.Dispose();
                
                
            
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void userloginTextBox_Leave(object sender, EventArgs e)
        {
            string loginup = userloginTextBox.Text.ToUpper();
            userloginTextBox.Text = loginup;
            
        }
        private void MakeOnlyCurrentRowVisible()
        {
            for (int i = 0; i < dataGridjob.Rows.Count; i++)
            {
                if (dataGridjob.CurrentRow != dataGridjob.Rows[i])
                    dataGridjob.Rows[i].Visible = false;
            }
        }

        private void userfirstnameTextBox_Leave(object sender, EventArgs e)
        {
            string firstn = userfirstnameTextBox.Text;
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            firstn = textInfo.ToTitleCase(firstn);
            userfirstnameTextBox.Text = firstn;
        }

        private void userlastnameTextBox_Leave(object sender, EventArgs e)
        {
            string firstn = userlastnameTextBox.Text;
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            firstn = textInfo.ToTitleCase(firstn);
            userlastnameTextBox.Text = firstn;
        }

        private void userloginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (userloginTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(userloginTextBox, "This cannot be blank");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void userfirstnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (userfirstnameTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(userfirstnameTextBox, "This cannot be blank");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void userlastnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (userlastnameTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(userlastnameTextBox, "This cannot be blank");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void frmuser_Paint(object sender, PaintEventArgs e)
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
    }
}

