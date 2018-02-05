namespace PackChecker
{
    partial class frmlocation
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
            System.Windows.Forms.Label locationnameLabel;
            System.Windows.Forms.Label warningLabel;
            System.Windows.Forms.Label hidelocationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlocation));
            this.webbitdbdataset = new PackChecker.webbitdbdataset();
            this.tblpacklocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpacklocationTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblpacklocationTableAdapter();
            this.tableAdapterManager = new PackChecker.webbitdbdatasetTableAdapters.TableAdapterManager();
            this.locationidTextBox = new System.Windows.Forms.TextBox();
            this.locationnameTextBox = new System.Windows.Forms.TextBox();
            this.warningCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hidelocationCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnsave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btncancel = new Bunifu.Framework.UI.BunifuThinButton2();
            locationnameLabel = new System.Windows.Forms.Label();
            warningLabel = new System.Windows.Forms.Label();
            hidelocationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // locationnameLabel
            // 
            locationnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            locationnameLabel.Location = new System.Drawing.Point(28, 68);
            locationnameLabel.Name = "locationnameLabel";
            locationnameLabel.Size = new System.Drawing.Size(144, 20);
            locationnameLabel.TabIndex = 3;
            locationnameLabel.Text = "Location Name:";
            // 
            // warningLabel
            // 
            warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            warningLabel.Location = new System.Drawing.Point(28, 98);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new System.Drawing.Size(264, 21);
            warningLabel.TabIndex = 5;
            warningLabel.Text = "Warn of location at collection:";
            // 
            // hidelocationLabel
            // 
            hidelocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            hidelocationLabel.Location = new System.Drawing.Point(28, 123);
            hidelocationLabel.Name = "hidelocationLabel";
            hidelocationLabel.Size = new System.Drawing.Size(264, 22);
            hidelocationLabel.TabIndex = 19;
            hidelocationLabel.Text = "Hide location so it can\'t be used:";
            // 
            // webbitdbdataset
            // 
            this.webbitdbdataset.DataSetName = "webbitdbdataset";
            this.webbitdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblpacklocationBindingSource
            // 
            this.tblpacklocationBindingSource.DataMember = "tblpacklocation";
            this.tblpacklocationBindingSource.DataSource = this.webbitdbdataset;
            // 
            // tblpacklocationTableAdapter
            // 
            this.tblpacklocationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.casualpxTableAdapter = null;
            this.tableAdapterManager.tblcycleTableAdapter = null;
            this.tableAdapterManager.tbldateTableAdapter = null;
            this.tableAdapterManager.tblinstitutionTableAdapter = null;
            this.tableAdapterManager.tbljobTableAdapter = null;
            this.tableAdapterManager.tblpacklocationTableAdapter = this.tblpacklocationTableAdapter;
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
            // locationidTextBox
            // 
            this.locationidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblpacklocationBindingSource, "locationid", true));
            this.locationidTextBox.Location = new System.Drawing.Point(12, 30);
            this.locationidTextBox.Name = "locationidTextBox";
            this.locationidTextBox.Size = new System.Drawing.Size(104, 20);
            this.locationidTextBox.TabIndex = 2;
            this.locationidTextBox.TabStop = false;
            this.locationidTextBox.Visible = false;
            // 
            // locationnameTextBox
            // 
            this.locationnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblpacklocationBindingSource, "locationname", true));
            this.locationnameTextBox.Location = new System.Drawing.Point(216, 68);
            this.locationnameTextBox.Name = "locationnameTextBox";
            this.locationnameTextBox.Size = new System.Drawing.Size(143, 20);
            this.locationnameTextBox.TabIndex = 0;
            this.locationnameTextBox.TextChanged += new System.EventHandler(this.locationnameTextBox_TextChanged);
            // 
            // warningCheckBox
            // 
            this.warningCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblpacklocationBindingSource, "warning", true));
            this.warningCheckBox.Location = new System.Drawing.Point(292, 95);
            this.warningCheckBox.Name = "warningCheckBox";
            this.warningCheckBox.Size = new System.Drawing.Size(23, 24);
            this.warningCheckBox.TabIndex = 1;
            this.warningCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Edit Location";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hidelocationCheckBox
            // 
            this.hidelocationCheckBox.AutoCheck = false;
            this.hidelocationCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblpacklocationBindingSource, "hidelocation", true));
            this.hidelocationCheckBox.Location = new System.Drawing.Point(292, 121);
            this.hidelocationCheckBox.Name = "hidelocationCheckBox";
            this.hidelocationCheckBox.Size = new System.Drawing.Size(23, 24);
            this.hidelocationCheckBox.TabIndex = 2;
            this.hidelocationCheckBox.UseVisualStyleBackColor = true;
            this.hidelocationCheckBox.Click += new System.EventHandler(this.hidelocationCheckBox_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnsave.Location = new System.Drawing.Point(58, 152);
            this.btnsave.Margin = new System.Windows.Forms.Padding(5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(141, 54);
            this.btnsave.TabIndex = 3;
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
            this.btncancel.Location = new System.Drawing.Point(221, 152);
            this.btncancel.Margin = new System.Windows.Forms.Padding(5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(98, 54);
            this.btncancel.TabIndex = 4;
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // frmlocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(376, 224);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(hidelocationLabel);
            this.Controls.Add(this.hidelocationCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationidTextBox);
            this.Controls.Add(locationnameLabel);
            this.Controls.Add(this.locationnameTextBox);
            this.Controls.Add(warningLabel);
            this.Controls.Add(this.warningCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmlocation";
            this.Load += new System.EventHandler(this.frmlocation_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmlocation_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private webbitdbdataset webbitdbdataset;
        private System.Windows.Forms.BindingSource tblpacklocationBindingSource;
        private webbitdbdatasetTableAdapters.tblpacklocationTableAdapter tblpacklocationTableAdapter;
        private webbitdbdatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox locationidTextBox;
        private System.Windows.Forms.TextBox locationnameTextBox;
        private System.Windows.Forms.CheckBox warningCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox hidelocationCheckBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsave;
        private Bunifu.Framework.UI.BunifuThinButton2 btncancel;
    }
}