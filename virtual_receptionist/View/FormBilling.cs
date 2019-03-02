using System;
using System.Windows.Forms;
using virtual_receptionist.ApplicationLayer;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Számlázó modul ablak
    /// </summary>
    public partial class FormBilling : Form
    {
        #region Adattagok

        /// <summary>
        /// Alkalmazás vezérlő egy példánya
        /// </summary>
        private Controller controller;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul ablak konstruktora
        /// </summary>
        public FormBilling()
        {
            InitializeComponent();
            controller = new Controller();
        }

        #endregion

        #region UI események

        private void FormBilling_Load(object sender, EventArgs e)
        {

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
            int rows = dataGridViewItems.Rows.Count;
            buttonPrintInvoice.Enabled = !controller.IsEmptyBillingTable(rows);
        }

        private void dataGridViewItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int rows = dataGridViewItems.Rows.Count;
            buttonPrintInvoice.Enabled = !controller.IsEmptyBillingTable(rows);
        }

        private void buttonPrintInvoice_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
