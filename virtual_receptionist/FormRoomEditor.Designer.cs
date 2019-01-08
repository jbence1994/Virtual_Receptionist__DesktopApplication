namespace virtual_receptionist.View
{
    partial class FormRoomEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoomEditor));
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.dataGridViewRoomRents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomRents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonBackToMainMenu.Image")));
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(466, 494);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(157, 64);
            this.buttonBackToMainMenu.TabIndex = 6;
            this.buttonBackToMainMenu.Text = "Vissza a főmenübe";
            this.buttonBackToMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBackToMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // dataGridViewRoomRents
            // 
            this.dataGridViewRoomRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoomRents.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewRoomRents.Name = "dataGridViewRoomRents";
            this.dataGridViewRoomRents.Size = new System.Drawing.Size(610, 475);
            this.dataGridViewRoomRents.TabIndex = 7;
            // 
            // FormRoomEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 570);
            this.Controls.Add(this.dataGridViewRoomRents);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRoomEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szobakiadás kezelő | Virtual Receptionist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomRents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.DataGridView dataGridViewRoomRents;
    }
}