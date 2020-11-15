using System;
using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Controllers;
using virtual_receptionist.Repositories;
using virtual_receptionist.Validation;

namespace virtual_receptionist.Views
{
    public partial class FormBillingItems : Form
    {
        private readonly BillingRepository billingRepository = new BillingRepository();
        private readonly BillingController controller = new BillingController();

        public object[] BillingItems { get; }

        public FormBillingItems(params object[] billingItems)
        {
            InitializeComponent();

            BillingItems = billingItems;

            textBoxItem.Text = billingItems[0].ToString();
            textBoxPrice.Text = billingItems[1].ToString();

            if (billingItems[3].ToString() == "0%")
                maskedTextBoxDiscountRate.Clear();
            else
                maskedTextBoxDiscountRate.Text = billingItems[3].ToString();

            numericUpDownQuantity.Text = billingItems[4].ToString();
            textBoxUnit.Text = billingItems[5].ToString();
            textBoxVAT.Text = billingItems[6].ToString();
            textBoxCategory.Text = billingItems[7].ToString();
        }

        private void FormModalBillingItems_Load(object sender, EventArgs e)
        {
            var billingItemsTable = controller.GetBillingItems();

            foreach (DataRow row in billingItemsTable.Rows)
            {
                var billingItems = new ListViewItem(row[0].ToString());

                for (var i = 1; i < billingItemsTable.Columns.Count; i++)
                    billingItems.SubItems.Add(row[i].ToString());

                listViewBillingItems.Items.Add(billingItems);
            }
        }

        private void listViewBillingItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBillingItems.SelectedItems.Count <= 0)
                return;

            textBoxItem.Text = listViewBillingItems.SelectedItems[0].Text;
            textBoxPrice.Text = listViewBillingItems.SelectedItems[0].SubItems[1].Text;
            textBoxVAT.Text = $"{listViewBillingItems.SelectedItems[0].SubItems[2].Text}%";
            textBoxCategory.Text = listViewBillingItems.SelectedItems[0].SubItems[3].Text;
            textBoxUnit.Text = listViewBillingItems.SelectedItems[0].SubItems[4].Text;
            errorProviderBillingItem.Clear();
            errorProviderDiscount.Clear();
            errorProviderQuantity.Clear();

            maskedTextBoxDiscountRate.Enabled =
                listViewBillingItems.SelectedItems[0].SubItems[3].Text != "Tárgyi adó mentes";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var validData = true;

            var item = string.Empty;
            double price = 0;
            double finalPrice;
            double discount = 0;

            try
            {
                item = textBoxItem.Text;
                BillingItemValidation.ValidateBillingItem(item);
                price = Convert.ToDouble(textBoxPrice.Text);
                finalPrice = Convert.ToDouble(textBoxPrice.Text);
            }
            catch (Exception exception)
            {
                DialogResult = DialogResult.None;
                errorProviderBillingItem.SetError(textBoxItem, exception.Message);
                validData = false;
            }

            if (maskedTextBoxDiscountRate.MaskFull)
            {
                discount = Convert.ToDouble(maskedTextBoxDiscountRate.Text);
            }

            var unit = textBoxUnit.Text;
            var vat = textBoxVAT.Text;
            var category = textBoxCategory.Text;
            var quantity = numericUpDownQuantity.Text;

            try
            {
                errorProviderQuantity.Clear();
                BillingItemQuantityValidation.ValidateBillingItemQuantity(quantity);
            }
            catch (OverflowException)
            {
                DialogResult = DialogResult.None;
                errorProviderQuantity.SetError(textBoxUnit, "Érvénytelen mennyiség!");
                validData = false;
            }
            catch (Exception exception)
            {
                DialogResult = DialogResult.None;
                errorProviderQuantity.SetError(numericUpDownQuantity, exception.Message);
                validData = false;
            }

            if (!validData)
                return;

            BillingItems[0] = item;

            finalPrice = billingRepository.CountDiscountPrice(Convert.ToDouble(price), Convert.ToDouble(discount));

            finalPrice = billingRepository.CountTotalPrice(Convert.ToDouble(finalPrice), Convert.ToInt32(quantity));

            BillingItems[1] = price;
            BillingItems[2] = finalPrice;
            BillingItems[3] = $"{discount}%";
            BillingItems[4] = quantity;
            BillingItems[5] = unit;
            BillingItems[6] = vat;
            BillingItems[7] = category;
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            errorProviderQuantity.Clear();
        }
    }
}
