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
            this.tabControlGuestRegistrationCard = new System.Windows.Forms.TabControl();
            this.tabPageGuestData = new System.Windows.Forms.TabPage();
            this.buttonImportGuestData = new System.Windows.Forms.Button();
            this.groupBoxPersonalData = new System.Windows.Forms.GroupBox();
            this.textBoxGuestName = new System.Windows.Forms.TextBox();
            this.textBoxGuestCitizenship = new System.Windows.Forms.TextBox();
            this.labelGuestDocumentNumber = new System.Windows.Forms.Label();
            this.labelGuestBirthDate = new System.Windows.Forms.Label();
            this.labelGuestName = new System.Windows.Forms.Label();
            this.labelGuestCitizenship = new System.Windows.Forms.Label();
            this.textBoxGuestBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxGuestDocumentNumber = new System.Windows.Forms.TextBox();
            this.comboBoxGuestCountry = new System.Windows.Forms.ComboBox();
            this.textBoxGuestZipCode = new System.Windows.Forms.TextBox();
            this.textBoxGuestCity = new System.Windows.Forms.TextBox();
            this.textBoxGuestAddress = new System.Windows.Forms.TextBox();
            this.labelGuestCountry = new System.Windows.Forms.Label();
            this.labelGuestAddress = new System.Windows.Forms.Label();
            this.labelGuestZipCode = new System.Windows.Forms.Label();
            this.labelGuestCity = new System.Windows.Forms.Label();
            this.groupBoxAdditionalInfo = new System.Windows.Forms.GroupBox();
            this.textBoxGuestEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxGuestPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelGuestPhoneNumber = new System.Windows.Forms.Label();
            this.labelGuestEmailAddress = new System.Windows.Forms.Label();
            this.tabPageBillingData = new System.Windows.Forms.TabPage();
            this.buttonImportCompanyData = new System.Windows.Forms.Button();
            this.groupBoxBillingData = new System.Windows.Forms.GroupBox();
            this.checkBoxIsCompany = new System.Windows.Forms.CheckBox();
            this.textBoxBillingName = new System.Windows.Forms.TextBox();
            this.labelVATNumber = new System.Windows.Forms.Label();
            this.labelHeadquarterCity = new System.Windows.Forms.Label();
            this.textBoxCompanyVATNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelHeadquarterAddress = new System.Windows.Forms.Label();
            this.comboBoxHeadquarterCountry = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHeadquarterAddress = new System.Windows.Forms.TextBox();
            this.textBoxHeadquarterZipCode = new System.Windows.Forms.TextBox();
            this.labelBillingName = new System.Windows.Forms.Label();
            this.textBoxHeadquarterCity = new System.Windows.Forms.TextBox();
            this.groupBoxAdditionalCompanyInfo = new System.Windows.Forms.GroupBox();
            this.labelCompanyPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxCompanyEmailAddress = new System.Windows.Forms.TextBox();
            this.labelCompanyEmailAddress = new System.Windows.Forms.Label();
            this.textBoxCompanyPhoneNumber = new System.Windows.Forms.TextBox();
            this.tabPageBookingData = new System.Windows.Forms.TabPage();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.numericUpDownNumberOfGuests = new System.Windows.Forms.NumericUpDown();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.labelNumberOfGuests = new System.Windows.Forms.Label();
            this.dateTimePickerArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxBookingData = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInput)).BeginInit();
            this.tabControlGuestRegistrationCard.SuspendLayout();
            this.tabPageGuestData.SuspendLayout();
            this.groupBoxPersonalData.SuspendLayout();
            this.groupBoxAdditionalInfo.SuspendLayout();
            this.tabPageBillingData.SuspendLayout();
            this.groupBoxBillingData.SuspendLayout();
            this.groupBoxAdditionalCompanyInfo.SuspendLayout();
            this.tabPageBookingData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGuests)).BeginInit();
            this.groupBoxBookingData.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProviderInput
            // 
            this.errorProviderInput.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderInput.ContainerControl = this;
            // 
            // tabControlGuestRegistrationCard
            // 
            this.tabControlGuestRegistrationCard.Controls.Add(this.tabPageGuestData);
            this.tabControlGuestRegistrationCard.Controls.Add(this.tabPageBillingData);
            this.tabControlGuestRegistrationCard.Controls.Add(this.tabPageBookingData);
            this.tabControlGuestRegistrationCard.Location = new System.Drawing.Point(12, 12);
            this.tabControlGuestRegistrationCard.Name = "tabControlGuestRegistrationCard";
            this.tabControlGuestRegistrationCard.SelectedIndex = 0;
            this.tabControlGuestRegistrationCard.Size = new System.Drawing.Size(660, 342);
            this.tabControlGuestRegistrationCard.TabIndex = 10;
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
            this.buttonImportGuestData.Click += new System.EventHandler(this.buttonImportGuestData_Click);
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
            // textBoxGuestName
            // 
            this.textBoxGuestName.Location = new System.Drawing.Point(152, 19);
            this.textBoxGuestName.Name = "textBoxGuestName";
            this.textBoxGuestName.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestName.TabIndex = 20;
            this.textBoxGuestName.TextChanged += new System.EventHandler(this.textBoxGuestName_TextChanged);
            // 
            // textBoxGuestCitizenship
            // 
            this.textBoxGuestCitizenship.Location = new System.Drawing.Point(152, 45);
            this.textBoxGuestCitizenship.Name = "textBoxGuestCitizenship";
            this.textBoxGuestCitizenship.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestCitizenship.TabIndex = 21;
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
            // labelGuestBirthDate
            // 
            this.labelGuestBirthDate.AutoSize = true;
            this.labelGuestBirthDate.Location = new System.Drawing.Point(77, 74);
            this.labelGuestBirthDate.Name = "labelGuestBirthDate";
            this.labelGuestBirthDate.Size = new System.Drawing.Size(69, 13);
            this.labelGuestBirthDate.TabIndex = 14;
            this.labelGuestBirthDate.Text = "Születési idő:";
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
            // labelGuestCitizenship
            // 
            this.labelGuestCitizenship.AutoSize = true;
            this.labelGuestCitizenship.Location = new System.Drawing.Point(65, 48);
            this.labelGuestCitizenship.Name = "labelGuestCitizenship";
            this.labelGuestCitizenship.Size = new System.Drawing.Size(81, 13);
            this.labelGuestCitizenship.TabIndex = 16;
            this.labelGuestCitizenship.Text = "Állampolgárság:";
            // 
            // textBoxGuestBirthDate
            // 
            this.textBoxGuestBirthDate.Location = new System.Drawing.Point(152, 71);
            this.textBoxGuestBirthDate.Name = "textBoxGuestBirthDate";
            this.textBoxGuestBirthDate.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestBirthDate.TabIndex = 22;
            // 
            // textBoxGuestDocumentNumber
            // 
            this.textBoxGuestDocumentNumber.Location = new System.Drawing.Point(152, 97);
            this.textBoxGuestDocumentNumber.Name = "textBoxGuestDocumentNumber";
            this.textBoxGuestDocumentNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestDocumentNumber.TabIndex = 23;
            // 
            // comboBoxGuestCountry
            // 
            this.comboBoxGuestCountry.FormattingEnabled = true;
            this.comboBoxGuestCountry.Location = new System.Drawing.Point(152, 123);
            this.comboBoxGuestCountry.Name = "comboBoxGuestCountry";
            this.comboBoxGuestCountry.Size = new System.Drawing.Size(276, 21);
            this.comboBoxGuestCountry.TabIndex = 24;
            this.comboBoxGuestCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxGuestCountry_SelectedIndexChanged);
            // 
            // textBoxGuestZipCode
            // 
            this.textBoxGuestZipCode.Location = new System.Drawing.Point(152, 150);
            this.textBoxGuestZipCode.Name = "textBoxGuestZipCode";
            this.textBoxGuestZipCode.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestZipCode.TabIndex = 25;
            this.textBoxGuestZipCode.TextChanged += new System.EventHandler(this.textBoxGuestZipCode_TextChanged);
            // 
            // textBoxGuestCity
            // 
            this.textBoxGuestCity.Location = new System.Drawing.Point(152, 176);
            this.textBoxGuestCity.Name = "textBoxGuestCity";
            this.textBoxGuestCity.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestCity.TabIndex = 26;
            this.textBoxGuestCity.TextChanged += new System.EventHandler(this.textBoxGuestCity_TextChanged);
            // 
            // textBoxGuestAddress
            // 
            this.textBoxGuestAddress.Location = new System.Drawing.Point(152, 202);
            this.textBoxGuestAddress.Name = "textBoxGuestAddress";
            this.textBoxGuestAddress.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestAddress.TabIndex = 27;
            this.textBoxGuestAddress.TextChanged += new System.EventHandler(this.textBoxGuestAddress_TextChanged);
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
            // labelGuestAddress
            // 
            this.labelGuestAddress.AutoSize = true;
            this.labelGuestAddress.Location = new System.Drawing.Point(117, 205);
            this.labelGuestAddress.Name = "labelGuestAddress";
            this.labelGuestAddress.Size = new System.Drawing.Size(29, 13);
            this.labelGuestAddress.TabIndex = 13;
            this.labelGuestAddress.Text = "Cím:";
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
            // labelGuestCity
            // 
            this.labelGuestCity.AutoSize = true;
            this.labelGuestCity.Location = new System.Drawing.Point(90, 179);
            this.labelGuestCity.Name = "labelGuestCity";
            this.labelGuestCity.Size = new System.Drawing.Size(56, 13);
            this.labelGuestCity.TabIndex = 10;
            this.labelGuestCity.Text = "Település:";
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
            // textBoxGuestEmailAddress
            // 
            this.textBoxGuestEmailAddress.Location = new System.Drawing.Point(152, 45);
            this.textBoxGuestEmailAddress.Name = "textBoxGuestEmailAddress";
            this.textBoxGuestEmailAddress.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestEmailAddress.TabIndex = 29;
            // 
            // textBoxGuestPhoneNumber
            // 
            this.textBoxGuestPhoneNumber.Location = new System.Drawing.Point(152, 19);
            this.textBoxGuestPhoneNumber.Name = "textBoxGuestPhoneNumber";
            this.textBoxGuestPhoneNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxGuestPhoneNumber.TabIndex = 28;
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
            // labelGuestEmailAddress
            // 
            this.labelGuestEmailAddress.AutoSize = true;
            this.labelGuestEmailAddress.Location = new System.Drawing.Point(108, 48);
            this.labelGuestEmailAddress.Name = "labelGuestEmailAddress";
            this.labelGuestEmailAddress.Size = new System.Drawing.Size(38, 13);
            this.labelGuestEmailAddress.TabIndex = 15;
            this.labelGuestEmailAddress.Text = "E-mail:";
            // 
            // tabPageBillingData
            // 
            this.tabPageBillingData.Controls.Add(this.buttonImportCompanyData);
            this.tabPageBillingData.Controls.Add(this.groupBoxBillingData);
            this.tabPageBillingData.Controls.Add(this.groupBoxAdditionalCompanyInfo);
            this.tabPageBillingData.Location = new System.Drawing.Point(4, 22);
            this.tabPageBillingData.Name = "tabPageBillingData";
            this.tabPageBillingData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBillingData.Size = new System.Drawing.Size(652, 316);
            this.tabPageBillingData.TabIndex = 1;
            this.tabPageBillingData.Text = "Számlázási adatok";
            this.tabPageBillingData.UseVisualStyleBackColor = true;
            // 
            // buttonImportCompanyData
            // 
            this.buttonImportCompanyData.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonImportCompanyData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonImportCompanyData.Image = ((System.Drawing.Image)(resources.GetObject("buttonImportCompanyData.Image")));
            this.buttonImportCompanyData.Location = new System.Drawing.Point(499, 253);
            this.buttonImportCompanyData.Name = "buttonImportCompanyData";
            this.buttonImportCompanyData.Size = new System.Drawing.Size(147, 57);
            this.buttonImportCompanyData.TabIndex = 38;
            this.buttonImportCompanyData.Text = "Adatok importálása";
            this.buttonImportCompanyData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonImportCompanyData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonImportCompanyData.UseVisualStyleBackColor = true;
            this.buttonImportCompanyData.Visible = false;
            this.buttonImportCompanyData.Click += new System.EventHandler(this.buttonImportCompanyData_Click);
            // 
            // groupBoxBillingData
            // 
            this.groupBoxBillingData.Controls.Add(this.checkBoxIsCompany);
            this.groupBoxBillingData.Controls.Add(this.textBoxBillingName);
            this.groupBoxBillingData.Controls.Add(this.labelVATNumber);
            this.groupBoxBillingData.Controls.Add(this.labelHeadquarterCity);
            this.groupBoxBillingData.Controls.Add(this.textBoxCompanyVATNumber);
            this.groupBoxBillingData.Controls.Add(this.label10);
            this.groupBoxBillingData.Controls.Add(this.labelHeadquarterAddress);
            this.groupBoxBillingData.Controls.Add(this.comboBoxHeadquarterCountry);
            this.groupBoxBillingData.Controls.Add(this.label8);
            this.groupBoxBillingData.Controls.Add(this.textBoxHeadquarterAddress);
            this.groupBoxBillingData.Controls.Add(this.textBoxHeadquarterZipCode);
            this.groupBoxBillingData.Controls.Add(this.labelBillingName);
            this.groupBoxBillingData.Controls.Add(this.textBoxHeadquarterCity);
            this.groupBoxBillingData.Location = new System.Drawing.Point(6, 6);
            this.groupBoxBillingData.Name = "groupBoxBillingData";
            this.groupBoxBillingData.Size = new System.Drawing.Size(434, 203);
            this.groupBoxBillingData.TabIndex = 36;
            this.groupBoxBillingData.TabStop = false;
            this.groupBoxBillingData.Text = "Számlázási adatok";
            // 
            // checkBoxIsCompany
            // 
            this.checkBoxIsCompany.AutoSize = true;
            this.checkBoxIsCompany.Location = new System.Drawing.Point(152, 19);
            this.checkBoxIsCompany.Name = "checkBoxIsCompany";
            this.checkBoxIsCompany.Size = new System.Drawing.Size(160, 17);
            this.checkBoxIsCompany.TabIndex = 27;
            this.checkBoxIsCompany.Text = "A vendég céges számlát kér";
            this.checkBoxIsCompany.UseVisualStyleBackColor = true;
            this.checkBoxIsCompany.CheckedChanged += new System.EventHandler(this.checkBoxIsCompany_CheckedChanged);
            // 
            // textBoxBillingName
            // 
            this.textBoxBillingName.Enabled = false;
            this.textBoxBillingName.Location = new System.Drawing.Point(152, 42);
            this.textBoxBillingName.Name = "textBoxBillingName";
            this.textBoxBillingName.Size = new System.Drawing.Size(276, 20);
            this.textBoxBillingName.TabIndex = 28;
            // 
            // labelVATNumber
            // 
            this.labelVATNumber.AutoSize = true;
            this.labelVATNumber.Location = new System.Drawing.Point(93, 176);
            this.labelVATNumber.Name = "labelVATNumber";
            this.labelVATNumber.Size = new System.Drawing.Size(53, 13);
            this.labelVATNumber.TabIndex = 20;
            this.labelVATNumber.Text = "Adószám:";
            this.labelVATNumber.Visible = false;
            // 
            // labelHeadquarterCity
            // 
            this.labelHeadquarterCity.AutoSize = true;
            this.labelHeadquarterCity.Location = new System.Drawing.Point(90, 124);
            this.labelHeadquarterCity.Name = "labelHeadquarterCity";
            this.labelHeadquarterCity.Size = new System.Drawing.Size(56, 13);
            this.labelHeadquarterCity.TabIndex = 19;
            this.labelHeadquarterCity.Text = "Település:";
            // 
            // textBoxCompanyVATNumber
            // 
            this.textBoxCompanyVATNumber.Location = new System.Drawing.Point(152, 173);
            this.textBoxCompanyVATNumber.Name = "textBoxCompanyVATNumber";
            this.textBoxCompanyVATNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxCompanyVATNumber.TabIndex = 29;
            this.textBoxCompanyVATNumber.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Irányítószám:";
            // 
            // labelHeadquarterAddress
            // 
            this.labelHeadquarterAddress.AutoSize = true;
            this.labelHeadquarterAddress.Location = new System.Drawing.Point(117, 150);
            this.labelHeadquarterAddress.Name = "labelHeadquarterAddress";
            this.labelHeadquarterAddress.Size = new System.Drawing.Size(29, 13);
            this.labelHeadquarterAddress.TabIndex = 21;
            this.labelHeadquarterAddress.Text = "Cím:";
            // 
            // comboBoxHeadquarterCountry
            // 
            this.comboBoxHeadquarterCountry.Enabled = false;
            this.comboBoxHeadquarterCountry.FormattingEnabled = true;
            this.comboBoxHeadquarterCountry.Location = new System.Drawing.Point(152, 68);
            this.comboBoxHeadquarterCountry.Name = "comboBoxHeadquarterCountry";
            this.comboBoxHeadquarterCountry.Size = new System.Drawing.Size(276, 21);
            this.comboBoxHeadquarterCountry.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ország:";
            // 
            // textBoxHeadquarterAddress
            // 
            this.textBoxHeadquarterAddress.Enabled = false;
            this.textBoxHeadquarterAddress.Location = new System.Drawing.Point(152, 147);
            this.textBoxHeadquarterAddress.Name = "textBoxHeadquarterAddress";
            this.textBoxHeadquarterAddress.Size = new System.Drawing.Size(276, 20);
            this.textBoxHeadquarterAddress.TabIndex = 33;
            // 
            // textBoxHeadquarterZipCode
            // 
            this.textBoxHeadquarterZipCode.Enabled = false;
            this.textBoxHeadquarterZipCode.Location = new System.Drawing.Point(152, 95);
            this.textBoxHeadquarterZipCode.Name = "textBoxHeadquarterZipCode";
            this.textBoxHeadquarterZipCode.Size = new System.Drawing.Size(276, 20);
            this.textBoxHeadquarterZipCode.TabIndex = 31;
            // 
            // labelBillingName
            // 
            this.labelBillingName.AutoSize = true;
            this.labelBillingName.Location = new System.Drawing.Point(63, 45);
            this.labelBillingName.Name = "labelBillingName";
            this.labelBillingName.Size = new System.Drawing.Size(83, 13);
            this.labelBillingName.TabIndex = 24;
            this.labelBillingName.Text = "Számlázási név:";
            // 
            // textBoxHeadquarterCity
            // 
            this.textBoxHeadquarterCity.Enabled = false;
            this.textBoxHeadquarterCity.Location = new System.Drawing.Point(152, 121);
            this.textBoxHeadquarterCity.Name = "textBoxHeadquarterCity";
            this.textBoxHeadquarterCity.Size = new System.Drawing.Size(276, 20);
            this.textBoxHeadquarterCity.TabIndex = 32;
            // 
            // groupBoxAdditionalCompanyInfo
            // 
            this.groupBoxAdditionalCompanyInfo.Controls.Add(this.labelCompanyPhoneNumber);
            this.groupBoxAdditionalCompanyInfo.Controls.Add(this.textBoxCompanyEmailAddress);
            this.groupBoxAdditionalCompanyInfo.Controls.Add(this.labelCompanyEmailAddress);
            this.groupBoxAdditionalCompanyInfo.Controls.Add(this.textBoxCompanyPhoneNumber);
            this.groupBoxAdditionalCompanyInfo.Location = new System.Drawing.Point(7, 215);
            this.groupBoxAdditionalCompanyInfo.Name = "groupBoxAdditionalCompanyInfo";
            this.groupBoxAdditionalCompanyInfo.Size = new System.Drawing.Size(433, 95);
            this.groupBoxAdditionalCompanyInfo.TabIndex = 37;
            this.groupBoxAdditionalCompanyInfo.TabStop = false;
            this.groupBoxAdditionalCompanyInfo.Text = "Egyéb adatok";
            this.groupBoxAdditionalCompanyInfo.Visible = false;
            // 
            // labelCompanyPhoneNumber
            // 
            this.labelCompanyPhoneNumber.AutoSize = true;
            this.labelCompanyPhoneNumber.Location = new System.Drawing.Point(75, 31);
            this.labelCompanyPhoneNumber.Name = "labelCompanyPhoneNumber";
            this.labelCompanyPhoneNumber.Size = new System.Drawing.Size(70, 13);
            this.labelCompanyPhoneNumber.TabIndex = 23;
            this.labelCompanyPhoneNumber.Text = "Telefonszám:";
            // 
            // textBoxCompanyEmailAddress
            // 
            this.textBoxCompanyEmailAddress.Location = new System.Drawing.Point(151, 54);
            this.textBoxCompanyEmailAddress.Name = "textBoxCompanyEmailAddress";
            this.textBoxCompanyEmailAddress.Size = new System.Drawing.Size(276, 20);
            this.textBoxCompanyEmailAddress.TabIndex = 35;
            // 
            // labelCompanyEmailAddress
            // 
            this.labelCompanyEmailAddress.AutoSize = true;
            this.labelCompanyEmailAddress.Location = new System.Drawing.Point(107, 61);
            this.labelCompanyEmailAddress.Name = "labelCompanyEmailAddress";
            this.labelCompanyEmailAddress.Size = new System.Drawing.Size(38, 13);
            this.labelCompanyEmailAddress.TabIndex = 25;
            this.labelCompanyEmailAddress.Text = "E-mail:";
            // 
            // textBoxCompanyPhoneNumber
            // 
            this.textBoxCompanyPhoneNumber.Location = new System.Drawing.Point(151, 28);
            this.textBoxCompanyPhoneNumber.Name = "textBoxCompanyPhoneNumber";
            this.textBoxCompanyPhoneNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxCompanyPhoneNumber.TabIndex = 34;
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
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
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
            // labelArrivalDate
            // 
            this.labelArrivalDate.AutoSize = true;
            this.labelArrivalDate.Location = new System.Drawing.Point(98, 78);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(48, 13);
            this.labelArrivalDate.TabIndex = 26;
            this.labelArrivalDate.Text = "Érkezés:";
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
            this.dateTimePickerArrivalDate.Location = new System.Drawing.Point(152, 72);
            this.dateTimePickerArrivalDate.Name = "dateTimePickerArrivalDate";
            this.dateTimePickerArrivalDate.Size = new System.Drawing.Size(276, 20);
            this.dateTimePickerArrivalDate.TabIndex = 30;
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(152, 98);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(276, 20);
            this.dateTimePickerDepartureDate.TabIndex = 31;
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
            this.tabControlGuestRegistrationCard.ResumeLayout(false);
            this.tabPageGuestData.ResumeLayout(false);
            this.groupBoxPersonalData.ResumeLayout(false);
            this.groupBoxPersonalData.PerformLayout();
            this.groupBoxAdditionalInfo.ResumeLayout(false);
            this.groupBoxAdditionalInfo.PerformLayout();
            this.tabPageBillingData.ResumeLayout(false);
            this.groupBoxBillingData.ResumeLayout(false);
            this.groupBoxBillingData.PerformLayout();
            this.groupBoxAdditionalCompanyInfo.ResumeLayout(false);
            this.groupBoxAdditionalCompanyInfo.PerformLayout();
            this.tabPageBookingData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGuests)).EndInit();
            this.groupBoxBookingData.ResumeLayout(false);
            this.groupBoxBookingData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProviderInput;
        private System.Windows.Forms.TabControl tabControlGuestRegistrationCard;
        private System.Windows.Forms.TabPage tabPageGuestData;
        private System.Windows.Forms.TabPage tabPageBillingData;
        private System.Windows.Forms.TabPage tabPageBookingData;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfGuests;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.Label labelArrivalDate;
        private System.Windows.Forms.Label labelNumberOfGuests;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrivalDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        private System.Windows.Forms.CheckBox checkBoxIsCompany;
        private System.Windows.Forms.Label labelVATNumber;
        private System.Windows.Forms.TextBox textBoxCompanyVATNumber;
        private System.Windows.Forms.TextBox textBoxCompanyEmailAddress;
        private System.Windows.Forms.Label labelCompanyPhoneNumber;
        private System.Windows.Forms.TextBox textBoxCompanyPhoneNumber;
        private System.Windows.Forms.Label labelCompanyEmailAddress;
        private System.Windows.Forms.TextBox textBoxHeadquarterZipCode;
        private System.Windows.Forms.TextBox textBoxHeadquarterCity;
        private System.Windows.Forms.Label labelBillingName;
        private System.Windows.Forms.TextBox textBoxHeadquarterAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBillingName;
        private System.Windows.Forms.ComboBox comboBoxHeadquarterCountry;
        private System.Windows.Forms.Label labelHeadquarterAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelHeadquarterCity;
        private System.Windows.Forms.TextBox textBoxGuestEmailAddress;
        private System.Windows.Forms.Label labelGuestPhoneNumber;
        private System.Windows.Forms.Label labelGuestDocumentNumber;
        private System.Windows.Forms.TextBox textBoxGuestPhoneNumber;
        private System.Windows.Forms.Label labelGuestBirthDate;
        private System.Windows.Forms.Label labelGuestEmailAddress;
        private System.Windows.Forms.TextBox textBoxGuestBirthDate;
        private System.Windows.Forms.Label labelGuestCitizenship;
        private System.Windows.Forms.TextBox textBoxGuestDocumentNumber;
        private System.Windows.Forms.TextBox textBoxGuestZipCode;
        private System.Windows.Forms.TextBox textBoxGuestCity;
        private System.Windows.Forms.Label labelGuestName;
        private System.Windows.Forms.TextBox textBoxGuestAddress;
        private System.Windows.Forms.Label labelGuestCountry;
        private System.Windows.Forms.TextBox textBoxGuestName;
        private System.Windows.Forms.TextBox textBoxGuestCitizenship;
        private System.Windows.Forms.ComboBox comboBoxGuestCountry;
        private System.Windows.Forms.Label labelGuestAddress;
        private System.Windows.Forms.Label labelGuestZipCode;
        private System.Windows.Forms.Label labelGuestCity;
        private System.Windows.Forms.GroupBox groupBoxPersonalData;
        private System.Windows.Forms.GroupBox groupBoxAdditionalInfo;
        private System.Windows.Forms.Button buttonImportGuestData;
        private System.Windows.Forms.GroupBox groupBoxBillingData;
        private System.Windows.Forms.GroupBox groupBoxAdditionalCompanyInfo;
        private System.Windows.Forms.Button buttonImportCompanyData;
        private System.Windows.Forms.GroupBox groupBoxBookingData;
    }
}