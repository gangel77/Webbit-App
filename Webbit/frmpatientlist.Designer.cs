namespace PackChecker
{
    partial class frmpatientlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpatientlist));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblpacksizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webbitdbdatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webbitdbdataset = new PackChecker.webbitdbdataset();
            this.tblcycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpacklocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpacklocationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tblpacksizeTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblpacksizeTableAdapter();
            this.tblcycleTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblcycleTableAdapter();
            this.tblpacklocationTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblpacklocationTableAdapter();
            this.tblpatientTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblpatientTableAdapter();
            this.tblcycleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblpacklocationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblpacksizeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.background = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkselectall = new System.Windows.Forms.CheckBox();
            this.chkSignSheet = new System.Windows.Forms.CheckBox();
            this.chkDelivery = new System.Windows.Forms.CheckBox();
            this.chkallow2loc = new System.Windows.Forms.CheckBox();
            this.cmbcycle = new System.Windows.Forms.ComboBox();
            this.btnbatchupdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmblocation = new System.Windows.Forms.ComboBox();
            this.cmbsize = new System.Windows.Forms.ComboBox();
            this.lblbatch = new System.Windows.Forms.Label();
            this.dataGridpatients = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.clnselected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnlastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnfirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpacksize = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clncycletype = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnpackscollect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnlocation1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnlocation2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnclear = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clndelivery = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cln5meds = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnsigningsheet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnforcenext = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnpxcomment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncomwarn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnpxid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnsuburb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnmedicare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnrepatid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnphonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clndispenseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clninstitution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpostcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clninstitutionname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource1)).BeginInit();
            this.background.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpatients)).BeginInit();
            this.SuspendLayout();
            // 
            // tblpacksizeBindingSource
            // 
            this.tblpacksizeBindingSource.DataMember = "tblpacksize";
            this.tblpacksizeBindingSource.DataSource = this.webbitdbdatasetBindingSource;
            this.tblpacksizeBindingSource.Filter = "hide = false";
            // 
            // webbitdbdatasetBindingSource
            // 
            this.webbitdbdatasetBindingSource.DataSource = this.webbitdbdataset;
            this.webbitdbdatasetBindingSource.Position = 0;
            // 
            // webbitdbdataset
            // 
            this.webbitdbdataset.DataSetName = "webbitdbdataset";
            this.webbitdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcycleBindingSource
            // 
            this.tblcycleBindingSource.DataMember = "tblcycle";
            this.tblcycleBindingSource.DataSource = this.webbitdbdatasetBindingSource;
            this.tblcycleBindingSource.Filter = "cyclehide = false";
            // 
            // tblpacklocationBindingSource
            // 
            this.tblpacklocationBindingSource.DataMember = "tblpacklocation";
            this.tblpacklocationBindingSource.DataSource = this.webbitdbdatasetBindingSource;
            this.tblpacklocationBindingSource.Filter = "hidelocation = false";
            // 
            // tblpacklocationBindingSource1
            // 
            this.tblpacklocationBindingSource1.DataMember = "tblpacklocation";
            this.tblpacklocationBindingSource1.DataSource = this.webbitdbdatasetBindingSource;
            this.tblpacklocationBindingSource1.Filter = "hidelocation = false";
            // 
            // lbltitle
            // 
            this.lbltitle.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lbltitle.Location = new System.Drawing.Point(407, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(516, 43);
            this.lbltitle.TabIndex = 3;
            this.lbltitle.Text = "My Patients";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 10;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Close";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 10;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnCancel.IdleForecolor = System.Drawing.Color.White;
            this.btnCancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnCancel.Location = new System.Drawing.Point(679, 615);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 54);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 10;
            this.btnSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Save and Close";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 10;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnSave.IdleForecolor = System.Drawing.Color.White;
            this.btnSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnSave.Location = new System.Drawing.Point(499, 615);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 54);
            this.btnSave.TabIndex = 23;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblpacksizeTableAdapter
            // 
            this.tblpacksizeTableAdapter.ClearBeforeFill = true;
            // 
            // tblcycleTableAdapter
            // 
            this.tblcycleTableAdapter.ClearBeforeFill = true;
            // 
            // tblpacklocationTableAdapter
            // 
            this.tblpacklocationTableAdapter.ClearBeforeFill = true;
            // 
            // tblpatientTableAdapter
            // 
            this.tblpatientTableAdapter.ClearBeforeFill = true;
            // 
            // tblcycleBindingSource1
            // 
            this.tblcycleBindingSource1.DataMember = "tblcycle";
            this.tblcycleBindingSource1.DataSource = this.webbitdbdataset;
            this.tblcycleBindingSource1.Filter = "cyclehide = false";
            // 
            // tblpacklocationBindingSource2
            // 
            this.tblpacklocationBindingSource2.DataMember = "tblpacklocation";
            this.tblpacklocationBindingSource2.DataSource = this.webbitdbdataset;
            this.tblpacklocationBindingSource2.Filter = "hidelocation = false";
            // 
            // tblpacksizeBindingSource1
            // 
            this.tblpacksizeBindingSource1.DataMember = "tblpacksize";
            this.tblpacksizeBindingSource1.DataSource = this.webbitdbdataset;
            this.tblpacksizeBindingSource1.Filter = "hide = false";
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.background.Controls.Add(this.panel2);
            this.background.Location = new System.Drawing.Point(19, 53);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1293, 64);
            this.background.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.chkselectall);
            this.panel2.Controls.Add(this.chkSignSheet);
            this.panel2.Controls.Add(this.chkDelivery);
            this.panel2.Controls.Add(this.chkallow2loc);
            this.panel2.Controls.Add(this.cmbcycle);
            this.panel2.Controls.Add(this.btnbatchupdate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmblocation);
            this.panel2.Controls.Add(this.cmbsize);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1288, 59);
            this.panel2.TabIndex = 24;
            // 
            // chkselectall
            // 
            this.chkselectall.AutoSize = true;
            this.chkselectall.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.chkselectall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.chkselectall.Location = new System.Drawing.Point(17, 12);
            this.chkselectall.Name = "chkselectall";
            this.chkselectall.Size = new System.Drawing.Size(139, 33);
            this.chkselectall.TabIndex = 26;
            this.chkselectall.Text = "Select All";
            this.chkselectall.UseVisualStyleBackColor = true;
            this.chkselectall.CheckedChanged += new System.EventHandler(this.chkselectall_CheckedChanged);
            // 
            // chkSignSheet
            // 
            this.chkSignSheet.AutoSize = true;
            this.chkSignSheet.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold);
            this.chkSignSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.chkSignSheet.Location = new System.Drawing.Point(789, 30);
            this.chkSignSheet.Name = "chkSignSheet";
            this.chkSignSheet.Size = new System.Drawing.Size(124, 24);
            this.chkSignSheet.TabIndex = 35;
            this.chkSignSheet.Text = "Signing Sheet";
            this.chkSignSheet.UseVisualStyleBackColor = true;
            // 
            // chkDelivery
            // 
            this.chkDelivery.AutoSize = true;
            this.chkDelivery.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold);
            this.chkDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.chkDelivery.Location = new System.Drawing.Point(789, 4);
            this.chkDelivery.Name = "chkDelivery";
            this.chkDelivery.Size = new System.Drawing.Size(85, 24);
            this.chkDelivery.TabIndex = 34;
            this.chkDelivery.Text = "Delivery";
            this.chkDelivery.UseVisualStyleBackColor = true;
            // 
            // chkallow2loc
            // 
            this.chkallow2loc.AutoSize = true;
            this.chkallow2loc.Font = new System.Drawing.Font("Arial", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkallow2loc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.chkallow2loc.Location = new System.Drawing.Point(1132, 7);
            this.chkallow2loc.Name = "chkallow2loc";
            this.chkallow2loc.Size = new System.Drawing.Size(144, 19);
            this.chkallow2loc.TabIndex = 32;
            this.chkallow2loc.Text = "Allow Dual Locations";
            this.chkallow2loc.UseVisualStyleBackColor = true;
            this.chkallow2loc.CheckedChanged += new System.EventHandler(this.chkallow2loc_CheckedChanged);
            // 
            // cmbcycle
            // 
            this.cmbcycle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbcycle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbcycle.DataSource = this.tblcycleBindingSource1;
            this.cmbcycle.DisplayMember = "cyclecode";
            this.cmbcycle.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcycle.FormattingEnabled = true;
            this.cmbcycle.Location = new System.Drawing.Point(413, 28);
            this.cmbcycle.Name = "cmbcycle";
            this.cmbcycle.Size = new System.Drawing.Size(177, 27);
            this.cmbcycle.TabIndex = 30;
            this.cmbcycle.ValueMember = "cycleid";
            // 
            // btnbatchupdate
            // 
            this.btnbatchupdate.ActiveBorderThickness = 1;
            this.btnbatchupdate.ActiveCornerRadius = 10;
            this.btnbatchupdate.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnbatchupdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnbatchupdate.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnbatchupdate.BackColor = System.Drawing.Color.White;
            this.btnbatchupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbatchupdate.BackgroundImage")));
            this.btnbatchupdate.ButtonText = "Update Selected";
            this.btnbatchupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbatchupdate.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbatchupdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnbatchupdate.IdleBorderThickness = 1;
            this.btnbatchupdate.IdleCornerRadius = 10;
            this.btnbatchupdate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnbatchupdate.IdleForecolor = System.Drawing.Color.White;
            this.btnbatchupdate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnbatchupdate.Location = new System.Drawing.Point(929, 1);
            this.btnbatchupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnbatchupdate.Name = "btnbatchupdate";
            this.btnbatchupdate.Size = new System.Drawing.Size(142, 56);
            this.btnbatchupdate.TabIndex = 25;
            this.btnbatchupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbatchupdate.Click += new System.EventHandler(this.btnbatchupdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(643, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Location";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(474, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cycle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(298, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmblocation
            // 
            this.cmblocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmblocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmblocation.DataSource = this.tblpacklocationBindingSource2;
            this.cmblocation.DisplayMember = "locationname";
            this.cmblocation.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmblocation.FormattingEnabled = true;
            this.cmblocation.Location = new System.Drawing.Point(596, 28);
            this.cmblocation.Name = "cmblocation";
            this.cmblocation.Size = new System.Drawing.Size(177, 27);
            this.cmblocation.TabIndex = 2;
            this.cmblocation.ValueMember = "locationid";
            // 
            // cmbsize
            // 
            this.cmbsize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbsize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbsize.DataSource = this.tblpacksizeBindingSource1;
            this.cmbsize.DisplayMember = "sizelongname";
            this.cmbsize.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsize.FormattingEnabled = true;
            this.cmbsize.Location = new System.Drawing.Point(230, 28);
            this.cmbsize.Name = "cmbsize";
            this.cmbsize.Size = new System.Drawing.Size(177, 27);
            this.cmbsize.TabIndex = 0;
            this.cmbsize.ValueMember = "packsizeid";
            // 
            // lblbatch
            // 
            this.lblbatch.AutoSize = true;
            this.lblbatch.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lblbatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblbatch.Location = new System.Drawing.Point(22, 22);
            this.lblbatch.Name = "lblbatch";
            this.lblbatch.Size = new System.Drawing.Size(122, 30);
            this.lblbatch.TabIndex = 25;
            this.lblbatch.Text = "Batch Edit";
            this.lblbatch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridpatients
            // 
            this.dataGridpatients.AllowUserToAddRows = false;
            this.dataGridpatients.AllowUserToDeleteRows = false;
            this.dataGridpatients.AllowUserToResizeColumns = false;
            this.dataGridpatients.AllowUserToResizeRows = false;
            this.dataGridpatients.BackgroundColor = System.Drawing.Color.White;
            this.dataGridpatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridpatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridpatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridpatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnselected,
            this.clnlastname,
            this.clnfirstname,
            this.clnpacksize,
            this.clncycletype,
            this.clnpackscollect,
            this.clnlocation1,
            this.clnlocation2,
            this.clnclear,
            this.clndelivery,
            this.cln5meds,
            this.clnsigningsheet,
            this.clnforcenext,
            this.clnpxcomment,
            this.clncomwarn,
            this.clnpxid,
            this.clnactive,
            this.clnsuburb,
            this.clnaddress,
            this.clnmedicare,
            this.clnrepatid,
            this.clnphonenumber,
            this.clndispenseid,
            this.clninstitution,
            this.clnpostcode,
            this.clninstitutionname});
            this.dataGridpatients.EnableHeadersVisualStyles = false;
            this.dataGridpatients.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridpatients.Location = new System.Drawing.Point(20, 125);
            this.dataGridpatients.MultiSelect = false;
            this.dataGridpatients.Name = "dataGridpatients";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridpatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridpatients.RowHeadersVisible = false;
            this.dataGridpatients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridpatients.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridpatients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridpatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridpatients.Size = new System.Drawing.Size(1289, 482);
            this.dataGridpatients.TabIndex = 38;
            this.dataGridpatients.TabStop = false;
            this.dataGridpatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridpatients_CellContentClick);
            this.dataGridpatients.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridpatients_CellEnter_1);
            this.dataGridpatients.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridpatients_CurrentCellDirtyStateChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // clnselected
            // 
            this.clnselected.HeaderText = "+";
            this.clnselected.Name = "clnselected";
            this.clnselected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnselected.Width = 30;
            // 
            // clnlastname
            // 
            this.clnlastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnlastname.HeaderText = "Last Name";
            this.clnlastname.Name = "clnlastname";
            this.clnlastname.ReadOnly = true;
            this.clnlastname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnlastname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnlastname.Width = 84;
            // 
            // clnfirstname
            // 
            this.clnfirstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnfirstname.HeaderText = "First Name";
            this.clnfirstname.Name = "clnfirstname";
            this.clnfirstname.ReadOnly = true;
            this.clnfirstname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnfirstname.Width = 85;
            // 
            // clnpacksize
            // 
            this.clnpacksize.DataSource = this.tblpacksizeBindingSource;
            this.clnpacksize.DisplayMember = "sizelongname";
            this.clnpacksize.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.clnpacksize.HeaderText = "Pack Size";
            this.clnpacksize.Name = "clnpacksize";
            this.clnpacksize.ValueMember = "packsizeid";
            // 
            // clncycletype
            // 
            this.clncycletype.DataSource = this.tblcycleBindingSource;
            this.clncycletype.DisplayMember = "cyclecode";
            this.clncycletype.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.clncycletype.HeaderText = "Cycle Type";
            this.clncycletype.Name = "clncycletype";
            this.clncycletype.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clncycletype.ValueMember = "cycleid";
            this.clncycletype.Width = 110;
            // 
            // clnpackscollect
            // 
            this.clnpackscollect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clnpackscollect.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnpackscollect.HeaderText = "Packs to Collect";
            this.clnpackscollect.Name = "clnpackscollect";
            this.clnpackscollect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnpackscollect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnpackscollect.Width = 118;
            // 
            // clnlocation1
            // 
            this.clnlocation1.DataSource = this.tblpacklocationBindingSource;
            this.clnlocation1.DisplayMember = "locationname";
            this.clnlocation1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.clnlocation1.HeaderText = "Pack Location";
            this.clnlocation1.Name = "clnlocation1";
            this.clnlocation1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnlocation1.ValueMember = "locationid";
            // 
            // clnlocation2
            // 
            this.clnlocation2.DataSource = this.tblpacklocationBindingSource1;
            this.clnlocation2.DisplayMember = "locationname";
            this.clnlocation2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.clnlocation2.HeaderText = "Optional Extra Location";
            this.clnlocation2.Name = "clnlocation2";
            this.clnlocation2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnlocation2.ValueMember = "locationid";
            this.clnlocation2.Visible = false;
            // 
            // clnclear
            // 
            this.clnclear.HeaderText = "Clear Extra Loc";
            this.clnclear.Name = "clnclear";
            this.clnclear.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnclear.Visible = false;
            this.clnclear.Width = 60;
            // 
            // clndelivery
            // 
            this.clndelivery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clndelivery.FalseValue = "False";
            this.clndelivery.HeaderText = "Delivery";
            this.clndelivery.Name = "clndelivery";
            this.clndelivery.TrueValue = "True";
            this.clndelivery.Width = 70;
            // 
            // cln5meds
            // 
            this.cln5meds.FalseValue = "False";
            this.cln5meds.HeaderText = "> 5 Meds";
            this.cln5meds.Name = "cln5meds";
            this.cln5meds.TrueValue = "True";
            this.cln5meds.Width = 75;
            // 
            // clnsigningsheet
            // 
            this.clnsigningsheet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clnsigningsheet.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnsigningsheet.FalseValue = "False";
            this.clnsigningsheet.HeaderText = "Signing Sheet";
            this.clnsigningsheet.Name = "clnsigningsheet";
            this.clnsigningsheet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnsigningsheet.TrueValue = "True";
            this.clnsigningsheet.Width = 60;
            // 
            // clnforcenext
            // 
            this.clnforcenext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clnforcenext.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnforcenext.FalseValue = "False";
            this.clnforcenext.HeaderText = "Force Cycle";
            this.clnforcenext.Name = "clnforcenext";
            this.clnforcenext.TrueValue = "True";
            this.clnforcenext.Width = 60;
            // 
            // clnpxcomment
            // 
            this.clnpxcomment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clnpxcomment.DefaultCellStyle = dataGridViewCellStyle5;
            this.clnpxcomment.HeaderText = "Comments";
            this.clnpxcomment.Name = "clnpxcomment";
            this.clnpxcomment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clncomwarn
            // 
            this.clncomwarn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clncomwarn.HeaderText = "Warn?";
            this.clncomwarn.Name = "clncomwarn";
            this.clncomwarn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clncomwarn.Width = 55;
            // 
            // clnpxid
            // 
            this.clnpxid.HeaderText = "PatientID";
            this.clnpxid.Name = "clnpxid";
            this.clnpxid.Visible = false;
            // 
            // clnactive
            // 
            this.clnactive.HeaderText = "Active";
            this.clnactive.Name = "clnactive";
            this.clnactive.Visible = false;
            // 
            // clnsuburb
            // 
            this.clnsuburb.HeaderText = "suburb";
            this.clnsuburb.Name = "clnsuburb";
            this.clnsuburb.Visible = false;
            // 
            // clnaddress
            // 
            this.clnaddress.HeaderText = "address";
            this.clnaddress.Name = "clnaddress";
            this.clnaddress.Visible = false;
            // 
            // clnmedicare
            // 
            this.clnmedicare.HeaderText = "medicare";
            this.clnmedicare.Name = "clnmedicare";
            this.clnmedicare.Visible = false;
            // 
            // clnrepatid
            // 
            this.clnrepatid.HeaderText = "repat";
            this.clnrepatid.Name = "clnrepatid";
            this.clnrepatid.Visible = false;
            // 
            // clnphonenumber
            // 
            this.clnphonenumber.HeaderText = "phone";
            this.clnphonenumber.Name = "clnphonenumber";
            this.clnphonenumber.Visible = false;
            // 
            // clndispenseid
            // 
            this.clndispenseid.HeaderText = "dispid";
            this.clndispenseid.Name = "clndispenseid";
            this.clndispenseid.Visible = false;
            // 
            // clninstitution
            // 
            this.clninstitution.HeaderText = "insti";
            this.clninstitution.Name = "clninstitution";
            this.clninstitution.Visible = false;
            // 
            // clnpostcode
            // 
            this.clnpostcode.HeaderText = "pcode";
            this.clnpostcode.Name = "clnpostcode";
            this.clnpostcode.Visible = false;
            // 
            // clninstitutionname
            // 
            this.clninstitutionname.HeaderText = "Institution";
            this.clninstitutionname.Name = "clninstitutionname";
            this.clninstitutionname.Visible = false;
            // 
            // frmpatientlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1330, 681);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridpatients);
            this.Controls.Add(this.background);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblbatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmpatientlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient List";
            this.Load += new System.EventHandler(this.frmpatientlist_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmpatientlist_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource1)).EndInit();
            this.background.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.BindingSource webbitdbdatasetBindingSource;
        private webbitdbdataset webbitdbdataset;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private System.Windows.Forms.BindingSource tblpacksizeBindingSource;
        private webbitdbdatasetTableAdapters.tblpacksizeTableAdapter tblpacksizeTableAdapter;
        private System.Windows.Forms.BindingSource tblcycleBindingSource;
        private webbitdbdatasetTableAdapters.tblcycleTableAdapter tblcycleTableAdapter;
        private System.Windows.Forms.BindingSource tblpacklocationBindingSource;
        private webbitdbdatasetTableAdapters.tblpacklocationTableAdapter tblpacklocationTableAdapter;
        private webbitdbdatasetTableAdapters.tblpatientTableAdapter tblpatientTableAdapter;
        private System.Windows.Forms.BindingSource tblpacklocationBindingSource1;
        private System.Windows.Forms.BindingSource tblcycleBindingSource1;
        private System.Windows.Forms.BindingSource tblpacklocationBindingSource2;
        private System.Windows.Forms.BindingSource tblpacksizeBindingSource1;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkSignSheet;
        private System.Windows.Forms.CheckBox chkDelivery;
        private System.Windows.Forms.CheckBox chkallow2loc;
        private System.Windows.Forms.ComboBox cmbcycle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbatchupdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkselectall;
        private System.Windows.Forms.Label lblbatch;
        private System.Windows.Forms.ComboBox cmblocation;
        private System.Windows.Forms.ComboBox cmbsize;
        private System.Windows.Forms.DataGridView dataGridpatients;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnselected;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnlastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnfirstname;
        private System.Windows.Forms.DataGridViewComboBoxColumn clnpacksize;
        private System.Windows.Forms.DataGridViewComboBoxColumn clncycletype;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpackscollect;
        private System.Windows.Forms.DataGridViewComboBoxColumn clnlocation1;
        private System.Windows.Forms.DataGridViewComboBoxColumn clnlocation2;
        private System.Windows.Forms.DataGridViewButtonColumn clnclear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clndelivery;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cln5meds;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnsigningsheet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnforcenext;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpxcomment;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clncomwarn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpxid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnsuburb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnmedicare;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnrepatid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnphonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clndispenseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clninstitution;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpostcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clninstitutionname;
    }
}

