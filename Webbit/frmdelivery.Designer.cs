namespace PackChecker
{
    partial class frmdelivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdelivery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridChecked = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.packid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pxname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCycleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPackComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clndelivered = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnreversecheck = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChecked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridChecked
            // 
            this.dataGridChecked.AllowUserToAddRows = false;
            this.dataGridChecked.AllowUserToDeleteRows = false;
            this.dataGridChecked.AllowUserToResizeColumns = false;
            this.dataGridChecked.AllowUserToResizeRows = false;
            this.dataGridChecked.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridChecked.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridChecked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChecked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packid,
            this.pxname,
            this.clnCycleDate,
            this.clnPackComment,
            this.clndelivered,
            this.clnreversecheck,
            this.clnactive});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridChecked.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridChecked.EnableHeadersVisualStyles = false;
            this.dataGridChecked.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.dataGridChecked.Location = new System.Drawing.Point(27, 68);
            this.dataGridChecked.MultiSelect = false;
            this.dataGridChecked.Name = "dataGridChecked";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridChecked.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridChecked.RowHeadersVisible = false;
            this.dataGridChecked.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridChecked.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridChecked.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridChecked.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridChecked.Size = new System.Drawing.Size(1012, 482);
            this.dataGridChecked.TabIndex = 0;
            this.dataGridChecked.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChecked_CellContentClick);
            this.dataGridChecked.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChecked_CellDoubleClick);
            this.dataGridChecked.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridChecked_CellPainting);
            this.dataGridChecked.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridChecked_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(408, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Delivery List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblusername.Location = new System.Drawing.Point(47, 20);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(148, 30);
            this.lblusername.TabIndex = 5;
            this.lblusername.Text = "Current User";
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
            this.btnclose.ButtonText = "Close";
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnclose.IdleBorderThickness = 1;
            this.btnclose.IdleCornerRadius = 10;
            this.btnclose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclose.IdleForecolor = System.Drawing.Color.White;
            this.btnclose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnclose.Location = new System.Drawing.Point(337, 575);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 54);
            this.btnclose.TabIndex = 20;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclose.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(13, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 512);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PackChecker.Properties.Resources.icon_user;
            this.pictureBox1.Location = new System.Drawing.Point(13, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // packid
            // 
            this.packid.HeaderText = "packid";
            this.packid.Name = "packid";
            this.packid.Visible = false;
            this.packid.Width = 61;
            // 
            // pxname
            // 
            this.pxname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.pxname.DefaultCellStyle = dataGridViewCellStyle2;
            this.pxname.FillWeight = 40F;
            this.pxname.HeaderText = "Patient";
            this.pxname.Name = "pxname";
            this.pxname.ReadOnly = true;
            this.pxname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pxname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnCycleDate
            // 
            this.clnCycleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clnCycleDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnCycleDate.HeaderText = "Pack Date";
            this.clnCycleDate.MinimumWidth = 100;
            this.clnCycleDate.Name = "clnCycleDate";
            this.clnCycleDate.ReadOnly = true;
            this.clnCycleDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnCycleDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnPackComment
            // 
            this.clnPackComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clnPackComment.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnPackComment.FillWeight = 60F;
            this.clnPackComment.HeaderText = "Pack Comment";
            this.clnPackComment.MinimumWidth = 60;
            this.clnPackComment.Name = "clnPackComment";
            this.clnPackComment.ReadOnly = true;
            this.clnPackComment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnPackComment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clndelivered
            // 
            this.clndelivered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clndelivered.HeaderText = "Delivered";
            this.clndelivered.Name = "clndelivered";
            this.clndelivered.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clndelivered.Width = 80;
            // 
            // clnreversecheck
            // 
            this.clnreversecheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.clnreversecheck.DefaultCellStyle = dataGridViewCellStyle5;
            this.clnreversecheck.HeaderText = "Undo";
            this.clnreversecheck.Name = "clnreversecheck";
            this.clnreversecheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnreversecheck.Width = 52;
            // 
            // clnactive
            // 
            this.clnactive.HeaderText = "active";
            this.clnactive.Name = "clnactive";
            this.clnactive.ReadOnly = true;
            this.clnactive.Visible = false;
            // 
            // frmdelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 645);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridChecked);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmdelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checking";
            this.Load += new System.EventHandler(this.frmchecking_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmdelivery_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChecked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusername;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn packid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pxname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCycleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPackComment;
        private System.Windows.Forms.DataGridViewButtonColumn clndelivered;
        private System.Windows.Forms.DataGridViewButtonColumn clnreversecheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnactive;
    }
}

