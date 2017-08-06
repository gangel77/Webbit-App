using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace PackChecker
{
    public partial class frmuser : Form
    {
        int newuserid;
        frmuserlist _owner;
        string formaction;
        public frmuser(int userid, frmuserlist owner,string action)
        {
            InitializeComponent();
            _owner = owner;
            newuserid = userid;
            formaction = action;
            dataGridjob.ClearSelection();
            
        }

        private void frmlocation_Load(object sender, EventArgs e)
        {

            this.tbljobTableAdapter.Fill(this.websterdbDataSet.tbljob);

            

            if (formaction == "add")
            {
                
            }
            else
            {
                this.tbluserTableAdapter.Fill(this.websterdbDataSet.tbluser);
                tbluserBindingSource.Position = this.tbluserBindingSource.Find("userid", newuserid);
            }

            greenticks();
        }

        private void greenticks()
        {
            foreach (DataGridViewRow row2 in dataGridjob.Rows)
            {
                for (int i = 0; i < dataGridjob.Columns.Count; i++)
                {
                    if (row2.Cells[i].Value.ToString() == "True")
                    {
                        row2.Cells[i].Style.BackColor = Color.LightGreen;
                        row2.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                    }else
                    {
                        row2.DefaultCellStyle.SelectionBackColor = Color.White;
                    }


                }


            }
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            if (formaction == "add")
            {
                //runsql
                OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                try
                {
                    string strins = "INSERT INTO tbluser (userfirstname,userlastname,userlogin,userpass,userjobid) VALUES (?,?,?,?,?)";
                    OleDbCommand cmd = new OleDbCommand(strins, con);
                    OleDbDataAdapter adapt = new OleDbDataAdapter();
                    cmd.Parameters.Add("?", OleDbType.VarWChar).Value = userfirstnameTextBox.Text;
                    cmd.Parameters.Add("?", OleDbType.VarWChar).Value = userlastnameTextBox.Text;
                    cmd.Parameters.Add("?", OleDbType.VarWChar).Value = userloginTextBox.Text;
                    cmd.Parameters.Add("?", OleDbType.VarWChar).Value = userpassTextBox.Text;
                    cmd.Parameters.Add("?", OleDbType.VarWChar).Value = Convert.ToInt32(cmbjob.SelectedIndex) + 1;

                    adapt.SelectCommand = cmd;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }catch (OleDbException ex)
                {
                    MessageBox.Show("The login cannot be the same as another login");
                }
                
            }
            else
            {
                this.Validate();
                this.tbluserBindingSource.EndEdit();
                
                this.tableAdapterManager.UpdateAll(this.websterdbDataSet);
            }
            _owner.PerformRefresh();
            this.Dispose();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private void cmbjob_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    greenticks();
        //    userjobidTextBox.Text = (Convert.ToInt32(cmbjob.SelectedIndex) + 1).ToString();
        //    MakeOnlyCurrentRowVisible();
            
        //}

        private void userloginTextBox_Leave(object sender, EventArgs e)
        {
            string loginup = userloginTextBox.Text.ToUpper();
            userloginTextBox.Text = loginup;
            
        }
        private void MakeOnlyCurrentRowVisible()
        {
            for (int i = 0; i < dataGridjob.Rows.Count; i++)
            {
                if (dataGridjob.CurrentRow != dataGridjob.Rows[i])
                    dataGridjob.Rows[i].Visible = false;
            }
        }

        private void userfirstnameTextBox_Leave(object sender, EventArgs e)
        {
            string firstn = userfirstnameTextBox.Text;
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            firstn = textInfo.ToTitleCase(firstn);
            userfirstnameTextBox.Text = firstn;
        }

        private void userlastnameTextBox_Leave(object sender, EventArgs e)
        {
            string firstn = userlastnameTextBox.Text;
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            firstn = textInfo.ToTitleCase(firstn);
            userlastnameTextBox.Text = firstn;
        }

        
    }
}

