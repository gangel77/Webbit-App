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
    public partial class frmcyclelist : Form
    {
        public frmcyclelist()
        {
            InitializeComponent();
        }

        private void frmcyclelist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websterdbDataSet.tblcycle' table. You can move, or remove it, as needed.
            this.tblcycleTableAdapter.Fill(this.websterdbDataSet.tblcycle);

        }
        private void dataGridCycles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                    //Figure out which button we jsut pressed
                    DataGridViewColumn col = this.dataGridcycles.Columns[e.ColumnIndex];

                    //IF we are in the Column pack, do this
                    if (col.Name.Equals("clnedit"))
                    {
                    int pass = Utility.userreq("admin");
                    if (pass == 0)
                    {
                        return;
                    }
                    DataGridViewRow row = this.dataGridcycles.Rows[e.RowIndex];
                        
                        frmcycle frmcycle = new frmcycle(Convert.ToInt32(row.Cells["clncycleid"].Value),this);
                        frmcycle.ShowDialog();
                    }
               
            }
        }
        public void PerformRefresh()
        {
            this.tblcycleTableAdapter.Fill(this.websterdbDataSet.tblcycle);
        }

        private void dataGridcycles_SelectionChanged(object sender, EventArgs e)
        {
            dataGridcycles.ClearSelection();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
    
}
