namespace PackChecker
{
    partial class frmjoblist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmjoblist));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.webbitdbdataset = new PackChecker.webbitdbdataset();
            this.tbljobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbljobTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tbljobTableAdapter();
            this.tableAdapterManager = new PackChecker.webbitdbdatasetTableAdapters.TableAdapterManager();
            this.DataGridjob = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.clnjobid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbljobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridjob)).BeginInit();
            this.SuspendLayout();
            // 
            // webbitdbdataset
            // 
            this.webbitdbdataset.DataSetName = "webbitdbdataset";
            this.webbitdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbljobBindingSource
            // 
            this.tbljobBindingSource.DataMember = "tbljob";
            this.tbljobBindingSource.DataSource = this.webbitdbdataset;
            // 
            // tbljobTableAdapter
            // 
            this.tbljobTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblcycleTableAdapter = null;
            this.tableAdapterManager.tbldateTableAdapter = null;
            this.tableAdapterManager.tblinstitutionTableAdapter = null;
            this.tableAdapterManager.tbljobTableAdapter = this.tbljobTableAdapter;
            this.tableAdapterManager.tblpacklocationTableAdapter = null;
            this.tableAdapterManager.tblpacksizeTableAdapter = null;
            this.tableAdapterManager.tblpackTableAdapter = null;
            this.tableAdapterManager.tblpatientTableAdapter = null;
            this.tableAdapterManager.tblsettingsTableAdapter = null;
            this.tableAdapterManager.tbluserTableAdapter = null;
            this.tableAdapterManager.tblweekTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PackChecker.webbitdbdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DataGridjob
            // 
            this.DataGridjob.AllowUserToAddRows = false;
            this.DataGridjob.AllowUserToDeleteRows = false;
            this.DataGridjob.AllowUserToResizeColumns = false;
            this.DataGridjob.AllowUserToResizeRows = false;
            this.DataGridjob.AutoGenerateColumns = false;
            this.DataGridjob.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myriad Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridjob.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridjob.ColumnHeadersHeight = 40;
            this.DataGridjob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridjob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnjobid,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn5});
            this.DataGridjob.DataSource = this.tbljobBindingSource;
            this.DataGridjob.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.DataGridjob.Location = new System.Drawing.Point(27, 74);
            this.DataGridjob.MultiSelect = false;
            this.DataGridjob.Name = "DataGridjob";
            this.DataGridjob.RowHeadersVisible = false;
            this.DataGridjob.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridjob.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridjob.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridjob.Size = new System.Drawing.Size(401, 130);
            this.DataGridjob.TabIndex = 1;
            this.DataGridjob.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridjob_CellContentClick);
            this.DataGridjob.SelectionChanged += new System.EventHandler(this.DataGridjob_SelectionChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblTitle.Location = new System.Drawing.Point(82, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 45);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "List of Positions";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnclose.ButtonText = "Cancel";
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnclose.IdleBorderThickness = 1;
            this.btnclose.IdleCornerRadius = 10;
            this.btnclose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclose.IdleForecolor = System.Drawing.Color.White;
            this.btnclose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclose.Location = new System.Drawing.Point(264, 221);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 54);
            this.btnclose.TabIndex = 22;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.ActiveBorderThickness = 1;
            this.BtnSave.ActiveCornerRadius = 10;
            this.BtnSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.BtnSave.ActiveForecolor = System.Drawing.Color.White;
            this.BtnSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.ButtonText = "Save and Close";
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.IdleBorderThickness = 1;
            this.BtnSave.IdleCornerRadius = 10;
            this.BtnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.BtnSave.IdleForecolor = System.Drawing.Color.White;
            this.BtnSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.BtnSave.Location = new System.Drawing.Point(90, 221);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(149, 54);
            this.BtnSave.TabIndex = 23;
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // clnjobid
            // 
            this.clnjobid.DataPropertyName = "jobid";
            this.clnjobid.HeaderText = "jobid";
            this.clnjobid.Name = "clnjobid";
            this.clnjobid.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "jobname";
            this.dataGridViewTextBoxColumn2.FillWeight = 55F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Position";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "canpack";
            this.dataGridViewCheckBoxColumn1.FillWeight = 15F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Pack";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "cancheck";
            this.dataGridViewCheckBoxColumn3.FillWeight = 15F;
            this.dataGridViewCheckBoxColumn3.HeaderText = "Check";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "cancollect";
            this.dataGridViewCheckBoxColumn2.FillWeight = 15F;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Collect";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "webadmin";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCheckBoxColumn4.FillWeight = 15F;
            this.dataGridViewCheckBoxColumn4.HeaderText = "Packing Admin";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "admin";
            this.dataGridViewCheckBoxColumn5.FillWeight = 15F;
            this.dataGridViewCheckBoxColumn5.HeaderText = "Admin";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            // 
            // frmjoblist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 296);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.DataGridjob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmjoblist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Positions";
            this.Load += new System.EventHandler(this.frmjoblist_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmjoblist_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbljobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridjob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private webbitdbdataset webbitdbdataset;
        private System.Windows.Forms.BindingSource tbljobBindingSource;
        private webbitdbdatasetTableAdapters.tbljobTableAdapter tbljobTableAdapter;
        private webbitdbdatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView DataGridjob;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnjobid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
    }
}