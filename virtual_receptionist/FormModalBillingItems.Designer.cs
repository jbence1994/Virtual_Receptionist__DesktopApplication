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
            this.labelItem = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.groupBoxItemParameters = new System.Windows.Forms.GroupBox();
            this.groupBoxItemParameters.SuspendLayout();
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
            this.listViewBillingItems.Size = new System.Drawing.Size(396, 355);
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
            this.columnHeaderPrice.Width = 115;
            // 
            // columnHeaderUnit
            // 
            this.columnHeaderUnit.Text = "Egység";
            this.columnHeaderUnit.Width = 115;
            // 
            // buttonAdd
            // 
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdd.Location = new System.Drawing.Point(12, 513);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(396, 37);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Hozzáadás";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(6, 26);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(34, 13);
            this.labelItem.TabIndex = 2;
            this.labelItem.Text = "Tétel:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(6, 48);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 13);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Egységár:";
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(115, 19);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.ReadOnly = true;
            this.textBoxItem.Size = new System.Drawing.Size(274, 20);
            this.textBoxItem.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(115, 45);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(274, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(115, 71);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.ReadOnly = true;
            this.textBoxUnit.Size = new System.Drawing.Size(274, 20);
            this.textBoxUnit.TabIndex = 6;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(6, 100);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(61, 13);
            this.labelQuantity.TabIndex = 7;
            this.labelQuantity.Text = "Mennyiség:";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(6, 74);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(45, 13);
            this.labelUnit.TabIndex = 8;
            this.labelUnit.Text = "Egység:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(115, 97);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(274, 20);
            this.textBoxQuantity.TabIndex = 9;
            // 
            // groupBoxItemParameters
            // 
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
            this.groupBoxItemParameters.Size = new System.Drawing.Size(396, 135);
            this.groupBoxItemParameters.TabIndex = 10;
            this.groupBoxItemParameters.TabStop = false;
            // 
            // FormModalBillingItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 562);
            this.Controls.Add(this.groupBoxItemParameters);
            this.Controls.Add(this.buttonAdd);
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
    }
}