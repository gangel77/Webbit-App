namespace PackChecker
{
    partial class frmpackmanagementmenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpackmanagementmenu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnForceCycle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnpxlist = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnChanges = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnfuture = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncasualpx = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnimportnewpx = new Bunifu.Framework.UI.BunifuThinButton2();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblTitle.Location = new System.Drawing.Point(199, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(413, 62);
            this.lblTitle.TabIndex = 42;
            this.lblTitle.Text = "Management";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnForceCycle
            // 
            this.btnForceCycle.ActiveBorderThickness = 1;
            this.btnForceCycle.ActiveCornerRadius = 10;
            this.btnForceCycle.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnForceCycle.ActiveForecolor = System.Drawing.Color.White;
            this.btnForceCycle.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnForceCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.btnForceCycle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForceCycle.BackgroundImage")));
            this.btnForceCycle.ButtonText = "Force Next Cycle";
            this.btnForceCycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForceCycle.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForceCycle.ForeColor = System.Drawing.Color.White;
            this.btnForceCycle.IdleBorderThickness = 1;
            this.btnForceCycle.IdleCornerRadius = 10;
            this.btnForceCycle.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btnForceCycle.IdleForecolor = System.Drawing.Color.White;
            this.btnForceCycle.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btnForceCycle.Location = new System.Drawing.Point(466, 251);
            this.btnForceCycle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnForceCycle.Name = "btnForceCycle";
            this.btnForceCycle.Size = new System.Drawing.Size(270, 56);
            this.btnForceCycle.TabIndex = 40;
            this.btnForceCycle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnForceCycle.Click += new System.EventHandler(this.btnforcecycle_Click);
            // 
            // btnpxlist
            // 
            this.btnpxlist.ActiveBorderThickness = 1;
            this.btnpxlist.ActiveCornerRadius = 10;
            this.btnpxlist.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(231)))), ((int)(((byte)(125)))));
            this.btnpxlist.ActiveForecolor = System.Drawing.Color.White;
            this.btnpxlist.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(231)))), ((int)(((byte)(125)))));
            this.btnpxlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.btnpxlist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpxlist.BackgroundImage")));
            this.btnpxlist.ButtonText = "Edit Patient Profiles";
            this.btnpxlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpxlist.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpxlist.ForeColor = System.Drawing.Color.White;
            this.btnpxlist.IdleBorderThickness = 1;
            this.btnpxlist.IdleCornerRadius = 10;
            this.btnpxlist.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            this.btnpxlist.IdleForecolor = System.Drawing.Color.White;
            this.btnpxlist.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            this.btnpxlist.Location = new System.Drawing.Point(75, 133);
            this.btnpxlist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnpxlist.Name = "btnpxlist";
            this.btnpxlist.Size = new System.Drawing.Size(270, 56);
            this.btnpxlist.TabIndex = 38;
            this.btnpxlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnpxlist.Click += new System.EventHandler(this.btnpxlist_Click);
            // 
            // btnChanges
            // 
            this.btnChanges.ActiveBorderThickness = 1;
            this.btnChanges.ActiveCornerRadius = 10;
            this.btnChanges.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnChanges.ActiveForecolor = System.Drawing.Color.White;
            this.btnChanges.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.btnChanges.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChanges.BackgroundImage")));
            this.btnChanges.ButtonText = "Edit Checked Packs";
            this.btnChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChanges.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChanges.ForeColor = System.Drawing.Color.White;
            this.btnChanges.IdleBorderThickness = 1;
            this.btnChanges.IdleCornerRadius = 10;
            this.btnChanges.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnChanges.IdleForecolor = System.Drawing.Color.White;
            this.btnChanges.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnChanges.Location = new System.Drawing.Point(466, 133);
            this.btnChanges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChanges.Name = "btnChanges";
            this.btnChanges.Size = new System.Drawing.Size(270, 56);
            this.btnChanges.TabIndex = 37;
            this.btnChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChanges.Click += new System.EventHandler(this.btnchanges_Click);
            // 
            // btnfuture
            // 
            this.btnfuture.ActiveBorderThickness = 1;
            this.btnfuture.ActiveCornerRadius = 10;
            this.btnfuture.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnfuture.ActiveForecolor = System.Drawing.Color.White;
            this.btnfuture.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnfuture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.btnfuture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfuture.BackgroundImage")));
            this.btnfuture.ButtonText = "Manage Future Packs";
            this.btnfuture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfuture.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfuture.ForeColor = System.Drawing.Color.White;
            this.btnfuture.IdleBorderThickness = 1;
            this.btnfuture.IdleCornerRadius = 10;
            this.btnfuture.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnfuture.IdleForecolor = System.Drawing.Color.White;
            this.btnfuture.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnfuture.Location = new System.Drawing.Point(466, 192);
            this.btnfuture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnfuture.Name = "btnfuture";
            this.btnfuture.Size = new System.Drawing.Size(270, 56);
            this.btnfuture.TabIndex = 36;
            this.btnfuture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnfuture.Click += new System.EventHandler(this.btnfuture_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncasualpx);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnimportnewpx);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnfuture);
            this.panel1.Controls.Add(this.btnForceCycle);
            this.panel1.Controls.Add(this.btnChanges);
            this.panel1.Controls.Add(this.btnpxlist);
            this.panel1.Location = new System.Drawing.Point(83, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 391);
            this.panel1.TabIndex = 43;
            // 
            // btncasualpx
            // 
            this.btncasualpx.ActiveBorderThickness = 1;
            this.btncasualpx.ActiveCornerRadius = 10;
            this.btncasualpx.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btncasualpx.ActiveForecolor = System.Drawing.Color.White;
            this.btncasualpx.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btncasualpx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.btncasualpx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncasualpx.BackgroundImage")));
            this.btncasualpx.ButtonText = "Add Casual Patient";
            this.btncasualpx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncasualpx.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncasualpx.ForeColor = System.Drawing.Color.White;
            this.btncasualpx.IdleBorderThickness = 1;
            this.btncasualpx.IdleCornerRadius = 10;
            this.btncasualpx.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btncasualpx.IdleForecolor = System.Drawing.Color.White;
            this.btncasualpx.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btncasualpx.Location = new System.Drawing.Point(75, 251);
            this.btncasualpx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncasualpx.Name = "btncasualpx";
            this.btncasualpx.Size = new System.Drawing.Size(270, 56);
            this.btncasualpx.TabIndex = 46;
            this.btncasualpx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncasualpx.Click += new System.EventHandler(this.btncasualpx_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(466, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 43);
            this.label2.TabIndex = 45;
            this.label2.Text = "Pack";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(75, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 43);
            this.label1.TabIndex = 44;
            this.label1.Text = "Patient";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnimportnewpx
            // 
            this.btnimportnewpx.ActiveBorderThickness = 1;
            this.btnimportnewpx.ActiveCornerRadius = 10;
            this.btnimportnewpx.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnimportnewpx.ActiveForecolor = System.Drawing.Color.White;
            this.btnimportnewpx.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnimportnewpx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.btnimportnewpx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnimportnewpx.BackgroundImage")));
            this.btnimportnewpx.ButtonText = "Update Patients";
            this.btnimportnewpx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnimportnewpx.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimportnewpx.ForeColor = System.Drawing.Color.White;
            this.btnimportnewpx.IdleBorderThickness = 1;
            this.btnimportnewpx.IdleCornerRadius = 10;
            this.btnimportnewpx.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnimportnewpx.IdleForecolor = System.Drawing.Color.White;
            this.btnimportnewpx.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnimportnewpx.Location = new System.Drawing.Point(75, 192);
            this.btnimportnewpx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnimportnewpx.Name = "btnimportnewpx";
            this.btnimportnewpx.Size = new System.Drawing.Size(270, 56);
            this.btnimportnewpx.TabIndex = 43;
            this.btnimportnewpx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnimportnewpx.Click += new System.EventHandler(this.btnimportnewpx_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // frmpackmanagementmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Name = "frmpackmanagementmenu";
            this.Size = new System.Drawing.Size(975, 600);
            this.Load += new System.EventHandler(this.frmpackmanagementmenu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnForceCycle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnpxlist;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChanges;
        private Bunifu.Framework.UI.BunifuThinButton2 btnfuture;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnimportnewpx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btncasualpx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}