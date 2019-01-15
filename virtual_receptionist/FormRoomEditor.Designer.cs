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
            this.tabControlRoomEditor = new System.Windows.Forms.TabControl();
            this.tabPageReservations = new System.Windows.Forms.TabPage();
            this.tabPageRooms = new System.Windows.Forms.TabPage();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomRents)).BeginInit();
            this.tabControlRoomEditor.SuspendLayout();
            this.tabPageReservations.SuspendLayout();
            this.tabPageRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonBackToMainMenu.Image")));
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(797, 613);
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
            this.dataGridViewRoomRents.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewRoomRents.Name = "dataGridViewRoomRents";
            this.dataGridViewRoomRents.Size = new System.Drawing.Size(922, 557);
            this.dataGridViewRoomRents.TabIndex = 7;
            // 
            // tabControlRoomEditor
            // 
            this.tabControlRoomEditor.Controls.Add(this.tabPageReservations);
            this.tabControlRoomEditor.Controls.Add(this.tabPageRooms);
            this.tabControlRoomEditor.Location = new System.Drawing.Point(12, 12);
            this.tabControlRoomEditor.Name = "tabControlRoomEditor";
            this.tabControlRoomEditor.SelectedIndex = 0;
            this.tabControlRoomEditor.Size = new System.Drawing.Size(942, 595);
            this.tabControlRoomEditor.TabIndex = 8;
            // 
            // tabPageReservations
            // 
            this.tabPageReservations.Controls.Add(this.dataGridViewRoomRents);
            this.tabPageReservations.Location = new System.Drawing.Point(4, 22);
            this.tabPageReservations.Name = "tabPageReservations";
            this.tabPageReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReservations.Size = new System.Drawing.Size(934, 569);
            this.tabPageReservations.TabIndex = 0;
            this.tabPageReservations.Text = "Szobakiadások";
            this.tabPageReservations.UseVisualStyleBackColor = true;
            // 
            // tabPageRooms
            // 
            this.tabPageRooms.Controls.Add(this.dataGridViewRooms);
            this.tabPageRooms.Location = new System.Drawing.Point(4, 22);
            this.tabPageRooms.Name = "tabPageRooms";
            this.tabPageRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRooms.Size = new System.Drawing.Size(934, 569);
            this.tabPageRooms.TabIndex = 1;
            this.tabPageRooms.Text = "Szobák";
            this.tabPageRooms.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.Size = new System.Drawing.Size(922, 557);
            this.dataGridViewRooms.TabIndex = 0;
            // 
            // FormRoomEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 690);
            this.Controls.Add(this.tabControlRoomEditor);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRoomEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szoba kezelő | Virtual Receptionist";
            this.Load += new System.EventHandler(this.FormRoomEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomRents)).EndInit();
            this.tabControlRoomEditor.ResumeLayout(false);
            this.tabPageReservations.ResumeLayout(false);
            this.tabPageRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.DataGridView dataGridViewRoomRents;
        private System.Windows.Forms.TabControl tabControlRoomEditor;
        private System.Windows.Forms.TabPage tabPageReservations;
        private System.Windows.Forms.TabPage tabPageRooms;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
    }
}