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
        /// Számlázási tételek
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
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (listViewBillingItems.SelectedItems.Count > 0)
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

                /* Validálni */

                string discountRate = maskedTextBoxItemDiscount.Text; // _5%, __%, 10% lehetőségek
                string[] discountRateWithoutPercentSign = discountRate.Split('%');

                // Validálni üres-e az első index, az első kettő, vagy teljes-e, vagy nulla => DivideByZeroException
                int discountValue = Convert.ToInt32(discountRateWithoutPercentSign[0]);

                price = controller.GetDiscountPrice(price, discountValue); //DivideByZeroException !!!

                billingItems[0] = item;
                billingItems[1] = price;
                billingItems[2] = unit;
                billingItems[3] = quantity;
                billingItems[4] = vat;
                billingItems[5] = category;

                if (maskedTextBoxItemDiscount.Text.Contains("_"))
                {
                    string[] underscore = maskedTextBoxItemDiscount.Text.Split('_');
                    billingItems[6] = $"{underscore[0]}{underscore[1]}";
                }
                else if (maskedTextBoxItemDiscount.Text[0] == '0')
                {
                    string[] zero = maskedTextBoxItemDiscount.Text.Split('0');
                    billingItems[6] = $"{zero[1]}";
                }
                else
                {
                    billingItems[6] = discountRate;
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt számlázási tétel!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
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
        /// Számlázási tételek
        /// </summary>
        public object[] BillingItems
        {
            get { return billingItems; }
        }

        #endregion
    }
}
