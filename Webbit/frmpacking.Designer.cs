namespace PackChecker
{
    partial class frmpacking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpacking));
            this.dataGridPacked = new System.Windows.Forms.DataGridView();
            this.packid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnweekid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pxname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCycleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpacksize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPackComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpackeduser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpack = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnreversepack = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btndeactivate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tblpackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webbitdbdataset = new PackChecker.webbitdbdataset();
            this.webbitdbdatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpackTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblpackTableAdapter();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblcountnotcycle = new System.Windows.Forms.Label();
            this.pnlkey = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdatasetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlkey.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPacked
            // 
            this.dataGridPacked.AllowUserToAddRows = false;
            this.dataGridPacked.AllowUserToDeleteRows = false;
            this.dataGridPacked.AllowUserToResizeColumns = false;
            this.dataGridPacked.AllowUserToResizeRows = false;
            this.dataGridPacked.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridPacked.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPacked.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridPacked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packid,
            this.clnweekid,
            this.clnactive,
            this.pxname,
            this.clnCycleDate,
            this.clnpacksize,
            this.clncode,
            this.clnPackComment,
            this.clnpackeduser,
            this.clnpack,
            this.clnreversepack,
            this.btndeactivate});
            this.dataGridPacked.EnableHeadersVisualStyles = false;
            this.dataGridPacked.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.dataGridPacked.Location = new System.Drawing.Point(12, 12);
            this.dataGridPacked.MultiSelect = false;
            this.dataGridPacked.Name = "dataGridPacked";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPacked.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridPacked.RowHeadersVisible = false;
            this.dataGridPacked.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridPacked.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridPacked.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridPacked.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPacked.Size = new System.Drawing.Size(1049, 482);
            this.dataGridPacked.TabIndex = 0;
            this.dataGridPacked.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacked_CellContentClick);
            this.dataGridPacked.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacked_CellContentClick);
            this.dataGridPacked.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacked_CellContentDoubleClick);
            this.dataGridPacked.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridPacked_CellPainting);
            this.dataGridPacked.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridPacked_KeyDown);
            // 
            // packid
            // 
            this.packid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.packid.HeaderText = "packid";
            this.packid.Name = "packid";
            this.packid.Visible = false;
            // 
            // clnweekid
            // 
            this.clnweekid.HeaderText = "Weekid";
            this.clnweekid.Name = "clnweekid";
            this.clnweekid.Visible = false;
            // 
            // clnactive
            // 
            this.clnactive.HeaderText = "active";
            this.clnactive.Name = "clnactive";
            this.clnactive.Visible = false;
            // 
            // pxname
            // 
            this.pxname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.pxname.DefaultCellStyle = dataGridViewCellStyle12;
            this.pxname.FillWeight = 30F;
            this.pxname.HeaderText = "Patient Name";
            this.pxname.Name = "pxname";
            this.pxname.ReadOnly = true;
            this.pxname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pxname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnCycleDate
            // 
            this.clnCycleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnCycleDate.DefaultCellStyle = dataGridViewCellStyle13;
            this.clnCycleDate.FillWeight = 25F;
            this.clnCycleDate.HeaderText = "Pack Date";
            this.clnCycleDate.Name = "clnCycleDate";
            this.clnCycleDate.ReadOnly = true;
            this.clnCycleDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnCycleDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnpacksize
            // 
            this.clnpacksize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clnpacksize.DefaultCellStyle = dataGridViewCellStyle14;
            this.clnpacksize.HeaderText = "Pack Size";
            this.clnpacksize.Name = "clnpacksize";
            this.clnpacksize.ReadOnly = true;
            this.clnpacksize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnpacksize.Width = 77;
            // 
            // clncode
            // 
            this.clncode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clncode.DefaultCellStyle = dataGridViewCellStyle15;
            this.clncode.HeaderText = "Cycle Type";
            this.clncode.Name = "clncode";
            this.clncode.ReadOnly = true;
            this.clncode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clncode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncode.Width = 85;
            // 
            // clnPackComment
            // 
            this.clnPackComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clnPackComment.DefaultCellStyle = dataGridViewCellStyle16;
            this.clnPackComment.FillWeight = 45F;
            this.clnPackComment.HeaderText = "Pack Comment";
            this.clnPackComment.Name = "clnPackComment";
            this.clnPackComment.ReadOnly = true;
            this.clnPackComment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnPackComment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnpackeduser
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnpackeduser.DefaultCellStyle = dataGridViewCellStyle17;
            this.clnpackeduser.HeaderText = "packeduser";
            this.clnpackeduser.Name = "clnpackeduser";
            this.clnpackeduser.ReadOnly = true;
            this.clnpackeduser.Visible = false;
            // 
            // clnpack
            // 
            this.clnpack.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnpack.HeaderText = "Pack";
            this.clnpack.Name = "clnpack";
            this.clnpack.Width = 47;
            // 
            // clnreversepack
            // 
            this.clnreversepack.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.clnreversepack.DefaultCellStyle = dataGridViewCellStyle18;
            this.clnreversepack.HeaderText = "Undo";
            this.clnreversepack.Name = "clnreversepack";
            this.clnreversepack.Width = 52;
            // 
            // btndeactivate
            // 
            this.btndeactivate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btndeactivate.HeaderText = "Delete";
            this.btndeactivate.Name = "btndeactivate";
            this.btndeactivate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btndeactivate.Width = 59;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(420, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Packing List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblpackBindingSource
            // 
            this.tblpackBindingSource.DataMember = "tblpack";
            this.tblpackBindingSource.DataSource = this.webbitdbdataset;
            // 
            // webbitdbdataset
            // 
            this.webbitdbdataset.DataSetName = "webbitdbdataset";
            this.webbitdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // webbitdbdatasetBindingSource
            // 
            this.webbitdbdatasetBindingSource.DataSource = this.webbitdbdataset;
            this.webbitdbdatasetBindingSource.Position = 0;
            // 
            // tblpackTableAdapter
            // 
            this.tblpackTableAdapter.ClearBeforeFill = true;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblusername.Location = new System.Drawing.Point(66, 21);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(148, 30);
            this.lblusername.TabIndex = 8;
            this.lblusername.Text = "Current User";
            // 
            // lblcount
            // 
            this.lblcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcount.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold);
            this.lblcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblcount.Location = new System.Drawing.Point(749, 3);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(317, 25);
            this.lblcount.TabIndex = 10;
            this.lblcount.Text = "packcount";
            this.lblcount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblcount.Click += new System.EventHandler(this.lblcount_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridPacked);
            this.panel1.Location = new System.Drawing.Point(13, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 507);
            this.panel1.TabIndex = 11;
            // 
            // btnclose
            // 
            this.btnclose.ActiveBorderThickness = 1;
            this.btnclose.ActiveCornerRadius = 10;
            this.btnclose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclose.ActiveForecolor = System.Drawing.Color.White;
            this.btnclose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnclose.BackColor = System.Drawing.Color.White;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.ButtonText = "Close";
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnclose.IdleBorderThickness = 1;
            this.btnclose.IdleCornerRadius = 10;
            this.btnclose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclose.IdleForecolor = System.Drawing.Color.White;
            this.btnclose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclose.Location = new System.Drawing.Point(501, 576);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 54);
            this.btnclose.TabIndex = 21;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PackChecker.Properties.Resources.icon_user;
            this.pictureBox1.Location = new System.Drawing.Point(28, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lblcountnotcycle
            // 
            this.lblcountnotcycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcountnotcycle.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold);
            this.lblcountnotcycle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblcountnotcycle.Location = new System.Drawing.Point(749, 31);
            this.lblcountnotcycle.Name = "lblcountnotcycle";
            this.lblcountnotcycle.Size = new System.Drawing.Size(317, 23);
            this.lblcountnotcycle.TabIndex = 23;
            this.lblcountnotcycle.Text = "packcount";
            this.lblcountnotcycle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlkey
            // 
            this.pnlkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlkey.Controls.Add(this.label4);
            this.pnlkey.Controls.Add(this.label5);
            this.pnlkey.Controls.Add(this.panel3);
            this.pnlkey.Controls.Add(this.panel5);
            this.pnlkey.Controls.Add(this.label2);
            this.pnlkey.Controls.Add(this.label3);
            this.pnlkey.Controls.Add(this.panel4);
            this.pnlkey.Controls.Add(this.panel2);
            this.pnlkey.Location = new System.Drawing.Point(28, 586);
            this.pnlkey.Name = "pnlkey";
            this.pnlkey.Size = new System.Drawing.Size(388, 44);
            this.pnlkey.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(225, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Not in current cycle";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(225, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Has Comment";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Location = new System.Drawing.Point(206, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 15);
            this.panel4.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Location = new System.Drawing.Point(206, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 15);
            this.panel2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(29, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Currently selected row";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(29, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Packed";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.panel3.Location = new System.Drawing.Point(10, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 15);
            this.panel3.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.ForestGreen;
            this.panel5.Location = new System.Drawing.Point(10, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 15);
            this.panel5.TabIndex = 27;
            // 
            // frmpacking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 644);
            this.Controls.Add(this.pnlkey);
            this.Controls.Add(this.lblcountnotcycle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmpacking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packing List";
            this.Load += new System.EventHandler(this.frmpacking_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmpacking_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdatasetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlkey.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridPacked;
        private System.Windows.Forms.BindingSource webbitdbdatasetBindingSource;
        private webbitdbdataset webbitdbdataset;
        private System.Windows.Forms.BindingSource tblpackBindingSource;
        private webbitdbdatasetTableAdapters.tblpackTableAdapter tblpackTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblcountnotcycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn packid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnweekid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn pxname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCycleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpacksize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPackComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpackeduser;
        private System.Windows.Forms.DataGridViewButtonColumn clnpack;
        private System.Windows.Forms.DataGridViewButtonColumn clnreversepack;
        private System.Windows.Forms.DataGridViewButtonColumn btndeactivate;
        private System.Windows.Forms.Panel pnlkey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}

