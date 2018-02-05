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
    public partial class frmdelivery : Form
    {
        DataSet ds = new DataSet();
        
        public frmdelivery()
        {
            InitializeComponent();
            lblusername.Text = "User: " + User.curusername;
            dataGridChecked.EnableHeadersVisualStyles = false;

        }

        private void frmchecking_Load(object sender, EventArgs e)
        {

            try
            { 
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(@"SELECT strconv(tblpatient.pxlastname,3) + ', ' + strconv(tblpatient.pxfirstname,3) AS pxname, tblpack.cycledate,tblpack.packid, tblpatient.delivery, tblpack.packeduser, tblpack.checkeduser, tblpack.collectuser, tblpack.packcomment, tblpack.active
FROM tblpatient INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid
WHERE (((tblpatient.delivery)=-1) AND ((tblpack.packeduser) Is Not Null) AND ((tblpack.checkeduser) Is Not Null) AND ((tblpack.collectuser) Is Null) AND ((tblpack.active)=-1)) ORDER BY tblpatient.pxlastname,tblpatient.pxfirstname, tblpack.cycledate", con);

                DataSet ds = new DataSet();
                con.Open();
                dataadapter.Fill(ds, "tableData");
                con.Close();


                dataGridChecked.AutoGenerateColumns = false;


                //set column data properties
                
                packid.DataPropertyName = "packid";
                pxname.DataPropertyName = "pxname";
                clnCycleDate.DataPropertyName = "cycledate";
                clnPackComment.DataPropertyName = "packcomment";
                clnactive.DataPropertyName = "active";

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
            dataGridChecked.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridChecked.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

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
                            //string pxcom = null;
                            ////CHeck if this is to be a patient notification too?
                            //if (!string.IsNullOrWhiteSpace(answer))
                            //{
                            //    yesnobox yesnobox = new yesnobox("Use this comment to notify patient on pickup?", "Use notifiction for patient?");


                            //    if (yesnobox.ShowDialog() == DialogResult.Yes)
                            //    {
                            //        pxcom = answer;
                            //    }
                            //    else
                            //    {
                            //        pxcom = "";
                            //    }
                            //}
                            //else
                            //{
                            //    pxcom = "";
                            //}

                            try
                            { 
                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {
                                string strpcom = "UPDATE tblpack SET packcomment = ? WHERE packid= ?";

                                OleDbCommand sqlcom = new OleDbCommand(strpcom, con);
                                OleDbDataAdapter dadapter = new OleDbDataAdapter();


                                sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = answer;
                                //sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = pxcom;
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
                        if (col.Name.Equals("clndelivered"))
                        {


                            DataGridViewRow row = this.dataGridChecked.Rows[e.RowIndex];
                            string packid = row.Cells["packid"].Value.ToString();

                        try { 
                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {

                                string strchecked = "UPDATE tblpack SET collectuser = ?, collectdate = ? , receivedby = ? WHERE packid = ?";

                                using (OleDbDataAdapter dataadapter = new OleDbDataAdapter())
                                {

                                    using (OleDbCommand sqlcom = new OleDbCommand(strchecked, con))
                                    {
                                        sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = User.curuserid;
                                        sqlcom.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                                        sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = "Delivered By " + User.curusername;
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
                            row.Cells["clndelivered"].Style.Padding = new Padding(200, 0, 0, 0);
                           
                        return;

                        }
                        //If col is Reverse pack button
                        if (col.Name.Equals("clnreversecheck"))
                        {


                            DataGridViewRow row = this.dataGridChecked.Rows[e.RowIndex];

                            string packid = row.Cells["packid"].Value.ToString();

                            string strcheckrev = "UPDATE tblpack SET collectuser = NULL, collectdate = NULL, receivedby = NULL WHERE packid= ?";

                        try { 
                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {

                                OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                                OleDbCommand sqlcom = new OleDbCommand(strcheckrev, con);
                                sqlcom.Parameters.Add("?", OleDbType.Integer).Value = packid;

                                dataadapter.SelectCommand = sqlcom;

                                con.Open();

                                sqlcom.ExecuteNonQuery();
                                //row.Cells["clndeliverededuser"].Value = "";
                                con.Close();
                            }

                        }
                        catch (Exception exe)
                        {
                            Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                        }
                        row.DefaultCellStyle.BackColor = Color.White;
                            row.Cells["clnreversecheck"].Style.Padding = new Padding(100, 0, 0, 0);
                            row.Cells["clndelivered"].Style.Padding = new Padding(0, 0, 0, 0);
                           

                        }
                       
                    }
                
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dataGridChecked_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    DataGridViewRow row = this.dataGridChecked.Rows[dataGridChecked.CurrentRow.Index];
                    string packid = row.Cells["packid"].Value.ToString();
                    try
                    { 
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        string strchecked = "UPDATE tblpack SET collectuser = ?, collectdate = ? , receivedby = ? WHERE packid = ?";

                        using (OleDbDataAdapter dataadapter = new OleDbDataAdapter())
                        {

                            using (OleDbCommand sqlcom = new OleDbCommand(strchecked, con))
                            {
                                sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = User.curuserid;
                                sqlcom.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                                sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = "Delivered By " + User.curusername;
                                sqlcom.Parameters.Add("?", OleDbType.Integer).Value = packid;

                                dataadapter.SelectCommand = sqlcom;

                                //run query
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

                    //post button changes to data grid
                    row.DefaultCellStyle.BackColor = Color.FromArgb(129, 183, 143);
                            int nRow = dataGridChecked.CurrentCell.RowIndex + 1;
                            if (nRow < dataGridChecked.RowCount)
                            {
                                dataGridChecked.Rows[dataGridChecked.CurrentRow.Index + 1].Selected = true;
                            }

                            row.Cells["clnreversecheck"].Style.Padding = new Padding(1, 0, 0, 0);
                            row.Cells["clndelivered"].Style.Padding = new Padding(100, 0, 0, 0);

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
            if (col.Name.Equals("clndelivered") && e.CellStyle.BackColor != Color.FromArgb(129, 183, 143) && e.CellStyle.BackColor != Color.FromArgb(179, 165, 177))
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
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmdelivery_Paint(object sender, PaintEventArgs e)
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
