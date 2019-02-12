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
            this.dataGridViewRoomRents = new System.Windows.Forms.DataGridView();
            this.ColumnGuest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGuestCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlRoomEditor = new System.Windows.Forms.TabControl();
            this.tabPageReservations = new System.Windows.Forms.TabPage();
            this.tabPageRooms = new System.Windows.Forms.TabPage();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNewRent = new System.Windows.Forms.Button();
            this.buttonUpdateRent = new System.Windows.Forms.Button();
            this.buttonDeleteRent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomRents)).BeginInit();
            this.tabControlRoomEditor.SuspendLayout();
            this.tabPageReservations.SuspendLayout();
            this.tabPageRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRoomRents
            // 
            this.dataGridViewRoomRents.AllowUserToAddRows = false;
            this.dataGridViewRoomRents.AllowUserToDeleteRows = false;
            this.dataGridViewRoomRents.AllowUserToResizeColumns = false;
            this.dataGridViewRoomRents.AllowUserToResizeRows = false;
            this.dataGridViewRoomRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoomRents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGuest,
            this.ColumnRoomNumber,
            this.ColumnGuestCapacity,
            this.ColumnArrival,
            this.ColumnDeparture});
            this.dataGridViewRoomRents.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewRoomRents.MultiSelect = false;
            this.dataGridViewRoomRents.Name = "dataGridViewRoomRents";
            this.dataGridViewRoomRents.ReadOnly = true;
            this.dataGridViewRoomRents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoomRents.Size = new System.Drawing.Size(843, 557);
            this.dataGridViewRoomRents.TabIndex = 7;
            // 
            // ColumnGuest
            // 
            this.ColumnGuest.DataPropertyName = "GuestName";
            this.ColumnGuest.HeaderText = "Vendég neve";
            this.ColumnGuest.Name = "ColumnGuest";
            this.ColumnGuest.ReadOnly = true;
            this.ColumnGuest.Width = 200;
            // 
            // ColumnRoomNumber
            // 
            this.ColumnRoomNumber.DataPropertyName = "RoomNumber";
            this.ColumnRoomNumber.HeaderText = "Szobaszám";
            this.ColumnRoomNumber.Name = "ColumnRoomNumber";
            this.ColumnRoomNumber.ReadOnly = true;
            this.ColumnRoomNumber.Width = 200;
            // 
            // ColumnGuestCapacity
            // 
            this.ColumnGuestCapacity.DataPropertyName = "NumberOfGuests";
            this.ColumnGuestCapacity.HeaderText = "Vendégszám";
            this.ColumnGuestCapacity.Name = "ColumnGuestCapacity";
            this.ColumnGuestCapacity.ReadOnly = true;
            this.ColumnGuestCapacity.Width = 200;
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
            // tabControlRoomEditor
            // 
            this.tabControlRoomEditor.Controls.Add(this.tabPageReservations);
            this.tabControlRoomEditor.Controls.Add(this.tabPageRooms);
            this.tabControlRoomEditor.Location = new System.Drawing.Point(12, 12);
            this.tabControlRoomEditor.Name = "tabControlRoomEditor";
            this.tabControlRoomEditor.SelectedIndex = 0;
            this.tabControlRoomEditor.Size = new System.Drawing.Size(863, 595);
            this.tabControlRoomEditor.TabIndex = 8;
            // 
            // tabPageReservations
            // 
            this.tabPageReservations.Controls.Add(this.dataGridViewRoomRents);
            this.tabPageReservations.Location = new System.Drawing.Point(4, 22);
            this.tabPageReservations.Name = "tabPageReservations";
            this.tabPageReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReservations.Size = new System.Drawing.Size(855, 569);
            this.tabPageReservations.TabIndex = 0;
            this.tabPageReservations.Text = "Szobakiadások";
            this.tabPageReservations.UseVisualStyleBackColor = true;
            // 
            // tabPageRooms
            // 
            this.tabPageRooms.Controls.Add(this.dataGridViewRooms);
            this.tabPageRooms.Location = new System.Drawing.Point(4, 22);
            this.tabPageRooms.Name = "tabPageRooms";
            this.tabPageRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRooms.Size = new System.Drawing.Size(855, 569);
            this.tabPageRooms.TabIndex = 1;
            this.tabPageRooms.Text = "Szobák";
            this.tabPageRooms.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.AllowUserToResizeColumns = false;
            this.dataGridViewRooms.AllowUserToResizeRows = false;
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
            this.dataGridViewRooms.Size = new System.Drawing.Size(843, 557);
            this.dataGridViewRooms.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Szoba neve";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 200;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.DataPropertyName = "Number";
            this.ColumnNumber.HeaderText = "Szobaszám";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Width = 200;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.DataPropertyName = "CategoryName";
            this.ColumnCategory.HeaderText = "Szobakategória";
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            this.ColumnCategory.Width = 200;
            // 
            // ColumnCapacity
            // 
            this.ColumnCapacity.DataPropertyName = "Capacity";
            this.ColumnCapacity.HeaderText = "Kapacitás";
            this.ColumnCapacity.Name = "ColumnCapacity";
            this.ColumnCapacity.ReadOnly = true;
            this.ColumnCapacity.Width = 200;
            // 
            // buttonNewRent
            // 
            this.buttonNewRent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewRent.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewRent.Image")));
            this.buttonNewRent.Location = new System.Drawing.Point(877, 34);
            this.buttonNewRent.Name = "buttonNewRent";
            this.buttonNewRent.Size = new System.Drawing.Size(159, 64);
            this.buttonNewRent.TabIndex = 9;
            this.buttonNewRent.Text = "Foglalás rögzítése";
            this.buttonNewRent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNewRent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonNewRent.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateRent
            // 
            this.buttonUpdateRent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateRent.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateRent.Image")));
            this.buttonUpdateRent.Location = new System.Drawing.Point(877, 104);
            this.buttonUpdateRent.Name = "buttonUpdateRent";
            this.buttonUpdateRent.Size = new System.Drawing.Size(159, 64);
            this.buttonUpdateRent.TabIndex = 10;
            this.buttonUpdateRent.Text = "Foglalás módosítása";
            this.buttonUpdateRent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdateRent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUpdateRent.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteRent
            // 
            this.buttonDeleteRent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteRent.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteRent.Image")));
            this.buttonDeleteRent.Location = new System.Drawing.Point(877, 174);
            this.buttonDeleteRent.Name = "buttonDeleteRent";
            this.buttonDeleteRent.Size = new System.Drawing.Size(159, 64);
            this.buttonDeleteRent.TabIndex = 11;
            this.buttonDeleteRent.Text = "Foglalás törlése";
            this.buttonDeleteRent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDeleteRent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteRent.UseVisualStyleBackColor = true;
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 613);
            this.Controls.Add(this.buttonDeleteRent);
            this.Controls.Add(this.buttonUpdateRent);
            this.Controls.Add(this.buttonNewRent);
            this.Controls.Add(this.tabControlRoomEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foglalási napló";
            this.Load += new System.EventHandler(this.FormRoomEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomRents)).EndInit();
            this.tabControlRoomEditor.ResumeLayout(false);
            this.tabPageReservations.ResumeLayout(false);
            this.tabPageRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewRoomRents;
        private System.Windows.Forms.TabControl tabControlRoomEditor;
        private System.Windows.Forms.TabPage tabPageReservations;
        private System.Windows.Forms.TabPage tabPageRooms;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGuestCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeparture;
        private System.Windows.Forms.Button buttonNewRent;
        private System.Windows.Forms.Button buttonUpdateRent;
        private System.Windows.Forms.Button buttonDeleteRent;
    }
}