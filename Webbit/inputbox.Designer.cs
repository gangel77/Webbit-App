namespace PackChecker
{
    partial class inputbox
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
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.lblquestion = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnok = new System.Windows.Forms.Button();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.OuterPanel = new System.Windows.Forms.Panel();
            this.InnerPanel = new System.Windows.Forms.Panel();
            this.OuterPanel.SuspendLayout();
            this.InnerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtanswer
            // 
            this.txtanswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.txtanswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtanswer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanswer.Location = new System.Drawing.Point(10, 5);
            this.txtanswer.MaxLength = 100;
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(290, 19);
            this.txtanswer.TabIndex = 3;
            this.txtanswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblquestion
            // 
            this.lblquestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblquestion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblquestion.Location = new System.Drawing.Point(12, 13);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(358, 45);
            this.lblquestion.TabIndex = 6;
            this.lblquestion.Text = "label1";
            this.lblquestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(219, 99);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(87, 37);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.btnok;
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnok.FlatAppearance.BorderSize = 0;
            this.btnok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Location = new System.Drawing.Point(102, 99);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(87, 37);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.btncancel;
            // 
            // OuterPanel
            // 
            this.OuterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            this.OuterPanel.Controls.Add(this.InnerPanel);
            this.OuterPanel.Location = new System.Drawing.Point(39, 58);
            this.OuterPanel.Name = "OuterPanel";
            this.OuterPanel.Size = new System.Drawing.Size(316, 33);
            this.OuterPanel.TabIndex = 0;
            this.OuterPanel.TabStop = true;
            this.OuterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // InnerPanel
            // 
            this.InnerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.InnerPanel.Controls.Add(this.txtanswer);
            this.InnerPanel.Location = new System.Drawing.Point(2, 2);
            this.InnerPanel.Name = "InnerPanel";
            this.InnerPanel.Size = new System.Drawing.Size(312, 29);
            this.InnerPanel.TabIndex = 1;
            this.InnerPanel.TabStop = true;
            // 
            // inputbox
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(382, 148);
            this.ControlBox = false;
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.lblquestion);
            this.Controls.Add(this.OuterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inputbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "inputbox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.inputbox_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.inputbox_Paint);
            this.OuterPanel.ResumeLayout(false);
            this.InnerPanel.ResumeLayout(false);
            this.InnerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.Button btncancel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Panel OuterPanel;
        private System.Windows.Forms.Panel InnerPanel;
    }
}