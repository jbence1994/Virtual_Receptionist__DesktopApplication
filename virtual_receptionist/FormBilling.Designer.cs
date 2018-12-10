namespace virtual_receptionist
{
    partial class FormBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBilling));
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.buttonPrintInvoice = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.printDialogPrinter = new System.Windows.Forms.PrintDialog();
            this.printDocumentInvoice = new System.Drawing.Printing.PrintDocument();
            this.buttonSaveInvoice = new System.Windows.Forms.Button();
            this.buttonImportData = new System.Windows.Forms.Button();
            this.buttonNewData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonBackToMainMenu.Image")));
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(501, 292);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(157, 64);
            this.buttonBackToMainMenu.TabIndex = 6;
            this.buttonBackToMainMenu.Text = "Vissza a főmenübe";
            this.buttonBackToMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBackToMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(646, 204);
            this.dataGridViewItems.TabIndex = 7;
            // 
            // buttonPrintInvoice
            // 
            this.buttonPrintInvoice.Enabled = false;
            this.buttonPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrintInvoice.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrintInvoice.Image")));
            this.buttonPrintInvoice.Location = new System.Drawing.Point(338, 292);
            this.buttonPrintInvoice.Name = "buttonPrintInvoice";
            this.buttonPrintInvoice.Size = new System.Drawing.Size(157, 64);
            this.buttonPrintInvoice.TabIndex = 8;
            this.buttonPrintInvoice.Text = "Számla nyomtatása";
            this.buttonPrintInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPrintInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPrintInvoice.UseVisualStyleBackColor = true;
            this.buttonPrintInvoice.Click += new System.EventHandler(this.buttonPrintInvoice_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Enabled = false;
            this.buttonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddItem.Image")));
            this.buttonAddItem.Location = new System.Drawing.Point(175, 222);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(157, 64);
            this.buttonAddItem.TabIndex = 9;
            this.buttonAddItem.Text = "Tétel hozzáadása";
            this.buttonAddItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.Enabled = false;
            this.buttonUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateItem.Image")));
            this.buttonUpdateItem.Location = new System.Drawing.Point(338, 222);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(157, 64);
            this.buttonUpdateItem.TabIndex = 10;
            this.buttonUpdateItem.Text = "Tétel módosítása";
            this.buttonUpdateItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdateItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUpdateItem.UseVisualStyleBackColor = true;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Enabled = false;
            this.buttonDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteItem.Image")));
            this.buttonDeleteItem.Location = new System.Drawing.Point(175, 292);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(157, 64);
            this.buttonDeleteItem.TabIndex = 11;
            this.buttonDeleteItem.Text = "Tétel törlése";
            this.buttonDeleteItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // printDialogPrinter
            // 
            this.printDialogPrinter.UseEXDialog = true;
            // 
            // buttonSaveInvoice
            // 
            this.buttonSaveInvoice.Enabled = false;
            this.buttonSaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveInvoice.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveInvoice.Image")));
            this.buttonSaveInvoice.Location = new System.Drawing.Point(501, 222);
            this.buttonSaveInvoice.Name = "buttonSaveInvoice";
            this.buttonSaveInvoice.Size = new System.Drawing.Size(157, 64);
            this.buttonSaveInvoice.TabIndex = 13;
            this.buttonSaveInvoice.Text = "Számla mentése";
            this.buttonSaveInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSaveInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSaveInvoice.UseVisualStyleBackColor = true;
            this.buttonSaveInvoice.Click += new System.EventHandler(this.buttonSaveInvoice_Click);
            // 
            // buttonImportData
            // 
            this.buttonImportData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonImportData.Image = ((System.Drawing.Image)(resources.GetObject("buttonImportData.Image")));
            this.buttonImportData.Location = new System.Drawing.Point(12, 292);
            this.buttonImportData.Name = "buttonImportData";
            this.buttonImportData.Size = new System.Drawing.Size(157, 64);
            this.buttonImportData.TabIndex = 14;
            this.buttonImportData.Text = "Ügyfél adatainak importálása";
            this.buttonImportData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonImportData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonImportData.UseVisualStyleBackColor = true;
            this.buttonImportData.Click += new System.EventHandler(this.buttonImportData_Click);
            // 
            // buttonNewData
            // 
            this.buttonNewData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewData.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewData.Image")));
            this.buttonNewData.Location = new System.Drawing.Point(12, 222);
            this.buttonNewData.Name = "buttonNewData";
            this.buttonNewData.Size = new System.Drawing.Size(157, 64);
            this.buttonNewData.TabIndex = 15;
            this.buttonNewData.Text = "Ügyfél adatai";
            this.buttonNewData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNewData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonNewData.UseVisualStyleBackColor = true;
            this.buttonNewData.Click += new System.EventHandler(this.buttonNewData_Click);
            // 
            // FormBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 369);
            this.Controls.Add(this.buttonNewData);
            this.Controls.Add(this.buttonImportData);
            this.Controls.Add(this.buttonSaveInvoice);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonUpdateItem);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.buttonPrintInvoice);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Számla kiállítása | Virtual Receptionist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button buttonPrintInvoice;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonUpdateItem;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.PrintDialog printDialogPrinter;
        private System.Drawing.Printing.PrintDocument printDocumentInvoice;
        private System.Windows.Forms.Button buttonSaveInvoice;
        private System.Windows.Forms.Button buttonImportData;
        private System.Windows.Forms.Button buttonNewData;
    }
}