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
using Microsoft.VisualBasic;



namespace PackChecker
{
    public partial class frmchecking : Form
    {
        DataSet ds = new DataSet();
        int totalcountcheck;
        public frmchecking()
        {
            this.Icon = Properties.Resources.icon;
            InitializeComponent();
            lblusername.Text = "User: " + User.curusername;
            
            
            dataGridChecked.EnableHeadersVisualStyles = false;
        }


        private void countpacks(OleDbConnection con)
        {
            string strcount = "SELECT COUNT(*) FROM tblpack WHERE active = -1 AND packeduser IS NOT NULL AND checkeduser IS NULL";



            using (OleDbCommand cmdcount = new OleDbCommand(strcount, con))
            {
                
                con.Open();
                totalcountcheck = (int)cmdcount.ExecuteScalar();
                con.Close();

                if (totalcountcheck == 0)
                {
                    using (msgbox yn = new msgbox("No packs to check!", "All Done"))
                    {
                        yn.ShowDialog();
                        
                        
                    }
                    DialogResult = DialogResult.Cancel;
                    
                }

            }
        }
        private void frmchecking_Load(object sender, EventArgs e)
        {
            


            try
            { 

            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                    countpacks(con);
                    lblcount.Text = "Packs to check: " + totalcountcheck;
                    
                    OleDbDataAdapter dataadapter = new OleDbDataAdapter(@"SELECT strconv(tblpatient.pxlastname,3) + ', ' + strconv(tblpatient.pxfirstname,3) AS pxname, tblpack.weeksinpack, tblpatient.patientid, tblpack.packid, tblpack.packcomment, tblpack.active, tblpack.cycledate, tblpack.isrepack, tbluser.userfirstname, tblpack.origcycledateid, tblpack.checkeduser, tblpack.packeduser
FROM tblpatient INNER JOIN (tbluser INNER JOIN tblpack ON tbluser.userid = tblpack.packeduser) ON tblpatient.patientid = tblpack.patientid
WHERE (((tblpack.checkeduser) Is Null) and tblpack.active = -1 AND ((tblpack.packeduser) Is Not Null))
ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname, tblpack.cycledate", con);

                DataSet ds = new DataSet();
                con.Open();
                dataadapter.Fill(ds, "tableData");
                con.Close();


                dataGridChecked.AutoGenerateColumns = false;


                //set column data properties
                clnpatientid.DataPropertyName = "patientid";
                packid.DataPropertyName = "packid";
                pxname.DataPropertyName = "pxname";
                clnCycleDate.DataPropertyName = "cycledate";
                //clncode.DataPropertyName = "cyclecode";
                clnPackComment.DataPropertyName = "packcomment";
                clnpackeduser.DataPropertyName = "userfirstname";
                clnactive.DataPropertyName = "active";
                clnorigcycle.DataPropertyName = "origcycledateid";
                clnweeksinpack.DataPropertyName = "weeksinpack";
                //set button properties

                dataGridChecked.DataSource = ds;
                dataGridChecked.DataMember = "tableData";

                //Colour row if already picked up 
                Application.DoEvents();
                foreach (DataGridViewRow row in dataGridChecked.Rows)
                {

                    if (row.Cells["clnPackComment"].Value.ToString() != "")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightBlue;

                    }
                    
                    
                }
                

                this.dataGridChecked.Columns["pxname"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.dataGridChecked.Columns["clnPackComment"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridChecked.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridChecked.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

                }

            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
        }




        private void dataGridChecked_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here

                    if (e.RowIndex >= 0)
                    {

                        DataGridViewColumn col = this.dataGridChecked.Columns[e.ColumnIndex];

                        //For Pack Comment Column
                        if (col.Name.Equals("clnPackComment"))
                        {
                            DataGridViewRow row = this.dataGridChecked.Rows[e.RowIndex];
                            string packid = row.Cells["packid"].Value.ToString();
                            string cellvalue = row.Cells["clnPackComment"].Value.ToString();

                            //Ask for comment
                            inputbox inputbox = new inputbox("Enter new message here", "Pack Comment", cellvalue);
                            string answer = null;
                            if (inputbox.ShowDialog() == DialogResult.OK)
                            {

                                answer = inputbox.answer + " - (" + User.curusername + ")";
                            }
                            else
                            {
                                return;
                            }
                            string pxcom = null;
                            //CHeck if this is to be a patient notification too?
                            if (!string.IsNullOrWhiteSpace(answer))
                            {
                                yesnobox yesnobox = new yesnobox("Use this comment to notify patient on pickup?", "Use notifiction for patient?");


                                if (yesnobox.ShowDialog() == DialogResult.Yes)
                                {
                                    pxcom = answer;
                                }
                                else
                                {
                                    pxcom = "";
                                }
                            }
                            else
                            {
                                pxcom = "";
                            }

                            try
                            { 
                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {
                                string strpcom = "UPDATE tblpack SET packcomment = ?, patientnote = ? WHERE packid= ?";

                                OleDbCommand sqlcom = new OleDbCommand(strpcom, con);
                                OleDbDataAdapter dadapter = new OleDbDataAdapter();


                                sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = answer;
                                sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = pxcom;
                                sqlcom.Parameters.Add("?", OleDbType.Integer).Value = packid;

                                dadapter.SelectCommand = sqlcom;

                                con.Open();
                                sqlcom.ExecuteNonQuery();
                                con.Close();
                            }
                            }
                            catch (Exception exe)
                            {
                                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                            }

                            //Post comment changes to table
                            row.Cells["clnPackComment"].Value = answer;
                        }



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
                    

                        //Figure out which button we jsut pressed
                        DataGridViewColumn col = this.dataGridChecked.Columns[e.ColumnIndex];

                        //For Column Checked
                        if (col.Name.Equals("clncheck"))
                        {


                            DataGridViewRow row = this.dataGridChecked.Rows[e.RowIndex];
                            string packid = row.Cells["packid"].Value.ToString();

                        try { 
                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {

                                string strchecked = "UPDATE tblpack SET checkeduser = ?, checkeddate = ? WHERE packid = ?";

                                using (OleDbDataAdapter dataadapter = new OleDbDataAdapter())
                                {

                                    using (OleDbCommand sqlcom = new OleDbCommand(strchecked, con))
                                    {
                                        sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = User.curuserid;
                                        sqlcom.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = packid;

                                        dataadapter.SelectCommand = sqlcom;

                                        con.Open();
                                        sqlcom.ExecuteNonQuery();
                                        con.Close();
                                    }
                                }
                            }
                        }
                        catch (Exception exe)
                        {
                            Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                        }
                        //post update changes to grid view
                        row.DefaultCellStyle.BackColor = Color.FromArgb(129, 183, 143);
                            int nRow = dataGridChecked.CurrentCell.RowIndex + 1;
                            if (nRow < dataGridChecked.RowCount)
                            {
                                dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
                            }
                        //this.dataGridChecked.Columns["clnreversecheck"].DefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
                       
                            row.Cells["clnreversecheck"].Style.Padding = new Padding(1, 0, 0, 0);
                            row.Cells["clncheck"].Style.Padding = new Padding(100, 0, 0, 0);
                            row.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);
                        totalcountcheck--;
                            lblcount.Text = "Packs to check: " + totalcountcheck;
                        return;

                        }
                        //If col is Reverse pack button
                        if (col.Name.Equals("clnreversecheck"))
                        {


                            DataGridViewRow row = this.dataGridChecked.Rows[e.RowIndex];

                            string packid = row.Cells["packid"].Value.ToString();

                            string strcheckrev = "UPDATE tblpack SET checkeduser = NULL, checkeddate = NULL WHERE packid= ?";
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
                                //row.Cells["clncheckeduser"].Value = "";
                                con.Close();
                            }
                        }
                        catch (Exception exe)
                        {
                            Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                        }
                        row.DefaultCellStyle.BackColor = Color.White;
                            row.Cells["clnreversecheck"].Style.Padding = new Padding(100, 0, 0, 0);
                            row.Cells["clncheck"].Style.Padding = new Padding(0, 0, 0, 0);
                            row.Cells["clnerror"].Style.Padding = new Padding(0, 0, 0, 0);
                        row.Cells["clnchange"].Style.Padding = new Padding(0, 0, 0, 0);
                        row.Cells["btndeactivate"].Style.Padding = new Padding(0, 0, 0, 0);
                        totalcountcheck++;
                            lblcount.Text = "Packs to check: " + totalcountcheck;
                        

                    }

