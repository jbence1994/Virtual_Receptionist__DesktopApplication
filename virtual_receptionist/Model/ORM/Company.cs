namespace virtual_receptionist.Model.ORM
{
    /// <summary>
    /// Cég egyed modell osztálya
    /// </summary>
    public class Company
    {
        #region Adattagok

        /// <summary>
        /// Cég azonosítója
        /// </summary>
        private int id;

        /// <summary>
        /// Cég neve
        /// </summary>
        private string name;

        /// <summary>
        /// Cég adószáma
        /// </summary>
        private string vatNumber;

        /// <summary>
        /// Cég székhely országának neve
        /// </summary>
        private string country;

        /// <summary>
        /// Cég székhely településének irányítószáma
        /// </summary>
        private string zipCode;

        /// <summary>
        /// Cég székhelyének települése
        /// </summary>
        private string city;

        /// <summary>
        /// Cég székhelyének címe (utca, házszám)
        /// </summary>
        private string address;

        /// <summary>
        /// Cég telefonszáma
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// Cég e-mail címe
        /// </summary>
        private string emailAddress;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Company osztály konstruktora
        /// </summary>
        ///<param name="id">Cég azonosítója</param>
        /// <param name="name">Cég neve</param>
        /// <param name="vatNumber">Cég adószáma</param>
        /// <param name="country">Cég székhely országának neve</param>
        /// <param name="zipCode">Cég székhely településének irányítószáma</param>
        /// <param name="city">Cég székhelyének települése</param>
        /// <param name="address">Cég székhelyének címe (utca, házszám)</param>
        /// <param name="phoneNumber">Cég telefonszáma</param>
        /// <param name="emailAddress">Cég e-mail címe</param>
        public Company(int id, string name, string vatNumber, string country, string zipCode, string city,
            string address, string phoneNumber, string emailAddress)
        {
            this.id = id;
            this.name = name;
            this.vatNumber = vatNumber;
            this.country = country;
            this.zipCode = zipCode;
            this.city = city;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
        }

        /// <summary>
        /// Company osztály üres konstruktora
        /// </summary>
        public Company()
        {
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Cég azonosítója
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Cég neve
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Cég adószáma
        /// </summary>
        public string VatNumber
        {
            get { return vatNumber; }
            set { vatNumber = value; }
        }

        /// <summary>
        /// Cég székhely országának neve
        /// </summary>
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        /// <summary>
        /// Cég székhely településének irányítószáma
        /// </summary>
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        /// <summary>
        /// Cég székhelyének települése
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// Cég székhelyének címe (utca, házszám)
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Cég telefonszáma
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        /// <summary>
        /// Cég e-mail címe
        /// </summary>
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Company osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Company típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return
                $"{id} {name} {vatNumber} {country} {zipCode} {city} {address} {phoneNumber} {emailAddress}";
        }

        #endregion
    }
}
