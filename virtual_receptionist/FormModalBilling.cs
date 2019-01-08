using System;
using System.Windows.Forms;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Számlázó modul vendégadatok felvételéhez szükséges modális ablak
    /// </summary>
    public partial class FormModalBilling : Form
    {
        #region Adattagok

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul vendégadatok felvételéhez szükséges modális ablak konstruktora
        /// </summary>
        public FormModalBilling()
        {
            InitializeComponent();
            //dataStore = new DataStore("127.0.0.1", "virtual_receptionist", "root", "", "3306");
        }

        private void FormModalBilling_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxCorporateGuest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCorporateGuest.Checked)
            {
                textBoxVatNumber.ReadOnly = false;
            }
            else
            {
                textBoxVatNumber.Clear();
                textBoxVatNumber.ReadOnly = true;
            }
        }

        #endregion
    }
}
