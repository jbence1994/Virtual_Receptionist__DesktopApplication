namespace virtual_receptionist.View
{
    partial class FormBillingData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBillingData));
            this.listViewPrivateGuests = new System.Windows.Forms.ListView();
            this.columnBookingID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRoomCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumberOfGuests = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArrivalDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDepartureDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewPrivateGuests
            // 
            this.listViewPrivateGuests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBookingID,
            this.columnHeaderName,
            this.columnHeaderRoomNumber,
            this.columnHeaderRoomCategory,
            this.columnHeaderNumberOfGuests,
            this.columnHeaderArrivalDate,
            this.columnHeaderDepartureDate});
            this.listViewPrivateGuests.FullRowSelect = true;
            this.listViewPrivateGuests.GridLines = true;
            this.listViewPrivateGuests.Location = new System.Drawing.Point(12, 12);
            this.listViewPrivateGuests.Name = "listViewPrivateGuests";
            this.listViewPrivateGuests.Size = new System.Drawing.Size(776, 251);
            this.listViewPrivateGuests.TabIndex = 2;
            this.listViewPrivateGuests.UseCompatibleStateImageBehavior = false;
            this.listViewPrivateGuests.View = System.Windows.Forms.View.Details;
            // 
            // columnBookingID
            // 
            this.columnBookingID.Text = "Foglalás azonosító";
            this.columnBookingID.Width = 150;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Név";
            this.columnHeaderName.Width = 150;
            // 
            // columnHeaderRoomNumber
            // 
            this.columnHeaderRoomNumber.Text = "Szobaszám";
            this.columnHeaderRoomNumber.Width = 150;
            // 
            // columnHeaderRoomCategory
            // 
            this.columnHeaderRoomCategory.Text = "Szoba neve";
            this.columnHeaderRoomCategory.Width = 150;
            // 
            // columnHeaderNumberOfGuests
            // 
            this.columnHeaderNumberOfGuests.Text = "Vendégek száma";
            this.columnHeaderNumberOfGuests.Width = 150;
            // 
            // columnHeaderArrivalDate
            // 
            this.columnHeaderArrivalDate.Text = "Érkezés";
            this.columnHeaderArrivalDate.Width = 150;
            // 
            // columnHeaderDepartureDate
            // 
            this.columnHeaderDepartureDate.Text = "Távozás";
            this.columnHeaderDepartureDate.Width = 150;
            // 
            // FormBillingData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 275);
            this.Controls.Add(this.listViewPrivateGuests);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBillingData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Számlázandó ügyfél";
            this.Load += new System.EventHandler(this.FormBillingData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPrivateGuests;
        private System.Windows.Forms.ColumnHeader columnBookingID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderRoomNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderRoomCategory;
        private System.Windows.Forms.ColumnHeader columnHeaderNumberOfGuests;
        private System.Windows.Forms.ColumnHeader columnHeaderArrivalDate;
        private System.Windows.Forms.ColumnHeader columnHeaderDepartureDate;
    }
}