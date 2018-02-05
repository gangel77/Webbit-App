namespace PackChecker
{
    partial class frmchanges
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmchanges));
            this.dataGridChanges = new System.Windows.Forms.DataGridView();
            this.packid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnweeksinpack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnorigcycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpatientid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pxname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCycleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpackeduser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPackComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnchange = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnerror = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndeactivate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clncycleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.cmbpatient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcurview = new System.Windows.Forms.Label();
            this.btnviewall = new System.Windows.Forms.Button();
            this.btnuncollected = new System.Windows.Forms.Button();
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridChanges
            // 
            this.dataGridChanges.AllowUserToAddRows = false;
            this.dataGridChanges.AllowUserToDeleteRows = false;
            this.dataGridChanges.AllowUserToResizeColumns = false;
            this.dataGridChanges.AllowUserToResizeRows = false;
            this.dataGridChanges.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridChanges.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridChanges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packid,
            this.clnweeksinpack,
            this.clnorigcycle,
            this.clnpatientid,
            this.pxname,
            this.clnCycleDate,
            this.clnpackeduser,
            this.clnPackComment,
            this.clnchange,
            this.clnerror,
            this.clnactive,
            this.btndeactivate,
            this.clncycleid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridChanges.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridChanges.EnableHeadersVisualStyles = false;
            this.dataGridChanges.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.dataGridChanges.Location = new System.Drawing.Point(20, 159);
            this.dataGridChanges.MultiSelect = false;
            this.dataGridChanges.Name = "dataGridChanges";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridChanges.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridChanges.RowHeadersVisible = false;
            this.dataGridChanges.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridChanges.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridChanges.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridChanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridChanges.Size = new System.Drawing.Size(1008, 461);
            this.dataGridChanges.TabIndex = 0;
            this.dataGridChanges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChanges_CellContentClick);
            this.dataGridChanges.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChanges_CellDoubleClick);
            this.dataGridChanges.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridChanges_CellPainting);
            this.dataGridChanges.SelectionChanged += new System.EventHandler(this.dataGridChanges_SelectionChanged);
            // 
            // packid
            // 
            this.packid.HeaderText = "packid";
            this.packid.Name = "packid";
            this.packid.Visible = false;
            this.packid.Width = 61;
            // 
            // clnweeksinpack
            // 
            this.clnweeksinpack.HeaderText = "weeksinpack";
            this.clnweeksinpack.Name = "clnweeksinpack";
            this.clnweeksinpack.Visible = false;
            // 
            // clnorigcycle
            // 
            this.clnorigcycle.HeaderText = "origcycle";
            this.clnorigcycle.Name = "clnorigcycle";
            this.clnorigcycle.Visible = false;
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
            this.pxname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pxname.HeaderText = "Patient";
            this.pxname.Name = "pxname";
            this.pxname.ReadOnly = true;
            this.pxname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pxname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pxname.Width = 63;
            // 
            // clnCycleDate
            // 
            this.clnCycleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnCycleDate.HeaderText = "Pack Date";
            this.clnCycleDate.Name = "clnCycleDate";
            this.clnCycleDate.ReadOnly = true;
            this.clnCycleDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnCycleDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnCycleDate.Width = 82;
            // 
            // clnpackeduser
            // 
            this.clnpackeduser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnpackeduser.HeaderText = "Packer";
            this.clnpackeduser.Name = "clnpackeduser";
            this.clnpackeduser.ReadOnly = true;
            this.clnpackeduser.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnpackeduser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnpackeduser.Width = 60;
            // 
            // clnPackComment
            // 
            this.clnPackComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnPackComment.HeaderText = "Pack Comment";
            this.clnPackComment.Name = "clnPackComment";
            this.clnPackComment.ReadOnly = true;
            this.clnPackComment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnPackComment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnchange
            // 
            this.clnchange.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnchange.HeaderText = "Change";
            this.clnchange.Name = "clnchange";
            this.clnchange.Width = 67;
            // 
            // clnerror
            // 
            this.clnerror.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnerror.HeaderText = "Error";
            this.clnerror.Name = "clnerror";
            this.clnerror.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnerror.Width = 47;
            // 
            // clnactive
            // 
            this.clnactive.HeaderText = "active";
            this.clnactive.Name = "clnactive";
            this.clnactive.ReadOnly = true;
            this.clnactive.Visible = false;
            // 
            // btndeactivate
            // 
            this.btndeactivate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btndeactivate.HeaderText = "Deactivate";
            this.btndeactivate.Name = "btndeactivate";
            this.btndeactivate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btndeactivate.Width = 87;
            // 
            // clncycleid
            // 
            this.clncycleid.HeaderText = "cycle";
            this.clncycleid.Name = "clncycleid";
            this.clncycleid.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(833, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Edit Checked Packs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblusername.Location = new System.Drawing.Point(58, 21);
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
            this.cmbpatient.Location = new System.Drawing.Point(648, 118);
            this.cmbpatient.MaxDropDownItems = 5;
            this.cmbpatient.Name = "cmbpatient";
            this.cmbpatient.Size = new System.Drawing.Size(310, 31);
            this.cmbpatient.TabIndex = 6;
            this.cmbpatient.SelectionChangeCommitted += new System.EventHandler(this.cmbpatient_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(481, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Patient Filter:";
            // 
            // lblcurview
            // 
            this.lblcurview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcurview.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurview.ForeColor = System.Drawing.Color.Firebrick;
            this.lblcurview.Location = new System.Drawing.Point(127, 61);
            this.lblcurview.Name = "lblcurview";
            this.lblcurview.Size = new System.Drawing.Size(817, 42);
            this.lblcurview.TabIndex = 8;
            this.lblcurview.Text = "CurrentView";
            this.lblcurview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnviewall
            // 
            this.btnviewall.Location = new System.Drawing.Point(20, 106);
            this.btnviewall.Name = "btnviewall";
            this.btnviewall.Size = new System.Drawing.Size(110, 30);
            this.btnviewall.TabIndex = 9;
            this.btnviewall.Text = "View All Packs";
            this.btnviewall.UseVisualStyleBackColor = true;
            this.btnviewall.Visible = false;
            this.btnviewall.Click += new System.EventHandler(this.btnviewall_Click);
            // 
            // btnuncollected
            // 
            this.btnuncollected.Location = new System.Drawing.Point(20, 106);
            this.btnuncollected.Name = "btnuncollected";
            this.btnuncollected.Size = new System.Drawing.Size(110, 30);
            this.btnuncollected.TabIndex = 10;
            this.btnuncollected.TabStop = false;
            this.btnuncollected.Text = "View Uncollected";
            this.btnuncollected.UseVisualStyleBackColor = true;
            this.btnuncollected.Visible = false;
            this.btnuncollected.Click += new System.EventHandler(this.btnuncollected_Click);
            // 
            // btnclose
            // 
            this.btnclose.ActiveBorderThickness = 1;
            this.btnclose.ActiveCornerRadius = 10;
            this.btnclose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclose.ActiveForecolor = System.Drawing.Color.White;
            this.btnclose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclose.BackColor = System.Drawing.Color.White;
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
            this.btnclose.Location = new System.Drawing.Point(479, 629);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 54);
            this.btnclose.TabIndex = 22;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PackChecker.Properties.Resources.icon_user;
            this.pictureBox1.Location = new System.Drawing.Point(20, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 10;
            this.btnClear.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 10;
            this.btnClear.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnClear.IdleForecolor = System.Drawing.Color.White;
            this.btnClear.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnClear.Location = new System.Drawing.Point(965, 112);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 43);
            this.btnClear.TabIndex = 24;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmchanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 697);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnuncollected);
            this.Controls.Add(this.btnviewall);
            this.Controls.Add(this.lblcurview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbpatient);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.dataGridChanges);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmchanges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changing Packs";
            this.Load += new System.EventHandler(this.frmchecking_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmchanges_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.ComboBox cmbpatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcurview;
        private System.Windows.Forms.Button btnviewall;
        private System.Windows.Forms.Button btnuncollected;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn packid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnweeksinpack;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnorigcycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpatientid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pxname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCycleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpackeduser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPackComment;
        private System.Windows.Forms.DataGridViewButtonColumn clnchange;
        private System.Windows.Forms.DataGridViewButtonColumn clnerror;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnactive;
        private System.Windows.Forms.DataGridViewButtonColumn btndeactivate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncycleid;
    }
}

