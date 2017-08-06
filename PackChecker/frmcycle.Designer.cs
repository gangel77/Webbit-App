namespace PackChecker
{
    partial class frmcycle
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
            System.Windows.Forms.Label cyclecodeLabel;
            System.Windows.Forms.Label cycledescriptionLabel;
            System.Windows.Forms.Label cycleweeksLabel;
            System.Windows.Forms.Label cyclepacksLabel;
            System.Windows.Forms.Label cyclehideLabel;
            this.websterdbDataSet = new PackChecker.websterdbDataSet();
            this.tblcycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblcycleTableAdapter = new PackChecker.websterdbDataSetTableAdapters.tblcycleTableAdapter();
            this.tableAdapterManager = new PackChecker.websterdbDataSetTableAdapters.TableAdapterManager();
            this.cyclecodeTextBox = new System.Windows.Forms.TextBox();
            this.cycledescriptionTextBox = new System.Windows.Forms.TextBox();
            this.cycleweeksTextBox = new System.Windows.Forms.TextBox();
            this.cyclepacksTextBox = new System.Windows.Forms.TextBox();
            this.cyclehideCheckBox = new System.Windows.Forms.CheckBox();
            this.cycleidTextBox = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            cyclecodeLabel = new System.Windows.Forms.Label();
            cycledescriptionLabel = new System.Windows.Forms.Label();
            cycleweeksLabel = new System.Windows.Forms.Label();
            cyclepacksLabel = new System.Windows.Forms.Label();
            cyclehideLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cyclecodeLabel
            // 
            cyclecodeLabel.AutoSize = true;
            cyclecodeLabel.Location = new System.Drawing.Point(41, 74);
            cyclecodeLabel.Name = "cyclecodeLabel";
            cyclecodeLabel.Size = new System.Drawing.Size(61, 13);
            cyclecodeLabel.TabIndex = 1;
            cyclecodeLabel.Text = "Cycle Code";
            // 
            // cycledescriptionLabel
            // 
            cycledescriptionLabel.AutoSize = true;
            cycledescriptionLabel.Location = new System.Drawing.Point(41, 100);
            cycledescriptionLabel.Name = "cycledescriptionLabel";
            cycledescriptionLabel.Size = new System.Drawing.Size(92, 13);
            cycledescriptionLabel.TabIndex = 3;
            cycledescriptionLabel.Text = "Cycle Description:";
            // 
            // cycleweeksLabel
            // 
            cycleweeksLabel.AutoSize = true;
            cycleweeksLabel.Location = new System.Drawing.Point(41, 126);
            cycleweeksLabel.Name = "cycleweeksLabel";
            cycleweeksLabel.Size = new System.Drawing.Size(84, 13);
            cycleweeksLabel.TabIndex = 5;
            cycleweeksLabel.Text = "Weeks in Cycle:";
            // 
            // cyclepacksLabel
            // 
            cyclepacksLabel.AutoSize = true;
            cyclepacksLabel.Location = new System.Drawing.Point(41, 152);
            cyclepacksLabel.Name = "cyclepacksLabel";
            cyclepacksLabel.Size = new System.Drawing.Size(80, 13);
            cyclepacksLabel.TabIndex = 7;
            cyclepacksLabel.Text = "Packs in Cycle:";
            // 
            // cyclehideLabel
            // 
            cyclehideLabel.AutoSize = true;
            cyclehideLabel.Location = new System.Drawing.Point(260, 142);
            cyclehideLabel.Name = "cyclehideLabel";
            cyclehideLabel.Size = new System.Drawing.Size(102, 13);
            cyclehideLabel.TabIndex = 11;
            cyclehideLabel.Text = "Don\'t use this cycle:";
            // 
            // websterdbDataSet
            // 
            this.websterdbDataSet.DataSetName = "websterdbDataSet";
            this.websterdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcycleBindingSource
            // 
            this.tblcycleBindingSource.DataMember = "tblcycle";
            this.tblcycleBindingSource.DataSource = this.websterdbDataSet;
            // 
            // tblcycleTableAdapter
            // 
            this.tblcycleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblcycleTableAdapter = this.tblcycleTableAdapter;
            this.tableAdapterManager.tbldateTableAdapter = null;
            this.tableAdapterManager.tbljobTableAdapter = null;
            this.tableAdapterManager.tblpacklocationTableAdapter = null;
            this.tableAdapterManager.tblpacksizeTableAdapter = null;
            this.tableAdapterManager.tblpackTableAdapter = null;
            this.tableAdapterManager.tblpatientTableAdapter = null;
            this.tableAdapterManager.tblsettingsTableAdapter = null;
            this.tableAdapterManager.tbluserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PackChecker.websterdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cyclecodeTextBox
            // 
            this.cyclecodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcycleBindingSource, "cyclecode", true));
            this.cyclecodeTextBox.Location = new System.Drawing.Point(133, 71);
            this.cyclecodeTextBox.Name = "cyclecodeTextBox";
            this.cyclecodeTextBox.Size = new System.Drawing.Size(104, 20);
            this.cyclecodeTextBox.TabIndex = 2;
            // 
            // cycledescriptionTextBox
            // 
            this.cycledescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcycleBindingSource, "cycledescription", true));
            this.cycledescriptionTextBox.Location = new System.Drawing.Point(133, 97);
            this.cycledescriptionTextBox.Name = "cycledescriptionTextBox";
            this.cycledescriptionTextBox.Size = new System.Drawing.Size(398, 20);
            this.cycledescriptionTextBox.TabIndex = 4;
            // 
            // cycleweeksTextBox
            // 
            this.cycleweeksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcycleBindingSource, "cycleweeks", true));
            this.cycleweeksTextBox.Location = new System.Drawing.Point(133, 123);
            this.cycleweeksTextBox.Name = "cycleweeksTextBox";
            this.cycleweeksTextBox.Size = new System.Drawing.Size(104, 20);
            this.cycleweeksTextBox.TabIndex = 6;
            // 
            // cyclepacksTextBox
            // 
            this.cyclepacksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcycleBindingSource, "cyclepacks", true));
            this.cyclepacksTextBox.Location = new System.Drawing.Point(133, 149);
            this.cyclepacksTextBox.Name = "cyclepacksTextBox";
            this.cyclepacksTextBox.Size = new System.Drawing.Size(104, 20);
            this.cyclepacksTextBox.TabIndex = 8;
            // 
            // cyclehideCheckBox
            // 
            this.cyclehideCheckBox.AutoCheck = false;
            this.cyclehideCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblcycleBindingSource, "cyclehide", true));
            this.cyclehideCheckBox.Location = new System.Drawing.Point(368, 137);
            this.cyclehideCheckBox.Name = "cyclehideCheckBox";
            this.cyclehideCheckBox.Size = new System.Drawing.Size(19, 24);
            this.cyclehideCheckBox.TabIndex = 12;
            this.cyclehideCheckBox.UseVisualStyleBackColor = true;
            this.cyclehideCheckBox.Click += new System.EventHandler(this.cyclehideCheckBox_Click);
            // 
            // cycleidTextBox
            // 
            this.cycleidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcycleBindingSource, "cycleid", true));
            this.cycleidTextBox.Location = new System.Drawing.Point(14, 74);
            this.cycleidTextBox.Name = "cycleidTextBox";
            this.cycleidTextBox.Size = new System.Drawing.Size(100, 20);
            this.cycleidTextBox.TabIndex = 13;
            this.cycleidTextBox.Visible = false;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(104, 192);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(133, 47);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Save and Close";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(254, 192);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(133, 47);
            this.btncancel.TabIndex = 15;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Edit Cycle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmcycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cycleidTextBox);
            this.Controls.Add(cyclecodeLabel);
            this.Controls.Add(this.cyclecodeTextBox);
            this.Controls.Add(cycledescriptionLabel);
            this.Controls.Add(this.cycledescriptionTextBox);
            this.Controls.Add(cycleweeksLabel);
            this.Controls.Add(this.cycleweeksTextBox);
            this.Controls.Add(cyclepacksLabel);
            this.Controls.Add(this.cyclepacksTextBox);
            this.Controls.Add(cyclehideLabel);
            this.Controls.Add(this.cyclehideCheckBox);
            this.Name = "frmcycle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcycle";
            this.Load += new System.EventHandler(this.frmcycle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private websterdbDataSet websterdbDataSet;
        private System.Windows.Forms.BindingSource tblcycleBindingSource;
        private websterdbDataSetTableAdapters.tblcycleTableAdapter tblcycleTableAdapter;
        private websterdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cyclecodeTextBox;
        private System.Windows.Forms.TextBox cycledescriptionTextBox;
        private System.Windows.Forms.TextBox cycleweeksTextBox;
        private System.Windows.Forms.TextBox cyclepacksTextBox;
        private System.Windows.Forms.CheckBox cyclehideCheckBox;
        private System.Windows.Forms.TextBox cycleidTextBox;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label1;
    }
}