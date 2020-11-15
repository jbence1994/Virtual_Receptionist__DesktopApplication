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
            this.pictureBoxVRLogo = new System.Windows.Forms.PictureBox();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.menuStripMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVRLogo)).BeginInit();
            this.panelMainMenu.SuspendLayout();
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
            // 
            // toolStripMenuItemLogout
            // 
            this.toolStripMenuItemLogout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemLogout.Image")));
            this.toolStripMenuItemLogout.Name = "toolStripMenuItemLogout";
            this.toolStripMenuItemLogout.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItemLogout.Text = "Kijelentkezés";
            this.toolStripMenuItemLogout.Click += new System.EventHandler(this.toolStripMenuItemLogout_Click);
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
            // 
            // toolStripMenuItemBooking
            // 
            this.toolStripMenuItemBooking.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemBooking.Image")));
            this.toolStripMenuItemBooking.Name = "toolStripMenuItemBooking";
            this.toolStripMenuItemBooking.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItemBooking.Text = "Foglalási napló";
            this.toolStripMenuItemBooking.Click += new System.EventHandler(this.toolStripMenuItemRoomEditor_Click);
            // 
            // toolStripMenuItemGuestDatabase
            // 
            this.toolStripMenuItemGuestDatabase.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemGuestDatabase.Image")));
            this.toolStripMenuItemGuestDatabase.Name = "toolStripMenuItemGuestDatabase";
            this.toolStripMenuItemGuestDatabase.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItemGuestDatabase.Text = "Vendégadatbázis";
            this.toolStripMenuItemGuestDatabase.Click += new System.EventHandler(this.toolStripMenuItemGuestDatabase_Click);
            // 
            // toolStripMenuItemBilling
            // 
            this.toolStripMenuItemBilling.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemBilling.Image")));
            this.toolStripMenuItemBilling.Name = "toolStripMenuItemBilling";
            this.toolStripMenuItemBilling.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItemBilling.Text = "Számlázás";
            this.toolStripMenuItemBilling.Click += new System.EventHandler(this.toolStripMenuItemBilling_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAccomodationInfo,
            this.toolStripMenuItemHelpSeparator,
            this.toolStripMenuItemHelpCHM});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItemHelp.Text = "Súgó";
            // 
            // toolStripMenuItemAccomodationInfo
            // 
            this.toolStripMenuItemAccomodationInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAccomodationInfo.Image")));
            this.toolStripMenuItemAccomodationInfo.Name = "toolStripMenuItemAccomodationInfo";
            this.toolStripMenuItemAccomodationInfo.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItemAccomodationInfo.Text = "Szálláshely adatai";
            this.toolStripMenuItemAccomodationInfo.Click += new System.EventHandler(this.toolStripMenuItemAccomodationInfo_Click);
            // 
            // toolStripMenuItemHelpSeparator
            // 
            this.toolStripMenuItemHelpSeparator.Name = "toolStripMenuItemHelpSeparator";
            this.toolStripMenuItemHelpSeparator.Size = new System.Drawing.Size(162, 6);
            // 
            // toolStripMenuItemHelpCHM
            // 
            this.toolStripMenuItemHelpCHM.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemHelpCHM.Image")));
            this.toolStripMenuItemHelpCHM.Name = "toolStripMenuItemHelpCHM";
            this.toolStripMenuItemHelpCHM.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItemHelpCHM.Text = "Segítség";
            this.toolStripMenuItemHelpCHM.Click += new System.EventHandler(this.toolStripMenuItemHelpCHM_Click);
            // 
            // pictureBoxVRLogo
            // 
            this.pictureBoxVRLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxVRLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxVRLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVRLogo.Image")));
            this.pictureBoxVRLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxVRLogo.Name = "pictureBoxVRLogo";
            this.pictureBoxVRLogo.Size = new System.Drawing.Size(267, 705);
            this.pictureBoxVRLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVRLogo.TabIndex = 5;
            this.pictureBoxVRLogo.TabStop = false;
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Controls.Add(this.pictureBoxVRLogo);
            this.panelMainMenu.Controls.Add(this.panelWelcome);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 24);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(1008, 705);
            this.panelMainMenu.TabIndex = 30;
            // 
            // panelWelcome
            // 
            this.panelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWelcome.Location = new System.Drawing.Point(266, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(742, 705);
            this.panelWelcome.TabIndex = 30;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.panelMainMenu);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVRLogo)).EndInit();
            this.panelMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.PictureBox pictureBoxVRLogo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelpCHM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAccomodationInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItemHelpSeparator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTools;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBooking;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuestDatabase;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBilling;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel panelWelcome;
    }
}