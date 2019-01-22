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
        /// Számlázó modul prezenter egy példánya
        /// </summary>
        private BillingPresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul ablak konstruktora, amely összeköti a főmenü ablakot a számlázó modul ablakkal
        /// </summary>
        /// <param name="formMainMenu">Főmenü ablak egy példánya</param>
        public FormBilling()
        {
            InitializeComponent();
            presenter = new BillingPresenter(dataGridViewItems);
        }

        #endregion

        #region UI események

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            presenter.BackToMainMenu(this);
        }

        private void buttonNewData_Click(object sender, EventArgs e)
        {
            presenter.NewData(buttonAddItem, buttonUpdateItem, buttonDeleteItem, buttonPrintInvoice, buttonSaveInvoice);
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            presenter.AddNewRow();
        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            presenter.UpdateRow();
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            presenter.DeleteRow();
        }

        private void buttonPrintInvoice_Click(object sender, EventArgs e)
        {
            presenter.PrintInvoice();
        }

        private void buttonSaveInvoice_Click(object sender, EventArgs e)
        {
            presenter.SaveInvoice();
        }

        private void buttonImportData_Click(object sender, EventArgs e)
        {
            presenter.ImportData();
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
