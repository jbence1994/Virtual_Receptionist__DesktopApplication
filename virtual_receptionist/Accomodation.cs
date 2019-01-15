namespace virtual_receptionist.Model
{
    /// <summary>
    /// Szálláshely egyed modell osztálya
    /// </summary>
    public class Accomodation
    {
        #region Adattagok

        /// <summary>
        /// Szálláshely neve
        /// </summary>
        private string name;
        /// <summary>
        /// Szálláshelyet üzemeltető cég neve
        /// </summary>
        private string company;
        /// <summary>
        /// Szálláshely kontakt személye
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
        /// Szálláshely szállásazonosítója
        /// </summary>
        private string accomodationID;
        /// <summary>
        /// Szálláshely szállásazonosítójához tartozó jelszava
        /// </summary>
        private string password;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Accomodation osztály konstruktora
        /// </summary>
        /// <param name="name">Szálláshely neve</param>
        /// <param name="company">Szálláshelyet üzemeltető cég neve</param>
        /// <param name="contact">Szálláshely kontakt személye</param>
        /// <param name="vatNumber">Szálláshely adószáma</param>
        /// <param name="headquarters">Szálláshely székhelye</param>
        /// <param name="site">Szálláshely telephelye</param>
        /// <param name="telephoneNumber">Szálláshely telefonszáma</param>
        /// <param name="emailAddress">Szálláshely e-mail címe</param>
        /// <param name="accomodationID">Szálláshely szállásazonosítója</param>
        /// <param name="password">Szálláshely szállásazonosítójához tartozó jelszava</param>
        public Accomodation(string name, string company, string contact, string vatNumber, string headquarters, string site, string phoneNumber, string emailAddress, string accomodationID, string password)
        {
            this.name = name;
            this.company = company;
            this.contact = contact;
            this.vatNumber = vatNumber;
            this.headquarters = headquarters;
            this.site = site;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
            this.accomodationID = accomodationID;
            this.password = password;
        }
        /// <summary>
        /// Accomodation osztály üres konstruktora
        /// </summary>
        public Accomodation()
        {

        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Szálláshely neve
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        /// <summary>
        /// Szálláshelyet üzemeltető cég neve
        /// </summary>
        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }
        /// <summary>
        /// Szálláshely kontakt személye
        /// </summary>
        public string Contact
        {
            get
            {
                return contact;
            }
            set
            {
                contact = value;
            }
        }
        /// <summary>
        /// Szálláshely adószáma
        /// </summary>
        public string VatNumber
        {
            get
            {
                return vatNumber;
            }
            set
            {
                vatNumber = value;
            }
        }
        /// <summary>
        /// Szálláshely székhelye
        /// </summary>
        public string Headquarters
        {
            get
            {
                return headquarters;
            }
            set
            {
                headquarters = value;
            }
        }
        /// <summary>
        /// Szálláshely telephelye
        /// </summary>
        public string Site
        {
            get
            {
                return site;
            }
            set
            {
                site = value;
            }
        }
        /// <summary>
        /// Szálláshely telefonszáma
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        /// <summary>
        /// Szálláshely e-mail címe
        /// </summary>
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                emailAddress = value;
            }
        }
        /// <summary>
        /// Szálláshely szállásazonosítója
        /// </summary>
        public string AccomodationID
        {
            get
            {
                return accomodationID;
            }
            set
            {
                accomodationID = value;
            }
        }
        /// <summary>
        /// Szálláshely szállásazonosítójához tartozó jelszava
        /// </summary>
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Accomodation osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja az Accomodation típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{name} {company} {contact} {vatNumber} {headquarters} {site} {phoneNumber} {emailAddress} {accomodationID} {password}";
        }

        #endregion
    }
}
