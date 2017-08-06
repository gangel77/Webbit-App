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
            this.dataGridlocation = new System.Windows.Forms.DataGridView();
            this.tblpacklocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.websterdbDataSet = new PackChecker.websterdbDataSet();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tblpacklocationTableAdapter = new PackChecker.websterdbDataSetTableAdapters.tblpacklocationTableAdapter();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.clnlocationid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnlocationname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnwarning = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clncyclehide = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnedit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridlocation
            // 
            this.dataGridlocation.AllowUserToAddRows = false;
            this.dataGridlocation.AllowUserToDeleteRows = false;
            this.dataGridlocation.AllowUserToResizeColumns = false;
            this.dataGridlocation.AllowUserToResizeRows = false;
            this.dataGridlocation.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridlocation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridlocation.Location = new System.Drawing.Point(24, 63);
            this.dataGridlocation.MultiSelect = false;
            this.dataGridlocation.Name = "dataGridlocation";
            this.dataGridlocation.ReadOnly = true;
            this.dataGridlocation.RowHeadersVisible = false;
            this.dataGridlocation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridlocation.RowTemplate.Height = 25;
            this.dataGridlocation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridlocation.Size = new System.Drawing.Size(374, 179);
            this.dataGridlocation.TabIndex = 0;
            this.dataGridlocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLocation_CellContentClick);
            this.dataGridlocation.SelectionChanged += new System.EventHandler(this.dataGridloction_SelectionChanged);
            // 
            // tblpacklocationBindingSource
            // 
            this.tblpacklocationBindingSource.DataMember = "tblpacklocation";
            this.tblpacklocationBindingSource.DataSource = this.websterdbDataSet;
            // 
            // websterdbDataSet
            // 
            this.websterdbDataSet.DataSetName = "websterdbDataSet";
            this.websterdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(96, 302);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(209, 46);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(57, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "List of Webster Storage Locations";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblpacklocationTableAdapter
            // 
            this.tblpacklocationTableAdapter.ClearBeforeFill = true;
            // 
            // btnaddnew
            // 
            this.btnaddnew.Location = new System.Drawing.Point(165, 262);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(75, 23);
            this.btnaddnew.TabIndex = 3;
            this.btnaddnew.Text = "Add New";
            this.btnaddnew.UseVisualStyleBackColor = true;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
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
            this.clnlocationname.DataPropertyName = "locationname";
            this.clnlocationname.HeaderText = "Location";
            this.clnlocationname.Name = "clnlocationname";
            this.clnlocationname.ReadOnly = true;
            this.clnlocationname.Width = 150;
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
            this.clncyclehide.Width = 57;
            // 
            // clnedit
            // 
            this.clnedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnedit.HeaderText = "Edit";
            this.clnedit.Name = "clnedit";
            this.clnedit.ReadOnly = true;
            this.clnedit.Width = 43;
            // 
            // frmlocationlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 376);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dataGridlocation);
            this.Name = "frmlocationlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locations";
            this.Load += new System.EventHandler(this.frmlocationlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridlocation;
        private websterdbDataSet websterdbDataSet;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource tblpacklocationBindingSource;
        private websterdbDataSetTableAdapters.tblpacklocationTableAdapter tblpacklocationTableAdapter;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnlocationid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnlocationname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnwarning;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clncyclehide;
        private System.Windows.Forms.DataGridViewButtonColumn clnedit;
    }
}