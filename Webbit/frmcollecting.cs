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
        string pxid;
        public frmcollecting(string pxid_)
        {
            
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
            lblusername.Text = "User: " + User.curusername;
            
            pxid = pxid_;
            //dataGridcollect.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridcollect.EnableHeadersVisualStyles = false;
        }
       

        
        private void frmchecking_Load(object sender, EventArgs e)
        {
            
            

            {
                try
                { 
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    

                    
                    string strpatient = @"SELECT tblpatient.patientid, tblpatient.pxfirstname + ' ' + tblpatient.pxlastname
        AS pxname, tblcycle.cycledescription, tblpatient.packscollect, tblpacklocation.locationname as loc1, tblpacklocation.warning, tblpacklocation2.locationname as loc2, tblpatient.comment, tblpatient.comwarn
FROM tblpacklocation AS tblpacklocation2 RIGHT JOIN(tblcycle INNER JOIN (tblpacklocation INNER JOIN tblpatient ON tblpacklocation.locationid = 
tblpatient.packlocation) ON tblcycle.cycleid = tblpatient.cycleid) ON tblpacklocation2.locationid = tblpatient.secondarypacklocation WHERE tblpatient.patientid = ?;";

                    OleDbDataAdapter adapt = new OleDbDataAdapter();

                    OleDbCommand cmdpx = new OleDbCommand(strpatient, con);
                    cmdpx.Parameters.Add("?", OleDbType.Integer, 9).Value = pxid;

                    con.Open();
                    OleDbDataReader reader;
                    reader = cmdpx.ExecuteReader();

                    reader.Read();

                    string patientname = reader["pxname"].ToString();
                    string location1 = reader["loc1"].ToString();
                    string location2 = reader["loc2"].ToString();
                    int packsget = Convert.ToInt32(reader["packscollect"].ToString());
                    string cycledesc = reader["cycledescription"].ToString();
                    string loc1warn = reader["warning"].ToString();
                        string pxcomment = reader["comment"].ToString();
                        bool comwarn = Convert.ToBoolean(reader["comwarn"].ToString());
                        reader.Close();
                    con.Close();

                    lblpatientname.Text = patientname;
                    lblloc1.Text = location1;
                    lblloc2.Text = location2;
                    lblwarning.Text = loc1warn;
                        lblcycledes.Text = cycledesc;
                    Updatelocation();
                        string s;
                        if (packsget > 1)
                        {
                            s = "s";
                        }
                        else
                        {
                            s = "";
                        }
                        lblpackscollect.Text = "(This patient receives " + packsget + " pack" + s + " each collection)";

                        if (comwarn == true)
                        {
                            using (msgbox mb = new msgbox(pxcomment, "Warning for Patient"))
                            {
                                mb.ShowDialog();
                            }
                            
                        }
                        
                    }
                

                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                }

                try
                { 
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    string sqlcollect = @"SELECT tblpatient.patientid, tblpack.collectdate, tblpatient.pxfirstname+' '+tblpatient.pxlastname AS pxname, tblpack.receivedby, tbluser.userfirstname AS collectuser, tblpatient.packscollect, tblpacklocation.locationname, tblcycle.cycledescription, tblpack.cycledate, IIf(IsNull([tblpack].[packeduser]),0,-1) AS checkpack, IIf(IsNull([tblpack].[checkeduser]),0,-1) AS checkcheck, tblpack.packid, tblpack.active, tblpack.patientnote
FROM (tblpacklocation INNER JOIN (tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid) ON tblpacklocation.locationid = tblpatient.packlocation) INNER JOIN (tbluser RIGHT JOIN tblpack ON tbluser.userid = tblpack.collectuser) ON tblpatient.patientid = tblpack.patientid
WHERE (((tblpatient.patientid)=?) AND ((tblpack.cycledate)>DateAdd('yyyy',-1,Date())) AND ((tblpack.active)=True) AND ((tblpack.packeduser) Is Not Null) AND ((tblpack.checkeduser) Is Not Null))
ORDER BY tblpack.cycledate DESC;";

                    OleDbDataAdapter dataadapter = new OleDbDataAdapter();
                    OleDbCommand cmd = new OleDbCommand(sqlcollect, con);

                    cmd.Parameters.Add("?", OleDbType.Integer, 9).Value = pxid;

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
                }
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                }
                foreach (DataGridViewRow row in dataGridcollect.Rows)
                {
                    if (row.Cells["clngivenoutby"].Value.ToString() != "")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(129, 183, 143);
                        dataGridcollect[row.Cells["clncollect"].ColumnIndex, row.Index].Style.Padding = new Padding(100, 0, 0, 0);
                    }
                    else
                    {
                        dataGridcollect[row.Cells["clnreversecheck"].ColumnIndex, row.Index].Style.Padding = new Padding(100, 0, 0, 0);
                    }


                    if (row.Cells["clnchecked"].Value.ToString() == "False"|| row.Cells["clnpacked"].Value.ToString() == "False")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(179, 165, 177);
                    }
                   

                }
                //dataGridcollect.Columns["clnpatientnote"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

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
                                msgbox msgbox = new msgbox(row.Cells["clnpatientnote"].Value.ToString(), "Important note to patient");
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
                            try
                            { 
                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {

                                string strchecked = "UPDATE tblpack SET collectuser = ?, collectdate = ?, receivedby = ? WHERE packid = ?";

                                OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                                OleDbCommand sqlcom = new OleDbCommand(strchecked, con);

                                sqlcom.Parameters.Add("?", OleDbType.Integer, 3).Value = User.curuserid;
                                sqlcom.Parameters.Add("?", OleDbType.Date, 5).Value = DateTime.Now;
                                sqlcom.Parameters.Add("?", OleDbType.VarChar, 15).Value = answer;
                                sqlcom.Parameters.Add("?", OleDbType.Integer, 9).Value = packid;

                                dataadapter.SelectCommand = sqlcom;

                                con.Open();

                                sqlcom.ExecuteNonQuery();
                                row.Cells["clngivenoutby"].Value = User.curusername;
                                row.Cells["clncollectedby"].Value = answer;
                                row.Cells["clncollectdate"].Value = DateTime.Now;
                                con.Close();
                                row.DefaultCellStyle.BackColor = Color.FromArgb(129, 183, 143);
                                dataGridcollect[row.Cells["clncollect"].ColumnIndex, row.Index].Style.Padding = new Padding(100, 0, 0, 0);
                                dataGridcollect[row.Cells["clnreversecheck"].ColumnIndex, row.Index].Style.Padding = new Padding(0, 0, 0, 0);
                            }
                            }
                            catch (Exception exe)
                            {
                                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                            }
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
                            try
                            {

                            
                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {

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
                            }
                            }
                            catch (Exception exe)
                            {
                                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                            }
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
            DialogResult = DialogResult.Cancel;
        }

        

        private void Updatelocation()
        {
            string loc = lblloc1.Text;
            if (!string.IsNullOrWhiteSpace(lblloc2.Text))
            {
                pnlloc2.Visible = true;
                lblpklocation.Text = "Locations:";
                if (lblloc2.Text.Equals("Fridge"))
                {
                    pnlloc2.BackColor = Color.FromArgb(0, 59, 76);
                    pnlloc2.ForeColor = Color.White;
                }
                
                if (lblloc2.Text.Equals("Safe"))
                {
                    pnlloc2.BackColor = Color.FromArgb(77, 47, 72);
                    pnlloc2.ForeColor = Color.White;
                }
               
                
            }

            if (loc.Equals("Fridge"))
            {
                pnlloc1.BackColor = Color.FromArgb(0, 59, 76);
                pnlloc1.ForeColor = Color.White;
            }

            if (loc.Equals("Safe"))
            {
                pnlloc1.BackColor = Color.FromArgb(77, 47, 72); ;
                pnlloc1.ForeColor = Color.White;
            }

            if (!string.IsNullOrWhiteSpace(lblloc2.Text))
            {
                msgbox mb1 = new msgbox("Patient has packs in two locations:" + Environment.NewLine + loc + " and " + lblloc2.Text, "Pack Location");
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
            try { 
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                string sqlcollect = @"SELECT TOP 15 tblpatient.patientid, tblpack.collectdate, tblpatient.pxfirstname + ' ' + tblpatient.pxlastname AS pxname, tblpack.receivedby, tbluser.userfirstname AS collectuser, tblpatient.packscollect, tblpacklocation.locationname, tblcycle.cycledescription, tblpack.cycledate, IIf(IsNull([tblpack].[packeduser]),0,-1) AS checkpack, IIf(IsNull([tblpack].[checkeduser]),0,-1) AS checkcheck, tblpack.packid, tblpack.active, tblpack.patientnote
FROM tbluser RIGHT JOIN ((tblpacklocation INNER JOIN (tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid) ON tblpacklocation.locationid = tblpatient.packlocation) INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid) ON tbluser.userid = tblpack.collectuser
WHERE (((tblpack.active)=-1)) AND tblpatient.patientid = ?
ORDER BY tblpack.cycledate DESC;";

                OleDbDataAdapter dataadapter = new OleDbDataAdapter();
                OleDbCommand cmd = new OleDbCommand(sqlcollect, con);

                cmd.Parameters.Add("?", OleDbType.Integer, 9).Value = pxid;

                dataadapter.SelectCommand = cmd;

                DataSet ds = new DataSet();
                con.Open();
                dataadapter.Fill(ds, "tableData");
                con.Close();


                dataGridcollect.DataSource = ds;
            }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
            dataGridcollect.DataMember = "tableData";
            foreach (DataGridViewRow row in dataGridcollect.Rows)
            {
                if (row.Cells["clngivenoutby"].Value.ToString() != "")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(129, 183, 143);
                    dataGridcollect[row.Cells["clncollect"].ColumnIndex, row.Index].Style.Padding = new Padding(100, 0, 0, 0);
                }
                else
                {
                    dataGridcollect[row.Cells["clnreversecheck"].ColumnIndex, row.Index].Style.Padding = new Padding(100, 0, 0, 0);
                }
                
                if (row.Cells["clnchecked"].Value.ToString() == "0")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(146, 173, 180);
                }

                if (row.Cells["clnpacked"].Value.ToString() == "0")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(179, 165, 177);
                }
            }
            pnlkey.Visible = true;
            clnchecked.Visible = true;
            clnpacked.Visible = true;
        }

        private void dataGridcollect_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridViewColumn col = this.dataGridcollect.Columns[e.ColumnIndex];


            if (e.RowIndex < 0)
                return;

            //Assign tick to column
            if (col.Name.Equals("clnCollect") && e.CellStyle.BackColor != Color.FromArgb(129, 183, 143))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = dataGridcollect.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.tick, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            //Assign undo to cell if pack is packed
            if (col.Name.Equals("clnreversecheck") && e.CellStyle.BackColor == Color.FromArgb(129, 183, 143))
            {
                //
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                
                var w = dataGridcollect.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.undo, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dataGridcollect_SelectionChanged(object sender, EventArgs e)
        {
            dataGridcollect.ClearSelection();
        }

        private void btnmessage_Click(object sender, EventArgs e)
        {
            using (frmNewMessage nm = new frmNewMessage(User.curuserid, Convert.ToInt32(pxid), lblpatientname.Text))
            {
                nm.ShowDialog();
            }
        }

        private void frmcollecting_Paint(object sender, PaintEventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridcollect_SelectionChanged_1(object sender, EventArgs e)
        {
            dataGridcollect.ClearSelection();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {

        }

        private void lblpatientname_Click(object sender, EventArgs e)
        {

        }

        private void lblpackscollect_Click(object sender, EventArgs e)
        {

        }

        private void lblcycledes_Click(object sender, EventArgs e)
        {

        }
    }
}
