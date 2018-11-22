namespace virtual_receptionist
{
    partial class FormGuestDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuestDatabase));
            this.listViewGuests = new System.Windows.Forms.ListView();
            this.buttonAddGuest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewGuests
            // 
            this.listViewGuests.FullRowSelect = true;
            this.listViewGuests.GridLines = true;
            this.listViewGuests.Location = new System.Drawing.Point(13, 13);
            this.listViewGuests.Name = "listViewGuests";
            this.listViewGuests.Size = new System.Drawing.Size(516, 504);
            this.listViewGuests.TabIndex = 0;
            this.listViewGuests.UseCompatibleStateImageBehavior = false;
            this.listViewGuests.View = System.Windows.Forms.View.Details;
            // 
            // buttonAddGuest
            // 
            this.buttonAddGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddGuest.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddGuest.Image")));
            this.buttonAddGuest.Location = new System.Drawing.Point(535, 13);
            this.buttonAddGuest.Name = "buttonAddGuest";
            this.buttonAddGuest.Size = new System.Drawing.Size(157, 64);
            this.buttonAddGuest.TabIndex = 1;
            this.buttonAddGuest.Text = "Új vendég hozzáadása";
            this.buttonAddGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddGuest.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(535, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vendég törlése";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormGuestDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddGuest);
            this.Controls.Add(this.listViewGuests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGuestDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendég adatbázis | Virtual Receptionist";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewGuests;
        private System.Windows.Forms.Button buttonAddGuest;
        private System.Windows.Forms.Button button1;
    }
}