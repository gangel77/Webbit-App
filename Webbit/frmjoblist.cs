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
    public partial class frmjoblist : Form
    {
        public frmjoblist()
        {
            InitializeComponent();
            DataGridjob.EnableHeadersVisualStyles = false;
        }
       
        private void frmjoblist_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'webbitdbdataset.tbljob' table. You can move, or remove it, as needed.
            this.tbljobTableAdapter.Fill(this.webbitdbdataset.tbljob);
            foreach (DataGridViewRow row2 in DataGridjob.Rows)
            {
                for (int i = 0; i < DataGridjob.Columns.Count; i++)
                {
                    string rstr = row2.Cells[i].Value.ToString();
                    if (rstr == "True")
                    {
                        row2.Cells[i].Style.BackColor = Color.FromArgb(129, 183, 143);
                        //row2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(129, 183, 143);
                    }
                    else
                    {
                        if (rstr == "False")
                        {
                            row2.Cells[i].Style.BackColor = Color.White;
                            //row2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(129, 183, 143);
                        }
                        else
                        {
                            row2.Cells[i].Style.BackColor = Color.White;
                        }

                    }


                }

            }
            DataGridjob.Rows[0].ReadOnly = true;
        }

        private void tbljobBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            { 
            this.Validate();
            this.tbljobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.webbitdbdataset);
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            this.Validate();
            this.tbljobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.webbitdbdataset);
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
            this.Close();
            this.Dispose();
        }

        private void DataGridjob_SelectionChanged(object sender, EventArgs e)
        {
            DataGridjob.ClearSelection();
        }

        private void DataGridjob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


            foreach (DataGridViewRow row2 in DataGridjob.Rows)
            {


                this.DataGridjob.CommitEdit(DataGridViewDataErrorContexts.Commit);
                for (int i = 0; i < DataGridjob.Columns.Count; i++)
                {
                    string rstr = row2.Cells[i].Value.ToString();
                    if (rstr == "True")
                    {

                        row2.Cells[i].Style.BackColor = Color.FromArgb(129, 183, 143);
                        //row2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(129, 183, 143);
                    }
                    else
                    {
                        if (rstr == "False")
                        {

                            row2.Cells[i].Style.BackColor = Color.White;
                            //row2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(129, 183, 143);
                        }
                        else
                        {
                            row2.Cells[i].Style.BackColor = Color.White;
                        }

                    }


                }

            }
        }

        private void DataGridjob_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {

        }

        private void frmjoblist_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = Color.FromArgb(0, 59, 76);
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
