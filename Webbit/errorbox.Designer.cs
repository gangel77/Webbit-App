namespace PackChecker
{
    partial class errorbox
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
            this.lblquestion1 = new System.Windows.Forms.Label();
            this.lblquestion2 = new System.Windows.Forms.Label();
            this.OuterPanel = new System.Windows.Forms.Panel();
            this.InnerPanel = new System.Windows.Forms.Panel();
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtanswer2 = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.OuterPanel.SuspendLayout();
            this.InnerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblquestion1
            // 
            this.lblquestion1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblquestion1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblquestion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblquestion1.Location = new System.Drawing.Point(12, 13);
            this.lblquestion1.Name = "lblquestion1";
            this.lblquestion1.Size = new System.Drawing.Size(438, 58);
            this.lblquestion1.TabIndex = 3;
            this.lblquestion1.Text = "label1";
            this.lblquestion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblquestion2
            // 
            this.lblquestion2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblquestion2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblquestion2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblquestion2.Location = new System.Drawing.Point(12, 118);
            this.lblquestion2.Name = "lblquestion2";
            this.lblquestion2.Size = new System.Drawing.Size(438, 42);
            this.lblquestion2.TabIndex = 4;
            this.lblquestion2.Text = "label1";
            this.lblquestion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OuterPanel
            // 
            this.OuterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.OuterPanel.Controls.Add(this.InnerPanel);
            this.OuterPanel.Location = new System.Drawing.Point(179, 74);
            this.OuterPanel.Name = "OuterPanel";
            this.OuterPanel.Size = new System.Drawing.Size(104, 33);
            this.OuterPanel.TabIndex = 0;
            this.OuterPanel.TabStop = true;
            // 
            // InnerPanel
            // 
            this.InnerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.InnerPanel.Controls.Add(this.txtanswer);
            this.InnerPanel.Location = new System.Drawing.Point(2, 2);
            this.InnerPanel.Name = "InnerPanel";
            this.InnerPanel.Size = new System.Drawing.Size(99, 29);
            this.InnerPanel.TabIndex = 1;
            this.InnerPanel.TabStop = true;
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
            this.txtanswer.Size = new System.Drawing.Size(80, 19);
            this.txtanswer.TabIndex = 3;
            this.txtanswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtanswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtanswer_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(30, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 33);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.txtanswer2);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 29);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // txtanswer2
            // 
            this.txtanswer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.txtanswer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtanswer2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtanswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanswer2.Location = new System.Drawing.Point(10, 5);
            this.txtanswer2.MaxLength = 100;
            this.txtanswer2.Name = "txtanswer2";
            this.txtanswer2.Size = new System.Drawing.Size(384, 19);
            this.txtanswer2.TabIndex = 3;
            this.txtanswer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtanswer2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtanswer2_KeyDown);
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
            this.btnok.Location = new System.Drawing.Point(126, 212);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(87, 37);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
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
            this.btncancel.Location = new System.Drawing.Point(249, 212);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(87, 37);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.btnok;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.btncancel;
            // 
            // errorbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(462, 266);
            this.ControlBox = false;
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OuterPanel);
            this.Controls.Add(this.lblquestion2);
            this.Controls.Add(this.lblquestion1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "errorbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inputbox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.errorbox_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.errorbox_Paint);
            this.OuterPanel.ResumeLayout(false);
            this.InnerPanel.ResumeLayout(false);
            this.InnerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblquestion1;
        private System.Windows.Forms.Label lblquestion2;
        private System.Windows.Forms.Panel OuterPanel;
        private System.Windows.Forms.Panel InnerPanel;
        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtanswer2;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}