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
            this.websterdbDataSet = new PackChecker.websterdbDataSet();
            this.tblpacklocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpacklocationTableAdapter = new PackChecker.websterdbDataSetTableAdapters.tblpacklocationTableAdapter();
            this.tableAdapterManager = new PackChecker.websterdbDataSetTableAdapters.TableAdapterManager();
            this.locationidTextBox = new System.Windows.Forms.TextBox();
            this.locationnameTextBox = new System.Windows.Forms.TextBox();
            this.warningCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.hidelocationCheckBox = new System.Windows.Forms.CheckBox();
            locationnameLabel = new System.Windows.Forms.Label();
            warningLabel = new System.Windows.Forms.Label();
            hidelocationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // locationnameLabel
            // 
            locationnameLabel.AutoSize = true;
            locationnameLabel.Location = new System.Drawing.Point(92, 68);
            locationnameLabel.Name = "locationnameLabel";
            locationnameLabel.Size = new System.Drawing.Size(82, 13);
            locationnameLabel.TabIndex = 3;
            locationnameLabel.Text = "Location Name:";
            // 
            // warningLabel
            // 
            warningLabel.AutoSize = true;
            warningLabel.Location = new System.Drawing.Point(26, 96);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new System.Drawing.Size(148, 13);
            warningLabel.TabIndex = 5;
            warningLabel.Text = "Warn of location at collection:";
            
            // 
            // websterdbDataSet
            // 
            this.websterdbDataSet.DataSetName = "websterdbDataSet";
            this.websterdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblpacklocationBindingSource
            // 
            this.tblpacklocationBindingSource.DataMember = "tblpacklocation";
            this.tblpacklocationBindingSource.DataSource = this.websterdbDataSet;
            // 
            // tblpacklocationTableAdapter
            // 
            this.tblpacklocationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblcycleTableAdapter = null;
            this.tableAdapterManager.tbldateTableAdapter = null;
            this.tableAdapterManager.tbljobTableAdapter = null;
            this.tableAdapterManager.tblpacklocationTableAdapter = this.tblpacklocationTableAdapter;
            this.tableAdapterManager.tblpacksizeTableAdapter = null;
            this.tableAdapterManager.tblpackTableAdapter = null;
            this.tableAdapterManager.tblpatientTableAdapter = null;
            this.tableAdapterManager.tblsettingsTableAdapter = null;
            this.tableAdapterManager.tbluserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PackChecker.websterdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // locationidTextBox
            // 
            this.locationidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblpacklocationBindingSource, "locationid", true));
            this.locationidTextBox.Location = new System.Drawing.Point(12, 39);
            this.locationidTextBox.Name = "locationidTextBox";
            this.locationidTextBox.Size = new System.Drawing.Size(104, 20);
            this.locationidTextBox.TabIndex = 2;
            this.locationidTextBox.Visible = false;
            // 
            // locationnameTextBox
            // 
            this.locationnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblpacklocationBindingSource, "locationname", true));
            this.locationnameTextBox.Location = new System.Drawing.Point(180, 65);
            this.locationnameTextBox.Name = "locationnameTextBox";
            this.locationnameTextBox.Size = new System.Drawing.Size(104, 20);
            this.locationnameTextBox.TabIndex = 4;
            // 
            // warningCheckBox
            // 
            this.warningCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblpacklocationBindingSource, "warning", true));
            this.warningCheckBox.Location = new System.Drawing.Point(180, 91);
            this.warningCheckBox.Name = "warningCheckBox";
            this.warningCheckBox.Size = new System.Drawing.Size(104, 24);
            this.warningCheckBox.TabIndex = 6;
            this.warningCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Edit Location";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(164, 153);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(133, 47);
            this.btncancel.TabIndex = 18;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(15, 153);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(133, 47);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Save and Close";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // hidelocationLabel
            // 
            hidelocationLabel.AutoSize = true;
            hidelocationLabel.Location = new System.Drawing.Point(12, 123);
            hidelocationLabel.Name = "hidelocationLabel";
            hidelocationLabel.Size = new System.Drawing.Size(162, 13);
            hidelocationLabel.TabIndex = 19;
            hidelocationLabel.Text = "Hide Location so it can\'t be used";
            // 
            // hidelocationCheckBox
            // 
            this.hidelocationCheckBox.AutoCheck = false;
            this.hidelocationCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblpacklocationBindingSource, "hidelocation", true));
            this.hidelocationCheckBox.Location = new System.Drawing.Point(180, 118);
            this.hidelocationCheckBox.Name = "hidelocationCheckBox";
            this.hidelocationCheckBox.Size = new System.Drawing.Size(104, 24);
            this.hidelocationCheckBox.TabIndex = 20;
            this.hidelocationCheckBox.UseVisualStyleBackColor = true;
            this.hidelocationCheckBox.Click += new System.EventHandler(this.hidelocationCheckBox_Click);
            // 
            // frmlocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 224);
            this.Controls.Add(hidelocationLabel);
            this.Controls.Add(this.hidelocationCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.locationidTextBox);
            this.Controls.Add(locationnameLabel);
            this.Controls.Add(this.locationnameTextBox);
            this.Controls.Add(warningLabel);
            this.Controls.Add(this.warningCheckBox);
            this.Name = "frmlocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmlocation";
            this.Load += new System.EventHandler(this.frmlocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacklocationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private websterdbDataSet websterdbDataSet;
        private System.Windows.Forms.BindingSource tblpacklocationBindingSource;
        private websterdbDataSetTableAdapters.tblpacklocationTableAdapter tblpacklocationTableAdapter;
        private websterdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox locationidTextBox;
        private System.Windows.Forms.TextBox locationnameTextBox;
        private System.Windows.Forms.CheckBox warningCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.CheckBox hidelocationCheckBox;
    }
}