using System.Collections.Generic;
using virtual_receptionist.BusinessLogicLayer;

namespace virtual_receptionist.ApplicationLayer
{
    /// <summary>
    /// Az alkalmazás vezérlője, amely a nézetek megfelelő előállításáért és az inputok ellenőrzéséért
    /// </summary>
    public partial class Controller
    {
        #region Adattagok

        private BillingBLL billingBLL;
        private GuestBLL guestBLL;
        private BookingBLL bookingBLL;
        private LoginBLL loginBLL;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Alkalmazás vezérlő konstruktora
        /// </summary>
        public Controller()
        {
            billingBLL = new BillingBLL();
            guestBLL = new GuestBLL();
            bookingBLL = new BookingBLL();
            loginBLL = new LoginBLL();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Országokat lista adatszerkezetben visszaadó metódus
        /// </summary>
        /// <returns>Országlistával tér vissza a függvény</returns>
        public List<string> GetCountries()
        {
            List<string> countries = new List<string>();
            countries.Add("Válasszon!");

            foreach (Country country in Repository.Countries)
            {
                countries.Add(country.Name);
            }

            return countries;
        }

        #endregion
    }
}
