namespace virtual_receptionist
{
    partial class FormDatabaseConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatabaseConfiguration));
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.comboBoxConnectionType = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(12, 39);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.ReadOnly = true;
            this.textBoxServer.Size = new System.Drawing.Size(217, 20);
            this.textBoxServer.TabIndex = 0;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(12, 143);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.ReadOnly = true;
            this.textBoxPort.Size = new System.Drawing.Size(217, 20);
            this.textBoxPort.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 117);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(217, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(12, 91);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(217, 20);
            this.textBoxUsername.TabIndex = 6;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(12, 65);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.ReadOnly = true;
            this.textBoxDatabase.Size = new System.Drawing.Size(217, 20);
            this.textBoxDatabase.TabIndex = 7;
            // 
            // comboBoxConnectionType
            // 
            this.comboBoxConnectionType.FormattingEnabled = true;
            this.comboBoxConnectionType.Items.AddRange(new object[] {
            "Helyi",
            "Távoli"});
            this.comboBoxConnectionType.Location = new System.Drawing.Point(12, 12);
            this.comboBoxConnectionType.Name = "comboBoxConnectionType";
            this.comboBoxConnectionType.Size = new System.Drawing.Size(217, 21);
            this.comboBoxConnectionType.TabIndex = 8;
            this.comboBoxConnectionType.SelectedIndexChanged += new System.EventHandler(this.comboBoxConnectionType_SelectedIndexChanged);
            // 
            // buttonConnect
            // 
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConnect.Image = ((System.Drawing.Image)(resources.GetObject("buttonConnect.Image")));
            this.buttonConnect.Location = new System.Drawing.Point(235, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(217, 151);
            this.buttonConnect.TabIndex = 9;
            this.buttonConnect.Text = "Csatlakozás";
            this.buttonConnect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // FormDatabaseConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 169);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxConnectionType);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDatabaseConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adatbázis konfiguráció | Virtual Receptionist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.ComboBox comboBoxConnectionType;
        private System.Windows.Forms.Button buttonConnect;
    }
}