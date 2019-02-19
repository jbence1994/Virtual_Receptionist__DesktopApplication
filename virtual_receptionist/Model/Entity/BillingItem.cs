namespace virtual_receptionist.Model.Entity
{
    /// <summary>
    /// Számlázási tételek modell osztálya
    /// </summary>
    public class BillingItem
    {
        #region Adattagok

        /// <summary>
        /// Számlázási tétel neve
        /// </summary>
        private string name;

        /// <summary>
        /// Számlázási tétel kategóriája
        /// </summary>
        private BillingItemCategory category;

        /// <summary>
        /// Számlázási tétel mennyisége
        /// </summary>
        private int quantity;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Számlázási tételek modell osztály konstrukora
        /// </summary>
        /// <param name="name">Számlázási tétel neve</param>
        /// <param name="category">Számlázási tétel kategóriája</param>
        public BillingItem(string name, BillingItemCategory category)
        {
            this.name = name;
            this.category = category;
        }

        /// <summary>
        /// Számlázási tételek modell osztály konstrukora
        /// </summary>
        /// <param name="name">Számlázási tétel neve</param>
        /// <param name="category">Számlázási tétel kategóriája</param>
        /// <param name="quantity">Számlázási tétel mennyisége</param>
        public BillingItem(string name, BillingItemCategory category, int quantity)
        {
            this.name = name;
            this.category = category;
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
        public BillingItemCategory Category
        {
            get { return category; }
            set { category = value; }
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
            return $"{name} {category} {category} {quantity}";
        }

        #endregion
    }
}
