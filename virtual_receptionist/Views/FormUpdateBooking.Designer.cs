namespace virtual_receptionist.Views
{
    partial class FormUpdateBooking
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateBooking));
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxBookingData = new System.Windows.Forms.GroupBox();
            this.comboBoxGuest = new System.Windows.Forms.ComboBox();
            this.textBoxBookingID = new System.Windows.Forms.TextBox();
            this.labelBookingID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfGuests = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfGuests = new System.Windows.Forms.Label();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDepartureDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumberOfGuests = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxBookingData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepartureDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberOfGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 273);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(397, 273);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxBookingData
            // 
            this.groupBoxBookingData.Controls.Add(this.comboBoxGuest);
            this.groupBoxBookingData.Controls.Add(this.textBoxBookingID);
            this.groupBoxBookingData.Controls.Add(this.labelBookingID);
            this.groupBoxBookingData.Controls.Add(this.labelName);
            this.groupBoxBookingData.Controls.Add(this.numericUpDownNumberOfGuests);
            this.groupBoxBookingData.Controls.Add(this.labelNumberOfGuests);
            this.groupBoxBookingData.Controls.Add(this.comboBoxRoom);
            this.groupBoxBookingData.Controls.Add(this.labelRoom);
            this.groupBoxBookingData.Controls.Add(this.labelDepartureDate);
            this.groupBoxBookingData.Controls.Add(this.labelArrivalDate);
            this.groupBoxBookingData.Controls.Add(this.dateTimePickerDepartureDate);
            this.groupBoxBookingData.Controls.Add(this.dateTimePickerArrivalDate);
            this.groupBoxBookingData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBookingData.Name = "groupBoxBookingData";
            this.groupBoxBookingData.Size = new System.Drawing.Size(460, 255);
            this.groupBoxBookingData.TabIndex = 17;
            this.groupBoxBookingData.TabStop = false;
            this.groupBoxBookingData.Text = "Foglalás adatok";
            // 
            // comboBoxGuest
            // 
            this.comboBoxGuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGuest.FormattingEnabled = true;
            this.comboBoxGuest.Location = new System.Drawing.Point(154, 80);
            this.comboBoxGuest.Name = "comboBoxGuest";
            this.comboBoxGuest.Size = new System.Drawing.Size(237, 21);
            this.comboBoxGuest.TabIndex = 16;
            // 
            // textBoxBookingID
            // 
            this.textBoxBookingID.Location = new System.Drawing.Point(154, 54);
            this.textBoxBookingID.Name = "textBoxBookingID";
            this.textBoxBookingID.ReadOnly = true;
            this.textBoxBookingID.Size = new System.Drawing.Size(237, 20);
            this.textBoxBookingID.TabIndex = 15;
            // 
            // labelBookingID
            // 
            this.labelBookingID.AutoSize = true;
            this.labelBookingID.Location = new System.Drawing.Point(49, 57);
            this.labelBookingID.Name = "labelBookingID";
            this.labelBookingID.Size = new System.Drawing.Size(99, 13);
            this.labelBookingID.TabIndex = 14;
            this.labelBookingID.Text = "Foglalás azonosító:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(74, 83);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Vendég neve:";
            // 
            // numericUpDownNumberOfGuests
            // 
            this.numericUpDownNumberOfGuests.Location = new System.Drawing.Point(154, 185);
            this.numericUpDownNumberOfGuests.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfGuests.Name = "numericUpDownNumberOfGuests";
            this.numericUpDownNumberOfGuests.Size = new System.Drawing.Size(237, 20);
            this.numericUpDownNumberOfGuests.TabIndex = 13;
            this.numericUpDownNumberOfGuests.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfGuests.ValueChanged += new System.EventHandler(this.numericUpDownNumberOfGuests_ValueChanged);
            // 
            // labelNumberOfGuests
            // 
            this.labelNumberOfGuests.AutoSize = true;
            this.labelNumberOfGuests.Location = new System.Drawing.Point(56, 187);
            this.labelNumberOfGuests.Name = "labelNumberOfGuests";
            this.labelNumberOfGuests.Size = new System.Drawing.Size(92, 13);
            this.labelNumberOfGuests.TabIndex = 0;
            this.labelNumberOfGuests.Text = "Vendégek száma:";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(154, 158);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(237, 21);
            this.comboBoxRoom.TabIndex = 12;
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(108, 161);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(40, 13);
            this.labelRoom.TabIndex = 0;
            this.labelRoom.Text = "Szoba:";
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.AutoSize = true;
            this.labelDepartureDate.Location = new System.Drawing.Point(59, 138);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(89, 13);
            this.labelDepartureDate.TabIndex = 0;
            this.labelDepartureDate.Text = "Távozás dátuma:";
            // 
            // labelArrivalDate
            // 
            this.labelArrivalDate.AutoSize = true;
            this.labelArrivalDate.Location = new System.Drawing.Point(62, 112);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(86, 13);
            this.labelArrivalDate.TabIndex = 0;
            this.labelArrivalDate.Text = "Érkezés dátuma:";
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(154, 132);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(237, 20);
            this.dateTimePickerDepartureDate.TabIndex = 11;
            this.dateTimePickerDepartureDate.ValueChanged += new System.EventHandler(this.dateTimePickerDepartureDate_ValueChanged);
            // 
            // dateTimePickerArrivalDate
            // 
            this.dateTimePickerArrivalDate.Location = new System.Drawing.Point(154, 106);
            this.dateTimePickerArrivalDate.Name = "dateTimePickerArrivalDate";
            this.dateTimePickerArrivalDate.Size = new System.Drawing.Size(237, 20);
            this.dateTimePickerArrivalDate.TabIndex = 10;
            // 
            // errorProviderName
            // 
            this.errorProviderName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderDepartureDate
            // 
            this.errorProviderDepartureDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderDepartureDate.ContainerControl = this;
            // 
            // errorProviderNumberOfGuests
            // 
            this.errorProviderNumberOfGuests.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNumberOfGuests.ContainerControl = this;
            // 
            // FormUpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 306);
            this.Controls.Add(this.groupBoxBookingData);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUpdateBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foglalás módosítása | Virtual Receptionist";
            this.groupBoxBookingData.ResumeLayout(false);
            this.groupBoxBookingData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepartureDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberOfGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxBookingData;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfGuests;
        private System.Windows.Forms.Label labelNumberOfGuests;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.Label labelArrivalDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrivalDate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxBookingID;
        private System.Windows.Forms.Label labelBookingID;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderDepartureDate;
        private System.Windows.Forms.ErrorProvider errorProviderNumberOfGuests;
        private System.Windows.Forms.ComboBox comboBoxGuest;
    }
}