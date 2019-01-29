using System.Windows.Forms;

namespace virtual_receptionist.Model
{
    /// <summary>
    /// Vállalati vendég modell osztálya
    /// </summary>
    public class CorporateGuest : Guest
    {
        #region Adattagok

        /// <summary>
        /// Vállalati vendég adószáma
        /// </summary>
        private string vatNumber;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// CorporateGuest osztály konstruktora
        /// </summary>
        /// <param name="name">Vállalati vendég cégneve</param>
        /// <param name="vatNumber">Vállalati vendég adószáma</param>
        /// <param name="country">Vállalati vendég országának neve</param>
        /// <param name="zipCode">Vállalati vendég irányítószáma</param>
        /// <param name="city">Vállalati vendég települése</param>
        /// <param name="address">Vállalati vendég címe (utca, házszám)</param>
        /// <param name="phoneNumber">Vállalati vendég telefonszáma</param>
        /// <param name="emailAddress">Vállalati vendég e-mail címe</param>
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
        /// Guest osztályból készült objektum string típusúvá alakítása
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
