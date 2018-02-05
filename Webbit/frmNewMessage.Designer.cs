namespace PackChecker
{
    partial class frmNewMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewMessage));
            this.lblTitle = new System.Windows.Forms.Label();
            this.OuterPanel = new System.Windows.Forms.Panel();
            this.InnerPanel = new System.Windows.Forms.Panel();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.lblpatient = new System.Windows.Forms.Label();
            this.btnsend = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btncancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.OuterPanel.SuspendLayout();
            this.InnerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblTitle.Location = new System.Drawing.Point(19, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(499, 45);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Send a message to the Packing Staff:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OuterPanel
            // 
            this.OuterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.OuterPanel.Controls.Add(this.InnerPanel);
            this.OuterPanel.Location = new System.Drawing.Point(19, 108);
            this.OuterPanel.Name = "OuterPanel";
            this.OuterPanel.Size = new System.Drawing.Size(502, 132);
            this.OuterPanel.TabIndex = 5;
            this.OuterPanel.TabStop = true;
            // 
            // InnerPanel
            // 
            this.InnerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.InnerPanel.Controls.Add(this.txtmessage);
            this.InnerPanel.Location = new System.Drawing.Point(2, 2);
            this.InnerPanel.Name = "InnerPanel";
            this.InnerPanel.Size = new System.Drawing.Size(497, 127);
            this.InnerPanel.TabIndex = 1;
            this.InnerPanel.TabStop = true;
            // 
            // txtmessage
            // 
            this.txtmessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.txtmessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmessage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtmessage.Location = new System.Drawing.Point(6, 5);
            this.txtmessage.MaxLength = 80;
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(484, 112);
            this.txtmessage.TabIndex = 3;
            // 
            // lblpatient
            // 
            this.lblpatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblpatient.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblpatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblpatient.Location = new System.Drawing.Point(53, 54);
            this.lblpatient.Name = "lblpatient";
            this.lblpatient.Size = new System.Drawing.Size(438, 45);
            this.lblpatient.TabIndex = 6;
            this.lblpatient.Text = "Patient Name";
            this.lblpatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsend
            // 
            this.btnsend.ActiveBorderThickness = 1;
            this.btnsend.ActiveCornerRadius = 10;
            this.btnsend.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnsend.ActiveForecolor = System.Drawing.Color.White;
            this.btnsend.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnsend.BackColor = System.Drawing.SystemColors.Control;
            this.btnsend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsend.BackgroundImage")));
            this.btnsend.ButtonText = "Send";
            this.btnsend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsend.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnsend.IdleBorderThickness = 1;
            this.btnsend.IdleCornerRadius = 10;
            this.btnsend.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnsend.IdleForecolor = System.Drawing.Color.White;
            this.btnsend.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnsend.Location = new System.Drawing.Point(165, 245);
            this.btnsend.Margin = new System.Windows.Forms.Padding(5);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(98, 54);
            this.btnsend.TabIndex = 23;
            this.btnsend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // btncancel
            // 
            this.btncancel.ActiveBorderThickness = 1;
            this.btncancel.ActiveCornerRadius = 10;
            this.btncancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btncancel.ActiveForecolor = System.Drawing.Color.White;
            this.btncancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btncancel.BackColor = System.Drawing.SystemColors.Control;
            this.btncancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancel.BackgroundImage")));
            this.btncancel.ButtonText = "Cancel";
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btncancel.IdleBorderThickness = 1;
            this.btncancel.IdleCornerRadius = 10;
            this.btncancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btncancel.IdleForecolor = System.Drawing.Color.White;
            this.btncancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btncancel.Location = new System.Drawing.Point(284, 245);
            this.btncancel.Margin = new System.Windows.Forms.Padding(5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(98, 54);
            this.btncancel.TabIndex = 24;
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // frmNewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(541, 310);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.lblpatient);
            this.Controls.Add(this.OuterPanel);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewMessage";
            this.Load += new System.EventHandler(this.frmNewMessage_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmNewMessage_Paint);
            this.OuterPanel.ResumeLayout(false);
            this.InnerPanel.ResumeLayout(false);
            this.InnerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel OuterPanel;
        private System.Windows.Forms.Panel InnerPanel;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.Label lblpatient;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsend;
        private Bunifu.Framework.UI.BunifuThinButton2 btncancel;
    }
}