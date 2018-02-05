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
using System.Data.SqlClient;
using System.Configuration;




namespace PackChecker
{
    public partial class frmimportinstitutions : Form
    {
        string _activity;
        public frmimportinstitutions(string activity)
        {
            InitializeComponent();
            _activity = activity;
        }
        int lotsinstid = new int();
        int webbitinstid = new int();
        


        private void frmimportinstitutions_Load(object sender, EventArgs e)
        {
            int countnewinst;
            
            Utility.import_institutions(out countnewinst);

            
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                string strinst = "SELECT * FROM tblinstitution";
                using (OleDbDataAdapter dataadapter = new OleDbDataAdapter(strinst, con))
                {


                    using (DataSet ds = new DataSet())
                    {
                        con.Open();
                        dataadapter.Fill(ds, "tableData");
                        con.Close();
                        dataGridInst.AutoGenerateColumns = false;


                        //ALLOCATE COLUMNS TO DATA
                        clninstid.DataPropertyName = "institutionid";
                        clninstiname.DataPropertyName = "institutionname";
                        clndispinstid.DataPropertyName = "dispenseinstid";
                        chkcommunity.DataPropertyName = "iscommunity";
                        chkimport.DataPropertyName = "iswebster";
                        dataGridInst.DataSource = ds;
                        dataGridInst.DataMember = "tableData";
                    }
                }
            }





            dataGridInst.ClearSelection();

            foreach(DataGridViewRow row in dataGridInst.Rows)
            {
                DataGridViewCheckBoxCell chkcell = row.Cells["chkcommunity"] as DataGridViewCheckBoxCell;
                DataGridViewCheckBoxCell chkcell2 = row.Cells["chkimport"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chkcell.Value) == true)
                {
                    row.Cells["chkcommunity"].Style.BackColor = Color.FromArgb(129, 183, 143);
                    chkcell2.Value = true;
                }
                //}else
                //{
                //    chkcell2.Value = false;
                //}

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool iscommunity = false;
            int instid;
            string instname;
            bool iswebster = false;

            int checkchecks = 0;
            foreach (DataGridViewRow row in dataGridInst.Rows)
            {
                DataGridViewCheckBoxCell chkcell = row.Cells["chkimport"] as DataGridViewCheckBoxCell;
                if (chkcell.Value != null)
                {
                    checkchecks = 1;
                }
            }

            if (checkchecks == 0)
            {
                msgbox mb = new msgbox("No Institutions selected to connect to! Please tick at least ONE", "No websters selected");
                mb.ShowDialog();
                return;
            }
            //make sure you want to proceed
            using (yesnobox yn = new PackChecker.yesnobox("Are you sure these Institutions are correct?", "Double Checking"))
            {
                yn.Top += 50;
                int totalimport = 0;
                if (yn.ShowDialog() == DialogResult.Yes)
                {

                    using (msgbox mb = new msgbox("I'll now go through each Institution and you can select the patient preferences.", "No websters selected"))
                    {
                        mb.ShowDialog();
                    }

                    using (msgboxlarge mb = new msgboxlarge("There is a Batch Update feature on this page" + Environment.NewLine +
                                                            "You may update multiple patients at the same time " + Environment.NewLine +
                                                            "by choosing settings at the top of the page " + Environment.NewLine +
                                                            "and selecting the check box on each row or ticking 'Select All'" + Environment.NewLine + 
                                                            "then click 'Update All' to action you update.", "No websters selected"))
                    {
                        mb.ShowDialog();
                    }
                    
                    startplash("Searching for patients");
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        string upinst = "UPDATE tblinstitution SET iscommunity = ?, iswebster = ? WHERE institutionid = ?";

                        using (OleDbCommand cmd = new OleDbCommand(upinst, con))
                        {

                            foreach (DataGridViewRow row in dataGridInst.Rows)
                            {
                                instid = Convert.ToInt32(row.Cells["clninstid"].Value);
                                iscommunity = Convert.ToBoolean(row.Cells["chkcommunity"].Value);
                                iswebster = Convert.ToBoolean(row.Cells["chkimport"].Value);
                                cmd.Parameters.Add("?", OleDbType.Boolean).Value = iscommunity;
                                cmd.Parameters.Add("?", OleDbType.Boolean).Value = iswebster;
                                cmd.Parameters.Add("?", OleDbType.Integer).Value = instid;

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                cmd.Parameters.Clear();
                            }

                        }
                    }


                    //create a list of the websters & community
                    DataTable dtLotsImport = new DataTable("dtLotsImport");
                    //using (msgboxlarge mb = new msgboxlarge("There is a Batch Update feature for changing patient details." + Environment.NewLine + "You can SELECT ALL or select indiviual lines and then 'Update All' selected rows together", "No websters selected"))
                    //{
                    //    mb.ShowDialog();
                    //}
                    foreach (DataGridViewRow row2 in dataGridInst.Rows)
                    {
                        
                        DataGridViewCheckBoxCell chkcell = row2.Cells["chkimport"] as DataGridViewCheckBoxCell;
                        if (chkcell.Value != null)
                        {//Check if Cell is ticked
                            if (Convert.ToBoolean(chkcell.Value) == true)
                            {

                                lotsinstid = Convert.ToInt32(row2.Cells["clndispinstid"].Value);
                                instname = row2.Cells["clninstiname"].Value.ToString();
                                iscommunity = Convert.ToBoolean(row2.Cells["chkcommunity"].Value);
                                webbitinstid = Convert.ToInt32(row2.Cells["clninstid"].Value);

                                //Get list of all patients in that institution on dispense
                                DataTable dtLotspx = new DataTable();
                                using (SqlConnection lotscon = new SqlConnection(PackChecker.Properties.Settings.Default["LOTSConnectionString"].ToString()))
                                {
                                    using (SqlCommand cmdinst = new SqlCommand(@"SELECT * FROM Person WHERE InstitutionID = @instid ORDER BY Lastname, Firstname;", lotscon))
                                    {
                                        cmdinst.Parameters.Add("@instid", SqlDbType.Int).Value = lotsinstid;
                                        using (SqlDataAdapter instadapt = new SqlDataAdapter())
                                        {
                                            instadapt.SelectCommand = cmdinst;

                                            lotscon.Open();

                                            instadapt.Fill(dtLotspx);

                                            lotscon.Close();
                                        }
                                    }

                                }



                                //Get list of all patients in that institution on webbit
                                DataTable dtWebbitPx = new DataTable();
                                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                {
                                    using (OleDbDataAdapter instadaptweb = new OleDbDataAdapter(@"SELECT dispenseid as patientid FROM tblpatient;", con))
                                    {
                                        con.Open();

                                        instadaptweb.Fill(dtWebbitPx);

                                        con.Close();
                                    }

                                }


                                var idsNotInPx = dtLotspx.AsEnumerable().Select(r => r.Field<int>("personid"))
                            .Except(dtWebbitPx.AsEnumerable().Select(r => r.Field<int>("patientid")));
                                int count = idsNotInPx.Count();

                                if (count == 0)
                                {
                                    msgbox mb = new PackChecker.msgbox("No patients to import for - " + instname, "No new patients");
                                    mb.ShowDialog();
                                }
                                else
                                {
                                    //Find all new patients.
                                    DataTable dtOnlyLotspx = (from row in dtLotspx.AsEnumerable()
                                                          join id in idsNotInPx
                                                          on row.Field<int>("personid") equals id
                                                          where (row.Field<int>("institutionid") == lotsinstid)
                                                          select row).CopyToDataTable();


                                


                                totalimport = totalimport + count;
                                    splashy.InvokeBy(() =>
                                    {
                                        splashy.Close();
                                    }
                );
                                    using (frmpatientlistadd newpx = new frmpatientlistadd(dtOnlyLotspx, iscommunity, webbitinstid, instname))
                                    {
                                        newpx.ShowDialog();
                                    }
                                }


                                dtLotsImport.Clear();

                            }
                        }

                    }
                }
                else
                {
                    return;
                }
                
