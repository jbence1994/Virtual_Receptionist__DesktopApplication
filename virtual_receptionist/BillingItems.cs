using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_receptionist.Model
{
    /// <summary>
    /// Számlázási tételek modell osztálya
    /// </summary>
    public class BillingItems
    {
        /// <summary>
        /// Számlázási tétel neve
        /// </summary>
        private string name;
        /// <summary>
        /// Számlázási tétel kategóriája
        /// </summary>
        private string category;
        /// <summary>
        /// Számlázási tétel ÁFA-kulcsának értéke
        /// </summary>
        private double vat;
        /// <summary>
        /// Számlázási tétel egysége
        /// </summary>
        private string unit;
        /// <summary>
        /// Számlázási tétel összege (ára)
        /// </summary>
        private double price;

        #region Konstruktorok

        /// <summary>
        /// Üres konstruktor
        /// </summary>
        public BillingItems()
        {

        }
        /// <summary>
        /// Konstruktor
        /// </summary>
        public BillingItems(string name, string category, double vat, string unit, double price)
        {
            this.name = name;
            this.category = category;
            this.vat = vat;
            this.unit = unit;
            this.price = price;
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Számlázási tétel neve
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
        /// Számlázási tétel kategóriája
        /// </summary>
        private string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        /// <summary>
        /// Számlázási tétel ÁFA-kulcsának értéke
        /// </summary>
        private double Vat
        {
            get
            {
                return vat;
            }
            set
            {
                vat = value;
            }
        }
        /// <summary>
        /// Számlázási tétel egysége
        /// </summary>
        private string Unit
        {
            get
            {
                return unit;
            }
            set
            {
                unit = value;
            }
        }
        /// <summary>
        /// Számlázási tétel összege (ára)
        /// </summary>
        private double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// BillingItems osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a BillingItems típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{name} {category} {vat} {unit} {price}";
        }

        #endregion
    }
}
