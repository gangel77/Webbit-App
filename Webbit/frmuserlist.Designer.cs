namespace PackChecker
{
    partial class frmuserlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmuserlist));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnaddnew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridlocation = new System.Windows.Forms.DataGridView();
            this.usersjobsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.websterdbwebbitdbdataset = new PackChecker.webbitdbdataset();
            this.users_jobsTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.users_jobsTableAdapter();
            this.clnuserid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnfirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnlastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnjob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnedit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersjobsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbwebbitdbdataset)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblTitle.Location = new System.Drawing.Point(172, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "User List";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 10;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Save and Close";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 10;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(328, 431);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(165, 41);
            this.bunifuThinButton21.TabIndex = 22;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnaddnew
            // 
            this.btnaddnew.ActiveBorderThickness = 1;
            this.btnaddnew.ActiveCornerRadius = 10;
            this.btnaddnew.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnaddnew.ActiveForecolor = System.Drawing.Color.White;
            this.btnaddnew.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnaddnew.BackColor = System.Drawing.Color.White;
            this.btnaddnew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaddnew.BackgroundImage")));
            this.btnaddnew.ButtonText = "Add New";
            this.btnaddnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddnew.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnew.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnaddnew.IdleBorderThickness = 1;
            this.btnaddnew.IdleCornerRadius = 10;
            this.btnaddnew.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnaddnew.IdleForecolor = System.Drawing.Color.White;
            this.btnaddnew.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnaddnew.Location = new System.Drawing.Point(153, 431);
            this.btnaddnew.Margin = new System.Windows.Forms.Padding(5);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(165, 41);
            this.btnaddnew.TabIndex = 23;
            this.btnaddnew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // dataGridlocation
            // 
            this.dataGridlocation.AllowUserToAddRows = false;
            this.dataGridlocation.AllowUserToDeleteRows = false;
            this.dataGridlocation.AllowUserToOrderColumns = true;
            this.dataGridlocation.AllowUserToResizeColumns = false;
            this.dataGridlocation.AllowUserToResizeRows = false;
            this.dataGridlocation.AutoGenerateColumns = false;
            this.dataGridlocation.BackgroundColor = System.Drawing.Color.White;
            this.dataGridlocation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridlocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridlocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridlocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnuserid,
            this.clnlogin,
            this.clnfirstname,
            this.clnlastname,
            this.clnjob,
            this.clnedit});
            this.dataGridlocation.DataSource = this.usersjobsBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridlocation.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridlocation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.dataGridlocation.Location = new System.Drawing.Point(12, 56);
            this.dataGridlocation.MultiSelect = false;
            this.dataGridlocation.Name = "dataGridlocation";
            this.dataGridlocation.ReadOnly = true;
            this.dataGridlocation.RowHeadersVisible = false;
            this.dataGridlocation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridlocation.RowTemplate.Height = 30;
            this.dataGridlocation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridlocation.Size = new System.Drawing.Size(622, 367);
            this.dataGridlocation.TabIndex = 24;
            this.dataGridlocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLocation_CellContentClick);
            this.dataGridlocation.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridlocation_CellPainting);
            this.dataGridlocation.SelectionChanged += new System.EventHandler(this.dataGridloction_SelectionChanged);
            // 
            // usersjobsBindingSource1
            // 
            this.usersjobsBindingSource1.DataMember = "users_jobs";
            this.usersjobsBindingSource1.DataSource = this.websterdbwebbitdbdataset;
            // 
            // websterdbwebbitdbdataset
            // 
            this.websterdbwebbitdbdataset.DataSetName = "websterdbwebbitdbdataset";
            this.websterdbwebbitdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // users_jobsTableAdapter
            // 
            this.users_jobsTableAdapter.ClearBeforeFill = true;
            // 
            // clnuserid
            // 
            this.clnuserid.DataPropertyName = "userid";
            this.clnuserid.HeaderText = "userid";
            this.clnuserid.Name = "clnuserid";
            this.clnuserid.ReadOnly = true;
            this.clnuserid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnuserid.Visible = false;
            // 
            // clnlogin
            // 
            this.clnlogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnlogin.DataPropertyName = "userlogin";
            this.clnlogin.HeaderText = "Login";
            this.clnlogin.Name = "clnlogin";
            this.clnlogin.ReadOnly = true;
            this.clnlogin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnlogin.Width = 54;
            // 
            // clnfirstname
            // 
            this.clnfirstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnfirstname.DataPropertyName = "userfirstname";
            this.clnfirstname.FillWeight = 30F;
            this.clnfirstname.HeaderText = "Firstname";
            this.clnfirstname.Name = "clnfirstname";
            this.clnfirstname.ReadOnly = true;
            this.clnfirstname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnlastname
            // 
            this.clnlastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnlastname.DataPropertyName = "userlastname";
            this.clnlastname.FillWeight = 30F;
            this.clnlastname.HeaderText = "Lastname";
            this.clnlastname.Name = "clnlastname";
            this.clnlastname.ReadOnly = true;
            this.clnlastname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnjob
            // 
            this.clnjob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnjob.DataPropertyName = "jobname";
            this.clnjob.FillWeight = 40F;
            this.clnjob.HeaderText = "Postion";
            this.clnjob.Name = "clnjob";
            this.clnjob.ReadOnly = true;
            this.clnjob.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnedit
            // 
            this.clnedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnedit.HeaderText = "Edit";
            this.clnedit.Name = "clnedit";
            this.clnedit.ReadOnly = true;
            this.clnedit.Width = 41;
            // 
            // frmuserlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 485);
            this.Controls.Add(this.dataGridlocation);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmuserlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locations";
            this.Load += new System.EventHandler(this.frmlocationlist_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmuserlist_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersjobsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbwebbitdbdataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private webbitdbdataset websterdbwebbitdbdataset;
        private webbitdbdatasetTableAdapters.users_jobsTableAdapter users_jobsTableAdapter;
        private System.Windows.Forms.BindingSource usersjobsBindingSource1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 btnaddnew;
        private System.Windows.Forms.DataGridView dataGridlocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnuserid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnlogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnfirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnlastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnjob;
        private System.Windows.Forms.DataGridViewButtonColumn clnedit;
    }
}