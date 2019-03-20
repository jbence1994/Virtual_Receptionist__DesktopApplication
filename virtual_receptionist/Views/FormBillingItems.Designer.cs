namespace virtual_receptionist.Views
{
    partial class FormBillingItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBillingItems));
            this.listViewBillingItems = new System.Windows.Forms.ListView();
            this.columnHeaderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelItem = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.groupBoxItemParameters = new System.Windows.Forms.GroupBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.maskedTextBoxItemDiscount = new System.Windows.Forms.MaskedTextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelVAT = new System.Windows.Forms.Label();
            this.textBoxVAT = new System.Windows.Forms.TextBox();
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
            this.listViewBillingItems.SelectedIndexChanged += new System.EventHandler(this.listViewBillingItems_SelectedIndexChanged);
            // 
            // columnHeaderItem
            // 
            this.columnHeaderItem.Text = "Tétel";
            this.columnHeaderItem.Width = 160;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Egységár";
            this.columnHeaderPrice.Width = 160;
            // 
            // columnHeaderVAT
            // 
            this.columnHeaderVAT.Text = "ÁFA";
            this.columnHeaderVAT.Width = 160;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Kategória";
            this.columnHeaderCategory.Width = 160;
            // 
            // columnHeaderUnit
            // 
            this.columnHeaderUnit.Text = "Egység";
            this.columnHeaderUnit.Width = 160;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(56, 58);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(34, 13);
            this.labelItem.TabIndex = 0;
            this.labelItem.Text = "Tétel:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(36, 84);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 13);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Egységár:";
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(96, 55);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.ReadOnly = true;
            this.textBoxItem.Size = new System.Drawing.Size(274, 20);
            this.textBoxItem.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(96, 81);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(274, 20);
            this.textBoxPrice.TabIndex = 0;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(492, 55);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.ReadOnly = true;
            this.textBoxUnit.Size = new System.Drawing.Size(274, 20);
            this.textBoxUnit.TabIndex = 0;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(425, 110);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(61, 13);
            this.labelQuantity.TabIndex = 0;
            this.labelQuantity.Text = "Mennyiség:";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(441, 58);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(45, 13);
            this.labelUnit.TabIndex = 0;
            this.labelUnit.Text = "Egység:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(492, 107);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(274, 20);
            this.textBoxQuantity.TabIndex = 2;
            // 
            // groupBoxItemParameters
            // 
            this.groupBoxItemParameters.Controls.Add(this.textBoxVAT);
            this.groupBoxItemParameters.Controls.Add(this.labelCategory);
            this.groupBoxItemParameters.Controls.Add(this.textBoxCategory);
            this.groupBoxItemParameters.Controls.Add(this.buttonCancel);
            this.groupBoxItemParameters.Controls.Add(this.buttonOK);
            this.groupBoxItemParameters.Controls.Add(this.maskedTextBoxItemDiscount);
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
            this.groupBoxItemParameters.Size = new System.Drawing.Size(803, 195);
            this.groupBoxItemParameters.TabIndex = 10;
            this.groupBoxItemParameters.TabStop = false;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(35, 137);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(55, 13);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Kategória:";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(96, 133);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.ReadOnly = true;
            this.textBoxCategory.Size = new System.Drawing.Size(274, 20);
            this.textBoxCategory.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(722, 166);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(641, 166);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 16;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // maskedTextBoxItemDiscount
            // 
            this.maskedTextBoxItemDiscount.Location = new System.Drawing.Point(492, 81);
            this.maskedTextBoxItemDiscount.Mask = "00%";
            this.maskedTextBoxItemDiscount.Name = "maskedTextBoxItemDiscount";
            this.maskedTextBoxItemDiscount.Size = new System.Drawing.Size(274, 20);
            this.maskedTextBoxItemDiscount.TabIndex = 1;
            this.maskedTextBoxItemDiscount.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(389, 84);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(97, 13);
            this.labelDiscount.TabIndex = 0;
            this.labelDiscount.Text = "Tétel kedvezmény:";
            // 
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.Location = new System.Drawing.Point(60, 110);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(30, 13);
            this.labelVAT.TabIndex = 0;
            this.labelVAT.Text = "ÁFA:";
            // 
            // textBoxVAT
            // 
            this.textBoxVAT.Location = new System.Drawing.Point(96, 107);
            this.textBoxVAT.Name = "textBoxVAT";
            this.textBoxVAT.ReadOnly = true;
            this.textBoxVAT.Size = new System.Drawing.Size(274, 20);
            this.textBoxVAT.TabIndex = 18;
            // 
            // FormBillingItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 580);
            this.Controls.Add(this.groupBoxItemParameters);
            this.Controls.Add(this.listViewBillingItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBillingItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Számlázási tételek | Virtual Receptionist";
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
        private System.Windows.Forms.MaskedTextBox maskedTextBoxItemDiscount;
        private System.Windows.Forms.ColumnHeader columnHeaderVAT;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxVAT;
    }
}