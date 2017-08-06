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

    public partial class frmpacking : Form
    {
        public frmpacking()
        {
            //string curuser, string curuserid, string curusername
            InitializeComponent();
            lblusername.Text = "User: " + User.curusername;
            //lbluserid.Text = curuserid;
            //lblcuruserlogin.Text = curuser;

        }

        private void frmpacking_Load(object sender, EventArgs e)
        {
            
            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

            string strcount = "SELECT COUNT(*) FROM tblpack WHERE active = true AND packeduser IS NULL";

            int count = 0;

            OleDbCommand cmdcount = new OleDbCommand(strcount, con);
            con.Open();
            count = (int)cmdcount.ExecuteScalar();
            con.Close();
            if (count == 0)
            {
                yesnobox yn = new yesnobox("It looks like all packs are made! Would you like to create a new packing cycle?", "Check New Cycle");
                if (yn.ShowDialog() == DialogResult.Yes)
                {
                    addpacks();

                }
                else
                {
                    this.Dispose();
                }
            }
            
            
            string strpack = @"SELECT [pxfirstname] & ' ' & [pxlastname] AS pxname, tblpacksize.sizename, tblpatient.pxlastname, tblpatient.pxfirstname, tblpacksize.sizename, tblcycle.cyclecode, tblpack.cycledate, tblpack.packcomment, tblcycle.cyclepacks, tblpack.active, tblpack.patientnote,tblpack.packid, tblpack.packeduser
FROM (tblpacksize INNER JOIN (tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid) ON tblpacksize.packsizeid = tblpatient.traysize) INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid
WHERE tblpack.active=True AND tblpack.packeduser IS NULL ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname, tblpack.cycledate;";
            //OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(strpack, con);
            //dataadapter.SelectCommand.Parameters.Add("?", OleDbType.Date, 5).Value = curdate.AddDays(-1);

            
            con.Open();
            DataSet ds = new DataSet();
            //con.Open();
            dataadapter.Fill(ds, "tableData");
            con.Close();
            dataGridPacked.AutoGenerateColumns = false;

            //dont think we need this
            //dataGridPacked.ColumnCount = 7;

            //ALLOCATE COLUMNS TO DATA
            packid.DataPropertyName = "packid";

            pxname.DataPropertyName = "pxname";

            clnCycleDate.DataPropertyName = "cycledate";

            clncode.DataPropertyName = "cyclecode";

            clnPackComment.DataPropertyName = "packcomment";

            clnpacksize.DataPropertyName = "sizename";

            //clnpackeduser.DataPropertyName = "packeduser";

            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //dataGridPacked.Columns.Add(btn);
            //btn.HeaderText = "Checked";

            //CREATE BUTTONS
           /* Assign images instead of text to buttons for pack and undo in cell painting method
            * 
            * clnpack.Text = "Packed";
            //clnpack.FlatStyle = FlatStyle.Popup;
            clnpack.UseColumnTextForButtonValue = true;

            clnreversepack.Text = "Reverse";
            //clnreversepack.FlatStyle = FlatStyle.Popup;
            clnreversepack.UseColumnTextForButtonValue = true;
            */

            dataGridPacked.DataSource = ds;
            dataGridPacked.DataMember = "tableData";

            foreach (DataGridViewRow row in dataGridPacked.Rows)
            {
                if (row.Cells["clnPackComment"].Value.ToString() != "")
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                }

                //if (row.Cells["clnpackeduser"].Value.ToString() != "")
                //{
                //    dataGridPacked[row.Cells["clnpack"].ColumnIndex,row.Index].Style.Padding = new Padding(100, 0, 0, 0);
                //    dataGridPacked[row.Cells["clnreversepack"].ColumnIndex, row.Index].Style.Padding = new Padding(100, 0, 0, 0);
                //    //row.DefaultCellStyle.Padding = new Padding(30, 0, 0, 0);
                //}

                
                    dataGridPacked[row.Cells["clnreversepack"].ColumnIndex, row.Index].Style.Padding = new Padding(100, 0, 0, 0);
                    //row.DefaultCellStyle.Padding = new Padding(30, 0, 0, 0);
               
                
            }

        }
        private void dataGridPacked_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here

                    if (e.RowIndex >= 0)
                    {
                        //Figure out which button we jsut pressed
                        DataGridViewColumn col = this.dataGridPacked.Columns[e.ColumnIndex];

                        //IF we are in the Column PACKCOMMENT, do this
                        if (col.Name.Equals("clnPackComment"))
                        {


                            DataGridViewRow row = this.dataGridPacked.Rows[e.RowIndex];
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

                            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                            string strpcom = "UPDATE tblpack SET packcomment = ? WHERE packid= ?";

                            OleDbCommand sqlcom = new OleDbCommand(strpcom, con);

                            OleDbDataAdapter dadapter = new OleDbDataAdapter();

                            string userbrack = null;

                            if (!string.IsNullOrWhiteSpace(answer))
                            {
                                userbrack = " (" + User.curuserlogin + ")";
                                    }

                            sqlcom.Parameters.Add("?", OleDbType.VarWChar, 30).Value = answer + userbrack;
                            sqlcom.Parameters.Add("?", OleDbType.Integer, 5).Value = packid;

                            dadapter.SelectCommand = sqlcom;
                             
                            con.Open();

                            sqlcom.ExecuteNonQuery();
                            row.Cells["clnPackComment"].Value = answer;
                            con.Close();

                        }



                    }
                }
            }

        }
        private void dataGridPacked_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    if (e.RowIndex >= 0)
                    {

                        //Figure out which button we jsut pressed
                        DataGridViewColumn col = this.dataGridPacked.Columns[e.ColumnIndex];

                        //IF we are in the Column pack, do this
                        if (col.Name.Equals("clnpack"))
                        {


                            DataGridViewRow row = this.dataGridPacked.Rows[e.RowIndex];
                            string packid = row.Cells["packid"].Value.ToString();

                            //MessageBox.Show(packid);
                            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

                            string strpacked = "UPDATE tblpack SET packeduser = ?, packeddate = ? WHERE packid = ?";
                            
                            OleDbDataAdapter dataadapter = new OleDbDataAdapter();
                            
                            OleDbCommand sqlcom = new OleDbCommand(strpacked, con);

                            sqlcom.Parameters.Add("?", OleDbType.VarWChar, 3).Value = User.curuserid;
                            sqlcom.Parameters.Add("?", OleDbType.Date, 5).Value = DateTime.Now;
                            sqlcom.Parameters.Add("?", OleDbType.Integer, 5).Value = packid;

                            dataadapter.SelectCommand = sqlcom;

                            con.Open();

                            sqlcom.ExecuteNonQuery();
                           // row.Cells["clnpackeduser"].Value = User.curuserlogin;
                            con.Close();
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            int nRow = dataGridPacked.CurrentCell.RowIndex + 1;
                            if (nRow < dataGridPacked.RowCount)
                            {
                                dataGridPacked.Rows[dataGridPacked.CurrentRow.Index + 1].Selected = true;
                            }
                            
                            row.Cells["clnpackeduser"].Value = User.curuserid;
                            row.Cells["clnreversepack"].Style.Padding = new Padding(0, 0, 0, 0);
                            row.Cells["clnpack"].Style.Padding = new Padding(100, 0, 0, 0);



                        }
                        //If col is Reverse pack button
                        if (col.Name.Equals("clnreversepack"))
                        {


                            DataGridViewRow row = this.dataGridPacked.Rows[e.RowIndex];

                            string packid = row.Cells["packid"].Value.ToString();

                            string strpackrev = "UPDATE tblpack SET packeduser = NULL, packeddate = NULL WHERE packid= ?";
                            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

                            OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                            OleDbCommand sqlcom = new OleDbCommand(strpackrev, con);
                            sqlcom.Parameters.Add("?", OleDbType.Integer, 5).Value = packid;

                            dataadapter.SelectCommand = sqlcom;

                            con.Open();

                            sqlcom.ExecuteNonQuery();
                            //row.Cells["clnpackeduser"].Value = "";
                            con.Close();
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.Cells["clnpackeduser"].Value = "";

                            row.Cells["clnreversepack"].Style.Padding = new Padding(100, 0, 0, 0);
                            row.Cells["clnpack"].Style.Padding = new Padding(0, 0, 0, 0);
                        }
                    }
                }
            }
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

            string strcount = "SELECT COUNT(*) FROM tblpack WHERE active = true AND packeduser IS NULL";

            int count = 0;

            OleDbCommand cmdcount = new OleDbCommand(strcount, con);
            con.Open();
            count = (int)cmdcount.ExecuteScalar();
            con.Close();
            if (count == 0)
            {

                yesnobox yn = new yesnobox("It looks like all packs are made! Would you like to create a new packing cycle?", "Check New Cycle");
                if (yn.ShowDialog() == DialogResult.Yes)
                {
                    addpacks();
                }
                else
                {
                    this.Dispose();
                }

                
                frmpacking_Load(sender, e);
          }
            else
            {
                this.Dispose();
            }
            
            

        }
        private static void checkforpacks()
        {
            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

            string strcount = "SELECT COUNT(*) FROM tblpack WHERE active = true AND packeduser IS NULL";

            int count = 0;

            OleDbCommand cmdcount = new OleDbCommand(strcount, con);
            con.Open();
            count = (int)cmdcount.ExecuteScalar();
            con.Close();
            if (count == 0)
            {
                yesnobox yn = new yesnobox("It looks like all packs are made! Would you like to create a new packing cycle?", "Check New Cycle");
                if (yn.ShowDialog() == DialogResult.Yes)
                {
                    addpacks();

                }else
                {
                    return;
                }
            }else
            {
                return;
            }
            
        }
        
        private static void addpacks()
        {
            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

            DateTime curdate = new DateTime();
            DateTime newdate = new DateTime();
            int defweeks = 0;
            //Get last cycle date
            string strpackdate = "SELECT * FROM tblsettings WHERE settingid = 6";
            OleDbCommand cmd = new OleDbCommand(strpackdate, con);
            con.Open();
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                curdate = Convert.ToDateTime(reader["settingdate"]);

            }

            reader.Close();
            con.Close();

            strpackdate = "SELECT * FROM tblsettings WHERE settingid = 8";
            cmd = new OleDbCommand(strpackdate, con);
            con.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                defweeks = Convert.ToInt32(reader["settingactive"]);

            }
            reader.Close();

            con.Close();

            newdate = curdate.AddDays(7 * defweeks);

            //yesnobox yn = new yesnobox("Would you like to create a new packing cycle starting" + Environment.NewLine + Environment.NewLine + newdate.ToShortDateString() , "Date Confirmation");
            //if (yn.ShowDialog() == DialogResult.No)
            //{
            //    return;
            //}
            //yn.Close();
            //yn.Dispose();

            //insert new WEEK into the pack schedule
            string strdateins = "INSERT INTO tblweek (weekdate) VALUES (?)";
            string getid = "Select @@Identity";


            OleDbDataAdapter adapt = new OleDbDataAdapter();

            OleDbCommand cmdp = new OleDbCommand(strdateins, con);

            cmdp.Parameters.Add("?", OleDbType.Date, 10).Value = newdate;

            adapt.SelectCommand = cmdp;
            int weekdateid = new int();
            weekdateid = 0;
            using (cmdp)
            {
                con.Open();

                cmdp.ExecuteNonQuery();
                cmdp.CommandText = getid;
                weekdateid = (int)cmdp.ExecuteScalar();
                con.Close();

            }

            string strupdate = "UPDATE tblsettings SET settingdate = ? WHERE settingid = 6";

            OleDbCommand cmdup = new OleDbCommand(strupdate, con);

            cmdup.Parameters.Add("?", OleDbType.Date, 10).Value = newdate;
            adapt.SelectCommand = cmdup;

            con.Open();
            cmdup.ExecuteNonQuery();
            con.Close();

            //Get list of patients needing packs
            string strpkpx = @"SELECT tblpatient.patientid, tblcycle.cycleweeks, tblcycle.cyclepacks, Max(tblweek.weekdate) AS MaxOfweekdate, Max([weekdate]+(7*[cycleweeks])) AS nextpack
            FROM tblweek RIGHT JOIN ((tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid) LEFT JOIN tblpack ON tblpatient.patientid = tblpack.patientid) ON tblweek.weekid = tblpack.origcycledateid
            WHERE (((tblpatient.active)=True))
            GROUP BY tblpatient.patientid, tblcycle.cycleweeks, tblcycle.cyclepacks
            HAVING (((Max([weekdate]+(7*[cycleweeks]))) = ?))";


            OleDbCommand cmdpx = new OleDbCommand(strpkpx, con);
            cmdpx.Parameters.Add("?", OleDbType.Date, 8).Value = newdate.ToShortDateString();

            

            DataTable dt = new DataTable();
            con.Open();
            OleDbDataAdapter adaptpx = new OleDbDataAdapter(cmdpx);
            adaptpx.SelectCommand = cmdpx;
            adaptpx.Fill(dt);


            DateTime origpackdate = new DateTime();
            origpackdate = newdate;

            DateTime nextpackdate = new DateTime();
            string strpackins = "INSERT INTO tblpack (cycledate,patientid,origcycledateid) VALUES (?,?,?)";
            OleDbCommand cmdadd = new OleDbCommand(strpackins, con);
            OleDbDataAdapter adaptp = new OleDbDataAdapter();


            foreach (DataRow row in dt.Rows)
            {
                var pxid = row["patientid"].ToString();
                var cweeks = Convert.ToInt32(row["cycleweeks"].ToString());
                var cpacks = Convert.ToInt32(row["cyclepacks"].ToString());

                int i = 0;

                // MessageBox.Show(pxid);
                nextpackdate = origpackdate;

                while (i < cpacks)
                {

                    cmdadd.Parameters.Clear();
                    cmdadd.Parameters.Add("?", OleDbType.Date, 32).Value = nextpackdate;
                    cmdadd.Parameters.Add("?", OleDbType.Integer, 9).Value = pxid;
                    cmdadd.Parameters.Add("?", OleDbType.Integer, 9).Value = weekdateid;

                    adaptp.SelectCommand = cmdadd;



                    cmdadd.ExecuteNonQuery();


                    nextpackdate = nextpackdate.AddDays(+7);
                   i++;
                }

            }
            con.Close();

        }

        private void dataGridPacked_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridViewRow row = this.dataGridPacked.Rows[dataGridPacked.CurrentCell.RowIndex];
            string packid = row.Cells["packid"].Value.ToString();

            //MessageBox.Show(packid);
            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

            string strpacked = "UPDATE tblpack SET packeduser = ?, packeddate = ? WHERE packid = ?";

            OleDbDataAdapter dataadapter = new OleDbDataAdapter();

            OleDbCommand sqlcom = new OleDbCommand(strpacked, con);

            sqlcom.Parameters.Add("?", OleDbType.VarWChar, 3).Value = User.curuserid;
            sqlcom.Parameters.Add("?", OleDbType.Date, 5).Value = DateTime.Now;
            sqlcom.Parameters.Add("?", OleDbType.Integer, 5).Value = packid;

            dataadapter.SelectCommand = sqlcom;

            con.Open();

            sqlcom.ExecuteNonQuery();
            // row.Cells["clnpackeduser"].Value = User.curuserlogin;
            con.Close();
            row.DefaultCellStyle.BackColor = Color.LightGreen;
            int nRow = dataGridPacked.CurrentCell.RowIndex + 1;
            if (nRow < dataGridPacked.RowCount)
            {
                dataGridPacked.Rows[dataGridPacked.CurrentRow.Index + 1].Selected = true;
            }
            row.Cells["clnreversepack"].Style.Padding = new Padding(0, 0, 0, 0);
            row.Cells["clnpack"].Style.Padding = new Padding(100, 0, 0, 0);
        }

        private void dataGridPacked_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
            DataGridViewColumn col = this.dataGridPacked.Columns[e.ColumnIndex];


            if (e.RowIndex < 0)
                return;
            
            //Assign tick to column
            if (col.Name.Equals("clnpack") && e.CellStyle.BackColor != Color.LightGreen)
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
            if (col.Name.Equals("clnreversepack") && e.CellStyle.BackColor == Color.LightGreen)
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
