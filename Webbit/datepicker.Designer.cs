namespace PackChecker
{
    partial class datepicker
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblquestion = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.OuterPanel = new System.Windows.Forms.Panel();
            this.InnerPanel = new System.Windows.Forms.Panel();
            this.OuterPanel.SuspendLayout();
            this.InnerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(30, 1);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(252, 27);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblquestion
            // 
            this.lblquestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblquestion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblquestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblquestion.Location = new System.Drawing.Point(12, 9);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(439, 66);
            this.lblquestion.TabIndex = 6;
            this.lblquestion.Text = "label1";
            this.lblquestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblquestion.Click += new System.EventHandler(this.lblquestion_Click);
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
            this.btncancel.Location = new System.Drawing.Point(254, 130);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(87, 37);
            this.btncancel.TabIndex = 22;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnok.FlatAppearance.BorderSize = 0;
            this.btnok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Location = new System.Drawing.Point(123, 130);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(89, 37);
            this.btnok.TabIndex = 21;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.btnok;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.btncancel;
            // 
            // OuterPanel
            // 
            this.OuterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.OuterPanel.Controls.Add(this.InnerPanel);
            this.OuterPanel.Location = new System.Drawing.Point(74, 88);
            this.OuterPanel.Name = "OuterPanel";
            this.OuterPanel.Size = new System.Drawing.Size(316, 33);
            this.OuterPanel.TabIndex = 23;
            this.OuterPanel.TabStop = true;
            // 
            // InnerPanel
            // 
            this.InnerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.InnerPanel.Controls.Add(this.dateTimePicker);
            this.InnerPanel.Location = new System.Drawing.Point(2, 2);
            this.InnerPanel.Name = "InnerPanel";
            this.InnerPanel.Size = new System.Drawing.Size(312, 29);
            this.InnerPanel.TabIndex = 1;
            this.InnerPanel.TabStop = true;
            // 
            // datepicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 186);
            this.Controls.Add(this.OuterPanel);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.lblquestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "datepicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Picker";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.datepicker_Paint);
            this.OuterPanel.ResumeLayout(false);
            this.InnerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Panel OuterPanel;
        private System.Windows.Forms.Panel InnerPanel;
    }
}