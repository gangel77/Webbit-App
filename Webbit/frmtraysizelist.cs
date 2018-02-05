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
    public partial class frmtraysizelist : Form
    {
        public frmtraysizelist()
        {
            InitializeComponent();
            DataGridpacksize.EnableHeadersVisualStyles = false;
        }

        private void tblpacksizeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            { 
            this.Validate();
            this.tblpacksizeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.webbitdbdataset);
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }

        }

        private void frmtraysizelist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'webbitdbdataset.tblpacksize' table. You can move, or remove it, as needed.
            try
            { 
            this.tblpacksizeTableAdapter.Fill(this.webbitdbdataset.tblpacksize);
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
            DataGridpacksize.ClearSelection();

        }
        public bool succeed;
        private void btnclose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tblpacksizeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.webbitdbdataset);
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
            succeed = true;
            this.Close();
            this.Dispose();

        }
        public void PerformRefresh()
        {
            this.tblpacksizeTableAdapter.Fill(this.webbitdbdataset.tblpacksize);
        }

        private void DataGridpacksize_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int count = 0;

           

            DataGridViewColumn col = this.DataGridpacksize.Columns[e.ColumnIndex];
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (col.Name.Equals("clndelete"))
                {




                    DataGridViewRow row = this.DataGridpacksize.Rows[e.RowIndex];
                    string sizeid = row.Cells["clnpacksizeid"].Value.ToString();

                    try
                    {
                        using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                        {

                            string strcountset = "SELECT COUNT(*) FROM tblsettings WHERE settingactive = ? and settingid = 10";

                            using (OleDbCommand cmdcountset = new OleDbCommand(strcountset, con))
                            {
                                cmdcountset.Parameters.Add("?", OleDbType.Integer).Value = sizeid;


                                con.Open();
                                count = (int)cmdcountset.ExecuteScalar();
                                con.Close();
                            }

                        }
                    }
                    catch (Exception exe)
                    {
                        Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                    }

                    if (count > 0)
                    {
                        msgbox mb = new msgbox("This is your default size, you can't delete it!", "Can't delete!");
                        mb.ShowDialog();
                        return;
                    }

                    yesnobox yn = new yesnobox("Are you sure you want to delete this pack size?", "Double Check");
                    if (yn.ShowDialog() == DialogResult.No)
                    {
                        return;
                    }

                    string strcount = "SELECT COUNT(*) FROM tblpatient WHERE traysize = ?";
                    try
                    {
                        using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                        {
                            using (OleDbCommand cmdcount = new OleDbCommand(strcount, con))
                            {
                                cmdcount.Parameters.Add("?", OleDbType.Integer).Value = sizeid;


                                con.Open();
                                count = (int)cmdcount.ExecuteScalar();
                                con.Close();
                            }

                        }
                    }
                    catch (Exception exe)
                    {
                        Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                    }
                    string defpack = "";
                    if (count > 0)
                    {
                        yesnobox yn2 = new yesnobox("There are " + count + " patients using this pack size." + Environment.NewLine + "Deleting will change them to the default size, ok?", "Size being used");
                        if (yn2.ShowDialog() == DialogResult.No)
                        {
                            return;
                        }
                        else
                        {       //get default size
                            string strdef = "SELECT settingactive FROM tblsettings WHERE settingid = 10";

                            try
                            {
                                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                {
                                    using (OleDbCommand cmddef = new OleDbCommand(strdef, con))
                                    {

                                        con.Open();
                                        defpack = (string)cmddef.ExecuteScalar();
                                        con.Close();

                                    }
                                }
                            }
                            catch (Exception exe)
                            {
                                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                            }

                            //update all px to default
                            string strup = "UPDATE tblpatient SET traysize = ? WHERE traysize = ?";
                            try
                            {
                                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                {
                                    using (OleDbDataAdapter dataadapter = new OleDbDataAdapter())
                                    {

                                        using (OleDbCommand sqlcom = new OleDbCommand(strup, con))
                                        {

                                            sqlcom.Parameters.Add("?", OleDbType.Integer).Value = defpack;
                                            sqlcom.Parameters.Add("?", OleDbType.Integer).Value = sizeid;

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

                            string strdel = "DELETE * FROM tblpacksize WHERE packsizeid = ?";
                            try
                            {
                                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                {
                                    using (OleDbDataAdapter dataadapter1 = new OleDbDataAdapter())
                                    {

                                        using (OleDbCommand sqlcom2 = new OleDbCommand(strdel, con))
                                        {
                                            sqlcom2.Parameters.Add("?", OleDbType.Integer, 5).Value = sizeid;
                                            dataadapter1.SelectCommand = sqlcom2;

                                            con.Open();
                                            sqlcom2.ExecuteNonQuery();
                                            con.Close();
                                        }
                                    }

                                }
                            }
                            catch (Exception exe)
                            {
                                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                            }

                            msgbox mb = new msgbox("Tray Size has been deleted.", "Done!");
                            mb.ShowDialog();
                            this.tblpacksizeTableAdapter.Fill(this.webbitdbdataset.tblpacksize);

                        }

                    }
                    else
                    {



                        string strdel = "DELETE * FROM tblpacksize WHERE packsizeid = ?";
                        try
                        {
                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {
                                using (OleDbDataAdapter dataadapter = new OleDbDataAdapter())
                                {

                                    using (OleDbCommand sqlcom = new OleDbCommand(strdel, con))
                                    {
                                        sqlcom.Parameters.Add("?", OleDbType.Integer, 5).Value = sizeid;
                                        dataadapter.SelectCommand = sqlcom;

                                        con.Open();
                                        sqlcom.ExecuteNonQuery();
                                        con.Close();

                                        msgbox mb = new msgbox("Tray Size has been deleted.", "Done!");
                                        mb.ShowDialog();
                                        this.tblpacksizeTableAdapter.Fill(this.webbitdbdataset.tblpacksize);
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

                if (col.Name.Equals("clnedit"))
                {
                    int pass = Utility.userreq("webadmin");
                    if (pass == 0)
                    {
                        return;
                    }
                    DataGridViewRow row = this.DataGridpacksize.Rows[e.RowIndex];

                    frmtraysize frmtraysize = new frmtraysize("edit", this, Convert.ToInt32(row.Cells["sizeorder"].Value), Convert.ToInt32(row.Cells["clnpacksizeid"].Value));
                    frmtraysize.ShowDialog();
                    

                }




                }
        }

        private void btnunlock_Click(object sender, EventArgs e)
        {
            int pass = Utility.userreq("webadmin");
            if (pass == 0)
            {
                return;
            }

            DataGridpacksize.Enabled = true;
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            int pass = Utility.userreq("webadmin");
            if (pass == 0)
            {
                return;
            }
            int nextorder;
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                string sqlmax = @"SELECT Max(tblpacksize.sizeorder) AS MaxOfsizeorder
                                    FROM tblpacksize;";

                    using (OleDbCommand sqlcom = new OleDbCommand(sqlmax, con))
                    {
                    con.Open();
                    nextorder = Convert.ToInt32(sqlcom.ExecuteScalar().ToString());
                    con.Close();

                    }
                nextorder++;
            }
                        frmtraysize ft = new frmtraysize("add",this, nextorder,1);
            ft.ShowDialog();
        }

        private void DataGridpacksize_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            DataGridViewColumn col = this.DataGridpacksize.Columns[e.ColumnIndex];


            if (e.RowIndex < 0)
                return;

            //Assign tick to column
            if (col.Name.Equals("clndelete") && e.CellStyle.BackColor != Color.FromArgb(129, 183, 143))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = DataGridpacksize.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.cross, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (col.Name.Equals("clnedit") && e.CellStyle.BackColor != Color.FromArgb(129, 183, 143))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = DataGridpacksize.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit, new Rectangle(x, y, w, h));
                e.Handled = true;
            }


        }

        private void frmtraysizelist_Paint(object sender, PaintEventArgs e)
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

        private void DataGridpacksize_SelectionChanged(object sender, EventArgs e)
        {
            DataGridpacksize.ClearSelection();
        }
    }


}

