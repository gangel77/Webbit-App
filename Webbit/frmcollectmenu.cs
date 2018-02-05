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
using System.IO;

namespace PackChecker
{
    public partial class frmcollectmenu : UserControl
    {
        public frmcollectmenu()
        {
            InitializeComponent();
            cmbpatient.IntegralHeight = false;
            cmbpatient.DropDownHeight = cmbpatient.Font.Height * 8;
            cmbpatient.MaxDropDownItems = 8;
        }

        private void frmcollectmenu_Load(object sender, EventArgs e)
        {
            rebiuldcombo(sender, e);
        }

        public void rebiuldcombo(object sender, EventArgs e)
        {
            try
            {

                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    OleDbDataAdapter adapt = new OleDbDataAdapter();

                    DataSet ds = new DataSet();


                    string sql = @"SELECT tbldeactive.patientid, tbldeactive.pxfirstname, tbldeactive.pxlastname, pxlastname + ', ' + pxfirstname as pxname
                                FROM
                                (SELECT tblpatient.patientid, tblpatient.pxfirstname, tblpatient.pxlastname
FROM tblpatient INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid
GROUP BY tblpatient.patientid, tblpatient.pxfirstname, tblpatient.pxlastname, tblpatient.active, tblpack.collectuser, tblpack.active, tblpatient.casual
HAVING (((tblpatient.active)=False) AND ((tblpack.collectuser) Is Null) AND ((tblpack.active)=True)) OR (((tblpack.collectuser) Is Null) AND ((tblpack.active)=True) AND ((tblpatient.casual)=True))) as tbldeactive
                                UNION
                                SELECT tblpatient.patientid, tblpatient.pxfirstname, tblpatient.pxlastname, pxlastname + ', ' + pxfirstname as pxname
                                FROM tblpatient
                                WHERE active = -1 AND casual = 0
                                Order BY pxlastname, pxfirstname";

                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, con);

                    adapt.SelectCommand = cmd;
                    adapt.Fill(ds);
                    adapt.Dispose();
                    con.Close();
                    cmbpatient.DataSource = ds.Tables[0];

                    cmbpatient.ValueMember = "patientid";
                    cmbpatient.DisplayMember = "pxname";


                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
        }

        private void btnopencollect_Click(object sender, EventArgs e)
        {
            if(ActiveControl == cmbpatient)
            {
                ActiveControl = btnopencollect;
            }
            try
            {
                var pxid = cmbpatient.SelectedValue.ToString();

                int pass = Utility.userreq("collect");
                if (pass == 0)
                {
                    return;
                }

                // take a screenshot of the form and darken it:
                Bitmap bmp = new Bitmap(this.FindForm().DisplayRectangle.Width, this.FindForm().DisplayRectangle.Height);
                using (Graphics G = Graphics.FromImage(bmp))
                {
                    G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                    G.CopyFromScreen(this.PointToScreen(new Point(0, 0)), new Point(0, 0), this.FindForm().DisplayRectangle.Size);
                    double percent = 0.60;
                    Color darken = Color.FromArgb((int)(255 * percent), Color.Black);
                    using (Brush brsh = new SolidBrush(darken))
                    {
                        G.FillRectangle(brsh, this.FindForm().DisplayRectangle);
                    }
                }

                // put the darkened screenshot into a Panel and bring it to the front:
                using (Panel p = new Panel())
                {
                    p.Location = new Point(0, 0);
                    p.Size = this.ClientRectangle.Size;
                    p.BackgroundImage = bmp;
                    this.Controls.Add(p);
                    p.BringToFront();

                    // display your dialog somehow:
                    frmcollecting frmcollecting = new frmcollecting(pxid);
                    frmcollecting.ShowDialog();
                }
            }
            
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
        }

        private void cmbpatient_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
    }
