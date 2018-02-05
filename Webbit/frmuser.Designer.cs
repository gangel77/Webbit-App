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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmuser));
            this.webbitdbdataset = new PackChecker.webbitdbdataset();
            this.tableAdapterManager = new PackChecker.webbitdbdatasetTableAdapters.TableAdapterManager();
            this.tbluserTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tbluserTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbjob = new System.Windows.Forms.ComboBox();
            this.tbluserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbljobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.useridTextBox = new System.Windows.Forms.TextBox();
            this.userfirstnameTextBox = new System.Windows.Forms.TextBox();
            this.userlastnameTextBox = new System.Windows.Forms.TextBox();
            this.userloginTextBox = new System.Windows.Forms.TextBox();
            this.userpassTextBox = new System.Windows.Forms.TextBox();
            this.tbljobTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tbljobTableAdapter();
            this.dataGridjob = new System.Windows.Forms.DataGridView();
            this.canpackDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cancollectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cancheckDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.webadminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btncancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnsave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            userfirstnameLabel = new System.Windows.Forms.Label();
            userlastnameLabel = new System.Windows.Forms.Label();
            userloginLabel = new System.Windows.Forms.Label();
            userpassLabel = new System.Windows.Forms.Label();
            userjobidLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbljobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridjob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // userfirstnameLabel
            // 
            userfirstnameLabel.AutoSize = true;
            userfirstnameLabel.Font = new System.Drawing.Font("Myriad Pro", 10.25F);
            userfirstnameLabel.Location = new System.Drawing.Point(54, 99);
            userfirstnameLabel.Name = "userfirstnameLabel";
            userfirstnameLabel.Size = new System.Drawing.Size(75, 17);
            userfirstnameLabel.TabIndex = 23;
            userfirstnameLabel.Text = "First Name:";
            // 
            // userlastnameLabel
            // 
            userlastnameLabel.AutoSize = true;
            userlastnameLabel.Font = new System.Drawing.Font("Myriad Pro", 10.25F);
            userlastnameLabel.Location = new System.Drawing.Point(54, 125);
            userlastnameLabel.Name = "userlastnameLabel";
            userlastnameLabel.Size = new System.Drawing.Size(74, 17);
            userlastnameLabel.TabIndex = 25;
            userlastnameLabel.Text = "Last Name:";
            // 
            // userloginLabel
            // 
            userloginLabel.AutoSize = true;
            userloginLabel.Font = new System.Drawing.Font("Myriad Pro", 10.25F);
            userloginLabel.Location = new System.Drawing.Point(54, 71);
            userloginLabel.Name = "userloginLabel";
            userloginLabel.Size = new System.Drawing.Size(45, 17);
            userloginLabel.TabIndex = 27;
            userloginLabel.Text = "Login:";
            // 
            // userpassLabel
            // 
            userpassLabel.AutoSize = true;
            userpassLabel.Font = new System.Drawing.Font("Myriad Pro", 10.25F);
            userpassLabel.Location = new System.Drawing.Point(54, 152);
            userpassLabel.Name = "userpassLabel";
            userpassLabel.Size = new System.Drawing.Size(68, 17);
            userpassLabel.TabIndex = 31;
            userpassLabel.Text = "Password:";
            // 
            // userjobidLabel
            // 
            userjobidLabel.AutoSize = true;
            userjobidLabel.Location = new System.Drawing.Point(150, 345);
            userjobidLabel.Name = "userjobidLabel";
            userjobidLabel.Size = new System.Drawing.Size(53, 13);
            userjobidLabel.TabIndex = 32;
            userjobidLabel.Text = "userjobid:";
            userjobidLabel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Myriad Pro", 10.25F);
            label2.Location = new System.Drawing.Point(54, 177);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 17);
            label2.TabIndex = 34;
            label2.Text = "Position:";
            // 
            // webbitdbdataset
            // 
            this.webbitdbdataset.DataSetName = "webbitdbdataset";
            this.webbitdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.tblpacksizeTableAdapter = null;
            this.tableAdapterManager.tblpackTableAdapter = null;
            this.tableAdapterManager.tblpatientTableAdapter = null;
            this.tableAdapterManager.tblsettingsTableAdapter = null;
            this.tableAdapterManager.tbluserTableAdapter = this.tbluserTableAdapter;
            this.tableAdapterManager.tblweekTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PackChecker.webbitdbdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usecycleTableAdapter = null;
            this.tableAdapterManager.uselocationTableAdapter = null;
            // 
            // tbluserTableAdapter
            // 
            this.tbluserTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Edit User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbjob
            // 
            this.cmbjob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbjob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbjob.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbluserBindingSource, "userjobid", true));
            this.cmbjob.DataSource = this.tbljobBindingSource;
            this.cmbjob.DisplayMember = "jobname";
            this.cmbjob.Font = new System.Drawing.Font("Myriad Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbjob.FormattingEnabled = true;
            this.cmbjob.Location = new System.Drawing.Point(132, 178);
            this.cmbjob.Name = "cmbjob";
            this.cmbjob.Size = new System.Drawing.Size(174, 21);
            this.cmbjob.TabIndex = 4;
            this.cmbjob.ValueMember = "jobid";
            // 
            // tbluserBindingSource
            // 
            this.tbluserBindingSource.DataMember = "tbluser";
            this.tbluserBindingSource.DataSource = this.webbitdbdataset;
            // 
            // tbljobBindingSource
            // 
            this.tbljobBindingSource.DataMember = "tbljob";
            this.tbljobBindingSource.DataSource = this.webbitdbdataset;
            // 
            // useridTextBox
            // 
            this.useridTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbluserBindingSource, "userid", true));
            this.useridTextBox.Location = new System.Drawing.Point(24, 6);
            this.useridTextBox.Name = "useridTextBox";
            this.useridTextBox.Size = new System.Drawing.Size(100, 21);
            this.useridTextBox.TabIndex = 22;
            this.useridTextBox.Visible = false;
            // 
            // userfirstnameTextBox
            // 
            this.userfirstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbluserBindingSource, "userfirstname", true));
            this.userfirstnameTextBox.Enabled = false;
            this.userfirstnameTextBox.Font = new System.Drawing.Font("Myriad Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userfirstnameTextBox.Location = new System.Drawing.Point(132, 98);
            this.userfirstnameTextBox.Name = "userfirstnameTextBox";
            this.userfirstnameTextBox.Size = new System.Drawing.Size(174, 21);
            this.userfirstnameTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.userfirstnameTextBox, "Updated from Dispense");
            this.userfirstnameTextBox.TextChanged += new System.EventHandler(this.userfirstnameTextBox_TextChanged);
            this.userfirstnameTextBox.Leave += new System.EventHandler(this.userfirstnameTextBox_Leave);
            // 
            // userlastnameTextBox
            // 
            this.userlastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbluserBindingSource, "userlastname", true));
            this.userlastnameTextBox.Font = new System.Drawing.Font("Myriad Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlastnameTextBox.Location = new System.Drawing.Point(132, 125);
            this.userlastnameTextBox.Name = "userlastnameTextBox";
            this.userlastnameTextBox.Size = new System.Drawing.Size(174, 21);
            this.userlastnameTextBox.TabIndex = 2;
            this.userlastnameTextBox.TextChanged += new System.EventHandler(this.userlastnameTextBox_TextChanged);
            this.userlastnameTextBox.Leave += new System.EventHandler(this.userlastnameTextBox_Leave);
            // 
            // userloginTextBox
            // 
            this.userloginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbluserBindingSource, "userlogin", true));
            this.userloginTextBox.Enabled = false;
            this.userloginTextBox.Font = new System.Drawing.Font("Myriad Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userloginTextBox.Location = new System.Drawing.Point(132, 71);
            this.userloginTextBox.MaxLength = 3;
            this.userloginTextBox.Name = "userloginTextBox";
            this.userloginTextBox.Size = new System.Drawing.Size(44, 21);
            this.userloginTextBox.TabIndex = 0;
            this.userloginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.userloginTextBox, "Updated from Dispense");
            this.userloginTextBox.TextChanged += new System.EventHandler(this.userloginTextBox_TextChanged);
            this.userloginTextBox.Leave += new System.EventHandler(this.userloginTextBox_Leave);
            // 
            // userpassTextBox
            // 
            this.userpassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbluserBindingSource, "userpass", true));
            this.userpassTextBox.Font = new System.Drawing.Font("Myriad Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userpassTextBox.Location = new System.Drawing.Point(132, 151);
            this.userpassTextBox.Name = "userpassTextBox";
            this.userpassTextBox.Size = new System.Drawing.Size(44, 21);
            this.userpassTextBox.TabIndex = 3;
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
            this.dataGridjob.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myriad Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridjob.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridjob.ColumnHeadersHeight = 45;
            this.dataGridjob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridjob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.canpackDataGridViewCheckBoxColumn,
            this.cancollectDataGridViewCheckBoxColumn,
            this.cancheckDataGridViewCheckBoxColumn,
            this.webadminDataGridViewCheckBoxColumn,
            this.adminDataGridViewCheckBoxColumn});
            this.dataGridjob.DataSource = this.tbljobBindingSource;
            this.dataGridjob.Enabled = false;
            this.dataGridjob.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.dataGridjob.Location = new System.Drawing.Point(24, 204);
            this.dataGridjob.MultiSelect = false;
            this.dataGridjob.Name = "dataGridjob";
            this.dataGridjob.ReadOnly = true;
            this.dataGridjob.RowHeadersVisible = false;
            this.dataGridjob.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridjob.RowTemplate.Height = 25;
            this.dataGridjob.RowTemplate.ReadOnly = true;
            this.dataGridjob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridjob.Size = new System.Drawing.Size(303, 72);
            this.dataGridjob.TabIndex = 35;
            this.dataGridjob.TabStop = false;
            // 
            // canpackDataGridViewCheckBoxColumn
            // 
            this.canpackDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.canpackDataGridViewCheckBoxColumn.DataPropertyName = "canpack";
            this.canpackDataGridViewCheckBoxColumn.FillWeight = 20F;
            this.canpackDataGridViewCheckBoxColumn.HeaderText = "Pack";
            this.canpackDataGridViewCheckBoxColumn.Name = "canpackDataGridViewCheckBoxColumn";
            this.canpackDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // cancollectDataGridViewCheckBoxColumn
            // 
            this.cancollectDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cancollectDataGridViewCheckBoxColumn.DataPropertyName = "cancollect";
            this.cancollectDataGridViewCheckBoxColumn.FillWeight = 20F;
            this.cancollectDataGridViewCheckBoxColumn.HeaderText = "Give out";
            this.cancollectDataGridViewCheckBoxColumn.Name = "cancollectDataGridViewCheckBoxColumn";
            this.cancollectDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // cancheckDataGridViewCheckBoxColumn
            // 
            this.cancheckDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cancheckDataGridViewCheckBoxColumn.DataPropertyName = "cancheck";
            this.cancheckDataGridViewCheckBoxColumn.FillWeight = 20F;
            this.cancheckDataGridViewCheckBoxColumn.HeaderText = "Check";
            this.cancheckDataGridViewCheckBoxColumn.Name = "cancheckDataGridViewCheckBoxColumn";
            this.cancheckDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // webadminDataGridViewCheckBoxColumn
            // 
            this.webadminDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.webadminDataGridViewCheckBoxColumn.DataPropertyName = "webadmin";
            this.webadminDataGridViewCheckBoxColumn.FillWeight = 20F;
            this.webadminDataGridViewCheckBoxColumn.HeaderText = "Packing Admin";
            this.webadminDataGridViewCheckBoxColumn.Name = "webadminDataGridViewCheckBoxColumn";
            this.webadminDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // adminDataGridViewCheckBoxColumn
            // 
            this.adminDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adminDataGridViewCheckBoxColumn.DataPropertyName = "admin";
            this.adminDataGridViewCheckBoxColumn.FillWeight = 20F;
            this.adminDataGridViewCheckBoxColumn.HeaderText = "Admin";
            this.adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
            this.adminDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btncancel
            // 
            this.btncancel.ActiveBorderThickness = 1;
            this.btncancel.ActiveCornerRadius = 10;
            this.btncancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btncancel.ActiveForecolor = System.Drawing.Color.White;
            this.btncancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(14)))));
            this.btncancel.BackColor = System.Drawing.Color.White;
            this.btncancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancel.BackgroundImage")));
            this.btncancel.ButtonText = "Cancel";
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btncancel.IdleBorderThickness = 1;
            this.btncancel.IdleCornerRadius = 10;
            this.btncancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btncancel.IdleForecolor = System.Drawing.Color.White;
            this.btncancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btncancel.Location = new System.Drawing.Point(208, 295);
            this.btncancel.Margin = new System.Windows.Forms.Padding(5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(98, 54);
            this.btncancel.TabIndex = 6;
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.ActiveBorderThickness = 1;
            this.btnsave.ActiveCornerRadius = 10;
            this.btnsave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnsave.ActiveForecolor = System.Drawing.Color.White;
            this.btnsave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(14)))));
            this.btnsave.BackColor = System.Drawing.Color.White;
            this.btnsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsave.BackgroundImage")));
            this.btnsave.ButtonText = "Save and Close";
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnsave.IdleBorderThickness = 1;
            this.btnsave.IdleCornerRadius = 10;
            this.btnsave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnsave.IdleForecolor = System.Drawing.Color.White;
            this.btnsave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnsave.Location = new System.Drawing.Point(45, 295);
            this.btnsave.Margin = new System.Windows.Forms.Padding(5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(141, 54);
            this.btnsave.TabIndex = 5;
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            // 
            // frmuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 363);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncancel);
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
            this.Font = new System.Drawing.Font("Myriad Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Edit";
            this.Load += new System.EventHandler(this.frmlocation_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmuser_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbljobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridjob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private webbitdbdataset webbitdbdataset;
        private webbitdbdatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbjob;
        private System.Windows.Forms.BindingSource tbluserBindingSource;
        private webbitdbdatasetTableAdapters.tbluserTableAdapter tbluserTableAdapter;
        private System.Windows.Forms.TextBox useridTextBox;
        private System.Windows.Forms.TextBox userfirstnameTextBox;
        private System.Windows.Forms.TextBox userlastnameTextBox;
        private System.Windows.Forms.TextBox userloginTextBox;
        private System.Windows.Forms.TextBox userpassTextBox;
        private System.Windows.Forms.BindingSource tbljobBindingSource;
        private webbitdbdatasetTableAdapters.tbljobTableAdapter tbljobTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsave;
        private Bunifu.Framework.UI.BunifuThinButton2 btncancel;
        private System.Windows.Forms.DataGridView dataGridjob;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canpackDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cancollectDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cancheckDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn webadminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}