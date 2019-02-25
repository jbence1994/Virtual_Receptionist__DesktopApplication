using System;
using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Számlázó modul ablak
    /// </summary>
    public partial class FormBilling : Form
    {
        #region Adattagok

        /// <summary>
        /// Számlázó ablak és számlázási tételek modális ablak prezenter egy példánya
        /// </summary>
        private BillingPresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul ablak konstruktora
        /// </summary>
        public FormBilling()
        {
            InitializeComponent();
            presenter = new BillingPresenter();
        }

        #endregion

        #region UI események

        private void FormBilling_Load(object sender, EventArgs e)
        {

        }

        private void buttonPrintInvoice_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            FormBillingItems billingItems = new FormBillingItems();

            if (billingItems.ShowDialog() == DialogResult.OK)
            {
                dataGridViewItems.DataSource = presenter.AddNewRow();
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
                    dataGridViewItems.DataSource = presenter.UpdateRow(rowToUpdate);
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
                dataGridViewItems.DataSource = presenter.DeleteRow(rowToDelete);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int rows = dataGridViewItems.Rows.Count;
            buttonPrintInvoice.Enabled = !presenter.IsEmptyBillingTable(rows);
        }

        private void dataGridViewItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int rows = dataGridViewItems.Rows.Count;
            buttonPrintInvoice.Enabled = !presenter.IsEmptyBillingTable(rows);
        }

        #endregion
    }
}
