namespace virtual_receptionist
{
    partial class FormMainMenu
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
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.statusStripMainMenu = new System.Windows.Forms.StatusStrip();
            this.buttonRoomEditor = new System.Windows.Forms.Button();
            this.buttonGuestDatabase = new System.Windows.Forms.Button();
            this.buttonBilling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Size = new System.Drawing.Size(637, 24);
            this.menuStripMainMenu.TabIndex = 0;
            // 
            // statusStripMainMenu
            // 
            this.statusStripMainMenu.Location = new System.Drawing.Point(0, 463);
            this.statusStripMainMenu.Name = "statusStripMainMenu";
            this.statusStripMainMenu.Size = new System.Drawing.Size(637, 22);
            this.statusStripMainMenu.TabIndex = 1;
            // 
            // buttonRoomEditor
            // 
            this.buttonRoomEditor.Location = new System.Drawing.Point(12, 27);
            this.buttonRoomEditor.Name = "buttonRoomEditor";
            this.buttonRoomEditor.Size = new System.Drawing.Size(152, 44);
            this.buttonRoomEditor.TabIndex = 2;
            this.buttonRoomEditor.Text = "Foglalások kezelése";
            this.buttonRoomEditor.UseVisualStyleBackColor = true;
            this.buttonRoomEditor.Click += new System.EventHandler(this.buttonRoomEditor_Click);
            // 
            // buttonGuestDatabase
            // 
            this.buttonGuestDatabase.Location = new System.Drawing.Point(12, 77);
            this.buttonGuestDatabase.Name = "buttonGuestDatabase";
            this.buttonGuestDatabase.Size = new System.Drawing.Size(152, 44);
            this.buttonGuestDatabase.TabIndex = 3;
            this.buttonGuestDatabase.Text = "Vendégnyilvántartás";
            this.buttonGuestDatabase.UseVisualStyleBackColor = true;
            this.buttonGuestDatabase.Click += new System.EventHandler(this.buttonGuestDatabase_Click);
            // 
            // buttonBilling
            // 
            this.buttonBilling.Location = new System.Drawing.Point(12, 127);
            this.buttonBilling.Name = "buttonBilling";
            this.buttonBilling.Size = new System.Drawing.Size(152, 44);
            this.buttonBilling.TabIndex = 4;
            this.buttonBilling.Text = "Számla kiállítása";
            this.buttonBilling.UseVisualStyleBackColor = true;
            this.buttonBilling.Click += new System.EventHandler(this.buttonBilling_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 485);
            this.Controls.Add(this.buttonBilling);
            this.Controls.Add(this.buttonGuestDatabase);
            this.Controls.Add(this.buttonRoomEditor);
            this.Controls.Add(this.statusStripMainMenu);
            this.Controls.Add(this.menuStripMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMainMenu;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü | Virtual Receptionist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.StatusStrip statusStripMainMenu;
        private System.Windows.Forms.Button buttonRoomEditor;
        private System.Windows.Forms.Button buttonGuestDatabase;
        private System.Windows.Forms.Button buttonBilling;
    }
}