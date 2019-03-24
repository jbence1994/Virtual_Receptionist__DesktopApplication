namespace virtual_receptionist.Repositories.Models
{
    /// <summary>
    /// Számlázási tételek kateógria egyed
    /// </summary>
    public class BillingItemCategory
    {
        #region Adattagok

        /// <summary>
        /// Számlázási tétel kategórianeve
        /// </summary>
        private string name;

        /// <summary>
        /// Számlázási tétel kategória ÁFA-kulcsának értéke
        /// </summary>
        private double vat;

        /// <summary>
        /// Számlázási tétel kategóriájának egysége
        /// </summary>
        private string unit;

        #endregion

        #region Konstruktor

        /// <summary>
        /// BillingItemCategory osztály konstruktora
        /// </summary>
        /// <param name="name">Számlázási tétel kategórianeve</param>
        /// <param name="vat">Számlázási tétel kategória ÁFA-kulcsának értéke</param>
        /// <param name="unit">Számlázási tétel kategóriájának egysége</param>
        public BillingItemCategory(string name, double vat, string unit)
        {
            this.name = name;
            this.vat = vat;
            this.unit = unit;
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Számlázási tétel kategórianeve
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Számlázási tétel kategória ÁFA-kulcsának értéke
        /// </summary>
        public double VAT
        {
            get { return vat; }
            set { vat = value; }
        }

        /// <summary>
        /// Számlázási tétel kategóriájának egysége
        /// </summary>
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// BillingItemCategory osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a BillingItemCategory típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{name} {vat} {unit}";
        }

        #endregion
    }
}
