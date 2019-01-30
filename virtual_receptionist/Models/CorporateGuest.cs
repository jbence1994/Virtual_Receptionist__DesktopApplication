using System.Windows.Forms;

namespace virtual_receptionist.Model
{
    /// <summary>
    /// Céges vendég modell osztálya
    /// </summary>
    public class CorporateGuest : Guest
    {
        #region Adattagok

        /// <summary>
        /// Céges vendég adószáma
        /// </summary>
        private string vatNumber;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// CorporateGuest osztály konstruktora
        /// </summary>
        /// <param name="name">Céges vendég cégneve</param>
        /// <param name="vatNumber">Céges vendég adószáma</param>
        /// <param name="country">Céges vendég országának neve</param>
        /// <param name="zipCode">Céges vendég irányítószáma</param>
        /// <param name="city">Céges vendég települése</param>
        /// <param name="address">Céges vendég címe (utca, házszám)</param>
        /// <param name="phoneNumber">Céges vendég telefonszáma</param>
        /// <param name="emailAddress">Céges vendég e-mail címe</param>
        public CorporateGuest(string name, string vatNumber, string country, string zipCode, string city,
            string address, string phoneNumber, string emailAddress) : base(name, country, zipCode, city, address,
            phoneNumber, emailAddress)
        {
            this.vatNumber = vatNumber;
        }

        /// <summary>
        /// CorporateGuest osztály üres konstruktora
        /// </summary>
        public CorporateGuest()
        {

        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Céges vendég adószáma
        /// </summary>
        public string VatNumber
        {
            get { return vatNumber; }
            set { vatNumber = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// CorporateGuest osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Guest típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return
                $"{name} {vatNumber} {country} {zipCode} {city} {address} {phoneNumber} {emailAddress}";
        }

        #endregion
    }
}
