namespace virtual_receptionist.Views
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
            this.buttonNewBooking = new System.Windows.Forms.Button();
            this.buttonUpdateBooking = new System.Windows.Forms.Button();
            this.buttonDeleteBooking = new System.Windows.Forms.Button();
            this.dateTimePickerArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.tabPageBookings = new System.Windows.Forms.TabPage();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.tabControlBooking = new System.Windows.Forms.TabControl();
            this.columnBookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnsRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumberOfGuests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnsDepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.tabControlBooking.SuspendLayout();
            this.SuspendLayout();
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
            this.dateTimePickerArrivalDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerArrivalDate.Location = new System.Drawing.Point(720, 626);
            this.dateTimePickerArrivalDate.Name = "dateTimePickerArrivalDate";
            this.dateTimePickerArrivalDate.Size = new System.Drawing.Size(189, 20);
            this.dateTimePickerArrivalDate.TabIndex = 12;
            this.dateTimePickerArrivalDate.ValueChanged += new System.EventHandler(this.dateTimePickerArrivalDate_ValueChanged);
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDepartureDate.CustomFormat = "yyyy-MM-dd";
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
            // tabPageBookings
            // 
            this.tabPageBookings.Controls.Add(this.dataGridViewBookings);
            this.tabPageBookings.Location = new System.Drawing.Point(4, 22);
            this.tabPageBookings.Name = "tabPageBookings";
            this.tabPageBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookings.Size = new System.Drawing.Size(1085, 538);
            this.tabPageBookings.TabIndex = 2;
            this.tabPageBookings.Text = "Foglalások";
            this.tabPageBookings.UseVisualStyleBackColor = true;
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
            this.columnBookingID,
            this.columnGuestName,
            this.columnsRoomNumber,
            this.columnNumberOfGuests,
            this.columnArrivalDate,
            this.columnsDepartureDate,
            this.ColumnPaid});
            this.dataGridViewBookings.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBookings.MultiSelect = false;
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.ReadOnly = true;
            this.dataGridViewBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookings.Size = new System.Drawing.Size(1079, 532);
            this.dataGridViewBookings.TabIndex = 8;
            // 
            // tabControlBooking
            // 
            this.tabControlBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlBooking.Controls.Add(this.tabPageBookings);
            this.tabControlBooking.Location = new System.Drawing.Point(12, 12);
            this.tabControlBooking.Name = "tabControlBooking";
            this.tabControlBooking.SelectedIndex = 0;
            this.tabControlBooking.Size = new System.Drawing.Size(1093, 564);
            this.tabControlBooking.TabIndex = 8;
            // 
            // columnBookingID
            // 
            this.columnBookingID.DataPropertyName = "ID";
            this.columnBookingID.HeaderText = "Foglalás azonosító";
            this.columnBookingID.Name = "columnBookingID";
            this.columnBookingID.ReadOnly = true;
            // 
            // columnGuestName
            // 
            this.columnGuestName.DataPropertyName = "GuestName";
            this.columnGuestName.HeaderText = "Vendég neve";
            this.columnGuestName.Name = "columnGuestName";
            this.columnGuestName.ReadOnly = true;
            // 
            // columnsRoomNumber
            // 
            this.columnsRoomNumber.DataPropertyName = "RoomNumber";
            this.columnsRoomNumber.HeaderText = "Szobaszám";
            this.columnsRoomNumber.Name = "columnsRoomNumber";
            this.columnsRoomNumber.ReadOnly = true;
            // 
            // columnNumberOfGuests
            // 
            this.columnNumberOfGuests.DataPropertyName = "NumberOfGuests";
            this.columnNumberOfGuests.HeaderText = "Vendégszám";
            this.columnNumberOfGuests.Name = "columnNumberOfGuests";
            this.columnNumberOfGuests.ReadOnly = true;
            // 
            // columnArrivalDate
            // 
            this.columnArrivalDate.DataPropertyName = "ArrivalDate";
            this.columnArrivalDate.HeaderText = "Érkezés";
            this.columnArrivalDate.Name = "columnArrivalDate";
            this.columnArrivalDate.ReadOnly = true;
            // 
            // columnsDepartureDate
            // 
            this.columnsDepartureDate.DataPropertyName = "DepartureDate";
            this.columnsDepartureDate.HeaderText = "Távozás";
            this.columnsDepartureDate.Name = "columnsDepartureDate";
            this.columnsDepartureDate.ReadOnly = true;
            // 
            // ColumnPaid
            // 
            this.ColumnPaid.DataPropertyName = "Paid";
            this.ColumnPaid.HeaderText = "Számlázott?";
            this.ColumnPaid.Name = "ColumnPaid";
            this.ColumnPaid.ReadOnly = true;
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
            this.tabPageBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.tabControlBooking.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNewBooking;
        private System.Windows.Forms.Button buttonUpdateBooking;
        private System.Windows.Forms.Button buttonDeleteBooking;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrivalDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        private System.Windows.Forms.Label labelArrivalDate;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.TabPage tabPageBookings;
        private System.Windows.Forms.TabControl tabControlBooking;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnsRoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumberOfGuests;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnArrivalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnsDepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPaid;
    }
}