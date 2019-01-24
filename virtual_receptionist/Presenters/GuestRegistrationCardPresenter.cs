using System;
using System.Windows.Forms;
using virtual_receptionist.Model;
using virtual_receptionist.View;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Vendég bejelentkező lap prezentere
    /// </summary>
    public class GuestRegistrationCardPresenter : DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Országok listáját tartalmazó legördülő menü
        /// </summary>
        private ComboBox comboBoxCountry;

        /// <summary>
        /// Vállalati ügyfél checkbox
        /// </summary>
        private CheckBox checkBoxCorporateGuest;

        /// <summary>
        /// Adószám szövegmező
        /// </summary>
        private TextBox textBoxVatNumber;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendég bejelentkező lap prezenter konstruktora
        /// </summary>
        /// <param name="controls">Paraméterül átadott GUI vezérlők</param>
        public GuestRegistrationCardPresenter(params Control[] controls)
        {
            comboBoxCountry = (ComboBox) controls[0];
            checkBoxCorporateGuest = (CheckBox) controls[1];
            textBoxVatNumber = (TextBox) controls[2];
        }

        #endregion

        #region Vendég bejelentkező lap nézetfrissítései

        /// <summary>
        /// Metódus, amely beállítja a legördülő lista forrásának az országok listját
        /// </summary>
        public void InitializeComboBoxWithCountryList()
        {
            comboBoxCountry.DataSource = dataRepository.GetCountries();
        }

        /// <summary>
        /// Metódus, amely elmenti a szobakiadást adatbázisba
        /// </summary>
        public void SaveRent()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metódus, amely elmenti a vendég adatait adatbázisba
        /// </summary>
        public void SaveGuestDataToDatabase()
        {
            throw new NotImplementedException();
        }

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

        #endregion
    }
}
