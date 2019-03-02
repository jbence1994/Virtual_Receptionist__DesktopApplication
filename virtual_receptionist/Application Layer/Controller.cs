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

        /// <summary>
        /// Számlázó modul üzleti logika osztály egy példánya
        /// </summary>
        private BillingBLL billingBLL;

        /// <summary>
        /// Vendégadatbázis modul üzleti logika osztály egy példánya
        /// </summary>
        private GuestBLL guestBLL;

        /// <summary>
        /// Foglalás modul üzleti logika osztály egy példánya
        /// </summary>
        private BookingBLL bookingBLL;

        /// <summary>
        /// Autentikáció üzleti logika osztály egy példánya
        /// </summary>
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
        /// Országok neveit listában visszaadó metódus
        /// </summary>
        /// <returns>Országlistával tér vissza a függvény</returns>
        public List<string> GetCountries()
        {
            List<string> countries = new List<string>();
            countries.Add("Válasszon!");

            foreach (var country in guestBLL.GetCountries())
            {
                countries.Add(country.Name);
            }

            return countries;
        }

        #endregion
    }
}
