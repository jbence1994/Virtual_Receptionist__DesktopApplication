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
            maskedTextBoxDiscountRate.Text = billingItems[3].ToString();
            textBoxQuantity.Text = billingItems[4].ToString();
            textBoxUnit.Text = billingItems[5].ToString();
            textBoxVAT.Text = billingItems[6].ToString();
            textBoxCategory.Text = billingItems[7].ToString();
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
                errorProviderDiscount.Clear();
                errorProviderQuantity.Clear();

                if (listViewBillingItems.SelectedItems[0].SubItems[3].Text == "Tárgyi adó mentes")
                {
                    maskedTextBoxDiscountRate.Enabled = false;
                }
                else
                {
                    maskedTextBoxDiscountRate.Enabled = true;
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool validData = true;

            string item = string.Empty;

            try
            {
                errorProviderItem.Clear();
                item = textBoxItem.Text;
                controller.ItemValidator(item);
            }
            catch (InvalidBllingItemParameterException exception)
            {
                DialogResult = DialogResult.None;
                errorProviderItem.SetError(textBoxItem, exception.Message);
                validData = false;
            }

            double price = Convert.ToDouble(textBoxPrice.Text);


            double finalPrice = Convert.ToDouble(textBoxPrice.Text);




            double discount = 0;

            if (maskedTextBoxDiscountRate.MaskFull)
            {
                discount = Convert.ToDouble(maskedTextBoxDiscountRate.Text);
            }

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
                validData = false;
            }
            catch (OverflowException)
            {
                DialogResult = DialogResult.None;
                errorProviderQuantity.SetError(textBoxQuantity, "Érvénytelen mennyiség!");
                validData = false;
            }

            if (validData)
            {
                billingItems[0] = item;

                /*
                 * Először, ha van, a kedvezményes árat számoljuk ki
                 */
                finalPrice = controller.GetDiscountPrice(price, discount);

                /*
                 * A kedvezményes árképzés után számoljuk össze a mennyiségét
                 */
                finalPrice = controller.GetTotalPrice(finalPrice, Convert.ToInt32(quantity));

                billingItems[1] = price;
                billingItems[2] = finalPrice;
                billingItems[3] = $"{discount}%";
                billingItems[4] = quantity;
                billingItems[5] = unit;
                billingItems[6] = vat;
                billingItems[7] = category;
            }
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
