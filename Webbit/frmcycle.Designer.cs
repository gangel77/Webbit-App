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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcycle));
            this.webbitdbdataset = new PackChecker.webbitdbdataset();
            this.tblcycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblcycleTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.tblcycleTableAdapter();
            this.tableAdapterManager = new PackChecker.webbitdbdatasetTableAdapters.TableAdapterManager();
            this.cyclecodeTextBox = new System.Windows.Forms.TextBox();
            this.cycledescriptionTextBox = new System.Windows.Forms.TextBox();
            this.cycleweeksTextBox = new System.Windows.Forms.TextBox();
            this.cyclepacksTextBox = new System.Windows.Forms.TextBox();
            this.cyclehideCheckBox = new System.Windows.Forms.CheckBox();
            this.cycleidTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnsave = new Bunifu.Framework.UI.BunifuThinButton2();
            cyclecodeLabel = new System.Windows.Forms.Label();
            cycledescriptionLabel = new System.Windows.Forms.Label();
            cycleweeksLabel = new System.Windows.Forms.Label();
            cyclepacksLabel = new System.Windows.Forms.Label();
            cyclehideLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cyclecodeLabel
            // 
            cyclecodeLabel.AutoSize = true;
            cyclecodeLabel.Font = new System.Drawing.Font("Myriad Pro", 10.25F);
            cyclecodeLabel.Location = new System.Drawing.Point(18, 74);
            cyclecodeLabel.Name = "cyclecodeLabel";
            cyclecodeLabel.Size = new System.Drawing.Size(76, 17);
            cyclecodeLabel.TabIndex = 1;
            cyclecodeLabel.Text = "Cycle Code:";
            // 
            // cycledescriptionLabel
            // 
            cycledescriptionLabel.AutoSize = true;
            cycledescriptionLabel.Font = new System.Drawing.Font("Myriad Pro", 10.25F);
            cycledescriptionLabel.Location = new System.Drawing.Point(18, 97);
            cycledescriptionLabel.Name = "cycledescriptionLabel";
            cycledescriptionLabel.Size = new System.Drawing.Size(113, 17);
            cycledescriptionLabel.TabIndex = 3;
            cycledescriptionLabel.Text = "Cycle Description:";
            // 
            // cycleweeksLabel
            // 
            cycleweeksLabel.AutoSize = true;
            cycleweeksLabel.Font = new System.Drawing.Font("Myriad Pro", 10.25F);
            cycleweeksLabel.Location = new System.Drawing.Point(18, 146);
            cycleweeksLabel.Name = "cycleweeksLabel";
            cycleweeksLabel.Size = new System.Drawing.Size(98, 17);
            cycleweeksLabel.TabIndex = 5;
            cycleweeksLabel.Text = "Weeks in Cycle:";
            // 
            // cyclepacksLabel
            // 
            cyclepacksLabel.AutoSize = true;
            cyclepacksLabel.Font = new System.Drawing.Font("Myriad Pro", 10.25F);
            cyclepacksLabel.Location = new System.Drawing.Point(18, 172);
            cyclepacksLabel.Name = "cyclepacksLabel";
            cyclepacksLabel.Size = new System.Drawing.Size(142, 17);
            cyclepacksLabel.TabIndex = 7;
            cyclepacksLabel.Text = "Physical Packs in Cycle:";
            // 
            // cyclehideLabel
            // 
            cyclehideLabel.AutoSize = true;
            cyclehideLabel.Font = new System.Drawing.Font("Myriad Pro", 10.25F);
            cyclehideLabel.Location = new System.Drawing.Point(18, 202);
            cyclehideLabel.Name = "cyclehideLabel";
            cyclehideLabel.Size = new System.Drawing.Size(125, 17);
            cyclehideLabel.TabIndex = 11;
            cyclehideLabel.Text = "Don\'t use this cycle:";
            // 
            // webbitdbdataset
            // 
            this.webbitdbdataset.DataSetName = "webbitdbdataset";
            this.webbitdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcycleBindingSource
            // 
            this.tblcycleBindingSource.DataMember = "tblcycle";
            this.tblcycleBindingSource.DataSource = this.webbitdbdataset;
            // 
            // tblcycleTableAdapter
            // 
            this.tblcycleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.casualpxTableAdapter = null;
            this.tableAdapterManager.tblcycleTableAdapter = this.tblcycleTableAdapter;
            this.tableAdapterManager.tbldateTableAdapter = null;
            this.tableAdapterManager.tblinstitutionTableAdapter = null;
            this.tableAdapterManager.tbljobTableAdapter = null;
            this.tableAdapterManager.tblpacklocationTableAdapter = null;
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
            // cyclecodeTextBox
            // 
            this.cyclecodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcycleBindingSource, "cyclecode", true));
            this.cyclecodeTextBox.Location = new System.Drawing.Point(170, 71);
            this.cyclecodeTextBox.Name = "cyclecodeTextBox";
            this.cyclecodeTextBox.Size = new System.Drawing.Size(104, 20);
            this.cyclecodeTextBox.TabIndex = 0;
            this.cyclecodeTextBox.TextChanged += new System.EventHandler(this.cyclecodeTextBox_TextChanged);
            // 
            // cycledescriptionTextBox
            // 
            this.cycledescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcycleBindingSource, "cycledescription", true));
            this.cycledescriptionTextBox.Enabled = false;
            this.cycledescriptionTextBox.Location = new System.Drawing.Point(170, 97);
            this.cycledescriptionTextBox.Multiline = true;
            this.cycledescriptionTextBox.Name = "cycledescriptionTextBox";
            this.cycledescriptionTextBox.Size = new System.Drawing.Size(347, 40);
            this.cycledescriptionTextBox.TabIndex = 1;
            // 
            // cycleweeksTextBox
            // 
            this.cycleweeksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcycleBindingSource, "cycleweeks", true));
            this.cycleweeksTextBox.Enabled = false;
            this.cycleweeksTextBox.Location = new System.Drawing.Point(170, 144);
            this.cycleweeksTextBox.Name = "cycleweeksTextBox";
            this.cycleweeksTextBox.Size = new System.Drawing.Size(35, 20);
            this.cycleweeksTextBox.TabIndex = 6;
            this.cycleweeksTextBox.TabStop = false;
            this.cycleweeksTextBox.TextChanged += new System.EventHandler(this.cycleweeksTextBox_TextChanged);
            // 
            // cyclepacksTextBox
            // 
            this.cyclepacksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcycleBindingSource, "cyclepacks", true));
            this.cyclepacksTextBox.Enabled = false;
            this.cyclepacksTextBox.Location = new System.Drawing.Point(170, 170);
            this.cyclepacksTextBox.Name = "cyclepacksTextBox";
            this.cyclepacksTextBox.Size = new System.Drawing.Size(35, 20);
            this.cyclepacksTextBox.TabIndex = 8;
            this.cyclepacksTextBox.TabStop = false;
            this.cyclepacksTextBox.TextChanged += new System.EventHandler(this.cyclepacksTextBox_TextChanged);
            // 
            // cyclehideCheckBox
            // 
            this.cyclehideCheckBox.AutoCheck = false;
            this.cyclehideCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblcycleBindingSource, "cyclehide", true));
            this.cyclehideCheckBox.Location = new System.Drawing.Point(171, 200);
            this.cyclehideCheckBox.Name = "cyclehideCheckBox";
            this.cyclehideCheckBox.Size = new System.Drawing.Size(19, 24);
            this.cyclehideCheckBox.TabIndex = 3;
            this.cyclehideCheckBox.UseVisualStyleBackColor = true;
            this.cyclehideCheckBox.Click += new System.EventHandler(this.cyclehideCheckBox_Click);
            // 
            // cycleidTextBox
            // 
            this.cycleidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcycleBindingSource, "cycleid", true));
            this.cycleidTextBox.Location = new System.Drawing.Point(21, 22);
            this.cycleidTextBox.Name = "cycleidTextBox";
            this.cycleidTextBox.Size = new System.Drawing.Size(100, 20);
            this.cycleidTextBox.TabIndex = 13;
            this.cycleidTextBox.TabStop = false;
            this.cycleidTextBox.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Edit Cycle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnclose
            // 
            this.btnclose.ActiveBorderThickness = 1;
            this.btnclose.ActiveCornerRadius = 10;
            this.btnclose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclose.ActiveForecolor = System.Drawing.Color.White;
            this.btnclose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnclose.BackColor = System.Drawing.Color.White;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.ButtonText = "Cancel";
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnclose.IdleBorderThickness = 1;
            this.btnclose.IdleCornerRadius = 10;
            this.btnclose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclose.IdleForecolor = System.Drawing.Color.White;
            this.btnclose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclose.Location = new System.Drawing.Point(412, 151);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 54);
            this.btnclose.TabIndex = 22;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclose.Click += new System.EventHandler(this.btncancel_Click);
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
            this.btnsave.Location = new System.Drawing.Point(247, 151);
            this.btnsave.Margin = new System.Windows.Forms.Padding(5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(155, 54);
            this.btnsave.TabIndex = 4;
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmcycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 240);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcycle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcycle";
            this.Load += new System.EventHandler(this.frmcycle_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmcycle_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcycleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private webbitdbdataset webbitdbdataset;
        private System.Windows.Forms.BindingSource tblcycleBindingSource;
        private webbitdbdatasetTableAdapters.tblcycleTableAdapter tblcycleTableAdapter;
        private webbitdbdatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cyclecodeTextBox;
        private System.Windows.Forms.TextBox cycledescriptionTextBox;
        private System.Windows.Forms.TextBox cycleweeksTextBox;
        private System.Windows.Forms.TextBox cyclepacksTextBox;
        private System.Windows.Forms.CheckBox cyclehideCheckBox;
        private System.Windows.Forms.TextBox cycleidTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
    }
}