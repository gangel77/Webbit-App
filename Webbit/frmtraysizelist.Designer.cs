namespace PackChecker
{
    partial class frmtraysizelist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtraysizelist));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.webbitdbdataset = new PackChecker.webbitdbdataset();
            this.tblpacksizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpacksizeTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblpacksizeTableAdapter();
            this.tableAdapterManager = new PackChecker.webbitdbdatasetTableAdapters.TableAdapterManager();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddnew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSaveandClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DataGridpacksize = new System.Windows.Forms.DataGridView();
            this.sizeorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpacksizeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizelongname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnhide = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clndelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnedit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridpacksize)).BeginInit();
            this.SuspendLayout();
            // 
            // webbitdbdataset
            // 
            this.webbitdbdataset.DataSetName = "webbitdbdataset";
            this.webbitdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblpacksizeBindingSource
            // 
            this.tblpacksizeBindingSource.DataMember = "tblpacksize";
            this.tblpacksizeBindingSource.DataSource = this.webbitdbdataset;
            // 
            // tblpacksizeTableAdapter
            // 
            this.tblpacksizeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.casualpxTableAdapter = null;
            this.tableAdapterManager.tblcycleTableAdapter = null;
            this.tableAdapterManager.tbldateTableAdapter = null;
            this.tableAdapterManager.tblinstitutionTableAdapter = null;
            this.tableAdapterManager.tbljobTableAdapter = null;
            this.tableAdapterManager.tblpacklocationTableAdapter = null;
            this.tableAdapterManager.tblpacksizeTableAdapter = this.tblpacksizeTableAdapter;
            this.tableAdapterManager.tblpackTableAdapter = null;
            this.tableAdapterManager.tblpatientTableAdapter = null;
            this.tableAdapterManager.tblsettingsTableAdapter = null;
            this.tableAdapterManager.tbluserTableAdapter = null;
            this.tableAdapterManager.tblweekTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PackChecker.webbitdbdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usecycleTableAdapter = null;
            this.tableAdapterManager.uselocationTableAdapter = null;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblTitle.Location = new System.Drawing.Point(158, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 48);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Tray Size List";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddnew
            // 
            this.btnAddnew.ActiveBorderThickness = 1;
            this.btnAddnew.ActiveCornerRadius = 10;
            this.btnAddnew.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnAddnew.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddnew.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnAddnew.BackColor = System.Drawing.Color.White;
            this.btnAddnew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddnew.BackgroundImage")));
            this.btnAddnew.ButtonText = "Add New";
            this.btnAddnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddnew.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnew.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddnew.IdleBorderThickness = 1;
            this.btnAddnew.IdleCornerRadius = 10;
            this.btnAddnew.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnAddnew.IdleForecolor = System.Drawing.Color.White;
            this.btnAddnew.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnAddnew.Location = new System.Drawing.Point(127, 298);
            this.btnAddnew.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(150, 41);
            this.btnAddnew.TabIndex = 25;
            this.btnAddnew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // btnSaveandClose
            // 
            this.btnSaveandClose.ActiveBorderThickness = 1;
            this.btnSaveandClose.ActiveCornerRadius = 10;
            this.btnSaveandClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnSaveandClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaveandClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnSaveandClose.BackColor = System.Drawing.Color.White;
            this.btnSaveandClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveandClose.BackgroundImage")));
            this.btnSaveandClose.ButtonText = "Save and Close";
            this.btnSaveandClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveandClose.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveandClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSaveandClose.IdleBorderThickness = 1;
            this.btnSaveandClose.IdleCornerRadius = 10;
            this.btnSaveandClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnSaveandClose.IdleForecolor = System.Drawing.Color.White;
            this.btnSaveandClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnSaveandClose.Location = new System.Drawing.Point(287, 298);
            this.btnSaveandClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveandClose.Name = "btnSaveandClose";
            this.btnSaveandClose.Size = new System.Drawing.Size(150, 41);
            this.btnSaveandClose.TabIndex = 24;
            this.btnSaveandClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveandClose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // DataGridpacksize
            // 
            this.DataGridpacksize.AllowUserToAddRows = false;
            this.DataGridpacksize.AllowUserToDeleteRows = false;
            this.DataGridpacksize.AllowUserToResizeColumns = false;
            this.DataGridpacksize.AllowUserToResizeRows = false;
            this.DataGridpacksize.AutoGenerateColumns = false;
            this.DataGridpacksize.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myriad Pro", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridpacksize.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridpacksize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridpacksize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sizeorder,
            this.clnpacksizeid,
            this.dataGridViewTextBoxColumn2,
            this.sizelongname,
            this.dataGridViewTextBoxColumn3,
            this.clnhide,
            this.clndelete,
            this.clnedit});
            this.DataGridpacksize.DataSource = this.tblpacksizeBindingSource;
            this.DataGridpacksize.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.DataGridpacksize.Location = new System.Drawing.Point(12, 70);
            this.DataGridpacksize.MultiSelect = false;
            this.DataGridpacksize.Name = "DataGridpacksize";
            this.DataGridpacksize.ReadOnly = true;
            this.DataGridpacksize.RowHeadersVisible = false;
            this.DataGridpacksize.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridpacksize.Size = new System.Drawing.Size(536, 220);
            this.DataGridpacksize.TabIndex = 26;
            this.DataGridpacksize.TabStop = false;
            this.DataGridpacksize.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridpacksize_CellContentClick);
            this.DataGridpacksize.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridpacksize_CellPainting);
            this.DataGridpacksize.SelectionChanged += new System.EventHandler(this.DataGridpacksize_SelectionChanged);
            this.DataGridpacksize.Paint += new System.Windows.Forms.PaintEventHandler(this.frmtraysizelist_Paint);
            // 
            // sizeorder
            // 
            this.sizeorder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sizeorder.DataPropertyName = "sizeorder";
            this.sizeorder.HeaderText = "Order";
            this.sizeorder.Name = "sizeorder";
            this.sizeorder.ReadOnly = true;
            this.sizeorder.ToolTipText = "Which order to display these";
            this.sizeorder.Width = 72;
            // 
            // clnpacksizeid
            // 
            this.clnpacksizeid.DataPropertyName = "packsizeid";
            this.clnpacksizeid.HeaderText = "packsizeid";
            this.clnpacksizeid.Name = "clnpacksizeid";
            this.clnpacksizeid.ReadOnly = true;
            this.clnpacksizeid.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sizename";
            this.dataGridViewTextBoxColumn2.HeaderText = "Code";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 4;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.ToolTipText = "Common code for referring to size";
            this.dataGridViewTextBoxColumn2.Width = 69;
            // 
            // sizelongname
            // 
            this.sizelongname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sizelongname.DataPropertyName = "sizelongname";
            this.sizelongname.HeaderText = "Name";
            this.sizelongname.MaxInputLength = 20;
            this.sizelongname.Name = "sizelongname";
            this.sizelongname.ReadOnly = true;
            this.sizelongname.Width = 74;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sizecomment";
            this.dataGridViewTextBoxColumn3.HeaderText = "Details";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 40;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.ToolTipText = "Spefic info (eg. 12mm pack)";
            // 
            // clnhide
            // 
            this.clnhide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnhide.DataPropertyName = "hide";
            this.clnhide.HeaderText = "Hide";
            this.clnhide.Name = "clnhide";
            this.clnhide.ReadOnly = true;
            this.clnhide.Width = 46;
            // 
            // clndelete
            // 
            this.clndelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clndelete.HeaderText = "Delete";
            this.clndelete.Name = "clndelete";
            this.clndelete.ReadOnly = true;
            this.clndelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clndelete.Visible = false;
            this.clndelete.Width = 59;
            // 
            // clnedit
            // 
            this.clnedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnedit.HeaderText = "Edit";
            this.clnedit.Name = "clnedit";
            this.clnedit.ReadOnly = true;
            this.clnedit.Width = 41;
            // 
            // frmtraysizelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 350);
            this.Controls.Add(this.DataGridpacksize);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.btnSaveandClose);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtraysizelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tray Sizes";
            this.Load += new System.EventHandler(this.frmtraysizelist_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmtraysizelist_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridpacksize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private webbitdbdataset webbitdbdataset;
        private System.Windows.Forms.BindingSource tblpacksizeBindingSource;
        private webbitdbdatasetTableAdapters.tblpacksizeTableAdapter tblpacksizeTableAdapter;
        private webbitdbdatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddnew;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaveandClose;
        private System.Windows.Forms.DataGridView DataGridpacksize;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpacksizeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizelongname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnhide;
        private System.Windows.Forms.DataGridViewButtonColumn clndelete;
        private System.Windows.Forms.DataGridViewButtonColumn clnedit;
    }
}