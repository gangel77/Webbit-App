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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.websterdbDataSet = new PackChecker.websterdbDataSet();
            this.tblpacksizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpacksizeTableAdapter = new PackChecker.websterdbDataSetTableAdapters.tblpacksizeTableAdapter();
            this.tableAdapterManager = new PackChecker.websterdbDataSetTableAdapters.TableAdapterManager();
            this.DataGridpacksize = new System.Windows.Forms.DataGridView();
            this.sizeorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpacksizeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizelongname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clndelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.btnunlock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridpacksize)).BeginInit();
            this.SuspendLayout();
            // 
            // websterdbDataSet
            // 
            this.websterdbDataSet.DataSetName = "websterdbDataSet";
            this.websterdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblpacksizeBindingSource
            // 
            this.tblpacksizeBindingSource.DataMember = "tblpacksize";
            this.tblpacksizeBindingSource.DataSource = this.websterdbDataSet;
            // 
            // tblpacksizeTableAdapter
            // 
            this.tblpacksizeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblcycleTableAdapter = null;
            this.tableAdapterManager.tbldateTableAdapter = null;
            this.tableAdapterManager.tbljobTableAdapter = null;
            this.tableAdapterManager.tblpacklocationTableAdapter = null;
            this.tableAdapterManager.tblpacksizeTableAdapter = this.tblpacksizeTableAdapter;
            this.tableAdapterManager.tblpackTableAdapter = null;
            this.tableAdapterManager.tblpatientTableAdapter = null;
            this.tableAdapterManager.tblsettingsTableAdapter = null;
            this.tableAdapterManager.tbluserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PackChecker.websterdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DataGridpacksize
            // 
            this.DataGridpacksize.AllowUserToAddRows = false;
            this.DataGridpacksize.AllowUserToDeleteRows = false;
            this.DataGridpacksize.AllowUserToResizeColumns = false;
            this.DataGridpacksize.AllowUserToResizeRows = false;
            this.DataGridpacksize.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridpacksize.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridpacksize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridpacksize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sizeorder,
            this.clnpacksizeid,
            this.dataGridViewTextBoxColumn2,
            this.sizelongname,
            this.dataGridViewTextBoxColumn3,
            this.clndelete});
            this.DataGridpacksize.DataSource = this.tblpacksizeBindingSource;
            this.DataGridpacksize.Enabled = false;
            this.DataGridpacksize.Location = new System.Drawing.Point(27, 47);
            this.DataGridpacksize.Name = "DataGridpacksize";
            this.DataGridpacksize.RowHeadersVisible = false;
            this.DataGridpacksize.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridpacksize.Size = new System.Drawing.Size(388, 220);
            this.DataGridpacksize.TabIndex = 1;
            this.DataGridpacksize.TabStop = false;
            this.DataGridpacksize.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridpacksize_CellContentClick);
            // 
            // sizeorder
            // 
            this.sizeorder.DataPropertyName = "sizeorder";
            this.sizeorder.HeaderText = "Order";
            this.sizeorder.Name = "sizeorder";
            this.sizeorder.ToolTipText = "Which order to display these";
            this.sizeorder.Width = 40;
            // 
            // clnpacksizeid
            // 
            this.clnpacksizeid.DataPropertyName = "packsizeid";
            this.clnpacksizeid.HeaderText = "packsizeid";
            this.clnpacksizeid.Name = "clnpacksizeid";
            this.clnpacksizeid.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sizename";
            this.dataGridViewTextBoxColumn2.HeaderText = "Code";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 4;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ToolTipText = "Common code for referring to size";
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // sizelongname
            // 
            this.sizelongname.DataPropertyName = "sizelongname";
            this.sizelongname.HeaderText = "Name";
            this.sizelongname.MaxInputLength = 20;
            this.sizelongname.Name = "sizelongname";
            this.sizelongname.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sizecomment";
            this.dataGridViewTextBoxColumn3.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 40;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ToolTipText = "Spefic info (eg. 12mm pack)";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // clndelete
            // 
            this.clndelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clndelete.HeaderText = "Delete";
            this.clndelete.Name = "clndelete";
            this.clndelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clndelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clndelete.Width = 63;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(94, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 24);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Tray Size List";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(111, 302);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(209, 46);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnaddnew
            // 
            this.btnaddnew.Location = new System.Drawing.Point(177, 273);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(75, 23);
            this.btnaddnew.TabIndex = 5;
            this.btnaddnew.Text = "Add New";
            this.btnaddnew.UseVisualStyleBackColor = true;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // btnunlock
            // 
            this.btnunlock.Location = new System.Drawing.Point(321, 18);
            this.btnunlock.Name = "btnunlock";
            this.btnunlock.Size = new System.Drawing.Size(94, 23);
            this.btnunlock.TabIndex = 6;
            this.btnunlock.Text = "Unlock to Edit";
            this.btnunlock.UseVisualStyleBackColor = true;
            this.btnunlock.Click += new System.EventHandler(this.btnunlock_Click);
            // 
            // frmtraysizelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 368);
            this.Controls.Add(this.btnunlock);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.DataGridpacksize);
            this.Name = "frmtraysizelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tray Sizes";
            this.Load += new System.EventHandler(this.frmtraysizelist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridpacksize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private websterdbDataSet websterdbDataSet;
        private System.Windows.Forms.BindingSource tblpacksizeBindingSource;
        private websterdbDataSetTableAdapters.tblpacksizeTableAdapter tblpacksizeTableAdapter;
        private websterdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView DataGridpacksize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpacksizeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizelongname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn clndelete;
        private System.Windows.Forms.Button btnunlock;
    }
}