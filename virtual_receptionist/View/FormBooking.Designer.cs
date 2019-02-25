namespace virtual_receptionist.View
{
    partial class FormBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooking));
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.tabControlBooking = new System.Windows.Forms.TabControl();
            this.tabPageBookings = new System.Windows.Forms.TabPage();
            this.tabPageRooms = new System.Windows.Forms.TabPage();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNewBooking = new System.Windows.Forms.Button();
            this.buttonUpdateBooking = new System.Windows.Forms.Button();
            this.buttonDeleteBooking = new System.Windows.Forms.Button();
            this.dateTimePickerArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGuest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGuestCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.tabControlBooking.SuspendLayout();
            this.tabPageBookings.SuspendLayout();
            this.tabPageRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.AllowUserToAddRows = false;
            this.dataGridViewBookings.AllowUserToDeleteRows = false;
            this.dataGridViewBookings.AllowUserToResizeColumns = false;
            this.dataGridViewBookings.AllowUserToResizeRows = false;
            this.dataGridViewBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnGuest,
            this.ColumnCompanyName,
            this.ColumnRoomNumber,
            this.ColumnGuestCapacity,
            this.ColumnArrival,
            this.ColumnDeparture});
            this.dataGridViewBookings.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewBookings.MultiSelect = false;
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.ReadOnly = true;
            this.dataGridViewBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookings.Size = new System.Drawing.Size(1073, 526);
            this.dataGridViewBookings.TabIndex = 7;
            // 
            // tabControlBooking
            // 
            this.tabControlBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlBooking.Controls.Add(this.tabPageBookings);
            this.tabControlBooking.Controls.Add(this.tabPageRooms);
            this.tabControlBooking.Location = new System.Drawing.Point(12, 12);
            this.tabControlBooking.Name = "tabControlBooking";
            this.tabControlBooking.SelectedIndex = 0;
            this.tabControlBooking.Size = new System.Drawing.Size(1093, 564);
            this.tabControlBooking.TabIndex = 8;
            // 
            // tabPageBookings
            // 
            this.tabPageBookings.Controls.Add(this.dataGridViewBookings);
            this.tabPageBookings.Location = new System.Drawing.Point(4, 22);
            this.tabPageBookings.Name = "tabPageBookings";
            this.tabPageBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookings.Size = new System.Drawing.Size(1085, 538);
            this.tabPageBookings.TabIndex = 0;
            this.tabPageBookings.Text = "Foglalások";
            this.tabPageBookings.UseVisualStyleBackColor = true;
            // 
            // tabPageRooms
            // 
            this.tabPageRooms.Controls.Add(this.dataGridViewRooms);
            this.tabPageRooms.Location = new System.Drawing.Point(4, 22);
            this.tabPageRooms.Name = "tabPageRooms";
            this.tabPageRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRooms.Size = new System.Drawing.Size(1085, 538);
            this.tabPageRooms.TabIndex = 1;
            this.tabPageRooms.Text = "Kiadó szobák";
            this.tabPageRooms.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.AllowUserToResizeColumns = false;
            this.dataGridViewRooms.AllowUserToResizeRows = false;
            this.dataGridViewRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnNumber,
            this.ColumnCategory,
            this.ColumnCapacity});
            this.dataGridViewRooms.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewRooms.MultiSelect = false;
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRooms.Size = new System.Drawing.Size(1073, 526);
            this.dataGridViewRooms.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Szoba neve";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.DataPropertyName = "Number";
            this.ColumnNumber.HeaderText = "Szobaszám";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.DataPropertyName = "CategoryName";
            this.ColumnCategory.HeaderText = "Szobakategória";
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            // 
            // ColumnCapacity
            // 
            this.ColumnCapacity.DataPropertyName = "Capacity";
            this.ColumnCapacity.HeaderText = "Kapacitás";
            this.ColumnCapacity.Name = "ColumnCapacity";
            this.ColumnCapacity.ReadOnly = true;
            // 
            // buttonNewBooking
            // 
            this.buttonNewBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewBooking.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewBooking.Image")));
            this.buttonNewBooking.Location = new System.Drawing.Point(12, 582);
            this.buttonNewBooking.Name = "buttonNewBooking";
            this.buttonNewBooking.Size = new System.Drawing.Size(159, 64);
            this.buttonNewBooking.TabIndex = 9;
            this.buttonNewBooking.Text = "Foglalás rögzítése";
            this.buttonNewBooking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNewBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonNewBooking.UseVisualStyleBackColor = true;
            this.buttonNewBooking.Click += new System.EventHandler(this.buttonNewBooking_Click);
            // 
            // buttonUpdateBooking
            // 
            this.buttonUpdateBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateBooking.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateBooking.Image")));
            this.buttonUpdateBooking.Location = new System.Drawing.Point(177, 582);
            this.buttonUpdateBooking.Name = "buttonUpdateBooking";
            this.buttonUpdateBooking.Size = new System.Drawing.Size(159, 64);
            this.buttonUpdateBooking.TabIndex = 10;
            this.buttonUpdateBooking.Text = "Foglalás módosítása";
            this.buttonUpdateBooking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdateBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUpdateBooking.UseVisualStyleBackColor = true;
            this.buttonUpdateBooking.Click += new System.EventHandler(this.buttonUpdateBooking_Click);
            // 
            // buttonDeleteBooking
            // 
            this.buttonDeleteBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteBooking.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteBooking.Image")));
            this.buttonDeleteBooking.Location = new System.Drawing.Point(342, 582);
            this.buttonDeleteBooking.Name = "buttonDeleteBooking";
            this.buttonDeleteBooking.Size = new System.Drawing.Size(159, 64);
            this.buttonDeleteBooking.TabIndex = 11;
            this.buttonDeleteBooking.Text = "Foglalás törlése";
            this.buttonDeleteBooking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDeleteBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteBooking.UseVisualStyleBackColor = true;
            this.buttonDeleteBooking.Click += new System.EventHandler(this.buttonDeleteBooking_Click);
            // 
            // dateTimePickerArrivalDate
            // 
            this.dateTimePickerArrivalDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerArrivalDate.Location = new System.Drawing.Point(720, 626);
            this.dateTimePickerArrivalDate.Name = "dateTimePickerArrivalDate";
            this.dateTimePickerArrivalDate.Size = new System.Drawing.Size(189, 20);
            this.dateTimePickerArrivalDate.TabIndex = 12;
            this.dateTimePickerArrivalDate.ValueChanged += new System.EventHandler(this.dateTimePickerArrivalDate_ValueChanged);
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(915, 626);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(189, 20);
            this.dateTimePickerDepartureDate.TabIndex = 13;
            this.dateTimePickerDepartureDate.ValueChanged += new System.EventHandler(this.dateTimePickerDepartureDate_ValueChanged);
            // 
            // labelArrivalDate
            // 
            this.labelArrivalDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelArrivalDate.AutoSize = true;
            this.labelArrivalDate.Location = new System.Drawing.Point(717, 610);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(86, 13);
            this.labelArrivalDate.TabIndex = 14;
            this.labelArrivalDate.Text = "Érkezés dátuma:";
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDepartureDate.AutoSize = true;
            this.labelDepartureDate.Location = new System.Drawing.Point(912, 610);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(89, 13);
            this.labelDepartureDate.TabIndex = 15;
            this.labelDepartureDate.Text = "Távozás dátuma:";
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "ID";
            this.ColumnID.HeaderText = "Foglalás azonosító";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnGuest
            // 
            this.ColumnGuest.DataPropertyName = "GuestName";
            this.ColumnGuest.HeaderText = "Vendég neve";
            this.ColumnGuest.Name = "ColumnGuest";
            this.ColumnGuest.ReadOnly = true;
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.DataPropertyName = "CompanyName";
            this.ColumnCompanyName.HeaderText = "Cégnév";
            this.ColumnCompanyName.Name = "ColumnCompanyName";
            this.ColumnCompanyName.ReadOnly = true;
            // 
            // ColumnRoomNumber
            // 
            this.ColumnRoomNumber.DataPropertyName = "RoomNumber";
            this.ColumnRoomNumber.HeaderText = "Szobaszám";
            this.ColumnRoomNumber.Name = "ColumnRoomNumber";
            this.ColumnRoomNumber.ReadOnly = true;
            // 
            // ColumnGuestCapacity
            // 
            this.ColumnGuestCapacity.DataPropertyName = "NumberOfGuests";
            this.ColumnGuestCapacity.HeaderText = "Vendégszám";
            this.ColumnGuestCapacity.Name = "ColumnGuestCapacity";
            this.ColumnGuestCapacity.ReadOnly = true;
            // 
            // ColumnArrival
            // 
            this.ColumnArrival.DataPropertyName = "ArrivalDate";
            this.ColumnArrival.HeaderText = "Érkezés";
            this.ColumnArrival.Name = "ColumnArrival";
            this.ColumnArrival.ReadOnly = true;
            // 
            // ColumnDeparture
            // 
            this.ColumnDeparture.DataPropertyName = "DepartureDate";
            this.ColumnDeparture.HeaderText = "Távozás";
            this.ColumnDeparture.Name = "ColumnDeparture";
            this.ColumnDeparture.ReadOnly = true;
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 658);
            this.Controls.Add(this.labelDepartureDate);
            this.Controls.Add(this.labelArrivalDate);
            this.Controls.Add(this.dateTimePickerDepartureDate);
            this.Controls.Add(this.dateTimePickerArrivalDate);
            this.Controls.Add(this.buttonDeleteBooking);
            this.Controls.Add(this.buttonUpdateBooking);
            this.Controls.Add(this.buttonNewBooking);
            this.Controls.Add(this.tabControlBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foglalási napló | Virtual Receptionist";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.tabControlBooking.ResumeLayout(false);
            this.tabPageBookings.ResumeLayout(false);
            this.tabPageRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.TabControl tabControlBooking;
        private System.Windows.Forms.TabPage tabPageBookings;
        private System.Windows.Forms.TabPage tabPageRooms;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCapacity;
        private System.Windows.Forms.Button buttonNewBooking;
        private System.Windows.Forms.Button buttonUpdateBooking;
        private System.Windows.Forms.Button buttonDeleteBooking;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrivalDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        private System.Windows.Forms.Label labelArrivalDate;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGuestCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeparture;
    }
}