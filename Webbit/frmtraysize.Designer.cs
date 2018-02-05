namespace PackChecker
{
    partial class frmtraysize
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
            System.Windows.Forms.Label sizenameLabel;
            System.Windows.Forms.Label sizecommentLabel;
            System.Windows.Forms.Label sizelongnameLabel;
            System.Windows.Forms.Label sizeorderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtraysize));
            System.Windows.Forms.Label hideLabel;
            this.webbitdbdataset = new PackChecker.webbitdbdataset();
            this.tblpacksizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpacksizeTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblpacksizeTableAdapter();
            this.tableAdapterManager = new PackChecker.webbitdbdatasetTableAdapters.TableAdapterManager();
            this.packsizeidTextBox = new System.Windows.Forms.TextBox();
            this.sizenameTextBox = new System.Windows.Forms.TextBox();
            this.sizecommentTextBox = new System.Windows.Forms.TextBox();
            this.sizelongnameTextBox = new System.Windows.Forms.TextBox();
            this.sizeorderTextBox = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSaveandClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btncancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.hideCheckBox = new System.Windows.Forms.CheckBox();
            sizenameLabel = new System.Windows.Forms.Label();
            sizecommentLabel = new System.Windows.Forms.Label();
            sizelongnameLabel = new System.Windows.Forms.Label();
            sizeorderLabel = new System.Windows.Forms.Label();
            hideLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sizenameLabel
            // 
            sizenameLabel.AutoSize = true;
            sizenameLabel.Location = new System.Drawing.Point(76, 79);
            sizenameLabel.Name = "sizenameLabel";
            sizenameLabel.Size = new System.Drawing.Size(35, 13);
            sizenameLabel.TabIndex = 3;
            sizenameLabel.Text = "Code:";
            // 
            // sizecommentLabel
            // 
            sizecommentLabel.AutoSize = true;
            sizecommentLabel.Location = new System.Drawing.Point(76, 131);
            sizecommentLabel.Name = "sizecommentLabel";
            sizecommentLabel.Size = new System.Drawing.Size(42, 13);
            sizecommentLabel.TabIndex = 5;
            sizecommentLabel.Text = "Details:";
            // 
            // sizelongnameLabel
            // 
            sizelongnameLabel.AutoSize = true;
            sizelongnameLabel.Location = new System.Drawing.Point(76, 105);
            sizelongnameLabel.Name = "sizelongnameLabel";
            sizelongnameLabel.Size = new System.Drawing.Size(38, 13);
            sizelongnameLabel.TabIndex = 7;
            sizelongnameLabel.Text = "Name:";
            // 
            // sizeorderLabel
            // 
            sizeorderLabel.AutoSize = true;
            sizeorderLabel.Location = new System.Drawing.Point(76, 157);
            sizeorderLabel.Name = "sizeorderLabel";
            sizeorderLabel.Size = new System.Drawing.Size(55, 13);
            sizeorderLabel.TabIndex = 9;
            sizeorderLabel.Text = "List Order:";
            // 
            // webbitdbdataset
            // 
            this.webbitdbdataset.DataSetName = "webbitdbdataset";
            this.webbitdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblpacksizeBindingSource
            // 
            this.tblpacksizeBindingSource.DataMember = "tblpacksize";
            this.tblpacksizeBindingSource.DataSource = this.webbitdbdataset;
            // 
            // tblpacksizeTableAdapter
            // 
            this.tblpacksizeTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblpacksizeTableAdapter = this.tblpacksizeTableAdapter;
            this.tableAdapterManager.tblpackTableAdapter = null;
            this.tableAdapterManager.tblpatientTableAdapter = null;
            this.tableAdapterManager.tblsettingsTableAdapter = null;
            this.tableAdapterManager.tbluserTableAdapter = null;
            this.tableAdapterManager.tblweekTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PackChecker.webbitdbdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usecycleTableAdapter = null;
            this.tableAdapterManager.uselocationTableAdapter = null;
            // 
            // packsizeidTextBox
            // 
            this.packsizeidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblpacksizeBindingSource, "packsizeid", true));
            this.packsizeidTextBox.Location = new System.Drawing.Point(31, 35);
            this.packsizeidTextBox.Name = "packsizeidTextBox";
            this.packsizeidTextBox.Size = new System.Drawing.Size(100, 20);
            this.packsizeidTextBox.TabIndex = 2;
            this.packsizeidTextBox.TabStop = false;
            this.packsizeidTextBox.Visible = false;
            // 
            // sizenameTextBox
            // 
            this.sizenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblpacksizeBindingSource, "sizename", true));
            this.sizenameTextBox.Location = new System.Drawing.Point(156, 76);
            this.sizenameTextBox.MaxLength = 4;
            this.sizenameTextBox.Name = "sizenameTextBox";
            this.sizenameTextBox.Size = new System.Drawing.Size(39, 20);
            this.sizenameTextBox.TabIndex = 0;
            this.sizenameTextBox.TextChanged += new System.EventHandler(this.sizenameTextBox_TextChanged);
            // 
            // sizecommentTextBox
            // 
            this.sizecommentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblpacksizeBindingSource, "sizecomment", true));
            this.sizecommentTextBox.Location = new System.Drawing.Point(156, 128);
            this.sizecommentTextBox.Name = "sizecommentTextBox";
            this.sizecommentTextBox.Size = new System.Drawing.Size(150, 20);
            this.sizecommentTextBox.TabIndex = 2;
            // 
            // sizelongnameTextBox
            // 
            this.sizelongnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblpacksizeBindingSource, "sizelongname", true));
            this.sizelongnameTextBox.Location = new System.Drawing.Point(156, 102);
            this.sizelongnameTextBox.MaxLength = 20;
            this.sizelongnameTextBox.Name = "sizelongnameTextBox";
            this.sizelongnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizelongnameTextBox.TabIndex = 1;
            this.sizelongnameTextBox.TextChanged += new System.EventHandler(this.sizelongnameTextBox_TextChanged);
            // 
            // sizeorderTextBox
            // 
            this.sizeorderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblpacksizeBindingSource, "sizeorder", true));
            this.sizeorderTextBox.Location = new System.Drawing.Point(156, 154);
            this.sizeorderTextBox.MaxLength = 2;
            this.sizeorderTextBox.Name = "sizeorderTextBox";
            this.sizeorderTextBox.Size = new System.Drawing.Size(39, 20);
            this.sizeorderTextBox.TabIndex = 3;
            this.sizeorderTextBox.TextChanged += new System.EventHandler(this.sizeorderTextBox_TextChanged);
            this.sizeorderTextBox.Enter += new System.EventHandler(this.sizeorderTextBox_Enter);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblTitle.Location = new System.Drawing.Point(57, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 35);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Edit Tray Size";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSaveandClose
            // 
            this.btnSaveandClose.ActiveBorderThickness = 1;
            this.btnSaveandClose.ActiveCornerRadius = 10;
            this.btnSaveandClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnSaveandClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaveandClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnSaveandClose.BackColor = System.Drawing.Color.White;
            this.btnSaveandClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveandClose.BackgroundImage")));
            this.btnSaveandClose.ButtonText = "Save and Close";
            this.btnSaveandClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveandClose.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveandClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSaveandClose.IdleBorderThickness = 1;
            this.btnSaveandClose.IdleCornerRadius = 10;
            this.btnSaveandClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnSaveandClose.IdleForecolor = System.Drawing.Color.White;
            this.btnSaveandClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnSaveandClose.Location = new System.Drawing.Point(31, 218);
            this.btnSaveandClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveandClose.Name = "btnSaveandClose";
            this.btnSaveandClose.Size = new System.Drawing.Size(141, 54);
            this.btnSaveandClose.TabIndex = 25;
            this.btnSaveandClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveandClose.Click += new System.EventHandler(this.btnsave_Click);
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
            this.btncancel.Location = new System.Drawing.Point(182, 218);
            this.btncancel.Margin = new System.Windows.Forms.Padding(5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(141, 54);
            this.btncancel.TabIndex = 26;
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // hideLabel
            // 
            hideLabel.AutoSize = true;
            hideLabel.Location = new System.Drawing.Point(76, 182);
            hideLabel.Name = "hideLabel";
            hideLabel.Size = new System.Drawing.Size(32, 13);
            hideLabel.TabIndex = 26;
            hideLabel.Text = "Hide:";
            // 
            // hideCheckBox
            // 
            this.hideCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblpacksizeBindingSource, "hide", true));
            this.hideCheckBox.Location = new System.Drawing.Point(156, 177);
            this.hideCheckBox.Name = "hideCheckBox";
            this.hideCheckBox.Size = new System.Drawing.Size(104, 24);
            this.hideCheckBox.TabIndex = 27;
            this.hideCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmtraysize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 295);
            this.Controls.Add(hideLabel);
            this.Controls.Add(this.hideCheckBox);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnSaveandClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.packsizeidTextBox);
            this.Controls.Add(sizenameLabel);
            this.Controls.Add(this.sizenameTextBox);
            this.Controls.Add(sizecommentLabel);
            this.Controls.Add(this.sizecommentTextBox);
            this.Controls.Add(sizelongnameLabel);
            this.Controls.Add(this.sizelongnameTextBox);
            this.Controls.Add(sizeorderLabel);
            this.Controls.Add(this.sizeorderTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtraysize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Tray Size";
            this.Load += new System.EventHandler(this.frmtraysize_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmtraysize_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private webbitdbdataset webbitdbdataset;
        private System.Windows.Forms.BindingSource tblpacksizeBindingSource;
        private webbitdbdatasetTableAdapters.tblpacksizeTableAdapter tblpacksizeTableAdapter;
        private webbitdbdatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox packsizeidTextBox;
        private System.Windows.Forms.TextBox sizenameTextBox;
        private System.Windows.Forms.TextBox sizecommentTextBox;
        private System.Windows.Forms.TextBox sizelongnameTextBox;
        private System.Windows.Forms.TextBox sizeorderTextBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuThinButton2 btncancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaveandClose;
        private System.Windows.Forms.CheckBox hideCheckBox;
    }
}