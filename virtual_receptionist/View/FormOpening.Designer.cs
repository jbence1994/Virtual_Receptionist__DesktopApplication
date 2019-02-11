namespace virtual_receptionist.View
{
    partial class FormOpening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpening));
            this.pictureBoxBinarySoftwareLogo = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.pictureBoxVRLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBinarySoftwareLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVRLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBinarySoftwareLogo
            // 
            this.pictureBoxBinarySoftwareLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxBinarySoftwareLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBinarySoftwareLogo.Image")));
            this.pictureBoxBinarySoftwareLogo.Location = new System.Drawing.Point(12, 281);
            this.pictureBoxBinarySoftwareLogo.Name = "pictureBoxBinarySoftwareLogo";
            this.pictureBoxBinarySoftwareLogo.Size = new System.Drawing.Size(696, 174);
            this.pictureBoxBinarySoftwareLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBinarySoftwareLogo.TabIndex = 0;
            this.pictureBoxBinarySoftwareLogo.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Enabled = false;
            this.labelTitle.Location = new System.Drawing.Point(12, 458);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(122, 13);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Virtual Receptionist v1.0";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Enabled = false;
            this.labelCopyright.Location = new System.Drawing.Point(411, 458);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(297, 13);
            this.labelCopyright.TabIndex = 12;
            this.labelCopyright.Text = "Copyright ©️ 2019 Binary Software, Inc. Minden jog fenntartva";
            // 
            // pictureBoxVRLogo
            // 
            this.pictureBoxVRLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxVRLogo.Name = "pictureBoxVRLogo";
            this.pictureBoxVRLogo.Size = new System.Drawing.Size(696, 263);
            this.pictureBoxVRLogo.TabIndex = 13;
            this.pictureBoxVRLogo.TabStop = false;
            // 
            // FormApplicationOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.pictureBoxVRLogo);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxBinarySoftwareLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormApplicationOpening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormApplicationOpening";
            this.Load += new System.EventHandler(this.FormApplicationOpening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBinarySoftwareLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVRLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBinarySoftwareLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.PictureBox pictureBoxVRLogo;
    }
}