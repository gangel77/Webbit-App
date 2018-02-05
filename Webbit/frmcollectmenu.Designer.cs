namespace PackChecker
{
    partial class frmcollectmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcollectmenu));
            this.cmbpatient = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnopencollect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbpatient
            // 
            this.cmbpatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbpatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbpatient.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpatient.FormattingEnabled = true;
            this.cmbpatient.Location = new System.Drawing.Point(7, 76);
            this.cmbpatient.Name = "cmbpatient";
            this.cmbpatient.Size = new System.Drawing.Size(365, 31);
            this.cmbpatient.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 34F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblTitle.Location = new System.Drawing.Point(17, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 54);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Select a Patient:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnopencollect
            // 
            this.btnopencollect.ActiveBorderThickness = 1;
            this.btnopencollect.ActiveCornerRadius = 10;
            this.btnopencollect.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnopencollect.ActiveForecolor = System.Drawing.Color.White;
            this.btnopencollect.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnopencollect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.btnopencollect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnopencollect.BackgroundImage")));
            this.btnopencollect.ButtonText = "Open Collection";
            this.btnopencollect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnopencollect.Font = new System.Drawing.Font("Myriad Pro", 18F);
            this.btnopencollect.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnopencollect.IdleBorderThickness = 1;
            this.btnopencollect.IdleCornerRadius = 10;
            this.btnopencollect.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnopencollect.IdleForecolor = System.Drawing.Color.White;
            this.btnopencollect.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnopencollect.Location = new System.Drawing.Point(91, 145);
            this.btnopencollect.Margin = new System.Windows.Forms.Padding(5);
            this.btnopencollect.Name = "btnopencollect";
            this.btnopencollect.Size = new System.Drawing.Size(196, 65);
            this.btnopencollect.TabIndex = 17;
            this.btnopencollect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnopencollect.Click += new System.EventHandler(this.btnopencollect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnopencollect);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.cmbpatient);
            this.panel1.Location = new System.Drawing.Point(298, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 210);
            this.panel1.TabIndex = 18;
            // 
            // frmcollectmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Name = "frmcollectmenu";
            this.Size = new System.Drawing.Size(975, 600);
            this.Load += new System.EventHandler(this.frmcollectmenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbpatient;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnopencollect;
        private System.Windows.Forms.Panel panel1;
    }
}