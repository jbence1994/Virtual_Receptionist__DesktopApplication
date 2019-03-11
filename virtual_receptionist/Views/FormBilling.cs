using System;
using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Controllers;

namespace virtual_receptionist.Views
{
    /// <summary>
    /// Számlázó modul ablak
    /// </summary>
    public partial class FormBilling : Form
    {
        #region Adattagok

        /// <summary>
        /// Számlázó modul vezérlő egy példánya
        /// </summary>
        private BillingController controller;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul ablak konstruktora
        /// </summary>
        public FormBilling()
        {
            InitializeComponent();
            controller = new BillingController();
        }

        #endregion

        #region UI események

        private void FormBilling_Load(object sender, EventArgs e)
        {
            DataTable bookingsToBillDataTable = controller.GetBookingsToBill();

            foreach (DataRow row in bookingsToBillDataTable.Rows)
            {
                ListViewItem bookingsToBill = new ListViewItem(row[0].ToString());

                for (int i = 1; i < bookingsToBillDataTable.Columns.Count; i++)
                {
                    bookingsToBill.SubItems.Add(row[i].ToString());
                }

                listViewToBill.Items.Add(bookingsToBill);
            }

            comboBoxBillingCountry.DataSource = controller.GetCountries();
        }

        private void checkBoxIsCompany_CheckedChanged(object sender, EventArgs e)
        {
            textBoxVATNumber.Clear();
            textBoxVATNumber.Enabled = checkBoxIsCompany.Checked;
        }

        private void listViewToBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewToBill.SelectedItems.Count > 0)
            {
                string name = listViewToBill.SelectedItems[0].SubItems[1].Text;
                string[] data = controller.GetBillingData(name);

                textBoxBillingName.Text = data[0];
                comboBoxBillingCountry.SelectedItem = data[1];
                textBoxBillingCity.Text = data[2];
                textBoxBillingZipCode.Text = data[3];
                textBoxBillingAddress.Text = data[4];

                buttonAddItem.Enabled = true;
                buttonUpdateItem.Enabled = true;
                buttonDeleteItem.Enabled = true;
            }
            else
            {
                textBoxBillingName.Clear();
                comboBoxBillingCountry.DataSource = null;
                comboBoxBillingCountry.DataSource = controller.GetCountries();
                comboBoxBillingCountry.SelectedItem = controller.GetCountries()[0];
                textBoxBillingCity.Clear();
                textBoxBillingZipCode.Clear();
                textBoxBillingAddress.Clear();
                textBoxVATNumber.Clear();

                buttonAddItem.Enabled = false;
                buttonUpdateItem.Enabled = false;
                buttonDeleteItem.Enabled = false;
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            FormBillingItems billingItems = new FormBillingItems();

            if (billingItems.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                FormBillingItems billingItems = new FormBillingItems();

                if (billingItems.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            textBoxTotalPrice.Text = controller.GetTotalPrice();
        }

        private void dataGridViewItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            textBoxTotalPrice.Text = controller.GetTotalPrice();
        }

        private void buttonPrintInvoice_Click(object sender, EventArgs e)
        {
            int bookingID = listViewToBill.SelectedItems[0].Index;
            controller.PrintInvoice(bookingID);
        }

        #endregion
    }
}
