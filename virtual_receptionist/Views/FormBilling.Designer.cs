namespace virtual_receptionist.Views
{
    partial class FormBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBilling));
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ColumnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPrintInvoice = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.printDialogPrinter = new System.Windows.Forms.PrintDialog();
            this.printDocumentInvoice = new System.Drawing.Printing.PrintDocument();
            this.groupBoxBillingData = new System.Windows.Forms.GroupBox();
            this.textBoxBillingCity = new System.Windows.Forms.TextBox();
            this.labelBillingCity = new System.Windows.Forms.Label();
            this.labelBillingZipCode = new System.Windows.Forms.Label();
            this.checkBoxIsCompany = new System.Windows.Forms.CheckBox();
            this.labelVATNumber = new System.Windows.Forms.Label();
            this.labelBillingCountry = new System.Windows.Forms.Label();
            this.textBoxBillingAddress = new System.Windows.Forms.TextBox();
            this.comboBoxBillingCountry = new System.Windows.Forms.ComboBox();
            this.labelBillingAddress = new System.Windows.Forms.Label();
            this.labelBillingName = new System.Windows.Forms.Label();
            this.textBoxBillingZipCode = new System.Windows.Forms.TextBox();
            this.textBoxVATNumber = new System.Windows.Forms.TextBox();
            this.textBoxBillingName = new System.Windows.Forms.TextBox();
            this.listViewToBill = new System.Windows.Forms.ListView();
            this.columnHeaderBookingID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGuest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumberOfGuests = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArrivalDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDepartureDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxBookingToBill = new System.Windows.Forms.GroupBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.groupBoxBillingData.SuspendLayout();
            this.groupBoxBookingToBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AllowUserToResizeColumns = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItem,
            this.ColumnPrice,
            this.ColumnUnit,
            this.ColumnQuantity});
            this.dataGridViewItems.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewItems.MultiSelect = false;
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(874, 204);
            this.dataGridViewItems.TabIndex = 8;
            this.dataGridViewItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewItems_RowsAdded);
            this.dataGridViewItems.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewItems_RowsRemoved);
            // 
            // ColumnItem
            // 
            this.ColumnItem.DataPropertyName = "Tétel";
            this.ColumnItem.HeaderText = "Tétel";
            this.ColumnItem.Name = "ColumnItem";
            this.ColumnItem.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.DataPropertyName = "Ár";
            this.ColumnPrice.HeaderText = "Ár";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnUnit
            // 
            this.ColumnUnit.DataPropertyName = "Egység";
            this.ColumnUnit.HeaderText = "Egység";
            this.ColumnUnit.Name = "ColumnUnit";
            this.ColumnUnit.ReadOnly = true;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Mennyiség";
            this.ColumnQuantity.HeaderText = "Mennyiség";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            // 
            // buttonPrintInvoice
            // 
            this.buttonPrintInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrintInvoice.Enabled = false;
            this.buttonPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrintInvoice.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrintInvoice.Image")));
            this.buttonPrintInvoice.Location = new System.Drawing.Point(892, 498);
            this.buttonPrintInvoice.Name = "buttonPrintInvoice";
            this.buttonPrintInvoice.Size = new System.Drawing.Size(157, 64);
            this.buttonPrintInvoice.TabIndex = 5;
            this.buttonPrintInvoice.Text = "Számla nyomtatása";
            this.buttonPrintInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPrintInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPrintInvoice.UseVisualStyleBackColor = true;
            this.buttonPrintInvoice.Click += new System.EventHandler(this.buttonPrintInvoice_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddItem.Enabled = false;
            this.buttonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddItem.Image")));
            this.buttonAddItem.Location = new System.Drawing.Point(892, 12);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(157, 64);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "Tétel hozzáadása";
            this.buttonAddItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateItem.Enabled = false;
            this.buttonUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateItem.Image")));
            this.buttonUpdateItem.Location = new System.Drawing.Point(892, 82);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(157, 64);
            this.buttonUpdateItem.TabIndex = 3;
            this.buttonUpdateItem.Text = "Tétel módosítása";
            this.buttonUpdateItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdateItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUpdateItem.UseVisualStyleBackColor = true;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteItem.Enabled = false;
            this.buttonDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteItem.Image")));
            this.buttonDeleteItem.Location = new System.Drawing.Point(892, 152);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(157, 64);
            this.buttonDeleteItem.TabIndex = 4;
            this.buttonDeleteItem.Text = "Tétel törlése";
            this.buttonDeleteItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // printDialogPrinter
            // 
            this.printDialogPrinter.UseEXDialog = true;
            // 
            // groupBoxBillingData
            // 
            this.groupBoxBillingData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBillingData.Controls.Add(this.textBoxBillingCity);
            this.groupBoxBillingData.Controls.Add(this.labelBillingCity);
            this.groupBoxBillingData.Controls.Add(this.labelBillingZipCode);
            this.groupBoxBillingData.Controls.Add(this.checkBoxIsCompany);
            this.groupBoxBillingData.Controls.Add(this.labelVATNumber);
            this.groupBoxBillingData.Controls.Add(this.labelBillingCountry);
            this.groupBoxBillingData.Controls.Add(this.textBoxBillingAddress);
            this.groupBoxBillingData.Controls.Add(this.comboBoxBillingCountry);
            this.groupBoxBillingData.Controls.Add(this.labelBillingAddress);
            this.groupBoxBillingData.Controls.Add(this.labelBillingName);
            this.groupBoxBillingData.Controls.Add(this.textBoxBillingZipCode);
            this.groupBoxBillingData.Controls.Add(this.textBoxVATNumber);
            this.groupBoxBillingData.Controls.Add(this.textBoxBillingName);
            this.groupBoxBillingData.Location = new System.Drawing.Point(12, 430);
            this.groupBoxBillingData.Name = "groupBoxBillingData";
            this.groupBoxBillingData.Size = new System.Drawing.Size(874, 132);
            this.groupBoxBillingData.TabIndex = 9;
            this.groupBoxBillingData.TabStop = false;
            this.groupBoxBillingData.Text = "Számlázási adatok";
            // 
            // textBoxBillingCity
            // 
            this.textBoxBillingCity.Location = new System.Drawing.Point(207, 84);
            this.textBoxBillingCity.Name = "textBoxBillingCity";
            this.textBoxBillingCity.Size = new System.Drawing.Size(225, 20);
            this.textBoxBillingCity.TabIndex = 13;
            // 
            // labelBillingCity
            // 
            this.labelBillingCity.AutoSize = true;
            this.labelBillingCity.Location = new System.Drawing.Point(145, 87);
            this.labelBillingCity.Name = "labelBillingCity";
            this.labelBillingCity.Size = new System.Drawing.Size(56, 13);
            this.labelBillingCity.TabIndex = 12;
            this.labelBillingCity.Text = "Település:";
            // 
            // labelBillingZipCode
            // 
            this.labelBillingZipCode.AutoSize = true;
            this.labelBillingZipCode.Location = new System.Drawing.Point(451, 60);
            this.labelBillingZipCode.Name = "labelBillingZipCode";
            this.labelBillingZipCode.Size = new System.Drawing.Size(70, 13);
            this.labelBillingZipCode.TabIndex = 11;
            this.labelBillingZipCode.Text = "Irányítószám:";
            // 
            // checkBoxIsCompany
            // 
            this.checkBoxIsCompany.AutoSize = true;
            this.checkBoxIsCompany.Location = new System.Drawing.Point(758, 33);
            this.checkBoxIsCompany.Name = "checkBoxIsCompany";
            this.checkBoxIsCompany.Size = new System.Drawing.Size(91, 17);
            this.checkBoxIsCompany.TabIndex = 10;
            this.checkBoxIsCompany.Text = "Céges számla";
            this.checkBoxIsCompany.UseVisualStyleBackColor = true;
            this.checkBoxIsCompany.CheckedChanged += new System.EventHandler(this.checkBoxIsCompany_CheckedChanged);
            // 
            // labelVATNumber
            // 
            this.labelVATNumber.AutoSize = true;
            this.labelVATNumber.Location = new System.Drawing.Point(468, 34);
            this.labelVATNumber.Name = "labelVATNumber";
            this.labelVATNumber.Size = new System.Drawing.Size(53, 13);
            this.labelVATNumber.TabIndex = 9;
            this.labelVATNumber.Text = "Adószám:";
            // 
            // labelBillingCountry
            // 
            this.labelBillingCountry.AutoSize = true;
            this.labelBillingCountry.Location = new System.Drawing.Point(158, 61);
            this.labelBillingCountry.Name = "labelBillingCountry";
            this.labelBillingCountry.Size = new System.Drawing.Size(43, 13);
            this.labelBillingCountry.TabIndex = 8;
            this.labelBillingCountry.Text = "Ország:";
            // 
            // textBoxBillingAddress
            // 
            this.textBoxBillingAddress.Location = new System.Drawing.Point(527, 83);
            this.textBoxBillingAddress.Name = "textBoxBillingAddress";
            this.textBoxBillingAddress.Size = new System.Drawing.Size(225, 20);
            this.textBoxBillingAddress.TabIndex = 7;
            // 
            // comboBoxBillingCountry
            // 
            this.comboBoxBillingCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBillingCountry.FormattingEnabled = true;
            this.comboBoxBillingCountry.Location = new System.Drawing.Point(207, 57);
            this.comboBoxBillingCountry.Name = "comboBoxBillingCountry";
            this.comboBoxBillingCountry.Size = new System.Drawing.Size(225, 21);
            this.comboBoxBillingCountry.TabIndex = 6;
            // 
            // labelBillingAddress
            // 
            this.labelBillingAddress.AutoSize = true;
            this.labelBillingAddress.Location = new System.Drawing.Point(492, 86);
            this.labelBillingAddress.Name = "labelBillingAddress";
            this.labelBillingAddress.Size = new System.Drawing.Size(29, 13);
            this.labelBillingAddress.TabIndex = 5;
            this.labelBillingAddress.Text = "Cím:";
            // 
            // labelBillingName
            // 
            this.labelBillingName.AutoSize = true;
            this.labelBillingName.Location = new System.Drawing.Point(118, 34);
            this.labelBillingName.Name = "labelBillingName";
            this.labelBillingName.Size = new System.Drawing.Size(83, 13);
            this.labelBillingName.TabIndex = 4;
            this.labelBillingName.Text = "Számlázási név:";
            // 
            // textBoxBillingZipCode
            // 
            this.textBoxBillingZipCode.Location = new System.Drawing.Point(527, 57);
            this.textBoxBillingZipCode.Name = "textBoxBillingZipCode";
            this.textBoxBillingZipCode.Size = new System.Drawing.Size(225, 20);
            this.textBoxBillingZipCode.TabIndex = 3;
            // 
            // textBoxVATNumber
            // 
            this.textBoxVATNumber.Enabled = false;
            this.textBoxVATNumber.Location = new System.Drawing.Point(527, 31);
            this.textBoxVATNumber.Name = "textBoxVATNumber";
            this.textBoxVATNumber.Size = new System.Drawing.Size(225, 20);
            this.textBoxVATNumber.TabIndex = 2;
            // 
            // textBoxBillingName
            // 
            this.textBoxBillingName.Location = new System.Drawing.Point(207, 31);
            this.textBoxBillingName.Name = "textBoxBillingName";
            this.textBoxBillingName.Size = new System.Drawing.Size(225, 20);
            this.textBoxBillingName.TabIndex = 0;
            // 
            // listViewToBill
            // 
            this.listViewToBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewToBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBookingID,
            this.columnGuest,
            this.columnHeaderRoom,
            this.columnHeaderNumberOfGuests,
            this.columnHeaderArrivalDate,
            this.columnHeaderDepartureDate});
            this.listViewToBill.FullRowSelect = true;
            this.listViewToBill.GridLines = true;
            this.listViewToBill.Location = new System.Drawing.Point(6, 19);
            this.listViewToBill.MultiSelect = false;
            this.listViewToBill.Name = "listViewToBill";
            this.listViewToBill.Size = new System.Drawing.Size(862, 146);
            this.listViewToBill.TabIndex = 10;
            this.listViewToBill.UseCompatibleStateImageBehavior = false;
            this.listViewToBill.View = System.Windows.Forms.View.Details;
            this.listViewToBill.SelectedIndexChanged += new System.EventHandler(this.listViewToBill_SelectedIndexChanged);
            // 
            // columnHeaderBookingID
            // 
            this.columnHeaderBookingID.Text = "Foglalás azonosító";
            this.columnHeaderBookingID.Width = 200;
            // 
            // columnGuest
            // 
            this.columnGuest.Text = "Vendég neve";
            this.columnGuest.Width = 200;
            // 
            // columnHeaderRoom
            // 
            this.columnHeaderRoom.Text = "Szoba";
            this.columnHeaderRoom.Width = 200;
            // 
            // columnHeaderNumberOfGuests
            // 
            this.columnHeaderNumberOfGuests.Text = "Vendégszám";
            this.columnHeaderNumberOfGuests.Width = 200;
            // 
            // columnHeaderArrivalDate
            // 
            this.columnHeaderArrivalDate.Text = "Érkezés";
            this.columnHeaderArrivalDate.Width = 200;
            // 
            // columnHeaderDepartureDate
            // 
            this.columnHeaderDepartureDate.Text = "Távozás";
            this.columnHeaderDepartureDate.Width = 200;
            // 
            // groupBoxBookingToBill
            // 
            this.groupBoxBookingToBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBookingToBill.Controls.Add(this.listViewToBill);
            this.groupBoxBookingToBill.Location = new System.Drawing.Point(12, 253);
            this.groupBoxBookingToBill.Name = "groupBoxBookingToBill";
            this.groupBoxBookingToBill.Size = new System.Drawing.Size(874, 171);
            this.groupBoxBookingToBill.TabIndex = 11;
            this.groupBoxBookingToBill.TabStop = false;
            this.groupBoxBookingToBill.Text = "Számlázandó foglalások";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalPrice.Location = new System.Drawing.Point(506, 222);
            this.textBoxTotalPrice.Multiline = true;
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(380, 25);
            this.textBoxTotalPrice.TabIndex = 12;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotalPrice.Location = new System.Drawing.Point(305, 223);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(195, 24);
            this.labelTotalPrice.TabIndex = 13;
            this.labelTotalPrice.Text = "Fizetendő végösszeg:";
            // 
            // FormBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 574);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.groupBoxBookingToBill);
            this.Controls.Add(this.groupBoxBillingData);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonUpdateItem);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.buttonPrintInvoice);
            this.Controls.Add(this.dataGridViewItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Számla kiállítása | Virtual Receptionist";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBilling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.groupBoxBillingData.ResumeLayout(false);
            this.groupBoxBillingData.PerformLayout();
            this.groupBoxBookingToBill.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button buttonPrintInvoice;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonUpdateItem;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.PrintDialog printDialogPrinter;
        private System.Drawing.Printing.PrintDocument printDocumentInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.GroupBox groupBoxBillingData;
        private System.Windows.Forms.ListView listViewToBill;
        private System.Windows.Forms.ColumnHeader columnHeaderBookingID;
        private System.Windows.Forms.ColumnHeader columnGuest;
        private System.Windows.Forms.ColumnHeader columnHeaderRoom;
        private System.Windows.Forms.ColumnHeader columnHeaderNumberOfGuests;
        private System.Windows.Forms.ColumnHeader columnHeaderArrivalDate;
        private System.Windows.Forms.ColumnHeader columnHeaderDepartureDate;
        private System.Windows.Forms.GroupBox groupBoxBookingToBill;
        private System.Windows.Forms.TextBox textBoxBillingZipCode;
        private System.Windows.Forms.TextBox textBoxVATNumber;
        private System.Windows.Forms.TextBox textBoxBillingName;
        private System.Windows.Forms.Label labelBillingName;
        private System.Windows.Forms.ComboBox comboBoxBillingCountry;
        private System.Windows.Forms.Label labelBillingAddress;
        private System.Windows.Forms.TextBox textBoxBillingAddress;
        private System.Windows.Forms.Label labelBillingCountry;
        private System.Windows.Forms.CheckBox checkBoxIsCompany;
        private System.Windows.Forms.Label labelVATNumber;
        private System.Windows.Forms.Label labelBillingZipCode;
        private System.Windows.Forms.TextBox textBoxBillingCity;
        private System.Windows.Forms.Label labelBillingCity;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label labelTotalPrice;
    }
}
