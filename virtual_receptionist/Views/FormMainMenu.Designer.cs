namespace virtual_receptionist.Views
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
            this.toolStripMenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuestDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBilling = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAccomodationInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelpSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemHelpCHM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMainMenu = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelClient = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMenuName = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBoxVRLogo = new System.Windows.Forms.PictureBox();
            this.toolStripMainMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBooking = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuestDatabase = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBilling = new System.Windows.Forms.ToolStripButton();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.labelIntroduction = new System.Windows.Forms.Label();
            this.labelWelcomeTitle = new System.Windows.Forms.Label();
            this.menuStripMainMenu.SuspendLayout();
            this.statusStripMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVRLogo)).BeginInit();
            this.toolStripMainMenu.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
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
            // toolStripMenuItemTools
            // 
            this.toolStripMenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBooking,
            this.toolStripMenuItemGuestDatabase,
            this.toolStripMenuItemBilling});
            this.toolStripMenuItemTools.Name = "toolStripMenuItemTools";
            this.toolStripMenuItemTools.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItemTools.Text = "Eszközök";
            this.toolStripMenuItemTools.MouseLeave += new System.EventHandler(this.toolStripMenuItemTools_MouseLeave);
            this.toolStripMenuItemTools.MouseHover += new System.EventHandler(this.toolStripMenuItemTools_MouseHover);
            // 
            // toolStripMenuItemBooking
            // 
            this.toolStripMenuItemBooking.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemBooking.Image")));
            this.toolStripMenuItemBooking.Name = "toolStripMenuItemBooking";
            this.toolStripMenuItemBooking.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItemBooking.Text = "Foglalási napló";
            this.toolStripMenuItemBooking.Click += new System.EventHandler(this.toolStripMenuItemRoomEditor_Click);
            this.toolStripMenuItemBooking.MouseLeave += new System.EventHandler(this.toolStripMenuItemRoomEditor_MouseLeave);
            this.toolStripMenuItemBooking.MouseHover += new System.EventHandler(this.toolStripMenuItemRoomEditor_MouseHover);
            // 
            // toolStripMenuItemGuestDatabase
            // 
            this.toolStripMenuItemGuestDatabase.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemGuestDatabase.Image")));
            this.toolStripMenuItemGuestDatabase.Name = "toolStripMenuItemGuestDatabase";
            this.toolStripMenuItemGuestDatabase.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItemGuestDatabase.Text = "Vendégadatbázis";
            this.toolStripMenuItemGuestDatabase.Click += new System.EventHandler(this.toolStripMenuItemGuestDatabase_Click);
            this.toolStripMenuItemGuestDatabase.MouseLeave += new System.EventHandler(this.toolStripMenuItemGuestDatabase_MouseLeave);
            this.toolStripMenuItemGuestDatabase.MouseHover += new System.EventHandler(this.toolStripMenuItemGuestDatabase_MouseHover);
            // 
            // toolStripMenuItemBilling
            // 
            this.toolStripMenuItemBilling.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemBilling.Image")));
            this.toolStripMenuItemBilling.Name = "toolStripMenuItemBilling";
            this.toolStripMenuItemBilling.Size = new System.Drawing.Size(162, 22);
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
            this.toolStripMenuItemWebsite});
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
            // statusStripMainMenu
            // 
            this.statusStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelClient,
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
            // toolStripStatusLabelMenuName
            // 
            this.toolStripStatusLabelMenuName.Name = "toolStripStatusLabelMenuName";
            this.toolStripStatusLabelMenuName.Size = new System.Drawing.Size(0, 32);
            // 
            // pictureBoxVRLogo
            // 
            this.pictureBoxVRLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxVRLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxVRLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVRLogo.Image")));
            this.pictureBoxVRLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxVRLogo.Name = "pictureBoxVRLogo";
            this.pictureBoxVRLogo.Size = new System.Drawing.Size(267, 629);
            this.pictureBoxVRLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVRLogo.TabIndex = 5;
            this.pictureBoxVRLogo.TabStop = false;
            // 
            // toolStripMainMenu
            // 
            this.toolStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBooking,
            this.toolStripButtonGuestDatabase,
            this.toolStripButtonBilling});
            this.toolStripMainMenu.Location = new System.Drawing.Point(0, 24);
            this.toolStripMainMenu.Name = "toolStripMainMenu";
            this.toolStripMainMenu.Size = new System.Drawing.Size(1008, 39);
            this.toolStripMainMenu.TabIndex = 6;
            // 
            // toolStripButtonBooking
            // 
            this.toolStripButtonBooking.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBooking.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBooking.Image")));
            this.toolStripButtonBooking.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonBooking.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBooking.Name = "toolStripButtonBooking";
            this.toolStripButtonBooking.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonBooking.Text = "Foglalási napló";
            this.toolStripButtonBooking.ToolTipText = "Foglalási napló";
            this.toolStripButtonBooking.Click += new System.EventHandler(this.toolStripButtonRoomEditor_Click);
            this.toolStripButtonBooking.MouseLeave += new System.EventHandler(this.toolStripButtonRoomEditor_MouseLeave);
            this.toolStripButtonBooking.MouseHover += new System.EventHandler(this.toolStripButtonRoomEditor_MouseHover);
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
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.Location = new System.Drawing.Point(580, 562);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(159, 64);
            this.buttonLogout.TabIndex = 29;
            this.buttonLogout.Text = "Kijelentkezés";
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            this.buttonLogout.MouseLeave += new System.EventHandler(this.buttonLogout_MouseLeave);
            this.buttonLogout.MouseHover += new System.EventHandler(this.buttonLogout_MouseHover);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Controls.Add(this.pictureBoxVRLogo);
            this.panelMainMenu.Controls.Add(this.panelWelcome);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 63);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(1008, 629);
            this.panelMainMenu.TabIndex = 30;
            // 
            // panelWelcome
            // 
            this.panelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWelcome.Controls.Add(this.labelIntroduction);
            this.panelWelcome.Controls.Add(this.labelWelcomeTitle);
            this.panelWelcome.Controls.Add(this.buttonLogout);
            this.panelWelcome.Location = new System.Drawing.Point(266, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(742, 629);
            this.panelWelcome.TabIndex = 30;
            // 
            // labelIntroduction
            // 
            this.labelIntroduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelIntroduction.AutoSize = true;
            this.labelIntroduction.Location = new System.Drawing.Point(50, 122);
            this.labelIntroduction.Name = "labelIntroduction";
            this.labelIntroduction.Size = new System.Drawing.Size(604, 39);
            this.labelIntroduction.TabIndex = 30;
            this.labelIntroduction.Text = resources.GetString("labelIntroduction.Text");
            // 
            // labelWelcomeTitle
            // 
            this.labelWelcomeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelWelcomeTitle.AutoSize = true;
            this.labelWelcomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcomeTitle.Location = new System.Drawing.Point(48, 61);
            this.labelWelcomeTitle.Name = "labelWelcomeTitle";
            this.labelWelcomeTitle.Size = new System.Drawing.Size(637, 25);
            this.labelWelcomeTitle.TabIndex = 0;
            this.labelWelcomeTitle.Text = "Üdvözöljük a Virtual Receptionist adminisztrációs felületén!";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.toolStripMainMenu);
            this.Controls.Add(this.statusStripMainMenu);
            this.Controls.Add(this.menuStripMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMainMenu;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Receptionist | ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            this.statusStripMainMenu.ResumeLayout(false);
            this.statusStripMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVRLogo)).EndInit();
            this.toolStripMainMenu.ResumeLayout(false);
            this.toolStripMainMenu.PerformLayout();
            this.panelMainMenu.ResumeLayout(false);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripButtonBooking;
        private System.Windows.Forms.ToolStripButton toolStripButtonBilling;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuestDatabase;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelpCHM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAccomodationInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItemHelpSeparator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWebsite;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTools;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBooking;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuestDatabase;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBilling;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMenuName;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label labelWelcomeTitle;
        private System.Windows.Forms.Label labelIntroduction;
    }
}