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
    public partial class frmchanges : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        public frmchanges()
        {
            this.Icon = Properties.Resources.icon;
            InitializeComponent();
            lblusername.Text = "User: " + User.curusername;
            dataGridChanges.EnableHeadersVisualStyles = false;

        }

        private void frmchecking_Load(object sender, EventArgs e)
        {
            loadoriginal(sender,e);
        }

        private void loadoriginal(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(@"SELECT tblpatient.pxfirstname+' '+tblpatient.pxlastname AS pxname, tblpatient.patientid, tblpack.packid, tblpack.packcomment, 
                tblcycle.cyclecode, tblpack.active, tblpack.checkeduser, (tblcycle.cycleweeks/tblcycle.cyclepacks) AS weeksinpack, tblpack.cycledate, tblpack.isrepack, tbluser.userfirstname, 
                tblpack.packeduser, tblpack.origcycledateid, tblpack.origcycledateid FROM (tblpacksize INNER JOIN (tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid) 
                ON tblpacksize.packsizeid = tblpatient.traysize) INNER JOIN (tbluser INNER JOIN tblpack ON tbluser.userid = tblpack.packeduser) ON tblpatient.patientid = tblpack.patientid
                WHERE (((tblpack.active)=True) AND ((tblpack.checkeduser) Is Not Null) AND ((tblpack.packeduser) Is Not Null) AND ((tblpack.collectuser) Is Null))
                ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname, tblpack.cycledate;", con);
                try
                {

                    DataSet ds = new DataSet();
                    con.Open();
                    dataadapter.Fill(ds, "tableData");
                    con.Close();


                    dataGridChanges.AutoGenerateColumns = false;


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
                    clncycleid.DataPropertyName = "originalcycledateid";



                    cmbpatient.DropDownHeight = cmbpatient.Font.Height * 8;

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = ds;
                    dataGridChanges.DataSource = bindingSource;
                    //dataGridChanges.DataSource = ds;
                    dataGridChanges.DataMember = "tableData";
                    dt = ds.Tables[0];
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                }
                using (OleDbConnection con2 = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {

                    OleDbDataAdapter adapt = new OleDbDataAdapter();

                    DataSet dscmb = new DataSet();


                    string sql = @"SELECT tbldeactive.patientid, tbldeactive.pxfirstname, tbldeactive.pxlastname, pxlastname + ', ' + pxfirstname as pxname
                                FROM
                                (SELECT tblpatient.patientid, tblpatient.pxfirstname, tblpatient.pxlastname
                                FROM tblpatient INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid
                                GROUP BY tblpatient.patientid, tblpatient.pxfirstname, tblpatient.pxlastname, tblpatient.active, tblpack.collectuser, tblpack.active
                                HAVING(((tblpatient.active) = False) AND((tblpack.collectuser)Is Null) AND((tblpack.active) = True))) as tbldeactive
                                UNION
                                SELECT tblpatient.patientid, tblpatient.pxfirstname, tblpatient.pxlastname, pxlastname + ', ' + pxfirstname as pxname
                                FROM tblpatient
                                Order BY pxlastname, pxfirstname";

                    try
                    {

                        con2.Open();
                        OleDbCommand cmd2 = new OleDbCommand(sql, con2);

                        adapt.SelectCommand = cmd2;
                        adapt.Fill(dscmb);
                        adapt.Dispose();
                        con2.Close();


                        cmbpatient.ValueMember = "patientid";
                        cmbpatient.DisplayMember = "pxname";

                        cmbpatient.DataSource = dscmb.Tables[0];

                        cmbpatient.SelectedIndex = -1;

                    }
                    catch (Exception exe)
                    {
                        Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                    }
                }


                dataGridChanges.ClearSelection();
                lblcurview.Text = "Packs Ready for Collection";
            }
        }


        private void dataGridChanges_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here

                    if (e.RowIndex >= 0)
                    {

                        DataGridViewColumn col = this.dataGridChanges.Columns[e.ColumnIndex];

                        //For Pack Comment Column
                        if (col.Name.Equals("clnPackComment"))
                        {
                            DataGridViewRow row = this.dataGridChanges.Rows[e.RowIndex];
                            string packid = row.Cells["packid"].Value.ToString();
                            string cellvalue = row.Cells["clnPackComment"].Value.ToString();

                            //Ask for comment
                            inputbox inputbox = new inputbox("Enter new message here", "Pack Comment", cellvalue);
                            string answer = null;
                            if (inputbox.ShowDialog() == DialogResult.OK)
                            {
                                answer = inputbox.answer;
                            }
                            else
                            {
                                return;
                            }
                            
                            //CHeck if this is to be a patient notification too?
                            

                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {
                                try
                                {
                                                                    
                                string strpcom = "UPDATE tblpack SET packcomment = ? WHERE packid= ?";

                                OleDbCommand sqlcom = new OleDbCommand(strpcom, con);
                                OleDbDataAdapter dadapter = new OleDbDataAdapter();


                                sqlcom.Parameters.Add("?", OleDbType.VarChar, 30).Value = answer;
                                sqlcom.Parameters.Add("?", OleDbType.Integer).Value = packid;

                                dadapter.SelectCommand = sqlcom;

                                con.Open();
                                sqlcom.ExecuteNonQuery();
                                con.Close();
                                }
                                catch (Exception exe)
                                {
                                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                                }
                            }

                            //Post comment changes to table
                            row.Cells["clnPackComment"].Value = answer;
                        }



                    }
                }
            }

        }

        private void dataGridChanges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                var senderGrid = (DataGridView)sender;
                DataGridViewColumn col = this.dataGridChanges.Columns[e.ColumnIndex];
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {


                    if (col.Name.Equals("clnerror"))
                    {
                        //Figure out which button we jsut pressed
                        DataGridViewRow row = this.dataGridChanges.Rows[e.RowIndex];

                        string pxid = row.Cells["clnpatientid"].Value.ToString();
                        string packid = row.Cells["packid"].Value.ToString();
                        int newpackid = Convert.ToInt32(row.Cells["packid"].Value);
                        DateTime cycledate = Convert.ToDateTime(row.Cells["clncycledate"].Value);
                        int origcycle = Convert.ToInt32(row.Cells["clnorigcycle"].Value);
                        string errorcount = null;
                        string errormsg = null;
                        string errormsg2 = null;
                        int weeksinpack = Convert.ToInt32(row.Cells["clnweeksinpack"].Value);

                        //check if they are sure they want to run error creator


                        yesnobox yn = new yesnobox("Are you sure you want to mark an error? This is irreversible?", "Error check");

                        if (yn.ShowDialog() == DialogResult.No)
                        {

                            return;
                        }
                        row = this.dataGridChanges.Rows[e.RowIndex];

                        int i = 0;
                        using (errorbox eb = new errorbox("How many errors were made in THIS pack?", "Comment regarding the error(s)?", "1", "", "Error Creation"))
                        {


                            //Open errorbox and ask for error count and msg
                            foreach (DataGridViewRow row3 in dataGridChanges.Rows)
                            {
                                if (row3.Cells["clnpatientid"].Value.ToString() == pxid && row3.Cells["clnactive"].Value.ToString() == "True" && Convert.ToInt32(row3.Cells["clnorigcycle"].Value) == origcycle)
                                {
                                    i++;
                                }
                            }

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
                        }

                        using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                        {
                            string strerror = "UPDATE tblpack SET errorcomment = ?, repackuser = ? , packerrors = ?, active = 0 WHERE packid= ?";

                            try
                            {

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
                                row.Cells["clnpackcomment"].Value = "Error: (" + errormsg2 + ") - sent back to packer";
                                con.Close();
                            }
                            catch (Exception exe)
                            {
                                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                            }
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


                        using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                        {
                            try
                            {
                                string strinsert = "INSERT INTO tblpack (patientid,cycledate,isrepack,packcomment,origcycledateid, active,weeksinpack, iscommunity, isrepat, isconcession, isover5med) VALUES (?,?,1,?,?,-1,?,?,?,?,?)";
                                string getid = "Select @@Identity";


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

                                //string getid = "Select @@Identity";

                                using (sqlins)
                                {
                                    con.Open();

                                    sqlins.ExecuteNonQuery();
                                    sqlins.CommandText = getid;
                                    newpackid = (int)sqlins.ExecuteScalar();
                                    con.Close();

                                }
                            }
                            catch (Exception exe)
                            {
                                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                            }
                        }
                        row.Cells["clnactive"].Value = 0;
                        if (i > 1)
                        {


                            //as if all packs have the same error
                            yesnobox ynb = new yesnobox("Is the error in all packs for this patient?", "Check other pack");
                            if (ynb.ShowDialog() == DialogResult.Yes)
                            {
                                //YES - all packs have te same error
                                try
                                {
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

                                try
                                {
                                    foreach (DataGridViewRow row2 in dataGridChanges.Rows)
                                    {
                                        if (row2.Cells["clnpatientid"].Value.ToString() == pxid && Convert.ToInt32(row2.Cells["clnorigcycle"].Value) == origcycle && row2.Cells["clnactive"].Value.ToString() == "True")
                                        {
                                            cycledate = Convert.ToDateTime(row2.Cells["clncycledate"].Value);


                                            row2.Cells["clnpackcomment"].Value = "Error (" + errormsg2 + ") - sent back to packer";

                                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                            {
                                                string strinsert = "INSERT INTO tblpack (patientid,cycledate,isrepack,packcomment,origcycledateid,active,weeksinpack, iscommunity, isrepat, isconcession, isover5med) VALUES (?,?,-1,?,?,-1,?,?,?,?,?)";
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

                                            row2.DefaultCellStyle.BackColor = Color.FromArgb(179, 165, 177);
                                            dataGridChanges.Rows[dataGridChanges.CurrentRow.Index + 1].Selected = true;
                                            row2.Cells["clnactive"].Value = 0;
                                            row2.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
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



                        row.DefaultCellStyle.BackColor = Color.FromArgb(179, 165, 177);
                        int nRow = dataGridChanges.CurrentCell.RowIndex + 1;
                        if (nRow < dataGridChanges.RowCount)
                        {
                            dataGridChanges.Rows[dataGridChanges.CurrentRow.Index + 1].Selected = true;
                        }
                        row.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);
                    }


                    if (col.Name.Equals("clnchange"))
                    {
                        //Figure out which button we jsut pressed
                        DataGridViewRow row = this.dataGridChanges.Rows[e.RowIndex];

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
                        row = this.dataGridChanges.Rows[e.RowIndex];


                        inputbox inputbox = new inputbox("What changes are you making?", "Pack Change", "");
                        int i = 0;
                        foreach (DataGridViewRow row3 in dataGridChanges.Rows)
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
                                    foreach (DataGridViewRow row2 in dataGridChanges.Rows)
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
                                            dataGridChanges.Rows[dataGridChanges.CurrentRow.Index + 1].Selected = true;
                                            row.Cells["clnpackcomment"].Value = "Change Made: (" + answer + ") - sent back to packer";
                                            row2.Cells["clnactive"].Value = 0;
                                            row2.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
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

                        row.DefaultCellStyle.BackColor = Color.Khaki;
                        int nRow = dataGridChanges.CurrentCell.RowIndex + 1;
                        if (nRow < dataGridChanges.RowCount)
                        {
                            dataGridChanges.Rows[dataGridChanges.CurrentRow.Index + 1].Selected = true;
                        }
                        row.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);
                    }

                    if (col.Name.Equals("btndeactivate"))
                    {
                        //Figure out which button we jsut pressed
                        DataGridViewRow row = this.dataGridChanges.Rows[e.RowIndex];

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
                        row = this.dataGridChanges.Rows[e.RowIndex];


                        inputbox inputbox = new inputbox("Why is this pack being deactivated?", "Deactivation", "");
                        int i = 0;
                        foreach (DataGridViewRow row3 in dataGridChanges.Rows)
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
                                    foreach (DataGridViewRow row2 in dataGridChanges.Rows)
                                    {
                                        if (row2.Cells["clnpatientid"].Value.ToString() == pxid && row2.Cells["clnactive"].Value.ToString() == "True")
                                        {
                                            row2.DefaultCellStyle.BackColor = Color.DarkGray;
                                            dataGridChanges.Rows[dataGridChanges.CurrentRow.Index + 1].Selected = true;
                                            row2.Cells["clnpackcomment"].Value = "Pack Deactivated - " + answer;
                                            row2.Cells["clnactive"].Value = 0;
                                            row2.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
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


                        int nRow = dataGridChanges.CurrentCell.RowIndex + 1;
                        if (nRow < dataGridChanges.RowCount)
                        {
                            dataGridChanges.Rows[dataGridChanges.CurrentRow.Index + 1].Selected = true;
                        }
                        row.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);

                    }


                }
            }
        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        

        private void dataGridChanges_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            DataGridViewColumn col = this.dataGridChanges.Columns[e.ColumnIndex];

            if (e.RowIndex < 0)
                return;

            //Assign error button
            if (col.Name.Equals("clnerror") && e.CellStyle.BackColor != Color.Khaki && e.CellStyle.BackColor != Color.FromArgb(179, 165, 177) && e.CellStyle.BackColor != Color.DarkGray)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = dataGridChanges.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.cross, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            //Assign error button
            if (col.Name.Equals("clnchange") && e.CellStyle.BackColor != Color.Khaki && e.CellStyle.BackColor != Color.FromArgb(179, 165, 177) && e.CellStyle.BackColor != Color.DarkGray)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = dataGridChanges.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.warning, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (col.Name.Equals("btndeactivate") && e.CellStyle.BackColor != Color.Khaki && e.CellStyle.BackColor != Color.FromArgb(179, 165, 177) && e.CellStyle.BackColor != Color.DarkGray)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = dataGridChanges.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.deactivate, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            DataGridViewRow row = this.dataGridChanges.Rows[e.RowIndex];

            if (row.Cells["clnactive"].Value.ToString() == "False")
            {
                if (row.Cells["clnPackComment"].Value.ToString().StartsWith("Error:"))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(179, 165, 177);
                }
            }
        }


        private void cmbpatient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRowView dv = (DataRowView)cmbpatient.SelectedItem;
            int m1 = (int)dv.Row["patientid"];

            DataView dv1 = dt.DefaultView;
            dv1.RowFilter = "patientid = " + m1.ToString();
            dataGridChanges.DataSource = dv1;
            foreach (DataGridViewRow row in dataGridChanges.Rows)
            {
                if (row.Cells["clnactive"].Value.ToString() == "False")
                {
                    //MessageBox.Show(row.Cells["clnactive"].Value.ToString());
                    if (row.Cells["clnPackComment"].Value.ToString().StartsWith("Error:", StringComparison.Ordinal))
                    {
                        //MessageBox.Show(row.Cells["clnPackComment"].Value.ToString());
                        row.DefaultCellStyle.BackColor = Color.FromArgb(179, 165, 177);
                        
                    }

                    if (row.Cells["clnPackComment"].Value.ToString().StartsWith("Change Made:", StringComparison.Ordinal))
                    {
                        row.DefaultCellStyle.BackColor = Color.Khaki;
                        
                    }
                    row.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                    row.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);
                    row.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);
                }

                if (row.Cells["clnPackComment"].Value.ToString().Contains("Pack Deactivated"))
                {
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                    
                }
                

            }
        
        }

        private void dataGridChanges_SelectionChanged(object sender, EventArgs e)
        {
            dataGridChanges.ClearSelection();
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            try
            { 
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(@"SELECT tblpatient.pxfirstname + ' ' + tblpatient.pxlastname AS pxname, tblpatient.patientid, tblpack.packid, tblpack.packcomment, tblcycle.cyclecode, tblpack.active, tblpack.checkeddate, tblpack.cycledate, tblpack.isrepack, tblpack.packeddate, tblpack.origcycledateid, tbluser.userfirstname
FROM tbluser RIGHT JOIN ((tblpacksize INNER JOIN (tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid) ON tblpacksize.packsizeid = tblpatient.traysize) INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid) ON tbluser.userid = tblpack.packeduser
WHERE (((tblpack.active)=-1) AND ((tblpack.collectuser) Is Null))
ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname, tblpack.cycledate", con);

                DataSet ds = new DataSet();
                con.Open();
                dataadapter.Fill(ds, "tableData");
                con.Close();
                
                dataGridChanges.AutoGenerateColumns = false;
                
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ds;
                dataGridChanges.DataSource = bindingSource;
                //dataGridChanges.DataSource = ds;
                dataGridChanges.DataMember = "tableData";

                dt = ds.Tables[0];
                //Colour row if already picked up 
                foreach (DataGridViewRow row in dataGridChanges.Rows)
                    {
                        if (row.Cells["clnactive"].Value.ToString() == "False")
                        {
                            if (row.Cells["clnPackComment"].Value.ToString().StartsWith("Error:"))
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(179, 165, 177);
                            }
                            if (row.Cells["clnPackComment"].Value.ToString().StartsWith("Change Made:"))
                            {

                                row.DefaultCellStyle.BackColor = Color.Khaki;
                            }
                        if (row.Cells["clnPackComment"].Value.ToString().Contains("Pack Deactivated"))
                        {

                            row.DefaultCellStyle.BackColor = Color.DarkGray;
                        }
                    
                        
                       
                    }

                    }

                
            }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
            cmbpatient.SelectedIndex = -1;
            dataGridChanges.ClearSelection();
            lblcurview.Text = "Viewing All Active Packs";
            btnuncollected.Visible = true;
            btnviewall.Visible = false;
        }

        private void btnuncollected_Click(object sender, EventArgs e)
        {
            loadoriginal(sender, e);
            //btnviewall.Visible = true;
            //btnuncollected.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbpatient.SelectedIndex = -1;
            loadoriginal(sender, e);
        }

        private void frmchanges_Paint(object sender, PaintEventArgs e)
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

