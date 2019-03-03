using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_receptionist.Models.ORM
{
    /// <summary>
    /// Szálláshely egyed
    /// </summary>
    public class Accomodation
    {
        #region Adattagok

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

        #region Konstruktorok

        /// <summary>
        /// Accomodation osztály konstruktora
        /// </summary>
        /// <param name="id">Szálláshely azonosítója</param>
        /// <param name="accomodationName">Szálláshely neve</param>
        /// <param name="companyName">Szálláshely cégneve</param>
        /// <param name="contact">Szálláshely képviselője</param>
        /// <param name="vatNumber">Szálláshely adószáma</param>
        /// <param name="headquarters">Szálláshely székhelye</param>
        /// <param name="site">Szálláshely telephelye</param>
        /// <param name="phoneNumber">Szálláshely telefonszáma</param>
        /// <param name="emailAddress">Szálláshely e-mail címe</param>
        /// <param name="accomodationID">Szálláshely egyedi szállásazonosítója</param>
        /// <param name="password">Szálláshely regisztrációjához tartozó jelszó</param>
        public Accomodation(int id, string accomodationName, string companyName, string contact, string vatNumber,
            string headquarters, string site,
            string phoneNumber, string emailAddress, string accomodationID, string password)
        {
            this.id = id;
            this.accomodationName = accomodationName;
            this.companyName = companyName;
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
        }

        /// <summary>
        /// Szálláshely regisztrációjához tartozó jelszó
        /// </summary>
        public string Password
        {
            get { return password; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Accomodation osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja az Accomodation típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return
                $"{id} {accomodationName} {companyName} {contact} {vatNumber} {headquarters} {site} {phoneNumber} {emailAddress}";
        }

        #endregion
    }
}
