namespace virtual_receptionist
{
    partial class FormModalBillingItems
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
            this.listViewBillingItems = new System.Windows.Forms.ListView();
            this.columnHeaderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewBillingItems
            // 
            this.listViewBillingItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderItem,
            this.columnHeaderPrice,
            this.columnHeaderUnit});
            this.listViewBillingItems.FullRowSelect = true;
            this.listViewBillingItems.GridLines = true;
            this.listViewBillingItems.Location = new System.Drawing.Point(12, 12);
            this.listViewBillingItems.MultiSelect = false;
            this.listViewBillingItems.Name = "listViewBillingItems";
            this.listViewBillingItems.Size = new System.Drawing.Size(477, 355);
            this.listViewBillingItems.TabIndex = 0;
            this.listViewBillingItems.UseCompatibleStateImageBehavior = false;
            this.listViewBillingItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderItem
            // 
            this.columnHeaderItem.Text = "Tétel";
            this.columnHeaderItem.Width = 158;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Egységár";
            this.columnHeaderPrice.Width = 163;
            // 
            // columnHeaderUnit
            // 
            this.columnHeaderUnit.Text = "Egység";
            this.columnHeaderUnit.Width = 150;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 373);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Hozzáadás";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // FormModalBillingItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 405);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewBillingItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormModalBillingItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tételek | Virtual Receptionist";
            this.Load += new System.EventHandler(this.FormModalBillingItems_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewBillingItems;
        private System.Windows.Forms.ColumnHeader columnHeaderItem;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderUnit;
        private System.Windows.Forms.Button buttonAdd;
    }
}