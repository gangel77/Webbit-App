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
    public partial class frmtraysize : Form
    {
        frmtraysizelist _owner;
        string formaction;
        public frmtraysize(string action, frmtraysizelist owner)
        {
            InitializeComponent();
            _owner = owner;
            formaction = action;
        }

        private void tblpacksizeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblpacksizeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.websterdbDataSet);

        }

        private void frmtraysize_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websterdbDataSet.tblpacksize' table. You can move, or remove it, as needed.
            if (formaction == "add")
            {
                sizeorderTextBox.Text = "1";
            }
            else
            {
                this.tblpacksizeTableAdapter.Fill(this.websterdbDataSet.tblpacksize);

            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (formaction == "add")
            {
                //runsql
                OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                try
                {
                    string strins = "INSERT INTO tblpacksize (sizename,sizelongname,sizecomment,sizeorder) VALUES (?,?,?,?)";
                    OleDbCommand cmd = new OleDbCommand(strins, con);
                    OleDbDataAdapter adapt = new OleDbDataAdapter();
                    cmd.Parameters.Add("?", OleDbType.VarWChar).Value = sizenameTextBox.Text;
                    cmd.Parameters.Add("?", OleDbType.VarWChar).Value = sizelongnameTextBox.Text;
                    cmd.Parameters.Add("?", OleDbType.VarWChar).Value = sizecommentTextBox.Text;
                    cmd.Parameters.Add("?", OleDbType.VarWChar).Value = sizeorderTextBox.Text;
                    
                    adapt.SelectCommand = cmd;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Error creating pack size");
                }

            }
            else
            {
                this.Validate();
                this.tblpacksizeBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(this.websterdbDataSet);
            }
            _owner.PerformRefresh();
            this.Dispose();
        }



    }  
    
}
