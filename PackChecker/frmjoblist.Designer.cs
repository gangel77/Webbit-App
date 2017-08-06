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
            this.websterdbDataSet = new PackChecker.websterdbDataSet();
            this.tbljobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbljobTableAdapter = new PackChecker.websterdbDataSetTableAdapters.tbljobTableAdapter();
            this.tableAdapterManager = new PackChecker.websterdbDataSetTableAdapters.TableAdapterManager();
            this.DataGridjob = new System.Windows.Forms.DataGridView();
            this.clnjobid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbljobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridjob)).BeginInit();
            this.SuspendLayout();
            // 
            // websterdbDataSet
            // 
            this.websterdbDataSet.DataSetName = "websterdbDataSet";
            this.websterdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbljobBindingSource
            // 
            this.tbljobBindingSource.DataMember = "tbljob";
            this.tbljobBindingSource.DataSource = this.websterdbDataSet;
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
            this.tableAdapterManager.tbljobTableAdapter = this.tbljobTableAdapter;
            this.tableAdapterManager.tblpacklocationTableAdapter = null;
            this.tableAdapterManager.tblpacksizeTableAdapter = null;
            this.tableAdapterManager.tblpackTableAdapter = null;
            this.tableAdapterManager.tblpatientTableAdapter = null;
            this.tableAdapterManager.tblsettingsTableAdapter = null;
            this.tableAdapterManager.tbluserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PackChecker.websterdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DataGridjob
            // 
            this.DataGridjob.AllowUserToAddRows = false;
            this.DataGridjob.AllowUserToDeleteRows = false;
            this.DataGridjob.AllowUserToResizeColumns = false;
            this.DataGridjob.AllowUserToResizeRows = false;
            this.DataGridjob.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
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
            // clnjobid
            // 
            this.clnjobid.DataPropertyName = "jobid";
            this.clnjobid.HeaderText = "jobid";
            this.clnjobid.Name = "clnjobid";
            this.clnjobid.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "jobname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Position";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "canpack";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Pack";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "cancheck";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Check";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Width = 50;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "cancollect";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Give Out";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 50;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "canrequestrepack";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Order Changes";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Width = 50;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "admin";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Admin";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.Width = 50;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(82, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 24);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "List of Positions";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(247, 229);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(114, 46);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Cancel";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save and Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmjoblist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.DataGridjob);
            this.Name = "frmjoblist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Positions";
            this.Load += new System.EventHandler(this.frmjoblist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbljobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridjob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private websterdbDataSet websterdbDataSet;
        private System.Windows.Forms.BindingSource tbljobBindingSource;
        private websterdbDataSetTableAdapters.tbljobTableAdapter tbljobTableAdapter;
        private websterdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView DataGridjob;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnjobid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
    }
}