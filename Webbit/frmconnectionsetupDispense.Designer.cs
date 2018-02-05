namespace PackChecker
{
    partial class frmconnectionsetupDispense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconnectionsetupDispense));
            this.cmbdispense = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnconnect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnldispensesettings = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.listboxSQLServerInstances = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnldispensesettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbdispense
            // 
            this.cmbdispense.FormattingEnabled = true;
            this.cmbdispense.Items.AddRange(new object[] {
            "LOTS",
            "Minfos",
            "FRED"});
            this.cmbdispense.Location = new System.Drawing.Point(105, 42);
            this.cmbdispense.Name = "cmbdispense";
            this.cmbdispense.Size = new System.Drawing.Size(163, 21);
            this.cmbdispense.TabIndex = 0;
            this.cmbdispense.SelectedValueChanged += new System.EventHandler(this.cmbdispense_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Which Dispense System is being used?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connection Setup";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PackChecker.Properties.Resources.Webbit_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(91, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(36, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter the PC name where your\r\nDISPENSE server is located:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnconnect
            // 
            this.btnconnect.ActiveBorderThickness = 1;
            this.btnconnect.ActiveCornerRadius = 10;
            this.btnconnect.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnconnect.ActiveForecolor = System.Drawing.Color.White;
            this.btnconnect.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnconnect.AutoSize = true;
            this.btnconnect.BackColor = System.Drawing.Color.White;
            this.btnconnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnconnect.BackgroundImage")));
            this.btnconnect.ButtonText = "Connect!";
            this.btnconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconnect.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconnect.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnconnect.IdleBorderThickness = 1;
            this.btnconnect.IdleCornerRadius = 10;
            this.btnconnect.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnconnect.IdleForecolor = System.Drawing.Color.White;
            this.btnconnect.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnconnect.Location = new System.Drawing.Point(75, 406);
            this.btnconnect.Margin = new System.Windows.Forms.Padding(5);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(123, 50);
            this.btnconnect.TabIndex = 21;
            this.btnconnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // pnldispensesettings
            // 
            this.pnldispensesettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnldispensesettings.BackgroundImage")));
            this.pnldispensesettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnldispensesettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnldispensesettings.Controls.Add(this.label8);
            this.pnldispensesettings.Controls.Add(this.listboxSQLServerInstances);
            this.pnldispensesettings.Controls.Add(this.label1);
            this.pnldispensesettings.Controls.Add(this.cmbdispense);
            this.pnldispensesettings.Controls.Add(this.label3);
            this.pnldispensesettings.ForeColor = System.Drawing.Color.Black;
            this.pnldispensesettings.GradientBottomLeft = System.Drawing.Color.White;
            this.pnldispensesettings.GradientBottomRight = System.Drawing.Color.White;
            this.pnldispensesettings.GradientTopLeft = System.Drawing.Color.White;
            this.pnldispensesettings.GradientTopRight = System.Drawing.Color.White;
            this.pnldispensesettings.Location = new System.Drawing.Point(27, 182);
            this.pnldispensesettings.Name = "pnldispensesettings";
            this.pnldispensesettings.Quality = 10;
            this.pnldispensesettings.Size = new System.Drawing.Size(378, 216);
            this.pnldispensesettings.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(17, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "SQL Server List:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listboxSQLServerInstances
            // 
            this.listboxSQLServerInstances.Location = new System.Drawing.Point(102, 115);
            this.listboxSQLServerInstances.Name = "listboxSQLServerInstances";
            this.listboxSQLServerInstances.Size = new System.Drawing.Size(248, 82);
            this.listboxSQLServerInstances.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "DISPENSE:";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 10;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.bunifuThinButton21.AutoSize = true;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Close";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 10;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(240, 406);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(123, 50);
            this.bunifuThinButton21.TabIndex = 31;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmconnectionsetupDispense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 474);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnldispensesettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmconnectionsetupDispense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInitialsetup";
            this.Load += new System.EventHandler(this.frmconnectionsetupDispense_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmconnectionsetup_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnldispensesettings.ResumeLayout(false);
            this.pnldispensesettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbdispense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnconnect;
        private Bunifu.Framework.UI.BunifuGradientPanel pnldispensesettings;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listboxSQLServerInstances;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}