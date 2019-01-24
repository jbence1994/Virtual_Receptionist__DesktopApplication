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



        #endregion

        #region Vendég bejelentkező lap nézetfrissítései
        
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

        #endregion
    }
}
