using System;
using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Számlázó modul tételek felvételéhez szükséges modális ablak
    /// </summary>
    public partial class FormBillingItems : Form
    {
        #region Adattagok

        /// <summary>
        /// Számlázó ablak és számlázási tételek modális ablak prezenter egy példánya
        /// </summary>
        private BillingPresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak konstruktora
        /// </summary>
        public FormBillingItems()
        {
            InitializeComponent();
            presenter = new BillingPresenter();
        }

        #endregion

        #region UI események

        private void FormModalBillingItems_Load(object sender, EventArgs e)
        {
            DataTable billingItemsTable = presenter.InitializeBillingItemsTable();

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
            double price = double.Parse(textBoxPrice.Text);
            string unit = textBoxUnit.Text;
            int quantity = int.Parse(textBoxQuantity.Text);

            presenter.SetBillingItemParameters(item, unit, price, quantity);
        }

        #endregion
    }
}
