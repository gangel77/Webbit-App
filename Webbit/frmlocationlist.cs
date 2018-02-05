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
            dataGridlocation.EnableHeadersVisualStyles = false;
        }

        private void frmlocationlist_Load(object sender, EventArgs e)
        {
         
            this.tblpacklocationTableAdapter.Fill(this.webbitdbdataset.tblpacklocation);

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
            
            this.tblpacklocationTableAdapter.Fill(this.webbitdbdataset.tblpacklocation);
            
        }

        private void dataGridloction_SelectionChanged(object sender, EventArgs e)
        {
            dataGridlocation.ClearSelection();
        }
        public bool succeed;
        private void btnclose_Click(object sender, EventArgs e)
        {
            succeed = true;
            this.Close();
            this.Dispose();
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            
                int pass = Utility.userreq("webadmin");
                if (pass == 0)
                {
                    return;
                }
           
                frmlocation frmlocation = new frmlocation(1, this, "add");
            frmlocation.ShowDialog();
        }

        private void dataGridlocation_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridViewColumn col = this.dataGridlocation.Columns[e.ColumnIndex];


            if (e.RowIndex < 0)
                return;
            if (col.Name.Equals("clnedit"))
            {
                //
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = dataGridlocation.RowTemplate.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void frmlocationlist_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = Color.FromArgb(31, 134, 73);
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
