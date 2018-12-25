namespace virtual_receptionist
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxAccomodationID = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAccomodationID = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConnectionType = new System.Windows.Forms.Label();
            this.comboBoxConnectionType = new System.Windows.Forms.ComboBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Enabled = false;
            this.buttonLogin.Location = new System.Drawing.Point(265, 162);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(214, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Bejelentkezés";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxAccomodationID
            // 
            this.textBoxAccomodationID.Location = new System.Drawing.Point(265, 83);
            this.textBoxAccomodationID.Name = "textBoxAccomodationID";
            this.textBoxAccomodationID.Size = new System.Drawing.Size(214, 20);
            this.textBoxAccomodationID.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(265, 109);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(214, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(145, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(207, 29);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Virtual Receptionist";
            // 
            // labelAccomodationID
            // 
            this.labelAccomodationID.AutoSize = true;
            this.labelAccomodationID.Location = new System.Drawing.Point(147, 86);
            this.labelAccomodationID.Name = "labelAccomodationID";
            this.labelAccomodationID.Size = new System.Drawing.Size(112, 13);
            this.labelAccomodationID.TabIndex = 4;
            this.labelAccomodationID.Text = "Szálláshely azonosító:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(220, 112);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(39, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Jelszó:";
            // 
            // labelConnectionType
            // 
            this.labelConnectionType.AutoSize = true;
            this.labelConnectionType.Location = new System.Drawing.Point(161, 138);
            this.labelConnectionType.Name = "labelConnectionType";
            this.labelConnectionType.Size = new System.Drawing.Size(98, 13);
            this.labelConnectionType.TabIndex = 6;
            this.labelConnectionType.Text = "Csatlakozás módja:";
            // 
            // comboBoxConnectionType
            // 
            this.comboBoxConnectionType.FormattingEnabled = true;
            this.comboBoxConnectionType.Items.AddRange(new object[] {
            "Helyi kiszolgálóhoz .xml állományból",
            "Helyi kiszolgálóhoz .txt állományból",
            "Távoli kiszolgálóhoz .xml állományból",
            "Távoli kiszolgálóhoz .txt állományból"});
            this.comboBoxConnectionType.Location = new System.Drawing.Point(265, 135);
            this.comboBoxConnectionType.Name = "comboBoxConnectionType";
            this.comboBoxConnectionType.Size = new System.Drawing.Size(214, 21);
            this.comboBoxConnectionType.TabIndex = 7;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 228);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(597, 37);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Enabled = false;
            this.labelCopyright.Location = new System.Drawing.Point(450, 268);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(159, 13);
            this.labelCopyright.TabIndex = 9;
            this.labelCopyright.Text = "Copyright @ Juász Bence 2019.";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 290);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.comboBoxConnectionType);
            this.Controls.Add(this.labelConnectionType);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelAccomodationID);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxAccomodationID);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés | Virtual Receptionist";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxAccomodationID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAccomodationID;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConnectionType;
        private System.Windows.Forms.ComboBox comboBoxConnectionType;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelCopyright;
    }
}

