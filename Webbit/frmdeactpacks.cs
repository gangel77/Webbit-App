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
    public partial class frmdeactpacks : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        public frmdeactpacks()
        {
            InitializeComponent();
            lblusername.Text = "User: " + User.curusername;
            dataGriddeact.EnableHeadersVisualStyles = false;

        }

        private void frmchecking_Load(object sender, EventArgs e)
        {

            try
            {
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    OleDbDataAdapter dataadapter = new OleDbDataAdapter(@"SELECT tblpatient.pxfirstname+' '+tblpatient.pxlastname AS pxname, tblpatient.patientid, tblpack.packid, tblpack.packcomment, tblpack.cycledate, tblpack.isrepack, tblpack.active, IIf(IsNull([errorcomment]),'',[errorcomment])+IIf(IsNull([repackcomment]),'',[repackcomment])+IIf(IsNull([deactivecomment]),'',[deactivecomment]) AS comment, tblpack.packerrors, IIf(Not IsNull([tblpack].[deactivecomment]),'Manual Deact',IIf(Not IsNull([tblpack].[repackcomment]),'Changes',IIf(Not IsNull([tblpack].[errorcomment]),'Error',''))) AS reason
FROM (tblpacksize INNER JOIN (tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid) ON tblpacksize.packsizeid = tblpatient.traysize) INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid
WHERE (((tblpack.active)=False))
ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname, tblpack.cycledate DESC", con);

                    DataSet ds = new DataSet();
                    con.Open();
                    dataadapter.Fill(ds, "tableData");
                    con.Close();


                    dataGriddeact.AutoGenerateColumns = false;


                    //set column data properties
                    clnpatientid.DataPropertyName = "patientid";
                    packid.DataPropertyName = "packid";
                    pxname.DataPropertyName = "pxname";
                    clnCycleDate.DataPropertyName = "cycledate";
                    clndeactcomment.DataPropertyName = "comment";
                    clnreason.DataPropertyName = "reason";
                    clnactive.DataPropertyName = "active";




                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = ds;
                    dataGriddeact.DataSource = bindingSource;
                    //dataGridChanges.DataSource = ds;
                    dataGriddeact.DataMember = "tableData";
                    dt = ds.Tables[0];

                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
            try { 
            using (OleDbConnection con2 = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {

                    OleDbDataAdapter adapt = new OleDbDataAdapter();

                    DataSet dscmb = new DataSet();


                    string sql = "SELECT tblpatient.patientid, tblpatient.pxlastname + ', ' + tblpatient.pxfirstname AS pxname FROM tblpatient ORDER BY pxlastname ASC, pxfirstname ASC";


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
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
        

            dataGriddeact.ClearSelection();
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

                        DataGridViewColumn col = this.dataGriddeact.Columns[e.ColumnIndex];

                        //For Pack Comment Column
                        if (col.Name.Equals("clnPackComment"))
                        {
                            DataGridViewRow row = this.dataGriddeact.Rows[e.RowIndex];
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


                                sqlcom.Parameters.Add("?", OleDbType.VarChar, 30).Value = answer;
                                sqlcom.Parameters.Add("?", OleDbType.VarChar, 30).Value = pxcom;
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

        private void dataGridChanges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                var senderGrid = (DataGridView)sender;
                DataGridViewColumn col = this.dataGriddeact.Columns[e.ColumnIndex];
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)



                    if (col.Name.Equals("clnerror"))
                    {
                        //Figure out which button we jsut pressed
                        DataGridViewRow row = this.dataGriddeact.Rows[e.RowIndex];

                        string pxid = row.Cells["clnpatientid"].Value.ToString();
                        string packid = row.Cells["packid"].Value.ToString();
                        int newpackid = Convert.ToInt32(row.Cells["packid"].Value);
                        string cycledate = row.Cells["clncycledate"].Value.ToString();
                        int origcycle = Convert.ToInt32(row.Cells["clnorigcycle"].Value);
                        string errorcount = null;
                        string errormsg = null;
                        string errormsg2 = null;

                        //check if they are sure they want to run error creator


                        yesnobox yn = new yesnobox("Are you sure you want to mark an error? This is irreversible?", "Error check");

                        if (yn.ShowDialog() == DialogResult.No)
                        {

                            return;
                        }
                        row = this.dataGriddeact.Rows[e.RowIndex];


                        using (errorbox eb = new errorbox("How many errors were made in THIS pack?", "Comment regarding the error(s)?", "1", "", "Error Creation"))
                        {

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

                        try
                        { 
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
                            row.Cells["clnpackcomment"].Value = "Error: (" + errormsg2 + ") - sent back to packer";
                            con.Close();
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
                            string strinsert = "INSERT INTO tblpack (patientid,cycledate,isrepack,packcomment,origcycledateid, active) VALUES (?,?,1,?,?,1)";


                            OleDbDataAdapter adaptinsert = new OleDbDataAdapter();

                            OleDbCommand sqlins = new OleDbCommand(strinsert, con);
                            sqlins.Parameters.Add("?", OleDbType.Integer).Value = pxid;
                            sqlins.Parameters.Add("?", OleDbType.VarChar).Value = cycledate;
                            sqlins.Parameters.Add("?", OleDbType.VarChar).Value = "Error: " + errormsg;
                            sqlins.Parameters.Add("?", OleDbType.Integer).Value = origcycle;

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
                        int nRow = dataGriddeact.CurrentCell.RowIndex + 1;
                        if (nRow < dataGriddeact.RowCount)
                        {
                            dataGriddeact.Rows[dataGriddeact.CurrentRow.Index + 1].Selected = true;
                        }
                        row.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                        row.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);

                    }
                    

                if (col.Name.Equals("clnchange"))
                {
                    //Figure out which button we jsut pressed
                    DataGridViewRow row = this.dataGriddeact.Rows[e.RowIndex];

                    string pxid = row.Cells["clnpatientid"].Value.ToString();
                    string packid = row.Cells["packid"].Value.ToString();

                    string cycledate = row.Cells["clncycledate"].Value.ToString();
                    int origcycle = Convert.ToInt32(row.Cells["clnorigcycle"].Value);

                    string answer;
                    //check if they are sure they want to run error creator


                    yesnobox yn = new yesnobox("Are you sure you want to make a pack change? This is irreversible?", "Error check");

                    if (yn.ShowDialog() == DialogResult.No)
                    {

                        return;
                    }
                    row = this.dataGriddeact.Rows[e.RowIndex];


                    inputbox inputbox = new inputbox("What changea are you making?", "Pack Change", "");

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
                        row.Cells["clnpackcomment"].Value = "Change Made: " + answer + " - sent back to packer";
                        con.Close();
                    }

                    }
                    catch (Exception exe)
                    {
                        Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                    }

                    try { 
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        string strinsert = "INSERT INTO tblpack (patientid,cycledate,isrepack,packcomment,origcycledateid, active) VALUES (?,?,1,?,?,1)";


                        OleDbDataAdapter adaptinsert = new OleDbDataAdapter();

                        OleDbCommand sqlins = new OleDbCommand(strinsert, con);
                        sqlins.Parameters.Add("?", OleDbType.Integer).Value = pxid;
                        sqlins.Parameters.Add("?", OleDbType.VarChar).Value = cycledate;
                        sqlins.Parameters.Add("?", OleDbType.VarChar).Value = "Pack Change: " + answer;
                        sqlins.Parameters.Add("?", OleDbType.Integer).Value = origcycle;

                        adaptinsert.SelectCommand = sqlins;

                        using (sqlins)
                        {
                            con.Open();
                            sqlins.ExecuteNonQuery();
                            con.Close();

                        }
                    }
                    }
                    catch (Exception exe)
                    {
                        Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                    }
                    row.Cells["clnactive"].Value = 0;
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                    int nRow = dataGriddeact.CurrentCell.RowIndex + 1;
                    if (nRow < dataGriddeact.RowCount)
                    {
                        dataGriddeact.Rows[dataGriddeact.CurrentRow.Index + 1].Selected = true;
                    }
                    row.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                    row.Cells["clnchange"].Style.Padding = new Padding(100, 0, 0, 0);
                    
                }
                else
                {
                    //accident, dont make an error!
                    return;
                }



            }
        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dataGridChanges_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    DataGridViewRow row = this.dataGriddeact.Rows[dataGriddeact.CurrentRow.Index];
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
                        sqlcom.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
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
                    int nRow = dataGriddeact.CurrentCell.RowIndex + 1;
                    if (nRow < dataGriddeact.RowCount)
                    {
                        dataGriddeact.Rows[dataGriddeact.CurrentRow.Index + 1].Selected = true;
                    }

                    row.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                    break;
                default:
                    base.OnKeyDown(e);
                    break;
            }
        }

        private void dataGridChanges_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            DataGridViewColumn col = this.dataGriddeact.Columns[e.ColumnIndex];

            if (e.RowIndex < 0)
                return;

            
            if (col.Name.Equals("clnreason") && e.Value.ToString() == "Changes")
            {
                e.CellStyle.BackColor = Color.Khaki; ;
            }

            if (col.Name.Equals("clnreason") && e.Value.ToString() == "Error")
            {
                e.CellStyle.BackColor = Color.FromArgb(146, 124, 141); ;
            }
        }


        private void cmbpatient_SelectionChangeCommitted(object sender, EventArgs e)
        {


            DataRowView dv = (DataRowView)cmbpatient.SelectedItem;

            if (dv.Row["patientid"] != null)
            {
                int m1 = (int)dv.Row["patientid"];

                DataView dv1 = dt.DefaultView;
                dv1.RowFilter = "patientid = " + m1.ToString();
                dataGriddeact.DataSource = dv1;
            }
            
        }

        private void dataGridChanges_SelectionChanged(object sender, EventArgs e)
        {
            dataGriddeact.ClearSelection();
        }

        private void cmbpatient_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int index;
                index = cmbpatient.FindString(cmbpatient.Text);
            cmbpatient.SelectedIndex = index;
                cmbpatient_SelectionChangeCommitted(sender, e);
            }
        }
    }
}

