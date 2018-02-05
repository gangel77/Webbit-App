namespace PackChecker
{
    partial class msgboxlarge
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
            this.btnok = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblquestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnok.FlatAppearance.BorderSize = 0;
            this.btnok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Location = new System.Drawing.Point(219, 213);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(89, 37);
            this.btnok.TabIndex = 20;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.btnok;
            // 
            // lblquestion
            // 
            this.lblquestion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblquestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblquestion.Location = new System.Drawing.Point(12, 9);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(495, 201);
            this.lblquestion.TabIndex = 3;
            this.lblquestion.Text = "label1";
            this.lblquestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msgboxlarge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(519, 263);
            this.ControlBox = false;
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.lblquestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "msgboxlarge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inputbox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.msgbox_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.msgbox_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnok;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        public System.Windows.Forms.Label lblquestion;
    }
}