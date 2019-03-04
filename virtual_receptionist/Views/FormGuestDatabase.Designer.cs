namespace virtual_receptionist.Views
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
            this.tabControlGuestDatabase = new System.Windows.Forms.TabControl();
            this.tabPageGuest = new System.Windows.Forms.TabPage();
            this.groupBoxGuest = new System.Windows.Forms.GroupBox();
            this.labelGuestID = new System.Windows.Forms.Label();
            this.buttonDeleteGuest = new System.Windows.Forms.Button();
            this.buttonUpdateGuest = new System.Windows.Forms.Button();
            this.textBoxGuestID = new System.Windows.Forms.TextBox();
            this.textBoxGuestEmailAddress = new System.Windows.Forms.TextBox();
            this.buttonAddGuest = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxGuestPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelDocumentID = new System.Windows.Forms.Label();
            this.textBoxGuestAddress = new System.Windows.Forms.TextBox();
            this.labelCitizenship = new System.Windows.Forms.Label();
            this.textBoxGuestCity = new System.Windows.Forms.TextBox();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.textBoxGuestZipCode = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.comboBoxGuestCountry = new System.Windows.Forms.ComboBox();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.textBoxGuestBirthDate = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxGuestCitizenship = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxGuestDocumentNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxGuestName = new System.Windows.Forms.TextBox();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.listViewGuest = new System.Windows.Forms.ListView();
            this.columnHeaderGuestID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestDocumentNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestCitizenship = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestZipCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestEmailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlGuestDatabase.SuspendLayout();
            this.tabPageGuest.SuspendLayout();
            this.groupBoxGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlGuestDatabase
            // 
            this.tabControlGuestDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlGuestDatabase.Controls.Add(this.tabPageGuest);
            this.tabControlGuestDatabase.Location = new System.Drawing.Point(12, 12);
            this.tabControlGuestDatabase.Name = "tabControlGuestDatabase";
            this.tabControlGuestDatabase.SelectedIndex = 0;
            this.tabControlGuestDatabase.Size = new System.Drawing.Size(1092, 634);
            this.tabControlGuestDatabase.TabIndex = 0;
            // 
            // tabPageGuest
            // 
            this.tabPageGuest.Controls.Add(this.groupBoxGuest);
            this.tabPageGuest.Controls.Add(this.listViewGuest);
            this.tabPageGuest.Location = new System.Drawing.Point(4, 22);
            this.tabPageGuest.Name = "tabPageGuest";
            this.tabPageGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGuest.Size = new System.Drawing.Size(1084, 608);
            this.tabPageGuest.TabIndex = 1;
            this.tabPageGuest.Text = "Vendégek";
            this.tabPageGuest.UseVisualStyleBackColor = true;
            // 
            // groupBoxGuest
            // 
            this.groupBoxGuest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGuest.Controls.Add(this.labelGuestID);
            this.groupBoxGuest.Controls.Add(this.buttonDeleteGuest);
            this.groupBoxGuest.Controls.Add(this.buttonUpdateGuest);
            this.groupBoxGuest.Controls.Add(this.textBoxGuestID);
            this.groupBoxGuest.Controls.Add(this.textBoxGuestEmailAddress);
            this.groupBoxGuest.Controls.Add(this.buttonAddGuest);
            this.groupBoxGuest.Controls.Add(this.labelName);
            this.groupBoxGuest.Controls.Add(this.textBoxGuestPhoneNumber);
            this.groupBoxGuest.Controls.Add(this.labelDocumentID);
            this.groupBoxGuest.Controls.Add(this.textBoxGuestAddress);
            this.groupBoxGuest.Controls.Add(this.labelCitizenship);
            this.groupBoxGuest.Controls.Add(this.textBoxGuestCity);
            this.groupBoxGuest.Controls.Add(this.labelBirthDate);
            this.groupBoxGuest.Controls.Add(this.textBoxGuestZipCode);
            this.groupBoxGuest.Controls.Add(this.labelCountry);
            this.groupBoxGuest.Controls.Add(this.comboBoxGuestCountry);
            this.groupBoxGuest.Controls.Add(this.labelZipCode);
            this.groupBoxGuest.Controls.Add(this.textBoxGuestBirthDate);
            this.groupBoxGuest.Controls.Add(this.labelCity);
            this.groupBoxGuest.Controls.Add(this.textBoxGuestCitizenship);
            this.groupBoxGuest.Controls.Add(this.labelAddress);
            this.groupBoxGuest.Controls.Add(this.textBoxGuestDocumentNumber);
            this.groupBoxGuest.Controls.Add(this.labelPhoneNumber);
            this.groupBoxGuest.Controls.Add(this.textBoxGuestName);
            this.groupBoxGuest.Controls.Add(this.labelEmailAddress);
            this.groupBoxGuest.Location = new System.Drawing.Point(6, 419);
            this.groupBoxGuest.Name = "groupBoxGuest";
            this.groupBoxGuest.Size = new System.Drawing.Size(1072, 183);
            this.groupBoxGuest.TabIndex = 0;
            this.groupBoxGuest.TabStop = false;
            // 
            // labelGuestID
            // 
            this.labelGuestID.AutoSize = true;
            this.labelGuestID.Location = new System.Drawing.Point(8, 22);
            this.labelGuestID.Name = "labelGuestID";
            this.labelGuestID.Size = new System.Drawing.Size(94, 13);
            this.labelGuestID.TabIndex = 38;
            this.labelGuestID.Text = "Vendégazonosító:";
            // 
            // buttonDeleteGuest
            // 
            this.buttonDeleteGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteGuest.Image")));
            this.buttonDeleteGuest.Location = new System.Drawing.Point(909, 113);
            this.buttonDeleteGuest.Name = "buttonDeleteGuest";
            this.buttonDeleteGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonDeleteGuest.TabIndex = 4;
            this.buttonDeleteGuest.Text = "Vendég törlése";
            this.buttonDeleteGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDeleteGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteGuest.UseVisualStyleBackColor = true;
            this.buttonDeleteGuest.Click += new System.EventHandler(this.buttonDeleteGuest_Click);
            // 
            // buttonUpdateGuest
            // 
            this.buttonUpdateGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateGuest.Image")));
            this.buttonUpdateGuest.Location = new System.Drawing.Point(746, 113);
            this.buttonUpdateGuest.Name = "buttonUpdateGuest";
            this.buttonUpdateGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonUpdateGuest.TabIndex = 3;
            this.buttonUpdateGuest.Text = "Vendég módosítása";
            this.buttonUpdateGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdateGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUpdateGuest.UseVisualStyleBackColor = true;
            this.buttonUpdateGuest.Click += new System.EventHandler(this.buttonUpdateGuest_Click);
            // 
            // textBoxGuestID
            // 
            this.textBoxGuestID.Location = new System.Drawing.Point(108, 19);
            this.textBoxGuestID.Name = "textBoxGuestID";
            this.textBoxGuestID.ReadOnly = true;
            this.textBoxGuestID.Size = new System.Drawing.Size(185, 20);
            this.textBoxGuestID.TabIndex = 37;
            // 
            // textBoxGuestEmailAddress
            // 
            this.textBoxGuestEmailAddress.Location = new System.Drawing.Point(382, 124);
            this.textBoxGuestEmailAddress.Name = "textBoxGuestEmailAddress";
            this.textBoxGuestEmailAddress.Size = new System.Drawing.Size(185, 20);
            this.textBoxGuestEmailAddress.TabIndex = 14;
            // 
            // buttonAddGuest
            // 
            this.buttonAddGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddGuest.Image")));
            this.buttonAddGuest.Location = new System.Drawing.Point(583, 113);
            this.buttonAddGuest.Name = "buttonAddGuest";
            this.buttonAddGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonAddGuest.TabIndex = 2;
            this.buttonAddGuest.Text = "Új vendég hozzáadása";
            this.buttonAddGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddGuest.UseVisualStyleBackColor = true;
            this.buttonAddGuest.Click += new System.EventHandler(this.buttonAddGuest_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(72, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(30, 13);
            this.labelName.TabIndex = 27;
            this.labelName.Text = "Név:";
            // 
            // textBoxGuestPhoneNumber
            // 
            this.textBoxGuestPhoneNumber.Location = new System.Drawing.Point(382, 98);
            this.textBoxGuestPhoneNumber.Name = "textBoxGuestPhoneNumber";
            this.textBoxGuestPhoneNumber.Size = new System.Drawing.Size(185, 20);
            this.textBoxGuestPhoneNumber.TabIndex = 13;
            // 
            // labelDocumentID
            // 
            this.labelDocumentID.AutoSize = true;
            this.labelDocumentID.Location = new System.Drawing.Point(6, 74);
            this.labelDocumentID.Name = "labelDocumentID";
            this.labelDocumentID.Size = new System.Drawing.Size(96, 13);
            this.labelDocumentID.TabIndex = 28;
            this.labelDocumentID.Text = "Okmányazonosító:";
            // 
            // textBoxGuestAddress
            // 
            this.textBoxGuestAddress.Location = new System.Drawing.Point(382, 72);
            this.textBoxGuestAddress.Name = "textBoxGuestAddress";
            this.textBoxGuestAddress.Size = new System.Drawing.Size(185, 20);
            this.textBoxGuestAddress.TabIndex = 12;
            // 
            // labelCitizenship
            // 
            this.labelCitizenship.AutoSize = true;
            this.labelCitizenship.Location = new System.Drawing.Point(21, 101);
            this.labelCitizenship.Name = "labelCitizenship";
            this.labelCitizenship.Size = new System.Drawing.Size(81, 13);
            this.labelCitizenship.TabIndex = 29;
            this.labelCitizenship.Text = "Állampolgárság:";
            // 
            // textBoxGuestCity
            // 
            this.textBoxGuestCity.Location = new System.Drawing.Point(382, 45);
            this.textBoxGuestCity.Name = "textBoxGuestCity";
            this.textBoxGuestCity.Size = new System.Drawing.Size(185, 20);
            this.textBoxGuestCity.TabIndex = 11;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(33, 127);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(69, 13);
            this.labelBirthDate.TabIndex = 30;
            this.labelBirthDate.Text = "Születési idő:";
            // 
            // textBoxGuestZipCode
            // 
            this.textBoxGuestZipCode.Location = new System.Drawing.Point(382, 19);
            this.textBoxGuestZipCode.Name = "textBoxGuestZipCode";
            this.textBoxGuestZipCode.Size = new System.Drawing.Size(185, 20);
            this.textBoxGuestZipCode.TabIndex = 10;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(59, 154);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 31;
            this.labelCountry.Text = "Ország:";
            // 
            // comboBoxGuestCountry
            // 
            this.comboBoxGuestCountry.FormattingEnabled = true;
            this.comboBoxGuestCountry.Location = new System.Drawing.Point(108, 151);
            this.comboBoxGuestCountry.Name = "comboBoxGuestCountry";
            this.comboBoxGuestCountry.Size = new System.Drawing.Size(185, 21);
            this.comboBoxGuestCountry.TabIndex = 9;
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(306, 22);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(70, 13);
            this.labelZipCode.TabIndex = 32;
            this.labelZipCode.Text = "Irányítószám:";
            // 
            // textBoxGuestBirthDate
            // 
            this.textBoxGuestBirthDate.Location = new System.Drawing.Point(108, 124);
            this.textBoxGuestBirthDate.Name = "textBoxGuestBirthDate";
            this.textBoxGuestBirthDate.Size = new System.Drawing.Size(185, 20);
            this.textBoxGuestBirthDate.TabIndex = 8;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(320, 48);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(56, 13);
            this.labelCity.TabIndex = 33;
            this.labelCity.Text = "Település:";
            // 
            // textBoxGuestCitizenship
            // 
            this.textBoxGuestCitizenship.Location = new System.Drawing.Point(108, 97);
            this.textBoxGuestCitizenship.Name = "textBoxGuestCitizenship";
            this.textBoxGuestCitizenship.Size = new System.Drawing.Size(185, 20);
            this.textBoxGuestCitizenship.TabIndex = 7;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(347, 75);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(29, 13);
            this.labelAddress.TabIndex = 34;
            this.labelAddress.Text = "Cím:";
            // 
            // textBoxGuestDocumentNumber
            // 
            this.textBoxGuestDocumentNumber.Location = new System.Drawing.Point(108, 71);
            this.textBoxGuestDocumentNumber.Name = "textBoxGuestDocumentNumber";
            this.textBoxGuestDocumentNumber.Size = new System.Drawing.Size(185, 20);
            this.textBoxGuestDocumentNumber.TabIndex = 6;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(306, 100);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(70, 13);
            this.labelPhoneNumber.TabIndex = 35;
            this.labelPhoneNumber.Text = "Telefonszám:";
            // 
            // textBoxGuestName
            // 
            this.textBoxGuestName.Location = new System.Drawing.Point(108, 45);
            this.textBoxGuestName.Name = "textBoxGuestName";
            this.textBoxGuestName.Size = new System.Drawing.Size(185, 20);
            this.textBoxGuestName.TabIndex = 5;
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(317, 127);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(59, 13);
            this.labelEmailAddress.TabIndex = 36;
            this.labelEmailAddress.Text = "E-mail cím:";
            // 
            // listViewGuest
            // 
            this.listViewGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewGuest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderGuestID,
            this.columnHeaderGuestName,
            this.columnHeaderGuestDocumentNumber,
            this.columnHeaderGuestCitizenship,
            this.columnHeaderGuestBirthDate,
            this.columnHeaderGuestCountry,
            this.columnHeaderGuestZipCode,
            this.columnHeaderGuestCity,
            this.columnHeaderGuestAddress,
            this.columnHeaderGuestPhoneNumber,
            this.columnHeaderGuestEmailAddress});
            this.listViewGuest.FullRowSelect = true;
            this.listViewGuest.GridLines = true;
            this.listViewGuest.Location = new System.Drawing.Point(3, 3);
            this.listViewGuest.Name = "listViewGuest";
            this.listViewGuest.Size = new System.Drawing.Size(1075, 410);
            this.listViewGuest.TabIndex = 1;
            this.listViewGuest.UseCompatibleStateImageBehavior = false;
            this.listViewGuest.View = System.Windows.Forms.View.Details;
            this.listViewGuest.SelectedIndexChanged += new System.EventHandler(this.listViewGuest_SelectedIndexChanged);
            // 
            // columnHeaderGuestID
            // 
            this.columnHeaderGuestID.Text = "Vendégazonosító";
            this.columnHeaderGuestID.Width = 150;
            // 
            // columnHeaderGuestName
            // 
            this.columnHeaderGuestName.Text = "Név";
            this.columnHeaderGuestName.Width = 150;
            // 
            // columnHeaderGuestDocumentNumber
            // 
            this.columnHeaderGuestDocumentNumber.Text = "Okmányazonosító";
            this.columnHeaderGuestDocumentNumber.Width = 150;
            // 
            // columnHeaderGuestCitizenship
            // 
            this.columnHeaderGuestCitizenship.Text = "Állampolgárság";
            this.columnHeaderGuestCitizenship.Width = 150;
            // 
            // columnHeaderGuestBirthDate
            // 
            this.columnHeaderGuestBirthDate.Text = "Születési idő";
            this.columnHeaderGuestBirthDate.Width = 150;
            // 
            // columnHeaderGuestCountry
            // 
            this.columnHeaderGuestCountry.Text = "Ország";
            this.columnHeaderGuestCountry.Width = 150;
            // 
            // columnHeaderGuestZipCode
            // 
            this.columnHeaderGuestZipCode.Text = "Irányítószám";
            this.columnHeaderGuestZipCode.Width = 150;
            // 
            // columnHeaderGuestCity
            // 
            this.columnHeaderGuestCity.Text = "Település";
            this.columnHeaderGuestCity.Width = 150;
            // 
            // columnHeaderGuestAddress
            // 
            this.columnHeaderGuestAddress.Text = "Cím";
            this.columnHeaderGuestAddress.Width = 150;
            // 
            // columnHeaderGuestPhoneNumber
            // 
            this.columnHeaderGuestPhoneNumber.Text = "Telefonszám";
            this.columnHeaderGuestPhoneNumber.Width = 150;
            // 
            // columnHeaderGuestEmailAddress
            // 
            this.columnHeaderGuestEmailAddress.Text = "E-mail cím";
            this.columnHeaderGuestEmailAddress.Width = 150;
            // 
            // FormGuestDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 658);
            this.Controls.Add(this.tabControlGuestDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGuestDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendégadatbázis | Virtual Receptionist";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGuestDatabase_Load);
            this.tabControlGuestDatabase.ResumeLayout(false);
            this.tabPageGuest.ResumeLayout(false);
            this.groupBoxGuest.ResumeLayout(false);
            this.groupBoxGuest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlGuestDatabase;
        private System.Windows.Forms.TabPage tabPageGuest;
        private System.Windows.Forms.ListView listViewGuest;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestName;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestDocumentNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestCitizenship;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestBirthDate;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestCountry;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestZipCode;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestCity;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestPhoneNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestEmailAddress;
        private System.Windows.Forms.Button buttonUpdateGuest;
        private System.Windows.Forms.Button buttonDeleteGuest;
        private System.Windows.Forms.Button buttonAddGuest;
        private System.Windows.Forms.GroupBox groupBoxGuest;
        private System.Windows.Forms.TextBox textBoxGuestEmailAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxGuestPhoneNumber;
        private System.Windows.Forms.Label labelDocumentID;
        private System.Windows.Forms.TextBox textBoxGuestAddress;
        private System.Windows.Forms.Label labelCitizenship;
        private System.Windows.Forms.TextBox textBoxGuestCity;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.TextBox textBoxGuestZipCode;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.ComboBox comboBoxGuestCountry;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.TextBox textBoxGuestBirthDate;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxGuestCitizenship;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxGuestDocumentNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxGuestName;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestID;
        private System.Windows.Forms.TextBox textBoxGuestID;
        private System.Windows.Forms.Label labelGuestID;
    }
}