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
            this.tabPageGuestBookings = new System.Windows.Forms.TabPage();
            this.tabPageCompanyBookings = new System.Windows.Forms.TabPage();
            this.dataGridViewCompanyBookings = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGuest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGuestCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlBooking = new System.Windows.Forms.TabControl();
            this.dataGridViewGuestBookings = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageGuestBookings.SuspendLayout();
            this.tabPageCompanyBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanyBookings)).BeginInit();
            this.tabControlBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestBookings)).BeginInit();
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
            // tabPageGuestBookings
            // 
            this.tabPageGuestBookings.Controls.Add(this.dataGridViewGuestBookings);
            this.tabPageGuestBookings.Location = new System.Drawing.Point(4, 22);
            this.tabPageGuestBookings.Name = "tabPageGuestBookings";
            this.tabPageGuestBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGuestBookings.Size = new System.Drawing.Size(1085, 538);
            this.tabPageGuestBookings.TabIndex = 2;
            this.tabPageGuestBookings.Text = "Vendég foglalások";
            this.tabPageGuestBookings.UseVisualStyleBackColor = true;
            // 
            // tabPageCompanyBookings
            // 
            this.tabPageCompanyBookings.Controls.Add(this.dataGridViewCompanyBookings);
            this.tabPageCompanyBookings.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompanyBookings.Name = "tabPageCompanyBookings";
            this.tabPageCompanyBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompanyBookings.Size = new System.Drawing.Size(1085, 538);
            this.tabPageCompanyBookings.TabIndex = 0;
            this.tabPageCompanyBookings.Text = "Céges foglalások";
            this.tabPageCompanyBookings.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCompanyBookings
            // 
            this.dataGridViewCompanyBookings.AllowUserToAddRows = false;
            this.dataGridViewCompanyBookings.AllowUserToDeleteRows = false;
            this.dataGridViewCompanyBookings.AllowUserToResizeColumns = false;
            this.dataGridViewCompanyBookings.AllowUserToResizeRows = false;
            this.dataGridViewCompanyBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCompanyBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCompanyBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompanyBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnGuest,
            this.ColumnCompanyName,
            this.ColumnRoomNumber,
            this.ColumnGuestCapacity,
            this.ColumnArrival,
            this.ColumnDeparture});
            this.dataGridViewCompanyBookings.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCompanyBookings.MultiSelect = false;
            this.dataGridViewCompanyBookings.Name = "dataGridViewCompanyBookings";
            this.dataGridViewCompanyBookings.ReadOnly = true;
            this.dataGridViewCompanyBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCompanyBookings.Size = new System.Drawing.Size(1079, 532);
            this.dataGridViewCompanyBookings.TabIndex = 7;
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
            // tabControlBooking
            // 
            this.tabControlBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlBooking.Controls.Add(this.tabPageGuestBookings);
            this.tabControlBooking.Controls.Add(this.tabPageCompanyBookings);
            this.tabControlBooking.Location = new System.Drawing.Point(12, 12);
            this.tabControlBooking.Name = "tabControlBooking";
            this.tabControlBooking.SelectedIndex = 0;
            this.tabControlBooking.Size = new System.Drawing.Size(1093, 564);
            this.tabControlBooking.TabIndex = 8;
            // 
            // dataGridViewGuestBookings
            // 
            this.dataGridViewGuestBookings.AllowUserToAddRows = false;
            this.dataGridViewGuestBookings.AllowUserToDeleteRows = false;
            this.dataGridViewGuestBookings.AllowUserToResizeColumns = false;
            this.dataGridViewGuestBookings.AllowUserToResizeRows = false;
            this.dataGridViewGuestBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGuestBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGuestBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuestBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridViewGuestBookings.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewGuestBookings.MultiSelect = false;
            this.dataGridViewGuestBookings.Name = "dataGridViewGuestBookings";
            this.dataGridViewGuestBookings.ReadOnly = true;
            this.dataGridViewGuestBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGuestBookings.Size = new System.Drawing.Size(1079, 532);
            this.dataGridViewGuestBookings.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Foglalás azonosító";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GuestName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vendég neve";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cégnév";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RoomNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "Szobaszám";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NumberOfGuests";
            this.dataGridViewTextBoxColumn5.HeaderText = "Vendégszám";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ArrivalDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Érkezés";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DepartureDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Távozás";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
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
            this.tabPageGuestBookings.ResumeLayout(false);
            this.tabPageCompanyBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanyBookings)).EndInit();
            this.tabControlBooking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestBookings)).EndInit();
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
        private System.Windows.Forms.TabPage tabPageGuestBookings;
        private System.Windows.Forms.TabPage tabPageCompanyBookings;
        private System.Windows.Forms.DataGridView dataGridViewCompanyBookings;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGuestCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeparture;
        private System.Windows.Forms.TabControl tabControlBooking;
        private System.Windows.Forms.DataGridView dataGridViewGuestBookings;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}