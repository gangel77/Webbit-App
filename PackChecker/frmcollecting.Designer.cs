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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridcollect = new System.Windows.Forms.DataGridView();
            this.tblpackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.websterdbDataSet = new PackChecker.websterdbDataSet();
            this.websterdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpackTableAdapter = new PackChecker.websterdbDataSetTableAdapters.tblpackTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpatientname = new System.Windows.Forms.Label();
            this.lblloc1 = new System.Windows.Forms.Label();
            this.pnlloc1 = new System.Windows.Forms.Panel();
            this.lblpxid = new System.Windows.Forms.Label();
            this.lblpackscollect = new System.Windows.Forms.Label();
            this.pnlloc2 = new System.Windows.Forms.Panel();
            this.lblloc2 = new System.Windows.Forms.Label();
            this.btnshownonpacked = new System.Windows.Forms.Button();
            this.lblwarning = new System.Windows.Forms.Label();
            this.lblpklocation = new System.Windows.Forms.Label();
            this.packid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCycleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCollect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnpatientnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpacked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnchecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clngivenoutby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncollectedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncollectdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnreversecheck = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcollect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSetBindingSource)).BeginInit();
            this.pnlloc1.SuspendLayout();
            this.pnlloc2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridcollect
            // 
            this.dataGridcollect.AllowUserToAddRows = false;
            this.dataGridcollect.AllowUserToDeleteRows = false;
            this.dataGridcollect.AllowUserToResizeColumns = false;
            this.dataGridcollect.AllowUserToResizeRows = false;
            this.dataGridcollect.BackgroundColor = System.Drawing.Color.White;
            this.dataGridcollect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridcollect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridcollect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridcollect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packid,
            this.clnCycleDate,
            this.clnCollect,
            this.clnpatientnote,
            this.clnpacked,
            this.clnchecked,
            this.clngivenoutby,
            this.clncollectedby,
            this.clncollectdate,
            this.clnreversecheck});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridcollect.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridcollect.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridcollect.Location = new System.Drawing.Point(25, 226);
            this.dataGridcollect.MultiSelect = false;
            this.dataGridcollect.Name = "dataGridcollect";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridcollect.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridcollect.RowHeadersVisible = false;
            this.dataGridcollect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridcollect.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridcollect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridcollect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridcollect.Size = new System.Drawing.Size(872, 324);
            this.dataGridcollect.TabIndex = 2;
            this.dataGridcollect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChecked_CellContentClick);
            this.dataGridcollect.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridcollect_CellPainting);
            // 
            // tblpackBindingSource
            // 
            this.tblpackBindingSource.DataMember = "tblpack";
            this.tblpackBindingSource.DataSource = this.websterdbDataSet;
            // 
            // websterdbDataSet
            // 
            this.websterdbDataSet.DataSetName = "websterdbDataSet";
            this.websterdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // websterdbDataSetBindingSource
            // 
            this.websterdbDataSetBindingSource.DataSource = this.websterdbDataSet;
            this.websterdbDataSetBindingSource.Position = 0;
            // 
            // tblpackTableAdapter
            // 
            this.tblpackTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(923, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Collection for";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.IndianRed;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(322, 568);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(229, 39);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(12, 9);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(182, 33);
            this.lblusername.TabIndex = 5;
            this.lblusername.Text = "Current User";
            // 
            // lblpatientname
            // 
            this.lblpatientname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblpatientname.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatientname.Location = new System.Drawing.Point(-14, 83);
            this.lblpatientname.Name = "lblpatientname";
            this.lblpatientname.Size = new System.Drawing.Size(923, 42);
            this.lblpatientname.TabIndex = 0;
            this.lblpatientname.Text = "pxname";
            this.lblpatientname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblloc1
            // 
            this.lblloc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloc1.Location = new System.Drawing.Point(0, 0);
            this.lblloc1.Name = "lblloc1";
            this.lblloc1.Size = new System.Drawing.Size(194, 50);
            this.lblloc1.TabIndex = 0;
            this.lblloc1.Text = "location";
            this.lblloc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlloc1
            // 
            this.pnlloc1.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlloc1.Controls.Add(this.lblloc1);
            this.pnlloc1.Location = new System.Drawing.Point(676, 57);
            this.pnlloc1.Name = "pnlloc1";
            this.pnlloc1.Size = new System.Drawing.Size(200, 50);
            this.pnlloc1.TabIndex = 1;
            // 
            // lblpxid
            // 
            this.lblpxid.AutoSize = true;
            this.lblpxid.Location = new System.Drawing.Point(74, 142);
            this.lblpxid.Name = "lblpxid";
            this.lblpxid.Size = new System.Drawing.Size(47, 13);
            this.lblpxid.TabIndex = 11;
            this.lblpxid.Text = "patientid";
            this.lblpxid.Visible = false;
            // 
            // lblpackscollect
            // 
            this.lblpackscollect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblpackscollect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpackscollect.ForeColor = System.Drawing.Color.DimGray;
            this.lblpackscollect.Location = new System.Drawing.Point(-24, 165);
            this.lblpackscollect.Name = "lblpackscollect";
            this.lblpackscollect.Size = new System.Drawing.Size(975, 33);
            this.lblpackscollect.TabIndex = 12;
            this.lblpackscollect.Text = "packscollect";
            this.lblpackscollect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlloc2
            // 
            this.pnlloc2.BackColor = System.Drawing.Color.Brown;
            this.pnlloc2.Controls.Add(this.lblloc2);
            this.pnlloc2.Location = new System.Drawing.Point(676, 119);
            this.pnlloc2.Name = "pnlloc2";
            this.pnlloc2.Size = new System.Drawing.Size(200, 50);
            this.pnlloc2.TabIndex = 2;
            this.pnlloc2.Visible = false;
            // 
            // lblloc2
            // 
            this.lblloc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloc2.Location = new System.Drawing.Point(0, 0);
            this.lblloc2.Name = "lblloc2";
            this.lblloc2.Size = new System.Drawing.Size(200, 50);
            this.lblloc2.TabIndex = 0;
            this.lblloc2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnshownonpacked
            // 
            this.btnshownonpacked.BackColor = System.Drawing.Color.LightBlue;
            this.btnshownonpacked.Location = new System.Drawing.Point(25, 552);
            this.btnshownonpacked.Name = "btnshownonpacked";
            this.btnshownonpacked.Size = new System.Drawing.Size(109, 55);
            this.btnshownonpacked.TabIndex = 13;
            this.btnshownonpacked.Text = "Show packs in packing queue";
            this.btnshownonpacked.UseVisualStyleBackColor = false;
            this.btnshownonpacked.Click += new System.EventHandler(this.btnshownonpacked_Click);
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Location = new System.Drawing.Point(673, 41);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(58, 13);
            this.lblwarning.TabIndex = 14;
            this.lblwarning.Text = "locwarning";
            this.lblwarning.Visible = false;
            // 
            // lblpklocation
            // 
            this.lblpklocation.AutoSize = true;
            this.lblpklocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpklocation.Location = new System.Drawing.Point(701, 29);
            this.lblpklocation.Name = "lblpklocation";
            this.lblpklocation.Size = new System.Drawing.Size(148, 25);
            this.lblpklocation.TabIndex = 15;
            this.lblpklocation.Text = "Pack Location";
            // 
            // packid
            // 
            this.packid.HeaderText = "packid";
            this.packid.Name = "packid";
            this.packid.Visible = false;
            this.packid.Width = 55;
            // 
            // clnCycleDate
            // 
            this.clnCycleDate.HeaderText = "Cycle Date";
            this.clnCycleDate.Name = "clnCycleDate";
            this.clnCycleDate.ReadOnly = true;
            this.clnCycleDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnCycleDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnCycleDate.Width = 92;
            // 
            // clnCollect
            // 
            this.clnCollect.HeaderText = "Collect";
            this.clnCollect.Name = "clnCollect";
            this.clnCollect.Width = 63;
            // 
            // clnpatientnote
            // 
            this.clnpatientnote.HeaderText = "Patient Note";
            this.clnpatientnote.Name = "clnpatientnote";
            this.clnpatientnote.ReadOnly = true;
            this.clnpatientnote.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnpatientnote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnpatientnote.Width = 150;
            // 
            // clnpacked
            // 
            this.clnpacked.HeaderText = "Packed";
            this.clnpacked.Name = "clnpacked";
            this.clnpacked.ReadOnly = true;
            this.clnpacked.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnpacked.Width = 68;
            // 
            // clnchecked
            // 
            this.clnchecked.HeaderText = "Checked";
            this.clnchecked.Name = "clnchecked";
            this.clnchecked.ReadOnly = true;
            this.clnchecked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnchecked.Width = 78;
            // 
            // clngivenoutby
            // 
            this.clngivenoutby.HeaderText = "Given Out By";
            this.clngivenoutby.Name = "clngivenoutby";
            this.clngivenoutby.ReadOnly = true;
            this.clngivenoutby.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clngivenoutby.Width = 108;
            // 
            // clncollectedby
            // 
            this.clncollectedby.HeaderText = "Collected By";
            this.clncollectedby.Name = "clncollectedby";
            this.clncollectedby.ReadOnly = true;
            this.clncollectedby.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncollectedby.Width = 103;
            // 
            // clncollectdate
            // 
            this.clncollectdate.HeaderText = "Collect Date";
            this.clncollectdate.Name = "clncollectdate";
            this.clncollectdate.ReadOnly = true;
            this.clncollectdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncollectdate.Width = 150;
            // 
            // clnreversecheck
            // 
            this.clnreversecheck.HeaderText = "Undo";
            this.clnreversecheck.Name = "clnreversecheck";
            this.clnreversecheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnreversecheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnreversecheck.Width = 55;
            // 
            // frmcollecting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 627);
            this.Controls.Add(this.lblpklocation);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.btnshownonpacked);
            this.Controls.Add(this.pnlloc2);
            this.Controls.Add(this.pnlloc1);
            this.Controls.Add(this.lblpackscollect);
            this.Controls.Add(this.lblpxid);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridcollect);
            this.Controls.Add(this.lblpatientname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmcollecting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmchecking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcollect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSetBindingSource)).EndInit();
            this.pnlloc1.ResumeLayout(false);
            this.pnlloc2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridcollect;
        private System.Windows.Forms.BindingSource websterdbDataSetBindingSource;
        private websterdbDataSet websterdbDataSet;
        private System.Windows.Forms.BindingSource tblpackBindingSource;
        private websterdbDataSetTableAdapters.tblpackTableAdapter tblpackTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpatientname;
        private System.Windows.Forms.Label lblloc1;
        private System.Windows.Forms.Panel pnlloc1;
        private System.Windows.Forms.Label lblpxid;
        private System.Windows.Forms.Label lblpackscollect;
        private System.Windows.Forms.Panel pnlloc2;
        private System.Windows.Forms.Label lblloc2;
        private System.Windows.Forms.Button btnshownonpacked;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.Label lblpklocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn packid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCycleDate;
        private System.Windows.Forms.DataGridViewButtonColumn clnCollect;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpatientnote;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnpacked;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnchecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn clngivenoutby;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncollectedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncollectdate;
        private System.Windows.Forms.DataGridViewButtonColumn clnreversecheck;
    }
}

