using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_receptionist
{
    /// <summary>
    /// Vendég egyed modell osztálya
    /// </summary>
    public class Guest
    {
        #region Adattagok

        /// <summary>
        /// Vendég neve
        /// </summary>
        private string name;
        /// <summary>
        /// Vendég nemzetisége
        /// </summary>
        private bool nationality;
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
        /// Vállalati vendég adószáma
        /// </summary>
        private string vatNumber;
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
        /// Guest osztály konstruktora (vállalati vendég esetén)
        /// </summary>
        /// <param name="name">Vendég neve</param>
        /// <param name="nationality">Vendég nemzetisége</param>
        /// <param name="country">Vendég száramázási országának neve</param>
        /// <param name="zipCode">Vendég lakhelyének irányítószáma</param>
        /// <param name="city">Vendég lakhelyének települése</param>
        /// <param name="address">Vendég lakhelyének címe (utca, házszám)</param>
        /// <param name="vatNumber">Céges vendég adószáma</param>
        /// <param name="phoneNumber">Vendég telefonszáma</param>
        /// <param name="emailAddress">Vendég e-mail címe</param>
        public Guest(string name, bool nationality, string country, string zipCode, string city, string address, string vatNumber, string phoneNumber, string emailAddress)
        {
            this.name = name;
            this.nationality = nationality;
            this.country = country;
            this.zipCode = zipCode;
            this.city = city;
            this.address = address;
            this.vatNumber = vatNumber;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
        }
        /// <summary>
        /// Guest osztály konstruktora (magán vendég esetén)
        /// </summary>
        /// <param name="name">Vendég neve</param>
        ///<param name="nationality">Vendég nemzetisége</param>
        /// <param name="country">Vendég száramázási országának neve</param>
        /// <param name="zipCode">Vendég lakhelyének irányítószáma</param>
        /// <param name="city">Vendég lakhelyének települése</param>
        /// <param name="address">Vendég lakhelyének címe (utca, házszám)</param>
        /// <param name="vatNumber">Céges vendég adószáma</param>
        /// <param name="phoneNumber">Vendég telefonszáma</param>
        /// <param name="emailAddress">Vendég e-mail címe</param>
        public Guest(string name, bool nationality, string country, string zipCode, string city, string address, string phoneNumber, string emailAddress)
        {
            this.name = name;
            this.nationality = nationality;
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
        /// Vendég neve
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
        /// Vendég nemzetisége
        /// </summary>
        public bool Nationality
        {
            get
            {
                return nationality;
            }
            set
            {
                nationality = value;
            }
        }
        /// <summary>
        /// Vendég száramázási országának neve
        /// </summary>
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        /// <summary>
        /// Vendég lakhelyének irányítószáma
        /// </summary>
        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                zipCode = value;
            }
        }
        /// <summary>
        /// Vendég lakhelyének települése
        /// </summary>
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        /// <summary>
        /// Vendég lakhelyének címe (utca, házszám)
        /// </summary>
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        /// <summary>
        /// Céges vendég adószáma
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
        /// Vendég telefonszáma
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
        /// Vendég e-mail címe
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

        #endregion

        #region Metódusok

        /// <summary>
        /// Guest osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Guest típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            string nationality = string.Empty;

            if (this.nationality == true)
            {
                nationality = "belföldi";
            }
            else
            {
                nationality = "külföldi";
            }

            return name + " " + nationality + " " + country + " " + zipCode + " " + city + " " + address + " " + vatNumber + " " + phoneNumber + " " + emailAddress;
        }

        #endregion
    }
}
