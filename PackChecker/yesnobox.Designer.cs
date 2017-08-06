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
            this.btnyes = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.lblquestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnyes
            // 
            this.btnyes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyes.Location = new System.Drawing.Point(78, 80);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(89, 37);
            this.btnyes.TabIndex = 1;
            this.btnyes.Text = "Yes";
            this.btnyes.UseVisualStyleBackColor = true;
            // 
            // btnno
            // 
            this.btnno.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnno.Location = new System.Drawing.Point(217, 80);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(87, 37);
            this.btnno.TabIndex = 2;
            this.btnno.Text = "No";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // lblquestion
            // 
            this.lblquestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.Location = new System.Drawing.Point(12, 9);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(361, 68);
            this.lblquestion.TabIndex = 3;
            this.lblquestion.Text = "label1";
            this.lblquestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesnobox
            // 
            this.AcceptButton = this.btnyes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 128);
            this.ControlBox = false;
            this.Controls.Add(this.lblquestion);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.Name = "yesnobox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inputbox";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Label lblquestion;
    }
}