                    if (col.Name.Equals("clnchange"))
                    {
                        //Figure out which button we jsut pressed
                        DataGridViewRow row = this.dataGridChecked.Rows[e.RowIndex];

                        string pxid = row.Cells["clnpatientid"].Value.ToString();
                        string packid = row.Cells["packid"].Value.ToString();

                        string cycledate = row.Cells["clncycledate"].Value.ToString();
                        int origcycle = Convert.ToInt32(row.Cells["clnorigcycle"].Value);
                        int weeksinpack = Convert.ToInt32(row.Cells["clnweeksinpack"].Value);

                        string answer;
                        //check if they are sure they want to run error creator


                        yesnobox yn = new yesnobox("Are you sure you want to make a pack change? This is irreversible?", "Error check");

                        if (yn.ShowDialog() == DialogResult.No)
                        {

                            return;
                        }
                        row = this.dataGridChecked.Rows[e.RowIndex];


                        inputbox inputbox = new inputbox("What changes are you making?", "Pack Change", "");
                        int i = 0;
                        foreach (DataGridViewRow row3 in dataGridChecked.Rows)
                        {
                            if (row3.Cells["clnpatientid"].Value.ToString() == pxid && row3.Cells["clnactive"].Value.ToString() == "True" && Convert.ToInt32(row3.Cells["clnorigcycle"].Value) == origcycle)
                            {
                                i++;
                            }
                        }

                        if (inputbox.ShowDialog() == DialogResult.OK)
                        {
                            answer = inputbox.answer + " (" + User.curusername + ")";

                        }
                        else
                        {
                            return;
                        }
                        try
                        {

                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {

                                string strerror = "UPDATE tblpack SET repackcomment = ?, repackuser = ?, active = 0 WHERE packid= ?";


                                OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                                OleDbCommand sqlcom = new OleDbCommand(strerror, con);
                                sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = answer;
                                sqlcom.Parameters.Add("?", OleDbType.Integer).Value = User.curuserid;
                                sqlcom.Parameters.Add("?", OleDbType.Integer).Value = packid;


                                dataadapter.SelectCommand = sqlcom;

                                con.Open();

                                sqlcom.ExecuteNonQuery();
                                //row.Cells["clncheckeduser"].Value = "";
                                row.Cells["clnpackcomment"].Value = "Change Made: (" + answer + ") - sent back to packer";
                                con.Close();
                            }
                        }
                        catch (Exception exe)
                        {
                            Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                        }

                        bool isrepat = new bool();
                        bool isconcession = new bool();
                        bool isover5med = new bool();
                        bool iscommunity = new bool();

                        try
                        {
                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {
                                string pxinfo = @"SELECT tblpatient.patientid, tblinstitution.iscommunity, tblpatient.repatnumber, tblpatient.concessionnumber, tblpatient.over5med
                                                FROM tblpatient INNER JOIN tblinstitution ON tblpatient.institutionid = tblinstitution.institutionid WHERE patientid = ?;";


                                using (OleDbCommand cmd = new OleDbCommand(pxinfo, con))
                                {
                                    cmd.Parameters.Add("?", OleDbType.VarWChar).Value = pxid;

                                    OleDbDataReader reader;

                                    con.Open();
                                    reader = cmd.ExecuteReader();
                                    while (reader.Read())
                                    {

                                        if (string.IsNullOrEmpty(reader["repatnumber"].ToString()))
                                        {
                                            isrepat = false;
                                        }
                                        else
                                        {
                                            isrepat = true;
                                        }

                                        if (string.IsNullOrEmpty(reader["concessionnumber"].ToString()))
                                        {
                                            isconcession = false;
                                        }
                                        else
                                        {
                                            isconcession = true;
                                        }

                                        isover5med = Convert.ToBoolean(reader["over5med"]);
                                        iscommunity = Convert.ToBoolean(reader["iscommunity"]);
                                    }


                                }


                            }
                        }
                        catch (Exception exe)
                        {
                            Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                        }
                        int newpackid = new int();
                        try
                        {
                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {
                                string strinsert = "INSERT INTO tblpack (patientid,cycledate,isrepack,packcomment,origcycledateid, active,weeksinpack, iscommunity, isrepat, isconcession, isover5med) VALUES (?,?,-1,?,?,-1,?,?,?,?,?)";
                                string getid = "Select @@Identity";
                                OleDbDataAdapter adaptinsert = new OleDbDataAdapter();

                                OleDbCommand sqlins = new OleDbCommand(strinsert, con);
                                sqlins.Parameters.Add("?", OleDbType.Integer).Value = pxid;
                                sqlins.Parameters.Add("?", OleDbType.Date).Value = cycledate;
                                sqlins.Parameters.Add("?", OleDbType.VarChar).Value = "Pack Change: " + answer;
                                sqlins.Parameters.Add("?", OleDbType.Integer).Value = origcycle;
                                sqlins.Parameters.Add("?", OleDbType.Integer).Value = weeksinpack;
                                sqlins.Parameters.Add("?", OleDbType.Boolean).Value = iscommunity;
                                sqlins.Parameters.Add("?", OleDbType.Boolean).Value = isrepat;
                                sqlins.Parameters.Add("?", OleDbType.Boolean).Value = isconcession;
                                sqlins.Parameters.Add("?", OleDbType.Boolean).Value = isover5med;

                                adaptinsert.SelectCommand = sqlins;

                                using (sqlins)
                                {
                                    con.Open();
                                    sqlins.ExecuteNonQuery();
                                    sqlins.CommandText = getid;
                                    newpackid = (int)sqlins.ExecuteScalar();
                                    con.Close();

                                }
                            }
                        }
                        catch (Exception exe)
                        {
                            Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                        }
                        row.Cells["clnactive"].Value = 0;

                        //If there are more than one pack in this cycle for this patient
                        if (i > 1)
                        {


                            //as if all packs have the same change
                            yesnobox ynb = new yesnobox("Is the change in all packs in this cycle for this patient?", "Check other packs");
                            if (ynb.ShowDialog() == DialogResult.Yes)
                            {
                                //YES - all packs have te same change
                                try
                                {
                                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                    {
                                        string strerror = "UPDATE tblpack SET repackcomment = ?, repackuser = ?, active = 0 WHERE tblpack.patientid = ? AND origcycledateid = ? AND active = -1 AND packid <> ?";

                                        OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                                        OleDbCommand sqlcom = new OleDbCommand(strerror, con);

                                        sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = answer;
                                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = User.curuserid;
                                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = pxid;
                                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = origcycle;
                                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = newpackid;
                                        dataadapter.SelectCommand = sqlcom;

                                        con.Open();
                                        sqlcom.ExecuteNonQuery();
                                        con.Close();
                                    }
                                }
                                catch (Exception exe)
                                {
                                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                                }

                                try
                                {
                                    foreach (DataGridViewRow row2 in dataGridChecked.Rows)
                                    {
                                        if (row2.Cells["clnpatientid"].Value.ToString() == pxid && Convert.ToInt32(row2.Cells["clnorigcycle"].Value) == origcycle && row2.Cells["clnactive"].Value.ToString() == "True")
                                        {


                                            cycledate = row2.Cells["clncycledate"].Value.ToString();
                                            row2.Cells["clnpackcomment"].Value = "Change Made: (" + answer + ") - sent back to packer";

                                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                            {
                                                string strinsert = "INSERT INTO tblpack (patientid,cycledate,isrepack,packcomment,origcycledateid,active,weeksinpack, iscommunity, isrepat, isconcession, isover5med) VALUES (?,?,-1,?,?,-1,?,?,?,?,?)";
                                                string pxid_2 = pxid;

                                                int origcycle_2 = origcycle;

                                                OleDbDataAdapter adaptinsert = new OleDbDataAdapter();

                                                OleDbCommand sqlins = new OleDbCommand(strinsert, con);
                                                sqlins.Parameters.Add("?", OleDbType.Integer).Value = pxid_2;
                                                sqlins.Parameters.Add("?", OleDbType.Date).Value = cycledate;
                                                sqlins.Parameters.Add("?", OleDbType.VarChar).Value = "Pack Change: " + answer;
                                                sqlins.Parameters.Add("?", OleDbType.Integer).Value = origcycle_2;
                                                sqlins.Parameters.Add("?", OleDbType.Integer).Value = weeksinpack;
                                                sqlins.Parameters.Add("?", OleDbType.Boolean).Value = iscommunity;
                                                sqlins.Parameters.Add("?", OleDbType.Boolean).Value = isrepat;
                                                sqlins.Parameters.Add("?", OleDbType.Boolean).Value = isconcession;
                                                sqlins.Parameters.Add("?", OleDbType.Boolean).Value = isover5med;


                                                adaptinsert.SelectCommand = sqlins;

                                                con.Open();
                                                sqlins.ExecuteNonQuery();
                                                con.Close();

                                                sqlins.Parameters.Clear();
                                            }

                                            row2.DefaultCellStyle.BackColor = Color.Khaki;
                                            dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
                                            row.Cells["clnpackcomment"].Value = "Change Made: (" + answer + ") - sent back to packer";
                                            row2.Cells["clnactive"].Value = 0;
                                            row2.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["clnreversecheck"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["clncheck"].Style.Padding = new Padding(100, 0, 0, 0);
                                        }
                                    }
                                }
                                catch (Exception exe)
                                {
                                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                                }

                            }
                        }

                        row.DefaultCellStyle.BackColor = Color.Khaki;
                        int nRow = dataGridChecked.CurrentCell.RowIndex + 1;
                        if (nRow < dataGridChecked.RowCount)
                        {
                            dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
                        }
                        row.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["clnreversecheck"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["clncheck"].Style.Padding = new Padding(100, 0, 0, 0);
                        

                    }

                    if (col.Name.Equals("btndeactivate"))
                    {
                        //Figure out which button we jsut pressed
                        DataGridViewRow row = this.dataGridChecked.Rows[e.RowIndex];

                        string pxid = row.Cells["clnpatientid"].Value.ToString();
                        string packid = row.Cells["packid"].Value.ToString();

                        string cycledate = row.Cells["clncycledate"].Value.ToString();
                        int origcycle = Convert.ToInt32(row.Cells["clnorigcycle"].Value);

                        string answer;
                        //check if they are sure they want to run error creator


                        yesnobox yn = new yesnobox("This pack will be removed from the packing cycle, are you sure?", "Check Deactivation");

                        if (yn.ShowDialog() == DialogResult.No)
                        {
                            return;
                        }
                        row = this.dataGridChecked.Rows[e.RowIndex];


                        inputbox inputbox = new inputbox("Why is this pack being deactivated?", "Deactivation", "");
                        int i = 0;
                        foreach (DataGridViewRow row3 in dataGridChecked.Rows)
                        {
                            if (row3.Cells["clnpatientid"].Value.ToString() == pxid && row3.Cells["clnactive"].Value.ToString() == "True")
                            {
                                i++;
                            }
                        }

                        if (inputbox.ShowDialog() == DialogResult.OK)
                        {
                            answer = inputbox.answer + " (" + User.curusername + ")";

                        }
                        else
                        {
                            return;
                        }

                        try
                        {

                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {
                                string strerror = "UPDATE tblpack SET deactivecomment = ?, repackuser = ?, active = 0 WHERE packid= ?";


                                OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                                OleDbCommand sqlcom = new OleDbCommand(strerror, con);
                                sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = answer;
                                sqlcom.Parameters.Add("?", OleDbType.Integer).Value = User.curuserid;
                                sqlcom.Parameters.Add("?", OleDbType.Integer).Value = packid;


                                dataadapter.SelectCommand = sqlcom;

                                con.Open();

                                sqlcom.ExecuteNonQuery();
                                //row.Cells["clncheckeduser"].Value = "";
                                row.Cells["clnpackcomment"].Value = "Pack Deactivated - " + answer;
                                con.Close();
                            }
                        }
                        catch (Exception exe)
                        {
                            Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                        }

                        row.Cells["clnactive"].Value = 0;
                        row.DefaultCellStyle.BackColor = Color.DarkGray;

                        if (i > 1)
                        {


                            //as if all packs have the same change
                            yesnobox ynb = new yesnobox("Would you like to Deactivate ALL remaining packs for this patient??", "Check other packs");
                            if (ynb.ShowDialog() == DialogResult.Yes)
                            {
                                //YES - all packs have te same change
                                try
                                {
                                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                    {
                                        string strerror = "UPDATE tblpack SET deactivecomment = ?, repackuser = ?, active = 0 WHERE tblpack.patientid = ? AND active = -1 AND packid <> ?";

                                        OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                                        OleDbCommand sqlcom = new OleDbCommand(strerror, con);

                                        sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = answer;
                                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = User.curuserid;
                                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = pxid;
                                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = packid;
                                        dataadapter.SelectCommand = sqlcom;

                                        con.Open();
                                        sqlcom.ExecuteNonQuery();
                                        con.Close();
                                    }
                                }
                                catch (Exception exe)
                                {
                                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                                }

                                try
                                {
                                    foreach (DataGridViewRow row2 in dataGridChecked.Rows)
                                    {
                                        if (row2.Cells["clnpatientid"].Value.ToString() == pxid && row2.Cells["clnactive"].Value.ToString() == "True")
                                        {
                                            row2.DefaultCellStyle.BackColor = Color.DarkGray;
                                            dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
                                            row2.Cells["clnpackcomment"].Value = "Pack Deactivated - " + answer;
                                            row2.Cells["clnactive"].Value = 0;
                                            row2.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);
                                           
                                            row2.Cells["clnreversecheck"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["clncheck"].Style.Padding = new Padding(100, 0, 0, 0);
                                        }
                                    }
                                }
                                catch (Exception exe)
                                {
                                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                                }

                            }

                        }


                        int nRow = dataGridChecked.CurrentCell.RowIndex + 1;
                        if (nRow < dataGridChecked.RowCount)
                        {
                            dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
                        }
                        row.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);
                       
                        row.Cells["clnreversecheck"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["clncheck"].Style.Padding = new Padding(100, 0, 0, 0);

                    }

                    //If Col is ERROR BUTTON
                    if (col.Name.Equals("clnerror"))
                        {
                        bool isrepat = new bool();
                            bool isconcession = new bool();
                            bool isover5med = new bool();
                            bool iscommunity = new bool();
                            DataGridViewRow row = this.dataGridChecked.Rows[e.RowIndex];
                            string pxid = row.Cells["clnpatientid"].Value.ToString();
                            string packid = row.Cells["packid"].Value.ToString();
                            int newpackid = Convert.ToInt32(row.Cells["packid"].Value);
                            DateTime cycledate = Convert.ToDateTime(row.Cells["clncycledate"].Value);
                            int origcycle = Convert.ToInt32(row.Cells["clnorigcycle"].Value);
                            int weeksinpack = Convert.ToInt32(row.Cells["clnweeksinpack"].Value);
                            string errorcount = null;
                            string errormsg = null;
                            string errormsg2 = null;

                            //check if they are sure they want to run error creator

                            string active = row.Cells["clnactive"].Value.ToString();
                            if (active == "False")
                            {
                                msgbox msgbox = new msgbox("This has already been marked as an error pack", "Error Duplication");
                                msgbox.ShowDialog();
                                return;
                            }

                            yesnobox yn = new yesnobox("Are you sure you want to mark an error? This is irreversible?", "Error check");
                            int i = 0;
                            if (yn.ShowDialog() == DialogResult.Yes)
                            {
                                row = this.dataGridChecked.Rows[e.RowIndex];

                                //Open errorbox and ask for error count and msg
                                foreach (DataGridViewRow row3 in dataGridChecked.Rows)
                                {
                                    if (row3.Cells["clnpatientid"].Value.ToString() == pxid && row3.Cells["clnactive"].Value.ToString() == "True" && Convert.ToInt32(row3.Cells["clnorigcycle"].Value) == origcycle)
                                    {
                                        i++;
                                    }
                                }
                                //MessageBox.Show(i.ToString());

                                errorbox eb = new errorbox("How many errors were made in THIS pack?", "Comment regarding the error(s)?", "1", "", "Error Creation");

                                if (eb.ShowDialog() == DialogResult.OK)
                                {
                                    errorcount = eb.answer1;
                                    errormsg = eb.answer2 + " (" + User.curusername + ")";
                                    errormsg2 = eb.answer2;
                                }
                                else
                                {
                                    return;
                                }

                            try { 
                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                {
                                    string strerror = "UPDATE tblpack SET errorcomment = ?, repackuser = ?, packerrors = ?, active = 0 WHERE packid= ?";


                                    OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                                    OleDbCommand sqlcom = new OleDbCommand(strerror, con);
                                    sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = errormsg;
                                    sqlcom.Parameters.Add("?", OleDbType.Integer).Value = User.curuserid;
                                    sqlcom.Parameters.Add("?", OleDbType.Integer).Value = errorcount;
                                    sqlcom.Parameters.Add("?", OleDbType.Integer).Value = packid;


                                    dataadapter.SelectCommand = sqlcom;

                                    con.Open();

                                    sqlcom.ExecuteNonQuery();
                                    //row.Cells["clncheckeduser"].Value = "";
                                    row.Cells["clnpackcomment"].Value = "Error (" + eb.answer2 + ") - sent back to packer";
                                    con.Close();
                                    totalcountcheck--;
                                    lblcount.Text = "Packs to check: " + totalcountcheck;
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
                                    string pxinfo = @"SELECT tblpatient.patientid, tblinstitution.iscommunity, tblpatient.repatnumber, tblpatient.concessionnumber, tblpatient.over5med
                                                FROM tblpatient INNER JOIN tblinstitution ON tblpatient.institutionid = tblinstitution.institutionid WHERE patientid = ?;";


                                    using (OleDbCommand cmd = new OleDbCommand(pxinfo, con))
                                    {
                                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = pxid;

                                        OleDbDataReader reader;

                                        con.Open();
                                        reader = cmd.ExecuteReader();
                                        while (reader.Read())
                                        {
                                            
                                            if (string.IsNullOrEmpty(reader["repatnumber"].ToString()))
                                            {
                                                isrepat = false;
                                            }
                                            else
                                            {
                                                isrepat = true;
                                            }

                                            if (string.IsNullOrEmpty(reader["concessionnumber"].ToString()))
                                            {
                                                isconcession = false;
                                            }
                                            else
                                            {
                                                isconcession = true;
                                            }

                                            isover5med = Convert.ToBoolean(reader["over5med"]);
                                            iscommunity = Convert.ToBoolean(reader["iscommunity"]);
                                        }


                                    }

                                    
                                }
                            }
                            catch (Exception exe)
                            {
                                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                            }
                            
                            try { 
                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                {
                                    string strinsert = "INSERT INTO tblpack (patientid,cycledate,isrepack,packcomment,origcycledateid, active,weeksinpack, iscommunity, isrepat, isconcession, isover5med) VALUES (?,?,-1,?,?,-1,?,?,?,?,?) ";


                                    OleDbDataAdapter adaptinsert = new OleDbDataAdapter();

                                    OleDbCommand sqlins = new OleDbCommand(strinsert, con);
                                    sqlins.Parameters.Add("?", OleDbType.Integer).Value = pxid;
                                    sqlins.Parameters.Add("?", OleDbType.Date).Value = cycledate;
                                    sqlins.Parameters.Add("?", OleDbType.VarChar).Value = "Error: " + errormsg;
                                    sqlins.Parameters.Add("?", OleDbType.Integer).Value = origcycle;
                                    sqlins.Parameters.Add("?", OleDbType.Integer).Value = weeksinpack;
                                    sqlins.Parameters.Add("?", OleDbType.Boolean).Value = iscommunity;
                                    sqlins.Parameters.Add("?", OleDbType.Boolean).Value = isrepat;
                                    sqlins.Parameters.Add("?", OleDbType.Boolean).Value = isconcession;
                                    sqlins.Parameters.Add("?", OleDbType.Boolean).Value = isover5med;

                                    adaptinsert.SelectCommand = sqlins;

                                    string getid = "Select @@Identity";

                                    using (sqlins)
                                    {
                                        con.Open();

                                        sqlins.ExecuteNonQuery();
                                        sqlins.CommandText = getid;
                                        newpackid = (int)sqlins.ExecuteScalar();
                                        con.Close();

                                    }
                                }
                            }
                            catch (Exception exe)
                            {
                                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                            }
                            row.Cells["clnactive"].Value = 0;
                                row.DefaultCellStyle.BackColor = Color.FromArgb(179, 165, 177);
                                int nRow = dataGridChecked.CurrentCell.RowIndex + 1;
                                if (nRow < dataGridChecked.RowCount)
                                {
                                    dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
                                }
                                row.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                                row.Cells["clnreversecheck"].Style.Padding = new Padding(100, 0, 0, 0);
                                row.Cells["clncheck"].Style.Padding = new Padding(100, 0, 0, 0);
                            row.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);
                            row.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);
                        }
                            else
                            {
                                //accident, dont make an error!
                                return;

                            }
                            if (i > 1)
                            {


                                //as if all packs have the same error
                                yesnobox ynb = new yesnobox("Is the error in all packs for this patient?", "Check other pack");
                                if (ynb.ShowDialog() == DialogResult.Yes)
                                {
                                //YES - all packs have te same error
                                try { 
                                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                    {
                                        string strerror = "UPDATE tblpack SET errorcomment = ?, repackuser = ?, packerrors = ?, active = 0 WHERE tblpack.patientid = ? AND origcycledateid = ? AND active = -1 AND packid <> ?";

                                        OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                                        OleDbCommand sqlcom = new OleDbCommand(strerror, con);
                                        sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = errormsg;
                                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = User.curuserid;
                                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = errorcount;
                                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = pxid;
                                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = origcycle;
                                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = newpackid;
                                        dataadapter.SelectCommand = sqlcom;

                                        con.Open();
                                        sqlcom.ExecuteNonQuery();
                                        con.Close();
                                    }
                                }
                                catch (Exception exe)
                                {
                                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                                }

                                try { 
                                foreach (DataGridViewRow row2 in dataGridChecked.Rows)
                                    {
                                        if (row2.Cells["clnpatientid"].Value.ToString() == pxid && Convert.ToInt32(row2.Cells["clnorigcycle"].Value) == origcycle && row2.Cells["clnactive"].Value.ToString() == "True")
                                        {
                                            cycledate = Convert.ToDateTime(row2.Cells["clncycledate"].Value);


                                            row2.Cells["clnpackcomment"].Value = "Error (" + errormsg2 + ") - sent back to packer";

                                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                            {
                                                string strinsert = "INSERT INTO tblpack (patientid,cycledate,isrepack,packcomment,origcycledateid, active,weeksinpack, iscommunity, isrepat, isconcession, isover5med) VALUES (?,?,-1,?,?,-1,?,?,?,?,?)";
                                                string pxid_2 = pxid;
                                                string errormsg_2 = errormsg;
                                                int origcycle_2 = origcycle;

                                                OleDbDataAdapter adaptinsert = new OleDbDataAdapter();

                                                OleDbCommand sqlins = new OleDbCommand(strinsert, con);
                                                sqlins.Parameters.Add("?", OleDbType.Integer).Value = pxid_2;
                                                sqlins.Parameters.Add("?", OleDbType.Date).Value = cycledate;
                                                sqlins.Parameters.Add("?", OleDbType.VarChar).Value = "Error: " + errormsg_2;
                                                sqlins.Parameters.Add("?", OleDbType.Integer).Value = origcycle_2;
                                                sqlins.Parameters.Add("?", OleDbType.Integer).Value = weeksinpack;
                                                sqlins.Parameters.Add("?", OleDbType.Boolean).Value = iscommunity;
                                                sqlins.Parameters.Add("?", OleDbType.Boolean).Value = isrepat;
                                                sqlins.Parameters.Add("?", OleDbType.Boolean).Value = isconcession;
                                                sqlins.Parameters.Add("?", OleDbType.Boolean).Value = isover5med;


                                                adaptinsert.SelectCommand = sqlins;

                                                con.Open();
                                                sqlins.ExecuteNonQuery();
                                                con.Close();

                                                sqlins.Parameters.Clear();
                                            }
                                            totalcountcheck--;
                                            lblcount.Text = "Packs to check: " + totalcountcheck;
                                            row2.DefaultCellStyle.BackColor = Color.FromArgb(179, 165, 177);
                                            dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
                                            row2.Cells["clnactive"].Value = 0;
                                            row2.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["clnreversecheck"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["clncheck"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);
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

                                    //NO - all the packs do not have the same error
                                    try
                                { 
                                    foreach (DataGridViewRow row2 in dataGridChecked.Rows)
                                    {
                                        if (row2.Cells["clnpatientid"].Value.ToString() == pxid && row2.Cells["clnactive"].Value.ToString() == "True" && Convert.ToInt32(row2.Cells["clnorigcycle"].Value) == origcycle)
                                        {
                                            packid = row2.Cells["packid"].Value.ToString();
                                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                            {
                                                string strerror2 = "UPDATE tblpack SET packcomment = ? WHERE tblpack.patientid = ? AND origcycledateid = ? AND active = -1 AND packid = ?";

                                                OleDbDataAdapter dataadapter2 = new OleDbDataAdapter();

                                                OleDbCommand sqlcom2 = new OleDbCommand(strerror2, con);
                                                sqlcom2.Parameters.Add("?", OleDbType.VarChar).Value = "Waiting on a repack before marking as checked";
                                                sqlcom2.Parameters.Add("?", OleDbType.VarChar).Value = pxid;
                                                sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = origcycle;
                                                sqlcom2.Parameters.Add("?", OleDbType.VarChar).Value = packid;

                                                dataadapter2.SelectCommand = sqlcom2;
                                                con.Open();
                                                sqlcom2.ExecuteNonQuery();
                                                con.Close();
                                            }
                                            row2.Cells["clnpackcomment"].Value = "Waiting on a repack before marking as checked";
                                            row2.DefaultCellStyle.BackColor = Color.LightBlue;
                                            dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
                                            //row2.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["clnreversecheck"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["clncheck"].Style.Padding = new Padding(0, 0, 0, 0);
                                            row2.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);


                                        }

                                    }
                                }
                                catch (Exception exe)
                                {
                                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                                }
                            }
                            }
                            else
                            {
                                return;
                            }

                        }
                    }
                
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dataGridChecked_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    DataGridViewRow row = this.dataGridChecked.Rows[dataGridChecked.CurrentRow.Index];

                    if(row.DefaultCellStyle.BackColor == Color.FromArgb(129, 183, 143))
                    {
                        return;
                    }
                    string packid = row.Cells["packid"].Value.ToString();
                    try
                    { 
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        string strchecked = "UPDATE tblpack SET checkeduser = ?, checkeddate = ? WHERE packid = ?";

                        OleDbDataAdapter dataadapter = new OleDbDataAdapter();
                        OleDbCommand sqlcom = new OleDbCommand(strchecked, con);

                        //allocate parameters to the string
                        sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = User.curuserid;
                        sqlcom.Parameters.Add("?", OleDbType.Date, 5).Value = DateTime.Now;
                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = packid;

                        dataadapter.SelectCommand = sqlcom;

                        //run query
                        con.Open();
                        sqlcom.ExecuteNonQuery();
                        con.Close();
                    }
                    }
                    catch (Exception exe)
                    {
                        Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                    }
                    //post button changes to data grid
                    row.DefaultCellStyle.BackColor = Color.FromArgb(129, 183, 143);
                    int nRow = dataGridChecked.CurrentCell.RowIndex + 1;
                    if (nRow < dataGridChecked.RowCount)
                    {
                        dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
                    }
                    
                    row.Cells["clnreversecheck"].Style.Padding = new Padding(1, 0, 0, 0);
                    row.Cells["clncheck"].Style.Padding = new Padding(100, 0, 0, 0);
                    row.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                    row.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);
                    row.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);

