namespace PackChecker
{
    partial class frmcyclelist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcyclelist));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridcycles = new System.Windows.Forms.DataGridView();
            this.tblcycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webbitdbdataset = new PackChecker.webbitdbdataset();
            this.tblcycleTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblcycleTableAdapter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clncyclecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncycleweeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncyclepacks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncycledescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncycleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncyclehide = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnedit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridcycles
            // 
            this.dataGridcycles.AllowUserToAddRows = false;
            this.dataGridcycles.AllowUserToDeleteRows = false;
            this.dataGridcycles.AllowUserToResizeColumns = false;
            this.dataGridcycles.AllowUserToResizeRows = false;
            this.dataGridcycles.AutoGenerateColumns = false;
            this.dataGridcycles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridcycles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridcycles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridcycles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridcycles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clncyclecode,
            this.clncycleweeks,
            this.clncyclepacks,
            this.clncycledescription,
            this.clncycleid,
            this.clncyclehide,
            this.clnedit});
            this.dataGridcycles.DataSource = this.tblcycleBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridcycles.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridcycles.EnableHeadersVisualStyles = false;
            this.dataGridcycles.Location = new System.Drawing.Point(21, 68);
            this.dataGridcycles.MultiSelect = false;
            this.dataGridcycles.Name = "dataGridcycles";
            this.dataGridcycles.ReadOnly = true;
            this.dataGridcycles.RowHeadersVisible = false;
            this.dataGridcycles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridcycles.RowTemplate.Height = 25;
            this.dataGridcycles.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridcycles.Size = new System.Drawing.Size(822, 178);
            this.dataGridcycles.TabIndex = 0;
            this.dataGridcycles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCycles_CellContentClick);
            this.dataGridcycles.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridcycles_CellPainting);
            this.dataGridcycles.SelectionChanged += new System.EventHandler(this.dataGridcycles_SelectionChanged);
            // 
            // tblcycleBindingSource
            // 
            this.tblcycleBindingSource.DataMember = "tblcycle";
            this.tblcycleBindingSource.DataSource = this.webbitdbdataset;
            // 
            // webbitdbdataset
            // 
            this.webbitdbdataset.DataSetName = "webbitdbdataset";
            this.webbitdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcycleTableAdapter
            // 
            this.tblcycleTableAdapter.ClearBeforeFill = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblTitle.Location = new System.Drawing.Point(142, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(586, 46);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "List of Cycles:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 10;
            this.btnClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "Save and Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 10;
            this.btnClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnClose.IdleForecolor = System.Drawing.Color.White;
            this.btnClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnClose.Location = new System.Drawing.Point(354, 262);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(163, 41);
            this.btnClose.TabIndex = 22;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 195);
            this.panel1.TabIndex = 23;
            // 
            // clncyclecode
            // 
            this.clncyclecode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clncyclecode.DataPropertyName = "cyclecode";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clncyclecode.DefaultCellStyle = dataGridViewCellStyle2;
            this.clncyclecode.HeaderText = "Cycle Name";
            this.clncyclecode.Name = "clncyclecode";
            this.clncyclecode.ReadOnly = true;
            this.clncyclecode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncyclecode.Width = 94;
            // 
            // clncycleweeks
            // 
            this.clncycleweeks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clncycleweeks.DataPropertyName = "cycleweeks";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clncycleweeks.DefaultCellStyle = dataGridViewCellStyle3;
            this.clncycleweeks.HeaderText = "Weeks to Pack";
            this.clncycleweeks.Name = "clncycleweeks";
            this.clncycleweeks.ReadOnly = true;
            this.clncycleweeks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncycleweeks.ToolTipText = "How many weeks will the packs last the patient?";
            this.clncycleweeks.Visible = false;
            this.clncycleweeks.Width = 110;
            // 
            // clncyclepacks
            // 
            this.clncyclepacks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clncyclepacks.DataPropertyName = "cyclepacks";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clncyclepacks.DefaultCellStyle = dataGridViewCellStyle4;
            this.clncyclepacks.HeaderText = "Packs in Cycle";
            this.clncyclepacks.Name = "clncyclepacks";
            this.clncyclepacks.ReadOnly = true;
            this.clncyclepacks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncyclepacks.ToolTipText = "How many literal packs of Websters are made?";
            this.clncyclepacks.Visible = false;
            this.clncyclepacks.Width = 108;
            // 
            // clncycledescription
            // 
            this.clncycledescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clncycledescription.DataPropertyName = "cycledescription";
            this.clncycledescription.HeaderText = "Description";
            this.clncycledescription.Name = "clncycledescription";
            this.clncycledescription.ReadOnly = true;
            this.clncycledescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clncycleid
            // 
            this.clncycleid.DataPropertyName = "cycleid";
            this.clncycleid.HeaderText = "cycleid";
            this.clncycleid.Name = "clncycleid";
            this.clncycleid.ReadOnly = true;
            this.clncycleid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncycleid.Visible = false;
            this.clncycleid.Width = 81;
            // 
            // clncyclehide
            // 
            this.clncyclehide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clncyclehide.DataPropertyName = "cyclehide";
            this.clncyclehide.HeaderText = "Hide";
            this.clncyclehide.Name = "clncyclehide";
            this.clncyclehide.ReadOnly = true;
            this.clncyclehide.Width = 46;
            // 
            // clnedit
            // 
            this.clnedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnedit.HeaderText = "Edit";
            this.clnedit.Name = "clnedit";
            this.clnedit.ReadOnly = true;
            this.clnedit.Width = 41;
            // 
            // frmcyclelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 313);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridcycles);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcyclelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcyclelist";
            this.Load += new System.EventHandler(this.frmcyclelist_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmcyclelist_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridcycles;
        private webbitdbdataset webbitdbdataset;
        private System.Windows.Forms.BindingSource tblcycleBindingSource;
        private webbitdbdatasetTableAdapters.tblcycleTableAdapter tblcycleTableAdapter;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncyclecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncycleweeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncyclepacks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncycledescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncycleid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clncyclehide;
        private System.Windows.Forms.DataGridViewButtonColumn clnedit;
    }
}