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
    public partial class frmuserlist : Form
    {
        public frmuserlist()
        {
            InitializeComponent();
        }

        private void frmlocationlist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websterdbDataSet1.users_jobs' table. You can move, or remove it, as needed.
            this.users_jobsTableAdapter.Fill(this.websterdbDataSet1.users_jobs);
            

            this.users_jobsTableAdapter.Fill(this.websterdbDataSet1.users_jobs);

        }
        private void dataGridLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                    //Figure out which button we jsut pressed
                    DataGridViewColumn col = this.dataGridlocation.Columns[e.ColumnIndex];

                    //IF we are in the Column pack, do this
                    if (col.Name.Equals("clnedit"))
                    {
                    int pass = Utility.userreq("admin");
                    if (pass == 0)
                    {
                        return;
                    }
                    DataGridViewRow row = this.dataGridlocation.Rows[e.RowIndex];

                    frmuser frmuser = new frmuser(Convert.ToInt32(row.Cells["clnuserid"].Value), this,"edit");
                    frmuser.ShowDialog();
                       
                    }
               
            }
        }
        public void PerformRefresh()
        {
            this.users_jobsTableAdapter.Fill(this.websterdbDataSet1.users_jobs);
        }

        private void dataGridloction_SelectionChanged(object sender, EventArgs e)
        {
            dataGridlocation.ClearSelection();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {

            frmuser frmuser = new frmuser(1, this, "add");
            frmuser.ShowDialog();
        }

        

        

        
    }
    
}
