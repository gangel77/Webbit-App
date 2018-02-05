using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Threading;





namespace PackChecker
{

    public partial class frmpatientlistadd : Form
    {
        DataTable dtLotsImport = new DataTable();
        bool compx = new bool();
        int newinstid = new int();
        string instname;
        string splashtext;
        public frmpatientlistadd(DataTable importdt, bool compxcheck, int instid, string impinstname)
        {

            InitializeComponent();
            dataGridpatients.CellValueChanged += new DataGridViewCellEventHandler(dataGridpatients_CellValueChanged);
            dataGridpatients.CurrentCellDirtyStateChanged += new EventHandler(dataGridpatients_CurrentCellDirtyStateChanged);
            dataGridpatients.EnableHeadersVisualStyles = false;
            dtLotsImport = importdt;
            compx = compxcheck;
            newinstid = instid;
            instname = impinstname;

        }

        private void frmpatientlist_Load(object sender, EventArgs e)
        {
            
            startplash("Building List...");

            // TODO: This line of code loads data into the 'webbitdbdataset.tblpacklocation' table. You can move, or remove it, as needed.
            this.tblpacklocationTableAdapter.Fill(this.webbitdbdataset.tblpacklocation);
            // TODO: This line of code loads data into the 'webbitdbdataset.tblcycle' table. You can move, or remove it, as needed.
            this.tblcycleTableAdapter.Fill(this.webbitdbdataset.tblcycle);
            // TODO: This line of code loads data into the 'webbitdbdataset.tblpacksize' table. You can move, or remove it, as needed.
            this.tblpacksizeTableAdapter.Fill(this.webbitdbdataset.tblpacksize);
            cmbcycle.SelectedIndex = -1;
            cmblocation.SelectedIndex = -1;
            cmbsize.SelectedIndex = -1;
            lbltitle.Text = "My Patients - " + instname;
            //dataGridpatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            try
            {
                dataGridpatients.AutoGenerateColumns = false;
                dataGridpatients.ClearSelection();
                //ALLOCATE COLUMNS TO DATA
                
                clnfirstname.DataPropertyName = "FirstName";
                clndispenseid.DataPropertyName = "PersonID";
                clnlastname.DataPropertyName = "LastName";
                clnaddress.DataPropertyName = "Address";
                clnsuburb.DataPropertyName = "Suburb";
                clnpostcode.DataPropertyName = "PostCode";
                clnphonenumber.DataPropertyName = "PhoneNumber";
                clnmedicare.DataPropertyName = "MedicareNo";
                clnrepatid.DataPropertyName = "VACardID";
                clninstitutionname.DataPropertyName = "institutionname";
                clninstitutionid.DataPropertyName = "InstitutionID";
                clnconcession.DataPropertyName = "EntitlementC";
                dataGridpatients.DataSource = dtLotsImport;





            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }


            foreach (DataGridViewRow row in dataGridpatients.Rows)
            {
                row.Cells["clnclear"].Style.Padding = new Padding(100, 0, 0, 0);
                row.Cells["cln5meds"].Value = -1;
            }

            stopsplash();
            using (msgbox mb = new msgbox("Loading Institution '" + instname + "'", "No websters selected"))
            {
                mb.ShowDialog();
            }

            
        }




