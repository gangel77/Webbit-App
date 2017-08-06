using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;


namespace PackChecker
{
    public partial class frmcycle : Form
    {
        int newcycleid;
        string oldtextpacks;
        string oldtextweeks;
        frmcyclelist _owner;
        public frmcycle(int cycleid, frmcyclelist owner)
        {
            InitializeComponent();
            newcycleid = cycleid;
            _owner = owner;

        }
        
        private void frmcycle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websterdbDataSet.tblcycle' table. You can move, or remove it, as needed.
            this.tblcycleTableAdapter.Fill(this.websterdbDataSet.tblcycle);
            
            tblcycleBindingSource.Position = this.tblcycleBindingSource.Find("cycleid",newcycleid);
            oldtextpacks = cyclepacksTextBox.Text;
            oldtextweeks = cycleweeksTextBox.Text;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int n;
            string newtext = cyclepacksTextBox.Text;
            //Check integer added
            if (int.TryParse(newtext, out n))
            {
                //If it is a number
                //Check if it is larger than weeks
                if (n > Convert.ToInt32(cycleweeksTextBox.Text))
                {
                    msgbox mb = new msgbox("You can't have more packs than there are weeks!" + Environment.NewLine + "If this is the case, create a new Tray Size with 2 packs in it", "Input Error");
                    mb.ShowDialog();
                    cyclepacksTextBox.Text = oldtextpacks;
                    cycleweeksTextBox.Text = oldtextweeks;
                    return;
                }
            }
            else
            {
                //if not a number
                msgbox mb = new msgbox("Both weeks and packs must be numbers!", "Input Error");
                mb.ShowDialog();
                cyclepacksTextBox.Text = oldtextpacks;
                cycleweeksTextBox.Text = oldtextweeks;
                return;
            }
            this.Validate();
            this.tblcycleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.websterdbDataSet);
            _owner.PerformRefresh();
            this.Dispose();

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        

        private void cyclehideCheckBox_Click(object sender, EventArgs e)
        {
            string state = cyclehideCheckBox.Checked.ToString();

            if (state == "True")
            {
                cyclehideCheckBox.Checked = false;

            }
            else
            {
                OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                string strpxcycles = "SELECT COUNT(*) FROM tblpatient WHERE cycleid = ? AND active = TRUE";

                OleDbCommand cmd = new OleDbCommand(strpxcycles, con);
                
                cmd.Parameters.Add("?", OleDbType.Integer).Value = newcycleid;
               
                int count = 0;
                con.Open();
                count = (int)cmd.ExecuteScalar();
                con.Close();
                
                if (count != 0)
                {
                    msgbox mb = new msgbox("You cannot hide this cycle, it is in use by " + count + " patients.", "Failed to Hide");
                    mb.ShowDialog();
                    
                    
                        //something
                        

                }
                else
                {
                    cyclehideCheckBox.Checked = true;
                }
                


            }
        }
        
       
    }
}
