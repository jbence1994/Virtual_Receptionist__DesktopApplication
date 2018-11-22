using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_receptionist
{
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
        private string nationality;
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
        /// Céges vendég adószáma
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
        /// Guest osztály konstruktora
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
        public Guest(string name, string nationality, string country, string zipCode, string city, string address, string vatNumber, string phoneNumber, string emailAddress)
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
        /// Guest osztály üres konstruktora
        /// </summary>
        public Guest()
        {

        }

        #endregion

        #region Metódusok
        
        #endregion
    }
}
