using System;
using virtual_receptionist.Model;
using System.Windows.Forms;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Számlázó modul ügyfél adatait kitöltő modális ablak prezentere
    /// </summary>
    public class ModalBillingPresenter : DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Adószám szövegmező
        /// </summary>
        private TextBox textBoxVatNumber;

        /// <summary>
        /// Vállalati ügyfél checkbox
        /// </summary>
        private CheckBox checkBoxCorporateGuest;

        /// <summary>
        /// Országok listáját tartalmazó legördülő menü
        /// </summary>
        private ComboBox comboBoxCountry;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul ügyfél adatait kitöltő modális ablak prezenter konsturktora
        /// </summary>
        public ModalBillingPresenter(params Control[] controls)
        {
            textBoxVatNumber = (TextBox) controls[0];
            checkBoxCorporateGuest = (CheckBox) controls[1];
            comboBoxCountry = (ComboBox) controls[2];
        }

        #endregion

        #region Ügyfél adatait kitöltő modális ablak nézetfrissítései

        /// <summary>
        /// Metódus, amely beállítja az adószám szövegmező írhatóságát, attól függően, hogy a vállalati ügyfél checkbox be van-e pipálva
        /// </summary>
        public void SetCorporateGuest()
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

        /// <summary>
        /// Metódus, amely beállítja a legördülő lista forrásának az országok listját
        /// </summary>
        public void InitializeComboBoxWithCountryList()
        {
            comboBoxCountry.DataSource = dataRepository.GetCountries();
        }

        #endregion
    }
}
