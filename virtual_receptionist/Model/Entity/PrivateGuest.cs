namespace virtual_receptionist.Model.Entity
{
    /// <summary>
    /// Vendég modell osztály
    /// </summary>
    public class PrivateGuest : Guest
    {
        #region Adattagok

        /// <summary>
        /// Vendég útlevél vagy személyi igazolvány száma
        /// </summary>
        private string documentNumber;

        /// <summary>
        /// Vendég állampolgársága
        /// </summary>
        private string citizenship;

        /// <summary>
        /// Vendég születési ideje
        /// </summary>
        private string birthDate;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// PrivateGuest osztály konstruktora
        /// </summary>
        /// <param name="id">Vendég azonosítója</param>
        /// <param name="name">Vendég neve</param>
        /// <param name="documentNumber">Vendég útlevelének vagy személyi igazolványának száma</param>
        /// <param name="citizenship">Vendég állampolgársága</param>
        /// <param name="birthDate">Vendég születési ideje</param>
        /// <param name="country">Vendég száramázási országának neve</param>
        /// <param name="zipCode">Vendég lakhelyének irányítószáma</param>
        /// <param name="city">Vendég lakhelyének települése</param>
        /// <param name="address">Vendég lakhelyének címe (utca, házszám)</param>
        /// <param name="phoneNumber">Vendég telefonszáma</param>
        /// <param name="emailAddress">Vendég e-mail címe</param>
        public PrivateGuest(int id, string name, string documentNumber, string citizenship, string birthDate,
            string country,
            string zipCode,
            string city,
            string address, string phoneNumber,
            string emailAddress) : base(id, name, country, zipCode, city, address, phoneNumber, emailAddress)
        {
            this.documentNumber = documentNumber;
            this.citizenship = citizenship;
            this.birthDate = birthDate;
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Vendég útlevél vagy személyi igazolvány száma
        /// </summary>
        public string DocumentNumber
        {
            get { return documentNumber; }
            set { documentNumber = value; }
        }

        /// <summary>
        /// Vendég állampolgársága
        /// </summary>
        public string Citizenship
        {
            get { return citizenship; }
            set { citizenship = value; }
        }

        /// <summary>
        /// Vendég születési ideje
        /// </summary>
        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// PrivateGuest osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Guest típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return
                $"{id} {name} {documentNumber} {citizenship} {birthDate} {country} {zipCode} {city} {address} {phoneNumber} {emailAddress}";
        }

        #endregion
    }
}
