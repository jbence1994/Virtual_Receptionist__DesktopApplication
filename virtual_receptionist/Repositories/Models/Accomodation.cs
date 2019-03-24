namespace virtual_receptionist.Repositories.Models
{
    /// <summary>
    /// Szálláshely egyed
    /// </summary>
    public class Accomodation
    {
        #region Adattagok

        /// <summary>
        /// Ezen osztály egyke példánya
        /// </summary>
        private static Accomodation accomodationInstance;

        /// <summary>
        /// Szálláshely azonosítója
        /// </summary>
        private int id;

        /// <summary>
        /// Szálláshely neve
        /// </summary>
        private string accomodationName;

        /// <summary>
        /// Szálláshely cégneve
        /// </summary>
        private string companyName;

        /// <summary>
        /// Szálláshely képviselője
        /// </summary>
        private string contact;

        /// <summary>
        /// Szálláshely adószáma
        /// </summary>
        private string vatNumber;

        /// <summary>
        /// Szálláshely székhelye
        /// </summary>
        private string headquarters;

        /// <summary>
        /// Szálláshely telephelye
        /// </summary>
        private string site;

        /// <summary>
        /// Szálláshely telefonszáma
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// Szálláshely e-mail címe
        /// </summary>
        private string emailAddress;

        /// <summary>
        /// Szálláshely egyedi szállásazonosítója
        /// </summary>
        private string accomodationID;

        /// <summary>
        /// Szálláshely regisztrációjához tartozó jelszó
        /// </summary>
        private string password;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Accomodation osztály konstruktora
        /// </summary>
        private Accomodation()
        {
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Szálláshely azonosítója
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Szálláshely neve
        /// </summary>
        public string AccomodationName
        {
            get { return accomodationName; }
            set { accomodationName = value; }
        }

        /// <summary>
        /// Szálláshely cégneve
        /// </summary>
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        /// <summary>
        /// Szálláshely képviselője
        /// </summary>
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        /// <summary>
        /// Szálláshely adószáma
        /// </summary>
        public string VATNumber
        {
            get { return vatNumber; }
            set { vatNumber = value; }
        }

        /// <summary>
        /// Szálláshely székhelye
        /// </summary>
        public string Headquarters
        {
            get { return headquarters; }
            set { headquarters = value; }
        }

        /// <summary>
        /// Szálláshely telephelye
        /// </summary>
        public string Site
        {
            get { return site; }
            set { site = value; }
        }

        /// <summary>
        /// Szálláshely telefonszáma
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        /// <summary>
        /// Szálláshely e-mail címe
        /// </summary>
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        /// <summary>
        /// Szálláshely egyedi szállásazonosítója
        /// </summary>
        public string AccomodationID
        {
            get { return accomodationID; }
            set { accomodationID = value; }
        }

        /// <summary>
        /// Szálláshely regisztrációjához tartozó jelszó
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Az egyke Accomodation osztályt példányosító (getter) metódus
        /// </summary>
        /// <returns>Az egyke példánnyal tér vissza a metódus</returns>
        public static Accomodation GetAccomodation()
        {
            if (accomodationInstance == null)
            {
                return accomodationInstance = new Accomodation();
            }

            return accomodationInstance;
        }

        /// <summary>
        /// Accomodation osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja az Accomodation típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return
                $"{accomodationName} {companyName} {contact} {vatNumber} {headquarters} {site} {phoneNumber} {emailAddress}";
        }

        #endregion
    }
}
