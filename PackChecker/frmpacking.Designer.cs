namespace PackChecker
{
    partial class frmpacking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridPacked = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.tblpackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.websterdbDataSet = new PackChecker.websterdbDataSet();
            this.websterdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpackTableAdapter = new PackChecker.websterdbDataSetTableAdapters.tblpackTableAdapter();
            this.lblusername = new System.Windows.Forms.Label();
            this.packid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pxname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpacksize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCycleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPackComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpackeduser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpack = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnreversepack = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPacked
            // 
            this.dataGridPacked.AllowUserToAddRows = false;
            this.dataGridPacked.AllowUserToDeleteRows = false;
            this.dataGridPacked.AllowUserToResizeColumns = false;
            this.dataGridPacked.AllowUserToResizeRows = false;
            this.dataGridPacked.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPacked.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPacked.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPacked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packid,
            this.pxname,
            this.clnpacksize,
            this.clncode,
            this.clnCycleDate,
            this.clnPackComment,
            this.clnpackeduser,
            this.clnpack,
            this.clnreversepack});
            this.dataGridPacked.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridPacked.Location = new System.Drawing.Point(25, 68);
            this.dataGridPacked.MultiSelect = false;
            this.dataGridPacked.Name = "dataGridPacked";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPacked.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPacked.RowHeadersVisible = false;
            this.dataGridPacked.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridPacked.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPacked.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridPacked.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPacked.Size = new System.Drawing.Size(881, 482);
            this.dataGridPacked.TabIndex = 2;
            this.dataGridPacked.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacked_CellContentClick);
            this.dataGridPacked.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacked_CellContentClick);
            this.dataGridPacked.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacked_CellContentDoubleClick);
            this.dataGridPacked.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridPacked_CellPainting);
            this.dataGridPacked.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridPacked_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Packing List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.IndianRed;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(269, 566);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(229, 39);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // tblpackBindingSource
            // 
            this.tblpackBindingSource.DataMember = "tblpack";
            this.tblpackBindingSource.DataSource = this.websterdbDataSet;
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
            // tblpackTableAdapter
            // 
            this.tblpackTableAdapter.ClearBeforeFill = true;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(12, 23);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(182, 33);
            this.lblusername.TabIndex = 8;
            this.lblusername.Text = "Current User";
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
            this.pxname.HeaderText = "Patient Name";
            this.pxname.Name = "pxname";
            this.pxname.ReadOnly = true;
            this.pxname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pxname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pxname.Width = 200;
            // 
            // clnpacksize
            // 
            this.clnpacksize.HeaderText = "Pack Size";
            this.clnpacksize.Name = "clnpacksize";
            this.clnpacksize.ReadOnly = true;
            this.clnpacksize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnpacksize.Width = 85;
            // 
            // clncode
            // 
            this.clncode.HeaderText = "Cycle Type";
            this.clncode.Name = "clncode";
            this.clncode.ReadOnly = true;
            this.clncode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clncode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clncode.Width = 95;
            // 
            // clnCycleDate
            // 
            this.clnCycleDate.HeaderText = "Pack Date";
            this.clnCycleDate.Name = "clnCycleDate";
            this.clnCycleDate.ReadOnly = true;
            this.clnCycleDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnCycleDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnCycleDate.Width = 92;
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
            // clnpackeduser
            // 
            this.clnpackeduser.HeaderText = "packeduser";
            this.clnpackeduser.Name = "clnpackeduser";
            this.clnpackeduser.ReadOnly = true;
            this.clnpackeduser.Visible = false;
            // 
            // clnpack
            // 
            this.clnpack.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnpack.HeaderText = "Pack";
            this.clnpack.Name = "clnpack";
            this.clnpack.Width = 50;
            // 
            // clnreversepack
            // 
            this.clnreversepack.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnreversepack.HeaderText = "Reverse";
            this.clnreversepack.Name = "clnreversepack";
            this.clnreversepack.Width = 74;
            // 
            // frmpacking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 636);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridPacked);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmpacking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packing List";
            this.Load += new System.EventHandler(this.frmpacking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websterdbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridPacked;
        private System.Windows.Forms.BindingSource websterdbDataSetBindingSource;
        private websterdbDataSet websterdbDataSet;
        private System.Windows.Forms.BindingSource tblpackBindingSource;
        private websterdbDataSetTableAdapters.tblpackTableAdapter tblpackTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn packid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pxname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpacksize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCycleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPackComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpackeduser;
        private System.Windows.Forms.DataGridViewButtonColumn clnpack;
        private System.Windows.Forms.DataGridViewButtonColumn clnreversepack;
    }
}

