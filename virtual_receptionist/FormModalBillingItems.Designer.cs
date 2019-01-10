namespace virtual_receptionist.View
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
            this.columnHeaderVAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.groupBoxItemParameters = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxItemDiscount = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxVAT = new System.Windows.Forms.MaskedTextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelVAT = new System.Windows.Forms.Label();
            this.groupBoxItemParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBillingItems
            // 
            this.listViewBillingItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderItem,
            this.columnHeaderPrice,
            this.columnHeaderVAT,
            this.columnHeaderCategory,
            this.columnHeaderUnit});
            this.listViewBillingItems.FullRowSelect = true;
            this.listViewBillingItems.GridLines = true;
            this.listViewBillingItems.Location = new System.Drawing.Point(12, 12);
            this.listViewBillingItems.MultiSelect = false;
            this.listViewBillingItems.Name = "listViewBillingItems";
            this.listViewBillingItems.Size = new System.Drawing.Size(804, 355);
            this.listViewBillingItems.TabIndex = 0;
            this.listViewBillingItems.UseCompatibleStateImageBehavior = false;
            this.listViewBillingItems.View = System.Windows.Forms.View.Details;
            this.listViewBillingItems.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewBillingItems_ColumnWidthChanging);
            this.listViewBillingItems.SelectedIndexChanged += new System.EventHandler(this.listViewBillingItems_SelectedIndexChanged);
            // 
            // columnHeaderItem
            // 
            this.columnHeaderItem.DisplayIndex = 0;
            this.columnHeaderItem.Text = "Tétel";
            this.columnHeaderItem.Width = 160;
            // 
            // columnHeaderVAT
            // 
            this.columnHeaderVAT.DisplayIndex = 2;
            this.columnHeaderVAT.Text = "ÁFA";
            this.columnHeaderVAT.Width = 160;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.DisplayIndex = 3;
            this.columnHeaderCategory.Text = "Kateógria";
            this.columnHeaderCategory.Width = 160;
            // 
            // columnHeaderUnit
            // 
            this.columnHeaderUnit.DisplayIndex = 4;
            this.columnHeaderUnit.Text = "Egység";
            this.columnHeaderUnit.Width = 160;
            // 
            // columnHeaderPrice
            //
            this.columnHeaderPrice.DisplayIndex = 1;
            this.columnHeaderPrice.Text = "Egységár";
            this.columnHeaderPrice.Width = 160;
            // 
            // buttonAdd
            // 
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(434, 132);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(363, 37);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Tétel hozzáadása";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(45, 26);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(34, 13);
            this.labelItem.TabIndex = 2;
            this.labelItem.Text = "Tétel:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(45, 48);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 13);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Egységár:";
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(154, 19);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.ReadOnly = true;
            this.textBoxItem.Size = new System.Drawing.Size(274, 20);
            this.textBoxItem.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(154, 45);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(274, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(154, 71);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.ReadOnly = true;
            this.textBoxUnit.Size = new System.Drawing.Size(274, 20);
            this.textBoxUnit.TabIndex = 6;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(45, 100);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(61, 13);
            this.labelQuantity.TabIndex = 7;
            this.labelQuantity.Text = "Mennyiség:";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(45, 74);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(45, 13);
            this.labelUnit.TabIndex = 8;
            this.labelUnit.Text = "Egység:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(154, 97);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(274, 20);
            this.textBoxQuantity.TabIndex = 9;
            // 
            // groupBoxItemParameters
            // 
            this.groupBoxItemParameters.Controls.Add(this.maskedTextBoxItemDiscount);
            this.groupBoxItemParameters.Controls.Add(this.buttonAdd);
            this.groupBoxItemParameters.Controls.Add(this.maskedTextBoxVAT);
            this.groupBoxItemParameters.Controls.Add(this.labelDiscount);
            this.groupBoxItemParameters.Controls.Add(this.labelVAT);
            this.groupBoxItemParameters.Controls.Add(this.labelItem);
            this.groupBoxItemParameters.Controls.Add(this.textBoxQuantity);
            this.groupBoxItemParameters.Controls.Add(this.textBoxItem);
            this.groupBoxItemParameters.Controls.Add(this.labelQuantity);
            this.groupBoxItemParameters.Controls.Add(this.labelUnit);
            this.groupBoxItemParameters.Controls.Add(this.textBoxPrice);
            this.groupBoxItemParameters.Controls.Add(this.labelPrice);
            this.groupBoxItemParameters.Controls.Add(this.textBoxUnit);
            this.groupBoxItemParameters.Location = new System.Drawing.Point(12, 373);
            this.groupBoxItemParameters.Name = "groupBoxItemParameters";
            this.groupBoxItemParameters.Size = new System.Drawing.Size(803, 188);
            this.groupBoxItemParameters.TabIndex = 10;
            this.groupBoxItemParameters.TabStop = false;
            // 
            // maskedTextBoxItemDiscount
            // 
            this.maskedTextBoxItemDiscount.Location = new System.Drawing.Point(154, 149);
            this.maskedTextBoxItemDiscount.Mask = "00.0%";
            this.maskedTextBoxItemDiscount.Name = "maskedTextBoxItemDiscount";
            this.maskedTextBoxItemDiscount.Size = new System.Drawing.Size(274, 20);
            this.maskedTextBoxItemDiscount.TabIndex = 15;
            // 
            // maskedTextBoxVAT
            // 
            this.maskedTextBoxVAT.Location = new System.Drawing.Point(154, 123);
            this.maskedTextBoxVAT.Mask = "00.0 %";
            this.maskedTextBoxVAT.Name = "maskedTextBoxVAT";
            this.maskedTextBoxVAT.ReadOnly = true;
            this.maskedTextBoxVAT.Size = new System.Drawing.Size(274, 20);
            this.maskedTextBoxVAT.TabIndex = 14;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(45, 152);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(97, 13);
            this.labelDiscount.TabIndex = 11;
            this.labelDiscount.Text = "Tétel kedvezmény:";
            // 
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.Location = new System.Drawing.Point(45, 126);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(30, 13);
            this.labelVAT.TabIndex = 10;
            this.labelVAT.Text = "ÁFA:";
            // 
            // FormModalBillingItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 574);
            this.Controls.Add(this.groupBoxItemParameters);
            this.Controls.Add(this.listViewBillingItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormModalBillingItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tételek | Virtual Receptionist";
            this.Load += new System.EventHandler(this.FormModalBillingItems_Load);
            this.groupBoxItemParameters.ResumeLayout(false);
            this.groupBoxItemParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewBillingItems;
        private System.Windows.Forms.ColumnHeader columnHeaderItem;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderUnit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.GroupBox groupBoxItemParameters;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelVAT;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxVAT;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxItemDiscount;
        private System.Windows.Forms.ColumnHeader columnHeaderVAT;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
    }
}