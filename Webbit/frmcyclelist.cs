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
            dataGridcycles.EnableHeadersVisualStyles = false;
        }

        private void frmcyclelist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'webbitdbdataset.tblcycle' table. You can move, or remove it, as needed.
            this.tblcycleTableAdapter.Fill(this.webbitdbdataset.tblcycle);

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
                    int pass = Utility.userreq("webadmin");
                    if (pass == 0)
                    {
                        return;
                    }
                    DataGridViewRow row = this.dataGridcycles.Rows[e.RowIndex];

                    frmcycle frmcycle = new frmcycle(Convert.ToInt32(row.Cells["clncycleid"].Value), this);
                    frmcycle.ShowDialog();
                }

            }
        }
    
        public void PerformRefresh()
        { 
            this.tblcycleTableAdapter.Fill(this.webbitdbdataset.tblcycle);
            
        }

        private void dataGridcycles_SelectionChanged(object sender, EventArgs e)
        {
            dataGridcycles.ClearSelection();
        }
        public bool succeed;
        private void btnclose_Click(object sender, EventArgs e)
        {
            succeed = true;
            DialogResult = DialogResult.OK;
        }
        
private void dataGridcycles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridViewColumn col = this.dataGridcycles.Columns[e.ColumnIndex];


            if (e.RowIndex < 0)
                return;
            if (col.Name.Equals("clnedit") )
            {
                //
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = dataGridcycles.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
    }

        private void frmcyclelist_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = Color.FromArgb(75, 47, 70);
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
    }
    
}
