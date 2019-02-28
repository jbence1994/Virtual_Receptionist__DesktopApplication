using System.Windows.Forms;
using virtual_receptionist.PresentationLayer;
using virtual_receptionist.DataAccessLayer.Model;
using virtual_receptionist.DataAccessLayer;

namespace virtual_receptionist.ApplicationLayer
{
    /// <summary>
    /// Főmenü ablak vezérlője
    /// </summary>
    public class MainMenuController : DefaultController
    {
        #region Adattagok

        /// <summary>
        /// Alkalmazás bejelentkező ablakának egy példánya
        /// </summary>
        private FormLogin formLogin;

        /// <summary>
        /// Főmenü ablak
        /// </summary>
        private FormMainMenu formMainMenu;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Főmenü ablak vezérlő konstruktora
        /// </summary>
        /// <param name="formMainMenu">Főmenü ablak</param>
        /// <param name="formLogin">Bejelentkező ablak</param>
        public MainMenuController(FormMainMenu formMainMenu, FormLogin formLogin)
        {
            this.formMainMenu = formMainMenu;
            this.formLogin = formLogin;
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely kijelentkezik az alkalmazásból
        /// </summary>
        public void Logout()
        {
            DialogResult logout = MessageBox.Show("Kijelentkezik az alkalmazásból?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (logout == DialogResult.Yes)
            {
                formMainMenu.Close();
                formLogin.Show();
                repository.Logout();
            }
        }

        /// <summary>
        /// Metódus, amely beállítja az ablakot betöltődéskor
        /// </summary>
        public string SetMainMenuHeader()
        {
            Accomodation accomodation = repository.Accomodation;
            return $"{accomodation.Name} ({accomodation.VatNumber})";
        }

        /// <summary>
        /// Metódus, amely megadja, mikor volt legutóbb felhasználó bejelentkezve az alkalmazásba
        /// </summary>
        /// <returns>A legutóbbi bejelentkezés idejét adja vissza karakterláncként a függvény</returns>
        public string GetLastTimeLoggedIn()
        {
            return repository.LastTimeLoggedIn;
        }

        /// <summary>
        /// Metódus, amely visszaadja az alkalmazást futtató számítógép NetBIOS nevét
        /// </summary>Alkalmazást futtató számítógép NetBIOS nevével tér vissza a függvény<returns></returns>
        public string GetClient()
        {
            return Repository.Client;
        }

        /// <summary>
        /// Metódus, amely megnyitja a névjegy ablakot
        /// </summary>
        public void OpenAboutBox()
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        /// <summary>
        /// Metódus, amely megnyitja a beépített CHM-súgót
        /// </summary>
        public void OpenCHM()
        {
            // Help.ShowHelp(formMainMenu, "CHMPath");
        }

        /// <summary>
        /// Metódus, amely beállítja az alkalmazást használó szálláshely adatait egy MessageBoxba
        /// </summary>
        public void SetAccomodationInfo()
        {
            Accomodation accomodation = repository.Accomodation;

            MessageBox.Show(
                $"Szálláshely neve: {accomodation.Name}\n\nCég neve: {accomodation.Company}\n\nKépviselő: {accomodation.Contact}\n\nAdószám: {accomodation.VatNumber}\n\nSzékhely: {accomodation.Headquarters}\n\nTelephely: {accomodation.Site}\n\nTelefonszám: {accomodation.PhoneNumber}\n\nE-mail cím: {accomodation.EmailAddress}",
                "Szálláshely információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        /// <summary>
        /// Metódus, amely megnyitja a vendég bejelentlező lap ablakot
        /// </summary>
        public void OpenGuestRegistrationCard()
        {
            FormGuestRegistrationCard formGuestRegistrationCard = new FormGuestRegistrationCard();
            formGuestRegistrationCard.ShowDialog();
        }

        #endregion
    }
}
