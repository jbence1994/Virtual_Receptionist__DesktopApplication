using System;
using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Controllers;
using virtual_receptionist.Controllers.Exceptions;

namespace virtual_receptionist.Views
{
    /// <summary>
    /// Számlázó modul tételek felvételéhez szükséges modális ablak
    /// </summary>
    public partial class FormBillingItems : Form
    {
        #region Adattagok

        /// <summary>
        /// Számlázó modul vezérlő egy példánya
        /// </summary>
        private BillingController controller;

        /// <summary>
        /// Számlázandó tétel adatai
        /// </summary>
        private object[] billingItems;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak konstruktora
        /// </summary>
        public FormBillingItems(params object[] billingItems)
        {
            InitializeComponent();
            controller = new BillingController();

            this.billingItems = billingItems;

            textBoxItem.Text = billingItems[0].ToString();
            textBoxPrice.Text = billingItems[1].ToString();
            textBoxUnit.Text = billingItems[2].ToString();
            textBoxQuantity.Text = billingItems[3].ToString();
            textBoxVAT.Text = billingItems[4].ToString();
            textBoxCategory.Text = billingItems[5].ToString();

            if (billingItems[6] != null)
            {
                maskedTextBoxItemDiscount.Text = billingItems[6].ToString();
            }
        }

        #endregion

        #region UI események

        private void FormModalBillingItems_Load(object sender, EventArgs e)
        {
            DataTable billingItemsTable = controller.GetBillingItems();

            foreach (DataRow row in billingItemsTable.Rows)
            {
                ListViewItem billingItems = new ListViewItem(row[0].ToString());

                for (int i = 1; i < billingItemsTable.Columns.Count; i++)
                {
                    billingItems.SubItems.Add(row[i].ToString());
                }

                listViewBillingItems.Items.Add(billingItems);
            }
        }

        private void listViewBillingItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBillingItems.SelectedItems.Count > 0)
            {
                textBoxItem.Text = listViewBillingItems.SelectedItems[0].Text;
                textBoxPrice.Text = listViewBillingItems.SelectedItems[0].SubItems[1].Text;
                textBoxVAT.Text = $"{listViewBillingItems.SelectedItems[0].SubItems[2].Text}%";
                textBoxCategory.Text = listViewBillingItems.SelectedItems[0].SubItems[3].Text;
                textBoxUnit.Text = listViewBillingItems.SelectedItems[0].SubItems[4].Text;
                textBoxQuantity.Clear();
                maskedTextBoxItemDiscount.Clear();
                errorProviderDiscount.Clear();
                errorProviderQuantity.Clear();

                maskedTextBoxItemDiscount.Enabled = textBoxCategory.Text == "Tárgyi adó mentes" ? false : true;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string item = textBoxItem.Text;
            double price = Convert.ToDouble(textBoxPrice.Text);
            string unit = textBoxUnit.Text;
            string vat = textBoxVAT.Text;
            string category = textBoxCategory.Text;
            string quantity = textBoxQuantity.Text;

            try
            {
                errorProviderQuantity.Clear();
                controller.QuantityValidator(quantity);
            }
            catch (InvalidBllingItemParameterException exception)
            {
                DialogResult = DialogResult.None;
                errorProviderQuantity.SetError(textBoxQuantity, exception.Message);
            }
            catch (OverflowException)
            {
                DialogResult = DialogResult.None;
                errorProviderQuantity.SetError(textBoxQuantity, "Érvénytelen mennyiség!");
            }

            billingItems[0] = item;
            billingItems[2] = unit;
            billingItems[3] = quantity;
            billingItems[4] = vat;
            billingItems[5] = category;

            if (maskedTextBoxItemDiscount.MaskFull)
            {
                double discount = discount = Convert.ToInt32(maskedTextBoxItemDiscount.Text);
                price = controller.GetDiscountPrice(price, discount);
                billingItems[6] = discount + "%";
            }

            price = controller.GetTotalPrice(price, Convert.ToInt32(quantity));
            billingItems[1] = price;
        }

        private void maskedTextBoxItemDiscount_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProviderDiscount.Clear();
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            errorProviderQuantity.Clear();
        }

        /// <summary>
        /// Számlázandó tétel adatai
        /// </summary>
        public object[] BillingItems
        {
            get { return billingItems; }
        }

        #endregion
    }
}
