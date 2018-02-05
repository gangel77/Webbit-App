namespace PackChecker
{
    partial class frmholidaypacks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmholidaypacks));
            this.cmbpatient = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnextrapacks = new Bunifu.Framework.UI.BunifuThinButton2();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // cmbpatient
            // 
            this.cmbpatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbpatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbpatient.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpatient.FormattingEnabled = true;
            this.cmbpatient.Location = new System.Drawing.Point(48, 94);
            this.cmbpatient.Name = "cmbpatient";
            this.cmbpatient.Size = new System.Drawing.Size(365, 31);
            this.cmbpatient.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblTitle.Location = new System.Drawing.Point(28, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(405, 71);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Request Future Packs";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnclose
            // 
            this.btnclose.ActiveBorderThickness = 1;
            this.btnclose.ActiveCornerRadius = 10;
            this.btnclose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclose.ActiveForecolor = System.Drawing.Color.White;
            this.btnclose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclose.BackColor = System.Drawing.Color.White;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.ButtonText = "Close";
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnclose.IdleBorderThickness = 1;
            this.btnclose.IdleCornerRadius = 10;
            this.btnclose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclose.IdleForecolor = System.Drawing.Color.White;
            this.btnclose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclose.Location = new System.Drawing.Point(181, 198);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 54);
            this.btnclose.TabIndex = 22;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnextrapacks
            // 
            this.btnextrapacks.ActiveBorderThickness = 1;
            this.btnextrapacks.ActiveCornerRadius = 10;
            this.btnextrapacks.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnextrapacks.ActiveForecolor = System.Drawing.Color.White;
            this.btnextrapacks.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnextrapacks.AutoSize = true;
            this.btnextrapacks.BackColor = System.Drawing.Color.White;
            this.btnextrapacks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnextrapacks.BackgroundImage")));
            this.btnextrapacks.ButtonText = "Create Extra Packs";
            this.btnextrapacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnextrapacks.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnextrapacks.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnextrapacks.IdleBorderThickness = 1;
            this.btnextrapacks.IdleCornerRadius = 10;
            this.btnextrapacks.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnextrapacks.IdleForecolor = System.Drawing.Color.White;
            this.btnextrapacks.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnextrapacks.Location = new System.Drawing.Point(146, 134);
            this.btnextrapacks.Margin = new System.Windows.Forms.Padding(5);
            this.btnextrapacks.Name = "btnextrapacks";
            this.btnextrapacks.Size = new System.Drawing.Size(168, 54);
            this.btnextrapacks.TabIndex = 23;
            this.btnextrapacks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnextrapacks.Click += new System.EventHandler(this.btnextrapacks_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // frmholidaypacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 266);
            this.Controls.Add(this.btnextrapacks);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbpatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmholidaypacks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmholidaypacks";
            this.Load += new System.EventHandler(this.frmholidaypacks_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmholidaypacks_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbpatient;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnextrapacks;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}