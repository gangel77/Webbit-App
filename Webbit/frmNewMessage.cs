using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PackChecker
{
    public partial class frmNewMessage : Form
    {
        int _userid;
        int _pxid;
        string _pxname;

        public frmNewMessage(int userid, int pxid, string pxname)
        {
            InitializeComponent();
            _pxid = pxid;
            _pxname = pxname;
            _userid = userid;
            lblpatient.Text = "Patient: " + _pxname;
        }

        private void frmNewMessage_Paint(object sender, PaintEventArgs e)
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

        private void btnsend_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                string newmessage = @"INSERT INTO tblmessage (messagetext, senderid, datesent, patientid) VALUES (?,?,?,?)";

                using (OleDbCommand cmd = new OleDbCommand(newmessage, con))
                {
                    cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtmessage.Text;
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = _userid;
                    cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = _pxid;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            using (msgbox mb = new msgbox("Message Sent", "Sent"))
            {
                mb.ShowDialog();
            }
            DialogResult = DialogResult.Yes;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
           
            if(!string.IsNullOrEmpty(txtmessage.Text))
                {

                using (yesnobox yn = new yesnobox("This will delete your message, are you sure?", "delete"))
                {
                    if(yn.ShowDialog() == DialogResult.Yes)
                    {
                        DialogResult = DialogResult.Cancel;
                    }else{

                        return;
                    }

                }

            }else
            {
                DialogResult = DialogResult.Cancel;
            }


        }

        private void frmNewMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
