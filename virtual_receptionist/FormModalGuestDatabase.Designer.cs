namespace virtual_receptionist
{
    partial class FormModalGuestDatabase
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxVatNumber = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.radioButtonNational = new System.Windows.Forms.RadioButton();
            this.radioButtonForeign = new System.Windows.Forms.RadioButton();
            this.radioButtonCorporate = new System.Windows.Forms.RadioButton();
            this.radioButtonPrivate = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(232, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(185, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(232, 180);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(185, 20);
            this.textBoxZipCode.TabIndex = 3;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(232, 206);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(185, 20);
            this.textBoxCity.TabIndex = 4;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(232, 232);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(185, 20);
            this.textBoxAddress.TabIndex = 5;
            // 
            // textBoxVatNumber
            // 
            this.textBoxVatNumber.Location = new System.Drawing.Point(232, 127);
            this.textBoxVatNumber.Name = "textBoxVatNumber";
            this.textBoxVatNumber.Size = new System.Drawing.Size(185, 20);
            this.textBoxVatNumber.TabIndex = 6;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(232, 258);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(185, 20);
            this.textBoxPhoneNumber.TabIndex = 7;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(232, 153);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(185, 21);
            this.comboBoxCountry.TabIndex = 8;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(232, 310);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(342, 310);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(232, 284);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(185, 20);
            this.textBoxEmailAddress.TabIndex = 11;
            // 
            // radioButtonNational
            // 
            this.radioButtonNational.AutoSize = true;
            this.radioButtonNational.Location = new System.Drawing.Point(232, 81);
            this.radioButtonNational.Name = "radioButtonNational";
            this.radioButtonNational.Size = new System.Drawing.Size(58, 17);
            this.radioButtonNational.TabIndex = 12;
            this.radioButtonNational.TabStop = true;
            this.radioButtonNational.Text = "belföldi";
            this.radioButtonNational.UseVisualStyleBackColor = true;
            // 
            // radioButtonForeign
            // 
            this.radioButtonForeign.AutoSize = true;
            this.radioButtonForeign.Location = new System.Drawing.Point(296, 81);
            this.radioButtonForeign.Name = "radioButtonForeign";
            this.radioButtonForeign.Size = new System.Drawing.Size(58, 17);
            this.radioButtonForeign.TabIndex = 13;
            this.radioButtonForeign.TabStop = true;
            this.radioButtonForeign.Text = "külföldi";
            this.radioButtonForeign.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorporate
            // 
            this.radioButtonCorporate.AutoSize = true;
            this.radioButtonCorporate.Location = new System.Drawing.Point(326, 104);
            this.radioButtonCorporate.Name = "radioButtonCorporate";
            this.radioButtonCorporate.Size = new System.Drawing.Size(91, 17);
            this.radioButtonCorporate.TabIndex = 16;
            this.radioButtonCorporate.TabStop = true;
            this.radioButtonCorporate.Text = "vállalati ügyfél";
            this.radioButtonCorporate.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrivate
            // 
            this.radioButtonPrivate.AutoSize = true;
            this.radioButtonPrivate.Location = new System.Drawing.Point(232, 104);
            this.radioButtonPrivate.Name = "radioButtonPrivate";
            this.radioButtonPrivate.Size = new System.Drawing.Size(88, 17);
            this.radioButtonPrivate.TabIndex = 17;
            this.radioButtonPrivate.TabStop = true;
            this.radioButtonPrivate.Text = "magán ügyfél";
            this.radioButtonPrivate.UseVisualStyleBackColor = true;
            // 
            // FormModalGuestDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 461);
            this.Controls.Add(this.radioButtonPrivate);
            this.Controls.Add(this.radioButtonCorporate);
            this.Controls.Add(this.radioButtonForeign);
            this.Controls.Add(this.radioButtonNational);
            this.Controls.Add(this.textBoxEmailAddress);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxVatNumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxZipCode);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormModalGuestDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendég hozzáadása / módosítása | Virtual Receptionist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxVatNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.RadioButton radioButtonNational;
        private System.Windows.Forms.RadioButton radioButtonForeign;
        private System.Windows.Forms.RadioButton radioButtonCorporate;
        private System.Windows.Forms.RadioButton radioButtonPrivate;
    }
}