namespace PackChecker
{
    partial class frmcheckmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcheckmenu));
            this.lblcheckcount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncheck = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcheckcount
            // 
            this.lblcheckcount.Font = new System.Drawing.Font("Myriad Pro", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblcheckcount.Location = new System.Drawing.Point(82, 59);
            this.lblcheckcount.Name = "lblcheckcount";
            this.lblcheckcount.Size = new System.Drawing.Size(155, 62);
            this.lblcheckcount.TabIndex = 9;
            this.lblcheckcount.Text = "lblcheckcount";
            this.lblcheckcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 34F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Packs to Check:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncheck
            // 
            this.btncheck.ActiveBorderThickness = 1;
            this.btncheck.ActiveCornerRadius = 10;
            this.btncheck.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btncheck.ActiveForecolor = System.Drawing.Color.White;
            this.btncheck.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btncheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.btncheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncheck.BackgroundImage")));
            this.btncheck.ButtonText = "Start Checking";
            this.btncheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheck.Font = new System.Drawing.Font("Myriad Pro", 18F);
            this.btncheck.ForeColor = System.Drawing.Color.SeaGreen;
            this.btncheck.IdleBorderThickness = 1;
            this.btncheck.IdleCornerRadius = 10;
            this.btncheck.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btncheck.IdleForecolor = System.Drawing.Color.White;
            this.btncheck.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btncheck.Location = new System.Drawing.Point(61, 141);
            this.btncheck.Margin = new System.Windows.Forms.Padding(5);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(191, 66);
            this.btncheck.TabIndex = 17;
            this.btncheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btncheck);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblcheckcount);
            this.panel1.Location = new System.Drawing.Point(331, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 212);
            this.panel1.TabIndex = 18;
            // 
            // frmcheckmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Name = "frmcheckmenu";
            this.Size = new System.Drawing.Size(975, 600);
            this.Load += new System.EventHandler(this.frmcheckmenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btncheck;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblcheckcount;
    }
}