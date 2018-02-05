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
        frmpackmenu owner;
        
        public frmpacking(frmpackmenu owner_)
        {
            //string curuser, string curuserid, string curusername
            InitializeComponent();
            lblusername.Text = "User: " + User.curusername;
            //lbluserid.Text = curuserid;
            //lblcuruserlogin.Text = curuser;
            owner = owner_;
            dataGridPacked.EnableHeadersVisualStyles = false;
            

        }
        double counttopack;
        int weekid;
        double count = new double();
        double nonpackcount = new double();
        //private void countpacks(OleDbConnection con, object sender, EventArgs e)
        //{

        //    Utility.checktopack(out counttopack, out weekid);
        //    count = Convert.ToInt32(counttopack);

            

        //    if (count == 0)
        //    {
        //        using (yesnobox yn = new yesnobox("It looks like all packs are made! Would you like to create a new packing cycle?", "Check New Cycle"))
        //        {
        //            if (yn.ShowDialog() == DialogResult.Yes)
        //            {
        //                Utility.updateallpx(sender, e);
        //                Utility.addcycle();
        //                Utility.checktopack(out counttopack, out weekid);
        //                count = Convert.ToInt32(counttopack);
        //            }
        //            else
        //            {
        //                this.Close();
        //                this.Dispose();
        //            }
        //        }
        //    }

        //}

        private void countpacksnotincycle()
        {
            nonpackcount = 0;
            foreach (DataGridViewRow rows in dataGridPacked.Rows)
            {
                if (Convert.ToInt32(rows.Cells["clnweekid"].Value) != weekid)
                {
                    nonpackcount++;
                }
            }
        }

        string s;
        string s2;
        private void frmpacking_Load(object sender, EventArgs e)
        {
            Utility.checktopack(out counttopack, out weekid);
            count = Convert.ToInt32(counttopack);
            //countpacks(con);
            if (count == 0)
            {
                using (yesnobox yn = new yesnobox("It looks like all packs are made! Would you like to create the next packing cycle?", "Check New Cycle"))
                {
                    if (yn.ShowDialog() == DialogResult.Yes)
                    {
                        
                        startplash("Creating Pack Cycle");
                        Utility.updateallpx(sender, e, "packing");
                        Utility.addcycle();
                        Utility.checktopack(out counttopack, out weekid);
                        count = Convert.ToInt32(counttopack);
                        stopsplash();
                    }
                    else
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                }
            }

            rebuildtable(sender, e);
            dataGridPacked.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridPacked.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;


        }

        private void rebuildtable(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    
                    string strpack = @"SELECT StrConv(tblpatient.pxlastname,3)+', '+StrConv(tblpatient.pxfirstname,3) AS pxname, tblpatient.pxlastname, tblpatient.active, tblpatient.pxfirstname, tblpacksize.sizename, tblcycle.cyclecode, tblpack.cycledate, tblpack.packcomment, tblcycle.cyclepacks, tblpack.active, tblpack.patientnote, tblpack.packid, tblpack.packeduser, tblweek.weekid
FROM tblweek INNER JOIN ((tblpacksize INNER JOIN (tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid) ON tblpacksize.packsizeid = tblpatient.traysize) INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid) ON tblweek.weekid = tblpack.origcycledateid
WHERE (((tblpack.active)=True) AND ((tblpack.packeduser) Is Null))
ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname, tblpack.cycledate;";
                    //OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString());
                    using (OleDbDataAdapter dataadapter = new OleDbDataAdapter(strpack, con))
                    {


                        using (DataSet ds = new DataSet())
                        {
                            con.Open();
                            dataadapter.Fill(ds, "tableData");
                            con.Close();
                            dataGridPacked.AutoGenerateColumns = false;


                            //ALLOCATE COLUMNS TO DATA
                            packid.DataPropertyName = "packid";

                            pxname.DataPropertyName = "pxname";

                            clnCycleDate.DataPropertyName = "cycledate";

                            clncode.DataPropertyName = "cyclecode";

                            clnPackComment.DataPropertyName = "packcomment";
                            clnweekid.DataPropertyName = "weekid";
                            clnpacksize.DataPropertyName = "sizename";
                            clnactive.DataPropertyName = "active";
                            dataGridPacked.DataSource = ds;
                            dataGridPacked.DataMember = "tableData";
                        }
                    }


                    foreach (DataGridViewRow row in dataGridPacked.Rows)
                    {
                        if (row.Cells["clnPackComment"].Value.ToString() != "")
                        {
                            row.DefaultCellStyle.BackColor = Color.LightBlue;
                        }

                        if (Convert.ToInt32(row.Cells["clnweekid"].Value) != weekid)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                        }

                    }
                    countpacksnotincycle();
                    updatecountlabels();
                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
        }

        private void updatecountlabels()
        {
            if (count != 1)
            {
                s = "s";
            }
            else
            {
                s = "";
            }

            if (nonpackcount != 1)
            {
                s2 = "s";
            }
            else
            {
                s2 = "";
            }
            lblcount.Text = count + " Pack" + s + " left in this cycle";
            lblcountnotcycle.Text = nonpackcount + " Pack" + s2 + " from other cycles";
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
                            string answer = null;

                            //string input = Interaction.InputBox("Enter new message here", "Pack Comment", cellvalue, -1, -1);
                            using (inputbox inputbox = new inputbox("Enter Comment", "Pack Comment", cellvalue))
                            {
                                
                                if (inputbox.ShowDialog() == DialogResult.OK)
                                {
                                    //MessageBox.Show(inputbox.answer);
                                    answer = inputbox.answer;

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


                                string strpcom = "UPDATE tblpack SET packcomment = ? WHERE packid= ?";

                                using (OleDbCommand sqlcom = new OleDbCommand(strpcom, con))
                                {

                                    using (OleDbDataAdapter dadapter = new OleDbDataAdapter())
                                    {
                                        

                                            string userbrack = null;

                                        if (!string.IsNullOrWhiteSpace(answer))
                                        {
                                            userbrack = " (" + User.curusername + ")";
                                        }

                                        sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = answer + userbrack;
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
        private void dataGridPacked_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    

                        //Figure out which button we jsut pressed
                        DataGridViewColumn col = this.dataGridPacked.Columns[e.ColumnIndex];

                        //IF we are in the Column pack, do this
                        if (col.Name.Equals("clnpack"))
                        {


                            DataGridViewRow row = this.dataGridPacked.Rows[e.RowIndex];
                            dopack(row, sender, e);

                        }
                        //If col is Reverse pack button
                        if (col.Name.Equals("clnreversepack"))
                        {


                            DataGridViewRow row = this.dataGridPacked.Rows[e.RowIndex];

                            string packid = row.Cells["packid"].Value.ToString();

                            string strpackrev = "UPDATE tblpack SET packeduser = NULL, packeddate = NULL WHERE packid= ?";
                            try
                            { 
                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {

                                using (OleDbDataAdapter dataadapter = new OleDbDataAdapter())
                                {

                                    using (OleDbCommand sqlcom = new OleDbCommand(strpackrev, con))
                                    {
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
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.Cells["clnpackeduser"].Value = "";
                    row.Cells["btndeactivate"].Style.Padding = new Padding(0, 0, 0, 0);
                    row.Cells["clnreversepack"].Style.Padding = new Padding(100, 0, 0, 0);
                            row.Cells["clnpack"].Style.Padding = new Padding(0, 0, 0, 0);

                    if(Convert.ToInt32(row.Cells["clnweekid"].Value) == weekid)

                    {
                        count++;
                    }else
                    {
                        nonpackcount++;
                    }
                    updatecountlabels(); 
                            
                        }

                if (col.Name.Equals("btndeactivate"))
                {
                    //Figure out which button we jsut pressed
                    DataGridViewRow row = this.dataGridPacked.Rows[e.RowIndex];

                    //string pxid = row.Cells["clnpatientid"].Value.ToString();
                    string packid = row.Cells["packid"].Value.ToString();

                    string cycledate = row.Cells["clncycledate"].Value.ToString();
                    

                    string answer;
                    //check if they are sure they want to run error creator


                    yesnobox yn = new yesnobox("This pack will be removed from the packing cycle, are you sure?", "Check Deactivation");

                    if (yn.ShowDialog() == DialogResult.No)
                    {
                        return;
                    }
                    row = this.dataGridPacked.Rows[e.RowIndex];


                    inputbox inputbox = new inputbox("Why is this pack being deactivated?", "Deactivation", "");
                    

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

                    

                    


                    int nRow = dataGridPacked.CurrentCell.RowIndex + 1;
                    if (nRow < dataGridPacked.RowCount)
                    {
                        dataGridPacked.Rows[dataGridPacked.CurrentRow.Index + 1].Selected = true;
                    }
                    
                    
                    row.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);
                    row.Cells["clnpack"].Style.Padding = new Padding(100, 0, 0, 0);
                    if (Convert.ToInt32(row.Cells["clnweekid"].Value) == weekid)

                    {
                        count--;
                    }
                    else
                    {
                        nonpackcount--;
                    }
                    updatecountlabels();
                }

            }
            
        }

        private void dopack(DataGridViewRow row, object sender, EventArgs e)
        {
            string packid = row.Cells["packid"].Value.ToString();

            //MessageBox.Show(packid);
            try
            { 
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {

                string strpacked = "UPDATE tblpack SET packeduser = ?, packeddate = ? WHERE packid = ?";

                using (OleDbDataAdapter dataadapter = new OleDbDataAdapter())
                {

                    using (OleDbCommand sqlcom = new OleDbCommand(strpacked, con))
                    {

                        sqlcom.Parameters.Add("?", OleDbType.VarChar).Value = User.curuserid;
                        sqlcom.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                        sqlcom.Parameters.Add("?", OleDbType.Integer).Value = packid;

                        dataadapter.SelectCommand = sqlcom;

                        con.Open();

                        sqlcom.ExecuteNonQuery();
                        // row.Cells["clnpackeduser"].Value = User.curuserlogin;
                        con.Close();
                    }
                }
            }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }



            row.DefaultCellStyle.BackColor = Color.FromArgb(129, 183, 143);
            int nRow = dataGridPacked.CurrentCell.RowIndex + 1;
            if (nRow < dataGridPacked.RowCount)
            {
                dataGridPacked.Rows[dataGridPacked.CurrentRow.Index + 1].Selected = true;
            }
            row.Cells["btndeactivate"].Style.Padding = new Padding(100, 0, 0, 0);
            row.Cells["clnpackeduser"].Value = User.curuserid;
            row.Cells["clnreversepack"].Style.Padding = new Padding(1, 0, 0, 0);
            row.Cells["clnpack"].Style.Padding = new Padding(100, 0, 0, 0);

            if (Convert.ToInt32(row.Cells["clnweekid"].Value) == weekid)

            {
                count--;
            }
            else
            {
                nonpackcount--;
            }
            updatecountlabels();
        }
        
        private void btnclose_Click(object sender, EventArgs e)
        {
            
            
            double counttotal;
            
            try
            { 
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {

                Utility.checktopack(out count, out weekid);
                    Utility.checktotalpacks(out counttotal);

                if (count == 0)
                {

                    using (yesnobox yn = new yesnobox("It looks like all packs are made! Would you like to create the next packing cycle?", "Check New Cycle"))
                    {
                        if (yn.ShowDialog() == DialogResult.Yes)
                        {
                                startplash("Creating Pack Cycle");
                                Utility.updateallpx(sender, e,"packing");
                                Utility.addcycle();
                                Utility.checktopack(out count, out weekid);
                                rebuildtable(sender, e);
                                stopsplash();
                            return;
                        }
                    }


                }
                
                // Utility.findpackvalues(out counttopack, out countocheck, out counttotal);
                owner.recreatecircle(count, counttotal);


                    DialogResult = DialogResult.Cancel;
                
            }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
        }
        

        private void dataGridPacked_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    DataGridViewRow row = this.dataGridPacked.Rows[dataGridPacked.CurrentCell.RowIndex];
                    
                    if (row.Cells["clnpackeduser"].Value == null || string.IsNullOrEmpty(row.Cells["clnpackeduser"].Value.ToString()))
                    {
                        dopack(row, sender, e);
                    }
                    break;

                default:
                    base.OnKeyDown(e);
                    break;

            }
        }

        private void frmpacking_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = Color.FromArgb(31, 134, 73);
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

        private void dataGridPacked_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
            DataGridViewColumn col = this.dataGridPacked.Columns[e.ColumnIndex];


            if (e.RowIndex < 0)
                return;
            
            //Assign tick to column
            if (col.Name.Equals("clnpack") && e.CellStyle.BackColor != Color.FromArgb(129, 183, 143) && e.CellStyle.BackColor != Color.DarkGray)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = dataGridPacked.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.tick, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            
            //Assign undo to cell if pack is packed
            if (col.Name.Equals("clnreversepack") && e.CellStyle.BackColor == Color.FromArgb(129, 183, 143) && e.CellStyle.BackColor != Color.DarkGray)
            {
                //
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = dataGridPacked.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.undo, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (col.Name.Equals("btndeactivate") && e.CellStyle.BackColor != Color.FromArgb(129, 183, 143) && e.CellStyle.BackColor != Color.DarkGray)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = dataGridPacked.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.deactivate, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

        }

        private void dataGridPacked_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblcount_Click(object sender, EventArgs e)
        {

        }

        string splashtext;
        FrmSplash splashy;
        private void startplash(string starttext)
        {
            if (!backgroundWorker1.IsBusy)
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            splashy = new FrmSplash();
            splashy.SetStatus(splashtext);
            splashy.ShowDialog();
        }
    }
   
}
