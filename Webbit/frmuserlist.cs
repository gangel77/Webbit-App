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
            dataGridlocation.EnableHeadersVisualStyles = false;
        }

        private void frmlocationlist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websterdbwebbitdbdataset.users_jobs' table. You can move, or remove it, as needed.
            try
            { 
            this.users_jobsTableAdapter.Fill(this.websterdbwebbitdbdataset.users_jobs);
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }

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
                    int pass = Utility.userreq("webadmin");
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
            this.users_jobsTableAdapter.Fill(this.websterdbwebbitdbdataset.users_jobs);
        }

        private void dataGridloction_SelectionChanged(object sender, EventArgs e)
        {
            dataGridlocation.ClearSelection();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            using (msgbox mb = new PackChecker.msgbox("Users are imported from dispense when you update patients.", "Can't add from here"))
            {
                mb.ShowDialog();
            }
            //int pass = Utility.userreq("webadmin");
            //if (pass == 0)
            //{
            //    return;
            //}
            //frmuser frmuser = new frmuser(1, this, "add");
            //frmuser.ShowDialog();
        }

        private void dataGridlocation_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
            DataGridViewColumn col = this.dataGridlocation.Columns[e.ColumnIndex];


            if (e.RowIndex < 0)
            {
                return;
            }
               
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

        private void frmuserlist_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = Color.FromArgb(148, 213, 0);
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
