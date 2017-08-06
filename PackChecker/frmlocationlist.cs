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
    public partial class frmlocationlist : Form
    {
        public frmlocationlist()
        {
            InitializeComponent();
        }

        private void frmlocationlist_Load(object sender, EventArgs e)
        {
         
            this.tblpacklocationTableAdapter.Fill(this.websterdbDataSet.tblpacklocation);

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

                    frmlocation frmlocation = new frmlocation(Convert.ToInt32(row.Cells["clnlocationid"].Value), this,"edit");
                    frmlocation.ShowDialog();
                       
                    }
               
            }
        }
        public void PerformRefresh()
        {
            this.tblpacklocationTableAdapter.Fill(this.websterdbDataSet.tblpacklocation);
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
           
            frmlocation frmlocation = new frmlocation(1, this, "add");
            frmlocation.ShowDialog();
        }
    }
    
}
