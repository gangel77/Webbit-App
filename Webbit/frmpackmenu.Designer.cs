namespace PackChecker
{
    partial class frmpackmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpackmenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.circprogpack = new CircularProgressBar.CircularProgressBar();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnopenfrmpack = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnmessages = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelgridarea = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaccepted = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridmessage = new System.Windows.Forms.DataGridView();
            this.clnmessageid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnmsgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnmessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnsender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnactioneddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnacceptuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnview = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnaccept = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panelgridarea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridmessage)).BeginInit();
            this.SuspendLayout();
            // 
            // circprogpack
            // 
            this.circprogpack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circprogpack.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circprogpack.AnimationSpeed = 200;
            this.circprogpack.BackColor = System.Drawing.Color.Transparent;
            this.circprogpack.Font = new System.Drawing.Font("Myriad Pro", 30F);
            this.circprogpack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.circprogpack.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.circprogpack.InnerMargin = 1;
            this.circprogpack.InnerWidth = -1;
            this.circprogpack.Location = new System.Drawing.Point(352, 145);
            this.circprogpack.MarqueeAnimationSpeed = 900;
            this.circprogpack.Name = "circprogpack";
            this.circprogpack.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(206)))), ((int)(((byte)(178)))));
            this.circprogpack.OuterMargin = -25;
            this.circprogpack.OuterWidth = 25;
            this.circprogpack.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.circprogpack.ProgressWidth = 25;
            this.circprogpack.SecondaryFont = new System.Drawing.Font("Myriad Pro Cond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circprogpack.Size = new System.Drawing.Size(248, 235);
            this.circprogpack.StartAngle = 270;
            this.circprogpack.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.circprogpack.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circprogpack.SubscriptText = "%";
            this.circprogpack.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.circprogpack.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circprogpack.SuperscriptText = "";
            this.circprogpack.TabIndex = 10;
            this.circprogpack.Text = "100";
            this.circprogpack.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circprogpack.Value = 68;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnopenfrmpack
            // 
            this.btnopenfrmpack.ActiveBorderThickness = 1;
            this.btnopenfrmpack.ActiveCornerRadius = 10;
            this.btnopenfrmpack.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnopenfrmpack.ActiveForecolor = System.Drawing.Color.White;
            this.btnopenfrmpack.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnopenfrmpack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnopenfrmpack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.btnopenfrmpack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnopenfrmpack.BackgroundImage")));
            this.btnopenfrmpack.ButtonText = "Start Packing";
            this.btnopenfrmpack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnopenfrmpack.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold);
            this.btnopenfrmpack.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnopenfrmpack.IdleBorderThickness = 1;
            this.btnopenfrmpack.IdleCornerRadius = 10;
            this.btnopenfrmpack.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnopenfrmpack.IdleForecolor = System.Drawing.Color.White;
            this.btnopenfrmpack.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnopenfrmpack.Location = new System.Drawing.Point(384, 394);
            this.btnopenfrmpack.Margin = new System.Windows.Forms.Padding(6);
            this.btnopenfrmpack.Name = "btnopenfrmpack";
            this.btnopenfrmpack.Size = new System.Drawing.Size(180, 65);
            this.btnopenfrmpack.TabIndex = 17;
            this.btnopenfrmpack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnopenfrmpack.Click += new System.EventHandler(this.btnopenfrmpack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnmessages);
            this.panel1.Controls.Add(this.btnopenfrmpack);
            this.panel1.Controls.Add(this.circprogpack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 600);
            this.panel1.TabIndex = 18;
            
            // 
            // btnmessages
            // 
            this.btnmessages.ActiveBorderThickness = 1;
            this.btnmessages.ActiveCornerRadius = 10;
            this.btnmessages.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(123)))), ((int)(((byte)(142)))));
            this.btnmessages.ActiveForecolor = System.Drawing.Color.White;
            this.btnmessages.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(123)))), ((int)(((byte)(142)))));
            this.btnmessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.btnmessages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmessages.BackgroundImage")));
            this.btnmessages.ButtonText = "Show Accepted Messages";
            this.btnmessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmessages.Font = new System.Drawing.Font("Arial", 12.25F);
            this.btnmessages.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnmessages.IdleBorderThickness = 1;
            this.btnmessages.IdleCornerRadius = 10;
            this.btnmessages.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.btnmessages.IdleForecolor = System.Drawing.Color.White;
            this.btnmessages.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.btnmessages.Location = new System.Drawing.Point(711, 236);
            this.btnmessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmessages.Name = "btnmessages";
            this.btnmessages.Size = new System.Drawing.Size(128, 60);
            this.btnmessages.TabIndex = 20;
            this.btnmessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnmessages.Click += new System.EventHandler(this.btnmessages_Click);
            // 
            // panelgridarea
            // 
            this.panelgridarea.AutoSize = true;
            this.panelgridarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.panelgridarea.Controls.Add(this.label1);
            this.panelgridarea.Controls.Add(this.btnaccepted);
            this.panelgridarea.Controls.Add(this.dataGridmessage);
            this.panelgridarea.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelgridarea.Location = new System.Drawing.Point(350, 0);
            this.panelgridarea.Name = "panelgridarea";
            this.panelgridarea.Size = new System.Drawing.Size(600, 600);
            this.panelgridarea.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(160, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Patient Messages";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnaccepted
            // 
            this.btnaccepted.ActiveBorderThickness = 1;
            this.btnaccepted.ActiveCornerRadius = 10;
            this.btnaccepted.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(123)))), ((int)(((byte)(142)))));
            this.btnaccepted.ActiveForecolor = System.Drawing.Color.White;
            this.btnaccepted.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(123)))), ((int)(((byte)(142)))));
            this.btnaccepted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.btnaccepted.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaccepted.BackgroundImage")));
            this.btnaccepted.ButtonText = "Show Accepted Messages";
            this.btnaccepted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaccepted.Font = new System.Drawing.Font("Arial", 12.25F);
            this.btnaccepted.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnaccepted.IdleBorderThickness = 1;
            this.btnaccepted.IdleCornerRadius = 10;
            this.btnaccepted.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.btnaccepted.IdleForecolor = System.Drawing.Color.White;
            this.btnaccepted.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.btnaccepted.Location = new System.Drawing.Point(350, 460);
            this.btnaccepted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnaccepted.Name = "btnaccepted";
            this.btnaccepted.Size = new System.Drawing.Size(246, 46);
            this.btnaccepted.TabIndex = 18;
            this.btnaccepted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnaccepted.Click += new System.EventHandler(this.btnaccepted_Click);
            // 
            // dataGridmessage
            // 
            this.dataGridmessage.AllowUserToAddRows = false;
            this.dataGridmessage.AllowUserToDeleteRows = false;
            this.dataGridmessage.AllowUserToResizeColumns = false;
            this.dataGridmessage.AllowUserToResizeRows = false;
            this.dataGridmessage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.dataGridmessage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridmessage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridmessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridmessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnmessageid,
            this.clnmsgdate,
            this.clnpatient,
            this.clnmessage,
            this.clnsender,
            this.clnactioneddate,
            this.clnacceptuser,
            this.clnview,
            this.clnaccept});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridmessage.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridmessage.EnableHeadersVisualStyles = false;
            this.dataGridmessage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.dataGridmessage.Location = new System.Drawing.Point(14, 135);
            this.dataGridmessage.MultiSelect = false;
            this.dataGridmessage.Name = "dataGridmessage";
            this.dataGridmessage.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridmessage.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridmessage.RowHeadersVisible = false;
            this.dataGridmessage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridmessage.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridmessage.RowTemplate.Height = 25;
            this.dataGridmessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridmessage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridmessage.Size = new System.Drawing.Size(582, 324);
            this.dataGridmessage.TabIndex = 2;
            this.dataGridmessage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridmessage_CellContentClick);
            this.dataGridmessage.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridmessage_CellPainting);
            this.dataGridmessage.SelectionChanged += new System.EventHandler(this.dataGridmessage_SelectionChanged);
            // 
            // clnmessageid
            // 
            this.clnmessageid.HeaderText = "messageid";
            this.clnmessageid.Name = "clnmessageid";
            this.clnmessageid.ReadOnly = true;
            this.clnmessageid.Visible = false;
            this.clnmessageid.Width = 55;
            // 
            // clnmsgdate
            // 
            this.clnmsgdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clnmsgdate.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnmsgdate.HeaderText = "Sent Date";
            this.clnmsgdate.Name = "clnmsgdate";
            this.clnmsgdate.ReadOnly = true;
            this.clnmsgdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnmsgdate.Width = 88;
            // 
            // clnpatient
            // 
            this.clnpatient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnpatient.HeaderText = "Patient";
            this.clnpatient.Name = "clnpatient";
            this.clnpatient.ReadOnly = true;
            // 
            // clnmessage
            // 
            this.clnmessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnmessage.HeaderText = "Message";
            this.clnmessage.Name = "clnmessage";
            this.clnmessage.ReadOnly = true;
            this.clnmessage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnmessage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnmessage.Visible = false;
            // 
            // clnsender
            // 
            this.clnsender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnsender.HeaderText = "From";
            this.clnsender.Name = "clnsender";
            this.clnsender.ReadOnly = true;
            this.clnsender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnsender.Width = 52;
            // 
            // clnactioneddate
            // 
            this.clnactioneddate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clnactioneddate.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnactioneddate.HeaderText = "Read Date";
            this.clnactioneddate.Name = "clnactioneddate";
            this.clnactioneddate.ReadOnly = true;
            this.clnactioneddate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnactioneddate.Visible = false;
            // 
            // clnacceptuser
            // 
            this.clnacceptuser.HeaderText = "Accepted User";
            this.clnacceptuser.Name = "clnacceptuser";
            this.clnacceptuser.ReadOnly = true;
            this.clnacceptuser.Visible = false;
            // 
            // clnview
            // 
            this.clnview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clnview.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnview.HeaderText = "View";
            this.clnview.Name = "clnview";
            this.clnview.ReadOnly = true;
            this.clnview.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnview.Width = 49;
            // 
            // clnaccept
            // 
            this.clnaccept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnaccept.HeaderText = "Accept";
            this.clnaccept.Name = "clnaccept";
            this.clnaccept.ReadOnly = true;
            this.clnaccept.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnaccept.Width = 65;
            // 
            // frmpackmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelgridarea);
            this.Name = "frmpackmenu";
            this.Size = new System.Drawing.Size(950, 600);
            this.Load += new System.EventHandler(this.frmpackmenu_Load);
            this.panel1.ResumeLayout(false);
            this.panelgridarea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridmessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CircularProgressBar.CircularProgressBar circprogpack;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnopenfrmpack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelgridarea;
        private System.Windows.Forms.DataGridView dataGridmessage;
        private Bunifu.Framework.UI.BunifuThinButton2 btnaccepted;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnmessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnmessageid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnmsgdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnmessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnsender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnactioneddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnacceptuser;
        private System.Windows.Forms.DataGridViewButtonColumn clnview;
        private System.Windows.Forms.DataGridViewButtonColumn clnaccept;
    }
}