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



        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendég bejelentkező lap prezenter konstruktora
        /// </summary>
        public GuestRegistrationCardPresenter()
        {

        }

        #endregion

        #region Vendég bejelentkező lap nézetfrissítései

        /// <summary>
        /// Metódus, amely beállítja az ablakot betöltődéskor
        /// </summary>
        /// <param name="comboBoxCountry">Országok listáját tartalmazó legördülő menü</param>
        public void SetRegistrationCard(ComboBox comboBoxCountry)
        {
            comboBoxCountry.DataSource = dataRepository.GetCountries();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Interrupt()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void SaveRent()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void SaveGuestDataToDatabase()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="checkBoxCorporateGuest"></param>
        /// <param name="textBoxVatNumber"></param>
        public void SetCorporateGuest(CheckBox checkBoxCorporateGuest, TextBox textBoxVatNumber)
        {
            textBoxVatNumber.ReadOnly = !checkBoxCorporateGuest.Checked;
        }

        #endregion
    }
}
