namespace virtual_receptionist.View
{
    partial class FormGuestRegistrationCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuestRegistrationCard));
            this.checkBoxCorporateGuest = new System.Windows.Forms.CheckBox();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelVatNumber = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxVatNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCitizenship = new System.Windows.Forms.TextBox();
            this.groupBoxGuestData = new System.Windows.Forms.GroupBox();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelNumberOfGuests = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfGuests = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.labelIDCardOrPassportNumber = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxIDCardOrPassportNumber = new System.Windows.Forms.TextBox();
            this.groupBoxBillingData = new System.Windows.Forms.GroupBox();
            this.textBoxBillingName = new System.Windows.Forms.TextBox();
            this.labelBillingName = new System.Windows.Forms.Label();
            this.groupBoxOtherData = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.errorProviderInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxGuestData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGuests)).BeginInit();
            this.groupBoxBillingData.SuspendLayout();
            this.groupBoxOtherData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInput)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxCorporateGuest
            // 
            this.checkBoxCorporateGuest.AutoSize = true;
            this.checkBoxCorporateGuest.Location = new System.Drawing.Point(192, 177);
            this.checkBoxCorporateGuest.Name = "checkBoxCorporateGuest";
            this.checkBoxCorporateGuest.Size = new System.Drawing.Size(141, 17);
            this.checkBoxCorporateGuest.TabIndex = 21;
            this.checkBoxCorporateGuest.Text = "A vendég vállalati ügyfél";
            this.checkBoxCorporateGuest.UseVisualStyleBackColor = true;
            this.checkBoxCorporateGuest.CheckedChanged += new System.EventHandler(this.checkBoxCorporateGuest_CheckedChanged);
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(148, 48);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(38, 13);
            this.labelEmailAddress.TabIndex = 25;
            this.labelEmailAddress.Text = "E-mail:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(116, 22);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(70, 13);
            this.labelPhoneNumber.TabIndex = 23;
            this.labelPhoneNumber.Text = "Telefonszám:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(157, 128);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(29, 13);
            this.labelAddress.TabIndex = 17;
            this.labelAddress.Text = "Cím:";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(116, 75);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(70, 13);
            this.labelZipCode.TabIndex = 13;
            this.labelZipCode.Text = "Irányítószám:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(143, 48);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 11;
            this.labelCountry.Text = "Ország:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(130, 103);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(56, 13);
            this.labelCity.TabIndex = 15;
            this.labelCity.Text = "Település:";
            // 
            // labelVatNumber
            // 
            this.labelVatNumber.AutoSize = true;
            this.labelVatNumber.Location = new System.Drawing.Point(133, 154);
            this.labelVatNumber.Name = "labelVatNumber";
            this.labelVatNumber.Size = new System.Drawing.Size(53, 13);
            this.labelVatNumber.TabIndex = 19;
            this.labelVatNumber.Text = "Adószám:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(112, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Vendég neve:";
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(192, 45);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(276, 20);
            this.textBoxEmailAddress.TabIndex = 26;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(192, 45);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(276, 21);
            this.comboBoxCountry.TabIndex = 12;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(192, 19);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxPhoneNumber.TabIndex = 24;
            // 
            // textBoxVatNumber
            // 
            this.textBoxVatNumber.Location = new System.Drawing.Point(192, 151);
            this.textBoxVatNumber.Name = "textBoxVatNumber";
            this.textBoxVatNumber.ReadOnly = true;
            this.textBoxVatNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxVatNumber.TabIndex = 20;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(192, 125);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(276, 20);
            this.textBoxAddress.TabIndex = 18;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(192, 98);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(276, 20);
            this.textBoxCity.TabIndex = 16;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(192, 72);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(276, 20);
            this.textBoxZipCode.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(192, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(276, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Állampolgárság:";
            // 
            // textBoxCitizenship
            // 
            this.textBoxCitizenship.Location = new System.Drawing.Point(192, 53);
            this.textBoxCitizenship.Name = "textBoxCitizenship";
            this.textBoxCitizenship.Size = new System.Drawing.Size(276, 20);
            this.textBoxCitizenship.TabIndex = 5;
            // 
            // groupBoxGuestData
            // 
            this.groupBoxGuestData.Controls.Add(this.comboBoxRoom);
            this.groupBoxGuestData.Controls.Add(this.labelRoom);
            this.groupBoxGuestData.Controls.Add(this.labelNumberOfGuests);
            this.groupBoxGuestData.Controls.Add(this.numericUpDownNumberOfGuests);
            this.groupBoxGuestData.Controls.Add(this.dateTimePickerDepartureDate);
            this.groupBoxGuestData.Controls.Add(this.dateTimePickerArrivalDate);
            this.groupBoxGuestData.Controls.Add(this.labelDepartureDate);
            this.groupBoxGuestData.Controls.Add(this.labelArrivalDate);
            this.groupBoxGuestData.Controls.Add(this.labelIDCardOrPassportNumber);
            this.groupBoxGuestData.Controls.Add(this.labelBirthDate);
            this.groupBoxGuestData.Controls.Add(this.textBoxBirthDate);
            this.groupBoxGuestData.Controls.Add(this.label1);
            this.groupBoxGuestData.Controls.Add(this.textBoxIDCardOrPassportNumber);
            this.groupBoxGuestData.Controls.Add(this.labelName);
            this.groupBoxGuestData.Controls.Add(this.textBoxName);
            this.groupBoxGuestData.Controls.Add(this.textBoxCitizenship);
            this.groupBoxGuestData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGuestData.Name = "groupBoxGuestData";
            this.groupBoxGuestData.Size = new System.Drawing.Size(490, 236);
            this.groupBoxGuestData.TabIndex = 1;
            this.groupBoxGuestData.TabStop = false;
            this.groupBoxGuestData.Text = "Vendég adatok";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(192, 209);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(276, 21);
            this.comboBoxRoom.TabIndex = 38;
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(146, 212);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(40, 13);
            this.labelRoom.TabIndex = 37;
            this.labelRoom.Text = "Szoba:";
            // 
            // labelNumberOfGuests
            // 
            this.labelNumberOfGuests.AutoSize = true;
            this.labelNumberOfGuests.Location = new System.Drawing.Point(94, 133);
            this.labelNumberOfGuests.Name = "labelNumberOfGuests";
            this.labelNumberOfGuests.Size = new System.Drawing.Size(92, 13);
            this.labelNumberOfGuests.TabIndex = 36;
            this.labelNumberOfGuests.Text = "Vendégek száma:";
            // 
            // numericUpDownNumberOfGuests
            // 
            this.numericUpDownNumberOfGuests.Location = new System.Drawing.Point(192, 131);
            this.numericUpDownNumberOfGuests.Name = "numericUpDownNumberOfGuests";
            this.numericUpDownNumberOfGuests.Size = new System.Drawing.Size(276, 20);
            this.numericUpDownNumberOfGuests.TabIndex = 30;
            this.numericUpDownNumberOfGuests.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(192, 183);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(276, 20);
            this.dateTimePickerDepartureDate.TabIndex = 35;
            // 
            // dateTimePickerArrivalDate
            // 
            this.dateTimePickerArrivalDate.Location = new System.Drawing.Point(192, 157);
            this.dateTimePickerArrivalDate.Name = "dateTimePickerArrivalDate";
            this.dateTimePickerArrivalDate.Size = new System.Drawing.Size(276, 20);
            this.dateTimePickerArrivalDate.TabIndex = 34;
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.AutoSize = true;
            this.labelDepartureDate.Location = new System.Drawing.Point(135, 189);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(51, 13);
            this.labelDepartureDate.TabIndex = 33;
            this.labelDepartureDate.Text = "Távozás:";
            // 
            // labelArrivalDate
            // 
            this.labelArrivalDate.AutoSize = true;
            this.labelArrivalDate.Location = new System.Drawing.Point(138, 163);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(48, 13);
            this.labelArrivalDate.TabIndex = 32;
            this.labelArrivalDate.Text = "Érkezés:";
            // 
            // labelIDCardOrPassportNumber
            // 
            this.labelIDCardOrPassportNumber.AutoSize = true;
            this.labelIDCardOrPassportNumber.Location = new System.Drawing.Point(90, 108);
            this.labelIDCardOrPassportNumber.Name = "labelIDCardOrPassportNumber";
            this.labelIDCardOrPassportNumber.Size = new System.Drawing.Size(96, 13);
            this.labelIDCardOrPassportNumber.TabIndex = 8;
            this.labelIDCardOrPassportNumber.Text = "Okmányazonosító:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(117, 82);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(69, 13);
            this.labelBirthDate.TabIndex = 6;
            this.labelBirthDate.Text = "Születési idő:";
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Location = new System.Drawing.Point(192, 79);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.Size = new System.Drawing.Size(276, 20);
            this.textBoxBirthDate.TabIndex = 7;
            // 
            // textBoxIDCardOrPassportNumber
            // 
            this.textBoxIDCardOrPassportNumber.Location = new System.Drawing.Point(192, 105);
            this.textBoxIDCardOrPassportNumber.Name = "textBoxIDCardOrPassportNumber";
            this.textBoxIDCardOrPassportNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxIDCardOrPassportNumber.TabIndex = 9;
            // 
            // groupBoxBillingData
            // 
            this.groupBoxBillingData.Controls.Add(this.textBoxBillingName);
            this.groupBoxBillingData.Controls.Add(this.labelBillingName);
            this.groupBoxBillingData.Controls.Add(this.textBoxVatNumber);
            this.groupBoxBillingData.Controls.Add(this.labelVatNumber);
            this.groupBoxBillingData.Controls.Add(this.checkBoxCorporateGuest);
            this.groupBoxBillingData.Controls.Add(this.textBoxZipCode);
            this.groupBoxBillingData.Controls.Add(this.textBoxCity);
            this.groupBoxBillingData.Controls.Add(this.textBoxAddress);
            this.groupBoxBillingData.Controls.Add(this.labelCountry);
            this.groupBoxBillingData.Controls.Add(this.labelAddress);
            this.groupBoxBillingData.Controls.Add(this.comboBoxCountry);
            this.groupBoxBillingData.Controls.Add(this.labelCity);
            this.groupBoxBillingData.Controls.Add(this.labelZipCode);
            this.groupBoxBillingData.Location = new System.Drawing.Point(12, 338);
            this.groupBoxBillingData.Name = "groupBoxBillingData";
            this.groupBoxBillingData.Size = new System.Drawing.Size(490, 236);
            this.groupBoxBillingData.TabIndex = 10;
            this.groupBoxBillingData.TabStop = false;
            this.groupBoxBillingData.Text = "Számlázási adatok";
            // 
            // textBoxBillingName
            // 
            this.textBoxBillingName.Location = new System.Drawing.Point(192, 19);
            this.textBoxBillingName.Name = "textBoxBillingName";
            this.textBoxBillingName.Size = new System.Drawing.Size(276, 20);
            this.textBoxBillingName.TabIndex = 23;
            // 
            // labelBillingName
            // 
            this.labelBillingName.AutoSize = true;
            this.labelBillingName.Location = new System.Drawing.Point(103, 22);
            this.labelBillingName.Name = "labelBillingName";
            this.labelBillingName.Size = new System.Drawing.Size(83, 13);
            this.labelBillingName.TabIndex = 22;
            this.labelBillingName.Text = "Számlázási név:";
            // 
            // groupBoxOtherData
            // 
            this.groupBoxOtherData.Controls.Add(this.textBoxEmailAddress);
            this.groupBoxOtherData.Controls.Add(this.labelPhoneNumber);
            this.groupBoxOtherData.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxOtherData.Controls.Add(this.labelEmailAddress);
            this.groupBoxOtherData.Location = new System.Drawing.Point(12, 254);
            this.groupBoxOtherData.Name = "groupBoxOtherData";
            this.groupBoxOtherData.Size = new System.Drawing.Size(490, 78);
            this.groupBoxOtherData.TabIndex = 22;
            this.groupBoxOtherData.TabStop = false;
            this.groupBoxOtherData.Text = "Egyéb adatok";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonOK.Image")));
            this.buttonOK.Location = new System.Drawing.Point(12, 580);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(490, 78);
            this.buttonOK.TabIndex = 28;
            this.buttonOK.Text = "Felvitel";
            this.buttonOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // errorProviderInput
            // 
            this.errorProviderInput.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderInput.ContainerControl = this;
            // 
            // FormGuestRegistrationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 670);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxOtherData);
            this.Controls.Add(this.groupBoxBillingData);
            this.Controls.Add(this.groupBoxGuestData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGuestRegistrationCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendég bejelentkező lap kitöltése | Virtual Receptionist";
            this.Load += new System.EventHandler(this.FormGuestRegistrationCard_Load);
            this.groupBoxGuestData.ResumeLayout(false);
            this.groupBoxGuestData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGuests)).EndInit();
            this.groupBoxBillingData.ResumeLayout(false);
            this.groupBoxBillingData.PerformLayout();
            this.groupBoxOtherData.ResumeLayout(false);
            this.groupBoxOtherData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxCorporateGuest;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelVatNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxVatNumber;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCitizenship;
        private System.Windows.Forms.GroupBox groupBoxGuestData;
        private System.Windows.Forms.GroupBox groupBoxBillingData;
        private System.Windows.Forms.GroupBox groupBoxOtherData;
        private System.Windows.Forms.TextBox textBoxIDCardOrPassportNumber;
        private System.Windows.Forms.Label labelIDCardOrPassportNumber;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxBillingName;
        private System.Windows.Forms.Label labelBillingName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrivalDate;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.Label labelArrivalDate;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfGuests;
        private System.Windows.Forms.Label labelNumberOfGuests;
        private System.Windows.Forms.ErrorProvider errorProviderInput;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label labelRoom;
    }
}