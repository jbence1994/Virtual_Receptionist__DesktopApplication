namespace virtual_receptionist
{
    partial class FormGuestDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuestDatabase));
            this.listViewGuests = new System.Windows.Forms.ListView();
            this.buttonAddGuest = new System.Windows.Forms.Button();
            this.buttonDeleteGuest = new System.Windows.Forms.Button();
            this.buttonUpdateGuest = new System.Windows.Forms.Button();
            this.menuStripGuestDatabase = new System.Windows.Forms.MenuStrip();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewGuests
            // 
            this.listViewGuests.FullRowSelect = true;
            this.listViewGuests.GridLines = true;
            this.listViewGuests.Location = new System.Drawing.Point(13, 27);
            this.listViewGuests.Name = "listViewGuests";
            this.listViewGuests.Size = new System.Drawing.Size(516, 490);
            this.listViewGuests.TabIndex = 0;
            this.listViewGuests.UseCompatibleStateImageBehavior = false;
            this.listViewGuests.View = System.Windows.Forms.View.Details;
            // 
            // buttonAddGuest
            // 
            this.buttonAddGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddGuest.Image")));
            this.buttonAddGuest.Location = new System.Drawing.Point(535, 27);
            this.buttonAddGuest.Name = "buttonAddGuest";
            this.buttonAddGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonAddGuest.TabIndex = 1;
            this.buttonAddGuest.Text = "Új vendég hozzáadása";
            this.buttonAddGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddGuest.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteGuest
            // 
            this.buttonDeleteGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteGuest.Image")));
            this.buttonDeleteGuest.Location = new System.Drawing.Point(535, 167);
            this.buttonDeleteGuest.Name = "buttonDeleteGuest";
            this.buttonDeleteGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonDeleteGuest.TabIndex = 2;
            this.buttonDeleteGuest.Text = "Vendég törlése";
            this.buttonDeleteGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDeleteGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteGuest.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateGuest
            // 
            this.buttonUpdateGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateGuest.Image")));
            this.buttonUpdateGuest.Location = new System.Drawing.Point(535, 97);
            this.buttonUpdateGuest.Name = "buttonUpdateGuest";
            this.buttonUpdateGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonUpdateGuest.TabIndex = 3;
            this.buttonUpdateGuest.Text = "Vendég módosítása";
            this.buttonUpdateGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdateGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUpdateGuest.UseVisualStyleBackColor = true;
            // 
            // menuStripGuestDatabase
            // 
            this.menuStripGuestDatabase.Location = new System.Drawing.Point(0, 0);
            this.menuStripGuestDatabase.Name = "menuStripGuestDatabase";
            this.menuStripGuestDatabase.Size = new System.Drawing.Size(704, 24);
            this.menuStripGuestDatabase.TabIndex = 4;
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(535, 453);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(157, 64);
            this.buttonBackToMainMenu.TabIndex = 5;
            this.buttonBackToMainMenu.Text = "Vissza a főmenübe";
            this.buttonBackToMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBackToMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            // 
            // FormGuestDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 529);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonUpdateGuest);
            this.Controls.Add(this.buttonDeleteGuest);
            this.Controls.Add(this.buttonAddGuest);
            this.Controls.Add(this.listViewGuests);
            this.Controls.Add(this.menuStripGuestDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripGuestDatabase;
            this.Name = "FormGuestDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendég adatbázis | Virtual Receptionist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewGuests;
        private System.Windows.Forms.Button buttonAddGuest;
        private System.Windows.Forms.Button buttonDeleteGuest;
        private System.Windows.Forms.Button buttonUpdateGuest;
        private System.Windows.Forms.MenuStrip menuStripGuestDatabase;
        private System.Windows.Forms.Button buttonBackToMainMenu;
    }
}