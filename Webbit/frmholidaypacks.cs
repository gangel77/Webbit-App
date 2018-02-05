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
    public partial class frmholidaypacks : Form, IWorker
    {
        //bool casual;
        public frmholidaypacks()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void frmholidaypacks_Load(object sender, EventArgs e)
        {
            try
            { 
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                        using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                        {





                            string sql = "SELECT tblpatient.patientid, tblpatient.pxlastname + ', ' + tblpatient.pxfirstname AS pxname, tblpatient.casual FROM tblpatient WHERE active = -1 ORDER BY pxlastname ASC, pxfirstname ASC";

                            con.Open();
                            using (OleDbCommand cmd = new OleDbCommand(sql, con))
                            {


                                adapt.SelectCommand = cmd;
                                adapt.Fill(ds);
                                adapt.Dispose();
                                con.Close();


                                cmbpatient.ValueMember = "patientid";
                                cmbpatient.DisplayMember = "pxname";
                                cmbpatient.DataSource = ds.Tables[0];
                                //casual = Convert.ToBoolean(ds.Tables[0].Rows[0]["casual"]);
                            }
                        }
                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
        }

        private void btnextrapacks_Click(object sender, EventArgs e)
        {
            string pxname = null;
            int pxid = Convert.ToInt32(cmbpatient.SelectedValue);
            string strpackdate = "SELECT * FROM tblpatient WHERE patientid = ?";
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {

                using (OleDbCommand cmd = new OleDbCommand(strpackdate, con))
                {
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = pxid;

                    con.Open();
                    OleDbDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        pxname = reader["pxfirstname"].ToString() + " " + reader["pxlastname"].ToString();
                    }

                    reader.Close();
                    con.Close();
                }
            }
            //MessageBox.Show(ds.Tables[0].Rows[Convert.ToInt32(cmbpatient.SelectedValue)]["patientid"].ToString());
            using (yesnobox yn = new yesnobox("Are you sure you want to create extra packs for " + pxname, "Check Patient"))
            {
                if (yn.ShowDialog() == DialogResult.No)
                {
                    return;
                }
            }

            Utility.futurepacks<frmholidaypacks>(sender, e, pxid);

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmholidaypacks_Paint(object sender, PaintEventArgs e)
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

        FrmSplash splashy;
        string splashtext;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            splashy = new FrmSplash();
            splashy.SetStatus(splashtext);
            splashy.ShowDialog();

        }
        public void startplash(string starttext)
        {
            if (!backgroundWorker1.IsBusy)
            {
                splashtext = starttext;
                backgroundWorker1.RunWorkerAsync();
            }

        }
        public void updatesplash(string updatetext)
        {
            splashy.InvokeBy(() =>
            {
                splashy.SetStatus(updatetext);
            }
                        );
        }
        public void stopsplash()
        {
            splashy.InvokeBy(() =>
            {
                splashy.Close();
            }
                        );

            backgroundWorker1.CancelAsync();
        }
    }
    public interface IWorker
    {
        void startplash(string starttext);

        void stopsplash();

        void updatesplash(string updatetext);
    }
}
