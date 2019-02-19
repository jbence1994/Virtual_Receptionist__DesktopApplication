namespace virtual_receptionist.Model.Entity
{
    /// <summary>
    /// Számlázási tételek kateógria modell osztálya
    /// </summary>
    public class BillingItemCategory
    {
        #region Adattagok

        /// <summary>
        /// Számlázási tétel kategória ÁFA-kulcsának értéke
        /// </summary>
        private double vat;

        /// <summary>
        /// Számlázási tétel kategóriájának egysége
        /// </summary>
        private string unit;

        /// <summary>
        /// Számlázási tétel kategóriának az összege ára
        /// </summary>
        private double price;

        #endregion

        #region Konstruktor

        /// <summary>
        /// BillingItemCategory osztály konstruktora
        /// </summary>
        /// <param name="vat">Számlázási tétel kategória ÁFA-kulcsának értéke</param>
        /// <param name="unit">Számlázási tétel kategóriájának egysége</param>
        /// <param name="price">Számlázási tétel kategóriának az összege ára</param>
        public BillingItemCategory(double vat, string unit, double price)
        {
            this.vat = vat;
            this.unit = unit;
            this.price = price;
        }

        #endregion

        #region Getter és setter tulajdonságok

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

        /// <summary>
        /// Számlázási tétel kategóriának az összege ára
        /// </summary>
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// BillingItemCategory osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a BillingItemCategory típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{vat} {unit} {price}";
        }

        #endregion
    }
}
