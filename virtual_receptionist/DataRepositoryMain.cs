using System.Collections.Generic;

namespace virtual_receptionist.Model
{
    /// <summary>
    /// Az alkalmazáshoz szükséges adatokat tároló (adattár) osztály, amely az üzleti logikáért felel
    /// </summary>
    public partial class DataRepository
    {
        #region Adattagok

        /// <summary>
        /// Adatbázis kapcsolódást és CRUD műveleteket megvalósító ORM osztály egy példánya
        /// </summary>
        private Database database;
        /// <summary>
        /// Számlázási tételeket tartalmazó adatszerkezet
        /// </summary>
        private List<BillingItems> billingItems;
        /// <summary>
        /// Vendégeket tartalmazó adatszerkezet
        /// </summary>
        private List<Guest> guests;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Konstruktor
        /// </summary>
        public DataRepository()
        {
            database = new Database();
            billingItems = new List<BillingItems>();
            guests = new List<Guest>();
        }

        #endregion
    }
}
