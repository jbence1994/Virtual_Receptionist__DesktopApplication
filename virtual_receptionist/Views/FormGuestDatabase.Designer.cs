namespace virtual_receptionist.View
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
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.tabControlGuestDatabase = new System.Windows.Forms.TabControl();
            this.tabPagePrivateGuest = new System.Windows.Forms.TabPage();
            this.tabPageCorporateGuest = new System.Windows.Forms.TabPage();
            this.listViewPrivateGuests = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDocumentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCitizenship = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZipCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewCorporateGuests = new System.Windows.Forms.ListView();
            this.columnHeaderCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVATNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHeadqurterCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHeadqurterZipCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonUpdatePrivateGuest = new System.Windows.Forms.Button();
            this.buttonDeletePrivateGuest = new System.Windows.Forms.Button();
            this.buttonAddPrivateGuest = new System.Windows.Forms.Button();
            this.buttonUpdateCorporateGuest = new System.Windows.Forms.Button();
            this.buttonDeleteCorporateGuest = new System.Windows.Forms.Button();
            this.buttonAddCorporateGuest = new System.Windows.Forms.Button();
            this.columnHeaderHeadqurterCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHeadqurterAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCompanyPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCompanyEmailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlGuestDatabase.SuspendLayout();
            this.tabPagePrivateGuest.SuspendLayout();
            this.tabPageCorporateGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonBackToMainMenu.Image")));
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(1006, 589);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(157, 64);
            this.buttonBackToMainMenu.TabIndex = 5;
            this.buttonBackToMainMenu.Text = "Vissza a főmenübe";
            this.buttonBackToMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBackToMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // tabControlGuestDatabase
            // 
            this.tabControlGuestDatabase.Controls.Add(this.tabPagePrivateGuest);
            this.tabControlGuestDatabase.Controls.Add(this.tabPageCorporateGuest);
            this.tabControlGuestDatabase.Location = new System.Drawing.Point(12, 12);
            this.tabControlGuestDatabase.Name = "tabControlGuestDatabase";
            this.tabControlGuestDatabase.SelectedIndex = 0;
            this.tabControlGuestDatabase.Size = new System.Drawing.Size(1161, 560);
            this.tabControlGuestDatabase.TabIndex = 6;
            // 
            // tabPagePrivateGuest
            // 
            this.tabPagePrivateGuest.Controls.Add(this.buttonUpdatePrivateGuest);
            this.tabPagePrivateGuest.Controls.Add(this.buttonDeletePrivateGuest);
            this.tabPagePrivateGuest.Controls.Add(this.buttonAddPrivateGuest);
            this.tabPagePrivateGuest.Controls.Add(this.listViewPrivateGuests);
            this.tabPagePrivateGuest.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrivateGuest.Name = "tabPagePrivateGuest";
            this.tabPagePrivateGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrivateGuest.Size = new System.Drawing.Size(1153, 534);
            this.tabPagePrivateGuest.TabIndex = 0;
            this.tabPagePrivateGuest.Text = "Vendégek";
            this.tabPagePrivateGuest.UseVisualStyleBackColor = true;
            // 
            // tabPageCorporateGuest
            // 
            this.tabPageCorporateGuest.Controls.Add(this.buttonUpdateCorporateGuest);
            this.tabPageCorporateGuest.Controls.Add(this.buttonDeleteCorporateGuest);
            this.tabPageCorporateGuest.Controls.Add(this.buttonAddCorporateGuest);
            this.tabPageCorporateGuest.Controls.Add(this.listViewCorporateGuests);
            this.tabPageCorporateGuest.Location = new System.Drawing.Point(4, 22);
            this.tabPageCorporateGuest.Name = "tabPageCorporateGuest";
            this.tabPageCorporateGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCorporateGuest.Size = new System.Drawing.Size(1153, 534);
            this.tabPageCorporateGuest.TabIndex = 1;
            this.tabPageCorporateGuest.Text = "Céges vendégek";
            this.tabPageCorporateGuest.UseVisualStyleBackColor = true;
            // 
            // listViewPrivateGuests
            // 
            this.listViewPrivateGuests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderDocumentID,
            this.columnHeaderCitizenship,
            this.columnHeaderBirthDate,
            this.columnHeaderCountry,
            this.columnHeaderZipCode,
            this.columnHeaderCity,
            this.columnHeaderAddress,
            this.columnHeaderPhoneNumber,
            this.columnHeaderEmailAddress});
            this.listViewPrivateGuests.FullRowSelect = true;
            this.listViewPrivateGuests.GridLines = true;
            this.listViewPrivateGuests.Location = new System.Drawing.Point(3, 3);
            this.listViewPrivateGuests.Name = "listViewPrivateGuests";
            this.listViewPrivateGuests.Size = new System.Drawing.Size(981, 528);
            this.listViewPrivateGuests.TabIndex = 1;
            this.listViewPrivateGuests.UseCompatibleStateImageBehavior = false;
            this.listViewPrivateGuests.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Név";
            this.columnHeaderName.Width = 120;
            // 
            // columnHeaderDocumentID
            // 
            this.columnHeaderDocumentID.Text = "Okmányazonosító";
            this.columnHeaderDocumentID.Width = 120;
            // 
            // columnHeaderCitizenship
            // 
            this.columnHeaderCitizenship.Text = "Állampolgárság";
            this.columnHeaderCitizenship.Width = 120;
            // 
            // columnHeaderBirthDate
            // 
            this.columnHeaderBirthDate.Text = "Születési idő";
            this.columnHeaderBirthDate.Width = 120;
            // 
            // columnHeaderCountry
            // 
            this.columnHeaderCountry.Text = "Ország";
            this.columnHeaderCountry.Width = 120;
            // 
            // columnHeaderZipCode
            // 
            this.columnHeaderZipCode.Text = "Irányítószám";
            this.columnHeaderZipCode.Width = 120;
            // 
            // columnHeaderCity
            // 
            this.columnHeaderCity.Text = "Település";
            this.columnHeaderCity.Width = 120;
            // 
            // columnHeaderAddress
            // 
            this.columnHeaderAddress.Text = "Cím";
            this.columnHeaderAddress.Width = 120;
            // 
            // columnHeaderPhoneNumber
            // 
            this.columnHeaderPhoneNumber.Text = "Telefonszám";
            this.columnHeaderPhoneNumber.Width = 120;
            // 
            // columnHeaderEmailAddress
            // 
            this.columnHeaderEmailAddress.Text = "E-mail cím";
            this.columnHeaderEmailAddress.Width = 120;
            // 
            // listViewCorporateGuests
            // 
            this.listViewCorporateGuests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCompanyName,
            this.columnHeaderVATNumber,
            this.columnHeaderHeadqurterCountry,
            this.columnHeaderHeadqurterZipCode,
            this.columnHeaderHeadqurterCity,
            this.columnHeaderHeadqurterAddress,
            this.columnHeaderCompanyPhoneNumber,
            this.columnHeaderCompanyEmailAddress});
            this.listViewCorporateGuests.FullRowSelect = true;
            this.listViewCorporateGuests.GridLines = true;
            this.listViewCorporateGuests.Location = new System.Drawing.Point(3, 3);
            this.listViewCorporateGuests.Name = "listViewCorporateGuests";
            this.listViewCorporateGuests.Size = new System.Drawing.Size(981, 528);
            this.listViewCorporateGuests.TabIndex = 2;
            this.listViewCorporateGuests.UseCompatibleStateImageBehavior = false;
            this.listViewCorporateGuests.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCompanyName
            // 
            this.columnHeaderCompanyName.Text = "Cégnév";
            this.columnHeaderCompanyName.Width = 150;
            // 
            // columnHeaderVATNumber
            // 
            this.columnHeaderVATNumber.Text = "Adószám";
            this.columnHeaderVATNumber.Width = 150;
            // 
            // columnHeaderHeadqurterCountry
            // 
            this.columnHeaderHeadqurterCountry.Text = "Ország";
            this.columnHeaderHeadqurterCountry.Width = 150;
            // 
            // columnHeaderHeadqurterZipCode
            // 
            this.columnHeaderHeadqurterZipCode.Text = "Irányítószám";
            this.columnHeaderHeadqurterZipCode.Width = 150;
            // 
            // buttonUpdatePrivateGuest
            // 
            this.buttonUpdatePrivateGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdatePrivateGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdatePrivateGuest.Image")));
            this.buttonUpdatePrivateGuest.Location = new System.Drawing.Point(990, 76);
            this.buttonUpdatePrivateGuest.Name = "buttonUpdatePrivateGuest";
            this.buttonUpdatePrivateGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonUpdatePrivateGuest.TabIndex = 6;
            this.buttonUpdatePrivateGuest.Text = "Vendég módosítása";
            this.buttonUpdatePrivateGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdatePrivateGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUpdatePrivateGuest.UseVisualStyleBackColor = true;
            this.buttonUpdatePrivateGuest.Click += new System.EventHandler(this.buttonUpdatePrivateGuest_Click);
            // 
            // buttonDeletePrivateGuest
            // 
            this.buttonDeletePrivateGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeletePrivateGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeletePrivateGuest.Image")));
            this.buttonDeletePrivateGuest.Location = new System.Drawing.Point(990, 146);
            this.buttonDeletePrivateGuest.Name = "buttonDeletePrivateGuest";
            this.buttonDeletePrivateGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonDeletePrivateGuest.TabIndex = 5;
            this.buttonDeletePrivateGuest.Text = "Vendég törlése";
            this.buttonDeletePrivateGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDeletePrivateGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeletePrivateGuest.UseVisualStyleBackColor = true;
            this.buttonDeletePrivateGuest.Click += new System.EventHandler(this.buttonDeletePrivateGuest_Click);
            // 
            // buttonAddPrivateGuest
            // 
            this.buttonAddPrivateGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddPrivateGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddPrivateGuest.Image")));
            this.buttonAddPrivateGuest.Location = new System.Drawing.Point(990, 6);
            this.buttonAddPrivateGuest.Name = "buttonAddPrivateGuest";
            this.buttonAddPrivateGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonAddPrivateGuest.TabIndex = 4;
            this.buttonAddPrivateGuest.Text = "Új vendég hozzáadása";
            this.buttonAddPrivateGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddPrivateGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddPrivateGuest.UseVisualStyleBackColor = true;
            this.buttonAddPrivateGuest.Click += new System.EventHandler(this.buttonAddPrivateGuest_Click);
            // 
            // buttonUpdateCorporateGuest
            // 
            this.buttonUpdateCorporateGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateCorporateGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateCorporateGuest.Image")));
            this.buttonUpdateCorporateGuest.Location = new System.Drawing.Point(990, 76);
            this.buttonUpdateCorporateGuest.Name = "buttonUpdateCorporateGuest";
            this.buttonUpdateCorporateGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonUpdateCorporateGuest.TabIndex = 9;
            this.buttonUpdateCorporateGuest.Text = "Vendég módosítása";
            this.buttonUpdateCorporateGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdateCorporateGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUpdateCorporateGuest.UseVisualStyleBackColor = true;
            this.buttonUpdateCorporateGuest.Click += new System.EventHandler(this.buttonUpdateCorporateGuest_Click);
            // 
            // buttonDeleteCorporateGuest
            // 
            this.buttonDeleteCorporateGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteCorporateGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteCorporateGuest.Image")));
            this.buttonDeleteCorporateGuest.Location = new System.Drawing.Point(990, 146);
            this.buttonDeleteCorporateGuest.Name = "buttonDeleteCorporateGuest";
            this.buttonDeleteCorporateGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonDeleteCorporateGuest.TabIndex = 8;
            this.buttonDeleteCorporateGuest.Text = "Vendég törlése";
            this.buttonDeleteCorporateGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDeleteCorporateGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteCorporateGuest.UseVisualStyleBackColor = true;
            this.buttonDeleteCorporateGuest.Click += new System.EventHandler(this.buttonDeleteCorporateGuest_Click);
            // 
            // buttonAddCorporateGuest
            // 
            this.buttonAddCorporateGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddCorporateGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddCorporateGuest.Image")));
            this.buttonAddCorporateGuest.Location = new System.Drawing.Point(990, 6);
            this.buttonAddCorporateGuest.Name = "buttonAddCorporateGuest";
            this.buttonAddCorporateGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonAddCorporateGuest.TabIndex = 7;
            this.buttonAddCorporateGuest.Text = "Új vendég hozzáadása";
            this.buttonAddCorporateGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddCorporateGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddCorporateGuest.UseVisualStyleBackColor = true;
            this.buttonAddCorporateGuest.Click += new System.EventHandler(this.buttonAddCorporateGuest_Click);
            // 
            // columnHeaderHeadqurterCity
            // 
            this.columnHeaderHeadqurterCity.Text = "Település";
            this.columnHeaderHeadqurterCity.Width = 150;
            // 
            // columnHeaderHeadqurterAddress
            // 
            this.columnHeaderHeadqurterAddress.Text = "Cím";
            this.columnHeaderHeadqurterAddress.Width = 150;
            // 
            // columnHeaderCompanyPhoneNumber
            // 
            this.columnHeaderCompanyPhoneNumber.Text = "Telefonszám";
            this.columnHeaderCompanyPhoneNumber.Width = 150;
            // 
            // columnHeaderCompanyEmailAddress
            // 
            this.columnHeaderCompanyEmailAddress.Text = "E-mail cím";
            this.columnHeaderCompanyEmailAddress.Width = 150;
            // 
            // FormGuestDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 665);
            this.Controls.Add(this.tabControlGuestDatabase);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGuestDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendégadatbázis | Virtual Receptionist";
            this.Load += new System.EventHandler(this.FormGuestDatabase_Load);
            this.tabControlGuestDatabase.ResumeLayout(false);
            this.tabPagePrivateGuest.ResumeLayout(false);
            this.tabPageCorporateGuest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.TabControl tabControlGuestDatabase;
        private System.Windows.Forms.TabPage tabPagePrivateGuest;
        private System.Windows.Forms.ListView listViewPrivateGuests;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDocumentID;
        private System.Windows.Forms.ColumnHeader columnHeaderCitizenship;
        private System.Windows.Forms.ColumnHeader columnHeaderBirthDate;
        private System.Windows.Forms.ColumnHeader columnHeaderCountry;
        private System.Windows.Forms.ColumnHeader columnHeaderZipCode;
        private System.Windows.Forms.ColumnHeader columnHeaderCity;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderPhoneNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderEmailAddress;
        private System.Windows.Forms.TabPage tabPageCorporateGuest;
        private System.Windows.Forms.ListView listViewCorporateGuests;
        private System.Windows.Forms.ColumnHeader columnHeaderCompanyName;
        private System.Windows.Forms.ColumnHeader columnHeaderVATNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderHeadqurterCountry;
        private System.Windows.Forms.ColumnHeader columnHeaderHeadqurterZipCode;
        private System.Windows.Forms.Button buttonUpdatePrivateGuest;
        private System.Windows.Forms.Button buttonDeletePrivateGuest;
        private System.Windows.Forms.Button buttonAddPrivateGuest;
        private System.Windows.Forms.Button buttonUpdateCorporateGuest;
        private System.Windows.Forms.Button buttonDeleteCorporateGuest;
        private System.Windows.Forms.Button buttonAddCorporateGuest;
        private System.Windows.Forms.ColumnHeader columnHeaderHeadqurterCity;
        private System.Windows.Forms.ColumnHeader columnHeaderHeadqurterAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderCompanyPhoneNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderCompanyEmailAddress;
    }
}