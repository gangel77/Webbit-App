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
        }

        private void frmjoblist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websterdbDataSet.tbljob' table. You can move, or remove it, as needed.
            this.tbljobTableAdapter.Fill(this.websterdbDataSet.tbljob);
            foreach (DataGridViewRow row2 in DataGridjob.Rows)
            {
                for (int i = 0; i < DataGridjob.Columns.Count; i++)
                {
                    string rstr = row2.Cells[i].Value.ToString();
                    if (rstr == "True")
                    {
                        row2.Cells[i].Style.BackColor = Color.LightGreen;
                        //row2.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                    }
                    else
                    {
                        if (rstr == "False")
                        {
                            row2.Cells[i].Style.BackColor = Color.LightCoral;
                            //row2.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                        }else
                        {
                            row2.Cells[i].Style.BackColor = Color.White;
                        }
                        
                    }


                }

            }
        }

        private void tbljobBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbljobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.websterdbDataSet);
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbljobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.websterdbDataSet);
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
                        row2.Cells[i].Style.BackColor = Color.LightGreen;
                        //row2.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                    }
                    else
                    {
                        if (rstr == "False")
                        {
                            row2.Cells[i].Style.BackColor = Color.LightCoral;
                            //row2.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                        }
                        else
                        {
                            row2.Cells[i].Style.BackColor = Color.White;
                        }

                    }


                }

            }
        }
    }
}
