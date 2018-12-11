using System;
using System.Windows.Forms;
using System.Data;

namespace virtual_receptionist
{
    /// <summary>
    /// Számlázó modul ablak
    /// </summary>
    public partial class FormBilling : Form
    {
        #region Adattagok

        /// <summary>
        /// Főmenü ablak egy példánya
        /// </summary>
        private FormMainMenu formMainMenu;
        /// <summary>
        /// Számlázó modul vendégadatok felvételéhez szükséges modális ablak egy példánya
        /// </summary>
        private FormModalBillingItems formModalBillingItems;
        /// <summary>
        /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak egy példánya
        /// </summary>
        private FormModalBilling formModalBilling;
        /// <summary>
        /// Adattár osztály egy példánya
        /// </summary>
        private DataStore dataStore;
        /// <summary>
        /// Számlázási tételeket tartalmazó DataTable adatszerkezet
        /// </summary>
        private DataTable billingItems;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul ablak konstruktora, amely összeköti a főmenü ablakot a számlázó modul ablakkal
        /// </summary>
        /// <param name="formMainMenu">Főmenü ablak egy példánya</param>
        public FormBilling(FormMainMenu formMainMenu)
        {
            InitializeComponent();
            this.formMainMenu = formMainMenu;
            dataStore = new DataStore();
            billingItems = dataStore.InitializeDataTableBillingItemsColumns();
        }

        #endregion

        #region UI események

        private void FormBilling_Load(object sender, EventArgs e)
        {
            dataGridViewItems.DataSource = billingItems;
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
            formMainMenu.Show();
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
            formModalBillingItems = new FormModalBillingItems(billingItems);

            if (formModalBillingItems.ShowDialog() == DialogResult.OK)
            {
                double total = double.Parse(textBoxTotal.Text);
                double nextPrice = 0;

                int row = dataGridViewItems.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    nextPrice = double.Parse(dataGridViewItems.Rows[i].Cells[1].Value.ToString());
                }

                textBoxTotal.Text = dataStore.CalculateTotalPrice(total, nextPrice).ToString();
            }
        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {

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

        #endregion
    }
}
