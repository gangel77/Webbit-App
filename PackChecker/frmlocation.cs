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
    public partial class frmlocation : Form
    {
        int newlocationid;
        frmlocationlist _owner;
        string formaction;
        public frmlocation(int locationid, frmlocationlist owner,string action)
        {
            InitializeComponent();
            _owner = owner;
            newlocationid = locationid;
            formaction = action;
        }

        private void frmlocation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websterdbDataSet.tblpacklocation' table. You can move, or remove it, as needed.
            if(formaction == "add")
            { return;
            }else
            {
                this.tblpacklocationTableAdapter.Fill(this.websterdbDataSet.tblpacklocation);
                tblpacklocationBindingSource.Position = this.tblpacklocationBindingSource.Find("locationid", newlocationid);
            }
            
        }



        private void btnsave_Click(object sender, EventArgs e)
        {
            if (formaction == "add")
            {
                //runsql
                OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

                string strins = "INSERT INTO tblpacklocation (locationname,warning,hidelocation) VALUES (?,?,?)";
                OleDbCommand cmd = new OleDbCommand(strins, con);
                OleDbDataAdapter adapt = new OleDbDataAdapter();
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = locationnameTextBox.Text;
                cmd.Parameters.Add("?", OleDbType.Boolean).Value = warningCheckBox.CheckState;
                cmd.Parameters.Add("?", OleDbType.Boolean).Value = hidelocationCheckBox.CheckState;

                adapt.SelectCommand = cmd;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                this.Validate();
                this.tblpacklocationBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.websterdbDataSet);
            }
            _owner.PerformRefresh();
            this.Dispose();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void hidelocationCheckBox_Click(object sender, EventArgs e)
        {
            string state = hidelocationCheckBox.Checked.ToString();

            if (state == "True")
            {
                hidelocationCheckBox.Checked = false;

            }
            else
            {
                OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                string strpxcycles = "SELECT COUNT(*) FROM tblpatient WHERE (packlocation = ? AND active = TRUE) OR (secondarypacklocation = ? AND active = TRUE)";

                OleDbCommand cmd = new OleDbCommand(strpxcycles, con);

                cmd.Parameters.Add("?", OleDbType.Integer).Value = newlocationid;
                cmd.Parameters.Add("?", OleDbType.Integer).Value = newlocationid;
                int count = 0;
                con.Open();
                count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count != 0)
                {
                    msgbox mb = new msgbox("You cannot hide this location, it is in use by " + count + " patients.", "Failed to Hide");
                    mb.ShowDialog();


                    //something


                }
                else
                {
                    hidelocationCheckBox.Checked = true;
                }
            }
        }
    }
}

