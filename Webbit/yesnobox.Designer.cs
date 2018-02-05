namespace PackChecker
{
    partial class yesnobox
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
            this.lblquestion = new System.Windows.Forms.Label();
            this.btnno = new System.Windows.Forms.Button();
            this.btnyes = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // lblquestion
            // 
            this.lblquestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblquestion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblquestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblquestion.Location = new System.Drawing.Point(12, 9);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(484, 87);
            this.lblquestion.TabIndex = 3;
            this.lblquestion.Text = "label1";
            this.lblquestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnno
            // 
            this.btnno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnno.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnno.FlatAppearance.BorderSize = 0;
            this.btnno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnno.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.btnno.ForeColor = System.Drawing.Color.White;
            this.btnno.Location = new System.Drawing.Point(273, 99);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(87, 37);
            this.btnno.TabIndex = 22;
            this.btnno.Text = "No";
            this.btnno.UseVisualStyleBackColor = false;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnyes
            // 
            this.btnyes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnyes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnyes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnyes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnyes.FlatAppearance.BorderSize = 0;
            this.btnyes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyes.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyes.ForeColor = System.Drawing.Color.White;
            this.btnyes.Location = new System.Drawing.Point(149, 99);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(89, 37);
            this.btnyes.TabIndex = 21;
            this.btnyes.Text = "Yes";
            this.btnyes.UseVisualStyleBackColor = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.btnyes;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.btnno;
            // 
            // yesnobox
            // 
            this.AcceptButton = this.btnyes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(508, 148);
            this.ControlBox = false;
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.Controls.Add(this.lblquestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yesnobox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inputbox";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.yesnobox_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Button btnno;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}