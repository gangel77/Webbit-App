using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackChecker
{
    public partial class FrmLoading : Form
    {
        Action work;
        public FrmLoading(Action _work)
        {
            InitializeComponent();
            work = _work;
            
        }
        
       public void SetStatus(string newStat)
        {
            lblstatus.Text = newStat;
        }

        private void FrmSplash_Paint(object sender, PaintEventArgs e)
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

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            this.backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Show();
            this.work();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
