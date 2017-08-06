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
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.lblquestion1 = new System.Windows.Forms.Label();
            this.lblquestion2 = new System.Windows.Forms.Label();
            this.txtanswer2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtanswer
            // 
            this.txtanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanswer.Location = new System.Drawing.Point(41, 38);
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(311, 22);
            this.txtanswer.TabIndex = 0;
            this.txtanswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtanswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtanswer_KeyDown);
            // 
            // btnok
            // 
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(83, 134);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(89, 37);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(222, 134);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(87, 37);
            this.btncancel.TabIndex = 3;
            this.btncancel.TabStop = false;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // lblquestion1
            // 
            this.lblquestion1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblquestion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion1.Location = new System.Drawing.Point(38, 13);
            this.lblquestion1.Name = "lblquestion1";
            this.lblquestion1.Size = new System.Drawing.Size(311, 23);
            this.lblquestion1.TabIndex = 3;
            this.lblquestion1.Text = "label1";
            this.lblquestion1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblquestion2
            // 
            this.lblquestion2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblquestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion2.Location = new System.Drawing.Point(38, 67);
            this.lblquestion2.Name = "lblquestion2";
            this.lblquestion2.Size = new System.Drawing.Size(311, 23);
            this.lblquestion2.TabIndex = 4;
            this.lblquestion2.Text = "label1";
            this.lblquestion2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtanswer2
            // 
            this.txtanswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanswer2.Location = new System.Drawing.Point(41, 93);
            this.txtanswer2.Name = "txtanswer2";
            this.txtanswer2.Size = new System.Drawing.Size(311, 22);
            this.txtanswer2.TabIndex = 1;
            this.txtanswer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtanswer2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtanswer2_KeyDown);
            // 
            // errorbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 183);
            this.ControlBox = false;
            this.Controls.Add(this.txtanswer2);
            this.Controls.Add(this.lblquestion2);
            this.Controls.Add(this.lblquestion1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtanswer);
            this.Name = "errorbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inputbox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.inputbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label lblquestion1;
        private System.Windows.Forms.Label lblquestion2;
        private System.Windows.Forms.TextBox txtanswer2;
    }
}