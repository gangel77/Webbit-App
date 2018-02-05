namespace PackChecker
{
    partial class frmdelivreportviewer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdelivreportviewer));
            this.rptdeliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webbitdbdataset = new PackChecker.webbitdbdataset();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rptdeliveryTableAdapter = new PackChecker.webbitdbdatasetTableAdapters.rptdeliveryTableAdapter();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.rptdeliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptdeliveryBindingSource
            // 
            this.rptdeliveryBindingSource.DataMember = "rptdelivery";
            this.rptdeliveryBindingSource.DataSource = this.webbitdbdataset;
            // 
            // webbitdbdataset
            // 
            this.webbitdbdataset.DataSetName = "webbitdbdataset";
            this.webbitdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "rptdelivery";
            reportDataSource1.Value = this.rptdeliveryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PackChecker.rptdelivery.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1061, 631);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 657);
            this.panel1.TabIndex = 1;
            // 
            // rptdeliveryTableAdapter
            // 
            this.rptdeliveryTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 10;
            this.btnClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 10;
            this.btnClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnClose.IdleForecolor = System.Drawing.Color.White;
            this.btnClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnClose.Location = new System.Drawing.Point(477, 678);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 54);
            this.btnClose.TabIndex = 20;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmdelivreportviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 748);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmdelivreportviewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmdelivreportviewer";
            this.Load += new System.EventHandler(this.frmdelivreportviewer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmdelivreportviewer_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.rptdeliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbitdbdataset)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource rptdeliveryBindingSource;
        private webbitdbdataset webbitdbdataset;
        private webbitdbdatasetTableAdapters.rptdeliveryTableAdapter rptdeliveryTableAdapter;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
    }
}