                    if (totalcountcheck > 0)
                    {
                        totalcountcheck--;
                        lblcount.Text = "Packs to check: " + totalcountcheck;
                    }
                    
                    break;

                default:
                    base.OnKeyDown(e);
                    break;
            }
        }

        private void dataGridChecked_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            

            DataGridViewColumn col = this.dataGridChecked.Columns[e.ColumnIndex];

            if (e.RowIndex < 0)
                return;

            //Assign tick to column
            if (col.Name.Equals("clncheck") && e.CellStyle.BackColor != Color.FromArgb(129, 183, 143) && e.CellStyle.BackColor != Color.FromArgb(179, 165, 177))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = dataGridChecked.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.tick, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            //Assign undo to cell if pack is packed
            if (col.Name.Equals("clnreversecheck") && e.CellStyle.BackColor == Color.FromArgb(129, 183, 143))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = dataGridChecked.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.undo, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            //Assign error button

            if(e.CellStyle.BackColor != Color.Khaki && e.CellStyle.BackColor != Color.FromArgb(129, 183, 143) && e.CellStyle.BackColor != Color.FromArgb(179, 165, 177) && e.CellStyle.BackColor != Color.DarkGray)
            {
                if (col.Name.Equals("clnerror"))
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var w = dataGridChecked.RowTemplate.Height - 5;
                    var h = w;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                    e.Graphics.DrawImage(Properties.Resources.cross, new Rectangle(x, y, w, h));
                    e.Handled = true;
                }
                if (col.Name.Equals("clnchange"))
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var w = dataGridChecked.RowTemplate.Height - 5;
                    var h = w;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                    e.Graphics.DrawImage(Properties.Resources.warning, new Rectangle(x, y, w, h));
                    e.Handled = true;
                }
                if (col.Name.Equals("btndeactivate"))
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var w = dataGridChecked.RowTemplate.Height - 5;
                    var h = w;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                    e.Graphics.DrawImage(Properties.Resources.deactivate, new Rectangle(x, y, w, h));
                    e.Handled = true;
                }
            }
            
        }

        private void frmchecking_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = Color.FromArgb(0, 59, 76);
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
