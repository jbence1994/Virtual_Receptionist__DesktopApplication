using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_receptionist.Model
{
    /// <summary>
    /// Magyarországi irányítószámok és települések modell osztálya
    /// </summary>
    public class HungarianZipCodesAndCities
    {
        #region Adattagok

        /// <summary>
        /// Település irányítószáma
        /// </summary>
        private string zipCode;
        /// <summary>
        /// Település neve
        /// </summary>
        private string city;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// HungarianZipCodesAndCities osztály konstruktora
        /// </summary>
        public HungarianZipCodesAndCities(string zipCode, string city)
        {
            this.zipCode = zipCode;
            this.city = city;
        }
        /// <summary>
        /// HungarianZipCodesAndCities osztály üres konstruktora
        /// </summary>
        public HungarianZipCodesAndCities()
        {

        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Település irányítószáma
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
        /// Település neve
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

        #endregion

        #region Metódusok

        /// <summary>
        /// HungarianZipCodesAndCities osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a HungarianZipCodesAndCities típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{zipCode} {city}";
        }

        #endregion
    }
}
