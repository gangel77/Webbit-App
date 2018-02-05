namespace PackChecker
{
    partial class frmchecking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmchecking));
            this.dataGridChecked = new System.Windows.Forms.DataGridView();
            this.packid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnweeksinpack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnorigcycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpatientid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pxname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCycleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpackeduser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPackComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncheck = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnreversecheck = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnchange = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnerror = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btndeactivate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlkey = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChecked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlkey.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridChecked
            // 
            this.dataGridChecked.AllowUserToAddRows = false;
            this.dataGridChecked.AllowUserToDeleteRows = false;
            this.dataGridChecked.AllowUserToResizeColumns = false;
            this.dataGridChecked.AllowUserToResizeRows = false;
            this.dataGridChecked.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridChecked.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridChecked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChecked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packid,
            this.clnweeksinpack,
            this.clnorigcycle,
            this.clnpatientid,
            this.pxname,
            this.clnCycleDate,
            this.clnpackeduser,
            this.clnPackComment,
            this.clncheck,
            this.clnreversecheck,
            this.clnchange,
            this.clnerror,
            this.btndeactivate,
            this.clnactive});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridChecked.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridChecked.EnableHeadersVisualStyles = false;
            this.dataGridChecked.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.dataGridChecked.Location = new System.Drawing.Point(20, 68);
            this.dataGridChecked.MultiSelect = false;
            this.dataGridChecked.Name = "dataGridChecked";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridChecked.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridChecked.RowHeadersVisible = false;
            this.dataGridChecked.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridChecked.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridChecked.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridChecked.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridChecked.Size = new System.Drawing.Size(1023, 482);
            this.dataGridChecked.TabIndex = 0;
            this.dataGridChecked.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChecked_CellContentClick);
            this.dataGridChecked.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChecked_CellDoubleClick);
            this.dataGridChecked.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridChecked_CellPainting);
            this.dataGridChecked.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridChecked_KeyDown);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnorigcycle.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.pxname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.pxname.DefaultCellStyle = dataGridViewCellStyle3;
            this.pxname.FillWeight = 40F;
            this.pxname.HeaderText = "Patient";
            this.pxname.Name = "pxname";
            this.pxname.ReadOnly = true;
            this.pxname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pxname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnCycleDate
            // 
            this.clnCycleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnCycleDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnCycleDate.FillWeight = 20F;
            this.clnCycleDate.HeaderText = "Pack Date";
            this.clnCycleDate.Name = "clnCycleDate";
            this.clnCycleDate.ReadOnly = true;
            this.clnCycleDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnCycleDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnpackeduser
            // 
            this.clnpackeduser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnpackeduser.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clnPackComment.DefaultCellStyle = dataGridViewCellStyle6;
            this.clnPackComment.FillWeight = 40F;
            this.clnPackComment.HeaderText = "Pack Comment";
            this.clnPackComment.Name = "clnPackComment";
            this.clnPackComment.ReadOnly = true;
            this.clnPackComment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnPackComment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clncheck
            // 
            this.clncheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clncheck.HeaderText = "Check";
            this.clncheck.Name = "clncheck";
            this.clncheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clncheck.Width = 56;
            // 
            // clnreversecheck
            // 
            this.clnreversecheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.clnreversecheck.DefaultCellStyle = dataGridViewCellStyle7;
            this.clnreversecheck.HeaderText = "Undo";
            this.clnreversecheck.Name = "clnreversecheck";
            this.clnreversecheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnreversecheck.Width = 52;
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
            // btndeactivate
            // 
            this.btndeactivate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btndeactivate.HeaderText = "Delete";
            this.btndeactivate.Name = "btndeactivate";
            this.btndeactivate.Width = 59;
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(364, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Checking List";
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
            // lblcount
            // 
            this.lblcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcount.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lblcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblcount.Location = new System.Drawing.Point(771, 21);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(272, 33);
            this.lblcount.TabIndex = 11;
            this.lblcount.Text = "packs to go";
            this.lblcount.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.btnclose.Location = new System.Drawing.Point(485, 558);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 54);
            this.btnclose.TabIndex = 20;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PackChecker.Properties.Resources.icon_user;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pnlkey
            // 
            this.pnlkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlkey.Controls.Add(this.label4);
            this.pnlkey.Controls.Add(this.label5);
            this.pnlkey.Controls.Add(this.panel3);
            this.pnlkey.Controls.Add(this.panel5);
            this.pnlkey.Controls.Add(this.label2);
            this.pnlkey.Controls.Add(this.label3);
            this.pnlkey.Controls.Add(this.panel4);
            this.pnlkey.Controls.Add(this.panel2);
            this.pnlkey.Location = new System.Drawing.Point(37, 567);
            this.pnlkey.Name = "pnlkey";
            this.pnlkey.Size = new System.Drawing.Size(388, 44);
            this.pnlkey.TabIndex = 26;
            this.pnlkey.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(29, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Currently selected row";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(29, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Checked";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.panel3.Location = new System.Drawing.Point(10, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 15);
            this.panel3.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.ForestGreen;
            this.panel5.Location = new System.Drawing.Point(10, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 15);
            this.panel5.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(225, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Not in current cycle";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(225, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Has Comment";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Location = new System.Drawing.Point(206, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 15);
            this.panel4.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Location = new System.Drawing.Point(206, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 15);
            this.panel2.TabIndex = 23;
            // 
            // frmchecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 623);
            this.Controls.Add(this.pnlkey);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.dataGridChecked);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmchecking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checking";
            this.Load += new System.EventHandler(this.frmchecking_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmchecking_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChecked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlkey.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblcount;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn packid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnweeksinpack;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnorigcycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpatientid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pxname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCycleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpackeduser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPackComment;
        private System.Windows.Forms.DataGridViewButtonColumn clncheck;
        private System.Windows.Forms.DataGridViewButtonColumn clnreversecheck;
        private System.Windows.Forms.DataGridViewButtonColumn clnchange;
        private System.Windows.Forms.DataGridViewButtonColumn clnerror;
        private System.Windows.Forms.DataGridViewButtonColumn btndeactivate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnactive;
        private System.Windows.Forms.Panel pnlkey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}

