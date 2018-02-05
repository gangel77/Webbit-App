namespace PackChecker
{
    partial class frmreports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreports));
            this.rptpatientlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptcountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radiopxlist = new System.Windows.Forms.RadioButton();
            this.radioreportgroup = new System.Windows.Forms.GroupBox();
            this.radiodeactivated = new System.Windows.Forms.RadioButton();
            this.radioqcpp = new System.Windows.Forms.RadioButton();
            this.radiographcounts = new System.Windows.Forms.RadioButton();
            this.radiocounts = new System.Windows.Forms.RadioButton();
            this.radiopklist = new System.Windows.Forms.RadioButton();
            this.packsperpxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblstartdate = new System.Windows.Forms.Label();
            this.cmbpatient = new System.Windows.Forms.ComboBox();
            this.lblenddate = new System.Windows.Forms.Label();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.dateend = new System.Windows.Forms.DateTimePicker();
            this.lblpx = new System.Windows.Forms.Label();
            this.groupoptions = new System.Windows.Forms.GroupBox();
            this.chkactive = new System.Windows.Forms.CheckBox();
            this.btnclear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnthisyear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnthismonth = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblpacktype = new System.Windows.Forms.Label();
            this.cmbclaimable = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btngeneratereport = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.webbitdbdataset = new PackChecker.webbitdbdataset();
            this.rptpatientlistTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.rptpatientlistTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbcycles = new System.Windows.Forms.ComboBox();
            this.lblcycle = new System.Windows.Forms.Label();
            this.radiocyclecheck = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.rptpatientlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptcountsBindingSource)).BeginInit();
            this.radioreportgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packsperpxBindingSource)).BeginInit();
            this.groupoptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "rptpatient";
            reportDataSource1.Value = this.rptpatientlistBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PackChecker.rptpatientlist.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(203, 126);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(761, 462);
            this.reportViewer1.TabIndex = 0;
            // 
            // radiopxlist
            // 
            this.radiopxlist.AutoSize = true;
            this.radiopxlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.radiopxlist.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiopxlist.Location = new System.Drawing.Point(8, 21);
            this.radiopxlist.Name = "radiopxlist";
            this.radiopxlist.Size = new System.Drawing.Size(85, 20);
            this.radiopxlist.TabIndex = 7;
            this.radiopxlist.TabStop = true;
            this.radiopxlist.Text = "Patient List";
            this.radiopxlist.UseVisualStyleBackColor = false;
            this.radiopxlist.CheckedChanged += new System.EventHandler(this.radiopxlist_CheckedChanged);
            // 
            // radioreportgroup
            // 
            this.radioreportgroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.radioreportgroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.radioreportgroup.Controls.Add(this.radiocyclecheck);
            this.radioreportgroup.Controls.Add(this.radiodeactivated);
            this.radioreportgroup.Controls.Add(this.radioqcpp);
            this.radioreportgroup.Controls.Add(this.radiographcounts);
            this.radioreportgroup.Controls.Add(this.radiocounts);
            this.radioreportgroup.Controls.Add(this.radiopklist);
            this.radioreportgroup.Controls.Add(this.radiopxlist);
            this.radioreportgroup.Font = new System.Drawing.Font("Myriad Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioreportgroup.Location = new System.Drawing.Point(12, 156);
            this.radioreportgroup.Margin = new System.Windows.Forms.Padding(0);
            this.radioreportgroup.Name = "radioreportgroup";
            this.radioreportgroup.Padding = new System.Windows.Forms.Padding(0);
            this.radioreportgroup.Size = new System.Drawing.Size(173, 175);
            this.radioreportgroup.TabIndex = 8;
            this.radioreportgroup.TabStop = false;
            this.radioreportgroup.Text = "Report List";
            // 
            // radiodeactivated
            // 
            this.radiodeactivated.AutoSize = true;
            this.radiodeactivated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.radiodeactivated.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiodeactivated.Location = new System.Drawing.Point(8, 105);
            this.radiodeactivated.Name = "radiodeactivated";
            this.radiodeactivated.Size = new System.Drawing.Size(124, 20);
            this.radiodeactivated.TabIndex = 12;
            this.radiodeactivated.TabStop = true;
            this.radiodeactivated.Text = "Deactivated Packs";
            this.radiodeactivated.UseVisualStyleBackColor = false;
            this.radiodeactivated.CheckedChanged += new System.EventHandler(this.radiodeactivated_CheckedChanged);
            // 
            // radioqcpp
            // 
            this.radioqcpp.AutoSize = true;
            this.radioqcpp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.radioqcpp.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioqcpp.Location = new System.Drawing.Point(8, 147);
            this.radioqcpp.Name = "radioqcpp";
            this.radioqcpp.Size = new System.Drawing.Size(141, 20);
            this.radioqcpp.TabIndex = 11;
            this.radioqcpp.TabStop = true;
            this.radioqcpp.Text = "6CPA Monthly Report";
            this.radioqcpp.UseVisualStyleBackColor = false;
            this.radioqcpp.CheckedChanged += new System.EventHandler(this.radioqcpp_CheckedChanged);
            // 
            // radiographcounts
            // 
            this.radiographcounts.AutoSize = true;
            this.radiographcounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.radiographcounts.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiographcounts.Location = new System.Drawing.Point(8, 84);
            this.radiographcounts.Name = "radiographcounts";
            this.radiographcounts.Size = new System.Drawing.Size(117, 20);
            this.radiographcounts.TabIndex = 10;
            this.radiographcounts.TabStop = true;
            this.radiographcounts.Text = "Packing Timeline";
            this.radiographcounts.UseVisualStyleBackColor = false;
            this.radiographcounts.CheckedChanged += new System.EventHandler(this.radiographcounts_CheckedChanged);
            // 
            // radiocounts
            // 
            this.radiocounts.AutoSize = true;
            this.radiocounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.radiocounts.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiocounts.Location = new System.Drawing.Point(8, 63);
            this.radiocounts.Name = "radiocounts";
            this.radiocounts.Size = new System.Drawing.Size(78, 20);
            this.radiocounts.TabIndex = 9;
            this.radiocounts.TabStop = true;
            this.radiocounts.Text = "Staff Stats";
            this.radiocounts.UseVisualStyleBackColor = false;
            this.radiocounts.CheckedChanged += new System.EventHandler(this.radiocounts_CheckedChanged);
            // 
            // radiopklist
            // 
            this.radiopklist.AutoSize = true;
            this.radiopklist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.radiopklist.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiopklist.Location = new System.Drawing.Point(8, 42);
            this.radiopklist.Name = "radiopklist";
            this.radiopklist.Size = new System.Drawing.Size(72, 20);
            this.radiopklist.TabIndex = 8;
            this.radiopklist.TabStop = true;
            this.radiopklist.Text = "Pack List";
            this.radiopklist.UseVisualStyleBackColor = false;
            this.radiopklist.CheckedChanged += new System.EventHandler(this.radiopklist_CheckedChanged);
            // 
            // lblstartdate
            // 
            this.lblstartdate.AutoSize = true;
            this.lblstartdate.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstartdate.ForeColor = System.Drawing.Color.Black;
            this.lblstartdate.Location = new System.Drawing.Point(465, 20);
            this.lblstartdate.Name = "lblstartdate";
            this.lblstartdate.Size = new System.Drawing.Size(148, 19);
            this.lblstartdate.TabIndex = 11;
            this.lblstartdate.Text = "Cycle Dates between";
            // 
            // cmbpatient
            // 
            this.cmbpatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbpatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbpatient.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpatient.FormattingEnabled = true;
            this.cmbpatient.Location = new System.Drawing.Point(108, 17);
            this.cmbpatient.Name = "cmbpatient";
            this.cmbpatient.Size = new System.Drawing.Size(232, 24);
            this.cmbpatient.TabIndex = 15;
            this.cmbpatient.Visible = false;
            // 
            // lblenddate
            // 
            this.lblenddate.AutoSize = true;
            this.lblenddate.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenddate.ForeColor = System.Drawing.Color.Black;
            this.lblenddate.Location = new System.Drawing.Point(577, 54);
            this.lblenddate.Name = "lblenddate";
            this.lblenddate.Size = new System.Drawing.Size(35, 19);
            this.lblenddate.TabIndex = 12;
            this.lblenddate.Text = "and";
            // 
            // datestart
            // 
            this.datestart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datestart.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlLight;
            this.datestart.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datestart.Location = new System.Drawing.Point(618, 18);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(218, 23);
            this.datestart.TabIndex = 9;
            this.datestart.Visible = false;
            // 
            // dateend
            // 
            this.dateend.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateend.Location = new System.Drawing.Point(618, 51);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(218, 23);
            this.dateend.TabIndex = 13;
            this.dateend.Visible = false;
            // 
            // lblpx
            // 
            this.lblpx.AutoSize = true;
            this.lblpx.Font = new System.Drawing.Font("Myriad Pro", 14F, System.Drawing.FontStyle.Underline);
            this.lblpx.ForeColor = System.Drawing.Color.Black;
            this.lblpx.Location = new System.Drawing.Point(29, 17);
            this.lblpx.Name = "lblpx";
            this.lblpx.Size = new System.Drawing.Size(70, 23);
            this.lblpx.TabIndex = 17;
            this.lblpx.Text = "Patient:";
            // 
            // groupoptions
            // 
            this.groupoptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupoptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.groupoptions.Controls.Add(this.lblcycle);
            this.groupoptions.Controls.Add(this.cmbcycles);
            this.groupoptions.Controls.Add(this.chkactive);
            this.groupoptions.Controls.Add(this.btnclear);
            this.groupoptions.Controls.Add(this.btnthisyear);
            this.groupoptions.Controls.Add(this.btnthismonth);
            this.groupoptions.Controls.Add(this.lblpacktype);
            this.groupoptions.Controls.Add(this.cmbclaimable);
            this.groupoptions.Controls.Add(this.lblpx);
            this.groupoptions.Controls.Add(this.dateend);
            this.groupoptions.Controls.Add(this.datestart);
            this.groupoptions.Controls.Add(this.lblenddate);
            this.groupoptions.Controls.Add(this.cmbpatient);
            this.groupoptions.Controls.Add(this.lblstartdate);
            this.groupoptions.Font = new System.Drawing.Font("Myriad Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupoptions.Location = new System.Drawing.Point(121, 19);
            this.groupoptions.Name = "groupoptions";
            this.groupoptions.Size = new System.Drawing.Size(843, 103);
            this.groupoptions.TabIndex = 14;
            this.groupoptions.TabStop = false;
            this.groupoptions.Text = "Options";
            // 
            // chkactive
            // 
            this.chkactive.AutoSize = true;
            this.chkactive.Checked = true;
            this.chkactive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkactive.Location = new System.Drawing.Point(108, 47);
            this.chkactive.Name = "chkactive";
            this.chkactive.Size = new System.Drawing.Size(120, 17);
            this.chkactive.TabIndex = 22;
            this.chkactive.Text = "Active Patients Only";
            this.chkactive.UseVisualStyleBackColor = true;
            this.chkactive.CheckedChanged += new System.EventHandler(this.chkactive_CheckedChanged);
            // 
            // btnclear
            // 
            this.btnclear.ActiveBorderThickness = 1;
            this.btnclear.ActiveCornerRadius = 5;
            this.btnclear.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclear.ActiveForecolor = System.Drawing.Color.White;
            this.btnclear.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.btnclear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclear.BackgroundImage")));
            this.btnclear.ButtonText = "All Patients";
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.Font = new System.Drawing.Font("Myriad Pro", 8.25F);
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.IdleBorderThickness = 1;
            this.btnclear.IdleCornerRadius = 5;
            this.btnclear.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclear.IdleForecolor = System.Drawing.Color.White;
            this.btnclear.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclear.Location = new System.Drawing.Point(344, 15);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(84, 27);
            this.btnclear.TabIndex = 21;
            this.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnthisyear
            // 
            this.btnthisyear.ActiveBorderThickness = 1;
            this.btnthisyear.ActiveCornerRadius = 5;
            this.btnthisyear.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnthisyear.ActiveForecolor = System.Drawing.Color.White;
            this.btnthisyear.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnthisyear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.btnthisyear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthisyear.BackgroundImage")));
            this.btnthisyear.ButtonText = "This  Year";
            this.btnthisyear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthisyear.Font = new System.Drawing.Font("Myriad Pro", 8.25F);
            this.btnthisyear.ForeColor = System.Drawing.Color.White;
            this.btnthisyear.IdleBorderThickness = 1;
            this.btnthisyear.IdleCornerRadius = 5;
            this.btnthisyear.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnthisyear.IdleForecolor = System.Drawing.Color.White;
            this.btnthisyear.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnthisyear.Location = new System.Drawing.Point(739, 75);
            this.btnthisyear.Name = "btnthisyear";
            this.btnthisyear.Size = new System.Drawing.Size(97, 27);
            this.btnthisyear.TabIndex = 20;
            this.btnthisyear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthisyear.Click += new System.EventHandler(this.btnthisyear_Click);
            // 
            // btnthismonth
            // 
            this.btnthismonth.ActiveBorderThickness = 1;
            this.btnthismonth.ActiveCornerRadius = 5;
            this.btnthismonth.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnthismonth.ActiveForecolor = System.Drawing.Color.White;
            this.btnthismonth.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnthismonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.btnthismonth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthismonth.BackgroundImage")));
            this.btnthismonth.ButtonText = "This  Month";
            this.btnthismonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthismonth.Font = new System.Drawing.Font("Myriad Pro", 8.25F);
            this.btnthismonth.ForeColor = System.Drawing.Color.White;
            this.btnthismonth.IdleBorderThickness = 1;
            this.btnthismonth.IdleCornerRadius = 5;
            this.btnthismonth.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnthismonth.IdleForecolor = System.Drawing.Color.White;
            this.btnthismonth.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnthismonth.Location = new System.Drawing.Point(618, 75);
            this.btnthismonth.Name = "btnthismonth";
            this.btnthismonth.Size = new System.Drawing.Size(97, 27);
            this.btnthismonth.TabIndex = 17;
            this.btnthismonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthismonth.Click += new System.EventHandler(this.btnthismonth_Click);
            // 
            // lblpacktype
            // 
            this.lblpacktype.AutoSize = true;
            this.lblpacktype.Font = new System.Drawing.Font("Myriad Pro", 14F, System.Drawing.FontStyle.Underline);
            this.lblpacktype.ForeColor = System.Drawing.Color.Black;
            this.lblpacktype.Location = new System.Drawing.Point(6, 75);
            this.lblpacktype.Name = "lblpacktype";
            this.lblpacktype.Size = new System.Drawing.Size(92, 23);
            this.lblpacktype.TabIndex = 19;
            this.lblpacktype.Text = "Pack Type:";
            // 
            // cmbclaimable
            // 
            this.cmbclaimable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbclaimable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbclaimable.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbclaimable.FormattingEnabled = true;
            this.cmbclaimable.Items.AddRange(new object[] {
            "All",
            "Claimable",
            "Non Claimable"});
            this.cmbclaimable.Location = new System.Drawing.Point(107, 73);
            this.cmbclaimable.Name = "cmbclaimable";
            this.cmbclaimable.Size = new System.Drawing.Size(232, 24);
            this.cmbclaimable.TabIndex = 18;
            this.cmbclaimable.Visible = false;
            this.cmbclaimable.SelectedIndexChanged += new System.EventHandler(this.cmbclaimable_SelectedIndexChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.groupoptions;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.radioreportgroup;
            // 
            // btngeneratereport
            // 
            this.btngeneratereport.ActiveBorderThickness = 1;
            this.btngeneratereport.ActiveCornerRadius = 10;
            this.btngeneratereport.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btngeneratereport.ActiveForecolor = System.Drawing.Color.White;
            this.btngeneratereport.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btngeneratereport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.btngeneratereport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngeneratereport.BackgroundImage")));
            this.btngeneratereport.ButtonText = "Create Report";
            this.btngeneratereport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngeneratereport.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeneratereport.ForeColor = System.Drawing.Color.White;
            this.btngeneratereport.IdleBorderThickness = 1;
            this.btngeneratereport.IdleCornerRadius = 10;
            this.btngeneratereport.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btngeneratereport.IdleForecolor = System.Drawing.Color.White;
            this.btngeneratereport.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btngeneratereport.Location = new System.Drawing.Point(12, 364);
            this.btngeneratereport.Margin = new System.Windows.Forms.Padding(5);
            this.btngeneratereport.Name = "btngeneratereport";
            this.btngeneratereport.Size = new System.Drawing.Size(183, 58);
            this.btngeneratereport.TabIndex = 16;
            this.btngeneratereport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btngeneratereport.Click += new System.EventHandler(this.btngeneratereport_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this;
            // 
            // webbitdbdataset
            // 
            this.webbitdbdataset.DataSetName = "webbitdbdataset";
            this.webbitdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptpatientlistTableAdapter
            // 
            this.rptpatientlistTableAdapter.ClearBeforeFill = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // cmbcycles
            // 
            this.cmbcycles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbcycles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbcycles.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcycles.FormattingEnabled = true;
            this.cmbcycles.Items.AddRange(new object[] {
            "All",
            "Claimable",
            "Non Claimable"});
            this.cmbcycles.Location = new System.Drawing.Point(619, 17);
            this.cmbcycles.Name = "cmbcycles";
            this.cmbcycles.Size = new System.Drawing.Size(177, 24);
            this.cmbcycles.TabIndex = 23;
            this.cmbcycles.Visible = false;
            // 
            // lblcycle
            // 
            this.lblcycle.AutoSize = true;
            this.lblcycle.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcycle.ForeColor = System.Drawing.Color.Black;
            this.lblcycle.Location = new System.Drawing.Point(555, 20);
            this.lblcycle.Name = "lblcycle";
            this.lblcycle.Size = new System.Drawing.Size(48, 19);
            this.lblcycle.TabIndex = 24;
            this.lblcycle.Text = "Cycle:";
            this.lblcycle.Visible = false;
            // 
            // radiocyclecheck
            // 
            this.radiocyclecheck.AutoSize = true;
            this.radiocyclecheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.radiocyclecheck.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiocyclecheck.Location = new System.Drawing.Point(8, 126);
            this.radiocyclecheck.Name = "radiocyclecheck";
            this.radiocyclecheck.Size = new System.Drawing.Size(114, 20);
            this.radiocyclecheck.TabIndex = 13;
            this.radiocyclecheck.TabStop = true;
            this.radiocyclecheck.Text = "Cycle Evaluation";
            this.radiocyclecheck.UseVisualStyleBackColor = false;
            this.radiocyclecheck.CheckedChanged += new System.EventHandler(this.radiocyclecheck_CheckedChanged);
            // 
            // frmreports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.btngeneratereport);
            this.Controls.Add(this.radioreportgroup);
            this.Controls.Add(this.groupoptions);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmreports";
            this.Size = new System.Drawing.Size(975, 600);
            this.Load += new System.EventHandler(this.frmreports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rptpatientlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptcountsBindingSource)).EndInit();
            this.radioreportgroup.ResumeLayout(false);
            this.radioreportgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packsperpxBindingSource)).EndInit();
            this.groupoptions.ResumeLayout(false);
            this.groupoptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rptpatientlistBindingSource;
        private System.Windows.Forms.RadioButton radiopxlist;
        private System.Windows.Forms.GroupBox radioreportgroup;
        private System.Windows.Forms.RadioButton radiopklist;
        private System.Windows.Forms.BindingSource packsperpxBindingSource;
        private System.Windows.Forms.BindingSource rptcountsBindingSource;
        private System.Windows.Forms.RadioButton radiocounts;
        private System.Windows.Forms.RadioButton radiographcounts;
        private System.Windows.Forms.RadioButton radioqcpp;
        private Bunifu.Framework.UI.BunifuThinButton2 btngeneratereport;
        private System.Windows.Forms.Label lblstartdate;
        private System.Windows.Forms.ComboBox cmbpatient;
        private System.Windows.Forms.Label lblenddate;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.Label lblpx;
        private System.Windows.Forms.GroupBox groupoptions;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.RadioButton radiodeactivated;
        private System.Windows.Forms.Label lblpacktype;
        private System.Windows.Forms.ComboBox cmbclaimable;
        private webbitdbdataset webbitdbdataset;
        private webbitdbdatasetTableAdapters.rptpatientlistTableAdapter rptpatientlistTableAdapter;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclear;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthisyear;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthismonth;
        private System.Windows.Forms.CheckBox chkactive;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbcycles;
        private System.Windows.Forms.Label lblcycle;
        private System.Windows.Forms.RadioButton radiocyclecheck;
    }
}