        private void dataGridPacked_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            {

                DataGridViewRow row = this.dataGridpatients.Rows[e.RowIndex];
                MessageBox.Show(row.Cells["clnlocation1"].Value.ToString());

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here

                    if (e.RowIndex >= 0)
                    {
                        //Figure out which button we jsut pressed
                        DataGridViewColumn col = this.dataGridpatients.Columns[e.ColumnIndex];

                        //IF we are in the Column PACKCOMMENT, do this
                        if (col.Name.Equals("clnPackComment"))
                        {


                            //DataGridViewRow row = this.dataGridpatients.Rows[e.RowIndex];
                            string packid = row.Cells["packid"].Value.ToString();
                            string cellvalue = row.Cells["clnPackComment"].Value.ToString();
                            //string input = Interaction.InputBox("Enter new message here", "Pack Comment", cellvalue, -1, -1);
                            inputbox inputbox = new inputbox("Enter new message here", "Pack Comment", cellvalue);
                            string answer = null;
                            if (inputbox.ShowDialog() == DialogResult.OK)
                            {
                                //MessageBox.Show(inputbox.answer);
                                answer = inputbox.answer;

                            }
                            else
                            {
                                return;
                            }


                            string strpcom = "UPDATE tblpack SET packcomment = ? WHERE packid= ?";
                            try
                            {
                                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                {
                                    using (OleDbCommand sqlcom = new OleDbCommand(strpcom, con))
                                    {

                                        using (OleDbDataAdapter dadapter = new OleDbDataAdapter())
                                        {

                                            string userbrack = null;

                                            if (!string.IsNullOrWhiteSpace(answer))
                                            {
                                                userbrack = " (" + User.curuserlogin + ")";
                                            }

                                            sqlcom.Parameters.Add("?", OleDbType.VarChar, 30).Value = answer + userbrack;
                                            sqlcom.Parameters.Add("?", OleDbType.Integer).Value = packid;

                                            dadapter.SelectCommand = sqlcom;

                                            con.Open();

                                            sqlcom.ExecuteNonQuery();
                                            row.Cells["clnPackComment"].Value = answer;
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



                    }
                }
            }

        }

        private void dataGridpatients_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            {
                bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
                var datagridview = sender as DataGridView;

                // Check to make sure the cell clicked is the cell containing the combobox 
                if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
                {
                    datagridview.BeginEdit(true);
                    ((ComboBox)datagridview.EditingControl).DroppedDown = true;
                }
            }
        }





        private void dataGridpatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {

                    //Figure out which button we jsut pressed
                    DataGridViewColumn col = this.dataGridpatients.Columns[e.ColumnIndex];

                    //IF we are in the Column pack, do this
                    if (col.Name.Equals("clnclear"))
                    {
                        DataGridViewRow row = this.dataGridpatients.Rows[e.RowIndex];

                        row.Cells["clnlocation2"].Value = DBNull.Value;
                        row.Cells["clnclear"].Style.Padding = new Padding(100, 0, 0, 0);

                    }


                }

            }


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridpatients.Rows[e.RowIndex];

                if(Convert.ToBoolean(row.Cells["clnselected"].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(171, 206, 178);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }


                

            }
        }

