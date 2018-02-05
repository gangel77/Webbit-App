namespace PackChecker
{
    partial class frmimportinstitutions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmimportinstitutions));
            this.dataGridInst = new System.Windows.Forms.DataGridView();
            this.chkimport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clninstiname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkcommunity = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clninstid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clndispinstid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNext = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnwhatiscom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInst)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridInst
            // 
            this.dataGridInst.AllowUserToAddRows = false;
            this.dataGridInst.AllowUserToDeleteRows = false;
            this.dataGridInst.AllowUserToResizeColumns = false;
            this.dataGridInst.AllowUserToResizeRows = false;
            this.dataGridInst.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridInst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridInst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkimport,
            this.clninstiname,
            this.chkcommunity,
            this.clninstid,
            this.clndispinstid});
            this.dataGridInst.EnableHeadersVisualStyles = false;
            this.dataGridInst.Location = new System.Drawing.Point(68, 171);
            this.dataGridInst.Name = "dataGridInst";
            this.dataGridInst.RowHeadersVisible = false;
            this.dataGridInst.Size = new System.Drawing.Size(330, 200);
            this.dataGridInst.TabIndex = 1;
            this.dataGridInst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInst_CellContentClick);
            this.dataGridInst.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridInst_CurrentCellDirtyStateChanged);
            this.dataGridInst.SelectionChanged += new System.EventHandler(this.dataGridInst_SelectionChanged);
            // 
            // chkimport
            // 
            this.chkimport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.chkimport.FalseValue = "false";
            this.chkimport.HeaderText = "Is DAA";
            this.chkimport.Name = "chkimport";
            this.chkimport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkimport.TrueValue = "true";
            this.chkimport.Width = 46;
            // 
            // clninstiname
            // 
            this.clninstiname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clninstiname.HeaderText = "Name";
            this.clninstiname.Name = "clninstiname";
            this.clninstiname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // chkcommunity
            // 
            this.chkcommunity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.chkcommunity.FalseValue = "false";
            this.chkcommunity.HeaderText = "Community";
            this.chkcommunity.Name = "chkcommunity";
            this.chkcommunity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkcommunity.TrueValue = "true";
            this.chkcommunity.Width = 64;
            // 
            // clninstid
            // 
            this.clninstid.HeaderText = "Instid";
            this.clninstid.Name = "clninstid";
            this.clninstid.Visible = false;
            // 
            // clndispinstid
            // 
            this.clndispinstid.HeaderText = "dispinstid";
            this.clndispinstid.Name = "clndispinstid";
            this.clndispinstid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Institutions to connect to Webbit";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Institution Selector for LOTS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btncancel.Location = new System.Drawing.Point(268, 379);
            this.btncancel.Margin = new System.Windows.Forms.Padding(5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(98, 54);
            this.btncancel.TabIndex = 22;
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.ActiveBorderThickness = 1;
            this.btnNext.ActiveCornerRadius = 10;
            this.btnNext.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnNext.ActiveForecolor = System.Drawing.Color.White;
            this.btnNext.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.ButtonText = "Next";
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNext.IdleBorderThickness = 1;
            this.btnNext.IdleCornerRadius = 10;
            this.btnNext.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnNext.IdleForecolor = System.Drawing.Color.White;
            this.btnNext.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnNext.Location = new System.Drawing.Point(99, 379);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 54);
            this.btnNext.TabIndex = 24;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnwhatiscom
            // 
            this.btnwhatiscom.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnwhatiscom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnwhatiscom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnwhatiscom.BorderRadius = 0;
            this.btnwhatiscom.ButtonText = "What is a Community Patient?";
            this.btnwhatiscom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnwhatiscom.DisabledColor = System.Drawing.Color.Gray;
            this.btnwhatiscom.Iconcolor = System.Drawing.Color.Transparent;
            this.btnwhatiscom.Iconimage = global::PackChecker.Properties.Resources.Blue_Questionmark;
            this.btnwhatiscom.Iconimage_right = null;
            this.btnwhatiscom.Iconimage_right_Selected = null;
            this.btnwhatiscom.Iconimage_Selected = null;
            this.btnwhatiscom.IconMarginLeft = 0;
            this.btnwhatiscom.IconMarginRight = 0;
            this.btnwhatiscom.IconRightVisible = true;
            this.btnwhatiscom.IconRightZoom = 0D;
            this.btnwhatiscom.IconVisible = false;
            this.btnwhatiscom.IconZoom = 60D;
            this.btnwhatiscom.IsTab = false;
            this.btnwhatiscom.Location = new System.Drawing.Point(117, 122);
            this.btnwhatiscom.Name = "btnwhatiscom";
            this.btnwhatiscom.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnwhatiscom.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnwhatiscom.OnHoverTextColor = System.Drawing.Color.White;
            this.btnwhatiscom.selected = false;
            this.btnwhatiscom.Size = new System.Drawing.Size(260, 31);
            this.btnwhatiscom.TabIndex = 25;
            this.btnwhatiscom.Text = "What is a Community Patient?";
            this.btnwhatiscom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnwhatiscom.Textcolor = System.Drawing.Color.White;
            this.btnwhatiscom.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwhatiscom.Click += new System.EventHandler(this.btnwhatiscom_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.btnwhatiscom;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // frmimportinstitutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 448);
            this.Controls.Add(this.btnwhatiscom);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridInst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmimportinstitutions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmimportinstitutions";
            this.Load += new System.EventHandler(this.frmimportinstitutions_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmimportinstitutions_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridInst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btncancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNext;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkimport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clninstiname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkcommunity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clninstid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clndispinstid;
        private Bunifu.Framework.UI.BunifuFlatButton btnwhatiscom;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}