namespace PackChecker
{
    partial class frmchecking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridChecked = new System.Windows.Forms.DataGridView();
            this.packid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnorigcycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpatientid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pxname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCycleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpackeduser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncheck = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnPackComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnreversecheck = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnerror = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChecked)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridChecked
            // 
            this.dataGridChecked.AllowUserToAddRows = false;
            this.dataGridChecked.AllowUserToDeleteRows = false;
            this.dataGridChecked.AllowUserToResizeColumns = false;
            this.dataGridChecked.AllowUserToResizeRows = false;
            this.dataGridChecked.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridChecked.BackgroundColor = System.Drawing.Color.White;
            this.dataGridChecked.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridChecked.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridChecked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChecked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packid,
            this.clnorigcycle,
            this.clnpatientid,
            this.pxname,
            this.clnCycleDate,
            this.clncode,
            this.clnpackeduser,
            this.clncheck,
            this.clnPackComment,
            this.clnreversecheck,
            this.clnerror,
            this.clnactive});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridChecked.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridChecked.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridChecked.Location = new System.Drawing.Point(20, 68);
            this.dataGridChecked.MultiSelect = false;
            this.dataGridChecked.Name = "dataGridChecked";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridChecked.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridChecked.RowHeadersVisible = false;
            this.dataGridChecked.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridChecked.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridChecked.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridChecked.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridChecked.Size = new System.Drawing.Size(934, 482);
            this.dataGridChecked.TabIndex = 0;
            this.dataGridChecked.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChecked_CellContentClick);
            this.dataGridChecked.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChecked_CellDoubleClick);
            this.dataGridChecked.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridChecked_CellPainting);
            this.dataGridChecked.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridChecked_KeyDown);
            // 
            // packid
            // 
            this.packid.HeaderText = "packid";
            this.packid.Name = "packid";
            this.packid.Visible = false;
            this.packid.Width = 61;
            // 
            // clnorigcycle
            // 
            this.clnorigcycle.HeaderText = "origcycle";
            this.clnorigcycle.Name = "clnorigcycle";
            this.clnorigcycle.Visible = false;
            // 
            // clnpatientid
            // 
            this.clnpatientid.HeaderText = "PatientID";
            this.clnpatientid.Name = "clnpatientid";
            this.clnpatientid.Visible = false;
            this.clnpatientid.Width = 82;
            // 
            // pxname
            // 
            this.pxname.HeaderText = "Patient";
            this.pxname.Name = "pxname";
            this.pxname.ReadOnly = true;
            this.pxname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pxname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pxname.Width = 200;
            // 
            // clnCycleDate
            // 
            this.clnCycleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnCycleDate.HeaderText = "Cycle Date";
            this.clnCycleDate.Name = "clnCycleDate";
            this.clnCycleDate.ReadOnly = true;
            this.clnCycleDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnCycleDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnCycleDate.Width = 92;
            // 
            // clncode
            // 
            this.clncode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clncode.HeaderText = "Cycle Type";
            this.clncode.Name = "clncode";
            this.clncode.ReadOnly = true;
            this.clncode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clncode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncode.Width = 91;
            // 
            // clnpackeduser
            // 
            this.clnpackeduser.HeaderText = "Packer";
            this.clnpackeduser.Name = "clnpackeduser";
            this.clnpackeduser.ReadOnly = true;
            this.clnpackeduser.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnpackeduser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnpackeduser.Width = 60;
            // 
            // clncheck
            // 
            this.clncheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clncheck.HeaderText = "Check";
            this.clncheck.Name = "clncheck";
            this.clncheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clncheck.Width = 60;
            // 
            // clnPackComment
            // 
            this.clnPackComment.HeaderText = "Pack Comment";
            this.clnPackComment.Name = "clnPackComment";
            this.clnPackComment.ReadOnly = true;
            this.clnPackComment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnPackComment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnPackComment.Width = 250;
            // 
            // clnreversecheck
            // 
            this.clnreversecheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clnreversecheck.HeaderText = "Reverse";
            this.clnreversecheck.Name = "clnreversecheck";
            this.clnreversecheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnreversecheck.Width = 74;
            // 
            // clnerror
            // 
            this.clnerror.HeaderText = "Error";
            this.clnerror.Name = "clnerror";
            this.clnerror.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnerror.Width = 69;
            // 
            // clnactive
            // 
            this.clnactive.HeaderText = "active";
            this.clnactive.Name = "clnactive";
            this.clnactive.ReadOnly = true;
            this.clnactive.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Checking List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.IndianRed;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(375, 572);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(229, 39);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(25, 20);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(182, 33);
            this.lblusername.TabIndex = 5;
            this.lblusername.Text = "Current User";
            // 
            // frmchecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 623);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridChecked);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmchecking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmchecking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChecked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn packid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnorigcycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpatientid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pxname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCycleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpackeduser;
        private System.Windows.Forms.DataGridViewButtonColumn clncheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPackComment;
        private System.Windows.Forms.DataGridViewButtonColumn clnreversecheck;
        private System.Windows.Forms.DataGridViewButtonColumn clnerror;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnactive;
    }
}

