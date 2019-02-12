namespace virtual_receptionist.View
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
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.buttonPrintInvoice = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.printDialogPrinter = new System.Windows.Forms.PrintDialog();
            this.printDocumentInvoice = new System.Drawing.Printing.PrintDocument();
            this.buttonNewData = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.ColumnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AllowUserToResizeColumns = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItem,
            this.ColumnPrice,
            this.ColumnUnit,
            this.ColumnQuantity});
            this.dataGridViewItems.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewItems.MultiSelect = false;
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(646, 204);
            this.dataGridViewItems.TabIndex = 8;
            this.dataGridViewItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewItems_RowsAdded);
            this.dataGridViewItems.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewItems_RowsRemoved);
            // 
            // buttonPrintInvoice
            // 
            this.buttonPrintInvoice.Enabled = false;
            this.buttonPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrintInvoice.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrintInvoice.Image")));
            this.buttonPrintInvoice.Location = new System.Drawing.Point(12, 342);
            this.buttonPrintInvoice.Name = "buttonPrintInvoice";
            this.buttonPrintInvoice.Size = new System.Drawing.Size(157, 64);
            this.buttonPrintInvoice.TabIndex = 5;
            this.buttonPrintInvoice.Text = "Számla nyomtatása";
            this.buttonPrintInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPrintInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPrintInvoice.UseVisualStyleBackColor = true;
            this.buttonPrintInvoice.Click += new System.EventHandler(this.buttonPrintInvoice_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddItem.Image")));
            this.buttonAddItem.Location = new System.Drawing.Point(175, 272);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(157, 64);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "Tétel hozzáadása";
            this.buttonAddItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateItem.Image")));
            this.buttonUpdateItem.Location = new System.Drawing.Point(338, 272);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(157, 64);
            this.buttonUpdateItem.TabIndex = 3;
            this.buttonUpdateItem.Text = "Tétel módosítása";
            this.buttonUpdateItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdateItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUpdateItem.UseVisualStyleBackColor = true;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteItem.Image")));
            this.buttonDeleteItem.Location = new System.Drawing.Point(501, 272);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(157, 64);
            this.buttonDeleteItem.TabIndex = 4;
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
            // buttonNewData
            // 
            this.buttonNewData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewData.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewData.Image")));
            this.buttonNewData.Location = new System.Drawing.Point(12, 272);
            this.buttonNewData.Name = "buttonNewData";
            this.buttonNewData.Size = new System.Drawing.Size(157, 64);
            this.buttonNewData.TabIndex = 1;
            this.buttonNewData.Text = "Ügyfél adatai";
            this.buttonNewData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNewData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonNewData.UseVisualStyleBackColor = true;
            this.buttonNewData.Click += new System.EventHandler(this.buttonNewData_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotal.Location = new System.Drawing.Point(12, 225);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(243, 25);
            this.labelTotal.TabIndex = 16;
            this.labelTotal.Text = "Fizetendő végösszeg:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTotal.Location = new System.Drawing.Point(262, 225);
            this.textBoxTotal.Multiline = true;
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(396, 25);
            this.textBoxTotal.TabIndex = 7;
            this.textBoxTotal.Text = "0";
            // 
            // ColumnItem
            // 
            this.ColumnItem.DataPropertyName = "Tétel";
            this.ColumnItem.HeaderText = "Tétel";
            this.ColumnItem.Name = "ColumnItem";
            this.ColumnItem.ReadOnly = true;
            this.ColumnItem.Width = 150;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.DataPropertyName = "Ár";
            this.ColumnPrice.HeaderText = "Ár";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            this.ColumnPrice.Width = 150;
            // 
            // ColumnUnit
            // 
            this.ColumnUnit.DataPropertyName = "Egység";
            this.ColumnUnit.HeaderText = "Egység";
            this.ColumnUnit.Name = "ColumnUnit";
            this.ColumnUnit.ReadOnly = true;
            this.ColumnUnit.Width = 150;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Mennyiség";
            this.ColumnQuantity.HeaderText = "Mennyiség";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            this.ColumnQuantity.Width = 150;
            // 
            // FormBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 418);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonNewData);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonUpdateItem);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.buttonPrintInvoice);
            this.Controls.Add(this.dataGridViewItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Számla kiállítása";
            this.Load += new System.EventHandler(this.FormBilling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button buttonPrintInvoice;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonUpdateItem;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.PrintDialog printDialogPrinter;
        private System.Drawing.Printing.PrintDocument printDocumentInvoice;
        private System.Windows.Forms.Button buttonNewData;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
    }
}