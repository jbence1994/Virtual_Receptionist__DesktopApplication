namespace virtual_receptionist.Model.Entity
{
    /// <summary>
    /// Vendég egyed absztrakt modell osztálya
    /// </summary>
    public abstract class Guest
    {
        #region Adattagok

        /// <summary>
        /// Vendég azonosítója
        /// </summary>
        protected int id;

        /// <summary>
        /// Vendég neve
        /// </summary>
        protected string name;

        /// <summary>
        /// Vendég száramázási országának neve
        /// </summary>
        protected string country;

        /// <summary>
        /// Vendég lakhelyének irányítószáma
        /// </summary>
        protected string zipCode;

        /// <summary>
        /// Vendég lakhelyének települése
        /// </summary>
        protected string city;

        /// <summary>
        /// Vendég lakhelyének címe (utca, házszám)
        /// </summary>
        protected string address;

        /// <summary>
        /// Vendég telefonszáma
        /// </summary>
        protected string phoneNumber;

        /// <summary>
        /// Vendég e-mail címe
        /// </summary>
        protected string emailAddress;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Guest osztály konstruktora
        /// </summary>
        /// <param name="id">Vendég azonosítója</param>
        /// <param name="name">Vendég neve</param>
        /// <param name="country">Vendég száramázási országának neve</param>
        /// <param name="zipCode">Vendég lakhelyének irányítószáma</param>
        /// <param name="city">Vendég lakhelyének települése</param>
        /// <param name="address">Vendég lakhelyének címe (utca, házszám)</param>
        /// <param name="phoneNumber">Vendég telefonszáma</param>
        /// <param name="emailAddress">Vendég e-mail címe</param>
        public Guest(int id, string name, string country, string zipCode, string city, string address,
            string phoneNumber,
            string emailAddress)
        {
            this.id = id;
            this.name = name;
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
    }
}
