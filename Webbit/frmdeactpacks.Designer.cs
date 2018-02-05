namespace PackChecker
{
    partial class frmdeactpacks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdeactpacks));
            this.dataGriddeact = new System.Windows.Forms.DataGridView();
            this.packid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpatientid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pxname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCycleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clndeactcomment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnreason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.cmbpatient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriddeact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGriddeact
            // 
            this.dataGriddeact.AllowUserToAddRows = false;
            this.dataGriddeact.AllowUserToDeleteRows = false;
            this.dataGriddeact.AllowUserToResizeColumns = false;
            this.dataGriddeact.AllowUserToResizeRows = false;
            this.dataGriddeact.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGriddeact.BackgroundColor = System.Drawing.Color.White;
            this.dataGriddeact.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriddeact.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGriddeact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriddeact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packid,
            this.clnpatientid,
            this.pxname,
            this.clnCycleDate,
            this.clndeactcomment,
            this.clnreason,
            this.clnactive});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGriddeact.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGriddeact.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.dataGriddeact.Location = new System.Drawing.Point(20, 105);
            this.dataGriddeact.MultiSelect = false;
            this.dataGriddeact.Name = "dataGriddeact";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriddeact.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGriddeact.RowHeadersVisible = false;
            this.dataGriddeact.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGriddeact.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGriddeact.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGriddeact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGriddeact.Size = new System.Drawing.Size(808, 461);
            this.dataGriddeact.TabIndex = 0;
            this.dataGriddeact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChanges_CellContentClick);
            this.dataGriddeact.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChanges_CellDoubleClick);
            this.dataGriddeact.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridChanges_CellPainting);
            this.dataGriddeact.SelectionChanged += new System.EventHandler(this.dataGridChanges_SelectionChanged);
            // 
            // packid
            // 
            this.packid.HeaderText = "packid";
            this.packid.Name = "packid";
            this.packid.Visible = false;
            this.packid.Width = 61;
            // 
            // clnpatientid
            // 
            this.clnpatientid.HeaderText = "PatientID";
            this.clnpatientid.Name = "clnpatientid";
            this.clnpatientid.Visible = false;
            this.clnpatientid.Width = 82;
            // 
            // pxname
            // 
            this.pxname.HeaderText = "Patient";
            this.pxname.Name = "pxname";
            this.pxname.ReadOnly = true;
            this.pxname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pxname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pxname.Width = 200;
            // 
            // clnCycleDate
            // 
            this.clnCycleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnCycleDate.HeaderText = "Pack Date";
            this.clnCycleDate.Name = "clnCycleDate";
            this.clnCycleDate.ReadOnly = true;
            this.clnCycleDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnCycleDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnCycleDate.Width = 82;
            // 
            // clndeactcomment
            // 
            this.clndeactcomment.HeaderText = "Comment";
            this.clndeactcomment.Name = "clndeactcomment";
            this.clndeactcomment.ReadOnly = true;
            this.clndeactcomment.Width = 400;
            // 
            // clnreason
            // 
            this.clnreason.HeaderText = "Reason";
            this.clnreason.Name = "clnreason";
            this.clnreason.ReadOnly = true;
            // 
            // clnactive
            // 
            this.clnactive.HeaderText = "active";
            this.clnactive.Name = "clnactive";
            this.clnactive.ReadOnly = true;
            this.clnactive.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deactivated Packs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblusername.Location = new System.Drawing.Point(51, 52);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(148, 30);
            this.lblusername.TabIndex = 5;
            this.lblusername.Text = "Current User";
            // 
            // cmbpatient
            // 
            this.cmbpatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbpatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbpatient.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpatient.FormattingEnabled = true;
            this.cmbpatient.Location = new System.Drawing.Point(518, 52);
            this.cmbpatient.Name = "cmbpatient";
            this.cmbpatient.Size = new System.Drawing.Size(310, 31);
            this.cmbpatient.TabIndex = 6;
            this.cmbpatient.SelectionChangeCommitted += new System.EventHandler(this.cmbpatient_SelectionChangeCommitted);
            this.cmbpatient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbpatient_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PackChecker.Properties.Resources.icon_user;
            this.pictureBox1.Location = new System.Drawing.Point(19, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnclose
            // 
            this.btnclose.ActiveBorderThickness = 1;
            this.btnclose.ActiveCornerRadius = 10;
            this.btnclose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclose.ActiveForecolor = System.Drawing.Color.White;
            this.btnclose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.ButtonText = "Close";
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnclose.IdleBorderThickness = 1;
            this.btnclose.IdleCornerRadius = 10;
            this.btnclose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclose.IdleForecolor = System.Drawing.Color.White;
            this.btnclose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclose.Location = new System.Drawing.Point(387, 573);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 54);
            this.btnclose.TabIndex = 22;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // frmdeactpacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(859, 641);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbpatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGriddeact);
            this.Controls.Add(this.lblusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmdeactpacks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changing Packs";
            this.Load += new System.EventHandler(this.frmchecking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGriddeact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGriddeact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.ComboBox cmbpatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn packid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpatientid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pxname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCycleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clndeactcomment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnreason;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnactive;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
    }
}

