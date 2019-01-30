using System;

namespace virtual_receptionist.Model
{
    /// <summary>
    /// Magánvendég modell osztálya
    /// </summary>
    public class PrivateGuest : Guest
    {
        #region Adattagok

        /// <summary>
        /// Magánvendég útlevél vagy személyi igazolvány száma
        /// </summary>
        private string documentNumber;

        /// <summary>
        /// Magánvendég állampolgársága
        /// </summary>
        private string citizenship;

        /// <summary>
        /// Magánvendég születési ideje
        /// </summary>
        private string birthDate;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// PrivateGuest osztály konstruktora
        /// </summary>
        /// <param name="name">Magánvendég neve</param>
        /// <param name="documentNumber">Magánvendég útlevelének vagy személyi igazolványának száma</param>
        /// <param name="citizenship">Magánvendég állampolgársága</param>
        /// <param name="birthDate">Magánvendég születési ideje</param>
        /// <param name="country">Magánvendég száramázási országának neve</param>
        /// <param name="zipCode">Magánvendég lakhelyének irányítószáma</param>
        /// <param name="city">Magánvendég lakhelyének települése</param>
        /// <param name="address">Magánvendég lakhelyének címe (utca, házszám)</param>
        /// <param name="phoneNumber">Magánvendég telefonszáma</param>
        /// <param name="emailAddress">Magánvendég e-mail címe</param>
        public PrivateGuest(string name, string documentNumber, string citizenship, string birthDate, string country,
            string zipCode,
            string city,
            string address, string phoneNumber,
            string emailAddress) : base(name, country, zipCode, city, address, phoneNumber, emailAddress)
        {
            this.documentNumber = documentNumber;
            this.citizenship = citizenship;
            this.birthDate = birthDate;
        }

        /// <summary>
        /// PrivateGuest osztály üres konstruktora
        /// </summary>
        public PrivateGuest()
        {

        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Magánvendég útlevél vagy személyi igazolvány száma
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

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
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
                $"{name} {documentNumber} {citizenship} {birthDate} {country} {zipCode} {city} {address} {phoneNumber} {emailAddress}";
        }

        #endregion
    }
}
