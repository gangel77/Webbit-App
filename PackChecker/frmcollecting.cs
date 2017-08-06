using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;




namespace PackChecker
{
    public partial class frmcollecting : Form
    {
        string answer = null;
        string origpickup = "Patient";
        int jakesadouche = 0;
        public frmcollecting(string pxid)
        {
            
            InitializeComponent();
            lblusername.Text = "User: " + User.curusername;
            
            lblpxid.Text = pxid;
        }

        private void frmchecking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websterdbDataSet.tblpack' table. You can move, or remove it, as needed.
            this.tblpackTableAdapter.Fill(this.websterdbDataSet.tblpack);

            //Datagridview

            {
                OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                string strpatient = @"SELECT tblpatient.patientid, tblpatient.pxfirstname & ' ' & tblpatient.pxlastname
        AS pxname, tblcycle.cycledescription, tblpatient.packscollect, tblpacklocation.locationname, tblpacklocation.warning, tblpacklocation2.locationname 
FROM tblpacklocation AS tblpacklocation2 RIGHT JOIN(tblcycle INNER JOIN (tblpacklocation INNER JOIN tblpatient ON tblpacklocation.locationid = 
tblpatient.packlocation) ON tblcycle.cycleid = tblpatient.cycleid) ON tblpacklocation2.locationid = tblpatient.secondarypacklocation WHERE tblpatient.patientid = ?;";

                OleDbDataAdapter adapt = new OleDbDataAdapter();

                OleDbCommand cmdpx = new OleDbCommand(strpatient, con);
                cmdpx.Parameters.Add("?", OleDbType.Integer, 9).Value = lblpxid.Text;

                con.Open();
                OleDbDataReader reader;
                reader = cmdpx.ExecuteReader();

                reader.Read();

                string patientname = reader["pxname"].ToString();
                string location1 = reader["tblpacklocation.locationname"].ToString();
                string location2 = reader["tblpacklocation2.locationname"].ToString();
                string packsget = reader["packscollect"].ToString();
                string cycledesc = reader["cycledescription"].ToString();
                string loc1warn = reader["warning"].ToString();
                reader.Close();
                con.Close();
                lblpatientname.Text = patientname;
                lblloc1.Text = location1;
                lblloc2.Text = location2;
                lblwarning.Text = loc1warn;
                Updatelocation();


                lblpackscollect.Text = "This patient receives " + packsget + " packs each collection";

                string sqlcollect = @"SELECT TOP 10 tblpatient.patientid, tblpack.collectdate, tblpatient.pxfirstname & ' ' & tblpatient.pxlastname AS pxname, tblpack.receivedby, tbluser.userfirstname AS collectuser, tblpatient.packscollect, tblpacklocation.locationname, tblcycle.cycledescription, tblpack.cycledate, IIf(IsNull([tblpack].[packeduser]),0,-1) AS checkpack, IIf(IsNull([tblpack].[checkeduser]),0,-1) AS checkcheck, tblpack.packid, tblpack.active, tblpack.patientnote
FROM tbluser RIGHT JOIN ((tblpacklocation INNER JOIN (tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid) ON tblpacklocation.locationid = tblpatient.packlocation) INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid) ON tbluser.userid = tblpack.collectuser
WHERE (((tblpack.active)=True)) AND tblpatient.patientid = ? AND tblpack.packeduser IS NOT NULL
ORDER BY tblpack.cycledate DESC;";

                OleDbDataAdapter dataadapter = new OleDbDataAdapter();
                OleDbCommand cmd = new OleDbCommand(sqlcollect, con);

                cmd.Parameters.Add("?", OleDbType.Integer, 9).Value = lblpxid.Text;

                dataadapter.SelectCommand = cmd;

                DataSet ds = new DataSet();
                con.Open();
                dataadapter.Fill(ds, "tableData");
                con.Close();
                dataGridcollect.AutoGenerateColumns = false;

                //dataGridChecked.ColumnCount = 7;

                packid.DataPropertyName = "packid";

                clnCycleDate.DataPropertyName = "cycledate";

                clnpatientnote.DataPropertyName = "patientnote";

                clngivenoutby.DataPropertyName = "collectuser";

                clnchecked.DataPropertyName = "checkcheck";

                clnpacked.DataPropertyName = "checkpack";

                clncollectedby.DataPropertyName = "receivedby";

                clncollectdate.DataPropertyName = "collectdate";


                //clnCollect.Text = "Collect";
                // clnCollect.FlatStyle = FlatStyle.Popup;
                //clnCollect.UseColumnTextForButtonValue = true;


                //clnreversecheck.Text = "Reverse";
                //clnreversecheck.FlatStyle = FlatStyle.Popup;
               // clnreversecheck.UseColumnTextForButtonValue = true;


                dataGridcollect.DataSource = ds;
                dataGridcollect.DataMember = "tableData";


                // The width of column 0 is 22.
                // Instead of fixed 25, you could use `columnwidth + 1` also.

                foreach (DataGridViewRow row in dataGridcollect.Rows)
                {
                    if (row.Cells["clngivenoutby"].Value.ToString() != "")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        dataGridcollect[row.Cells["clncollect"].ColumnIndex, row.Index].Style.Padding = new Padding(100, 0, 0, 0);
                    }
                    else
                    {
                        dataGridcollect[row.Cells["clnreversecheck"].ColumnIndex, row.Index].Style.Padding = new Padding(100, 0, 0, 0);
                    }
                }
                

            }
        }
             
        private void dataGridChecked_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    if (e.RowIndex >= 0)
                    {

                        //Figure out which button we jsut pressed
                        DataGridViewColumn col = this.dataGridcollect.Columns[e.ColumnIndex];

                        //IF we are in the Collect column , do this
                        if (col.Name.Equals("clnCollect"))
                        {
                            DataGridViewRow row = this.dataGridcollect.Rows[e.RowIndex];
                            //string input = Interaction.InputBox("Who picked up the packs", "Received By", "Patient", -1, -1);
                            string collectedby = row.Cells["clnpatientnote"].Value.ToString();
                            bool checkedval = Convert.ToBoolean(row.Cells["clnchecked"].Value);
                            string collectuser = row.Cells["clngivenoutby"].Value.ToString();
                           

                            if (checkedval == false)
                            {
                                msgbox msgbox = new msgbox("You can't give this out, it isn't checked!", "Error marking as Collected!");
                                msgbox.ShowDialog();
                                return;
                            }

                            

                            if (!string.IsNullOrEmpty(collectuser))
                            {
                                DateTime collectdate = Convert.ToDateTime(row.Cells["clncollectdate"].Value.ToString());
                                msgbox msgbox = new msgbox("This was already given out on: " + Environment.NewLine + String.Format("{0:ddd, MMM d, yyyy}", collectdate) + " at " + String.Format("{0:t}", collectdate), "Can't give out twice");
                                msgbox.ShowDialog();
                                return;
                                //MessageBox.Show("no comment");
                            }

                            if (!string.IsNullOrEmpty(row.Cells["clnpatientnote"].Value.ToString()))
                            {
                                msgbox msgbox = new msgbox("\"" + row.Cells["clnpatientnote"].Value.ToString() + "\" - " + User.curusername, "Important note to patient");
                                msgbox.ShowDialog();
                                
                            }



                            
                            inputbox inputbox = new inputbox("Who picked up the packs", "Received By", origpickup);
                            if (jakesadouche != 1)
                            {

                            if (inputbox.ShowDialog() == DialogResult.OK)
                            {
                                //MessageBox.Show(inputbox.answer);
                                answer = inputbox.answer;
                                jakesadouche = 1;

                            }
                            else
                            {
                                    return;

                            }
                            }




                            string packid = row.Cells["packid"].Value.ToString();

                            //MessageBox.Show(packid);
                            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

                            string strchecked = "UPDATE tblpack SET collectuser = ?, collectdate = ?, receivedby = ? WHERE packid = ?";

                            OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                            OleDbCommand sqlcom = new OleDbCommand(strchecked, con);

                            sqlcom.Parameters.Add("?", OleDbType.Integer, 3).Value = User.curuserid;
                            sqlcom.Parameters.Add("?", OleDbType.Date, 5).Value = DateTime.Now;
                            sqlcom.Parameters.Add("?", OleDbType.VarWChar, 15).Value = answer;
                            sqlcom.Parameters.Add("?", OleDbType.Integer, 9).Value = packid;

                            dataadapter.SelectCommand = sqlcom;

                            con.Open();

                            sqlcom.ExecuteNonQuery();
                            row.Cells["clngivenoutby"].Value = User.curusername;
                            row.Cells["clncollectedby"].Value = answer;
                            row.Cells["clncollectdate"].Value = DateTime.Now;
                            con.Close();
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            dataGridcollect[row.Cells["clncollect"].ColumnIndex, row.Index].Style.Padding = new Padding(100, 0, 0, 0);
                            dataGridcollect[row.Cells["clnreversecheck"].ColumnIndex, row.Index].Style.Padding = new Padding(0, 0, 0, 0);

                        }

                        //If col is Reverse pack button
                        if (col.Name.Equals("clnreversecheck"))
                        {
                            DataGridViewRow row = this.dataGridcollect.Rows[e.RowIndex];
                            DateTime curcoldate = DateTime.Now;
                            try
                            {
                                curcoldate = DateTime.Parse(row.Cells["clncollectdate"].Value.ToString());
                            }
                            catch
                            {
                                return;
                            }
                            
                            if (string.IsNullOrWhiteSpace(curcoldate.ToString()) || curcoldate == DateTime.MinValue)
                                {
                                return;
                                }
                            //MessageBox.Show(curcoldate.ToString());
                            //MessageBox.Show(DateTime.Now.AddDays(-1).ToString());
                            if (curcoldate < DateTime.Now.AddDays(-1)) 
                            {
                                yesnobox yn = new yesnobox("Are you sure you want to clear a collection from over a day ago!?","Double check clear");
                                if (yn.ShowDialog() == DialogResult.No)
                                {
                                    return;
                                }
                            }

                            string packid = row.Cells["packid"].Value.ToString();

                            string strcheckrev = "UPDATE tblpack SET collectuser = NULL, collectdate = NULL, receivedby =NULL WHERE packid= ?";
                            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

                            OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                            OleDbCommand sqlcom = new OleDbCommand(strcheckrev, con);
                            sqlcom.Parameters.Add("?", OleDbType.Integer, 9).Value = packid;

                            dataadapter.SelectCommand = sqlcom;

                            con.Open();

                            sqlcom.ExecuteNonQuery();
                            row.Cells["clngivenoutby"].Value = "";
                            row.Cells["clncollectedby"].Value = "";
                            row.Cells["clncollectdate"].Value = "";
                            con.Close();
                            row.DefaultCellStyle.BackColor = Color.White;
                            dataGridcollect[row.Cells["clncollect"].ColumnIndex, row.Index].Style.Padding = new Padding(0, 0, 0, 0);
                            dataGridcollect[row.Cells["clnreversecheck"].ColumnIndex, row.Index].Style.Padding = new Padding(100, 0, 0, 0);

                        }
                        
                    }
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        

        private void Updatelocation()
        {
            string loc = lblloc1.Text;
            if (!string.IsNullOrWhiteSpace(lblloc2.Text))
            {
                pnlloc2.Visible = true;
                lblpklocation.Text = "Pack Locations";
                if (lblloc2.Text.Equals("Fridge"))
                {
                    pnlloc2.BackColor = Color.RoyalBlue;
                    pnlloc2.ForeColor = Color.White;
                }
                
                if (lblloc2.Text.Equals("Safe"))
                {
                    pnlloc2.BackColor = Color.Firebrick;
                    pnlloc2.ForeColor = Color.White;
                }
               
                
            }

            if (loc.Equals("Fridge"))
            {
                pnlloc1.BackColor = Color.RoyalBlue;
                pnlloc1.ForeColor = Color.White;
            }

            if (loc.Equals("Safe"))
            {
                pnlloc1.BackColor = Color.Firebrick;
                pnlloc1.ForeColor = Color.White;
            }

            if (!string.IsNullOrWhiteSpace(lblloc2.Text))
            {
                msgbox mb1 = new msgbox("Patient has packs in two locations:" + Environment.NewLine + loc + Environment.NewLine + lblloc2.Text, "Pack Location");
                mb1.ShowDialog();


            }else
            {
                if (lblwarning.Text.Equals("True"))
                {
                    msgbox mb = new msgbox("Packs in " + loc, "Pack Location");
                    mb.ShowDialog();

                }
            }
           
            
        }

       

        private void btnshownonpacked_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            string sqlcollect = @"SELECT tblpatient.patientid, tblpack.collectdate, tblpatient.pxfirstname & ' ' & tblpatient.pxlastname AS pxname, tblpack.receivedby, tbluser.userfirstname AS collectuser, tblpatient.packscollect, tblpacklocation.locationname, tblcycle.cycledescription, tblpack.cycledate, IIf(IsNull([tblpack].[packeduser]),0,-1) AS checkpack, IIf(IsNull([tblpack].[checkeduser]),0,-1) AS checkcheck, tblpack.packid, tblpack.active, tblpack.patientnote
