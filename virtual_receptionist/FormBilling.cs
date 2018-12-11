using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        #endregion

        #region UI események

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
            formModalBillingItems = new FormModalBillingItems();

            if (formModalBillingItems.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {

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
