namespace virtual_receptionist.View
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowStatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuestRegistrationCard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRoomEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuestDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBilling = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAccomodationInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelpSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemHelpCHM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMainMenu = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelClient = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMenuName = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBoxVRLogo = new System.Windows.Forms.PictureBox();
            this.toolStripMainMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGuestRegistrationCard = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRoomEditor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuestDatabase = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBilling = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxBSLogo = new System.Windows.Forms.PictureBox();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.menuStripMainMenu.SuspendLayout();
            this.statusStripMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVRLogo)).BeginInit();
            this.toolStripMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBSLogo)).BeginInit();
            this.panelMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemView,
            this.toolStripMenuItemTools,
            this.toolStripMenuItemHelp});
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Size = new System.Drawing.Size(1008, 24);
            this.menuStripMainMenu.TabIndex = 0;
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLogout});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "Fájl";
            this.toolStripMenuItemFile.MouseLeave += new System.EventHandler(this.toolStripMenuItemFile_MouseLeave);
            this.toolStripMenuItemFile.MouseHover += new System.EventHandler(this.toolStripMenuItemFile_MouseHover);
            // 
            // toolStripMenuItemLogout
            // 
            this.toolStripMenuItemLogout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemLogout.Image")));
            this.toolStripMenuItemLogout.Name = "toolStripMenuItemLogout";
            this.toolStripMenuItemLogout.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItemLogout.Text = "Kijelentkezés";
            this.toolStripMenuItemLogout.Click += new System.EventHandler(this.toolStripMenuItemLogout_Click);
            this.toolStripMenuItemLogout.MouseLeave += new System.EventHandler(this.toolStripMenuItemLogout_MouseLeave);
            this.toolStripMenuItemLogout.MouseHover += new System.EventHandler(this.toolStripMenuItemLogout_MouseHover);
            // 
            // toolStripMenuItemView
            // 
            this.toolStripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShowStatusStrip,
            this.toolStripMenuItemShowToolStrip});
            this.toolStripMenuItemView.Name = "toolStripMenuItemView";
            this.toolStripMenuItemView.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItemView.Text = "Nézet";
            this.toolStripMenuItemView.MouseLeave += new System.EventHandler(this.toolStripMenuItemView_MouseLeave);
            this.toolStripMenuItemView.MouseHover += new System.EventHandler(this.toolStripMenuItemView_MouseHover);
            // 
            // toolStripMenuItemShowStatusStrip
            // 
            this.toolStripMenuItemShowStatusStrip.Checked = true;
            this.toolStripMenuItemShowStatusStrip.CheckOnClick = true;
            this.toolStripMenuItemShowStatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemShowStatusStrip.Name = "toolStripMenuItemShowStatusStrip";
            this.toolStripMenuItemShowStatusStrip.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItemShowStatusStrip.Text = "Állapotsor megjelenítése";
            this.toolStripMenuItemShowStatusStrip.CheckStateChanged += new System.EventHandler(this.toolStripMenuItemShowStatusStrip_CheckStateChanged);
            this.toolStripMenuItemShowStatusStrip.MouseLeave += new System.EventHandler(this.toolStripMenuItemShowStatusStrip_MouseLeave);
            this.toolStripMenuItemShowStatusStrip.MouseHover += new System.EventHandler(this.toolStripMenuItemShowStatusStrip_MouseHover);
            // 
            // toolStripMenuItemShowToolStrip
            // 
            this.toolStripMenuItemShowToolStrip.Checked = true;
            this.toolStripMenuItemShowToolStrip.CheckOnClick = true;
            this.toolStripMenuItemShowToolStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemShowToolStrip.Name = "toolStripMenuItemShowToolStrip";
            this.toolStripMenuItemShowToolStrip.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItemShowToolStrip.Text = "Eszköztár megjelenítése";
            this.toolStripMenuItemShowToolStrip.CheckStateChanged += new System.EventHandler(this.toolStripMenuItemShowToolStrip_CheckStateChanged);
            this.toolStripMenuItemShowToolStrip.MouseLeave += new System.EventHandler(this.toolStripMenuItemShowToolStrip_MouseLeave);
            this.toolStripMenuItemShowToolStrip.MouseHover += new System.EventHandler(this.toolStripMenuItemShowToolStrip_MouseHover);
            // 
            // toolStripMenuItemTools
            // 
            this.toolStripMenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemGuestRegistrationCard,
            this.toolStripMenuItemRoomEditor,
            this.toolStripMenuItemGuestDatabase,
            this.toolStripMenuItemBilling});
            this.toolStripMenuItemTools.Name = "toolStripMenuItemTools";
            this.toolStripMenuItemTools.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItemTools.Text = "Eszközök";
            this.toolStripMenuItemTools.MouseLeave += new System.EventHandler(this.toolStripMenuItemTools_MouseLeave);
            this.toolStripMenuItemTools.MouseHover += new System.EventHandler(this.toolStripMenuItemTools_MouseHover);
            // 
            // toolStripMenuItemGuestRegistrationCard
            // 
            this.toolStripMenuItemGuestRegistrationCard.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemGuestRegistrationCard.Image")));
            this.toolStripMenuItemGuestRegistrationCard.Name = "toolStripMenuItemGuestRegistrationCard";
            this.toolStripMenuItemGuestRegistrationCard.Size = new System.Drawing.Size(248, 22);
            this.toolStripMenuItemGuestRegistrationCard.Text = "Vendég bejelentkező lap kitöltése";
            this.toolStripMenuItemGuestRegistrationCard.Click += new System.EventHandler(this.toolStripMenuItemGuestRegistrationCard_Click);
            this.toolStripMenuItemGuestRegistrationCard.MouseLeave += new System.EventHandler(this.toolStripMenuItemGuestRegistrationCard_MouseLeave);
            this.toolStripMenuItemGuestRegistrationCard.MouseHover += new System.EventHandler(this.toolStripMenuItemGuestRegistrationCard_MouseHover);
            // 
            // toolStripMenuItemRoomEditor
            // 
            this.toolStripMenuItemRoomEditor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemRoomEditor.Image")));
            this.toolStripMenuItemRoomEditor.Name = "toolStripMenuItemRoomEditor";
            this.toolStripMenuItemRoomEditor.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemRoomEditor.Text = "Szobakezelő";
            this.toolStripMenuItemRoomEditor.Click += new System.EventHandler(this.toolStripMenuItemRoomEditor_Click);
            this.toolStripMenuItemRoomEditor.MouseLeave += new System.EventHandler(this.toolStripMenuItemRoomEditor_MouseLeave);
            this.toolStripMenuItemRoomEditor.MouseHover += new System.EventHandler(this.toolStripMenuItemRoomEditor_MouseHover);
            // 
            // toolStripMenuItemGuestDatabase
            // 
            this.toolStripMenuItemGuestDatabase.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemGuestDatabase.Image")));
            this.toolStripMenuItemGuestDatabase.Name = "toolStripMenuItemGuestDatabase";
            this.toolStripMenuItemGuestDatabase.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemGuestDatabase.Text = "Vendégadatbázis";
            this.toolStripMenuItemGuestDatabase.Click += new System.EventHandler(this.toolStripMenuItemGuestDatabase_Click);
            this.toolStripMenuItemGuestDatabase.MouseLeave += new System.EventHandler(this.toolStripMenuItemGuestDatabase_MouseLeave);
            this.toolStripMenuItemGuestDatabase.MouseHover += new System.EventHandler(this.toolStripMenuItemGuestDatabase_MouseHover);
            // 
            // toolStripMenuItemBilling
            // 
            this.toolStripMenuItemBilling.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemBilling.Image")));
            this.toolStripMenuItemBilling.Name = "toolStripMenuItemBilling";
            this.toolStripMenuItemBilling.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItemBilling.Text = "Számlázás";
            this.toolStripMenuItemBilling.Click += new System.EventHandler(this.toolStripMenuItemBilling_Click);
            this.toolStripMenuItemBilling.MouseLeave += new System.EventHandler(this.toolStripMenuItemBilling_MouseLeave);
            this.toolStripMenuItemBilling.MouseHover += new System.EventHandler(this.toolStripMenuItemBilling_MouseHover);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAccomodationInfo,
            this.toolStripMenuItemHelpSeparator,
            this.toolStripMenuItemHelpCHM,
            this.toolStripMenuItemWebsite,
            this.toolStripMenuItemAbout});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItemHelp.Text = "Súgó";
            this.toolStripMenuItemHelp.MouseLeave += new System.EventHandler(this.toolStripMenuItemHelp_MouseLeave);
            this.toolStripMenuItemHelp.MouseHover += new System.EventHandler(this.toolStripMenuItemHelp_MouseHover);
            // 
            // toolStripMenuItemAccomodationInfo
            // 
            this.toolStripMenuItemAccomodationInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAccomodationInfo.Image")));
            this.toolStripMenuItemAccomodationInfo.Name = "toolStripMenuItemAccomodationInfo";
            this.toolStripMenuItemAccomodationInfo.Size = new System.Drawing.Size(244, 22);
            this.toolStripMenuItemAccomodationInfo.Text = "Szálláshely adatai";
            this.toolStripMenuItemAccomodationInfo.Click += new System.EventHandler(this.toolStripMenuItemAccomodationInfo_Click);
            this.toolStripMenuItemAccomodationInfo.MouseLeave += new System.EventHandler(this.toolStripMenuItemAccomodationInfo_MouseLeave);
            this.toolStripMenuItemAccomodationInfo.MouseHover += new System.EventHandler(this.toolStripMenuItemAccomodationInfo_MouseHover);
            // 
            // toolStripMenuItemHelpSeparator
            // 
            this.toolStripMenuItemHelpSeparator.Name = "toolStripMenuItemHelpSeparator";
            this.toolStripMenuItemHelpSeparator.Size = new System.Drawing.Size(241, 6);
            // 
            // toolStripMenuItemHelpCHM
            // 
            this.toolStripMenuItemHelpCHM.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemHelpCHM.Image")));
            this.toolStripMenuItemHelpCHM.Name = "toolStripMenuItemHelpCHM";
            this.toolStripMenuItemHelpCHM.Size = new System.Drawing.Size(244, 22);
            this.toolStripMenuItemHelpCHM.Text = "Segítség";
            this.toolStripMenuItemHelpCHM.Click += new System.EventHandler(this.toolStripMenuItemHelpCHM_Click);
            this.toolStripMenuItemHelpCHM.MouseLeave += new System.EventHandler(this.toolStripMenuItemHelpCHM_MouseLeave);
            this.toolStripMenuItemHelpCHM.MouseHover += new System.EventHandler(this.toolStripMenuItemHelpCHM_MouseHover);
            // 
            // toolStripMenuItemWebsite
            // 
            this.toolStripMenuItemWebsite.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemWebsite.Image")));
            this.toolStripMenuItemWebsite.Name = "toolStripMenuItemWebsite";
            this.toolStripMenuItemWebsite.Size = new System.Drawing.Size(244, 22);
            this.toolStripMenuItemWebsite.Text = "A Virtual Receptionist weboldala";
            this.toolStripMenuItemWebsite.Click += new System.EventHandler(this.toolStripMenuItemWebsite_Click);
            this.toolStripMenuItemWebsite.MouseLeave += new System.EventHandler(this.toolStripMenuItemWebsite_MouseLeave);
            this.toolStripMenuItemWebsite.MouseHover += new System.EventHandler(this.toolStripMenuItemWebsite_MouseHover);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAbout.Image")));
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(244, 22);
            this.toolStripMenuItemAbout.Text = "Névjegy";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            this.toolStripMenuItemAbout.MouseLeave += new System.EventHandler(this.toolStripMenuItemAbout_MouseLeave);
            this.toolStripMenuItemAbout.MouseHover += new System.EventHandler(this.toolStripMenuItemAbout_MouseHover);
            // 
            // statusStripMainMenu
            // 
            this.statusStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelClient,
            this.toolStripStatusLabelServer,
            this.toolStripStatusLabelMenuName});
            this.statusStripMainMenu.Location = new System.Drawing.Point(0, 692);
            this.statusStripMainMenu.Name = "statusStripMainMenu";
            this.statusStripMainMenu.Size = new System.Drawing.Size(1008, 37);
            this.statusStripMainMenu.TabIndex = 1;
            // 
            // toolStripStatusLabelClient
            // 
            this.toolStripStatusLabelClient.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelClient.Image")));
            this.toolStripStatusLabelClient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabelClient.Name = "toolStripStatusLabelClient";
            this.toolStripStatusLabelClient.Size = new System.Drawing.Size(123, 32);
            this.toolStripStatusLabelClient.Text = "Munkaállomás: ";
            // 
            // toolStripStatusLabelServer
            // 
            this.toolStripStatusLabelServer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelServer.Image")));
            this.toolStripStatusLabelServer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabelServer.Name = "toolStripStatusLabelServer";
            this.toolStripStatusLabelServer.Size = new System.Drawing.Size(98, 32);
            this.toolStripStatusLabelServer.Text = "Kiszolgáló: ";
            // 
            // toolStripStatusLabelMenuName
            // 
            this.toolStripStatusLabelMenuName.Name = "toolStripStatusLabelMenuName";
            this.toolStripStatusLabelMenuName.Size = new System.Drawing.Size(0, 32);
            // 
            // pictureBoxVRLogo
            // 
            this.pictureBoxVRLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxVRLogo.Location = new System.Drawing.Point(12, 66);
            this.pictureBoxVRLogo.Name = "pictureBoxVRLogo";
            this.pictureBoxVRLogo.Size = new System.Drawing.Size(326, 436);
            this.pictureBoxVRLogo.TabIndex = 5;
            this.pictureBoxVRLogo.TabStop = false;
            // 
            // toolStripMainMenu
            // 
            this.toolStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGuestRegistrationCard,
            this.toolStripButtonRoomEditor,
            this.toolStripButtonGuestDatabase,
            this.toolStripButtonBilling});
            this.toolStripMainMenu.Location = new System.Drawing.Point(0, 24);
            this.toolStripMainMenu.Name = "toolStripMainMenu";
            this.toolStripMainMenu.Size = new System.Drawing.Size(1008, 39);
            this.toolStripMainMenu.TabIndex = 6;
            this.toolStripMainMenu.Text = "toolStrip1";
            // 
            // toolStripButtonGuestRegistrationCard
            // 
            this.toolStripButtonGuestRegistrationCard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGuestRegistrationCard.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuestRegistrationCard.Image")));
            this.toolStripButtonGuestRegistrationCard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonGuestRegistrationCard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuestRegistrationCard.Name = "toolStripButtonGuestRegistrationCard";
            this.toolStripButtonGuestRegistrationCard.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonGuestRegistrationCard.Text = "Vendég bejelentkező lap kitöltése";
            this.toolStripButtonGuestRegistrationCard.Click += new System.EventHandler(this.toolStripButtonGuestRegistrationCard_Click);
            this.toolStripButtonGuestRegistrationCard.MouseLeave += new System.EventHandler(this.toolStripButtonGuestRegistrationCard_MouseLeave);
            this.toolStripButtonGuestRegistrationCard.MouseHover += new System.EventHandler(this.toolStripButtonGuestRegistrationCard_MouseHover);
            // 
            // toolStripButtonRoomEditor
            // 
            this.toolStripButtonRoomEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRoomEditor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRoomEditor.Image")));
            this.toolStripButtonRoomEditor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRoomEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRoomEditor.Name = "toolStripButtonRoomEditor";
            this.toolStripButtonRoomEditor.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonRoomEditor.Text = "Szobakezelő";
            this.toolStripButtonRoomEditor.Click += new System.EventHandler(this.toolStripButtonRoomEditor_Click);
            this.toolStripButtonRoomEditor.MouseLeave += new System.EventHandler(this.toolStripButtonRoomEditor_MouseLeave);
            this.toolStripButtonRoomEditor.MouseHover += new System.EventHandler(this.toolStripButtonRoomEditor_MouseHover);
            // 
            // toolStripButtonGuestDatabase
            // 
            this.toolStripButtonGuestDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGuestDatabase.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuestDatabase.Image")));
            this.toolStripButtonGuestDatabase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonGuestDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuestDatabase.Name = "toolStripButtonGuestDatabase";
            this.toolStripButtonGuestDatabase.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonGuestDatabase.Text = "Vendégadatbázis";
            this.toolStripButtonGuestDatabase.Click += new System.EventHandler(this.toolStripButtonGuestDatabase_Click);
            this.toolStripButtonGuestDatabase.MouseLeave += new System.EventHandler(this.toolStripButtonGuestDatabase_MouseLeave);
            this.toolStripButtonGuestDatabase.MouseHover += new System.EventHandler(this.toolStripButtonGuestDatabase_MouseHover);
            // 
            // toolStripButtonBilling
            // 
            this.toolStripButtonBilling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBilling.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBilling.Image")));
            this.toolStripButtonBilling.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonBilling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBilling.Name = "toolStripButtonBilling";
            this.toolStripButtonBilling.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButtonBilling.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonBilling.Text = "Számlázás";
            this.toolStripButtonBilling.Click += new System.EventHandler(this.toolStripButtonBilling_Click);
            this.toolStripButtonBilling.MouseLeave += new System.EventHandler(this.toolStripButtonBilling_MouseLeave);
            this.toolStripButtonBilling.MouseHover += new System.EventHandler(this.toolStripButtonBilling_MouseHover);
            // 
            // pictureBoxBSLogo
            // 
            this.pictureBoxBSLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxBSLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBSLogo.Image")));
            this.pictureBoxBSLogo.Location = new System.Drawing.Point(12, 508);
            this.pictureBoxBSLogo.Name = "pictureBoxBSLogo";
            this.pictureBoxBSLogo.Size = new System.Drawing.Size(326, 182);
            this.pictureBoxBSLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBSLogo.TabIndex = 7;
            this.pictureBoxBSLogo.TabStop = false;
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Controls.Add(this.labelDescription);
            this.panelMainMenu.Controls.Add(this.labelWelcome);
            this.panelMainMenu.Location = new System.Drawing.Point(344, 66);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(652, 623);
            this.panelMainMenu.TabIndex = 8;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(3, 62);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(593, 143);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = resources.GetString("labelDescription.Text");
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcome.Location = new System.Drawing.Point(3, 19);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(371, 16);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Üdvözöljük a Virtual Receptionist asztali platformján!";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.pictureBoxBSLogo);
            this.Controls.Add(this.toolStripMainMenu);
            this.Controls.Add(this.pictureBoxVRLogo);
            this.Controls.Add(this.statusStripMainMenu);
            this.Controls.Add(this.menuStripMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMainMenu;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Receptionist | ";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            this.statusStripMainMenu.ResumeLayout(false);
            this.statusStripMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVRLogo)).EndInit();
            this.toolStripMainMenu.ResumeLayout(false);
            this.toolStripMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBSLogo)).EndInit();
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.StatusStrip statusStripMainMenu;
        private System.Windows.Forms.PictureBox pictureBoxVRLogo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelClient;
        private System.Windows.Forms.ToolStrip toolStripMainMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonRoomEditor;
        private System.Windows.Forms.ToolStripButton toolStripButtonBilling;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuestDatabase;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMenuName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelpCHM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAccomodationInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItemHelpSeparator;
        private System.Windows.Forms.PictureBox pictureBoxBSLogo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWebsite;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTools;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRoomEditor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuestDatabase;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBilling;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelServer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuestRegistrationCard;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuestRegistrationCard;
    }
}