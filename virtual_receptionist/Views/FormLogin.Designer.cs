namespace virtual_receptionist.Views
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
            this.pictureBoxBinarySoftwareLogo = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.pictureBoxVRLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxAccomodationID = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelAccomodationID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBinarySoftwareLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVRLogo)).BeginInit();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBinarySoftwareLogo
            // 
            this.pictureBoxBinarySoftwareLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxBinarySoftwareLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBinarySoftwareLogo.Image")));
            this.pictureBoxBinarySoftwareLogo.Location = new System.Drawing.Point(462, 324);
            this.pictureBoxBinarySoftwareLogo.Name = "pictureBoxBinarySoftwareLogo";
            this.pictureBoxBinarySoftwareLogo.Size = new System.Drawing.Size(294, 227);
            this.pictureBoxBinarySoftwareLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBinarySoftwareLogo.TabIndex = 0;
            this.pictureBoxBinarySoftwareLogo.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Enabled = false;
            this.labelTitle.Location = new System.Drawing.Point(12, 554);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(122, 13);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Virtual Receptionist v1.0";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Enabled = false;
            this.labelCopyright.Location = new System.Drawing.Point(459, 554);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(297, 13);
            this.labelCopyright.TabIndex = 12;
            this.labelCopyright.Text = "Copyright ©️ 2019 Binary Software, Inc. Minden jog fenntartva";
            // 
            // pictureBoxVRLogo
            // 
            this.pictureBoxVRLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVRLogo.Image")));
            this.pictureBoxVRLogo.Location = new System.Drawing.Point(15, 12);
            this.pictureBoxVRLogo.Name = "pictureBoxVRLogo";
            this.pictureBoxVRLogo.Size = new System.Drawing.Size(741, 306);
            this.pictureBoxVRLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVRLogo.TabIndex = 13;
            this.pictureBoxVRLogo.TabStop = false;
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.buttonExit);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.labelPassword);
            this.groupBoxLogin.Controls.Add(this.textBoxAccomodationID);
            this.groupBoxLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxLogin.Controls.Add(this.labelAccomodationID);
            this.groupBoxLogin.Location = new System.Drawing.Point(15, 324);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(441, 227);
            this.groupBoxLogin.TabIndex = 14;
            this.groupBoxLogin.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(175, 179);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(214, 23);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Kilépés";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(175, 150);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(214, 23);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.Text = "Bejelentkezés";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(130, 100);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(39, 13);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Jelszó:";
            // 
            // textBoxAccomodationID
            // 
            this.textBoxAccomodationID.Location = new System.Drawing.Point(175, 71);
            this.textBoxAccomodationID.Name = "textBoxAccomodationID";
            this.textBoxAccomodationID.Size = new System.Drawing.Size(214, 20);
            this.textBoxAccomodationID.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(175, 97);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(214, 20);
            this.textBoxPassword.TabIndex = 8;
            // 
            // labelAccomodationID
            // 
            this.labelAccomodationID.AutoSize = true;
            this.labelAccomodationID.Location = new System.Drawing.Point(57, 74);
            this.labelAccomodationID.Name = "labelAccomodationID";
            this.labelAccomodationID.Size = new System.Drawing.Size(112, 13);
            this.labelAccomodationID.TabIndex = 11;
            this.labelAccomodationID.Text = "Szálláshely azonosító:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 576);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxVRLogo);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxBinarySoftwareLogo);
            this.Controls.Add(this.groupBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés | Virtual Receptionist";
            this.Load += new System.EventHandler(this.FormApplicationOpening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBinarySoftwareLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVRLogo)).EndInit();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBinarySoftwareLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.PictureBox pictureBoxVRLogo;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxAccomodationID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelAccomodationID;
        private System.Windows.Forms.Button buttonExit;
    }
}