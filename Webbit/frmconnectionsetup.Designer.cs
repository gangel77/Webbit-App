namespace PackChecker
{
    partial class frmconnectionsetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconnectionsetup));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnconnect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtdbpath = new System.Windows.Forms.TextBox();
            this.btnfinddb = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlwebbitsettings = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlwebbitsettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connection Setup";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PackChecker.Properties.Resources.Webbit_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.btnconnect.Location = new System.Drawing.Point(40, 202);
            this.btnconnect.Margin = new System.Windows.Forms.Padding(5);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(123, 50);
            this.btnconnect.TabIndex = 21;
            this.btnconnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // txtdbpath
            // 
            this.txtdbpath.Location = new System.Drawing.Point(15, 32);
            this.txtdbpath.Name = "txtdbpath";
            this.txtdbpath.Size = new System.Drawing.Size(187, 20);
            this.txtdbpath.TabIndex = 24;
            // 
            // btnfinddb
            // 
            this.btnfinddb.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnfinddb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnfinddb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfinddb.BorderRadius = 0;
            this.btnfinddb.ButtonText = "Browse";
            this.btnfinddb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfinddb.DisabledColor = System.Drawing.Color.Gray;
            this.btnfinddb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnfinddb.Iconcolor = System.Drawing.Color.Transparent;
            this.btnfinddb.Iconimage = null;
            this.btnfinddb.Iconimage_right = null;
            this.btnfinddb.Iconimage_right_Selected = null;
            this.btnfinddb.Iconimage_Selected = null;
            this.btnfinddb.IconMarginLeft = 0;
            this.btnfinddb.IconMarginRight = 0;
            this.btnfinddb.IconRightVisible = true;
            this.btnfinddb.IconRightZoom = 0D;
            this.btnfinddb.IconVisible = true;
            this.btnfinddb.IconZoom = 90D;
            this.btnfinddb.IsTab = false;
            this.btnfinddb.Location = new System.Drawing.Point(208, 32);
            this.btnfinddb.Name = "btnfinddb";
            this.btnfinddb.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnfinddb.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnfinddb.OnHoverTextColor = System.Drawing.Color.White;
            this.btnfinddb.selected = false;
            this.btnfinddb.Size = new System.Drawing.Size(69, 20);
            this.btnfinddb.TabIndex = 25;
            this.btnfinddb.Text = "Browse";
            this.btnfinddb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnfinddb.Textcolor = System.Drawing.Color.White;
            this.btnfinddb.TextFont = new System.Drawing.Font("Myriad Pro Cond", 12.75F);
            this.btnfinddb.Click += new System.EventHandler(this.btnfinddb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Enter the location of your WEBBIT database";
            // 
            // pnlwebbitsettings
            // 
            this.pnlwebbitsettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlwebbitsettings.BackgroundImage")));
            this.pnlwebbitsettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlwebbitsettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlwebbitsettings.Controls.Add(this.txtdbpath);
            this.pnlwebbitsettings.Controls.Add(this.label4);
            this.pnlwebbitsettings.Controls.Add(this.btnfinddb);
            this.pnlwebbitsettings.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlwebbitsettings.GradientBottomRight = System.Drawing.Color.White;
            this.pnlwebbitsettings.GradientTopLeft = System.Drawing.Color.White;
            this.pnlwebbitsettings.GradientTopRight = System.Drawing.Color.White;
            this.pnlwebbitsettings.Location = new System.Drawing.Point(24, 120);
            this.pnlwebbitsettings.Name = "pnlwebbitsettings";
            this.pnlwebbitsettings.Quality = 10;
            this.pnlwebbitsettings.Size = new System.Drawing.Size(288, 67);
            this.pnlwebbitsettings.TabIndex = 29;
            // 
            // btnclose
            // 
            this.btnclose.ActiveBorderThickness = 1;
            this.btnclose.ActiveCornerRadius = 10;
            this.btnclose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclose.ActiveForecolor = System.Drawing.Color.White;
            this.btnclose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclose.AutoSize = true;
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
            this.btnclose.Location = new System.Drawing.Point(173, 202);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(123, 50);
            this.btnclose.TabIndex = 31;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // frmconnectionsetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(336, 269);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlwebbitsettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmconnectionsetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInitialsetup";
            this.Load += new System.EventHandler(this.frmconnectionsetup_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmconnectionsetup_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlwebbitsettings.ResumeLayout(false);
            this.pnlwebbitsettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnconnect;
        private System.Windows.Forms.TextBox txtdbpath;
        private Bunifu.Framework.UI.BunifuFlatButton btnfinddb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlwebbitsettings;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
    }
}