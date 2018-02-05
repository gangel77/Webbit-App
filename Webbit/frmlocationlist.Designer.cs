namespace PackChecker
{
    partial class frmlocationlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlocationlist));
            this.dataGridlocation = new System.Windows.Forms.DataGridView();
            this.clnlocationid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnlocationname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnwarning = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clncyclehide = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnedit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblpacklocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webbitdbdataset = new PackChecker.webbitdbdataset();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tblpacklocationTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblpacklocationTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnaddnew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridlocation
            // 
            this.dataGridlocation.AllowUserToAddRows = false;
            this.dataGridlocation.AllowUserToDeleteRows = false;
            this.dataGridlocation.AllowUserToResizeColumns = false;
            this.dataGridlocation.AllowUserToResizeRows = false;
            this.dataGridlocation.AutoGenerateColumns = false;
            this.dataGridlocation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridlocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridlocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridlocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnlocationid,
            this.clnlocationname,
            this.clnwarning,
            this.clncyclehide,
            this.clnedit});
            this.dataGridlocation.DataSource = this.tblpacklocationBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridlocation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridlocation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.dataGridlocation.Location = new System.Drawing.Point(14, 14);
            this.dataGridlocation.MultiSelect = false;
            this.dataGridlocation.Name = "dataGridlocation";
            this.dataGridlocation.ReadOnly = true;
            this.dataGridlocation.RowHeadersVisible = false;
            this.dataGridlocation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridlocation.RowTemplate.Height = 25;
            this.dataGridlocation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridlocation.Size = new System.Drawing.Size(347, 180);
            this.dataGridlocation.TabIndex = 0;
            this.dataGridlocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLocation_CellContentClick);
            this.dataGridlocation.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridlocation_CellPainting);
            this.dataGridlocation.SelectionChanged += new System.EventHandler(this.dataGridloction_SelectionChanged);
            // 
            // clnlocationid
            // 
            this.clnlocationid.DataPropertyName = "locationid";
            this.clnlocationid.HeaderText = "locationid";
            this.clnlocationid.Name = "clnlocationid";
            this.clnlocationid.ReadOnly = true;
            this.clnlocationid.Visible = false;
            // 
            // clnlocationname
            // 
            this.clnlocationname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnlocationname.DataPropertyName = "locationname";
            this.clnlocationname.HeaderText = "Location";
            this.clnlocationname.Name = "clnlocationname";
            this.clnlocationname.ReadOnly = true;
            // 
            // clnwarning
            // 
            this.clnwarning.DataPropertyName = "warning";
            this.clnwarning.HeaderText = "Warning?";
            this.clnwarning.Name = "clnwarning";
            this.clnwarning.ReadOnly = true;
            this.clnwarning.ToolTipText = "Do you want a warning for collections?";
            // 
            // clncyclehide
            // 
            this.clncyclehide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clncyclehide.DataPropertyName = "hidelocation";
            this.clncyclehide.HeaderText = "Hide?";
            this.clncyclehide.Name = "clncyclehide";
            this.clncyclehide.ReadOnly = true;
            this.clncyclehide.Width = 52;
            // 
            // clnedit
            // 
            this.clnedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnedit.HeaderText = "Edit";
            this.clnedit.Name = "clnedit";
            this.clnedit.ReadOnly = true;
            this.clnedit.Width = 41;
            // 
            // tblpacklocationBindingSource
            // 
            this.tblpacklocationBindingSource.DataMember = "tblpacklocation";
            this.tblpacklocationBindingSource.DataSource = this.webbitdbdataset;
            // 
            // webbitdbdataset
            // 
            this.webbitdbdataset.DataSetName = "webbitdbdataset";
            this.webbitdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblTitle.Location = new System.Drawing.Point(51, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 48);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Location List";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblpacklocationTableAdapter
            // 
            this.tblpacklocationTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridlocation);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 210);
            this.panel1.TabIndex = 4;
            // 
            // btnaddnew
            // 
            this.btnaddnew.ActiveBorderThickness = 1;
            this.btnaddnew.ActiveCornerRadius = 10;
            this.btnaddnew.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnaddnew.ActiveForecolor = System.Drawing.Color.White;
            this.btnaddnew.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnaddnew.AutoSize = true;
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
            this.btnaddnew.Location = new System.Drawing.Point(46, 284);
            this.btnaddnew.Margin = new System.Windows.Forms.Padding(5);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(151, 43);
            this.btnaddnew.TabIndex = 25;
            this.btnaddnew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // btnclose
            // 
            this.btnclose.ActiveBorderThickness = 1;
            this.btnclose.ActiveCornerRadius = 10;
            this.btnclose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclose.ActiveForecolor = System.Drawing.Color.White;
            this.btnclose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclose.AutoSize = true;
            this.btnclose.BackColor = System.Drawing.Color.White;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.ButtonText = "Save and Close";
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnclose.IdleBorderThickness = 1;
            this.btnclose.IdleCornerRadius = 10;
            this.btnclose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclose.IdleForecolor = System.Drawing.Color.White;
            this.btnclose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclose.Location = new System.Drawing.Point(207, 284);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(151, 43);
            this.btnclose.TabIndex = 24;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // frmlocationlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 336);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlocationlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locations";
            this.Load += new System.EventHandler(this.frmlocationlist_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmlocationlist_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridlocation;
        private webbitdbdataset webbitdbdataset;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource tblpacklocationBindingSource;
        private webbitdbdatasetTableAdapters.tblpacklocationTableAdapter tblpacklocationTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnaddnew;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnlocationid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnlocationname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnwarning;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clncyclehide;
        private System.Windows.Forms.DataGridViewButtonColumn clnedit;
    }
}