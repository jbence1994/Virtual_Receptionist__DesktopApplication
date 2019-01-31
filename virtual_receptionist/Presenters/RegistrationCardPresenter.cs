using System;
using System.Collections.Generic;
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
        /// 
        /// </summary>
        private List<Country> countries;

        /// <summary>
        /// 
        /// </summary>
        private ComboBox comboBoxCountries;

        #endregion

        #region Konstruktor

        public GuestRegistrationCardPresenter(params Control[] controls)
        {
            countries = dataRepository.GetCountries();
            comboBoxCountries = (ComboBox) controls[0];
        }

        #endregion

        #region Vendég bejelentkező lap nézetfrissítései

        /// <summary>
        /// Metódus, amely elmenti a szobakiadást adatbázisba
        /// </summary>
        public void SaveRent()
        {
            throw new NotImplementedException();
        }

        public void SetGuestRegistrationCard()
        {
            comboBoxCountries.DataSource = countries;
        }

        #endregion
    }
}
