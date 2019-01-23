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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSaveToDatabase = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelIDCardOrPassportNumber = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxIDCardOrPassportNumber = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(270, 627);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(179, 23);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Félbehagyás";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSaveToDatabase
            // 
            this.buttonSaveToDatabase.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveToDatabase.Location = new System.Drawing.Point(270, 569);
            this.buttonSaveToDatabase.Name = "buttonSaveToDatabase";
            this.buttonSaveToDatabase.Size = new System.Drawing.Size(179, 23);
            this.buttonSaveToDatabase.TabIndex = 27;
            this.buttonSaveToDatabase.Text = "Vendég mentése adatbázisba";
            this.buttonSaveToDatabase.UseVisualStyleBackColor = true;
            this.buttonSaveToDatabase.Click += new System.EventHandler(this.buttonSaveToDatabase_Click);
            // 
            // checkBoxCorporateGuest
            // 
            this.checkBoxCorporateGuest.AutoSize = true;
            this.checkBoxCorporateGuest.Location = new System.Drawing.Point(235, 151);
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
            this.labelAddress.Location = new System.Drawing.Point(200, 102);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(29, 13);
            this.labelAddress.TabIndex = 17;
            this.labelAddress.Text = "Cím:";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(159, 49);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(70, 13);
            this.labelZipCode.TabIndex = 13;
            this.labelZipCode.Text = "Irányítószám:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(186, 22);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 11;
            this.labelCountry.Text = "Ország:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(173, 77);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(56, 13);
            this.labelCity.TabIndex = 15;
            this.labelCity.Text = "Település:";
            // 
            // labelVatNumber
            // 
            this.labelVatNumber.AutoSize = true;
            this.labelVatNumber.Location = new System.Drawing.Point(176, 128);
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
            this.comboBoxCountry.Location = new System.Drawing.Point(235, 19);
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
            this.textBoxVatNumber.Location = new System.Drawing.Point(235, 125);
            this.textBoxVatNumber.Name = "textBoxVatNumber";
            this.textBoxVatNumber.ReadOnly = true;
            this.textBoxVatNumber.Size = new System.Drawing.Size(276, 20);
            this.textBoxVatNumber.TabIndex = 20;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(235, 99);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(276, 20);
            this.textBoxAddress.TabIndex = 18;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(235, 72);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(276, 20);
            this.textBoxCity.TabIndex = 16;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(235, 46);
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
            this.labelTitle.Location = new System.Drawing.Point(229, 28);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelIDCardOrPassportNumber);
            this.groupBox1.Controls.Add(this.labelBirthDate);
            this.groupBox1.Controls.Add(this.textBoxBirthDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxIDCardOrPassportNumber);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxCitizenship);
            this.groupBox1.Location = new System.Drawing.Point(76, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Általános adatok";
            // 
            // labelIDCardOrPassportNumber
            // 
            this.labelIDCardOrPassportNumber.AutoSize = true;
            this.labelIDCardOrPassportNumber.Location = new System.Drawing.Point(15, 100);
            this.labelIDCardOrPassportNumber.Name = "labelIDCardOrPassportNumber";
            this.labelIDCardOrPassportNumber.Size = new System.Drawing.Size(214, 13);
            this.labelIDCardOrPassportNumber.TabIndex = 8;
            this.labelIDCardOrPassportNumber.Text = "Személyi igazolvány száma / Útlevél száma:";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxVatNumber);
            this.groupBox2.Controls.Add(this.labelVatNumber);
            this.groupBox2.Controls.Add(this.checkBoxCorporateGuest);
            this.groupBox2.Controls.Add(this.textBoxZipCode);
            this.groupBox2.Controls.Add(this.textBoxCity);
            this.groupBox2.Controls.Add(this.textBoxAddress);
            this.groupBox2.Controls.Add(this.labelCountry);
            this.groupBox2.Controls.Add(this.labelAddress);
            this.groupBox2.Controls.Add(this.comboBoxCountry);
            this.groupBox2.Controls.Add(this.labelCity);
            this.groupBox2.Controls.Add(this.labelZipCode);
            this.groupBox2.Location = new System.Drawing.Point(76, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 183);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Számlázási adatok";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxEmailAddress);
            this.groupBox3.Controls.Add(this.labelPhoneNumber);
            this.groupBox3.Controls.Add(this.textBoxPhoneNumber);
            this.groupBox3.Controls.Add(this.labelEmailAddress);
            this.groupBox3.Location = new System.Drawing.Point(76, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 100);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Egyéb adatok";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(270, 598);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(179, 23);
            this.buttonOK.TabIndex = 28;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormGuestRegistrationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveToDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGuestRegistrationCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendég bejelentkező lap kitöltése | Virtual Receptionist";
            this.Load += new System.EventHandler(this.FormGuestRegistrationCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSaveToDatabase;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxIDCardOrPassportNumber;
        private System.Windows.Forms.Label labelIDCardOrPassportNumber;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.Button buttonOK;
    }
}