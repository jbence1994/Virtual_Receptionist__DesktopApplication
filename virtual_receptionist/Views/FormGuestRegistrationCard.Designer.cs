﻿namespace virtual_receptionist.View
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
            this.buttonCancel = new System.Windows.Forms.Button();
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCitizenship = new System.Windows.Forms.TextBox();
            this.groupBoxGeneralData = new System.Windows.Forms.GroupBox();
            this.labelIDCardOrPassportNumber = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxIDCardOrPassportNumber = new System.Windows.Forms.TextBox();
            this.groupBoxBillingData = new System.Windows.Forms.GroupBox();
            this.groupBoxOtherData = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelBillingName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.groupBoxGeneralData.SuspendLayout();
            this.groupBoxBillingData.SuspendLayout();
            this.groupBoxOtherData.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(76, 614);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(517, 23);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Félbehagyás";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxCorporateGuest
            // 
            this.checkBoxCorporateGuest.AutoSize = true;
            this.checkBoxCorporateGuest.Location = new System.Drawing.Point(235, 181);
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
            this.labelEmailAddress.Location = new System.Drawing.Point(191, 48);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(38, 13);
            this.labelEmailAddress.TabIndex = 25;
            this.labelEmailAddress.Text = "E-mail:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(159, 22);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(70, 13);
            this.labelPhoneNumber.TabIndex = 23;
            this.labelPhoneNumber.Text = "Telefonszám:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(200, 132);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(29, 13);
            this.labelAddress.TabIndex = 17;
            this.labelAddress.Text = "Cím:";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(159, 79);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(70, 13);
            this.labelZipCode.TabIndex = 13;
            this.labelZipCode.Text = "Irányítószám:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(186, 52);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 11;
            this.labelCountry.Text = "Ország:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(173, 107);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(56, 13);
            this.labelCity.TabIndex = 15;
            this.labelCity.Text = "Település:";
            // 
            // labelVatNumber
            // 
            this.labelVatNumber.AutoSize = true;
            this.labelVatNumber.Location = new System.Drawing.Point(176, 158);
            this.labelVatNumber.Name = "labelVatNumber";
            this.labelVatNumber.Size = new System.Drawing.Size(53, 13);
            this.labelVatNumber.TabIndex = 19;
            this.labelVatNumber.Text = "Adószám:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(155, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Vendég neve:";
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(235, 45);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(276, 20);
            this.textBoxEmailAddress.TabIndex = 26;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(235, 49);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(276, 21);
            this.comboBoxCountry.TabIndex = 12;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(235, 19);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxPhoneNumber.TabIndex = 24;
            // 
            // textBoxVatNumber
            // 
            this.textBoxVatNumber.Location = new System.Drawing.Point(235, 155);
            this.textBoxVatNumber.Name = "textBoxVatNumber";
            this.textBoxVatNumber.ReadOnly = true;
            this.textBoxVatNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxVatNumber.TabIndex = 20;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(235, 129);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(276, 20);
            this.textBoxAddress.TabIndex = 18;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(235, 102);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(276, 20);
            this.textBoxCity.TabIndex = 16;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(235, 76);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(276, 20);
            this.textBoxZipCode.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(235, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(276, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(71, 36);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(243, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Vendég bejelentő lap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Állampolgárság:";
            // 
            // textBoxCitizenship
            // 
            this.textBoxCitizenship.Location = new System.Drawing.Point(235, 45);
            this.textBoxCitizenship.Name = "textBoxCitizenship";
            this.textBoxCitizenship.Size = new System.Drawing.Size(276, 20);
            this.textBoxCitizenship.TabIndex = 5;
            // 
            // groupBoxGeneralData
            // 
            this.groupBoxGeneralData.Controls.Add(this.dateTimePickerDepartureDate);
            this.groupBoxGeneralData.Controls.Add(this.dateTimePickerArrivalDate);
            this.groupBoxGeneralData.Controls.Add(this.labelDepartureDate);
            this.groupBoxGeneralData.Controls.Add(this.labelArrivalDate);
            this.groupBoxGeneralData.Controls.Add(this.labelIDCardOrPassportNumber);
            this.groupBoxGeneralData.Controls.Add(this.labelBirthDate);
            this.groupBoxGeneralData.Controls.Add(this.textBoxBirthDate);
            this.groupBoxGeneralData.Controls.Add(this.label1);
            this.groupBoxGeneralData.Controls.Add(this.textBoxIDCardOrPassportNumber);
            this.groupBoxGeneralData.Controls.Add(this.labelName);
            this.groupBoxGeneralData.Controls.Add(this.textBoxName);
            this.groupBoxGeneralData.Controls.Add(this.textBoxCitizenship);
            this.groupBoxGeneralData.Location = new System.Drawing.Point(76, 93);
            this.groupBoxGeneralData.Name = "groupBoxGeneralData";
            this.groupBoxGeneralData.Size = new System.Drawing.Size(517, 186);
            this.groupBoxGeneralData.TabIndex = 1;
            this.groupBoxGeneralData.TabStop = false;
            this.groupBoxGeneralData.Text = "Általános adatok";
            // 
            // labelIDCardOrPassportNumber
            // 
            this.labelIDCardOrPassportNumber.AutoSize = true;
            this.labelIDCardOrPassportNumber.Location = new System.Drawing.Point(17, 100);
            this.labelIDCardOrPassportNumber.Name = "labelIDCardOrPassportNumber";
            this.labelIDCardOrPassportNumber.Size = new System.Drawing.Size(212, 13);
            this.labelIDCardOrPassportNumber.TabIndex = 8;
            this.labelIDCardOrPassportNumber.Text = "Személyi igazolvány száma / útlevél száma:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(160, 74);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(69, 13);
            this.labelBirthDate.TabIndex = 6;
            this.labelBirthDate.Text = "Születési idő:";
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Location = new System.Drawing.Point(235, 71);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.Size = new System.Drawing.Size(276, 20);
            this.textBoxBirthDate.TabIndex = 7;
            // 
            // textBoxIDCardOrPassportNumber
            // 
            this.textBoxIDCardOrPassportNumber.Location = new System.Drawing.Point(235, 97);
            this.textBoxIDCardOrPassportNumber.Name = "textBoxIDCardOrPassportNumber";
            this.textBoxIDCardOrPassportNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxIDCardOrPassportNumber.TabIndex = 9;
            // 
            // groupBoxBillingData
            // 
            this.groupBoxBillingData.Controls.Add(this.textBox1);
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
            this.groupBoxBillingData.Location = new System.Drawing.Point(76, 285);
            this.groupBoxBillingData.Name = "groupBoxBillingData";
            this.groupBoxBillingData.Size = new System.Drawing.Size(517, 210);
            this.groupBoxBillingData.TabIndex = 10;
            this.groupBoxBillingData.TabStop = false;
            this.groupBoxBillingData.Text = "Számlázási adatok";
            // 
            // groupBoxOtherData
            // 
            this.groupBoxOtherData.Controls.Add(this.textBoxEmailAddress);
            this.groupBoxOtherData.Controls.Add(this.labelPhoneNumber);
            this.groupBoxOtherData.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxOtherData.Controls.Add(this.labelEmailAddress);
            this.groupBoxOtherData.Location = new System.Drawing.Point(76, 501);
            this.groupBoxOtherData.Name = "groupBoxOtherData";
            this.groupBoxOtherData.Size = new System.Drawing.Size(517, 78);
            this.groupBoxOtherData.TabIndex = 22;
            this.groupBoxOtherData.TabStop = false;
            this.groupBoxOtherData.Text = "Egyéb adatok";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(76, 585);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(517, 23);
            this.buttonOK.TabIndex = 28;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelBillingName
            // 
            this.labelBillingName.AutoSize = true;
            this.labelBillingName.Location = new System.Drawing.Point(199, 26);
            this.labelBillingName.Name = "labelBillingName";
            this.labelBillingName.Size = new System.Drawing.Size(30, 13);
            this.labelBillingName.TabIndex = 22;
            this.labelBillingName.Text = "Név:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 23;
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(235, 150);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(276, 20);
            this.dateTimePickerDepartureDate.TabIndex = 35;
            // 
            // dateTimePickerArrivalDate
            // 
            this.dateTimePickerArrivalDate.Location = new System.Drawing.Point(235, 123);
            this.dateTimePickerArrivalDate.Name = "dateTimePickerArrivalDate";
            this.dateTimePickerArrivalDate.Size = new System.Drawing.Size(276, 20);
            this.dateTimePickerArrivalDate.TabIndex = 34;
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.AutoSize = true;
            this.labelDepartureDate.Location = new System.Drawing.Point(178, 156);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(51, 13);
            this.labelDepartureDate.TabIndex = 33;
            this.labelDepartureDate.Text = "Távozás:";
            // 
            // labelArrivalDate
            // 
            this.labelArrivalDate.AutoSize = true;
            this.labelArrivalDate.Location = new System.Drawing.Point(181, 129);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(48, 13);
            this.labelArrivalDate.TabIndex = 32;
            this.labelArrivalDate.Text = "Érkezés:";
            // 
            // FormGuestRegistrationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 661);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxOtherData);
            this.Controls.Add(this.groupBoxBillingData);
            this.Controls.Add(this.groupBoxGeneralData);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGuestRegistrationCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendég bejelentkező lap kitöltése | Virtual Receptionist";
            this.Load += new System.EventHandler(this.FormGuestRegistrationCard_Load);
            this.groupBoxGeneralData.ResumeLayout(false);
            this.groupBoxGeneralData.PerformLayout();
            this.groupBoxBillingData.ResumeLayout(false);
            this.groupBoxBillingData.PerformLayout();
            this.groupBoxOtherData.ResumeLayout(false);
            this.groupBoxOtherData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
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
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCitizenship;
        private System.Windows.Forms.GroupBox groupBoxGeneralData;
        private System.Windows.Forms.GroupBox groupBoxBillingData;
        private System.Windows.Forms.GroupBox groupBoxOtherData;
        private System.Windows.Forms.TextBox textBoxIDCardOrPassportNumber;
        private System.Windows.Forms.Label labelIDCardOrPassportNumber;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelBillingName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrivalDate;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.Label labelArrivalDate;
    }
}