        private void dataGridpatients_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            DataGridViewColumn col = this.dataGridpatients.Columns[e.ColumnIndex];

            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = this.dataGridpatients.Rows[e.RowIndex];
            //Assign tick to column
            if (col.Name.Equals("clnclear") && !string.IsNullOrWhiteSpace(row.Cells["clnlocation2"].FormattedValue.ToString()))
            {
                //MessageBox.Show(col.DefaultCellStyle.Padding.Right.ToString());
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = dataGridpatients.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.cross, new Rectangle(x, y, w, h));
                e.Handled = true;
            }



        }

        private void dataGridpatients_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridpatients.CurrentCell is DataGridViewComboBoxCell || dataGridpatients.CurrentCell is DataGridViewCheckBoxCell)
            {
                dataGridpatients.CommitEdit(DataGridViewDataErrorContexts.Commit);
                dataGridpatients.EndEdit();
            }

            if (dataGridpatients.CurrentCell.OwningColumn == clncycletype)
            {
                DataGridViewRow row = this.dataGridpatients.Rows[dataGridpatients.CurrentCell.RowIndex];
                int cycleid = Convert.ToInt32(row.Cells["clncycletype"].Value);
                int packs = 2;
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
                    row.Cells["clnpackscollect"].Value = packs;
                }

                // This fires the cell value changed handler below
                // dataGridpatients.CommitEdit(DataGridViewDataErrorContexts.Commit);

            }
        }

        private void dataGridpatients_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {

            
            DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridpatients.Rows[e.RowIndex].Cells["clnlocation2"];
            if (cb.Value != null && cb.Value != DBNull.Value)
            {
                MessageBox.Show(cb.Value.ToString());

               
                    DataGridViewRow row = this.dataGridpatients.Rows[e.RowIndex];
                    row.Cells["clnclear"].Style.Padding = new Padding(0, 0, 0, 0);


                    dataGridpatients.Invalidate();
                
            }
            }
        }

        private void dataGridpatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn col = this.dataGridpatients.Columns[e.ColumnIndex];

            if (col.Name.Equals("clnfirstname") || col.Name.Equals("clnlastname") || col.Name.Equals("clnpxcomment"))
            {
                dataGridpatients.BeginEdit(true);
            }
        }

        private void dataGridpatients_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewColumn col = this.dataGridpatients.Columns[e.ColumnIndex];
            if (e.RowIndex > 0)
            {
                if (col.Name.Equals("clnlastname") || col.Name.Equals("clnfirstname") || col.Name.Equals("clnpxcomment"))
                {
                    dataGridpatients.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.ForestGreen;
                }
            }
        }

        private void dataGridpatients_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn col = this.dataGridpatients.Columns[e.ColumnIndex];
            if (e.RowIndex > 0)
            {
                if (col.Name.Equals("clnlastname") || col.Name.Equals("clnfirstname") || col.Name.Equals("clnpxcomment"))
                {
                    dataGridpatients.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            using (yesnobox yn = new yesnobox("This will NOT save any of these patients to Webbit. Are you sure? (You can add this group later if needed) ", "Skipping group"))
            {
                if(yn.ShowDialog()==DialogResult.No)
                {
                    return;
                }
            }
            this.Close();
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            startplash("Checking details are completed");
            dataGridpatients.CommitEdit(DataGridViewDataErrorContexts.Commit);
            dataGridpatients.EndEdit();
            

            foreach (DataGridViewRow row in dataGridpatients.Rows)
            {//Change checkboxes to false if they are null
                if (row.Cells["clndelivery"].Value == null)
                {
                    row.Cells["clndelivery"].Value = false;
                }
                if (row.Cells["clnsigningsheet"].Value == null)
                {
                    row.Cells["clnsigningsheet"].Value = false;
                }
                //Validate all responses.
                if (string.IsNullOrWhiteSpace(row.Cells["clncycletype"].FormattedValue.ToString()))
                {
                    using (msgbox mb = new msgbox("Cycle for " + row.Cells["clnfirstname"].Value.ToString() + " " + row.Cells["clnlastname"].Value.ToString() + " has not been set.", "Missing Data"))
                    {
                        mb.ShowDialog();
                        stopsplash();
                        return;
                    }
                }

                if (string.IsNullOrWhiteSpace(row.Cells["clnlocation1"].FormattedValue.ToString()))
                {
                    using (msgbox mb = new msgbox("Location for " + row.Cells["clnfirstname"].Value.ToString() + " " + row.Cells["clnlastname"].Value.ToString() + " has not been set.", "Missing Data"))
                    {
                        mb.ShowDialog();
                        stopsplash();
                        return;
                    }
                }


                if (string.IsNullOrWhiteSpace(row.Cells["clnpacksize"].FormattedValue.ToString()))
                {
                    using (msgbox mb = new msgbox("Pack Size for " + row.Cells["clnfirstname"].Value.ToString() + " " + row.Cells["clnlastname"].Value.ToString() + " has not been set.", "Missing Data"))
                    {
                        mb.ShowDialog();
                        stopsplash();
                        return;
                    }
                }
                int notint;
                bool checkcollect = int.TryParse(row.Cells["clnpackscollect"].ToString(), out notint);
                if (checkcollect == true || string.IsNullOrWhiteSpace(row.Cells["clnpackscollect"].FormattedValue.ToString()))
                {
                    using (msgbox mb = new msgbox("Packs to Collect for " + row.Cells["clnfirstname"].Value.ToString() + " " + row.Cells["clnlastname"].Value.ToString() + " has not been set.", "Missing Data"))
                    {
                        mb.ShowDialog();
                        stopsplash();
                        return;
                    }
                }

            }

            if(!backgroundWorker1.IsBusy)
            {
                startplash("Adding Patients");
            }
            else
            {
                updatesplash("Adding Patients");
            }

        string strins = @"INSERT INTO tblpatient (pxfirstname, pxlastname, address, suburb, phonenumber, dispenseid, 
                                repatnumber, active, cycleid, packscollect, comment, traysize, packlocation, secondarypacklocation, institutionid, delivery, signingsheet, medicarenumber, concessionnumber,over5med) 
                                VALUES ( StrConv(?,3), StrConv(?,3), ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?,?)";

                        using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbDataAdapter dataadapter = new OleDbDataAdapter())
                    {
                        using (OleDbCommand sqlcom2 = new OleDbCommand(strins, con))
                        {
                                int i = 0;
                            con.Open();
                            foreach (DataGridViewRow row in dataGridpatients.Rows)
                            {
                                i++;
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row.Cells["clnfirstname"].Value.ToString();
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row.Cells["clnlastname"].Value.ToString();
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row.Cells["clnaddress"].Value.ToString();
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row.Cells["clnsuburb"].Value.ToString();
                            sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row.Cells["clnphonenumber"].Value.ToString();
                            sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = row.Cells["clndispenseid"].Value;


                            if (string.IsNullOrEmpty(row.Cells["clnrepatid"].FormattedValue.ToString()) || Convert.ToInt32(row.Cells["clnrepatid"].FormattedValue.ToString()) == 0)
                            {
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = "";
                            }
                            else
                            {
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row.Cells["clnrepatid"].Value;
                            }

                            sqlcom2.Parameters.Add("?", OleDbType.Boolean).Value = true;
                            sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = row.Cells["clncycletype"].Value;
                            sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = row.Cells["clnpackscollect"].Value.ToString();
                            
                            
                            if (string.IsNullOrEmpty(row.Cells["clnpxcomment"].FormattedValue.ToString()))
                            {
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = "";
                            }
                            else
                            {
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row.Cells["clnpxcomment"].Value;
                            }

                            sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = row.Cells["clnpacksize"].Value;
                            sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = row.Cells["clnlocation1"].Value;

                            if (string.IsNullOrEmpty(row.Cells["clnlocation2"].FormattedValue.ToString()))
                            {
                                sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = DBNull.Value;
                            }
                            else
                            {
                                sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = row.Cells["clnlocation2"].Value;
                            }

                            
                            sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = newinstid;
                            sqlcom2.Parameters.Add("?", OleDbType.Boolean).Value = row.Cells["clndelivery"].Value;
                            sqlcom2.Parameters.Add("?", OleDbType.Boolean).Value = row.Cells["clnsigningsheet"].Value;
                            sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row.Cells["clnmedicare"].Value.ToString();
                            
                            if (string.IsNullOrEmpty(row.Cells["clnconcession"].FormattedValue.ToString()))
                            {
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = DBNull.Value;
                            }
                            else
                            {
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row.Cells["clnconcession"].Value;
                            }
                            sqlcom2.Parameters.Add("?", OleDbType.Boolean).Value = row.Cells["cln5meds"].Value;
                            dataadapter.SelectCommand = sqlcom2;
                            


                                sqlcom2.ExecuteNonQuery();
                                sqlcom2.Parameters.Clear();
                            }
                            con.Close();
                        string s;
                        if (i > 1)
                        {
                            s = "s";
                        }else
                        {
                            s = "";
                        }
                            using (msgbox mb = new msgbox(i + " patient" + s + " added to Webbit.", "Patients Added"))
                            {
                                mb.ShowDialog();

                            }
                        stopsplash();
                        }
                    }
                }
            //}
            //catch (Exception exe)
            //{
            //    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            //}

            this.Close();
            this.Dispose();
        }

        private void dataGridpatients_SelectionChanged(object sender, EventArgs e)
        {
            dataGridpatients.ClearSelection();
        }

        private void chkselectall_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkselectall.Checked == true)
            {
                startplash("Selecting");
                foreach (DataGridViewRow row in dataGridpatients.Rows)
                {
                    row.Cells["clnselected"].Value = true;
                    row.DefaultCellStyle.BackColor = Color.FromArgb(171, 206, 178);

                }
                stopsplash();
            }
            else
            {
                startplash("Deselecting");
                foreach (DataGridViewRow row in dataGridpatients.Rows)
                {
                    row.Cells["clnselected"].Value = false;
                    row.DefaultCellStyle.BackColor = Color.White;

                }
                stopsplash();
            }
            

        }
        

        private void btnbatchupdate_Click(object sender, EventArgs e)
        {
            int countselected = 0;
            if (cmbcycle.SelectedIndex == -1 && cmblocation.SelectedIndex == -1 && cmbsize.SelectedIndex == -1 && chkDelivery.Checked == false && chkSignSheet.Checked == false)
            {
                using (msgbox mb = new msgbox("You don't have any options selected!", "Empty Drop Down Boxes"))
                {
                    mb.ShowDialog();
                    return;
                }
            }
            else
            {

                foreach (DataGridViewRow row in dataGridpatients.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["clnselected"].Value))
                    {
                        countselected++;

                    }

                }
                if (countselected == 0)
                {
                    using (msgbox mb = new msgbox("You don't have any boxes ticked!", "Now rows selected"))
                    {
                        mb.ShowDialog();
                        return;
                    }
                }

                using (yesnobox yn = new yesnobox("This will update " + countselected + " rows. Are you sure?", "Updating Rows"))
                {
                    if (yn.ShowDialog() == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            startplash("Updating patients: 0%");

            int cycle = new int();
            int location;
            int size;
                int packs = new int();
            double countupdated = new double();
            //if cycle has a value.
            if (cmbcycle.SelectedIndex != -1)
                {
                    cycle = Convert.ToInt32(cmbcycle.SelectedValue);


                    
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        string strpatient = @"SELECT tblcycle.cycleid, tblcycle.cycleweeks, tblcycle.cyclepacks
                                                FROM tblcycle WHERE cycleid = ?;";

                        using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                        {

                            using (OleDbCommand cmdpx = new OleDbCommand(strpatient, con))
                            {
                                cmdpx.Parameters.Add("?", OleDbType.Integer, 9).Value = cycle;

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
                    }


                    

                }
             int percentupdate = percentupdate = 0;
            
                foreach (DataGridViewRow rowx in dataGridpatients.Rows)
            {
               
                if (Convert.ToBoolean(rowx.Cells["clnselected"].Value))
                {
                    countupdated++;
                    if (cmbcycle.SelectedIndex != -1)
                    {
                        rowx.Cells["clncycletype"].Value = cycle;
                        rowx.Cells["clnpackscollect"].Value = packs;
                    }
                    //Thread.Sleep(15);
                    //if location has a value
                    if (cmblocation.SelectedIndex != -1)
                    {
                        location = Convert.ToInt32(cmblocation.SelectedValue);
                        rowx.Cells["clnlocation1"].Value = location;

                    }

                    if (cmbsize.SelectedIndex != -1)
                    {
                        size = Convert.ToInt32(cmbsize.SelectedValue);
                        rowx.Cells["clnpacksize"].Value = size;

                    }

                    if (chkDelivery.Checked == true)
                    {
                        rowx.Cells["clnDelivery"].Value = true;
                    }

                    if (chkSignSheet.Checked == true)
                    {
                        rowx.Cells["clnSigningSheet"].Value = true;
                    }

                    percentupdate = (int)(countupdated*100 / countselected) ;
                    updatesplash("Updating patients: " + percentupdate.ToString() + "%");
                }
            }
            updatesplash("Preparing Table");
            foreach (DataGridViewRow row in dataGridpatients.Rows)
            {
                row.Cells["clnselected"].Value = false;
                row.DefaultCellStyle.BackColor = Color.White;
            }

            cmbsize.SelectedIndex = -1;
            cmblocation.SelectedIndex = -1;
            cmbcycle.SelectedIndex = -1;
            chkDelivery.Checked = false;
            chkSignSheet.Checked = false;

            
            this.chkselectall.CheckedChanged -= new System.EventHandler(this.chkselectall_CheckedChanged);
            chkselectall.Checked = false;
            this.chkselectall.CheckedChanged += new System.EventHandler(this.chkselectall_CheckedChanged);
            stopsplash();
            //backgroundWorker1.CancelAsync();
        }

        

        private void chkallow2loc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkallow2loc.Checked == true)
            {
                clnlocation2.Visible = true;
                clnclear.Visible = true;
            }
            else
            {
                clnlocation2.Visible = false;
                clnclear.Visible = false;
            }
        }

        private void frmpatientlistadd_Paint(object sender, PaintEventArgs e)
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
        FrmSplash splashy;
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            splashy = new FrmSplash();
            splashy.SetStatus(splashtext);
            splashy.ShowDialog();
            

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //splashy.Close();
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }
        private void startplash(string starttext)
        {
            if(!backgroundWorker1.IsBusy)
            {
                splashtext = starttext;
                backgroundWorker1.RunWorkerAsync();
            }
            
        }
        private void updatesplash(string updatetext)
        {
            splashy.InvokeBy(() =>
            {
                splashy.SetStatus(updatetext);
            }
                        );
        }
        private void stopsplash()
        {
            splashy.InvokeBy(() =>
            {
                splashy.Close();
            }
                        );

            backgroundWorker1.CancelAsync();
        }
    }
    public static class MyExtensions
    {
        public static void InvokeBy(this Control ctl, MethodInvoker method)
        {
            if (ctl.InvokeRequired)
                ctl.Invoke(method);
            else method();
        }
    }

}
