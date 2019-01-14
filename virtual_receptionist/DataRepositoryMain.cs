using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace virtual_receptionist.Model
{
    /// <summary>
    /// Az alkalmazáshoz szükséges adatokat tároló (adattár) osztály, amely az üzleti logikáért felel
    /// </summary>
    public partial class DataRepository
    {
        #region Adattagok

        /// <summary>
        /// Adatbázis kapcsolatot létrehozó mező
        /// </summary>
        private MySqlConnection mySqlConnection;
        /// <summary>
        /// SQL utasítást vágrehajtó mező
        /// </summary>
        private MySqlCommand mySqlCommand;
        /// <summary>
        /// Adatbázis adatot olvasó mező
        /// </summary>
        private MySqlDataReader mySqlDataReader;
        /// <summary>
        /// Adatszerkezeteket adattal feltöltő osztály egy példánya
        /// </summary>
        private MySqlDataAdapter mySqlDataAdapter;
        /// <summary>
        /// SQL DML és DDL parancsokat  végrehajtó osztály egy példánya
        /// </summary>
        private MySqlCommandBuilder mySqlCommandBuilder;
        /// <summary>
        /// Számlázási tételeket tartalmazó adatszerkezet
        /// </summary>
        private List<BillingItems> billingItems;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Adattár konstruktora
        /// </summary>
        public DataRepository()
        {
            mySqlConnection = new MySqlConnection()
            {
                ConnectionString = $"SERVER=127.0.0.1;DATABASE=virtual_receptionist;UID=root;PASSWORD=;PORT=3306"
            };

            billingItems = new List<BillingItems>();
        }

        #endregion
    }
}
