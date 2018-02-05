namespace PackChecker
{
    partial class frmcasualpatient
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
            System.Windows.Forms.Label pxfirstnameLabel;
            System.Windows.Forms.Label pxlastnameLabel;
            System.Windows.Forms.Label phonenumberLabel;
            System.Windows.Forms.Label repatnumberLabel;
            System.Windows.Forms.Label concessionnumberLabel;
            System.Windows.Forms.Label cycleidLabel;
            System.Windows.Forms.Label packscollectLabel;
            System.Windows.Forms.Label traysizeLabel;
            System.Windows.Forms.Label packlocationLabel;
            System.Windows.Forms.Label signingsheetLabel;
            System.Windows.Forms.Label over5medLabel;
            System.Windows.Forms.Label casualcommunityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcasualpatient));
            this.webbitdbdataset = new PackChecker.webbitdbdataset();
            this.casualpxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casualpxTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.casualpxTableAdapter();
            this.tableAdapterManager = new PackChecker.webbitdbdatasetTableAdapters.TableAdapterManager();
            this.pxfirstnameTextBox = new System.Windows.Forms.TextBox();
            this.pxlastnameTextBox = new System.Windows.Forms.TextBox();
            this.patientidTextBox = new System.Windows.Forms.TextBox();
            this.phonenumberTextBox = new System.Windows.Forms.TextBox();
            this.repatnumberTextBox = new System.Windows.Forms.TextBox();
            this.concessionnumberTextBox = new System.Windows.Forms.TextBox();
            this.packscollectTextBox = new System.Windows.Forms.TextBox();
            this.signingsheetCheckBox = new System.Windows.Forms.CheckBox();
            this.over5medCheckBox = new System.Windows.Forms.CheckBox();
            this.tblpacksizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpacksizeTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblpacksizeTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btncancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmblocation = new System.Windows.Forms.ComboBox();
            this.tblpacklocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpacklocationTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblpacklocationTableAdapter();
            this.cmbCycle = new System.Windows.Forms.ComboBox();
            this.tblcycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblcycleTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblcycleTableAdapter();
            this.cmbtraysize = new System.Windows.Forms.ComboBox();
            this.tblpatientTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblpatientTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.casualcommunityCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pxfirstnameLabel = new System.Windows.Forms.Label();
            pxlastnameLabel = new System.Windows.Forms.Label();
            phonenumberLabel = new System.Windows.Forms.Label();
            repatnumberLabel = new System.Windows.Forms.Label();
            concessionnumberLabel = new System.Windows.Forms.Label();
            cycleidLabel = new System.Windows.Forms.Label();
            packscollectLabel = new System.Windows.Forms.Label();
            traysizeLabel = new System.Windows.Forms.Label();
            packlocationLabel = new System.Windows.Forms.Label();
            signingsheetLabel = new System.Windows.Forms.Label();
            over5medLabel = new System.Windows.Forms.Label();
            casualcommunityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casualpxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pxfirstnameLabel
            // 
            pxfirstnameLabel.AutoSize = true;
            pxfirstnameLabel.Location = new System.Drawing.Point(36, 77);
            pxfirstnameLabel.Name = "pxfirstnameLabel";
            pxfirstnameLabel.Size = new System.Drawing.Size(60, 13);
            pxfirstnameLabel.TabIndex = 1;
            pxfirstnameLabel.Text = "First Name:";
            // 
            // pxlastnameLabel
            // 
            pxlastnameLabel.AutoSize = true;
            pxlastnameLabel.Location = new System.Drawing.Point(36, 111);
            pxlastnameLabel.Name = "pxlastnameLabel";
            pxlastnameLabel.Size = new System.Drawing.Size(61, 13);
            pxlastnameLabel.TabIndex = 3;
            pxlastnameLabel.Text = "Last Name:";
            // 
            // phonenumberLabel
            // 
            phonenumberLabel.AutoSize = true;
            phonenumberLabel.Location = new System.Drawing.Point(36, 144);
            phonenumberLabel.Name = "phonenumberLabel";
            phonenumberLabel.Size = new System.Drawing.Size(81, 13);
            phonenumberLabel.TabIndex = 7;
            phonenumberLabel.Text = "Phone Number:";
            // 
            // repatnumberLabel
            // 
            repatnumberLabel.AutoSize = true;
            repatnumberLabel.Location = new System.Drawing.Point(36, 178);
            repatnumberLabel.Name = "repatnumberLabel";
            repatnumberLabel.Size = new System.Drawing.Size(79, 13);
            repatnumberLabel.TabIndex = 9;
            repatnumberLabel.Text = "Repat Number:";
            // 
            // concessionnumberLabel
            // 
            concessionnumberLabel.AutoSize = true;
            concessionnumberLabel.Location = new System.Drawing.Point(36, 210);
            concessionnumberLabel.Name = "concessionnumberLabel";
            concessionnumberLabel.Size = new System.Drawing.Size(105, 13);
            concessionnumberLabel.TabIndex = 11;
            concessionnumberLabel.Text = "Concession Number:";
            // 
            // cycleidLabel
            // 
            cycleidLabel.AutoSize = true;
            cycleidLabel.Location = new System.Drawing.Point(36, 244);
            cycleidLabel.Name = "cycleidLabel";
            cycleidLabel.Size = new System.Drawing.Size(63, 13);
            cycleidLabel.TabIndex = 13;
            cycleidLabel.Text = "Cycle Type:";
            // 
            // packscollectLabel
            // 
            packscollectLabel.AutoSize = true;
            packscollectLabel.Location = new System.Drawing.Point(36, 277);
            packscollectLabel.Name = "packscollectLabel";
            packscollectLabel.Size = new System.Drawing.Size(87, 13);
            packscollectLabel.TabIndex = 15;
            packscollectLabel.Text = "Packs to Collect:";
            // 
            // traysizeLabel
            // 
            traysizeLabel.AutoSize = true;
            traysizeLabel.Location = new System.Drawing.Point(36, 312);
            traysizeLabel.Name = "traysizeLabel";
            traysizeLabel.Size = new System.Drawing.Size(54, 13);
            traysizeLabel.TabIndex = 17;
            traysizeLabel.Text = "Tray Size:";
            // 
            // packlocationLabel
            // 
            packlocationLabel.AutoSize = true;
            packlocationLabel.Location = new System.Drawing.Point(36, 346);
            packlocationLabel.Name = "packlocationLabel";
            packlocationLabel.Size = new System.Drawing.Size(79, 13);
            packlocationLabel.TabIndex = 19;
            packlocationLabel.Text = "Pack Location:";
            // 
            // signingsheetLabel
            // 
            signingsheetLabel.AutoSize = true;
            signingsheetLabel.Location = new System.Drawing.Point(36, 416);
            signingsheetLabel.Name = "signingsheetLabel";
            signingsheetLabel.Size = new System.Drawing.Size(79, 13);
            signingsheetLabel.TabIndex = 21;
            signingsheetLabel.Text = "Signing Sheet?";
            // 
            // over5medLabel
            // 
            over5medLabel.AutoSize = true;
            over5medLabel.Location = new System.Drawing.Point(36, 452);
            over5medLabel.Name = "over5medLabel";
            over5medLabel.Size = new System.Drawing.Size(114, 13);
            over5medLabel.TabIndex = 23;
            over5medLabel.Text = "Over 5 Meds Packed?";
            // 
            // casualcommunityLabel
            // 
            casualcommunityLabel.AutoSize = true;
            casualcommunityLabel.Location = new System.Drawing.Point(36, 379);
            casualcommunityLabel.Name = "casualcommunityLabel";
            casualcommunityLabel.Size = new System.Drawing.Size(97, 13);
            casualcommunityLabel.TabIndex = 30;
            casualcommunityLabel.Text = "Community Patient:";
            // 
            // webbitdbdataset
            // 
            this.webbitdbdataset.DataSetName = "webbitdbdataset";
            this.webbitdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // casualpxBindingSource
            // 
            this.casualpxBindingSource.DataMember = "casualpx";
            this.casualpxBindingSource.DataSource = this.webbitdbdataset;
            // 
            // casualpxTableAdapter
            // 
            this.casualpxTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.casualpxTableAdapter = this.casualpxTableAdapter;
            this.tableAdapterManager.tblcycleTableAdapter = null;
            this.tableAdapterManager.tbldateTableAdapter = null;
            this.tableAdapterManager.tblinstitutionTableAdapter = null;
            this.tableAdapterManager.tbljobTableAdapter = null;
            this.tableAdapterManager.tblpacklocationTableAdapter = null;
            this.tableAdapterManager.tblpacksizeTableAdapter = null;
            this.tableAdapterManager.tblpackTableAdapter = null;
            this.tableAdapterManager.tblpatientTableAdapter = null;
            this.tableAdapterManager.tblsettingsTableAdapter = null;
            this.tableAdapterManager.tbluserTableAdapter = null;
            this.tableAdapterManager.tblweekTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PackChecker.webbitdbdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usecycleTableAdapter = null;
            this.tableAdapterManager.uselocationTableAdapter = null;
            // 
            // pxfirstnameTextBox
            // 
            this.pxfirstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casualpxBindingSource, "pxfirstname", true));
            this.pxfirstnameTextBox.Location = new System.Drawing.Point(159, 74);
            this.pxfirstnameTextBox.Name = "pxfirstnameTextBox";
            this.pxfirstnameTextBox.Size = new System.Drawing.Size(152, 20);
            this.pxfirstnameTextBox.TabIndex = 0;
            this.pxfirstnameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pxfirstnameTextBox_KeyDown);
            // 
            // pxlastnameTextBox
            // 
            this.pxlastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casualpxBindingSource, "pxlastname", true));
            this.pxlastnameTextBox.Location = new System.Drawing.Point(159, 107);
            this.pxlastnameTextBox.Name = "pxlastnameTextBox";
            this.pxlastnameTextBox.Size = new System.Drawing.Size(152, 20);
            this.pxlastnameTextBox.TabIndex = 1;
            this.pxlastnameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pxfirstnameTextBox_KeyDown);
            // 
            // patientidTextBox
            // 
            this.patientidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casualpxBindingSource, "patientid", true));
            this.patientidTextBox.Location = new System.Drawing.Point(112, 37);
            this.patientidTextBox.Name = "patientidTextBox";
            this.patientidTextBox.Size = new System.Drawing.Size(152, 20);
            this.patientidTextBox.TabIndex = 6;
            this.patientidTextBox.TabStop = false;
            this.patientidTextBox.Visible = false;
            // 
            // phonenumberTextBox
            // 
            this.phonenumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casualpxBindingSource, "phonenumber", true));
            this.phonenumberTextBox.Location = new System.Drawing.Point(159, 140);
            this.phonenumberTextBox.Name = "phonenumberTextBox";
            this.phonenumberTextBox.Size = new System.Drawing.Size(152, 20);
            this.phonenumberTextBox.TabIndex = 2;
            this.phonenumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pxfirstnameTextBox_KeyDown);
            // 
            // repatnumberTextBox
            // 
            this.repatnumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casualpxBindingSource, "repatnumber", true));
            this.repatnumberTextBox.Location = new System.Drawing.Point(159, 173);
            this.repatnumberTextBox.Name = "repatnumberTextBox";
            this.repatnumberTextBox.Size = new System.Drawing.Size(152, 20);
            this.repatnumberTextBox.TabIndex = 3;
            this.repatnumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pxfirstnameTextBox_KeyDown);
            // 
            // concessionnumberTextBox
            // 
            this.concessionnumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casualpxBindingSource, "concessionnumber", true));
            this.concessionnumberTextBox.Location = new System.Drawing.Point(159, 206);
            this.concessionnumberTextBox.Name = "concessionnumberTextBox";
            this.concessionnumberTextBox.Size = new System.Drawing.Size(152, 20);
            this.concessionnumberTextBox.TabIndex = 4;
            this.concessionnumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pxfirstnameTextBox_KeyDown);
            // 
            // packscollectTextBox
            // 
            this.packscollectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casualpxBindingSource, "packscollect", true));
            this.packscollectTextBox.Location = new System.Drawing.Point(159, 273);
            this.packscollectTextBox.Name = "packscollectTextBox";
            this.packscollectTextBox.Size = new System.Drawing.Size(47, 20);
            this.packscollectTextBox.TabIndex = 6;
            this.packscollectTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pxfirstnameTextBox_KeyDown);
            // 
            // signingsheetCheckBox
            // 
            this.signingsheetCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.casualpxBindingSource, "signingsheet", true));
            this.signingsheetCheckBox.Location = new System.Drawing.Point(159, 411);
            this.signingsheetCheckBox.Name = "signingsheetCheckBox";
            this.signingsheetCheckBox.Size = new System.Drawing.Size(105, 24);
            this.signingsheetCheckBox.TabIndex = 9;
            this.signingsheetCheckBox.TabStop = false;
            this.signingsheetCheckBox.UseVisualStyleBackColor = true;
            // 
            // over5medCheckBox
            // 
            this.over5medCheckBox.Checked = true;
            this.over5medCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.over5medCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.casualpxBindingSource, "over5med", true));
            this.over5medCheckBox.Location = new System.Drawing.Point(159, 448);
            this.over5medCheckBox.Name = "over5medCheckBox";
            this.over5medCheckBox.Size = new System.Drawing.Size(105, 24);
            this.over5medCheckBox.TabIndex = 10;
            this.over5medCheckBox.TabStop = false;
            this.over5medCheckBox.UseVisualStyleBackColor = true;
            // 
            // tblpacksizeBindingSource
            // 
            this.tblpacksizeBindingSource.DataMember = "tblpacksize";
            this.tblpacksizeBindingSource.DataSource = this.webbitdbdataset;
            this.tblpacksizeBindingSource.Filter = "hide = false";
            // 
            // tblpacksizeTableAdapter
            // 
            this.tblpacksizeTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 38);
            this.label1.TabIndex = 28;
            this.label1.Text = "Casual Patient Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsave
            // 
            this.btnsave.ActiveBorderThickness = 1;
            this.btnsave.ActiveCornerRadius = 10;
            this.btnsave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnsave.ActiveForecolor = System.Drawing.Color.White;
            this.btnsave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
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
            this.btnsave.Location = new System.Drawing.Point(48, 473);
            this.btnsave.Margin = new System.Windows.Forms.Padding(5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(141, 54);
            this.btnsave.TabIndex = 9;
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.ActiveBorderThickness = 1;
            this.btncancel.ActiveCornerRadius = 10;
            this.btncancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btncancel.ActiveForecolor = System.Drawing.Color.White;
            this.btncancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
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
            this.btncancel.Location = new System.Drawing.Point(211, 473);
            this.btncancel.Margin = new System.Windows.Forms.Padding(5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(98, 54);
            this.btncancel.TabIndex = 30;
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // cmblocation
            // 
            this.cmblocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmblocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmblocation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.casualpxBindingSource, "packlocation", true));
            this.cmblocation.DataSource = this.tblpacklocationBindingSource;
            this.cmblocation.DisplayMember = "locationname";
            this.cmblocation.FormattingEnabled = true;
            this.cmblocation.Location = new System.Drawing.Point(159, 340);
            this.cmblocation.Name = "cmblocation";
            this.cmblocation.Size = new System.Drawing.Size(150, 21);
            this.cmblocation.TabIndex = 8;
            this.cmblocation.ValueMember = "locationid";
            this.cmblocation.SelectedIndexChanged += new System.EventHandler(this.cmbtraysize_SelectedValueChanged);
            this.cmblocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pxfirstnameTextBox_KeyDown);
            // 
            // tblpacklocationBindingSource
            // 
            this.tblpacklocationBindingSource.DataMember = "tblpacklocation";
            this.tblpacklocationBindingSource.DataSource = this.webbitdbdataset;
            this.tblpacklocationBindingSource.Filter = "hidelocation = false";
            // 
            // tblpacklocationTableAdapter
            // 
            this.tblpacklocationTableAdapter.ClearBeforeFill = true;
            // 
            // cmbCycle
            // 
            this.cmbCycle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCycle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCycle.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.casualpxBindingSource, "cycleid", true));
            this.cmbCycle.DataSource = this.tblcycleBindingSource;
            this.cmbCycle.DisplayMember = "cyclecode";
            this.cmbCycle.FormattingEnabled = true;
            this.cmbCycle.Location = new System.Drawing.Point(159, 239);
            this.cmbCycle.Name = "cmbCycle";
            this.cmbCycle.Size = new System.Drawing.Size(150, 21);
            this.cmbCycle.TabIndex = 5;
            this.cmbCycle.ValueMember = "cycleid";
            this.cmbCycle.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbCycle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pxfirstnameTextBox_KeyDown);
            // 
            // tblcycleBindingSource
            // 
            this.tblcycleBindingSource.DataMember = "tblcycle";
            this.tblcycleBindingSource.DataSource = this.webbitdbdataset;
            this.tblcycleBindingSource.Filter = "cyclehide = false";
            // 
            // tblcycleTableAdapter
            // 
            this.tblcycleTableAdapter.ClearBeforeFill = true;
            // 
            // cmbtraysize
            // 
            this.cmbtraysize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbtraysize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbtraysize.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.casualpxBindingSource, "traysize", true));
            this.cmbtraysize.DataSource = this.tblpacksizeBindingSource;
            this.cmbtraysize.DisplayMember = "sizelongname";
            this.cmbtraysize.FormattingEnabled = true;
            this.cmbtraysize.Location = new System.Drawing.Point(159, 306);
            this.cmbtraysize.Name = "cmbtraysize";
            this.cmbtraysize.Size = new System.Drawing.Size(152, 21);
            this.cmbtraysize.TabIndex = 7;
            this.cmbtraysize.ValueMember = "packsizeid";
            this.cmbtraysize.SelectedIndexChanged += new System.EventHandler(this.cmbtraysize_SelectedValueChanged);
            this.cmbtraysize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pxfirstnameTextBox_KeyDown);
            // 
            // tblpatientTableAdapter
            // 
            this.tblpatientTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // casualcommunityCheckBox
            // 
            this.casualcommunityCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.casualpxBindingSource, "casualcommunity", true));
            this.casualcommunityCheckBox.Location = new System.Drawing.Point(159, 374);
            this.casualcommunityCheckBox.Name = "casualcommunityCheckBox";
            this.casualcommunityCheckBox.Size = new System.Drawing.Size(104, 24);
            this.casualcommunityCheckBox.TabIndex = 31;
            this.casualcommunityCheckBox.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // frmcasualpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 541);
            this.Controls.Add(casualcommunityLabel);
            this.Controls.Add(this.casualcommunityCheckBox);
            this.Controls.Add(this.cmbCycle);
            this.Controls.Add(this.cmblocation);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbtraysize);
            this.Controls.Add(pxfirstnameLabel);
            this.Controls.Add(this.pxfirstnameTextBox);
            this.Controls.Add(pxlastnameLabel);
            this.Controls.Add(this.pxlastnameTextBox);
            this.Controls.Add(this.patientidTextBox);
            this.Controls.Add(phonenumberLabel);
            this.Controls.Add(this.phonenumberTextBox);
            this.Controls.Add(repatnumberLabel);
            this.Controls.Add(this.repatnumberTextBox);
            this.Controls.Add(concessionnumberLabel);
            this.Controls.Add(this.concessionnumberTextBox);
            this.Controls.Add(cycleidLabel);
            this.Controls.Add(packscollectLabel);
            this.Controls.Add(this.packscollectTextBox);
            this.Controls.Add(traysizeLabel);
            this.Controls.Add(packlocationLabel);
            this.Controls.Add(signingsheetLabel);
            this.Controls.Add(this.signingsheetCheckBox);
            this.Controls.Add(over5medLabel);
            this.Controls.Add(this.over5medCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcasualpatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcasualpatient";
            this.Load += new System.EventHandler(this.frmcasualpatient_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmcasualpatient_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casualpxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private webbitdbdataset webbitdbdataset;
        private System.Windows.Forms.BindingSource casualpxBindingSource;
        private webbitdbdatasetTableAdapters.casualpxTableAdapter casualpxTableAdapter;
        private webbitdbdatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox pxfirstnameTextBox;
        private System.Windows.Forms.TextBox pxlastnameTextBox;
        private System.Windows.Forms.TextBox patientidTextBox;
        private System.Windows.Forms.TextBox phonenumberTextBox;
        private System.Windows.Forms.TextBox repatnumberTextBox;
        private System.Windows.Forms.TextBox concessionnumberTextBox;
        private System.Windows.Forms.TextBox packscollectTextBox;
        private System.Windows.Forms.CheckBox signingsheetCheckBox;
        private System.Windows.Forms.CheckBox over5medCheckBox;
        private System.Windows.Forms.BindingSource tblpacksizeBindingSource;
        private webbitdbdatasetTableAdapters.tblpacksizeTableAdapter tblpacksizeTableAdapter;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsave;
        private Bunifu.Framework.UI.BunifuThinButton2 btncancel;
        private System.Windows.Forms.ComboBox cmblocation;
        private System.Windows.Forms.BindingSource tblpacklocationBindingSource;
        private webbitdbdatasetTableAdapters.tblpacklocationTableAdapter tblpacklocationTableAdapter;
        private System.Windows.Forms.ComboBox cmbCycle;
        private System.Windows.Forms.BindingSource tblcycleBindingSource;
        private webbitdbdatasetTableAdapters.tblcycleTableAdapter tblcycleTableAdapter;
        private System.Windows.Forms.ComboBox cmbtraysize;
        private webbitdbdatasetTableAdapters.tblpatientTableAdapter tblpatientTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox casualcommunityCheckBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}