                            if (totalimport != 0)
                            {
                    
                                msgbox mb = new msgbox("Webbit will now create packs for all the imported patients.", "Creating Packs");
                                mb.ShowDialog();
                    //startplash("Creating packs...");
                                Utility.initpacks(sender, e, this.FindForm().Name, this);
                    //stopsplash();
                            }
                            else
                            {
                                msgbox mb = new msgbox("No new patients found to create packs for.", "No new patients found");
                                mb.ShowDialog();

                            }

                DialogResult = DialogResult.Cancel;


                        
                }
            }
        

        private void dataGridInst_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridInst.Rows[dataGridInst.CurrentCell.RowIndex];
            if (this.dataGridInst.CurrentCell.OwningColumn == chkcommunity && !Convert.ToBoolean(row.Cells["chkimport"].Value) && this.dataGridInst.IsCurrentCellDirty)
            {
                using (msgbox mb = new msgbox("This can only be selected if the group is ticked as DAA Group.", "Not marked as a pack group"))
                {
                    mb.ShowDialog();

                }
                this.dataGridInst.CancelEdit();
            }

            if (this.dataGridInst.IsCurrentCellDirty &&
        (this.dataGridInst.CurrentCell.OwningColumn == chkimport) || this.dataGridInst.IsCurrentCellDirty &&
        (this.dataGridInst.CurrentCell.OwningColumn == chkcommunity))
            {
                this.dataGridInst.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            //if comm tried to click, cancel if chkimport is false
            
           
        }

        private void dataGridInst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewColumn col = this.dataGridInst.Columns[e.ColumnIndex];
                DataGridViewRow row = this.dataGridInst.Rows[e.RowIndex];
                //if import selected, make websters true as well.
                if (col.Name.Equals("chkimport"))
                {
                    

                    if (Convert.ToBoolean(row.Cells["chkimport"].Value))
                    {
                        row.Cells["chkcommunity"].Style.BackColor = Color.FromArgb(129, 183, 143);
                        row.Cells["chkcommunity"].Value = 1;

                    }else
                    {
                        row.Cells["chkcommunity"].Style.BackColor = Color.White;
                        
                        row.Cells["chkcommunity"].Value = 0;
                    }

                }


                if (col.Name.Equals("chkcommunity"))
                {


                    if (Convert.ToBoolean(row.Cells["chkcommunity"].Value))
                    {
                        row.Cells["chkcommunity"].Style.BackColor = Color.FromArgb(129, 183, 143);

                    }
                    else
                    {
                        row.Cells["chkcommunity"].Style.BackColor = Color.White;
                        
                    }
                }

            }
        }
        

        private void btncancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void dataGridInst_SelectionChanged(object sender, EventArgs e)
        {
            dataGridInst.ClearSelection();
        }

        private void InstitutionNewBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frmimportinstitutions_Paint(object sender, PaintEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnwhatiscom_Click(object sender, EventArgs e)
        {
            using (msgboxlarge mb = new msgboxlarge(@"A community patient is any patient not living in a in-patients of " + Environment.NewLine +
                                                     "public or private hospitals, day hospital facilities, transitional care facilities, " + Environment.NewLine + 
                                                     "residents of an Aged Care Facility or patients in a correctional facility", "Steps"))
            {
                mb.ShowDialog();
            }
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