FROM tbluser RIGHT JOIN ((tblpacklocation INNER JOIN (tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid) ON tblpacklocation.locationid = tblpatient.packlocation) INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid) ON tbluser.userid = tblpack.collectuser
WHERE (((tblpack.active)=True)) AND tblpatient.patientid = ?
ORDER BY tblpack.cycledate DESC;";

            OleDbDataAdapter dataadapter = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand(sqlcollect, con);

            cmd.Parameters.Add("?", OleDbType.Integer, 9).Value = lblpxid.Text;

            dataadapter.SelectCommand = cmd;

            DataSet ds = new DataSet();
            con.Open();
            dataadapter.Fill(ds, "tableData");
            con.Close();
            

            dataGridcollect.DataSource = ds;
            dataGridcollect.DataMember = "tableData";
        }

        private void dataGridcollect_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridViewColumn col = this.dataGridcollect.Columns[e.ColumnIndex];


            if (e.RowIndex < 0)
                return;

            //Assign tick to column
            if (col.Name.Equals("clnCollect") && e.CellStyle.BackColor != Color.LightGreen)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.tick.Width;
                var h = Properties.Resources.tick.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.tick, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            //Assign undo to cell if pack is packed
            if (col.Name.Equals("clnreversecheck") && e.CellStyle.BackColor == Color.LightGreen)
            {
                //
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.undo.Width;
                var h = Properties.Resources.undo.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.undo, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
