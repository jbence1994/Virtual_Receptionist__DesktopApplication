namespace virtual_receptionist.Model.Entity
{
    /// <summary>
    /// Számlázási tételek modell osztálya
    /// </summary>
    public class BillingItem
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

        /// <summary>
        /// Számlázási tétel mennyisége
        /// </summary>
        private int quantity;

        #region Konstruktorok

        /// <summary>
        /// Számlázási tételek modell osztály konstrukora
        /// </summary>
        /// <param name="name">Számlázási tétel neve</param>
        /// <param name="category">Számlázási tétel kategóriája</param>
        /// <param name="vat">Számlázási tétel ÁFA-kulcsának értéke</param>
        /// <param name="unit">Számlázási tétel egysége</param>
        /// <param name="price">Számlázási tétel összege (ára)</param>
        public BillingItem(string name, string category, double vat, string unit, double price)
        {
            this.name = name;
            this.category = category;
            this.vat = vat;
            this.unit = unit;
            this.price = price;
        }

        /// <summary>
        /// Számlázási tételek modell osztály konstrukora
        /// </summary>
        /// <param name="name">Számlázási tétel neve</param>
        /// <param name="unit">Számlázási tétel egysége</param>
        /// <param name="price">Számlázási tétel összege (ára)</param>
        /// <param name="quantity">Számlázási tétel mennyisége</param>
        public BillingItem(string name, string unit, double price, int quantity)
        {
            this.name = name;
            this.unit = unit;
            this.price = price;
            this.quantity = quantity;
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Számlázási tétel neve
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Számlázási tétel kategóriája
        /// </summary>
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        /// <summary>
        /// Számlázási tétel ÁFA-kulcsának értéke
        /// </summary>
        public double Vat
        {
            get { return vat; }
            set { vat = value; }
        }

        /// <summary>
        /// Számlázási tétel egysége
        /// </summary>
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        /// <summary>
        /// Számlázási tétel összege (ára)
        /// </summary>
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Számlázási tétel mennyisége
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// BillingItems osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a BillingItems típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{name} {category} {vat} {unit} {price} {quantity}";
        }

        #endregion
    }
}
