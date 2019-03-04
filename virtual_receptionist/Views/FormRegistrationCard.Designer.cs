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
            this.groupBoxBookingData = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.labelNumberOfGuests = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfGuests = new System.Windows.Forms.NumericUpDown();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.tabPageGuestData = new System.Windows.Forms.TabPage();
            this.groupBoxAdditionalInfo = new System.Windows.Forms.GroupBox();
            this.labelGuestEmailAddress = new System.Windows.Forms.Label();
            this.labelGuestPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxGuestPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxGuestEmailAddress = new System.Windows.Forms.TextBox();
            this.groupBoxPersonalData = new System.Windows.Forms.GroupBox();
            this.labelGuestCity = new System.Windows.Forms.Label();
            this.labelGuestZipCode = new System.Windows.Forms.Label();
            this.labelGuestAddress = new System.Windows.Forms.Label();
            this.labelGuestCountry = new System.Windows.Forms.Label();
            this.textBoxGuestAddress = new System.Windows.Forms.TextBox();
            this.textBoxGuestCity = new System.Windows.Forms.TextBox();
            this.textBoxGuestZipCode = new System.Windows.Forms.TextBox();
            this.comboBoxGuestCountry = new System.Windows.Forms.ComboBox();
            this.textBoxGuestDocumentNumber = new System.Windows.Forms.TextBox();
            this.textBoxGuestBirthDate = new System.Windows.Forms.TextBox();
            this.labelGuestCitizenship = new System.Windows.Forms.Label();
            this.labelGuestName = new System.Windows.Forms.Label();
            this.labelGuestBirthDate = new System.Windows.Forms.Label();
            this.labelGuestDocumentNumber = new System.Windows.Forms.Label();
            this.textBoxGuestCitizenship = new System.Windows.Forms.TextBox();
            this.textBoxGuestName = new System.Windows.Forms.TextBox();
            this.buttonImportGuestData = new System.Windows.Forms.Button();
            this.tabControlGuestRegistrationCard = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInput)).BeginInit();
            this.tabPageBookingData.SuspendLayout();
            this.groupBoxBookingData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGuests)).BeginInit();
            this.tabPageGuestData.SuspendLayout();
            this.groupBoxAdditionalInfo.SuspendLayout();
            this.groupBoxPersonalData.SuspendLayout();
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
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(152, 98);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(276, 20);
            this.dateTimePickerDepartureDate.TabIndex = 31;
            // 
            // dateTimePickerArrivalDate
            // 
            this.dateTimePickerArrivalDate.Location = new System.Drawing.Point(152, 72);
            this.dateTimePickerArrivalDate.Name = "dateTimePickerArrivalDate";
            this.dateTimePickerArrivalDate.Size = new System.Drawing.Size(276, 20);
            this.dateTimePickerArrivalDate.TabIndex = 30;
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
            // labelArrivalDate
            // 
            this.labelArrivalDate.AutoSize = true;
            this.labelArrivalDate.Location = new System.Drawing.Point(98, 78);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(48, 13);
            this.labelArrivalDate.TabIndex = 26;
            this.labelArrivalDate.Text = "Érkezés:";
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
            // labelDepartureDate
            // 
            this.labelDepartureDate.AutoSize = true;
            this.labelDepartureDate.Location = new System.Drawing.Point(95, 104);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(51, 13);
            this.labelDepartureDate.TabIndex = 25;
            this.labelDepartureDate.Text = "Távozás:";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(152, 19);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(276, 21);
            this.comboBoxRoom.TabIndex = 28;
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
            // 
            // tabPageGuestData
            // 
            this.tabPageGuestData.Controls.Add(this.buttonImportGuestData);
            this.tabPageGuestData.Controls.Add(this.groupBoxPersonalData);
            this.tabPageGuestData.Controls.Add(this.groupBoxAdditionalInfo);
            this.tabPageGuestData.Location = new System.Drawing.Point(4, 22);
            this.tabPageGuestData.Name = "tabPageGuestData";
            this.tabPageGuestData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGuestData.Size = new System.Drawing.Size(652, 316);
            this.tabPageGuestData.TabIndex = 0;
            this.tabPageGuestData.Text = "Vendég adatok";
            this.tabPageGuestData.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdditionalInfo
            // 
            this.groupBoxAdditionalInfo.Controls.Add(this.textBoxGuestEmailAddress);
            this.groupBoxAdditionalInfo.Controls.Add(this.textBoxGuestPhoneNumber);
            this.groupBoxAdditionalInfo.Controls.Add(this.labelGuestPhoneNumber);
            this.groupBoxAdditionalInfo.Controls.Add(this.labelGuestEmailAddress);
            this.groupBoxAdditionalInfo.Location = new System.Drawing.Point(6, 241);
            this.groupBoxAdditionalInfo.Name = "groupBoxAdditionalInfo";
            this.groupBoxAdditionalInfo.Size = new System.Drawing.Size(434, 69);
            this.groupBoxAdditionalInfo.TabIndex = 31;
            this.groupBoxAdditionalInfo.TabStop = false;
            this.groupBoxAdditionalInfo.Text = "Egyéb adatok";
            // 
            // labelGuestEmailAddress
            // 
            this.labelGuestEmailAddress.AutoSize = true;
            this.labelGuestEmailAddress.Location = new System.Drawing.Point(108, 48);
            this.labelGuestEmailAddress.Name = "labelGuestEmailAddress";
            this.labelGuestEmailAddress.Size = new System.Drawing.Size(38, 13);
            this.labelGuestEmailAddress.TabIndex = 15;
            this.labelGuestEmailAddress.Text = "E-mail:";
            // 
            // labelGuestPhoneNumber
            // 
            this.labelGuestPhoneNumber.AutoSize = true;
            this.labelGuestPhoneNumber.Location = new System.Drawing.Point(77, 22);
            this.labelGuestPhoneNumber.Name = "labelGuestPhoneNumber";
            this.labelGuestPhoneNumber.Size = new System.Drawing.Size(70, 13);
            this.labelGuestPhoneNumber.TabIndex = 11;
            this.labelGuestPhoneNumber.Text = "Telefonszám:";
            // 
            // textBoxGuestPhoneNumber
            // 
            this.textBoxGuestPhoneNumber.Location = new System.Drawing.Point(152, 19);
            this.textBoxGuestPhoneNumber.Name = "textBoxGuestPhoneNumber";
            this.textBoxGuestPhoneNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestPhoneNumber.TabIndex = 28;
            // 
            // textBoxGuestEmailAddress
            // 
            this.textBoxGuestEmailAddress.Location = new System.Drawing.Point(152, 45);
            this.textBoxGuestEmailAddress.Name = "textBoxGuestEmailAddress";
            this.textBoxGuestEmailAddress.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestEmailAddress.TabIndex = 29;
            // 
            // groupBoxPersonalData
            // 
            this.groupBoxPersonalData.Controls.Add(this.textBoxGuestName);
            this.groupBoxPersonalData.Controls.Add(this.textBoxGuestCitizenship);
            this.groupBoxPersonalData.Controls.Add(this.labelGuestDocumentNumber);
            this.groupBoxPersonalData.Controls.Add(this.labelGuestBirthDate);
            this.groupBoxPersonalData.Controls.Add(this.labelGuestName);
            this.groupBoxPersonalData.Controls.Add(this.labelGuestCitizenship);
            this.groupBoxPersonalData.Controls.Add(this.textBoxGuestBirthDate);
            this.groupBoxPersonalData.Controls.Add(this.textBoxGuestDocumentNumber);
            this.groupBoxPersonalData.Controls.Add(this.comboBoxGuestCountry);
            this.groupBoxPersonalData.Controls.Add(this.textBoxGuestZipCode);
            this.groupBoxPersonalData.Controls.Add(this.textBoxGuestCity);
            this.groupBoxPersonalData.Controls.Add(this.textBoxGuestAddress);
            this.groupBoxPersonalData.Controls.Add(this.labelGuestCountry);
            this.groupBoxPersonalData.Controls.Add(this.labelGuestAddress);
            this.groupBoxPersonalData.Controls.Add(this.labelGuestZipCode);
            this.groupBoxPersonalData.Controls.Add(this.labelGuestCity);
            this.groupBoxPersonalData.Location = new System.Drawing.Point(6, 6);
            this.groupBoxPersonalData.Name = "groupBoxPersonalData";
            this.groupBoxPersonalData.Size = new System.Drawing.Size(434, 229);
            this.groupBoxPersonalData.TabIndex = 30;
            this.groupBoxPersonalData.TabStop = false;
            this.groupBoxPersonalData.Text = "Személyes adatok";
            // 
            // labelGuestCity
            // 
            this.labelGuestCity.AutoSize = true;
            this.labelGuestCity.Location = new System.Drawing.Point(90, 179);
            this.labelGuestCity.Name = "labelGuestCity";
            this.labelGuestCity.Size = new System.Drawing.Size(56, 13);
            this.labelGuestCity.TabIndex = 10;
            this.labelGuestCity.Text = "Település:";
            // 
            // labelGuestZipCode
            // 
            this.labelGuestZipCode.AutoSize = true;
            this.labelGuestZipCode.Location = new System.Drawing.Point(76, 153);
            this.labelGuestZipCode.Name = "labelGuestZipCode";
            this.labelGuestZipCode.Size = new System.Drawing.Size(70, 13);
            this.labelGuestZipCode.TabIndex = 17;
            this.labelGuestZipCode.Text = "Irányítószám:";
            // 
            // labelGuestAddress
            // 
            this.labelGuestAddress.AutoSize = true;
            this.labelGuestAddress.Location = new System.Drawing.Point(117, 205);
            this.labelGuestAddress.Name = "labelGuestAddress";
            this.labelGuestAddress.Size = new System.Drawing.Size(29, 13);
            this.labelGuestAddress.TabIndex = 13;
            this.labelGuestAddress.Text = "Cím:";
            // 
            // labelGuestCountry
            // 
            this.labelGuestCountry.AutoSize = true;
            this.labelGuestCountry.Location = new System.Drawing.Point(103, 126);
            this.labelGuestCountry.Name = "labelGuestCountry";
            this.labelGuestCountry.Size = new System.Drawing.Size(43, 13);
            this.labelGuestCountry.TabIndex = 19;
            this.labelGuestCountry.Text = "Ország:";
            // 
            // textBoxGuestAddress
            // 
            this.textBoxGuestAddress.Location = new System.Drawing.Point(152, 202);
            this.textBoxGuestAddress.Name = "textBoxGuestAddress";
            this.textBoxGuestAddress.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestAddress.TabIndex = 27;
            // 
            // textBoxGuestCity
            // 
            this.textBoxGuestCity.Location = new System.Drawing.Point(152, 176);
            this.textBoxGuestCity.Name = "textBoxGuestCity";
            this.textBoxGuestCity.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestCity.TabIndex = 26;
            // 
            // textBoxGuestZipCode
            // 
            this.textBoxGuestZipCode.Location = new System.Drawing.Point(152, 150);
            this.textBoxGuestZipCode.Name = "textBoxGuestZipCode";
            this.textBoxGuestZipCode.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestZipCode.TabIndex = 25;
            // 
            // comboBoxGuestCountry
            // 
            this.comboBoxGuestCountry.FormattingEnabled = true;
            this.comboBoxGuestCountry.Location = new System.Drawing.Point(152, 123);
            this.comboBoxGuestCountry.Name = "comboBoxGuestCountry";
            this.comboBoxGuestCountry.Size = new System.Drawing.Size(276, 21);
            this.comboBoxGuestCountry.TabIndex = 24;
            // 
            // textBoxGuestDocumentNumber
            // 
            this.textBoxGuestDocumentNumber.Location = new System.Drawing.Point(152, 97);
            this.textBoxGuestDocumentNumber.Name = "textBoxGuestDocumentNumber";
            this.textBoxGuestDocumentNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestDocumentNumber.TabIndex = 23;
            // 
            // textBoxGuestBirthDate
            // 
            this.textBoxGuestBirthDate.Location = new System.Drawing.Point(152, 71);
            this.textBoxGuestBirthDate.Name = "textBoxGuestBirthDate";
            this.textBoxGuestBirthDate.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestBirthDate.TabIndex = 22;
            // 
            // labelGuestCitizenship
            // 
            this.labelGuestCitizenship.AutoSize = true;
            this.labelGuestCitizenship.Location = new System.Drawing.Point(65, 48);
            this.labelGuestCitizenship.Name = "labelGuestCitizenship";
            this.labelGuestCitizenship.Size = new System.Drawing.Size(81, 13);
            this.labelGuestCitizenship.TabIndex = 16;
            this.labelGuestCitizenship.Text = "Állampolgárság:";
            // 
            // labelGuestName
            // 
            this.labelGuestName.AutoSize = true;
            this.labelGuestName.Location = new System.Drawing.Point(72, 22);
            this.labelGuestName.Name = "labelGuestName";
            this.labelGuestName.Size = new System.Drawing.Size(74, 13);
            this.labelGuestName.TabIndex = 18;
            this.labelGuestName.Text = "Vendég neve:";
            // 
            // labelGuestBirthDate
            // 
            this.labelGuestBirthDate.AutoSize = true;
            this.labelGuestBirthDate.Location = new System.Drawing.Point(77, 74);
            this.labelGuestBirthDate.Name = "labelGuestBirthDate";
            this.labelGuestBirthDate.Size = new System.Drawing.Size(69, 13);
            this.labelGuestBirthDate.TabIndex = 14;
            this.labelGuestBirthDate.Text = "Születési idő:";
            // 
            // labelGuestDocumentNumber
            // 
            this.labelGuestDocumentNumber.AutoSize = true;
            this.labelGuestDocumentNumber.Location = new System.Drawing.Point(50, 100);
            this.labelGuestDocumentNumber.Name = "labelGuestDocumentNumber";
            this.labelGuestDocumentNumber.Size = new System.Drawing.Size(96, 13);
            this.labelGuestDocumentNumber.TabIndex = 12;
            this.labelGuestDocumentNumber.Text = "Okmányazonosító:";
            // 
            // textBoxGuestCitizenship
            // 
            this.textBoxGuestCitizenship.Location = new System.Drawing.Point(152, 45);
            this.textBoxGuestCitizenship.Name = "textBoxGuestCitizenship";
            this.textBoxGuestCitizenship.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestCitizenship.TabIndex = 21;
            // 
            // textBoxGuestName
            // 
            this.textBoxGuestName.Location = new System.Drawing.Point(152, 19);
            this.textBoxGuestName.Name = "textBoxGuestName";
            this.textBoxGuestName.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestName.TabIndex = 20;
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
            this.groupBoxAdditionalInfo.ResumeLayout(false);
            this.groupBoxAdditionalInfo.PerformLayout();
            this.groupBoxPersonalData.ResumeLayout(false);
            this.groupBoxPersonalData.PerformLayout();
            this.tabControlGuestRegistrationCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProviderInput;
        private System.Windows.Forms.TabControl tabControlGuestRegistrationCard;
        private System.Windows.Forms.TabPage tabPageGuestData;
        private System.Windows.Forms.Button buttonImportGuestData;
        private System.Windows.Forms.GroupBox groupBoxPersonalData;
        private System.Windows.Forms.TextBox textBoxGuestName;
        private System.Windows.Forms.TextBox textBoxGuestCitizenship;
        private System.Windows.Forms.Label labelGuestDocumentNumber;
        private System.Windows.Forms.Label labelGuestBirthDate;
        private System.Windows.Forms.Label labelGuestName;
        private System.Windows.Forms.Label labelGuestCitizenship;
        private System.Windows.Forms.TextBox textBoxGuestBirthDate;
        private System.Windows.Forms.TextBox textBoxGuestDocumentNumber;
        private System.Windows.Forms.ComboBox comboBoxGuestCountry;
        private System.Windows.Forms.TextBox textBoxGuestZipCode;
        private System.Windows.Forms.TextBox textBoxGuestCity;
        private System.Windows.Forms.TextBox textBoxGuestAddress;
        private System.Windows.Forms.Label labelGuestCountry;
        private System.Windows.Forms.Label labelGuestAddress;
        private System.Windows.Forms.Label labelGuestZipCode;
        private System.Windows.Forms.Label labelGuestCity;
        private System.Windows.Forms.GroupBox groupBoxAdditionalInfo;
        private System.Windows.Forms.TextBox textBoxGuestEmailAddress;
        private System.Windows.Forms.TextBox textBoxGuestPhoneNumber;
        private System.Windows.Forms.Label labelGuestPhoneNumber;
        private System.Windows.Forms.Label labelGuestEmailAddress;
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