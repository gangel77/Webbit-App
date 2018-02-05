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
    public partial class frmcasualpatient : Form, IWorker
    {
        string action;
        int editpxid;
        public frmcasualpatient(string _action, int _editpxid)
        {
            InitializeComponent();
            action = _action;
            editpxid = _editpxid;
        }

        private void frmcasualpatient_Paint(object sender, PaintEventArgs e)
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

        private void casualpxBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.casualpxBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.webbitdbdataset);

        }

        private void frmcasualpatient_Load(object sender, EventArgs e)
        {
            if(action != "add")
            { 
                this.tblpatientTableAdapter.Fill(this.webbitdbdataset.tblpatient);
                casualpxBindingSource.Position = this.casualpxBindingSource.Find("patientid", editpxid);
            }
            
            
            // TODO: This line of code loads data into the 'webbitdbdataset2.tblcycle' table. You can move, or remove it, as needed.
            this.tblcycleTableAdapter.Fill(this.webbitdbdataset.tblcycle);
            // TODO: This line of code loads data into the 'webbitdbdataset.tblpacklocation' table. You can move, or remove it, as needed.
            this.tblpacklocationTableAdapter.Fill(this.webbitdbdataset.tblpacklocation);

            //this.casualpxTableAdapter.Fill(this.webbitdbdataset.casualpx);

           
            this.tblpacksizeTableAdapter.Fill(this.webbitdbdataset.tblpacksize);
            updatepacktocollect();
            ActiveControl = pxfirstnameTextBox;
            

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
                if (pxfirstnameTextBox.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(pxfirstnameTextBox, "This cannot be blank");
                return;
                }
                else
                {
                    errorProvider1.Clear();
                }

            if (pxlastnameTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(pxlastnameTextBox, "This cannot be blank");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (packscollectTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(pxfirstnameTextBox, "This cannot be blank");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }



            int pxid = new int();
            if (action == "add")
            {
                string uppx = @"INSERT INTO tblpatient (pxfirstname, pxlastname, phonenumber, repatnumber, active, concessionnumber, cycleid, packscollect, traysize, packlocation, signingsheet, over5med, casual, casualcommunity)
                                    VALUES (StrConv(?,3), StrConv(?,3),?,?,?,?,?,?,?,?,?,?,true,?)";
                string getid = "Select @@Identity";

                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbDataAdapter dataadapter = new OleDbDataAdapter())
                    {
                        using (OleDbCommand sqlcom2 = new OleDbCommand(uppx, con))
                        {
                            
                            con.Open();

                            sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = pxfirstnameTextBox.Text;
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = pxlastnameTextBox.Text;
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = phonenumberTextBox.Text;
                                
                                if (string.IsNullOrEmpty(repatnumberTextBox.Text))
                                {
                                    sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = "";
                                }
                                else
                                {
                                    sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = repatnumberTextBox.Text;
                                }

                                sqlcom2.Parameters.Add("?", OleDbType.Boolean).Value = true;

                            if (string.IsNullOrEmpty(concessionnumberTextBox.Text))
                            {
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = DBNull.Value;
                            }
                            else
                            {
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = concessionnumberTextBox.Text;
                            }

                            sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(cmbCycle.SelectedValue);
                                sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(packscollectTextBox.Text);
                            
                                sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(cmbtraysize.SelectedValue);
                                sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(cmblocation.SelectedValue);
                            
                                sqlcom2.Parameters.Add("?", OleDbType.Boolean).Value = Convert.ToBoolean(signingsheetCheckBox.Checked);
                                sqlcom2.Parameters.Add("?", OleDbType.Boolean).Value = Convert.ToBoolean(over5medCheckBox.Checked);
                            sqlcom2.Parameters.Add("?", OleDbType.Boolean).Value = Convert.ToBoolean(casualcommunityCheckBox.Checked);

                            sqlcom2.ExecuteNonQuery();
                            sqlcom2.CommandText = getid;
                            pxid = (int)sqlcom2.ExecuteScalar();
                            
                            con.Close();
                            
                            
                            using (msgbox mb = new msgbox("Casual Patient added to Webbit.", "Patients Added"))
                            {
                                mb.ShowDialog();

                            }
                        }
                    }
                }
                using (yesnobox yn = new yesnobox("Would you like to create packs for this patient now?", "check yn"))
                {
                    if(yn.ShowDialog() == DialogResult.Yes)
                    {
                        int pass = Utility.userreq("pack");
                        if (pass == 0)
                        {
                            return;
                        }
                        Utility.futurepacks<frmcasualpatient>(sender, e, Convert.ToInt32(pxid));
                    }
                }

            }
            else
            {

                this.Validate();
                this.casualpxBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.webbitdbdataset);
            }
            DialogResult = DialogResult.Cancel;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void pxfirstnameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            gotonext(e);

        }

        private static void gotonext(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatepacktocollect();
            SendKeys.Send("{TAB}");
        }

        private void updatepacktocollect()
        {
            int cycleid = Convert.ToInt32(cmbCycle.SelectedValue);
            int packs = new int();
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {



                string strpatient = @"SELECT tblcycle.cycleid, tblcycle.cycleweeks, tblcycle.cyclepacks
                                                FROM tblcycle WHERE cycleid = ?;";

                using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                {

                    using (OleDbCommand cmdpx = new OleDbCommand(strpatient, con))
                    {
                        cmdpx.Parameters.Add("?", OleDbType.Integer, 9).Value = cycleid;

                        con.Open();
                        OleDbDataReader reader;
                        reader = cmdpx.ExecuteReader();

                        while (reader.Read())
                        {
                            //string weeks = reader["cycleweeks"].ToString();
                            packs = Convert.ToInt32(reader["cyclepacks"]);

                        }
                    }
                }
                con.Close();
                packscollectTextBox.Text = packs.ToString();
            }
        }

        private void cmbtraysize_SelectedValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void cmblocation_SelectedValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        FrmSplash splashy;
        string splashtext;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            splashy = new FrmSplash();
            splashy.SetStatus(splashtext);
            splashy.ShowDialog();

        }
        public void startplash(string starttext)
        {
            if (!backgroundWorker1.IsBusy)
            {
                splashtext = starttext;
                backgroundWorker1.RunWorkerAsync();
            }

        }
        public void updatesplash(string updatetext)
        {
            splashy.InvokeBy(() =>
            {
                splashy.SetStatus(updatetext);
            }
                        );
        }
        public void stopsplash()
        {
            splashy.InvokeBy(() =>
            {
                splashy.Close();
            }
                        );

            backgroundWorker1.CancelAsync();
        }
    }
}
    

