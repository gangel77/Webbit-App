namespace PackChecker
{
    partial class frmcollecting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcollecting));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpatientname = new System.Windows.Forms.Label();
            this.lblloc1 = new System.Windows.Forms.Label();
            this.pnlloc1 = new System.Windows.Forms.Panel();
            this.lblpackscollect = new System.Windows.Forms.Label();
            this.pnlloc2 = new System.Windows.Forms.Panel();
            this.lblloc2 = new System.Windows.Forms.Label();
            this.lblwarning = new System.Windows.Forms.Label();
            this.lblpklocation = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnshownonpacked = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnmessage = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridcollect = new System.Windows.Forms.DataGridView();
            this.packid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCycleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpatientnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpacked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnchecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clngivenoutby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncollectedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncollectdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCollect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnreversecheck = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlkey = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblcycledes = new System.Windows.Forms.Label();
            this.pnlloc1.SuspendLayout();
            this.pnlloc2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcollect)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlkey.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblusername.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.lblusername.Location = new System.Drawing.Point(239, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(148, 30);
            this.lblusername.TabIndex = 5;
            this.lblusername.Text = "Current User";
            // 
            // lblpatientname
            // 
            this.lblpatientname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblpatientname.Font = new System.Drawing.Font("Myriad Pro", 34F, System.Drawing.FontStyle.Bold);
            this.lblpatientname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.lblpatientname.Location = new System.Drawing.Point(20, 4);
            this.lblpatientname.Name = "lblpatientname";
            this.lblpatientname.Size = new System.Drawing.Size(579, 74);
            this.lblpatientname.TabIndex = 0;
            this.lblpatientname.Text = "pxname";
            this.lblpatientname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblpatientname.Click += new System.EventHandler(this.lblpatientname_Click);
            // 
            // lblloc1
            // 
            this.lblloc1.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lblloc1.Location = new System.Drawing.Point(0, 8);
            this.lblloc1.Name = "lblloc1";
            this.lblloc1.Size = new System.Drawing.Size(97, 28);
            this.lblloc1.TabIndex = 0;
            this.lblloc1.Text = "location";
            this.lblloc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlloc1
            // 
            this.pnlloc1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlloc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.pnlloc1.Controls.Add(this.lblloc1);
            this.pnlloc1.Location = new System.Drawing.Point(148, 45);
            this.pnlloc1.Name = "pnlloc1";
            this.pnlloc1.Size = new System.Drawing.Size(100, 45);
            this.pnlloc1.TabIndex = 1;
            // 
            // lblpackscollect
            // 
            this.lblpackscollect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblpackscollect.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpackscollect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.lblpackscollect.Location = new System.Drawing.Point(21, 78);
            this.lblpackscollect.Name = "lblpackscollect";
            this.lblpackscollect.Size = new System.Drawing.Size(579, 38);
            this.lblpackscollect.TabIndex = 12;
            this.lblpackscollect.Text = "packscollect";
            this.lblpackscollect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblpackscollect.Click += new System.EventHandler(this.lblpackscollect_Click);
            // 
            // pnlloc2
            // 
            this.pnlloc2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlloc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.pnlloc2.Controls.Add(this.lblloc2);
            this.pnlloc2.Location = new System.Drawing.Point(148, 96);
            this.pnlloc2.Name = "pnlloc2";
            this.pnlloc2.Size = new System.Drawing.Size(100, 45);
            this.pnlloc2.TabIndex = 2;
            this.pnlloc2.Visible = false;
            // 
            // lblloc2
            // 
            this.lblloc2.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lblloc2.Location = new System.Drawing.Point(0, 3);
            this.lblloc2.Name = "lblloc2";
            this.lblloc2.Size = new System.Drawing.Size(97, 42);
            this.lblloc2.TabIndex = 0;
            this.lblloc2.Text = "LOC2";
            this.lblloc2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Location = new System.Drawing.Point(694, 533);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(58, 13);
            this.lblwarning.TabIndex = 14;
            this.lblwarning.Text = "locwarning";
            this.lblwarning.Visible = false;
            // 
            // lblpklocation
            // 
            this.lblpklocation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblpklocation.Font = new System.Drawing.Font("Myriad Pro", 16F, System.Drawing.FontStyle.Bold);
            this.lblpklocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.lblpklocation.Location = new System.Drawing.Point(26, 53);
            this.lblpklocation.Name = "lblpklocation";
            this.lblpklocation.Size = new System.Drawing.Size(116, 27);
            this.lblpklocation.TabIndex = 15;
            this.lblpklocation.Text = "Location:";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.pnlloc1;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.pnlloc2;
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 10;
            this.btnClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 10;
            this.btnClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnClose.IdleForecolor = System.Drawing.Color.White;
            this.btnClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnClose.Location = new System.Drawing.Point(502, 509);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 54);
            this.btnClose.TabIndex = 19;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnshownonpacked
            // 
            this.btnshownonpacked.ActiveBorderThickness = 1;
            this.btnshownonpacked.ActiveCornerRadius = 10;
            this.btnshownonpacked.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnshownonpacked.ActiveForecolor = System.Drawing.Color.White;
            this.btnshownonpacked.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnshownonpacked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnshownonpacked.AutoSize = true;
            this.btnshownonpacked.BackColor = System.Drawing.Color.White;
            this.btnshownonpacked.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnshownonpacked.BackgroundImage")));
            this.btnshownonpacked.ButtonText = "Show Packing Queue";
            this.btnshownonpacked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshownonpacked.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshownonpacked.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnshownonpacked.IdleBorderThickness = 1;
            this.btnshownonpacked.IdleCornerRadius = 10;
            this.btnshownonpacked.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnshownonpacked.IdleForecolor = System.Drawing.Color.White;
            this.btnshownonpacked.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnshownonpacked.Location = new System.Drawing.Point(21, 507);
            this.btnshownonpacked.Margin = new System.Windows.Forms.Padding(5);
            this.btnshownonpacked.Name = "btnshownonpacked";
            this.btnshownonpacked.Size = new System.Drawing.Size(225, 53);
            this.btnshownonpacked.TabIndex = 18;
            this.btnshownonpacked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnshownonpacked.Click += new System.EventHandler(this.btnshownonpacked_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::PackChecker.Properties.Resources.icon_user;
            this.pictureBox1.Location = new System.Drawing.Point(204, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnmessage
            // 
            this.btnmessage.ActiveBorderThickness = 1;
            this.btnmessage.ActiveCornerRadius = 10;
            this.btnmessage.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(123)))), ((int)(((byte)(142)))));
            this.btnmessage.ActiveForecolor = System.Drawing.Color.White;
            this.btnmessage.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(123)))), ((int)(((byte)(142)))));
            this.btnmessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmessage.AutoSize = true;
            this.btnmessage.BackColor = System.Drawing.Color.White;
            this.btnmessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmessage.BackgroundImage")));
            this.btnmessage.ButtonText = "Send Message to Packer";
            this.btnmessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmessage.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmessage.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnmessage.IdleBorderThickness = 1;
            this.btnmessage.IdleCornerRadius = 10;
            this.btnmessage.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.btnmessage.IdleForecolor = System.Drawing.Color.White;
            this.btnmessage.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.btnmessage.Location = new System.Drawing.Point(820, 507);
            this.btnmessage.Margin = new System.Windows.Forms.Padding(5);
            this.btnmessage.Name = "btnmessage";
            this.btnmessage.Size = new System.Drawing.Size(225, 53);
            this.btnmessage.TabIndex = 20;
            this.btnmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnmessage.Click += new System.EventHandler(this.btnmessage_Click);
            // 
            // dataGridcollect
            // 
            this.dataGridcollect.AllowUserToAddRows = false;
            this.dataGridcollect.AllowUserToDeleteRows = false;
            this.dataGridcollect.AllowUserToResizeColumns = false;
            this.dataGridcollect.AllowUserToResizeRows = false;
            this.dataGridcollect.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridcollect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridcollect.ColumnHeadersHeight = 56;
            this.dataGridcollect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packid,
            this.clnCycleDate,
            this.clnpatientnote,
            this.clnpacked,
            this.clnchecked,
            this.clngivenoutby,
            this.clncollectedby,
            this.clncollectdate,
            this.clnCollect,
            this.clnreversecheck});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridcollect.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridcollect.EnableHeadersVisualStyles = false;
            this.dataGridcollect.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.dataGridcollect.Location = new System.Drawing.Point(22, 166);
            this.dataGridcollect.MultiSelect = false;
            this.dataGridcollect.Name = "dataGridcollect";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridcollect.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridcollect.RowHeadersVisible = false;
            this.dataGridcollect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridcollect.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridcollect.RowTemplate.Height = 25;
            this.dataGridcollect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridcollect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridcollect.Size = new System.Drawing.Size(1023, 324);
            this.dataGridcollect.TabIndex = 21;
            this.dataGridcollect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChecked_CellContentClick);
            this.dataGridcollect.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridcollect_CellPainting);
            this.dataGridcollect.SelectionChanged += new System.EventHandler(this.dataGridcollect_SelectionChanged_1);
            // 
            // packid
            // 
            this.packid.HeaderText = "packid";
            this.packid.MinimumWidth = 55;
            this.packid.Name = "packid";
            this.packid.Visible = false;
            this.packid.Width = 55;
            // 
            // clnCycleDate
            // 
            this.clnCycleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnCycleDate.FillWeight = 50F;
            this.clnCycleDate.HeaderText = "Cycle Date";
            this.clnCycleDate.Name = "clnCycleDate";
            this.clnCycleDate.ReadOnly = true;
            this.clnCycleDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnCycleDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnpatientnote
            // 
            this.clnpatientnote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clnpatientnote.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnpatientnote.FillWeight = 50F;
            this.clnpatientnote.HeaderText = "Patient Note";
            this.clnpatientnote.Name = "clnpatientnote";
            this.clnpatientnote.ReadOnly = true;
            this.clnpatientnote.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnpatientnote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnpacked
            // 
            this.clnpacked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnpacked.HeaderText = "Packed";
            this.clnpacked.Name = "clnpacked";
            this.clnpacked.ReadOnly = true;
            this.clnpacked.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnpacked.Visible = false;
            this.clnpacked.Width = 68;
            // 
            // clnchecked
            // 
            this.clnchecked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnchecked.HeaderText = "Checked";
            this.clnchecked.Name = "clnchecked";
            this.clnchecked.ReadOnly = true;
            this.clnchecked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnchecked.Visible = false;
            this.clnchecked.Width = 78;
            // 
            // clngivenoutby
            // 
            this.clngivenoutby.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clngivenoutby.DefaultCellStyle = dataGridViewCellStyle3;
            this.clngivenoutby.HeaderText = "Served By";
            this.clngivenoutby.Name = "clngivenoutby";
            this.clngivenoutby.ReadOnly = true;
            this.clngivenoutby.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clngivenoutby.Width = 78;
            // 
            // clncollectedby
            // 
            this.clncollectedby.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clncollectedby.DefaultCellStyle = dataGridViewCellStyle4;
            this.clncollectedby.HeaderText = "Collected By";
            this.clncollectedby.Name = "clncollectedby";
            this.clncollectedby.ReadOnly = true;
            this.clncollectedby.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncollectedby.Width = 93;
            // 
            // clncollectdate
            // 
            this.clncollectdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clncollectdate.HeaderText = "Collect Date";
            this.clncollectdate.MinimumWidth = 120;
            this.clncollectdate.Name = "clncollectdate";
            this.clncollectdate.ReadOnly = true;
            this.clncollectdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncollectdate.Width = 120;
            // 
            // clnCollect
            // 
            this.clnCollect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnCollect.HeaderText = "Collect";
            this.clnCollect.Name = "clnCollect";
            this.clnCollect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnCollect.Width = 63;
            // 
            // clnreversecheck
            // 
            this.clnreversecheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnreversecheck.HeaderText = "Undo";
            this.clnreversecheck.Name = "clnreversecheck";
            this.clnreversecheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnreversecheck.Width = 54;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlloc1);
            this.panel1.Controls.Add(this.lblpklocation);
            this.panel1.Controls.Add(this.pnlloc2);
            this.panel1.Location = new System.Drawing.Point(794, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 149);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lblusername);
            this.panel3.Location = new System.Drawing.Point(-136, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 39);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.panel2.Location = new System.Drawing.Point(3, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 15);
            this.panel2.TabIndex = 23;
            // 
            // pnlkey
            // 
            this.pnlkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlkey.Controls.Add(this.label2);
            this.pnlkey.Controls.Add(this.label1);
            this.pnlkey.Controls.Add(this.panel4);
            this.pnlkey.Controls.Add(this.panel2);
            this.pnlkey.Location = new System.Drawing.Point(254, 511);
            this.pnlkey.Name = "pnlkey";
            this.pnlkey.Size = new System.Drawing.Size(167, 44);
            this.pnlkey.TabIndex = 24;
            this.pnlkey.Visible = false;
            this.pnlkey.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Not Checked";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(22, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Not Packed";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(123)))), ((int)(((byte)(142)))));
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 15);
            this.panel4.TabIndex = 24;
            // 
            // lblcycledes
            // 
            this.lblcycledes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcycledes.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcycledes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.lblcycledes.Location = new System.Drawing.Point(21, 116);
            this.lblcycledes.Name = "lblcycledes";
            this.lblcycledes.Size = new System.Drawing.Size(579, 38);
            this.lblcycledes.TabIndex = 25;
            this.lblcycledes.Text = "packscollect";
            this.lblcycledes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblcycledes.Click += new System.EventHandler(this.lblcycledes_Click);
            // 
            // frmcollecting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 574);
            this.Controls.Add(this.lblcycledes);
            this.Controls.Add(this.pnlkey);
            this.Controls.Add(this.dataGridcollect);
            this.Controls.Add(this.btnmessage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnshownonpacked);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.lblpackscollect);
            this.Controls.Add(this.lblpatientname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcollecting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pack Collections";
            this.Load += new System.EventHandler(this.frmchecking_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmcollecting_Paint);
            this.pnlloc1.ResumeLayout(false);
            this.pnlloc2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcollect)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlkey.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpatientname;
        private System.Windows.Forms.Label lblloc1;
        private System.Windows.Forms.Panel pnlloc1;
        private System.Windows.Forms.Label lblpackscollect;
        private System.Windows.Forms.Panel pnlloc2;
        private System.Windows.Forms.Label lblloc2;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.Label lblpklocation;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnshownonpacked;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnmessage;
        private System.Windows.Forms.DataGridView dataGridcollect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlkey;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn packid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCycleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpatientnote;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnpacked;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnchecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn clngivenoutby;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncollectedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncollectdate;
        private System.Windows.Forms.DataGridViewButtonColumn clnCollect;
        private System.Windows.Forms.DataGridViewButtonColumn clnreversecheck;
        private System.Windows.Forms.Label lblcycledes;
        private System.Windows.Forms.Panel panel3;
    }
}

