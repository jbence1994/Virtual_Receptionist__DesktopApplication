namespace virtual_receptionist
{
    partial class FormModalBilling
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.checkBoxCorporateGuest = new System.Windows.Forms.CheckBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelVatNumber = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.textBoxVatNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(286, 247);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 52;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 247);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 51;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // checkBoxCorporateGuest
            // 
            this.checkBoxCorporateGuest.AutoSize = true;
            this.checkBoxCorporateGuest.Location = new System.Drawing.Point(126, 194);
            this.checkBoxCorporateGuest.Name = "checkBoxCorporateGuest";
            this.checkBoxCorporateGuest.Size = new System.Drawing.Size(141, 17);
            this.checkBoxCorporateGuest.TabIndex = 50;
            this.checkBoxCorporateGuest.Text = "A vendég vállalati ügyfél";
            this.checkBoxCorporateGuest.UseVisualStyleBackColor = true;
            this.checkBoxCorporateGuest.CheckedChanged += new System.EventHandler(this.checkBoxCorporateGuest_CheckedChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(91, 145);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(29, 13);
            this.labelAddress.TabIndex = 47;
            this.labelAddress.Text = "Cím:";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(50, 93);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(70, 13);
            this.labelZipCode.TabIndex = 46;
            this.labelZipCode.Text = "Irányítószám:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(77, 66);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 45;
            this.labelCountry.Text = "Ország:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(64, 119);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(56, 13);
            this.labelCity.TabIndex = 44;
            this.labelCity.Text = "Település:";
            // 
            // labelVatNumber
            // 
            this.labelVatNumber.AutoSize = true;
            this.labelVatNumber.Location = new System.Drawing.Point(67, 171);
            this.labelVatNumber.Name = "labelVatNumber";
            this.labelVatNumber.Size = new System.Drawing.Size(53, 13);
            this.labelVatNumber.TabIndex = 43;
            this.labelVatNumber.Text = "Adószám:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(46, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 13);
            this.labelName.TabIndex = 41;
            this.labelName.Text = "Vendég neve:";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(126, 63);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(185, 21);
            this.comboBoxCountry.TabIndex = 37;
            // 
            // textBoxVatNumber
            // 
            this.textBoxVatNumber.Location = new System.Drawing.Point(126, 168);
            this.textBoxVatNumber.Name = "textBoxVatNumber";
            this.textBoxVatNumber.ReadOnly = true;
            this.textBoxVatNumber.Size = new System.Drawing.Size(185, 20);
            this.textBoxVatNumber.TabIndex = 35;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(126, 142);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(185, 20);
            this.textBoxAddress.TabIndex = 34;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(126, 116);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(185, 20);
            this.textBoxCity.TabIndex = 33;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(126, 90);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(185, 20);
            this.textBoxZipCode.TabIndex = 32;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(126, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(185, 20);
            this.textBoxName.TabIndex = 31;
            // 
            // FormModalBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 282);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBoxCorporateGuest);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelVatNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.textBoxVatNumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxZipCode);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormModalBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ügyfél adatai | Virtual Receptionist";
            this.Load += new System.EventHandler(this.FormModalBilling_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.CheckBox checkBoxCorporateGuest;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelVatNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.TextBox textBoxVatNumber;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.TextBox textBoxName;
    }
}