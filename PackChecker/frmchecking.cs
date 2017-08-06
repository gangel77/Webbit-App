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
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        public frmchecking()
        {
            InitializeComponent();
            lblusername.Text = "User: " + User.curusername;
           
        }

        private void frmchecking_Load(object sender, EventArgs e)
        {
            
            {
          
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(@"SELECT tblpatient.pxfirstname & ' ' & tblpatient.pxlastname AS pxname, 
tblpatient.patientid, tblpack.packid, tblpack.packcomment, tblcycle.cyclecode, tblpack.active, tblpack.checkeddate, tblpack.cycledate, 
tblpack.isrepack, tbluser.userfirstname, tblpack.packeddate, tblpack.origcycledateid FROM tbluser INNER JOIN(tblpacksize INNER JOIN((tblpatient 
INNER JOIN tblcycle ON tblpatient.cycleid = tblcycle.cycleid) INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid) 
ON tblpacksize.packsizeid = tblpatient.traysize) ON tbluser.userid = tblpack.packeduser WHERE(((tblpack.checkeddate)Is Null) 
AND((tblpack.packeddate)Is Not Null)) AND tblpack.active = TRUE ORDER BY tblpatient.pxlastname ASC, tblpatient.pxfirstname ASC, tblpack.cycledate;", con);

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
                clncode.DataPropertyName = "cyclecode";
                clnPackComment.DataPropertyName = "packcomment";
                clnpackeduser.DataPropertyName = "userfirstname";
                clnactive.DataPropertyName = "active";
                clnorigcycle.DataPropertyName = "origcycledateid";

                //set button properties
                /* Check and Reverse buttons assigned images tick / undo
                 * clncheck.Text = "Checked";
                clncheck.UseColumnTextForButtonValue = true;
                clnreversecheck.Text = "Reverse";
                clnreversecheck.UseColumnTextForButtonValue = true;
               */

                clnerror.Text = "Error";
                clnerror.UseColumnTextForButtonValue = true;


                dataGridChecked.DataSource = ds;
                dataGridChecked.DataMember = "tableData";

                //Colour row if already picked up 
                foreach (DataGridViewRow row in dataGridChecked.Rows)
                {
                    if (row.Cells["clnPackComment"].Value.ToString() != "")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                    }
                    dataGridChecked[row.Cells["clnreversecheck"].ColumnIndex, row.Index].Style.Padding = new Padding(100, 0, 0, 0);
                }

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
                            }else
                            {
                                pxcom = "";
                            }
                                
                        
                            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                            string strpcom = "UPDATE tblpack SET packcomment = ?, patientnote = ? WHERE packid= ?";

                            OleDbCommand sqlcom = new OleDbCommand(strpcom, con);
                            OleDbDataAdapter dadapter = new OleDbDataAdapter();


                            sqlcom.Parameters.Add("?", OleDbType.VarWChar, 30).Value = answer;
                            sqlcom.Parameters.Add("?", OleDbType.VarWChar, 30).Value = pxcom;
                            sqlcom.Parameters.Add("?", OleDbType.Integer, 5).Value = packid;

                            dadapter.SelectCommand = sqlcom;

                            con.Open();
                            sqlcom.ExecuteNonQuery();
                            con.Close();

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
                    if (e.RowIndex >= 0)
                    {

                        //Figure out which button we jsut pressed
                        DataGridViewColumn col = this.dataGridChecked.Columns[e.ColumnIndex];

                        //For Column Checked
                        if (col.Name.Equals("clncheck"))
                        {


                            DataGridViewRow row = this.dataGridChecked.Rows[e.RowIndex];
                            string packid = row.Cells["packid"].Value.ToString();


                            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

                            string strchecked = "UPDATE tblpack SET checkeduser = ?, checkeddate = ? WHERE packid = ?";

                            OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                            OleDbCommand sqlcom = new OleDbCommand(strchecked, con);
                            sqlcom.Parameters.Add("?", OleDbType.VarWChar, 3).Value = User.curuserid;
                            sqlcom.Parameters.Add("?", OleDbType.Date, 5).Value = DateTime.Now;
                            sqlcom.Parameters.Add("?", OleDbType.Integer, 9).Value = packid;

                            dataadapter.SelectCommand = sqlcom;

                            con.Open();
                            sqlcom.ExecuteNonQuery();
                            con.Close();

                            //post update changes to grid view
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            int nRow = dataGridChecked.CurrentCell.RowIndex + 1;
                            if (nRow < dataGridChecked.RowCount)
                            {
                                dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
                            }
                            row.Cells["clnreversecheck"].Style.Padding = new Padding(0, 0, 0, 0);
                            row.Cells["clncheck"].Style.Padding = new Padding(100, 0, 0, 0);

                        }
                        //If col is Reverse pack button
                        if (col.Name.Equals("clnreversecheck"))
                        {


                            DataGridViewRow row = this.dataGridChecked.Rows[e.RowIndex];

                            string packid = row.Cells["packid"].Value.ToString();

                            string strcheckrev = "UPDATE tblpack SET checkeduser = NULL, checkeddate = NULL WHERE packid= ?";
                            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

                            OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                            OleDbCommand sqlcom = new OleDbCommand(strcheckrev, con);
                            sqlcom.Parameters.Add("?", OleDbType.Integer, 9).Value = packid;

                            dataadapter.SelectCommand = sqlcom;

                            con.Open();

                            sqlcom.ExecuteNonQuery();
                            //row.Cells["clncheckeduser"].Value = "";
                            con.Close();
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.Cells["clnreversecheck"].Style.Padding = new Padding(100, 0, 0, 0);
                            row.Cells["clncheck"].Style.Padding = new Padding(0, 0, 0, 0);

                        }
                        //If Col is ERROR BUTTON
                        if (col.Name.Equals("clnerror"))
                        {
                            DataGridViewRow row = this.dataGridChecked.Rows[e.RowIndex];
                            string pxid = row.Cells["clnpatientid"].Value.ToString();
                            string packid = row.Cells["packid"].Value.ToString();
                            int newpackid = Convert.ToInt32(row.Cells["packid"].Value);
                            string cycledate = row.Cells["clncycledate"].Value.ToString();
                            int origcycle = Convert.ToInt32(row.Cells["clnorigcycle"].Value);
                            string errorcount = null;
                            string errormsg = null;
                            string errormsg2 = null;
                            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
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


                                string strerror = "UPDATE tblpack SET errorcomment = ?, checkeduser = ?, packerrors = ?, active = 0 WHERE packid= ?";


                                OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                                OleDbCommand sqlcom = new OleDbCommand(strerror, con);
                                sqlcom.Parameters.Add("?", OleDbType.VarWChar).Value = errormsg;
                                sqlcom.Parameters.Add("?", OleDbType.Integer).Value = User.curuserid;
                                sqlcom.Parameters.Add("?", OleDbType.Integer).Value = errorcount;
                                sqlcom.Parameters.Add("?", OleDbType.Integer).Value = packid;


                                dataadapter.SelectCommand = sqlcom;

                                con.Open();

                                sqlcom.ExecuteNonQuery();
                                //row.Cells["clncheckeduser"].Value = "";
                                row.Cells["clnpackcomment"].Value = "Error (" + eb.answer2 + ") - sent back to packer";
                                con.Close();

                                string strinsert = "INSERT INTO tblpack (patientid,cycledate,isrepack,packcomment,origcycledateid, active) VALUES (?,?,-1,?,?,-1)";


                                OleDbDataAdapter adaptinsert = new OleDbDataAdapter();

                                OleDbCommand sqlins = new OleDbCommand(strinsert, con);
                                sqlins.Parameters.Add("?", OleDbType.Integer).Value = pxid;
                                sqlins.Parameters.Add("?", OleDbType.VarChar).Value = cycledate;
                                sqlins.Parameters.Add("?", OleDbType.VarWChar).Value = "Error: " + errormsg;
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

                                row.Cells["clnactive"].Value = 0;
                                row.DefaultCellStyle.BackColor = Color.LightCoral;
                                int nRow = dataGridChecked.CurrentCell.RowIndex + 1;
                                if (nRow < dataGridChecked.RowCount)
                                {
                                    dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
                                }
                                row.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                                row.Cells["clnreversecheck"].Style.Padding = new Padding(100, 0, 0, 0);
                                row.Cells["clncheck"].Style.Padding = new Padding(100, 0, 0, 0);
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
                                    string strerror = "UPDATE tblpack SET errorcomment = ?, checkeduser = ?, packerrors = ?, active = 0 WHERE tblpack.patientid = ? AND origcycledateid = ? AND active = TRUE AND packid <> ?";

                                    OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                                    OleDbCommand sqlcom = new OleDbCommand(strerror, con);
                                    sqlcom.Parameters.Add("?", OleDbType.VarWChar).Value = errormsg;
                                    sqlcom.Parameters.Add("?", OleDbType.Integer).Value = User.curuserid;
                                    sqlcom.Parameters.Add("?", OleDbType.Integer).Value = errorcount;
                                    sqlcom.Parameters.Add("?", OleDbType.Integer).Value = pxid;
                                    sqlcom.Parameters.Add("?", OleDbType.Integer).Value = origcycle;
                                    sqlcom.Parameters.Add("?", OleDbType.Integer).Value = newpackid;
                                    dataadapter.SelectCommand = sqlcom;

                                    con.Open();
                                    sqlcom.ExecuteNonQuery();
                                    con.Close();

                                    
                                    foreach (DataGridViewRow row2 in dataGridChecked.Rows)
                                    {
                                        if (row2.Cells["clnpatientid"].Value.ToString() == pxid && Convert.ToInt32(row2.Cells["clnorigcycle"].Value) == origcycle && row2.Cells["clnactive"].Value.ToString() == "True")
                                        {
                                            cycledate = row2.Cells["clncycledate"].Value.ToString();

                                            
                                            row2.Cells["clnpackcomment"].Value = "Error (" + errormsg2 + ") - sent back to packer";
                                            

                                            string strinsert = "INSERT INTO tblpack (patientid,cycledate,isrepack,packcomment,origcycledateid,active) VALUES (?,?,True,?,?,True)";
                                            string pxid_2 = pxid;
                                            string errormsg_2 = errormsg;
                                            int origcycle_2 = origcycle;

                                            OleDbDataAdapter adaptinsert = new OleDbDataAdapter();

                                            OleDbCommand sqlins = new OleDbCommand(strinsert, con);
                                            sqlins.Parameters.Add("?", OleDbType.Integer).Value = pxid_2;
                                            sqlins.Parameters.Add("?", OleDbType.VarChar).Value = cycledate;
                                            sqlins.Parameters.Add("?", OleDbType.VarWChar).Value = "Error: " + errormsg_2;
                                            sqlins.Parameters.Add("?", OleDbType.Integer).Value = origcycle_2;


                                            adaptinsert.SelectCommand = sqlins;

                                            con.Open();
                                            sqlins.ExecuteNonQuery();
                                            con.Close();

                                            sqlins.Parameters.Clear();
                                            row2.DefaultCellStyle.BackColor = Color.LightCoral;
                                            dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
                                            row2.Cells["clnactive"].Value = 0;
                                            row2.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["clnreversecheck"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["clncheck"].Style.Padding = new Padding(100, 0, 0, 0);
                                        }
                                    }

                                }
                                else
                                {
                      
                                    //NO - all the packs do not have the same error
                                    foreach (DataGridViewRow row2 in dataGridChecked.Rows)
                                    {
                                        if (row2.Cells["clnpatientid"].Value.ToString() == pxid && row2.Cells["clnactive"].Value.ToString() == "True" && Convert.ToInt32(row2.Cells["clnorigcycle"].Value) == origcycle)
                                        {
                                            packid = row2.Cells["packid"].Value.ToString();

                                            string strerror2 = "UPDATE tblpack SET packcomment = ? WHERE tblpack.patientid = ? AND origcycledateid = ? AND active = TRUE AND packid = ?";

                                            OleDbDataAdapter dataadapter2 = new OleDbDataAdapter();

                                            OleDbCommand sqlcom2 = new OleDbCommand(strerror2, con);
                                            sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = "Waiting on a repack before marking as checked";
                                            sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = pxid;
                                            sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = origcycle;
                                            sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = packid;

                                            dataadapter2.SelectCommand = sqlcom2;
                                            con.Open();
                                            sqlcom2.ExecuteNonQuery();
                                            con.Close();

                                            row2.Cells["clnpackcomment"].Value = "Waiting on a repack before marking as checked";
                                            row2.DefaultCellStyle.BackColor = Color.LightBlue;
                                            dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
                                            row2.Cells["clnerror"].Style.Padding = new Padding(100, 0, 0, 0);
                                            row2.Cells["clnreversecheck"].Style.Padding = new Padding(1000, 0, 0, 0);
                                            row2.Cells["clncheck"].Style.Padding = new Padding(0, 0, 0, 0);

                                        }

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
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridChecked_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridViewRow row = this.dataGridChecked.Rows[dataGridChecked.CurrentRow.Index];
            string packid = row.Cells["packid"].Value.ToString();

            
            

            string strchecked = "UPDATE tblpack SET checkeduser = ?, checkeddate = ? WHERE packid = ?";

            OleDbDataAdapter dataadapter = new OleDbDataAdapter();
            OleDbCommand sqlcom = new OleDbCommand(strchecked, con);

            //allocate parameters to the string
            sqlcom.Parameters.Add("?", OleDbType.VarWChar, 3).Value = User.curuserid;
            sqlcom.Parameters.Add("?", OleDbType.Date, 5).Value = DateTime.Now;
            sqlcom.Parameters.Add("?", OleDbType.Integer, 9).Value = packid;

            dataadapter.SelectCommand = sqlcom;

            //run query
            con.Open();
            sqlcom.ExecuteNonQuery();
            con.Close();

            //post button changes to data grid
            row.DefaultCellStyle.BackColor = Color.LightGreen;
            int nRow = dataGridChecked.CurrentCell.RowIndex + 1;
            if (nRow < dataGridChecked.RowCount)
            {
                dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
            }
            row.Cells["clnreversecheck"].Style.Padding = new Padding(0, 0, 0, 0);
            row.Cells["clncheck"].Style.Padding = new Padding(100, 0, 0, 0);
        }

        private void dataGridChecked_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            DataGridViewColumn col = this.dataGridChecked.Columns[e.ColumnIndex];

            if (e.RowIndex < 0)
                return;

            //Assign tick to column
            if (col.Name.Equals("clncheck"))
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
