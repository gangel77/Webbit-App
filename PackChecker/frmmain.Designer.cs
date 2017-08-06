namespace PackChecker
{
    partial class frmmain
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
            this.websterdbDataSet = new PackChecker.websterdbDataSet();
            this.websterdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnopencollect = new System.Windows.Forms.Button();
            this.cmbpatient = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabmain = new System.Windows.Forms.TabControl();
            this.tabcollect = new System.Windows.Forms.TabPage();
            this.tabpack = new System.Windows.Forms.TabPage();
            this.lblpacking = new System.Windows.Forms.Label();
            this.btnopenfrmpack = new System.Windows.Forms.Button();
            this.tabcheck = new System.Windows.Forms.TabPage();
            this.lblchecking = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.tabfunctions = new System.Windows.Forms.TabPage();
            this.btntraysizes = new System.Windows.Forms.Button();
            this.btnforcecycle = new System.Windows.Forms.Button();
            this.btninitpacks = new System.Windows.Forms.Button();
            this.btnjobs = new System.Windows.Forms.Button();
            this.btnusers = new System.Windows.Forms.Button();
            this.btnlocations = new System.Windows.Forms.Button();
            this.btncycle = new System.Windows.Forms.Button();
            this.btnpxlist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSetBindingSource)).BeginInit();
            this.tabmain.SuspendLayout();
            this.tabcollect.SuspendLayout();
            this.tabpack.SuspendLayout();
            this.tabcheck.SuspendLayout();
            this.tabfunctions.SuspendLayout();
            this.SuspendLayout();
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
            // btnopencollect
            // 
            this.btnopencollect.AutoSize = true;
            this.btnopencollect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopencollect.Location = new System.Drawing.Point(425, 265);
            this.btnopencollect.Name = "btnopencollect";
            this.btnopencollect.Size = new System.Drawing.Size(175, 64);
            this.btnopencollect.TabIndex = 4;
            this.btnopencollect.Text = "Open Collection";
            this.btnopencollect.UseVisualStyleBackColor = true;
            this.btnopencollect.Click += new System.EventHandler(this.btnopencollect_Click);
            // 
            // cmbpatient
            // 
            this.cmbpatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbpatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpatient.FormattingEnabled = true;
            this.cmbpatient.Location = new System.Drawing.Point(320, 184);
            this.cmbpatient.Name = "cmbpatient";
            this.cmbpatient.Size = new System.Drawing.Size(365, 32);
            this.cmbpatient.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(313, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(405, 71);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Webster Collections";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabmain
            // 
            this.tabmain.Controls.Add(this.tabcollect);
            this.tabmain.Controls.Add(this.tabpack);
            this.tabmain.Controls.Add(this.tabcheck);
            this.tabmain.Controls.Add(this.tabfunctions);
            this.tabmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabmain.Location = new System.Drawing.Point(0, 0);
            this.tabmain.Name = "tabmain";
            this.tabmain.SelectedIndex = 0;
            this.tabmain.Size = new System.Drawing.Size(1151, 640);
            this.tabmain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabmain.TabIndex = 0;
            // 
            // tabcollect
            // 
            this.tabcollect.BackColor = System.Drawing.Color.Transparent;
            this.tabcollect.Controls.Add(this.btnopencollect);
            this.tabcollect.Controls.Add(this.cmbpatient);
            this.tabcollect.Controls.Add(this.lblTitle);
            this.tabcollect.Location = new System.Drawing.Point(4, 33);
            this.tabcollect.Name = "tabcollect";
            this.tabcollect.Padding = new System.Windows.Forms.Padding(3);
            this.tabcollect.Size = new System.Drawing.Size(1143, 603);
            this.tabcollect.TabIndex = 0;
            this.tabcollect.Text = "Collect";
            // 
            // tabpack
            // 
            this.tabpack.Controls.Add(this.lblpacking);
            this.tabpack.Controls.Add(this.btnopenfrmpack);
            this.tabpack.Location = new System.Drawing.Point(4, 33);
            this.tabpack.Name = "tabpack";
            this.tabpack.Padding = new System.Windows.Forms.Padding(3);
            this.tabpack.Size = new System.Drawing.Size(1143, 603);
            this.tabpack.TabIndex = 1;
            this.tabpack.Text = "Pack";
            this.tabpack.UseVisualStyleBackColor = true;
            // 
            // lblpacking
            // 
            this.lblpacking.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpacking.Location = new System.Drawing.Point(330, 85);
            this.lblpacking.Name = "lblpacking";
            this.lblpacking.Size = new System.Drawing.Size(405, 71);
            this.lblpacking.TabIndex = 6;
            this.lblpacking.Text = "Packing";
            this.lblpacking.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnopenfrmpack
            // 
            this.btnopenfrmpack.BackColor = System.Drawing.Color.Orange;
            this.btnopenfrmpack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.btnopenfrmpack.Location = new System.Drawing.Point(427, 159);
            this.btnopenfrmpack.Name = "btnopenfrmpack";
            this.btnopenfrmpack.Size = new System.Drawing.Size(209, 89);
            this.btnopenfrmpack.TabIndex = 6;
            this.btnopenfrmpack.Text = "Start Packing";
            this.btnopenfrmpack.UseVisualStyleBackColor = false;
            this.btnopenfrmpack.Click += new System.EventHandler(this.btnopenfrmpack_Click_1);
            // 
            // tabcheck
            // 
            this.tabcheck.Controls.Add(this.lblchecking);
            this.tabcheck.Controls.Add(this.btncheck);
            this.tabcheck.Location = new System.Drawing.Point(4, 33);
            this.tabcheck.Name = "tabcheck";
            this.tabcheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabcheck.Size = new System.Drawing.Size(1143, 603);
            this.tabcheck.TabIndex = 2;
            this.tabcheck.Text = "Check";
            this.tabcheck.UseVisualStyleBackColor = true;
            // 
            // lblchecking
            // 
            this.lblchecking.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchecking.Location = new System.Drawing.Point(349, 69);
            this.lblchecking.Name = "lblchecking";
            this.lblchecking.Size = new System.Drawing.Size(405, 71);
            this.lblchecking.TabIndex = 7;
            this.lblchecking.Text = "Checking";
            this.lblchecking.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.PaleGreen;
            this.btncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(440, 221);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(210, 89);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "Start Checking";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click_1);
            // 
            // tabfunctions
            // 
            this.tabfunctions.BackColor = System.Drawing.Color.Transparent;
            this.tabfunctions.Controls.Add(this.btntraysizes);
            this.tabfunctions.Controls.Add(this.btnforcecycle);
            this.tabfunctions.Controls.Add(this.btninitpacks);
            this.tabfunctions.Controls.Add(this.btnjobs);
            this.tabfunctions.Controls.Add(this.btnusers);
            this.tabfunctions.Controls.Add(this.btnlocations);
            this.tabfunctions.Controls.Add(this.btncycle);
            this.tabfunctions.Controls.Add(this.btnpxlist);
            this.tabfunctions.Location = new System.Drawing.Point(4, 33);
            this.tabfunctions.Name = "tabfunctions";
            this.tabfunctions.Padding = new System.Windows.Forms.Padding(3);
            this.tabfunctions.Size = new System.Drawing.Size(1143, 603);
            this.tabfunctions.TabIndex = 4;
            this.tabfunctions.Text = "Functions";
            // 
            // btntraysizes
            // 
            this.btntraysizes.Location = new System.Drawing.Point(732, 227);
            this.btntraysizes.Name = "btntraysizes";
            this.btntraysizes.Size = new System.Drawing.Size(178, 41);
            this.btntraysizes.TabIndex = 11;
            this.btntraysizes.Text = "Tray Sizes";
            this.btntraysizes.UseVisualStyleBackColor = true;
            this.btntraysizes.Click += new System.EventHandler(this.btntraysizes_Click);
            // 
            // btnforcecycle
            // 
            this.btnforcecycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnforcecycle.Location = new System.Drawing.Point(39, 151);
            this.btnforcecycle.Name = "btnforcecycle";
            this.btnforcecycle.Size = new System.Drawing.Size(205, 90);
            this.btnforcecycle.TabIndex = 10;
            this.btnforcecycle.Text = "Force Next Cycle";
            this.btnforcecycle.UseVisualStyleBackColor = true;
            this.btnforcecycle.Click += new System.EventHandler(this.btnforcecycle_Click);
            // 
            // btninitpacks
            // 
            this.btninitpacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninitpacks.Location = new System.Drawing.Point(39, 49);
            this.btninitpacks.Name = "btninitpacks";
            this.btninitpacks.Size = new System.Drawing.Size(205, 90);
            this.btninitpacks.TabIndex = 9;
            this.btninitpacks.Text = "INIT PACKS";
            this.btninitpacks.UseVisualStyleBackColor = true;
            this.btninitpacks.Click += new System.EventHandler(this.btninitpacks_Click);
            // 
            // btnjobs
            // 
            this.btnjobs.Location = new System.Drawing.Point(732, 84);
            this.btnjobs.Name = "btnjobs";
            this.btnjobs.Size = new System.Drawing.Size(178, 41);
            this.btnjobs.TabIndex = 4;
            this.btnjobs.Text = "Job Positions";
            this.btnjobs.UseVisualStyleBackColor = true;
            this.btnjobs.Click += new System.EventHandler(this.btnjobs_Click);
            // 
            // btnusers
            // 
            this.btnusers.Location = new System.Drawing.Point(732, 37);
            this.btnusers.Name = "btnusers";
            this.btnusers.Size = new System.Drawing.Size(178, 41);
            this.btnusers.TabIndex = 3;
            this.btnusers.Text = "Users";
            this.btnusers.UseVisualStyleBackColor = true;
            this.btnusers.Click += new System.EventHandler(this.btnusers_Click);
            // 
            // btnlocations
            // 
            this.btnlocations.Location = new System.Drawing.Point(732, 180);
            this.btnlocations.Name = "btnlocations";
            this.btnlocations.Size = new System.Drawing.Size(178, 41);
            this.btnlocations.TabIndex = 2;
            this.btnlocations.Text = "Locations";
            this.btnlocations.UseVisualStyleBackColor = true;
            this.btnlocations.Click += new System.EventHandler(this.btnlocations_Click);
            // 
            // btncycle
            // 
            this.btncycle.Location = new System.Drawing.Point(732, 131);
            this.btncycle.Name = "btncycle";
            this.btncycle.Size = new System.Drawing.Size(178, 41);
            this.btncycle.TabIndex = 1;
            this.btncycle.Text = "Packing Cycles";
            this.btncycle.UseVisualStyleBackColor = true;
            this.btncycle.Click += new System.EventHandler(this.btncycle_Click);
            // 
            // btnpxlist
            // 
            this.btnpxlist.Location = new System.Drawing.Point(398, 88);
            this.btnpxlist.Name = "btnpxlist";
            this.btnpxlist.Size = new System.Drawing.Size(154, 51);
            this.btnpxlist.TabIndex = 0;
            this.btnpxlist.Text = "Patient List";
            this.btnpxlist.UseVisualStyleBackColor = true;
            this.btnpxlist.Click += new System.EventHandler(this.btnpxlist_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 640);
            this.Controls.Add(this.tabmain);
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webbit Main Menu";
            this.Load += new System.EventHandler(this.frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSetBindingSource)).EndInit();
            this.tabmain.ResumeLayout(false);
            this.tabcollect.ResumeLayout(false);
            this.tabcollect.PerformLayout();
            this.tabpack.ResumeLayout(false);
            this.tabcheck.ResumeLayout(false);
            this.tabfunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource websterdbDataSetBindingSource;
        private websterdbDataSet websterdbDataSet;
        private System.Windows.Forms.Button btnopencollect;
        private System.Windows.Forms.ComboBox cmbpatient;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabmain;
        private System.Windows.Forms.TabPage tabcollect;
        private System.Windows.Forms.TabPage tabpack;
        private System.Windows.Forms.TabPage tabcheck;
        private System.Windows.Forms.Button btnopenfrmpack;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label lblpacking;
        private System.Windows.Forms.Label lblchecking;
        private System.Windows.Forms.TabPage tabfunctions;
        private System.Windows.Forms.Button btnpxlist;
        private System.Windows.Forms.Button btncycle;
        private System.Windows.Forms.Button btnlocations;
        private System.Windows.Forms.Button btnusers;
        private System.Windows.Forms.Button btnjobs;
        private System.Windows.Forms.Button btnforcecycle;
        private System.Windows.Forms.Button btninitpacks;
        private System.Windows.Forms.Button btntraysizes;
    }
}