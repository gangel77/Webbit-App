namespace PackChecker
{
    partial class frmshowcons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmshowcons));
            this.lblwebbit = new System.Windows.Forms.Label();
            this.lbldispense = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgweb = new System.Windows.Forms.PictureBox();
            this.imgdisp = new System.Windows.Forms.PictureBox();
            this.btnOK = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.imgweb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgdisp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblwebbit
            // 
            this.lblwebbit.AutoSize = true;
            this.lblwebbit.Font = new System.Drawing.Font("Myriad Pro Cond", 24.75F);
            this.lblwebbit.Location = new System.Drawing.Point(32, 57);
            this.lblwebbit.Name = "lblwebbit";
            this.lblwebbit.Size = new System.Drawing.Size(213, 39);
            this.lblwebbit.TabIndex = 0;
            this.lblwebbit.Text = "Webbit Connection:";
            this.lblwebbit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbldispense
            // 
            this.lbldispense.AutoSize = true;
            this.lbldispense.Font = new System.Drawing.Font("Myriad Pro Cond", 24.75F);
            this.lbldispense.Location = new System.Drawing.Point(32, 113);
            this.lbldispense.Name = "lbldispense";
            this.lbldispense.Size = new System.Drawing.Size(231, 39);
            this.lbldispense.TabIndex = 2;
            this.lbldispense.Text = "Dispense Connection:";
            this.lbldispense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Cond", 24.75F);
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Check Connections:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imgweb
            // 
            this.imgweb.Image = global::PackChecker.Properties.Resources.cross;
            this.imgweb.Location = new System.Drawing.Point(275, 57);
            this.imgweb.Name = "imgweb";
            this.imgweb.Size = new System.Drawing.Size(43, 39);
            this.imgweb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgweb.TabIndex = 4;
            this.imgweb.TabStop = false;
            // 
            // imgdisp
            // 
            this.imgdisp.Image = global::PackChecker.Properties.Resources.cross;
            this.imgdisp.Location = new System.Drawing.Point(275, 113);
            this.imgdisp.Name = "imgdisp";
            this.imgdisp.Size = new System.Drawing.Size(43, 39);
            this.imgdisp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgdisp.TabIndex = 5;
            this.imgdisp.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.ActiveBorderThickness = 1;
            this.btnOK.ActiveCornerRadius = 10;
            this.btnOK.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnOK.ActiveForecolor = System.Drawing.Color.White;
            this.btnOK.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnOK.AutoSize = true;
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.ButtonText = "OK";
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOK.IdleBorderThickness = 1;
            this.btnOK.IdleCornerRadius = 10;
            this.btnOK.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnOK.IdleForecolor = System.Drawing.Color.White;
            this.btnOK.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnOK.Location = new System.Drawing.Point(129, 161);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 44);
            this.btnOK.TabIndex = 22;
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmshowcons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 212);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.imgdisp);
            this.Controls.Add(this.imgweb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldispense);
            this.Controls.Add(this.lblwebbit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmshowcons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmshowcons";
            this.Load += new System.EventHandler(this.frmshowcons_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmshowcons_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.imgweb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgdisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwebbit;
        private System.Windows.Forms.Label lbldispense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgweb;
        private System.Windows.Forms.PictureBox imgdisp;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOK;
    }
}