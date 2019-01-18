using System;
using System.Windows.Forms;
using System.Data;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Számlázó modul ablak
    /// </summary>
    public partial class FormBilling : Form
    {
        #region Adattagok

        /// <summary>
        /// Számlázó modul vendégadatok felvételéhez szükséges modális ablak egy példánya
        /// </summary>
        private FormModalBillingItems formModalBillingItems;
        /// <summary>
        /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak egy példánya
        /// </summary>
        private FormModalBilling formModalBilling;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul ablak konstruktora, amely összeköti a főmenü ablakot a számlázó modul ablakkal
        /// </summary>
        /// <param name="formMainMenu">Főmenü ablak egy példánya</param>
        public FormBilling()
        {
            InitializeComponent();
        }

        #endregion

        #region UI események

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNewData_Click(object sender, EventArgs e)
        {
            formModalBilling = new FormModalBilling();

            if (formModalBilling.ShowDialog() == DialogResult.OK)
            {
                buttonAddItem.Enabled = true;
                buttonUpdateItem.Enabled = true;
                buttonDeleteItem.Enabled = true;
                buttonPrintInvoice.Enabled = true;
                buttonSaveInvoice.Enabled = true;
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            formModalBillingItems = new FormModalBillingItems();
            formModalBillingItems.ShowDialog();
        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count != 0)
            {

            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count != 0)
            {
                int rowToDelete = dataGridViewItems.SelectedRows[0].Index;
                dataGridViewItems.Rows.RemoveAt(rowToDelete);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrintInvoice_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveInvoice_Click(object sender, EventArgs e)
        {

        }

        private void buttonImportData_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridViewItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        #endregion
    }
}
