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
            this.websterdbDataSet = new PackChecker.websterdbDataSet();
            this.tblpacksizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpacksizeTableAdapter = new PackChecker.websterdbDataSetTableAdapters.tblpacksizeTableAdapter();
            this.tableAdapterManager = new PackChecker.websterdbDataSetTableAdapters.TableAdapterManager();
            this.packsizeidTextBox = new System.Windows.Forms.TextBox();
            this.sizenameTextBox = new System.Windows.Forms.TextBox();
            this.sizecommentTextBox = new System.Windows.Forms.TextBox();
            this.sizelongnameTextBox = new System.Windows.Forms.TextBox();
            this.sizeorderTextBox = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            sizenameLabel = new System.Windows.Forms.Label();
            sizecommentLabel = new System.Windows.Forms.Label();
            sizelongnameLabel = new System.Windows.Forms.Label();
            sizeorderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // websterdbDataSet
            // 
            this.websterdbDataSet.DataSetName = "websterdbDataSet";
            this.websterdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblpacksizeBindingSource
            // 
            this.tblpacksizeBindingSource.DataMember = "tblpacksize";
            this.tblpacksizeBindingSource.DataSource = this.websterdbDataSet;
            // 
            // tblpacksizeTableAdapter
            // 
            this.tblpacksizeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblcycleTableAdapter = null;
            this.tableAdapterManager.tbldateTableAdapter = null;
            this.tableAdapterManager.tbljobTableAdapter = null;
            this.tableAdapterManager.tblpacklocationTableAdapter = null;
            this.tableAdapterManager.tblpacksizeTableAdapter = this.tblpacksizeTableAdapter;
            this.tableAdapterManager.tblpackTableAdapter = null;
            this.tableAdapterManager.tblpatientTableAdapter = null;
            this.tableAdapterManager.tblsettingsTableAdapter = null;
            this.tableAdapterManager.tbluserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PackChecker.websterdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // packsizeidTextBox
            // 
            this.packsizeidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblpacksizeBindingSource, "packsizeid", true));
            this.packsizeidTextBox.Location = new System.Drawing.Point(12, 12);
            this.packsizeidTextBox.Name = "packsizeidTextBox";
            this.packsizeidTextBox.Size = new System.Drawing.Size(100, 20);
            this.packsizeidTextBox.TabIndex = 2;
            this.packsizeidTextBox.Visible = false;
            // 
            // sizenameLabel
            // 
            sizenameLabel.AutoSize = true;
            sizenameLabel.Location = new System.Drawing.Point(42, 79);
            sizenameLabel.Name = "sizenameLabel";
            sizenameLabel.Size = new System.Drawing.Size(70, 13);
            sizenameLabel.TabIndex = 3;
            sizenameLabel.Text = "Code for Size";
            // 
            // sizenameTextBox
            // 
            this.sizenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblpacksizeBindingSource, "sizename", true));
            this.sizenameTextBox.Location = new System.Drawing.Point(122, 76);
            this.sizenameTextBox.MaxLength = 4;
            this.sizenameTextBox.Name = "sizenameTextBox";
            this.sizenameTextBox.Size = new System.Drawing.Size(39, 20);
            this.sizenameTextBox.TabIndex = 4;
            // 
            // sizecommentLabel
            // 
            sizecommentLabel.AutoSize = true;
            sizecommentLabel.Location = new System.Drawing.Point(42, 131);
            sizecommentLabel.Name = "sizecommentLabel";
            sizecommentLabel.Size = new System.Drawing.Size(54, 13);
            sizecommentLabel.TabIndex = 5;
            sizecommentLabel.Text = "Comment:";
            // 
            // sizecommentTextBox
            // 
            this.sizecommentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblpacksizeBindingSource, "sizecomment", true));
            this.sizecommentTextBox.Location = new System.Drawing.Point(122, 128);
            this.sizecommentTextBox.Name = "sizecommentTextBox";
            this.sizecommentTextBox.Size = new System.Drawing.Size(150, 20);
            this.sizecommentTextBox.TabIndex = 6;
            // 
            // sizelongnameLabel
            // 
            sizelongnameLabel.AutoSize = true;
            sizelongnameLabel.Location = new System.Drawing.Point(42, 105);
            sizelongnameLabel.Name = "sizelongnameLabel";
            sizelongnameLabel.Size = new System.Drawing.Size(73, 13);
            sizelongnameLabel.TabIndex = 7;
            sizelongnameLabel.Text = "Name of Size:";
            // 
            // sizelongnameTextBox
            // 
            this.sizelongnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblpacksizeBindingSource, "sizelongname", true));
            this.sizelongnameTextBox.Location = new System.Drawing.Point(122, 102);
            this.sizelongnameTextBox.MaxLength = 8;
            this.sizelongnameTextBox.Name = "sizelongnameTextBox";
            this.sizelongnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizelongnameTextBox.TabIndex = 10;
            // 
            // sizeorderLabel
            // 
            sizeorderLabel.AutoSize = true;
            sizeorderLabel.Location = new System.Drawing.Point(42, 157);
            sizeorderLabel.Name = "sizeorderLabel";
            sizeorderLabel.Size = new System.Drawing.Size(52, 13);
            sizeorderLabel.TabIndex = 9;
            sizeorderLabel.Text = "List Order";
            // 
            // sizeorderTextBox
            // 
            this.sizeorderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblpacksizeBindingSource, "sizeorder", true));
            this.sizeorderTextBox.Location = new System.Drawing.Point(122, 154);
            this.sizeorderTextBox.MaxLength = 2;
            this.sizeorderTextBox.Name = "sizeorderTextBox";
            this.sizeorderTextBox.Size = new System.Drawing.Size(39, 20);
            this.sizeorderTextBox.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(23, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 24);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "New Tray Size";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(179, 191);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(93, 47);
            this.btncancel.TabIndex = 20;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(45, 191);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(93, 47);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "Save and Close";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmtraysize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 261);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
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
            this.Name = "frmtraysize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Tray Size";
            this.Load += new System.EventHandler(this.frmtraysize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpacksizeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private websterdbDataSet websterdbDataSet;
        private System.Windows.Forms.BindingSource tblpacksizeBindingSource;
        private websterdbDataSetTableAdapters.tblpacksizeTableAdapter tblpacksizeTableAdapter;
        private websterdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox packsizeidTextBox;
        private System.Windows.Forms.TextBox sizenameTextBox;
        private System.Windows.Forms.TextBox sizecommentTextBox;
        private System.Windows.Forms.TextBox sizelongnameTextBox;
        private System.Windows.Forms.TextBox sizeorderTextBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
    }
}