namespace virtual_receptionist
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
        private string telephoneNumber;
        /// <summary>
        /// Szálláshely e-mail címe
        /// </summary>
        private string emailAddress;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Accomodation osztály üres konstruktora
        /// </summary>
        public Accomodation()
        {

        }
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
        public Accomodation(string name, string company, string contact, string vatNumber, string headquarters, string site, string telephoneNumber, string emailAddress)
        {
            this.name = name;
            this.company = company;
            this.contact = contact;
            this.vatNumber = vatNumber;
            this.headquarters = headquarters;
            this.site = site;
            this.telephoneNumber = telephoneNumber;
            this.emailAddress = emailAddress;
        }

        #endregion

        #region
        
        #endregion
    }
}
