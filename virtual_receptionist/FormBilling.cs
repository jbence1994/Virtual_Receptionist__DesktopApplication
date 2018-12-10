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
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
