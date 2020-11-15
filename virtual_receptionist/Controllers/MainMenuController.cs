using virtual_receptionist.Models;
using virtual_receptionist.Repositories;
using virtual_receptionist.Views;

namespace virtual_receptionist.Controllers
{
    /// <summary>
    /// Főmenü vezérlője
    /// </summary>
    public class MainMenuController : Controller
    {
        #region Adattagok

        /// <summary>
        /// Szálláshely adattár egy példánya
        /// </summary>
        private AccommodationRepository repository;

        #endregion

        #region Konsturktor

        /// <summary>
        /// Főmenü vezérlő konsturktora
        /// </summary>
        public MainMenuController()
        {
            repository = new AccommodationRepository();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely beállítja az ablakot betöltődéskor
        /// </summary>
        public string SetMainMenuHeader()
        {
            Accommodation accomodation = repository.GetAccomodation();
            return $"{accomodation.AccomodationName} ({accomodation.VATNumber})";
        }

        /// <summary>
        /// Metódus, amely visszaadja a szálláshely adatait az adattárból egy tömbben
        /// </summary>
        /// <returns>A feltöltött sztring tömböt adja vissza a függvény</returns>
        public string[] GetAccomodationInfo()
        {
            Accommodation accomodation = repository.GetAccomodation();

            string[] accomodationData = new string[8];
            accomodationData[0] = accomodation.AccomodationName;
            accomodationData[1] = accomodation.CompanyName;
            accomodationData[2] = accomodation.Contact;
            accomodationData[3] = accomodation.VATNumber;
            accomodationData[4] = accomodation.Headquarters;
            accomodationData[5] = accomodation.Site;
            accomodationData[6] = accomodation.PhoneNumber;
            accomodationData[7] = accomodation.EmailAddress;

            return accomodationData;
        }

        /// <summary>
        /// Metódus, amely megnyitja a foglalási napló modult
        /// </summary>
        public void OpenBooking()
        {
            FormBooking formBooking = new FormBooking();
            formBooking.ShowDialog();
        }

        /// <summary>
        /// Metódus, amely megnyitja a számlázó modult
        /// </summary>
        public void OpenBilling()
        {
            FormBilling formBilling = new FormBilling();
            formBilling.ShowDialog();
        }

        /// <summary>
        /// Metódus, amely megnyitja a vendégadatbázis-kezelő modult
        /// </summary>
        public void OpenGuestDatabase()
        {
            FormGuestDatabase formGuestDatabase = new FormGuestDatabase();
            formGuestDatabase.ShowDialog();
        }

        /// <summary>
        /// Metódus, amely megnyitja az alkalmazáss weboldalát egy internetes böngészőben
        /// </summary>
        public void OpenVirtualReceptionistWebsite()
        {

        }

        #endregion
    }
}
