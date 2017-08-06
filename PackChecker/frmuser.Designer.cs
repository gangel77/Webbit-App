namespace PackChecker
{
    partial class frmuser
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
            System.Windows.Forms.Label userfirstnameLabel;
            System.Windows.Forms.Label userlastnameLabel;
            System.Windows.Forms.Label userloginLabel;
            System.Windows.Forms.Label userpassLabel;
            System.Windows.Forms.Label userjobidLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.websterdbDataSet = new PackChecker.websterdbDataSet();
            this.tableAdapterManager = new PackChecker.websterdbDataSetTableAdapters.TableAdapterManager();
            this.tbluserTableAdapter = new PackChecker.websterdbDataSetTableAdapters.tbluserTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.cmbjob = new System.Windows.Forms.ComboBox();
            this.tbluserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbljobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.useridTextBox = new System.Windows.Forms.TextBox();
            this.userfirstnameTextBox = new System.Windows.Forms.TextBox();
            this.userlastnameTextBox = new System.Windows.Forms.TextBox();
            this.userloginTextBox = new System.Windows.Forms.TextBox();
            this.userpassTextBox = new System.Windows.Forms.TextBox();
            this.tbljobTableAdapter = new PackChecker.websterdbDataSetTableAdapters.tbljobTableAdapter();
            this.dataGridjob = new System.Windows.Forms.DataGridView();
            this.canpackDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cancollectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cancheckDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canrequestrepackDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            userfirstnameLabel = new System.Windows.Forms.Label();
            userlastnameLabel = new System.Windows.Forms.Label();
            userloginLabel = new System.Windows.Forms.Label();
            userpassLabel = new System.Windows.Forms.Label();
            userjobidLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbljobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridjob)).BeginInit();
            this.SuspendLayout();
            // 
            // userfirstnameLabel
            // 
            userfirstnameLabel.AutoSize = true;
            userfirstnameLabel.Location = new System.Drawing.Point(54, 99);
            userfirstnameLabel.Name = "userfirstnameLabel";
            userfirstnameLabel.Size = new System.Drawing.Size(60, 13);
            userfirstnameLabel.TabIndex = 23;
            userfirstnameLabel.Text = "First Name:";
            // 
            // userlastnameLabel
            // 
            userlastnameLabel.AutoSize = true;
            userlastnameLabel.Location = new System.Drawing.Point(54, 125);
            userlastnameLabel.Name = "userlastnameLabel";
            userlastnameLabel.Size = new System.Drawing.Size(61, 13);
            userlastnameLabel.TabIndex = 25;
            userlastnameLabel.Text = "Last Name:";
            // 
            // userloginLabel
            // 
            userloginLabel.AutoSize = true;
            userloginLabel.Location = new System.Drawing.Point(54, 71);
            userloginLabel.Name = "userloginLabel";
            userloginLabel.Size = new System.Drawing.Size(36, 13);
            userloginLabel.TabIndex = 27;
            userloginLabel.Text = "Login:";
            // 
            // userpassLabel
            // 
            userpassLabel.AutoSize = true;
            userpassLabel.Location = new System.Drawing.Point(54, 151);
            userpassLabel.Name = "userpassLabel";
            userpassLabel.Size = new System.Drawing.Size(56, 13);
            userpassLabel.TabIndex = 31;
            userpassLabel.Text = "Password:";
            // 
            // userjobidLabel
            // 
            userjobidLabel.AutoSize = true;
            userjobidLabel.Location = new System.Drawing.Point(150, 312);
            userjobidLabel.Name = "userjobidLabel";
            userjobidLabel.Size = new System.Drawing.Size(52, 13);
            userjobidLabel.TabIndex = 32;
            userjobidLabel.Text = "userjobid:";
            userjobidLabel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(54, 177);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 13);
            label2.TabIndex = 34;
            label2.Text = "Position:";
            // 
            // websterdbDataSet
            // 
            this.websterdbDataSet.DataSetName = "websterdbDataSet";
            this.websterdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblcycleTableAdapter = null;
            this.tableAdapterManager.tbldateTableAdapter = null;
            this.tableAdapterManager.tbljobTableAdapter = null;
            this.tableAdapterManager.tblpacklocationTableAdapter = null;
            this.tableAdapterManager.tblpacksizeTableAdapter = null;
            this.tableAdapterManager.tblpackTableAdapter = null;
            this.tableAdapterManager.tblpatientTableAdapter = null;
            this.tableAdapterManager.tblsettingsTableAdapter = null;
            this.tableAdapterManager.tbluserTableAdapter = this.tbluserTableAdapter;
            this.tableAdapterManager.UpdateOrder = PackChecker.websterdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbluserTableAdapter
            // 
            this.tbluserTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Edit User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(185, 278);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(133, 47);
            this.btncancel.TabIndex = 18;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(36, 278);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(133, 47);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Save and Close";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // cmbjob
            // 
            this.cmbjob.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbluserBindingSource, "userjobid", true));
            this.cmbjob.DataSource = this.tbljobBindingSource;
            this.cmbjob.DisplayMember = "jobname";
            this.cmbjob.FormattingEnabled = true;
            this.cmbjob.Location = new System.Drawing.Point(132, 174);
            this.cmbjob.Name = "cmbjob";
            this.cmbjob.Size = new System.Drawing.Size(174, 21);
            this.cmbjob.TabIndex = 21;
            this.cmbjob.ValueMember = "jobid";
            // 
            // tbluserBindingSource
            // 
            this.tbluserBindingSource.DataMember = "tbluser";
            this.tbluserBindingSource.DataSource = this.websterdbDataSet;
            // 
            // tbljobBindingSource
            // 
            this.tbljobBindingSource.DataMember = "tbljob";
            this.tbljobBindingSource.DataSource = this.websterdbDataSet;
            // 
            // useridTextBox
            // 
            this.useridTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbluserBindingSource, "userid", true));
            this.useridTextBox.Location = new System.Drawing.Point(24, 38);
            this.useridTextBox.Name = "useridTextBox";
            this.useridTextBox.Size = new System.Drawing.Size(100, 20);
            this.useridTextBox.TabIndex = 22;
            this.useridTextBox.Visible = false;
            // 
            // userfirstnameTextBox
            // 
            this.userfirstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbluserBindingSource, "userfirstname", true));
            this.userfirstnameTextBox.Location = new System.Drawing.Point(132, 96);
            this.userfirstnameTextBox.Name = "userfirstnameTextBox";
            this.userfirstnameTextBox.Size = new System.Drawing.Size(174, 20);
            this.userfirstnameTextBox.TabIndex = 24;
            this.userfirstnameTextBox.Leave += new System.EventHandler(this.userfirstnameTextBox_Leave);
            // 
            // userlastnameTextBox
            // 
            this.userlastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbluserBindingSource, "userlastname", true));
            this.userlastnameTextBox.Location = new System.Drawing.Point(132, 122);
            this.userlastnameTextBox.Name = "userlastnameTextBox";
            this.userlastnameTextBox.Size = new System.Drawing.Size(174, 20);
            this.userlastnameTextBox.TabIndex = 26;
            this.userlastnameTextBox.Leave += new System.EventHandler(this.userlastnameTextBox_Leave);
            // 
            // userloginTextBox
            // 
            this.userloginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbluserBindingSource, "userlogin", true));
            this.userloginTextBox.Location = new System.Drawing.Point(132, 68);
            this.userloginTextBox.MaxLength = 3;
            this.userloginTextBox.Name = "userloginTextBox";
            this.userloginTextBox.Size = new System.Drawing.Size(44, 20);
            this.userloginTextBox.TabIndex = 0;
            this.userloginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userloginTextBox.Leave += new System.EventHandler(this.userloginTextBox_Leave);
            // 
            // userpassTextBox
            // 
            this.userpassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbluserBindingSource, "userpass", true));
            this.userpassTextBox.Location = new System.Drawing.Point(132, 148);
            this.userpassTextBox.Name = "userpassTextBox";
            this.userpassTextBox.Size = new System.Drawing.Size(44, 20);
            this.userpassTextBox.TabIndex = 32;
            // 
            // tbljobTableAdapter
            // 
            this.tbljobTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridjob
            // 
            this.dataGridjob.AllowUserToAddRows = false;
            this.dataGridjob.AllowUserToDeleteRows = false;
            this.dataGridjob.AllowUserToResizeColumns = false;
            this.dataGridjob.AllowUserToResizeRows = false;
            this.dataGridjob.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridjob.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridjob.ColumnHeadersHeight = 34;
            this.dataGridjob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridjob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.canpackDataGridViewCheckBoxColumn,
            this.cancollectDataGridViewCheckBoxColumn,
            this.cancheckDataGridViewCheckBoxColumn,
            this.canrequestrepackDataGridViewCheckBoxColumn,
            this.adminDataGridViewCheckBoxColumn});
            this.dataGridjob.DataSource = this.tbljobBindingSource;
            this.dataGridjob.Enabled = false;
            this.dataGridjob.Location = new System.Drawing.Point(24, 204);
            this.dataGridjob.MultiSelect = false;
            this.dataGridjob.Name = "dataGridjob";
            this.dataGridjob.ReadOnly = true;
            this.dataGridjob.RowHeadersVisible = false;
            this.dataGridjob.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridjob.RowTemplate.Height = 25;
            this.dataGridjob.RowTemplate.ReadOnly = true;
            this.dataGridjob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridjob.Size = new System.Drawing.Size(303, 59);
            this.dataGridjob.TabIndex = 35;
            // 
            // canpackDataGridViewCheckBoxColumn
            // 
            this.canpackDataGridViewCheckBoxColumn.DataPropertyName = "canpack";
            this.canpackDataGridViewCheckBoxColumn.HeaderText = "Pack";
            this.canpackDataGridViewCheckBoxColumn.Name = "canpackDataGridViewCheckBoxColumn";
            this.canpackDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canpackDataGridViewCheckBoxColumn.Width = 60;
            // 
            // cancollectDataGridViewCheckBoxColumn
            // 
            this.cancollectDataGridViewCheckBoxColumn.DataPropertyName = "cancollect";
            this.cancollectDataGridViewCheckBoxColumn.HeaderText = "Give out";
            this.cancollectDataGridViewCheckBoxColumn.Name = "cancollectDataGridViewCheckBoxColumn";
            this.cancollectDataGridViewCheckBoxColumn.ReadOnly = true;
            this.cancollectDataGridViewCheckBoxColumn.Width = 60;
            // 
            // cancheckDataGridViewCheckBoxColumn
            // 
            this.cancheckDataGridViewCheckBoxColumn.DataPropertyName = "cancheck";
            this.cancheckDataGridViewCheckBoxColumn.HeaderText = "Check";
            this.cancheckDataGridViewCheckBoxColumn.Name = "cancheckDataGridViewCheckBoxColumn";
            this.cancheckDataGridViewCheckBoxColumn.ReadOnly = true;
            this.cancheckDataGridViewCheckBoxColumn.Width = 60;
            // 
            // canrequestrepackDataGridViewCheckBoxColumn
            // 
            this.canrequestrepackDataGridViewCheckBoxColumn.DataPropertyName = "canrequestrepack";
            this.canrequestrepackDataGridViewCheckBoxColumn.HeaderText = "Requests Changes";
            this.canrequestrepackDataGridViewCheckBoxColumn.Name = "canrequestrepackDataGridViewCheckBoxColumn";
            this.canrequestrepackDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canrequestrepackDataGridViewCheckBoxColumn.Width = 60;
            // 
            // adminDataGridViewCheckBoxColumn
            // 
            this.adminDataGridViewCheckBoxColumn.DataPropertyName = "admin";
            this.adminDataGridViewCheckBoxColumn.HeaderText = "Admin";
            this.adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
            this.adminDataGridViewCheckBoxColumn.ReadOnly = true;
            this.adminDataGridViewCheckBoxColumn.Width = 60;
            // 
            // frmuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 359);
            this.Controls.Add(this.dataGridjob);
            this.Controls.Add(label2);
            this.Controls.Add(userjobidLabel);
            this.Controls.Add(this.useridTextBox);
            this.Controls.Add(userfirstnameLabel);
            this.Controls.Add(this.userfirstnameTextBox);
            this.Controls.Add(userlastnameLabel);
            this.Controls.Add(this.userlastnameTextBox);
            this.Controls.Add(userloginLabel);
            this.Controls.Add(this.userloginTextBox);
            this.Controls.Add(userpassLabel);
            this.Controls.Add(this.userpassTextBox);
            this.Controls.Add(this.cmbjob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Name = "frmuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Edit";
            this.Load += new System.EventHandler(this.frmlocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbljobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridjob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private websterdbDataSet websterdbDataSet;
        private websterdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox cmbjob;
        private System.Windows.Forms.BindingSource tbluserBindingSource;
        private websterdbDataSetTableAdapters.tbluserTableAdapter tbluserTableAdapter;
        private System.Windows.Forms.TextBox useridTextBox;
        private System.Windows.Forms.TextBox userfirstnameTextBox;
        private System.Windows.Forms.TextBox userlastnameTextBox;
        private System.Windows.Forms.TextBox userloginTextBox;
        private System.Windows.Forms.TextBox userpassTextBox;
        private System.Windows.Forms.BindingSource tbljobBindingSource;
        private websterdbDataSetTableAdapters.tbljobTableAdapter tbljobTableAdapter;
        private System.Windows.Forms.DataGridView dataGridjob;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canpackDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cancollectDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cancheckDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canrequestrepackDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
    }
}