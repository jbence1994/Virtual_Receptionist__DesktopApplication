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
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            FormBillingItems billingItems = new FormBillingItems();

            if (billingItems.ShowDialog() == DialogResult.OK)
            {
                dataGridViewItems.DataSource = controller.AddNewRow();
            }
        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                FormBillingItems billingItems = new FormBillingItems();

                if (billingItems.ShowDialog() == DialogResult.OK)
                {
                    int rowToUpdate = dataGridViewItems.SelectedRows[0].Index;
                    dataGridViewItems.DataSource = controller.UpdateRow(rowToUpdate);
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
                int rowToDelete = dataGridViewItems.SelectedRows[0].Index;
                dataGridViewItems.DataSource = controller.DeleteRow(rowToDelete);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridViewItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void buttonPrintInvoice_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
