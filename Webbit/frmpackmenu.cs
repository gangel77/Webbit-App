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
using System.Threading;

namespace PackChecker
{
    public partial class frmpackmenu : UserControl
    {
        double counttopack, counttocheck, counttotal;
        int w = new int();
        int origw = new int();
        public frmpackmenu(double topack, double tocheck, double total)
        {
            InitializeComponent();
            counttopack = topack;
            counttocheck = tocheck;
            counttotal = total;
            origw = panel1.Size.Width;
            w = origw / 3;
        }
        
        private void btnopenfrmpack_Click(object sender, EventArgs e)
        {
            

            int pass = Utility.userreq("pack");
            if (pass == 0)
            {
                return;
            }
            //int weekid;
            //Utility.checktopack(out counttopack,out weekid);
            frmpacking frmpacking = new frmpacking(this);
            frmpacking.ShowDialog();
            
        }

        private void dataGridmessage_SelectionChanged(object sender, EventArgs e)
        {
            dataGridmessage.ClearSelection();
        }

        private void dataGridmessage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {


                //Figure out which button we jsut pressed
                DataGridViewColumn col = this.dataGridmessage.Columns[e.ColumnIndex];

                //IF we are in the Column pack, do this
                if (col.Name.Equals("clnview"))
                {
                    DataGridViewRow row = this.dataGridmessage.Rows[e.RowIndex];
                    string msg = row.Cells["clnmessage"].Value.ToString();
                    using (msgbox mb = new msgbox( msg,"New Message"))
                    {
                        mb.ShowDialog();
                    }
                }

                if (col.Name.Equals("clnaccept"))
                {
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        string newmessage = @"UPDATE tblmessage SET dateactioned = ?, actionedid = ? WHERE messageid = ?";

                        using (OleDbCommand cmd = new OleDbCommand(newmessage, con))
                        {
                            DataGridViewRow row = this.dataGridmessage.Rows[e.RowIndex];

                            int pass = Utility.userreq("pack");
                            if (pass == 0)
                            {
                                return;
                            }
                            int msgid = Convert.ToInt32(row.Cells["clnmessageid"].Value);

                            cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                            cmd.Parameters.Add("?", OleDbType.Integer).Value = User.curuserid;
                            cmd.Parameters.Add("?", OleDbType.Integer).Value = msgid;
                            

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            
                        }
                    }
                    using (msgbox mb = new msgbox("Message Received", "Received"))
                    {
                        mb.ShowDialog();
                    }
                    reloadtable(sender, e);
                }
            }
        
        }

        private void btnaccepted_Click(object sender, EventArgs e)
        {
            if (btnaccepted.ButtonText != "Show New")
            {
                reloadtableaccepted(sender, e);
                btnaccepted.ButtonText = "Show New";
                clnactioneddate.Visible = true;
                clnacceptuser.Visible = true;
                clnaccept.Visible = false;
            }
            else
            {
                reloadtable(sender, e);
               
            }
            
        }

        private void frmpackmenu_Load(object sender, EventArgs e)
        {
            //Utility.checktopack(out counttopack);
            //Utility.checktocheck(out counttocheck);
            //Utility.checktotalpacks(out counttotal);
            
            
            reloadtable(sender, e);

        }

        private void btnmessages_Click(object sender, EventArgs e)
        {
           
            reloadtableaccepted(sender, e);
            btnaccepted.ButtonText = "Show New";
            clnactioneddate.Visible = true;
            clnacceptuser.Visible = true;
            clnaccept.Visible = false;
            panelgridarea.Visible = true;
            
            panel1.Width = w;
            
        }

        private void dataGridmessage_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridViewColumn col = this.dataGridmessage.Columns[e.ColumnIndex];


            if (e.RowIndex < 0)
                return;

            //Assign tick to column
            if (col.Name.Equals("clnaccept") )
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = dataGridmessage.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.tick, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (col.Name.Equals("clnview"))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = dataGridmessage.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.view, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        public void reloadtable(object sender, EventArgs e)
        {
            btnaccepted.ButtonText = "Show Accepted";
            clnactioneddate.Visible = false;
            clnacceptuser.Visible = false;
            clnaccept.Visible = true;
            DataSet ds = new DataSet();
            try
            {
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    string sqlcollect = @"SELECT tbluser_1.userfirstname AS actioneduser, tbluser.userfirstname AS sender, tblmessage.messagetext, tblmessage.datesent, tblmessage.dateactioned, StrConv([pxfirstname],3)+' '+StrConv([pxlastname],3) AS pxname, tblmessage.messageid
FROM tbluser AS tbluser_1 RIGHT JOIN (tbluser INNER JOIN (tblmessage INNER JOIN tblpatient ON tblmessage.patientid = tblpatient.patientid) ON tbluser.userid = tblmessage.senderid) ON tbluser_1.userid = tblmessage.actionedid
WHERE (((tblmessage.dateactioned) Is Null))
ORDER BY tblmessage.datesent";

                    using (OleDbDataAdapter dataadapter = new OleDbDataAdapter(sqlcollect, con))
                    {



                        
                        con.Open();
                        dataadapter.Fill(ds, "tableData");
                        con.Close();
                        dataGridmessage.AutoGenerateColumns = false;

                        

                        clnacceptuser.DataPropertyName = "actioneduser";

                        clnsender.DataPropertyName = "sender";

                        clnactioneddate.DataPropertyName = "dateactioned";

                        clnmsgdate.DataPropertyName = "datesent";

                        clnpatient.DataPropertyName = "collectdate";

                        clnpatient.DataPropertyName = "pxname";
                        clnmessageid.DataPropertyName = "messageid";
                        clnmessage.DataPropertyName = "messagetext";
                        dataGridmessage.DataSource = ds;
                        dataGridmessage.DataMember = "tableData";
                    }


                    
                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
            dataGridmessage.ClearSelection();
            if(ds.Tables["tableData"].Rows.Count == 0)
            {
                panelgridarea.Visible = false;
                panel1.Width = origw;
                //panel1.Location = new Point(351, 134);
                //panel1.Width = 950;
            }
            else
            {
               
                panel1.Width = w;
                panelgridarea.Visible = true;
                
                //panel1.Location = new Point(24, 134);
            }
        }

        

        

        private void reloadtableaccepted(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    string sqlcollect = @"SELECT tbluser_1.userfirstname AS actioneduser, tbluser.userfirstname AS sender, tblmessage.messagetext, tblmessage.datesent, tblmessage.dateactioned, StrConv([pxfirstname],3)+' '+StrConv([pxlastname],3) AS pxname, tblmessage.messageid
FROM tbluser AS tbluser_1 RIGHT JOIN (tbluser INNER JOIN (tblmessage INNER JOIN tblpatient ON tblmessage.patientid = tblpatient.patientid) ON tbluser.userid = tblmessage.senderid) ON tbluser_1.userid = tblmessage.actionedid
WHERE (((tblmessage.dateactioned) Is Not Null))
ORDER BY tblmessage.datesent desc";

                    using (OleDbDataAdapter dataadapter = new OleDbDataAdapter(sqlcollect, con))
                    {



                        DataSet ds = new DataSet();
                        con.Open();
                        dataadapter.Fill(ds, "tableData");
                        con.Close();
                        dataGridmessage.AutoGenerateColumns = false;



                        clnacceptuser.DataPropertyName = "actioneduser";

                        clnsender.DataPropertyName = "sender";

                        clnactioneddate.DataPropertyName = "dateactioned";

                        clnmsgdate.DataPropertyName = "datesent";

                        clnpatient.DataPropertyName = "collectdate";

                        clnpatient.DataPropertyName = "pxname";
                        clnmessageid.DataPropertyName = "messageid";
                        clnmessage.DataPropertyName = "messagetext";
                        dataGridmessage.DataSource = ds;
                        dataGridmessage.DataMember = "tableData";
                    }



                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
            dataGridmessage.ClearSelection();
        }

        public void recreatecircle(double counttopack,double counttotal)
        {
            circprogpack.Minimum = 0;
            circprogpack.Maximum = Convert.ToInt32(counttotal);
            

            int curperc;
            if (counttotal == 0)
            {
                curperc = 0;
            }
            else
            {
                curperc = Convert.ToInt32(((counttotal - counttopack) / counttotal) * 100);
            }
            
            
            circprogpack.Value = Convert.ToInt32((counttotal - counttopack));
           
            //if (curperc == 100)
            //{
            //    curperc = 1000;
            //}
            circprogpack.Text = curperc.ToString();
            
            
        }

    }
}

