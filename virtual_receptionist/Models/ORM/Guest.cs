namespace virtual_receptionist.Models.ORM
{
    /// <summary>
    /// Vendég egyed modell osztálya
    /// </summary>
    public class Guest
    {
        #region Adattagok

        /// <summary>
        /// Vendég azonosítója
        /// </summary>
        private int id;

        /// <summary>
        /// Vendég neve
        /// </summary>
        private string name;

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

        /// <summary>
        /// Vendég száramázási országának neve
        /// </summary>
        private string country;

        /// <summary>
        /// Vendég lakhelyének irányítószáma
        /// </summary>
        private string zipCode;

        /// <summary>
        /// Vendég lakhelyének települése
        /// </summary>
        private string city;

        /// <summary>
        /// Vendég lakhelyének címe (utca, házszám)
        /// </summary>
        private string address;

        /// <summary>
        /// Vendég telefonszáma
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// Vendég e-mail címe
        /// </summary>
        private string emailAddress;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Guest osztály konstruktora
        /// </summary>
        /// <param name="id">Vendég azonosítója</param>
        /// <param name="name">Vendég neve</param>
        /// <param name="documentNumber">Vendég útlevél vagy személyi igazolvány száma</param>
        /// <param name="citizenship">Vendég állampolgársága</param>
        /// <param name="birthDate">Vendég születési ideje</param>
        /// <param name="country">Vendég száramázási országának neve</param>
        /// <param name="zipCode">Vendég lakhelyének irányítószáma</param>
        /// <param name="city">Vendég lakhelyének települése</param>
        /// <param name="address">Vendég lakhelyének címe (utca, házszám)</param>
        /// <param name="phoneNumber">Vendég telefonszáma</param>
        /// <param name="emailAddress">Vendég e-mail címe</param>
        public Guest(int id, string name, string documentNumber, string citizenship, string birthDate, string country,
            string zipCode, string city, string address,
            string phoneNumber,
            string emailAddress)
        {
            this.id = id;
            this.name = name;
            this.documentNumber = documentNumber;
            this.citizenship = citizenship;
            this.birthDate = birthDate;
            this.country = country;
            this.zipCode = zipCode;
            this.city = city;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
        }

        /// <summary>
        /// Guest osztály üres konstruktora
        /// </summary>
        public Guest()
        {
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Vendég azonosítója
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Vendég neve
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

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

        /// <summary>
        /// Vendég száramázási országának neve
        /// </summary>
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        /// <summary>
        /// Vendég lakhelyének irányítószáma
        /// </summary>
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        /// <summary>
        /// Vendég lakhelyének települése
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// Vendég lakhelyének címe (utca, házszám)
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Vendég telefonszáma
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        /// <summary>
        /// Vendég e-mail címe
        /// </summary>
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Guest osztályból készült objektum string típusúvá alakítása
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
