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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridpatients = new System.Windows.Forms.DataGridView();
            this.tblpacksizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.websterdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.websterdbDataSet = new PackChecker.websterdbDataSet();
            this.tblcycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpacklocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.tblcycleTableAdapter = new PackChecker.websterdbDataSetTableAdapters.tblcycleTableAdapter();
            this.tblpacksizeTableAdapter = new PackChecker.websterdbDataSetTableAdapters.tblpacksizeTableAdapter();
            this.tblpacklocationTableAdapter = new PackChecker.websterdbDataSetTableAdapters.tblpacklocationTableAdapter();
            this.clnlastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnfirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpacksize = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clncycletype = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnlocation1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnlocation2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnclear = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clndelivery = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnpxcomment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnsigningsheet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnpxid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridpatients
            // 
            this.dataGridpatients.AllowUserToAddRows = false;
            this.dataGridpatients.AllowUserToDeleteRows = false;
            this.dataGridpatients.AllowUserToResizeColumns = false;
            this.dataGridpatients.AllowUserToResizeRows = false;
            this.dataGridpatients.AutoGenerateColumns = false;
            this.dataGridpatients.BackgroundColor = System.Drawing.Color.White;
            this.dataGridpatients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridpatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridpatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridpatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnlastname,
            this.clnfirstname,
            this.clnpacksize,
            this.clncycletype,
            this.clnlocation1,
            this.clnlocation2,
            this.clnclear,
            this.clndelivery,
            this.clnpxcomment,
            this.clnsigningsheet,
            this.clnpxid,
            this.clnactive});
            this.dataGridpatients.DataSource = this.websterdbDataSetBindingSource;
            this.dataGridpatients.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridpatients.Location = new System.Drawing.Point(12, 54);
            this.dataGridpatients.MultiSelect = false;
            this.dataGridpatients.Name = "dataGridpatients";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridpatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridpatients.RowHeadersVisible = false;
            this.dataGridpatients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridpatients.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridpatients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridpatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridpatients.Size = new System.Drawing.Size(1280, 482);
            this.dataGridpatients.TabIndex = 2;
            this.dataGridpatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridpatients_CellContentClick);
            this.dataGridpatients.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridpatients_CellEnter);
            // 
            // tblpacksizeBindingSource
            // 
            this.tblpacksizeBindingSource.DataMember = "tblpacksize";
            this.tblpacksizeBindingSource.DataSource = this.websterdbDataSetBindingSource;
            // 
            // websterdbDataSetBindingSource
            // 
            this.websterdbDataSetBindingSource.DataSource = this.websterdbDataSet;
            this.websterdbDataSetBindingSource.Position = 0;
            // 
            // websterdbDataSet
            // 
            this.websterdbDataSet.DataSetName = "websterdbDataSet";
            this.websterdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcycleBindingSource
            // 
            this.tblcycleBindingSource.DataMember = "tblcycle";
            this.tblcycleBindingSource.DataSource = this.websterdbDataSetBindingSource;
            this.tblcycleBindingSource.CurrentChanged += new System.EventHandler(this.tblcycleBindingSource_CurrentChanged);
            // 
            // tblpacklocationBindingSource
            // 
            this.tblpacklocationBindingSource.DataMember = "tblpacklocation";
            this.tblpacklocationBindingSource.DataSource = this.websterdbDataSetBindingSource;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(528, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(213, 42);
            this.lbltitle.TabIndex = 3;
            this.lbltitle.Text = "My Patients";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.IndianRed;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(535, 542);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(206, 39);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // tblcycleTableAdapter
            // 
            this.tblcycleTableAdapter.ClearBeforeFill = true;
            // 
            // tblpacksizeTableAdapter
            // 
            this.tblpacksizeTableAdapter.ClearBeforeFill = true;
            // 
            // tblpacklocationTableAdapter
            // 
            this.tblpacklocationTableAdapter.ClearBeforeFill = true;
            // 
            // clnlastname
            // 
            this.clnlastname.HeaderText = "Last Name";
            this.clnlastname.Name = "clnlastname";
            this.clnlastname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnlastname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnlastname.Width = 175;
            // 
            // clnfirstname
            // 
            this.clnfirstname.HeaderText = "First Name";
            this.clnfirstname.Name = "clnfirstname";
            this.clnfirstname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnfirstname.Width = 175;
            // 
            // clnpacksize
            // 
            this.clnpacksize.DataSource = this.tblpacksizeBindingSource;
            this.clnpacksize.DisplayMember = "sizename";
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
            this.clncycletype.Width = 120;
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
            this.clnlocation2.DataSource = this.tblpacklocationBindingSource;
            this.clnlocation2.DisplayMember = "locationname";
            this.clnlocation2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.clnlocation2.HeaderText = "Optional Extra Location";
            this.clnlocation2.Name = "clnlocation2";
            this.clnlocation2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnlocation2.ValueMember = "locationid";
            // 
            // clnclear
            // 
            this.clnclear.HeaderText = "Clear Loc 2";
            this.clnclear.Name = "clnclear";
            this.clnclear.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnclear.Width = 60;
            // 
            // clndelivery
            // 
            this.clndelivery.HeaderText = "Delivery";
            this.clndelivery.Name = "clndelivery";
            // 
            // clnpxcomment
            // 
            this.clnpxcomment.HeaderText = "Comments";
            this.clnpxcomment.Name = "clnpxcomment";
            this.clnpxcomment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnpxcomment.Width = 250;
            // 
            // clnsigningsheet
            // 
            this.clnsigningsheet.HeaderText = "Signing Sheet";
            this.clnsigningsheet.Name = "clnsigningsheet";
            this.clnsigningsheet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnsigningsheet.Width = 80;
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
            // frmpatientlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 636);
            this.ControlBox = false;
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.dataGridpatients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmpatientlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient List";
            this.Load += new System.EventHandler(this.frmpatientlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridpatients;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.BindingSource websterdbDataSetBindingSource;
        private websterdbDataSet websterdbDataSet;
        private System.Windows.Forms.BindingSource tblcycleBindingSource;
        private websterdbDataSetTableAdapters.tblcycleTableAdapter tblcycleTableAdapter;
        private System.Windows.Forms.BindingSource tblpacksizeBindingSource;
        private websterdbDataSetTableAdapters.tblpacksizeTableAdapter tblpacksizeTableAdapter;
        private System.Windows.Forms.BindingSource tblpacklocationBindingSource;
        private websterdbDataSetTableAdapters.tblpacklocationTableAdapter tblpacklocationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnlastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnfirstname;
        private System.Windows.Forms.DataGridViewComboBoxColumn clnpacksize;
        private System.Windows.Forms.DataGridViewComboBoxColumn clncycletype;
        private System.Windows.Forms.DataGridViewComboBoxColumn clnlocation1;
        private System.Windows.Forms.DataGridViewComboBoxColumn clnlocation2;
        private System.Windows.Forms.DataGridViewButtonColumn clnclear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clndelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpxcomment;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnsigningsheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpxid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnactive;
    }
}

