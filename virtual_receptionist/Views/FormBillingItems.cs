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

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak konstruktora
        /// </summary>
        public FormBillingItems()
        {
            InitializeComponent();
            controller = new BillingController();
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
                buttonOK.Enabled = true;
                textBoxItem.Text = listViewBillingItems.SelectedItems[0].Text;
                textBoxPrice.Text = listViewBillingItems.SelectedItems[0].SubItems[1].Text;
                maskedTextBoxVAT.Text = listViewBillingItems.SelectedItems[0].SubItems[2].Text;
                textBoxUnit.Text = listViewBillingItems.SelectedItems[0].SubItems[4].Text;
                textBoxQuantity.Clear();
                maskedTextBoxItemDiscount.Clear();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string item = textBoxItem.Text;
            double price = Convert.ToDouble(textBoxPrice.Text);
            string unit = textBoxUnit.Text;
            int quantity = Convert.ToInt32(textBoxQuantity.Text);

            controller.SetBillingItemParameters(item, unit, price, quantity);
        }

        #endregion
    }
}
