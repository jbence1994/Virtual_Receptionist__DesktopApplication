namespace virtual_receptionist.Views
{
    partial class FormBookingManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookingManager));
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxGuestName = new System.Windows.Forms.TextBox();
            this.textBoxDocumentNumber = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCitizenship = new System.Windows.Forms.TextBox();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.groupBoxGuestData = new System.Windows.Forms.GroupBox();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelCitizenship = new System.Windows.Forms.Label();
            this.labelDocumentNumber = new System.Windows.Forms.Label();
            this.groupBoxBookingData = new System.Windows.Forms.GroupBox();
            this.numericUpDownNumberOfGuests = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfGuests = new System.Windows.Forms.Label();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDocumentNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCitizenship = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBirthDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmailAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumberOfGuests = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDepartureDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderZipCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxGuestData.SuspendLayout();
            this.groupBoxBookingData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDocumentNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCitizenship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBirthDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmailAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberOfGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepartureDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZipCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 475);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(397, 475);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxGuestName
            // 
            this.textBoxGuestName.Location = new System.Drawing.Point(171, 19);
            this.textBoxGuestName.Name = "textBoxGuestName";
            this.textBoxGuestName.Size = new System.Drawing.Size(237, 20);
            this.textBoxGuestName.TabIndex = 0;
            this.textBoxGuestName.TextChanged += new System.EventHandler(this.textBoxGuestName_TextChanged);
            // 
            // textBoxDocumentNumber
            // 
            this.textBoxDocumentNumber.Location = new System.Drawing.Point(171, 46);
            this.textBoxDocumentNumber.Name = "textBoxDocumentNumber";
            this.textBoxDocumentNumber.Size = new System.Drawing.Size(237, 20);
            this.textBoxDocumentNumber.TabIndex = 1;
            this.textBoxDocumentNumber.TextChanged += new System.EventHandler(this.textBoxDocumentNumber_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(91, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Vendég neve:";
            // 
            // textBoxCitizenship
            // 
            this.textBoxCitizenship.Location = new System.Drawing.Point(171, 72);
            this.textBoxCitizenship.Name = "textBoxCitizenship";
            this.textBoxCitizenship.Size = new System.Drawing.Size(237, 20);
            this.textBoxCitizenship.TabIndex = 2;
            this.textBoxCitizenship.TextChanged += new System.EventHandler(this.textBoxCitizenship_TextChanged);
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Location = new System.Drawing.Point(171, 98);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.Size = new System.Drawing.Size(237, 20);
            this.textBoxBirthDate.TabIndex = 3;
            this.textBoxBirthDate.TextChanged += new System.EventHandler(this.textBoxBirthDate_TextChanged);
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(171, 151);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(237, 20);
            this.textBoxZipCode.TabIndex = 5;
            this.textBoxZipCode.TextChanged += new System.EventHandler(this.textBoxZipCode_TextChanged);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(171, 124);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(237, 21);
            this.comboBoxCountry.TabIndex = 4;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(122, 127);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 0;
            this.labelCountry.Text = "Ország:";
            // 
            // groupBoxGuestData
            // 
            this.groupBoxGuestData.Controls.Add(this.labelEmailAddress);
            this.groupBoxGuestData.Controls.Add(this.textBoxEmailAddress);
            this.groupBoxGuestData.Controls.Add(this.labelPhoneNumber);
            this.groupBoxGuestData.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxGuestData.Controls.Add(this.labelAddress);
            this.groupBoxGuestData.Controls.Add(this.textBoxAddress);
            this.groupBoxGuestData.Controls.Add(this.labelCity);
            this.groupBoxGuestData.Controls.Add(this.textBoxCity);
            this.groupBoxGuestData.Controls.Add(this.labelZipCode);
            this.groupBoxGuestData.Controls.Add(this.labelBirthDate);
            this.groupBoxGuestData.Controls.Add(this.labelCitizenship);
            this.groupBoxGuestData.Controls.Add(this.labelDocumentNumber);
            this.groupBoxGuestData.Controls.Add(this.comboBoxCountry);
            this.groupBoxGuestData.Controls.Add(this.labelCountry);
            this.groupBoxGuestData.Controls.Add(this.textBoxGuestName);
            this.groupBoxGuestData.Controls.Add(this.textBoxDocumentNumber);
            this.groupBoxGuestData.Controls.Add(this.textBoxZipCode);
            this.groupBoxGuestData.Controls.Add(this.labelName);
            this.groupBoxGuestData.Controls.Add(this.textBoxBirthDate);
            this.groupBoxGuestData.Controls.Add(this.textBoxCitizenship);
            this.groupBoxGuestData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGuestData.Name = "groupBoxGuestData";
            this.groupBoxGuestData.Size = new System.Drawing.Size(460, 293);
            this.groupBoxGuestData.TabIndex = 0;
            this.groupBoxGuestData.TabStop = false;
            this.groupBoxGuestData.Text = "Vendég adatok";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(106, 258);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(59, 13);
            this.labelEmailAddress.TabIndex = 0;
            this.labelEmailAddress.Text = "E-mail cím:";
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(171, 255);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(237, 20);
            this.textBoxEmailAddress.TabIndex = 9;
            this.textBoxEmailAddress.TextChanged += new System.EventHandler(this.textBoxEmailAddress_TextChanged);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(95, 232);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(70, 13);
            this.labelPhoneNumber.TabIndex = 0;
            this.labelPhoneNumber.Text = "Telefonszám:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(171, 229);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(237, 20);
            this.textBoxPhoneNumber.TabIndex = 8;
            this.textBoxPhoneNumber.TextChanged += new System.EventHandler(this.textBoxPhoneNumber_TextChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(119, 206);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(46, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Lakcím:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(171, 203);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(237, 20);
            this.textBoxAddress.TabIndex = 7;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(109, 180);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(56, 13);
            this.labelCity.TabIndex = 0;
            this.labelCity.Text = "Település:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(171, 177);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(237, 20);
            this.textBoxCity.TabIndex = 6;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(95, 154);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(70, 13);
            this.labelZipCode.TabIndex = 0;
            this.labelZipCode.Text = "Irányítószám:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(81, 101);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(84, 13);
            this.labelBirthDate.TabIndex = 0;
            this.labelBirthDate.Text = "Születési dátum:";
            // 
            // labelCitizenship
            // 
            this.labelCitizenship.AutoSize = true;
            this.labelCitizenship.Location = new System.Drawing.Point(84, 75);
            this.labelCitizenship.Name = "labelCitizenship";
            this.labelCitizenship.Size = new System.Drawing.Size(81, 13);
            this.labelCitizenship.TabIndex = 0;
            this.labelCitizenship.Text = "Állampolgárság:";
            // 
            // labelDocumentNumber
            // 
            this.labelDocumentNumber.AutoSize = true;
            this.labelDocumentNumber.Location = new System.Drawing.Point(69, 49);
            this.labelDocumentNumber.Name = "labelDocumentNumber";
            this.labelDocumentNumber.Size = new System.Drawing.Size(96, 13);
            this.labelDocumentNumber.TabIndex = 0;
            this.labelDocumentNumber.Text = "Okmányazonosító:";
            // 
            // groupBoxBookingData
            // 
            this.groupBoxBookingData.Controls.Add(this.numericUpDownNumberOfGuests);
            this.groupBoxBookingData.Controls.Add(this.labelNumberOfGuests);
            this.groupBoxBookingData.Controls.Add(this.comboBoxRoom);
            this.groupBoxBookingData.Controls.Add(this.labelRoom);
            this.groupBoxBookingData.Controls.Add(this.labelDepartureDate);
            this.groupBoxBookingData.Controls.Add(this.labelArrivalDate);
            this.groupBoxBookingData.Controls.Add(this.dateTimePickerDepartureDate);
            this.groupBoxBookingData.Controls.Add(this.dateTimePickerArrivalDate);
            this.groupBoxBookingData.Location = new System.Drawing.Point(13, 311);
            this.groupBoxBookingData.Name = "groupBoxBookingData";
            this.groupBoxBookingData.Size = new System.Drawing.Size(459, 158);
            this.groupBoxBookingData.TabIndex = 0;
            this.groupBoxBookingData.TabStop = false;
            this.groupBoxBookingData.Text = "Foglalás adatok";
            // 
            // numericUpDownNumberOfGuests
            // 
            this.numericUpDownNumberOfGuests.Location = new System.Drawing.Point(170, 116);
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
            this.labelNumberOfGuests.Location = new System.Drawing.Point(72, 118);
            this.labelNumberOfGuests.Name = "labelNumberOfGuests";
            this.labelNumberOfGuests.Size = new System.Drawing.Size(92, 13);
            this.labelNumberOfGuests.TabIndex = 0;
            this.labelNumberOfGuests.Text = "Vendégek száma:";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(170, 89);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(237, 21);
            this.comboBoxRoom.TabIndex = 12;
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(124, 92);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(40, 13);
            this.labelRoom.TabIndex = 0;
            this.labelRoom.Text = "Szoba:";
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.AutoSize = true;
            this.labelDepartureDate.Location = new System.Drawing.Point(75, 69);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(89, 13);
            this.labelDepartureDate.TabIndex = 0;
            this.labelDepartureDate.Text = "Távozás dátuma:";
            // 
            // labelArrivalDate
            // 
            this.labelArrivalDate.AutoSize = true;
            this.labelArrivalDate.Location = new System.Drawing.Point(78, 43);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(86, 13);
            this.labelArrivalDate.TabIndex = 0;
            this.labelArrivalDate.Text = "Érkezés dátuma:";
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(170, 63);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(237, 20);
            this.dateTimePickerDepartureDate.TabIndex = 11;
            this.dateTimePickerDepartureDate.ValueChanged += new System.EventHandler(this.dateTimePickerDepartureDate_ValueChanged);
            // 
            // dateTimePickerArrivalDate
            // 
            this.dateTimePickerArrivalDate.Location = new System.Drawing.Point(170, 37);
            this.dateTimePickerArrivalDate.Name = "dateTimePickerArrivalDate";
            this.dateTimePickerArrivalDate.Size = new System.Drawing.Size(237, 20);
            this.dateTimePickerArrivalDate.TabIndex = 10;
            // 
            // errorProviderName
            // 
            this.errorProviderName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderDocumentNumber
            // 
            this.errorProviderDocumentNumber.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderDocumentNumber.ContainerControl = this;
            // 
            // errorProviderCitizenship
            // 
            this.errorProviderCitizenship.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCitizenship.ContainerControl = this;
            // 
            // errorProviderBirthDate
            // 
            this.errorProviderBirthDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderBirthDate.ContainerControl = this;
            // 
            // errorProviderCity
            // 
            this.errorProviderCity.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCity.ContainerControl = this;
            // 
            // errorProviderPhoneNumber
            // 
            this.errorProviderPhoneNumber.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPhoneNumber.ContainerControl = this;
            // 
            // errorProviderEmailAddress
            // 
            this.errorProviderEmailAddress.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderEmailAddress.ContainerControl = this;
            // 
            // errorProviderNumberOfGuests
            // 
            this.errorProviderNumberOfGuests.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNumberOfGuests.ContainerControl = this;
            // 
            // errorProviderDepartureDate
            // 
            this.errorProviderDepartureDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderDepartureDate.ContainerControl = this;
            // 
            // errorProviderZipCode
            // 
            this.errorProviderZipCode.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderZipCode.ContainerControl = this;
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderAddress.ContainerControl = this;
            // 
            // FormBookingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 510);
            this.Controls.Add(this.groupBoxBookingData);
            this.Controls.Add(this.groupBoxGuestData);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBookingManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foglalás kezelése | Virtual Receptionist";
            this.Load += new System.EventHandler(this.FormBookingManager_Load);
            this.groupBoxGuestData.ResumeLayout(false);
            this.groupBoxGuestData.PerformLayout();
            this.groupBoxBookingData.ResumeLayout(false);
            this.groupBoxBookingData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDocumentNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCitizenship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBirthDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmailAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberOfGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepartureDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZipCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxGuestName;
        private System.Windows.Forms.TextBox textBoxDocumentNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxCitizenship;
        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.GroupBox groupBoxGuestData;
        private System.Windows.Forms.GroupBox groupBoxBookingData;
        private System.Windows.Forms.Label labelDocumentNumber;
        private System.Windows.Forms.Label labelCitizenship;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrivalDate;
        private System.Windows.Forms.Label labelArrivalDate;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfGuests;
        private System.Windows.Forms.Label labelNumberOfGuests;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderDocumentNumber;
        private System.Windows.Forms.ErrorProvider errorProviderCitizenship;
        private System.Windows.Forms.ErrorProvider errorProviderBirthDate;
        private System.Windows.Forms.ErrorProvider errorProviderCity;
        private System.Windows.Forms.ErrorProvider errorProviderPhoneNumber;
        private System.Windows.Forms.ErrorProvider errorProviderEmailAddress;
        private System.Windows.Forms.ErrorProvider errorProviderNumberOfGuests;
        private System.Windows.Forms.ErrorProvider errorProviderDepartureDate;
        private System.Windows.Forms.ErrorProvider errorProviderZipCode;
        private System.Windows.Forms.ErrorProvider errorProviderAddress;
    }
}