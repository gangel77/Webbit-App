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
        }

        private void tblpacksizeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblpacksizeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.websterdbDataSet);

        }

        private void frmtraysizelist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websterdbDataSet.tblpacksize' table. You can move, or remove it, as needed.
            this.tblpacksizeTableAdapter.Fill(this.websterdbDataSet.tblpacksize);
            DataGridpacksize.ClearSelection();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void PerformRefresh()
        {
            this.tblpacksizeTableAdapter.Fill(this.websterdbDataSet.tblpacksize);
        }

        private void DataGridpacksize_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                var senderGrid = (DataGridView)sender;

            DataGridViewColumn col = this.DataGridpacksize.Columns[e.ColumnIndex];
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    (col.Name.Equals("clndelete")))
                {
                   
                    
                        DataGridViewRow row = this.DataGridpacksize.Rows[e.RowIndex];
                        string sizeid = row.Cells["clnpacksizeid"].Value.ToString();
                        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

                        string strcountset = "SELECT COUNT(*) FROM tblsettings WHERE settingactive = ? and settingid = 10";

                        OleDbCommand cmdcountset = new OleDbCommand(strcountset, con);
                        cmdcountset.Parameters.Add("?", OleDbType.Integer).Value = sizeid;

                        int count;
                        con.Open();
                        count = (int)cmdcountset.ExecuteScalar();
                        con.Close();

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

                        OleDbCommand cmdcount = new OleDbCommand(strcount, con);
                        cmdcount.Parameters.Add("?", OleDbType.Integer).Value = sizeid;


                        con.Open();
                        count = (int)cmdcount.ExecuteScalar();
                        con.Close();

                        if (count > 0)
                        {
                            yesnobox yn2 = new yesnobox("There are " + count + " patients using this pack size." + Environment.NewLine + "Deleting will change them to the default size, ok?", "Size being used");
                            if (yn2.ShowDialog() == DialogResult.No)
                            {
                                return;
                            }else
                            {       //get default size
                                string strdef = "SELECT settingactive FROM tblsettings WHERE settingid = 10";
                                OleDbCommand cmddef = new OleDbCommand(strdef, con);
                                string defpack;                               
                                con.Open();
                                defpack = (string)cmddef.ExecuteScalar();
                                con.Close();

                                //update all px to default
                                string strup = "UPDATE tblpatient SET traysize = ? WHERE traysize = ?";

                                OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                                OleDbCommand sqlcom = new OleDbCommand(strup, con);

                                sqlcom.Parameters.Add("?", OleDbType.Integer).Value = defpack;
                                sqlcom.Parameters.Add("?", OleDbType.Integer).Value = sizeid;

                                dataadapter.SelectCommand = sqlcom;
                                con.Open();
                                sqlcom.ExecuteNonQuery();
                                con.Close();

                                string strdel = "DELETE * FROM tblpacksize WHERE packsizeid = ?";

                                OleDbDataAdapter dataadapter1 = new OleDbDataAdapter();

                                OleDbCommand sqlcom2 = new OleDbCommand(strdel, con);
                                sqlcom.Parameters.Add("?", OleDbType.Integer, 5).Value = sizeid;
                                dataadapter1.SelectCommand = sqlcom2;

                                con.Open();
                                sqlcom2.ExecuteNonQuery();
                                con.Close();

                                msgbox mb = new msgbox("Tray Size has been deleted.", "Done!");
                                mb.ShowDialog();
                                this.tblpacksizeTableAdapter.Fill(this.websterdbDataSet.tblpacksize);
                                this.tblpacksizeTableAdapter.Fill(this.websterdbDataSet.tblpacksize);
                            }

                        }
                        else
                        {



                            string strdel = "DELETE * FROM tblpacksize WHERE packsizeid = ?";

                            OleDbDataAdapter dataadapter = new OleDbDataAdapter();

                            OleDbCommand sqlcom = new OleDbCommand(strdel, con);
                            sqlcom.Parameters.Add("?", OleDbType.Integer, 5).Value = sizeid;
                            dataadapter.SelectCommand = sqlcom;

                            con.Open();
                            sqlcom.ExecuteNonQuery();
                            con.Close();

                            msgbox mb = new msgbox("Tray Size has been deleted.", "Done!");
                            mb.ShowDialog();
                            this.tblpacksizeTableAdapter.Fill(this.websterdbDataSet.tblpacksize);

                        }
                    
                        
                    
                }
            
        }

        private void btnunlock_Click(object sender, EventArgs e)
        {
            int pass = Utility.userreq("admin");
            if (pass == 0)
            {
                return;
            }

            DataGridpacksize.Enabled = true;
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            frmtraysize ft = new frmtraysize("add",this);
            ft.ShowDialog();
        }
    }
}
