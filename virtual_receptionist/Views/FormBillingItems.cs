using System;
using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Controllers;

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
            maskedTextBoxVAT.Text = billingItems[4].ToString();
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
                maskedTextBoxVAT.Text = listViewBillingItems.SelectedItems[0].SubItems[2].Text;
                textBoxCategory.Text = listViewBillingItems.SelectedItems[0].SubItems[3].Text;
                textBoxUnit.Text = listViewBillingItems.SelectedItems[0].SubItems[4].Text;
                textBoxQuantity.Clear();
                maskedTextBoxItemDiscount.Clear();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            /*
             * Validálni !!! + Százalékos kedvezményt számolni kontroller függvénnyel
             */

            string item = textBoxItem.Text;
            double price = Convert.ToDouble(textBoxPrice.Text);
            string unit = textBoxUnit.Text;
            int quantity = Convert.ToInt32(textBoxQuantity.Text);
            string vat = maskedTextBoxVAT.Text;
            string category = textBoxCategory.Text;
            string discount = maskedTextBoxItemDiscount.Text;

            billingItems[0] = item;
            billingItems[1] = price;
            billingItems[2] = unit;
            billingItems[3] = quantity;

            if (vat == "0_%")
            {
                billingItems[4] = "0%";
            }
            else
            {
                billingItems[4] = vat;
            }

            billingItems[5] = category;

            if (!maskedTextBoxItemDiscount.MaskFull)
            {
                billingItems[6] = "";
            }
            else
            {
                billingItems[6] = discount;
            }
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
