namespace PackChecker
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnclosetop = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnminimise = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelactive = new System.Windows.Forms.Panel();
            this.pnlbuttons = new System.Windows.Forms.Panel();
            this.btndeliveries = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncollectmenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnmanagepacks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnpackmenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnreports = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncloseweb = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncheckmenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblversion = new System.Windows.Forms.Label();
            this.automaticUpdater = new wyDay.Controls.AutomaticUpdater();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclosetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimise)).BeginInit();
            this.pnlbuttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdater)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::PackChecker.Properties.Resources.Webbit_Logo;
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(20, 45);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(252, 75);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            // 
            // btnclosetop
            // 
            this.btnclosetop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btnclosetop.Image = ((System.Drawing.Image)(resources.GetObject("btnclosetop.Image")));
            this.btnclosetop.ImageActive = null;
            this.btnclosetop.Location = new System.Drawing.Point(1266, 0);
            this.btnclosetop.Name = "btnclosetop";
            this.btnclosetop.Size = new System.Drawing.Size(24, 28);
            this.btnclosetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclosetop.TabIndex = 4;
            this.btnclosetop.TabStop = false;
            this.btnclosetop.Zoom = 10;
            this.btnclosetop.Click += new System.EventHandler(this.btnclosetop_Click);
            // 
            // btnminimise
            // 
            this.btnminimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnminimise.Image = ((System.Drawing.Image)(resources.GetObject("btnminimise.Image")));
            this.btnminimise.ImageActive = null;
            this.btnminimise.Location = new System.Drawing.Point(1242, 0);
            this.btnminimise.Name = "btnminimise";
            this.btnminimise.Size = new System.Drawing.Size(24, 28);
            this.btnminimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimise.TabIndex = 3;
            this.btnminimise.TabStop = false;
            this.btnminimise.Zoom = 10;
            this.btnminimise.Click += new System.EventHandler(this.btnminimise_Click);
            // 
            // panelactive
            // 
            this.panelactive.Location = new System.Drawing.Point(303, 33);
            this.panelactive.Name = "panelactive";
            this.panelactive.Size = new System.Drawing.Size(976, 600);
            this.panelactive.TabIndex = 17;
            // 
            // pnlbuttons
            // 
            this.pnlbuttons.Controls.Add(this.btndeliveries);
            this.pnlbuttons.Controls.Add(this.btncollectmenu);
            this.pnlbuttons.Controls.Add(this.btnmanagepacks);
            this.pnlbuttons.Controls.Add(this.btnpackmenu);
            this.pnlbuttons.Controls.Add(this.btnreports);
            this.pnlbuttons.Controls.Add(this.btncloseweb);
            this.pnlbuttons.Controls.Add(this.btncheckmenu);
            this.pnlbuttons.Controls.Add(this.btnsettings);
            this.pnlbuttons.Location = new System.Drawing.Point(3, 24);
            this.pnlbuttons.Name = "pnlbuttons";
            this.pnlbuttons.Size = new System.Drawing.Size(283, 608);
            this.pnlbuttons.TabIndex = 18;
            // 
            // btndeliveries
            // 
            this.btndeliveries.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.btndeliveries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.btndeliveries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndeliveries.BorderRadius = 0;
            this.btndeliveries.ButtonText = "          DELIVERIES";
            this.btndeliveries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeliveries.DisabledColor = System.Drawing.Color.Gray;
            this.btndeliveries.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold);
            this.btndeliveries.Iconcolor = System.Drawing.Color.Transparent;
            this.btndeliveries.Iconimage = ((System.Drawing.Image)(resources.GetObject("btndeliveries.Iconimage")));
            this.btndeliveries.Iconimage_right = null;
            this.btndeliveries.Iconimage_right_Selected = null;
            this.btndeliveries.Iconimage_Selected = null;
            this.btndeliveries.IconMarginLeft = 0;
            this.btndeliveries.IconMarginRight = 0;
            this.btndeliveries.IconRightVisible = false;
            this.btndeliveries.IconRightZoom = 0D;
            this.btndeliveries.IconVisible = false;
            this.btndeliveries.IconZoom = 90D;
            this.btndeliveries.IsTab = false;
            this.btndeliveries.Location = new System.Drawing.Point(-11, 323);
            this.btndeliveries.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btndeliveries.Name = "btndeliveries";
            this.btndeliveries.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.btndeliveries.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(123)))), ((int)(((byte)(142)))));
            this.btndeliveries.OnHoverTextColor = System.Drawing.Color.White;
            this.btndeliveries.selected = false;
            this.btndeliveries.Size = new System.Drawing.Size(273, 48);
            this.btndeliveries.TabIndex = 6;
            this.btndeliveries.Text = "          DELIVERIES";
            this.btndeliveries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeliveries.Textcolor = System.Drawing.Color.White;
            this.btndeliveries.TextFont = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btndeliveries.Click += new System.EventHandler(this.btndeliveries_Click);
            // 
            // btncollectmenu
            // 
            this.btncollectmenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            this.btncollectmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            this.btncollectmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncollectmenu.BorderRadius = 0;
            this.btncollectmenu.ButtonText = "          COLLECTING";
            this.btncollectmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncollectmenu.DisabledColor = System.Drawing.Color.Gray;
            this.btncollectmenu.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold);
            this.btncollectmenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btncollectmenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncollectmenu.Iconimage")));
            this.btncollectmenu.Iconimage_right = null;
            this.btncollectmenu.Iconimage_right_Selected = null;
            this.btncollectmenu.Iconimage_Selected = null;
            this.btncollectmenu.IconMarginLeft = 0;
            this.btncollectmenu.IconMarginRight = 0;
            this.btncollectmenu.IconRightVisible = false;
            this.btncollectmenu.IconRightZoom = 0D;
            this.btncollectmenu.IconVisible = false;
            this.btncollectmenu.IconZoom = 90D;
            this.btncollectmenu.IsTab = false;
            this.btncollectmenu.Location = new System.Drawing.Point(-11, 143);
            this.btncollectmenu.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btncollectmenu.Name = "btncollectmenu";
            this.btncollectmenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            this.btncollectmenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(231)))), ((int)(((byte)(125)))));
            this.btncollectmenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btncollectmenu.selected = false;
            this.btncollectmenu.Size = new System.Drawing.Size(273, 48);
            this.btncollectmenu.TabIndex = 0;
            this.btncollectmenu.Text = "          COLLECTING";
            this.btncollectmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncollectmenu.Textcolor = System.Drawing.Color.White;
            this.btncollectmenu.TextFont = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btncollectmenu.Click += new System.EventHandler(this.btncollectmenu_Click);
            // 
            // btnmanagepacks
            // 
            this.btnmanagepacks.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnmanagepacks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnmanagepacks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmanagepacks.BorderRadius = 0;
            this.btnmanagepacks.ButtonText = "          MANAGEMENT";
            this.btnmanagepacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmanagepacks.DisabledColor = System.Drawing.Color.Gray;
            this.btnmanagepacks.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold);
            this.btnmanagepacks.Iconcolor = System.Drawing.Color.Transparent;
            this.btnmanagepacks.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnmanagepacks.Iconimage")));
            this.btnmanagepacks.Iconimage_right = null;
            this.btnmanagepacks.Iconimage_right_Selected = null;
            this.btnmanagepacks.Iconimage_Selected = null;
            this.btnmanagepacks.IconMarginLeft = 0;
            this.btnmanagepacks.IconMarginRight = 0;
            this.btnmanagepacks.IconRightVisible = false;
            this.btnmanagepacks.IconRightZoom = 0D;
            this.btnmanagepacks.IconVisible = false;
            this.btnmanagepacks.IconZoom = 90D;
            this.btnmanagepacks.IsTab = false;
            this.btnmanagepacks.Location = new System.Drawing.Point(-11, 383);
            this.btnmanagepacks.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnmanagepacks.Name = "btnmanagepacks";
            this.btnmanagepacks.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btnmanagepacks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnmanagepacks.OnHoverTextColor = System.Drawing.Color.White;
            this.btnmanagepacks.selected = false;
            this.btnmanagepacks.Size = new System.Drawing.Size(273, 48);
            this.btnmanagepacks.TabIndex = 5;
            this.btnmanagepacks.Text = "          MANAGEMENT";
            this.btnmanagepacks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmanagepacks.Textcolor = System.Drawing.Color.White;
            this.btnmanagepacks.TextFont = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnmanagepacks.Click += new System.EventHandler(this.btnmanagepacks_Click);
            // 
            // btnpackmenu
            // 
            this.btnpackmenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnpackmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnpackmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpackmenu.BorderRadius = 0;
            this.btnpackmenu.ButtonText = "          PACKING";
            this.btnpackmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpackmenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnpackmenu.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold);
            this.btnpackmenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnpackmenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnpackmenu.Iconimage")));
            this.btnpackmenu.Iconimage_right = null;
            this.btnpackmenu.Iconimage_right_Selected = null;
            this.btnpackmenu.Iconimage_Selected = null;
            this.btnpackmenu.IconMarginLeft = 0;
            this.btnpackmenu.IconMarginRight = 0;
            this.btnpackmenu.IconRightVisible = false;
            this.btnpackmenu.IconRightZoom = 0D;
            this.btnpackmenu.IconVisible = false;
            this.btnpackmenu.IconZoom = 90D;
            this.btnpackmenu.IsTab = false;
            this.btnpackmenu.Location = new System.Drawing.Point(-11, 203);
            this.btnpackmenu.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnpackmenu.Name = "btnpackmenu";
            this.btnpackmenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnpackmenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnpackmenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnpackmenu.selected = false;
            this.btnpackmenu.Size = new System.Drawing.Size(273, 48);
            this.btnpackmenu.TabIndex = 1;
            this.btnpackmenu.Text = "          PACKING";
            this.btnpackmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpackmenu.Textcolor = System.Drawing.Color.White;
            this.btnpackmenu.TextFont = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnpackmenu.Click += new System.EventHandler(this.btnpackmenu_Click);
            // 
            // btnreports
            // 
            this.btnreports.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnreports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnreports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreports.BorderRadius = 0;
            this.btnreports.ButtonText = "          REPORTS";
            this.btnreports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreports.DisabledColor = System.Drawing.Color.Gray;
            this.btnreports.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold);
            this.btnreports.Iconcolor = System.Drawing.Color.Transparent;
            this.btnreports.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnreports.Iconimage")));
            this.btnreports.Iconimage_right = null;
            this.btnreports.Iconimage_right_Selected = null;
            this.btnreports.Iconimage_Selected = null;
            this.btnreports.IconMarginLeft = 0;
            this.btnreports.IconMarginRight = 0;
            this.btnreports.IconRightVisible = false;
            this.btnreports.IconRightZoom = 0D;
            this.btnreports.IconVisible = false;
            this.btnreports.IconZoom = 90D;
            this.btnreports.IsTab = false;
            this.btnreports.Location = new System.Drawing.Point(-11, 443);
            this.btnreports.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnreports.Name = "btnreports";
            this.btnreports.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(73)))));
            this.btnreports.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(183)))), ((int)(((byte)(143)))));
            this.btnreports.OnHoverTextColor = System.Drawing.Color.White;
            this.btnreports.selected = false;
            this.btnreports.Size = new System.Drawing.Size(273, 48);
            this.btnreports.TabIndex = 4;
            this.btnreports.Text = "          REPORTS";
            this.btnreports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreports.Textcolor = System.Drawing.Color.White;
            this.btnreports.TextFont = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btncloseweb
            // 
            this.btncloseweb.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.btncloseweb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.btncloseweb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncloseweb.BorderRadius = 0;
            this.btncloseweb.ButtonText = "Close";
            this.btncloseweb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncloseweb.DisabledColor = System.Drawing.Color.Gray;
            this.btncloseweb.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold);
            this.btncloseweb.Iconcolor = System.Drawing.Color.Transparent;
            this.btncloseweb.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncloseweb.Iconimage")));
            this.btncloseweb.Iconimage_right = null;
            this.btncloseweb.Iconimage_right_Selected = null;
            this.btncloseweb.Iconimage_Selected = null;
            this.btncloseweb.IconMarginLeft = 0;
            this.btncloseweb.IconMarginRight = 0;
            this.btncloseweb.IconRightVisible = false;
            this.btncloseweb.IconRightZoom = 0D;
            this.btncloseweb.IconVisible = false;
            this.btncloseweb.IconZoom = 90D;
            this.btncloseweb.IsTab = false;
            this.btncloseweb.Location = new System.Drawing.Point(-11, 569);
            this.btncloseweb.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btncloseweb.Name = "btncloseweb";
            this.btncloseweb.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.btncloseweb.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(123)))), ((int)(((byte)(142)))));
            this.btncloseweb.OnHoverTextColor = System.Drawing.Color.White;
            this.btncloseweb.selected = false;
            this.btncloseweb.Size = new System.Drawing.Size(171, 25);
            this.btncloseweb.TabIndex = 19;
            this.btncloseweb.Text = "Close";
            this.btncloseweb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncloseweb.Textcolor = System.Drawing.Color.White;
            this.btncloseweb.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btncloseweb.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // btncheckmenu
            // 
            this.btncheckmenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btncheckmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btncheckmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncheckmenu.BorderRadius = 0;
            this.btncheckmenu.ButtonText = "          CHECKING";
            this.btncheckmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheckmenu.DisabledColor = System.Drawing.Color.Gray;
            this.btncheckmenu.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold);
            this.btncheckmenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btncheckmenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncheckmenu.Iconimage")));
            this.btncheckmenu.Iconimage_right = null;
            this.btncheckmenu.Iconimage_right_Selected = null;
            this.btncheckmenu.Iconimage_Selected = null;
            this.btncheckmenu.IconMarginLeft = 0;
            this.btncheckmenu.IconMarginRight = 0;
            this.btncheckmenu.IconRightVisible = false;
            this.btncheckmenu.IconRightZoom = 0D;
            this.btncheckmenu.IconVisible = false;
            this.btncheckmenu.IconZoom = 90D;
            this.btncheckmenu.IsTab = false;
            this.btncheckmenu.Location = new System.Drawing.Point(-11, 263);
            this.btncheckmenu.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btncheckmenu.Name = "btncheckmenu";
            this.btncheckmenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.btncheckmenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btncheckmenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btncheckmenu.selected = false;
            this.btncheckmenu.Size = new System.Drawing.Size(273, 48);
            this.btncheckmenu.TabIndex = 2;
            this.btncheckmenu.Text = "          CHECKING";
            this.btncheckmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncheckmenu.Textcolor = System.Drawing.Color.White;
            this.btncheckmenu.TextFont = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btncheckmenu.Click += new System.EventHandler(this.btncheckmenu_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            this.btnsettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            this.btnsettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsettings.BorderRadius = 0;
            this.btnsettings.ButtonText = "          SETTINGS";
            this.btnsettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsettings.DisabledColor = System.Drawing.Color.Gray;
            this.btnsettings.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold);
            this.btnsettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsettings.Iconimage")));
            this.btnsettings.Iconimage_right = null;
            this.btnsettings.Iconimage_right_Selected = null;
            this.btnsettings.Iconimage_Selected = null;
            this.btnsettings.IconMarginLeft = 0;
            this.btnsettings.IconMarginRight = 0;
            this.btnsettings.IconRightVisible = false;
            this.btnsettings.IconRightZoom = 0D;
            this.btnsettings.IconVisible = false;
            this.btnsettings.IconZoom = 90D;
            this.btnsettings.IsTab = false;
            this.btnsettings.Location = new System.Drawing.Point(-11, 503);
            this.btnsettings.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            this.btnsettings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(231)))), ((int)(((byte)(125)))));
            this.btnsettings.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsettings.selected = false;
            this.btnsettings.Size = new System.Drawing.Size(273, 48);
            this.btnsettings.TabIndex = 3;
            this.btnsettings.Text = "          SETTINGS";
            this.btnsettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.Textcolor = System.Drawing.Color.White;
            this.btnsettings.TextFont = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Font = new System.Drawing.Font("Myriad Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.lblversion.Location = new System.Drawing.Point(1137, 9);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(41, 13);
            this.lblversion.TabIndex = 19;
            this.lblversion.Text = "version";
            // 
            // automaticUpdater
            // 
            this.automaticUpdater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.automaticUpdater.ContainerForm = this;
            this.automaticUpdater.DaysBetweenChecks = 1;
            this.automaticUpdater.GUID = "634c9b33-8784-4ee6-8703-5c7a7ba79dcb";
            this.automaticUpdater.Location = new System.Drawing.Point(272, 4);
            this.automaticUpdater.Name = "automaticUpdater";
            this.automaticUpdater.Size = new System.Drawing.Size(16, 16);
            this.automaticUpdater.TabIndex = 20;
            this.automaticUpdater.ToolStripItem = this.toolStripMenuItem1;
            this.automaticUpdater.wyUpdateCommandline = null;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "Update";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1291, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.menuStrip1_Paint);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.btncollectmenu;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.btndeliveries;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this.btnmanagepacks;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 10;
            this.bunifuElipse5.TargetControl = this.btnpackmenu;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 10;
            this.bunifuElipse6.TargetControl = this.btnreports;
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 10;
            this.bunifuElipse7.TargetControl = this.btnsettings;
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 10;
            this.bunifuElipse8.TargetControl = this.btncheckmenu;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.btncloseweb;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1291, 644);
            this.Controls.Add(this.automaticUpdater);
            this.Controls.Add(this.lblversion);
            this.Controls.Add(this.panelactive);
            this.Controls.Add(this.btnclosetop);
            this.Controls.Add(this.btnminimise);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.pnlbuttons);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpeningPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPage_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclosetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimise)).EndInit();
            this.pnlbuttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdater)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnminimise;
        private Bunifu.Framework.UI.BunifuImageButton btnclosetop;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panelactive;
        private System.Windows.Forms.Panel pnlbuttons;
        private System.Windows.Forms.Label lblversion;
        private wyDay.Controls.AutomaticUpdater automaticUpdater;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Bunifu.Framework.UI.BunifuFlatButton btndeliveries;
        private Bunifu.Framework.UI.BunifuFlatButton btnmanagepacks;
        private Bunifu.Framework.UI.BunifuFlatButton btnreports;
        private Bunifu.Framework.UI.BunifuFlatButton btnsettings;
        private Bunifu.Framework.UI.BunifuFlatButton btncheckmenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnpackmenu;
        private Bunifu.Framework.UI.BunifuFlatButton btncollectmenu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private Bunifu.Framework.UI.BunifuFlatButton btncloseweb;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}