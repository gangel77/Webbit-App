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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridlocation = new System.Windows.Forms.DataGridView();
            this.clnuserid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnfirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnlastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnjob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnedit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.usersjobsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.websterdbDataSet1 = new PackChecker.websterdbDataSet();
            this.usersjobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnclose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.users_jobsTableAdapter = new PackChecker.websterdbDataSetTableAdapters.users_jobsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersjobsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersjobsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridlocation
            // 
            this.dataGridlocation.AllowUserToAddRows = false;
            this.dataGridlocation.AllowUserToDeleteRows = false;
            this.dataGridlocation.AllowUserToOrderColumns = true;
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
            this.clnuserid,
            this.clnfirstname,
            this.clnlastname,
            this.clnlogin,
            this.clnjob,
            this.clnedit});
            this.dataGridlocation.DataSource = this.usersjobsBindingSource1;
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
            this.dataGridlocation.Size = new System.Drawing.Size(622, 367);
            this.dataGridlocation.TabIndex = 0;
            this.dataGridlocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLocation_CellContentClick);
            this.dataGridlocation.SelectionChanged += new System.EventHandler(this.dataGridloction_SelectionChanged);
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
            // clnfirstname
            // 
            this.clnfirstname.DataPropertyName = "userfirstname";
            this.clnfirstname.HeaderText = "Firstname";
            this.clnfirstname.Name = "clnfirstname";
            this.clnfirstname.ReadOnly = true;
            this.clnfirstname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnfirstname.Width = 150;
            // 
            // clnlastname
            // 
            this.clnlastname.DataPropertyName = "userlastname";
            this.clnlastname.HeaderText = "Lastname";
            this.clnlastname.Name = "clnlastname";
            this.clnlastname.ReadOnly = true;
            this.clnlastname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnlastname.Width = 150;
            // 
            // clnlogin
            // 
            this.clnlogin.DataPropertyName = "userlogin";
            this.clnlogin.HeaderText = "Login";
            this.clnlogin.Name = "clnlogin";
            this.clnlogin.ReadOnly = true;
            this.clnlogin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnlogin.Width = 50;
            // 
            // clnjob
            // 
            this.clnjob.DataPropertyName = "jobname";
            this.clnjob.HeaderText = "Postion";
            this.clnjob.Name = "clnjob";
            this.clnjob.ReadOnly = true;
            this.clnjob.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnjob.Width = 200;
            // 
            // clnedit
            // 
            this.clnedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnedit.HeaderText = "Edit";
            this.clnedit.Name = "clnedit";
            this.clnedit.ReadOnly = true;
            this.clnedit.Width = 43;
            // 
            // usersjobsBindingSource1
            // 
            this.usersjobsBindingSource1.DataMember = "users_jobs";
            this.usersjobsBindingSource1.DataSource = this.websterdbDataSet1;
            // 
            // websterdbDataSet1
            // 
            this.websterdbDataSet1.DataSetName = "websterdbDataSet1";
            this.websterdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(228, 477);
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
            this.lblTitle.Location = new System.Drawing.Point(150, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "User List";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnaddnew
            // 
            this.btnaddnew.Location = new System.Drawing.Point(297, 437);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(75, 23);
            this.btnaddnew.TabIndex = 3;
            this.btnaddnew.Text = "Add New";
            this.btnaddnew.UseVisualStyleBackColor = true;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // users_jobsTableAdapter
            // 
            this.users_jobsTableAdapter.ClearBeforeFill = true;
            // 
            // frmuserlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 558);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dataGridlocation);
            this.Name = "frmuserlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locations";
            this.Load += new System.EventHandler(this.frmlocationlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersjobsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersjobsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridlocation;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnaddnew;
        private websterdbDataSet websterdbDataSet1;
        private System.Windows.Forms.BindingSource usersjobsBindingSource;
        private websterdbDataSetTableAdapters.users_jobsTableAdapter users_jobsTableAdapter;
        private System.Windows.Forms.BindingSource usersjobsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnuserid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnfirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnlastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnlogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnjob;
        private System.Windows.Forms.DataGridViewButtonColumn clnedit;
    }
}