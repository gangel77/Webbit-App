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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridcycles = new System.Windows.Forms.DataGridView();
            this.clncyclecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncycleweeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncyclepacks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncycledescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncycleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncyclehide = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnedit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblcycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.websterdbDataSet = new PackChecker.websterdbDataSet();
            this.tblcycleTableAdapter = new PackChecker.websterdbDataSetTableAdapters.tblcycleTableAdapter();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridcycles
            // 
            this.dataGridcycles.AllowUserToAddRows = false;
            this.dataGridcycles.AllowUserToDeleteRows = false;
            this.dataGridcycles.AllowUserToResizeColumns = false;
            this.dataGridcycles.AllowUserToResizeRows = false;
            this.dataGridcycles.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridcycles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridcycles.Location = new System.Drawing.Point(23, 68);
            this.dataGridcycles.MultiSelect = false;
            this.dataGridcycles.Name = "dataGridcycles";
            this.dataGridcycles.ReadOnly = true;
            this.dataGridcycles.RowHeadersVisible = false;
            this.dataGridcycles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridcycles.RowTemplate.Height = 25;
            this.dataGridcycles.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridcycles.Size = new System.Drawing.Size(830, 173);
            this.dataGridcycles.TabIndex = 0;
            this.dataGridcycles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCycles_CellContentClick);
            this.dataGridcycles.SelectionChanged += new System.EventHandler(this.dataGridcycles_SelectionChanged);
            // 
            // clncyclecode
            // 
            this.clncyclecode.DataPropertyName = "cyclecode";
            this.clncyclecode.HeaderText = "Cycle Code";
            this.clncyclecode.Name = "clncyclecode";
            this.clncyclecode.ReadOnly = true;
            this.clncyclecode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncyclecode.Width = 125;
            // 
            // clncycleweeks
            // 
            this.clncycleweeks.DataPropertyName = "cycleweeks";
            this.clncycleweeks.HeaderText = "Weeks to Pack";
            this.clncycleweeks.Name = "clncycleweeks";
            this.clncycleweeks.ReadOnly = true;
            this.clncycleweeks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncycleweeks.ToolTipText = "How many weeks will the packs last the patient?";
            // 
            // clncyclepacks
            // 
            this.clncyclepacks.DataPropertyName = "cyclepacks";
            this.clncyclepacks.HeaderText = "Packs in Cycle";
            this.clncyclepacks.Name = "clncyclepacks";
            this.clncyclepacks.ReadOnly = true;
            this.clncyclepacks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncyclepacks.ToolTipText = "How many literal packs of Websters are made?";
            // 
            // clncycledescription
            // 
            this.clncycledescription.DataPropertyName = "cycledescription";
            this.clncycledescription.HeaderText = "Description";
            this.clncycledescription.Name = "clncycledescription";
            this.clncycledescription.ReadOnly = true;
            this.clncycledescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncycledescription.Width = 400;
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
            // tblcycleBindingSource
            // 
            this.tblcycleBindingSource.DataMember = "tblcycle";
            this.tblcycleBindingSource.DataSource = this.websterdbDataSet;
            // 
            // websterdbDataSet
            // 
            this.websterdbDataSet.DataSetName = "websterdbDataSet";
            this.websterdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcycleTableAdapter
            // 
            this.tblcycleTableAdapter.ClearBeforeFill = true;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(339, 274);
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
            this.lblTitle.Location = new System.Drawing.Point(354, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(173, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "List of Cycle Types:";
            // 
            // frmcyclelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 340);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dataGridcycles);
            this.Name = "frmcyclelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcyclelist";
            this.Load += new System.EventHandler(this.frmcyclelist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridcycles;
        private websterdbDataSet websterdbDataSet;
        private System.Windows.Forms.BindingSource tblcycleBindingSource;
        private websterdbDataSetTableAdapters.tblcycleTableAdapter tblcycleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncyclecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncycleweeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncyclepacks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncycledescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncycleid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clncyclehide;
        private System.Windows.Forms.DataGridViewButtonColumn clnedit;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblTitle;
    }
}