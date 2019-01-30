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
            this.listViewGuests = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDocumentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZipCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVATNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddGuest = new System.Windows.Forms.Button();
            this.buttonDeleteGuest = new System.Windows.Forms.Button();
            this.buttonUpdateGuest = new System.Windows.Forms.Button();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.columnHeaderCitizenship = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewGuests
            // 
            this.listViewGuests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderDocumentID,
            this.columnHeaderCitizenship,
            this.columnHeaderBirthDate,
            this.columnHeaderVATNumber,
            this.columnHeaderCountry,
            this.columnHeaderZipCode,
            this.columnHeaderCity,
            this.columnHeaderAddress,
            this.columnHeaderPhoneNumber,
            this.columnHeaderEmailAddress});
            this.listViewGuests.FullRowSelect = true;
            this.listViewGuests.GridLines = true;
            this.listViewGuests.Location = new System.Drawing.Point(12, 12);
            this.listViewGuests.Name = "listViewGuests";
            this.listViewGuests.Size = new System.Drawing.Size(995, 560);
            this.listViewGuests.TabIndex = 0;
            this.listViewGuests.UseCompatibleStateImageBehavior = false;
            this.listViewGuests.View = System.Windows.Forms.View.Details;
            this.listViewGuests.SelectedIndexChanged += new System.EventHandler(this.listViewGuests_SelectedIndexChanged);
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
            // columnHeaderVATNumber
            // 
            this.columnHeaderVATNumber.Text = "Adószám";
            this.columnHeaderVATNumber.Width = 120;
            // 
            // columnHeaderPhoneNumber
            // 
            this.columnHeaderPhoneNumber.Text = "Telefonszám";
            this.columnHeaderPhoneNumber.Width = 120;
            // 
            // columnHeaderEmailAddress
            // 
            this.columnHeaderEmailAddress.Text = "E-mail";
            this.columnHeaderEmailAddress.Width = 120;
            // 
            // buttonAddGuest
            // 
            this.buttonAddGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddGuest.Image")));
            this.buttonAddGuest.Location = new System.Drawing.Point(1013, 12);
            this.buttonAddGuest.Name = "buttonAddGuest";
            this.buttonAddGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonAddGuest.TabIndex = 1;
            this.buttonAddGuest.Text = "Új vendég hozzáadása";
            this.buttonAddGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddGuest.UseVisualStyleBackColor = true;
            this.buttonAddGuest.Click += new System.EventHandler(this.buttonAddGuest_Click);
            // 
            // buttonDeleteGuest
            // 
            this.buttonDeleteGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteGuest.Image")));
            this.buttonDeleteGuest.Location = new System.Drawing.Point(1013, 152);
            this.buttonDeleteGuest.Name = "buttonDeleteGuest";
            this.buttonDeleteGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonDeleteGuest.TabIndex = 2;
            this.buttonDeleteGuest.Text = "Vendég törlése";
            this.buttonDeleteGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDeleteGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteGuest.UseVisualStyleBackColor = true;
            this.buttonDeleteGuest.Click += new System.EventHandler(this.buttonDeleteGuest_Click);
            // 
            // buttonUpdateGuest
            // 
            this.buttonUpdateGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateGuest.Image")));
            this.buttonUpdateGuest.Location = new System.Drawing.Point(1013, 82);
            this.buttonUpdateGuest.Name = "buttonUpdateGuest";
            this.buttonUpdateGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonUpdateGuest.TabIndex = 3;
            this.buttonUpdateGuest.Text = "Vendég módosítása";
            this.buttonUpdateGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdateGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUpdateGuest.UseVisualStyleBackColor = true;
            this.buttonUpdateGuest.Click += new System.EventHandler(this.buttonUpdateGuest_Click);
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonBackToMainMenu.Image")));
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(1013, 508);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(157, 64);
            this.buttonBackToMainMenu.TabIndex = 5;
            this.buttonBackToMainMenu.Text = "Vissza a főmenübe";
            this.buttonBackToMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBackToMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
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
            // FormGuestDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 584);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonUpdateGuest);
            this.Controls.Add(this.buttonDeleteGuest);
            this.Controls.Add(this.buttonAddGuest);
            this.Controls.Add(this.listViewGuests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGuestDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendégadatbázis | Virtual Receptionist";
            this.Load += new System.EventHandler(this.FormGuestDatabase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewGuests;
        private System.Windows.Forms.Button buttonAddGuest;
        private System.Windows.Forms.Button buttonDeleteGuest;
        private System.Windows.Forms.Button buttonUpdateGuest;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDocumentID;
        private System.Windows.Forms.ColumnHeader columnHeaderCountry;
        private System.Windows.Forms.ColumnHeader columnHeaderZipCode;
        private System.Windows.Forms.ColumnHeader columnHeaderCity;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderVATNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderPhoneNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderEmailAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderCitizenship;
        private System.Windows.Forms.ColumnHeader columnHeaderBirthDate;
    }
}