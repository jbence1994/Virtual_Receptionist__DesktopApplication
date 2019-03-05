namespace virtual_receptionist.Views
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
            this.errorProviderInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPageBookingData = new System.Windows.Forms.TabPage();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.groupBoxBookingData = new System.Windows.Forms.GroupBox();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfGuests = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfGuests = new System.Windows.Forms.Label();
            this.dateTimePickerArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.tabPageGuestData = new System.Windows.Forms.TabPage();
            this.buttonImportGuestData = new System.Windows.Forms.Button();
            this.groupBoxGuestData = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCitizenship = new System.Windows.Forms.TextBox();
            this.labelDocumentNumber = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCitizenship = new System.Windows.Forms.Label();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxDocumentNumber = new System.Windows.Forms.TextBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.groupBoxAdditionalInfo = new System.Windows.Forms.GroupBox();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.tabControlGuestRegistrationCard = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInput)).BeginInit();
            this.tabPageBookingData.SuspendLayout();
            this.groupBoxBookingData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGuests)).BeginInit();
            this.tabPageGuestData.SuspendLayout();
            this.groupBoxGuestData.SuspendLayout();
            this.groupBoxAdditionalInfo.SuspendLayout();
            this.tabControlGuestRegistrationCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProviderInput
            // 
            this.errorProviderInput.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderInput.ContainerControl = this;
            // 
            // tabPageBookingData
            // 
            this.tabPageBookingData.Controls.Add(this.buttonSaveData);
            this.tabPageBookingData.Controls.Add(this.groupBoxBookingData);
            this.tabPageBookingData.Location = new System.Drawing.Point(4, 22);
            this.tabPageBookingData.Name = "tabPageBookingData";
            this.tabPageBookingData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookingData.Size = new System.Drawing.Size(652, 316);
            this.tabPageBookingData.TabIndex = 2;
            this.tabPageBookingData.Text = "Foglalás adatok";
            this.tabPageBookingData.UseVisualStyleBackColor = true;
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveData.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveData.Image")));
            this.buttonSaveData.Location = new System.Drawing.Point(499, 253);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(147, 57);
            this.buttonSaveData.TabIndex = 32;
            this.buttonSaveData.Text = "Adatok mentése";
            this.buttonSaveData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSaveData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // groupBoxBookingData
            // 
            this.groupBoxBookingData.Controls.Add(this.comboBoxRoom);
            this.groupBoxBookingData.Controls.Add(this.labelDepartureDate);
            this.groupBoxBookingData.Controls.Add(this.labelRoom);
            this.groupBoxBookingData.Controls.Add(this.labelArrivalDate);
            this.groupBoxBookingData.Controls.Add(this.numericUpDownNumberOfGuests);
            this.groupBoxBookingData.Controls.Add(this.labelNumberOfGuests);
            this.groupBoxBookingData.Controls.Add(this.dateTimePickerArrivalDate);
            this.groupBoxBookingData.Controls.Add(this.dateTimePickerDepartureDate);
            this.groupBoxBookingData.Location = new System.Drawing.Point(6, 6);
            this.groupBoxBookingData.Name = "groupBoxBookingData";
            this.groupBoxBookingData.Size = new System.Drawing.Size(434, 304);
            this.groupBoxBookingData.TabIndex = 33;
            this.groupBoxBookingData.TabStop = false;
            this.groupBoxBookingData.Text = "Foglalási adatok";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(152, 19);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(276, 21);
            this.comboBoxRoom.TabIndex = 28;
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.AutoSize = true;
            this.labelDepartureDate.Location = new System.Drawing.Point(95, 104);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(51, 13);
            this.labelDepartureDate.TabIndex = 25;
            this.labelDepartureDate.Text = "Távozás:";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(106, 22);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(40, 13);
            this.labelRoom.TabIndex = 24;
            this.labelRoom.Text = "Szoba:";
            // 
            // labelArrivalDate
            // 
            this.labelArrivalDate.AutoSize = true;
            this.labelArrivalDate.Location = new System.Drawing.Point(98, 78);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(48, 13);
            this.labelArrivalDate.TabIndex = 26;
            this.labelArrivalDate.Text = "Érkezés:";
            // 
            // numericUpDownNumberOfGuests
            // 
            this.numericUpDownNumberOfGuests.Location = new System.Drawing.Point(152, 46);
            this.numericUpDownNumberOfGuests.Name = "numericUpDownNumberOfGuests";
            this.numericUpDownNumberOfGuests.Size = new System.Drawing.Size(276, 20);
            this.numericUpDownNumberOfGuests.TabIndex = 29;
            this.numericUpDownNumberOfGuests.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNumberOfGuests
            // 
            this.labelNumberOfGuests.AutoSize = true;
            this.labelNumberOfGuests.Location = new System.Drawing.Point(54, 48);
            this.labelNumberOfGuests.Name = "labelNumberOfGuests";
            this.labelNumberOfGuests.Size = new System.Drawing.Size(92, 13);
            this.labelNumberOfGuests.TabIndex = 27;
            this.labelNumberOfGuests.Text = "Vendégek száma:";
            // 
            // dateTimePickerArrivalDate
            // 
            this.dateTimePickerArrivalDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerArrivalDate.Location = new System.Drawing.Point(152, 72);
            this.dateTimePickerArrivalDate.Name = "dateTimePickerArrivalDate";
            this.dateTimePickerArrivalDate.Size = new System.Drawing.Size(276, 20);
            this.dateTimePickerArrivalDate.TabIndex = 30;
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(152, 98);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(276, 20);
            this.dateTimePickerDepartureDate.TabIndex = 31;
            // 
            // tabPageGuestData
            // 
            this.tabPageGuestData.Controls.Add(this.buttonImportGuestData);
            this.tabPageGuestData.Controls.Add(this.groupBoxGuestData);
            this.tabPageGuestData.Controls.Add(this.groupBoxAdditionalInfo);
            this.tabPageGuestData.Location = new System.Drawing.Point(4, 22);
            this.tabPageGuestData.Name = "tabPageGuestData";
            this.tabPageGuestData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGuestData.Size = new System.Drawing.Size(652, 316);
            this.tabPageGuestData.TabIndex = 0;
            this.tabPageGuestData.Text = "Vendég adatok";
            this.tabPageGuestData.UseVisualStyleBackColor = true;
            // 
            // buttonImportGuestData
            // 
            this.buttonImportGuestData.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonImportGuestData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonImportGuestData.Image = ((System.Drawing.Image)(resources.GetObject("buttonImportGuestData.Image")));
            this.buttonImportGuestData.Location = new System.Drawing.Point(499, 253);
            this.buttonImportGuestData.Name = "buttonImportGuestData";
            this.buttonImportGuestData.Size = new System.Drawing.Size(147, 57);
            this.buttonImportGuestData.TabIndex = 33;
            this.buttonImportGuestData.Text = "Adatok importálása";
            this.buttonImportGuestData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonImportGuestData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonImportGuestData.UseVisualStyleBackColor = true;
            // 
            // groupBoxGuestData
            // 
            this.groupBoxGuestData.Controls.Add(this.textBoxName);
            this.groupBoxGuestData.Controls.Add(this.textBoxCitizenship);
            this.groupBoxGuestData.Controls.Add(this.labelDocumentNumber);
            this.groupBoxGuestData.Controls.Add(this.labelBirthDate);
            this.groupBoxGuestData.Controls.Add(this.labelName);
            this.groupBoxGuestData.Controls.Add(this.labelCitizenship);
            this.groupBoxGuestData.Controls.Add(this.textBoxBirthDate);
            this.groupBoxGuestData.Controls.Add(this.textBoxDocumentNumber);
            this.groupBoxGuestData.Controls.Add(this.comboBoxCountry);
            this.groupBoxGuestData.Controls.Add(this.textBoxZipCode);
            this.groupBoxGuestData.Controls.Add(this.textBoxCity);
            this.groupBoxGuestData.Controls.Add(this.textBoxAddress);
            this.groupBoxGuestData.Controls.Add(this.labelCountry);
            this.groupBoxGuestData.Controls.Add(this.labelAddress);
            this.groupBoxGuestData.Controls.Add(this.labelZipCode);
            this.groupBoxGuestData.Controls.Add(this.labelCity);
            this.groupBoxGuestData.Location = new System.Drawing.Point(6, 6);
            this.groupBoxGuestData.Name = "groupBoxGuestData";
            this.groupBoxGuestData.Size = new System.Drawing.Size(434, 229);
            this.groupBoxGuestData.TabIndex = 30;
            this.groupBoxGuestData.TabStop = false;
            this.groupBoxGuestData.Text = "Személyes adatok";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(152, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(276, 20);
            this.textBoxName.TabIndex = 20;
            // 
            // textBoxCitizenship
            // 
            this.textBoxCitizenship.Location = new System.Drawing.Point(152, 45);
            this.textBoxCitizenship.Name = "textBoxCitizenship";
            this.textBoxCitizenship.Size = new System.Drawing.Size(276, 20);
            this.textBoxCitizenship.TabIndex = 21;
            // 
            // labelDocumentNumber
            // 
            this.labelDocumentNumber.AutoSize = true;
            this.labelDocumentNumber.Location = new System.Drawing.Point(50, 100);
            this.labelDocumentNumber.Name = "labelDocumentNumber";
            this.labelDocumentNumber.Size = new System.Drawing.Size(96, 13);
            this.labelDocumentNumber.TabIndex = 12;
            this.labelDocumentNumber.Text = "Okmányazonosító:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(77, 74);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(69, 13);
            this.labelBirthDate.TabIndex = 14;
            this.labelBirthDate.Text = "Születési idő:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(72, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 13);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Vendég neve:";
            // 
            // labelCitizenship
            // 
            this.labelCitizenship.AutoSize = true;
            this.labelCitizenship.Location = new System.Drawing.Point(65, 48);
            this.labelCitizenship.Name = "labelCitizenship";
            this.labelCitizenship.Size = new System.Drawing.Size(81, 13);
            this.labelCitizenship.TabIndex = 16;
            this.labelCitizenship.Text = "Állampolgárság:";
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Location = new System.Drawing.Point(152, 71);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.Size = new System.Drawing.Size(276, 20);
            this.textBoxBirthDate.TabIndex = 22;
            // 
            // textBoxDocumentNumber
            // 
            this.textBoxDocumentNumber.Location = new System.Drawing.Point(152, 97);
            this.textBoxDocumentNumber.Name = "textBoxDocumentNumber";
            this.textBoxDocumentNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxDocumentNumber.TabIndex = 23;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(152, 123);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(276, 21);
            this.comboBoxCountry.TabIndex = 24;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(152, 150);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(276, 20);
            this.textBoxZipCode.TabIndex = 25;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(152, 176);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(276, 20);
            this.textBoxCity.TabIndex = 26;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(152, 202);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(276, 20);
            this.textBoxAddress.TabIndex = 27;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(103, 126);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 19;
            this.labelCountry.Text = "Ország:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(117, 205);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(29, 13);
            this.labelAddress.TabIndex = 13;
            this.labelAddress.Text = "Cím:";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(76, 153);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(70, 13);
            this.labelZipCode.TabIndex = 17;
            this.labelZipCode.Text = "Irányítószám:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(90, 179);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(56, 13);
            this.labelCity.TabIndex = 10;
            this.labelCity.Text = "Település:";
            // 
            // groupBoxAdditionalInfo
            // 
            this.groupBoxAdditionalInfo.Controls.Add(this.textBoxEmailAddress);
            this.groupBoxAdditionalInfo.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxAdditionalInfo.Controls.Add(this.labelPhoneNumber);
            this.groupBoxAdditionalInfo.Controls.Add(this.labelEmailAddress);
            this.groupBoxAdditionalInfo.Location = new System.Drawing.Point(6, 241);
            this.groupBoxAdditionalInfo.Name = "groupBoxAdditionalInfo";
            this.groupBoxAdditionalInfo.Size = new System.Drawing.Size(434, 69);
            this.groupBoxAdditionalInfo.TabIndex = 31;
            this.groupBoxAdditionalInfo.TabStop = false;
            this.groupBoxAdditionalInfo.Text = "Egyéb adatok";
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(152, 45);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(276, 20);
            this.textBoxEmailAddress.TabIndex = 29;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(152, 19);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxPhoneNumber.TabIndex = 28;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(77, 22);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(70, 13);
            this.labelPhoneNumber.TabIndex = 11;
            this.labelPhoneNumber.Text = "Telefonszám:";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(108, 48);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(38, 13);
            this.labelEmailAddress.TabIndex = 15;
            this.labelEmailAddress.Text = "E-mail:";
            // 
            // tabControlGuestRegistrationCard
            // 
            this.tabControlGuestRegistrationCard.Controls.Add(this.tabPageGuestData);
            this.tabControlGuestRegistrationCard.Controls.Add(this.tabPageBookingData);
            this.tabControlGuestRegistrationCard.Location = new System.Drawing.Point(12, 12);
            this.tabControlGuestRegistrationCard.Name = "tabControlGuestRegistrationCard";
            this.tabControlGuestRegistrationCard.SelectedIndex = 0;
            this.tabControlGuestRegistrationCard.Size = new System.Drawing.Size(660, 342);
            this.tabControlGuestRegistrationCard.TabIndex = 10;
            // 
            // FormGuestRegistrationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 366);
            this.Controls.Add(this.tabControlGuestRegistrationCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGuestRegistrationCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendég bejelentkező lap kitöltése | Virtual Receptionist";
            this.Load += new System.EventHandler(this.FormGuestRegistrationCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInput)).EndInit();
            this.tabPageBookingData.ResumeLayout(false);
            this.groupBoxBookingData.ResumeLayout(false);
            this.groupBoxBookingData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGuests)).EndInit();
            this.tabPageGuestData.ResumeLayout(false);
            this.groupBoxGuestData.ResumeLayout(false);
            this.groupBoxGuestData.PerformLayout();
            this.groupBoxAdditionalInfo.ResumeLayout(false);
            this.groupBoxAdditionalInfo.PerformLayout();
            this.tabControlGuestRegistrationCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProviderInput;
        private System.Windows.Forms.TabControl tabControlGuestRegistrationCard;
        private System.Windows.Forms.TabPage tabPageGuestData;
        private System.Windows.Forms.Button buttonImportGuestData;
        private System.Windows.Forms.GroupBox groupBoxGuestData;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCitizenship;
        private System.Windows.Forms.Label labelDocumentNumber;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCitizenship;
        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.TextBox textBoxDocumentNumber;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.GroupBox groupBoxAdditionalInfo;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.TabPage tabPageBookingData;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.GroupBox groupBoxBookingData;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label labelArrivalDate;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfGuests;
        private System.Windows.Forms.Label labelNumberOfGuests;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrivalDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
    }
}